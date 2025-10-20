open System
open System.IO
open System.Text
open System.Text.Json
open System.Text.Json.Nodes
open System.Collections.Generic
open System.Text.RegularExpressions
open System.IO.Compression
open System.Formats.Tar
open Fabulous.AST
open type Fabulous.AST.Ast
open Fantomas.Core
module Syntax = Fantomas.Core.SyntaxOak


type JsiiDocs = { Summary: string option; Remarks: string option }

type JsiiTypeRef =
    | Primitive of string
    | Collection of kind: string * element: JsiiTypeRef
    | Fqn of string
    | Union of JsiiTypeRef list

type JsiiProperty =
    { Name: string
      Optional: bool
      Type: JsiiTypeRef
      Docs: JsiiDocs }

type BuilderOperation =
    { PropertyName: string
      MethodName: string
      OperationName: string
      ParameterType: string
      SetterExpr: string
      Docs: string list
      IsRequired: bool }

type BuilderDefinition =
    { BuilderName: string
      FunctionName: string
      ResourceName: string
      ResourceType: string
      ConfigType: string
      ModuleName: string
      Docs: string list
      Operations: BuilderOperation list
      RequiredProperties: JsiiProperty list }

type GeneratorOptions = {
    ProviderId: string
    ModuleName: string
    OutputNamespace: string
    PackageDirectory: string
    OutputRoot: string
}

let parseArgs (argv: string[]) =
    if argv.Length = 0 || (argv.Length = 1 && (argv.[0] = "--help" || argv.[0] = "-h")) then
        Error "Usage: --provider-id <id> --module-name <name> --namespace <ns> --package-dir <path> --output-root <path>"
    else
        try
            let dict = Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)

            let rec loop idx =
                if idx < argv.Length then
                    let key = argv.[idx]
                    if key.StartsWith("--") then
                        if idx + 1 >= argv.Length then
                            failwithf "Missing value for argument '%s'" key
                        else
                            dict[key.Substring(2)] <- argv.[idx + 1]
                            loop (idx + 2)
                    else
                        failwithf "Unexpected argument '%s'" key

            loop 0

            let get name =
                match dict.TryGetValue(name) with
                | true, value when String.IsNullOrWhiteSpace(value) |> not -> value
                | _ -> failwithf "Missing required argument '--%s'" name

            Ok { ProviderId = get "provider-id"
                 ModuleName = get "module-name"
                 OutputNamespace = get "namespace"
                 PackageDirectory = get "package-dir"
                 OutputRoot = get "output-root" }
        with ex -> Error ex.Message

let loadJsii (tarballPath: string) =
    use stream = File.OpenRead(tarballPath)
    use gzip = new GZipStream(stream, CompressionMode.Decompress)
    use reader = new TarReader(gzip)

    let mutable entry = reader.GetNextEntry()
    let mutable content = None

    while entry <> null && content.IsNone do
        if entry.Name = "package/.jsii" then
            use ms = new MemoryStream()
            entry.DataStream.CopyTo(ms)
            content <- Some(Encoding.UTF8.GetString(ms.ToArray()))

        entry <- reader.GetNextEntry()

    content |> Option.defaultWith(fun () -> failwith $"Unable to locate .jsii within '{tarballPath}'.")

let parseJsonDocument (text: string) = JsonDocument.Parse(text)

let linkRegex = Regex(@"\{@link\s+([^}\s]+)(?:\s+([^}]+))?\}", RegexOptions.Compiled)

let appendAnchorSuffix (url: string) =
    let idx = url.IndexOf('#')
    if idx >= 0 && idx < url.Length - 1 then
        let prefix = url.Substring(0, idx + 1)
        let fragment = url.Substring(idx + 1)
        if fragment.EndsWith("-1", StringComparison.Ordinal) then
            url
        else
            prefix + fragment + "-1"
    else
        url

let normalizeDocText (text: string) =
    if String.IsNullOrWhiteSpace(text) then
        text
    else
        linkRegex.Replace(
            text,
            MatchEvaluator(fun m ->
                let url = m.Groups[1].Value
                let labelGroup = m.Groups[2]
                let label =
                    if labelGroup.Success then
                        let value = labelGroup.Value.Trim()
                        if String.IsNullOrEmpty(value) then None else Some value
                    else
                        None

                let adjustedUrl = appendAnchorSuffix url
                match label with
                | Some l when String.IsNullOrWhiteSpace(l) |> not -> $"<a href=\"{adjustedUrl}\">{l}</a>"
                | _ -> $"<a href=\"{adjustedUrl}\">{adjustedUrl}</a>"))

let makeXmlDocs (segments: string list) =
    segments
    |> List.map (fun line -> line.Trim())
    |> List.filter (String.IsNullOrWhiteSpace >> not)
    |> function
        | [] -> []
        | lines ->
            let summary = String.Join(" ", lines)
            [ "<summary>"; summary; "</summary>" ]



let buildTypeMap packageDir assemblyName =
    let map = Dictionary<string, string>()
    let codeDir = Path.Combine(packageDir, assemblyName)
    if Directory.Exists(codeDir) then
        let classRegex = Regex(@"\[JsiiClass\(nativeType: typeof\(([^)]+)\),\s*fullyQualifiedName:\s*""([^""]+)""")
        let byValueRegex = Regex(@"\[JsiiByValue\(fqn:\s*""([^""]+)""\)\]\s*public class ([^\s]+)")
        let namespaceRegex = Regex(@"namespace\s+([^\s]+)")

        for file in Directory.EnumerateFiles(codeDir, "*.cs", SearchOption.AllDirectories) do
            let content = File.ReadAllText(file)
            for m in classRegex.Matches(content) do
                let typeName = m.Groups[1].Value
                let fqn = m.Groups[2].Value
                map[fqn] <- typeName

            let nsMatch = namespaceRegex.Match(content)
            if nsMatch.Success then
                let namespaceName = nsMatch.Groups[1].Value
                for m in byValueRegex.Matches(content) do
                    let fqn = m.Groups[1].Value
                    let className = m.Groups[2].Value
                    let typeName = $"{namespaceName}.{className}"
                    map[fqn] <- typeName

    map

let tryGetProperty (element: JsonElement) (name: string) =
    let mutable value = Unchecked.defaultof<JsonElement>
    if element.TryGetProperty(name, &value) then Some value else None

let getStringProperty (element: JsonElement) (name: string) =
    match tryGetProperty element name with
    | Some value -> value.GetString()
    | None -> null

let readDocs (element: JsonElement) =
    match tryGetProperty element "docs" with
    | Some docs ->
        let summary =
            match tryGetProperty docs "summary" with
            | Some value ->
                match value.GetString() with
                | null -> None
                | text ->
                    let normalized = normalizeDocText text
                    if String.IsNullOrWhiteSpace(normalized) then None else Some normalized
            | None -> None

        let remarks =
            match tryGetProperty docs "remarks" with
            | Some value ->
                match value.GetString() with
                | null -> None
                | text ->
                    let normalized = normalizeDocText text
                    if String.IsNullOrWhiteSpace(normalized) then None else Some normalized
            | None -> None

        { Summary = summary; Remarks = remarks }
    | None -> { Summary = None; Remarks = None }

let capitalize (value: string) =
    if String.IsNullOrEmpty(value) then
        value
    else
        value.Substring(0, 1).ToUpperInvariant() + value.Substring(1)

let pascalCase (value: string) =
    if String.IsNullOrEmpty(value) then
        value
    else
        let sb = StringBuilder()

        let mutable lastWasSeparator = true

        for ch in value do
            if ch = '_' || ch = '-' || ch = ' ' then
                lastWasSeparator <- true
            elif lastWasSeparator then
                sb.Append(Char.ToUpperInvariant(ch)) |> ignore
                lastWasSeparator <- false
            else
                sb.Append(ch) |> ignore

        sb.ToString()

let camelCase (value: string) =
    if String.IsNullOrEmpty(value) then
        value
    else
        let pascal = pascalCase value
        pascal.Substring(0, 1).ToLowerInvariant() + pascal.Substring(1)

let snakeCase (value: string) =
    if String.IsNullOrEmpty(value) then
        value
    else
        let sb = StringBuilder()

        for i in 0 .. value.Length - 1 do
            let ch = value[i]

            if Char.IsUpper(ch) then
                if i > 0 && value[i - 1] <> '_' then
                    sb.Append('_') |> ignore

                sb.Append(Char.ToLowerInvariant(ch)) |> ignore
            else
                sb.Append(ch) |> ignore

        sb.ToString()

let rec parseTypeRef (element: JsonElement) =
    if element.ValueKind <> JsonValueKind.Object then
        failwith $"Unexpected type reference node kind: {element.ValueKind}"

    match tryGetProperty element "primitive" with
    | Some primitive -> Primitive(primitive.GetString())
    | None ->
        match tryGetProperty element "fqn" with
        | Some fqn -> Fqn(fqn.GetString())
        | None ->
            match tryGetProperty element "collection" with
            | Some collection ->
                let kind = collection.GetProperty("kind").GetString()
                let elementType = parseTypeRef(collection.GetProperty("elementtype"))
                Collection(kind, elementType)
            | None ->
                match tryGetProperty element "union" with
                | Some union ->
                    let types =
                        union.GetProperty("types").EnumerateArray()
                        |> Seq.map parseTypeRef
                        |> Seq.toList

                    Union types
                | None ->
                    failwith $"Unsupported type reference: {element}"

let rec mapTypeToSignature rootNamespace (typeMap: IReadOnlyDictionary<string, string>) =
    function
    | Primitive "string" -> "string"
    | Primitive "number" -> "double"
    | Primitive "boolean" -> "bool"
    | Primitive "any"
    | Primitive "json" -> "obj"
    | Primitive "date" -> "System.DateTime"
    | Primitive other -> other
    | Fqn fqn ->
        match typeMap.TryGetValue(fqn) with
        | true, typeName -> typeName
        | _ -> toDotnetType rootNamespace fqn
    | Collection("array", element)
    | Collection("list", element)
    | Collection("set", element) ->
        $"{mapTypeToSignature rootNamespace typeMap element} array"
    | Collection("map", element) ->
        $"System.Collections.Generic.IDictionary<string, {mapTypeToSignature rootNamespace typeMap element}>"
    | Collection(kind, _) ->
        failwith $"Unsupported collection kind '{kind}'."
    | Union _ -> "obj"

and describeType rootNamespace (typeMap: IReadOnlyDictionary<string, string>) =
    function
    | Primitive p -> p
    | Fqn fqn ->
        match typeMap.TryGetValue(fqn) with
        | true, typeName -> typeName
        | _ -> toDotnetType rootNamespace fqn
    | Collection("array", element) -> $"{describeType rootNamespace typeMap element}[]"
    | Collection("list", element) -> $"{describeType rootNamespace typeMap element} list"
    | Collection("set", element) -> $"{describeType rootNamespace typeMap element} set"
    | Collection("map", element) -> $"IDictionary<string, {describeType rootNamespace typeMap element}>"
    | Collection(kind, _) -> kind
    | Union types -> types |> List.map (describeType rootNamespace typeMap) |> String.concat " | "

and toDotnetType rootNamespace (fqn: string) =
    let parts = fqn.Split('.', StringSplitOptions.RemoveEmptyEntries)

    match parts with
    | [||] -> fqn
    | [| _; typeName |] -> $"{rootNamespace}.{typeName}"
    | _ ->
        let namespaceParts = parts |> Array.skip 1 |> Array.take (parts.Length - 2)
        let pascalNamespaces = namespaceParts |> Array.map capitalize
        let typeName = parts[parts.Length - 1]
        let ns =
            if pascalNamespaces.Length = 0 then
                rootNamespace
            else
                rootNamespace + "." + String.Join(".", pascalNamespaces)

        ns + "." + typeName

let unionDoc rootNamespace (typeMap: IReadOnlyDictionary<string, string>) typeRef =
    match typeRef with
    | Union types ->
        let description = types |> List.map (describeType rootNamespace typeMap) |> String.concat " | "
        Some $"Accepts: {description}"
    | _ -> None

let exprFromText (text: string) =
    let indented =
        text.Split('\n')
        |> Array.map(fun line -> "    " + line)
        |> String.concat "\n"

    let source = "module __Tmp\nlet __tmp =\n" + indented
    let oak, _ =
        CodeFormatter.ParseOakAsync(false, source)
        |> Async.RunSynchronously
        |> Array.head

    let moduleNode = oak.ModulesOrNamespaces.Head

    let bindingNode =
        match moduleNode.Declarations.Head with
        | Syntax.ModuleDecl.TopLevelBinding bindingNode -> bindingNode
        | _ -> failwith $"Expected binding for expression '{text}'."

    Ast.EscapeHatch(bindingNode.Expr)

let bindingFromText (text: string) =
    let source = "module __Tmp\n" + text
    let oak, _ =
        CodeFormatter.ParseOakAsync(false, source)
        |> Async.RunSynchronously
        |> Array.head

    let moduleNode = oak.ModulesOrNamespaces.Head

    match moduleNode.Declarations.Head with
    | Syntax.ModuleDecl.TopLevelBinding bindingNode -> Ast.EscapeHatch bindingNode
    | _ -> failwith $"Expected binding in '{text}'."

let typeFromText (text: string) =
    let source = "module __Tmp\n" + text
    let oak, _ =
        CodeFormatter.ParseOakAsync(false, source)
        |> Async.RunSynchronously
        |> Array.head

    let moduleNode = oak.ModulesOrNamespaces.Head

    match moduleNode.Declarations.Head with
    | Syntax.ModuleDecl.TypeDefn _ -> Ast.EscapeHatch(moduleNode.Declarations.Head)
    | other -> failwith $"Expected type definition in '{text}'. Found: {other.GetType().FullName}"

let parameterPattern (name: string) (typeName: string option) : WidgetBuilder<Syntax.Pattern> =
    match typeName with
    | Some t -> Ast.ParameterPat(name, t)
    | None -> Ast.ParameterPat(name)

let unitParameter (name: string) : WidgetBuilder<Syntax.Pattern> = Ast.ParameterPat(name, "unit")

let buildBuilderDefinition moduleName rootNamespace (typeMap: IReadOnlyDictionary<string, string>) baseType resourceType configType resourceName docs configProperties =
    let builderName = $"{resourceName}Builder"
    let functionName =
        if baseType = "cdktf.TerraformProvider" then
            "provider"
        else
            resourceName |> camelCase

    let createDocLines (prop: JsiiProperty) =
        [ prop.Docs.Summary; prop.Docs.Remarks; unionDoc rootNamespace typeMap prop.Type ]
        |> List.choose id
        |> List.collect(fun text ->
            text.Split('\n', StringSplitOptions.RemoveEmptyEntries)
            |> Array.map(fun line -> line.Trim())
            |> Array.filter(fun line -> String.IsNullOrWhiteSpace(line) |> not)
            |> Array.toList)
        |> makeXmlDocs

    let mkOperation methodName operationName propertyName docs parameterType setterExpr isRequired =
        { PropertyName = propertyName
          MethodName = methodName
          OperationName = operationName
          ParameterType = parameterType
          SetterExpr = setterExpr
          Docs = docs
          IsRequired = isRequired }

    let operations =
        configProperties
        |> List.collect(fun prop ->
            let propertyName = prop.Name |> pascalCase
            let methodName = propertyName
            let customName = prop.Name |> snakeCase
            let docs = createDocLines prop

            let defaultType = mapTypeToSignature rootNamespace typeMap prop.Type
            let defaultSetter = $"config.{propertyName} <- value"
            let required = not prop.Optional
            let defaultOp () = [ mkOperation methodName customName propertyName docs defaultType defaultSetter required ]

            match prop.Type with
            | Collection("map", element) ->
                match element with
                | Primitive "string" ->
                    let setter =
                        $"config.{propertyName} <- dict value"
                    [ mkOperation methodName customName propertyName docs "seq<string * string>" setter required ]
                | _ ->
                    let valueType = mapTypeToSignature rootNamespace typeMap element
                    let setter =
                        $"config.{propertyName} <- dict value"
                    [ mkOperation methodName customName propertyName docs $"seq<string * {valueType}>" setter required ]

            | Collection(kind, element) when kind = "array" || kind = "list" ->
                let elementType = mapTypeToSignature rootNamespace typeMap element
                let setter = $"config.{propertyName} <- (value |> Seq.toArray)"
                [ mkOperation methodName customName propertyName docs $"seq<{elementType}>" setter required ]

            | Union unionTypes ->
                let overOps =
                    unionTypes
                    |> List.choose(fun u ->
                        match u with
                        | Primitive "boolean" ->
                            Some(mkOperation methodName customName propertyName docs "bool" defaultSetter required)
                        | Primitive "number" ->
                            Some(mkOperation methodName customName propertyName docs "double" defaultSetter required)
                        | Primitive "string" ->
                            Some(mkOperation methodName customName propertyName docs "string" defaultSetter required)
                        | Primitive "any" ->
                            Some(mkOperation methodName customName propertyName docs "obj" defaultSetter required)
                        | Fqn f when f = "cdktf.IResolvable" ->
                            Some(mkOperation methodName customName propertyName docs "HashiCorp.Cdktf.IResolvable" defaultSetter required)
                        | Fqn f when typeMap.ContainsKey(f) ->
                            let resolved = mapTypeToSignature rootNamespace typeMap u
                            Some(mkOperation methodName customName propertyName docs resolved defaultSetter required)
                        | _ -> None)

                if overOps.IsEmpty then
                    defaultOp ()
                else
                    overOps

            | _ ->
                defaultOp ())

    let requiredProperties =
        configProperties |> List.filter (fun prop -> not prop.Optional)

    { BuilderName = builderName
      FunctionName = functionName
      ResourceName = resourceName
      ResourceType = resourceType
      ConfigType = configType
      ModuleName = moduleName
      Docs = makeXmlDocs docs
      Operations = operations
      RequiredProperties = requiredProperties }

let buildStateDeclaration (builder: BuilderDefinition) =
    let stateTypeName = $"{builder.ModuleName}.{builder.ResourceName}State"

    let typeParams =
        builder.RequiredProperties
        |> List.map(fun prop -> prop.Name |> pascalCase)

    let genericDecl =
        if typeParams.IsEmpty then
            ""
        else
            "<" + (typeParams |> List.map(fun name -> $"'{name}") |> String.concat ", ") + ">"

    let stateTypeString =
        $"type {stateTypeName}{genericDecl} = {{ assignments: ResizeArray<{builder.ConfigType} -> unit> }}"

    typeFromText stateTypeString

let buildBuilderType (builder: BuilderDefinition) =
    let constructor =
        Ast.Constructor(
            Ast.ParenPat(
                Ast.ParameterPat("logicalId", "string")
            )
        )

    let typeParams =
        builder.RequiredProperties
        |> List.map(fun prop -> prop.Name |> pascalCase)

    let stateTypeName = $"{builder.ModuleName}.{builder.ResourceName}State"

    let stateTypeWith args =
        if typeParams.IsEmpty then
            stateTypeName
        else
            stateTypeName + "<" + (String.concat ", " args) + ">"

    let initialStateExpr =
        if typeParams.IsEmpty then
            "{ assignments = ResizeArray() }"
        else
            let missingArgs = List.replicate typeParams.Length "Missing"
            let stateType = stateTypeWith missingArgs
            $"({{ assignments = ResizeArray() }} : {stateType})"

    let yieldMember =
        Ast.Member("_.Yield", Ast.ParenPat(Ast.TuplePat([ unitParameter "_" ])), exprFromText initialStateExpr)

    let zeroMember =
        Ast.Member("_.Zero", Ast.ParenPat(Ast.UnitPat()), exprFromText initialStateExpr)

    let customMembers =
        builder.Operations
        |> List.map(fun op ->
            let propertyParam = op.PropertyName
            let inputArgs =
                if typeParams.IsEmpty then
                    []
                else
                    typeParams
                    |> List.map(fun name ->
                        if op.IsRequired && name = propertyParam then "Missing" else $"'{name}")

            let outputArgs =
                if typeParams.IsEmpty then
                    []
                else
                    typeParams
                    |> List.map(fun name ->
                        if op.IsRequired && name = propertyParam then "Present" else $"'{name}")

            let inputStateType = stateTypeWith inputArgs
            let outputStateType = stateTypeWith outputArgs

            let tupleItems : WidgetBuilder<Syntax.Pattern> list =
                [ parameterPattern "state" (Some inputStateType)
                  parameterPattern "value" (Some op.ParameterType) ]

            let pattern = Ast.ParenPat(Ast.TuplePat(tupleItems :> seq<_>))

            let bodyText =
                if op.IsRequired && not typeParams.IsEmpty then
                    $"state.assignments.Add(fun config -> {op.SetterExpr})\nlet state' : {outputStateType} = {{ assignments = state.assignments }}\nstate'"
                else
                    $"state.assignments.Add(fun config -> {op.SetterExpr})\nstate"

            let body = exprFromText bodyText

            let memberBuilder = Ast.Member($"_.{op.MethodName}", pattern, body)

            let withDocs =
                if op.Docs.IsEmpty then
                    memberBuilder
                else
                    memberBuilder.xmlDocs(op.Docs)

            withDocs.attribute(Ast.Attribute("CustomOperation", Ast.String(op.OperationName))))

    let successStateType =
        if typeParams.IsEmpty then
            stateTypeName
        else
            stateTypeWith (List.replicate typeParams.Length "Present")

    let runPattern = Ast.ParenPat(Ast.TuplePat([ parameterPattern "state" (Some successStateType) ]))

    let runBody =
        exprFromText
            $"let config = {builder.ConfigType}()\nfor setter in state.assignments do setter config\n{builder.ResourceType}(StackContext.get(), logicalId, config)"

    let runMember = Ast.Member("_.Run", runPattern, runBody)

    let obsoleteMember =
        if typeParams.IsEmpty then
            None
        else
            let fallbackStateType = stateTypeWith (List.replicate typeParams.Length "_")
            let requiredNames =
                builder.RequiredProperties
                |> List.map(fun prop -> prop.Name |> snakeCase)
                |> String.concat ", "

            let message =
                $"{builder.ModuleName}.{builder.FunctionName}: missing required arguments. Must call: {requiredNames}."

            let pattern = Ast.ParenPat(Ast.TuplePat([ parameterPattern "_" (Some fallbackStateType) ]))
            let body = exprFromText $"Unchecked.defaultof<{builder.ResourceType}>"
            let memberBuilder = Ast.Member("_.Run", pattern, body)
            let attribute = Ast.Attribute("System.Obsolete", exprFromText $"(\"{message}\", true)")
            Some(memberBuilder.attribute(attribute))

    let typeDef =
        TypeDefn(builder.BuilderName, constructor) {
            yieldMember
            zeroMember
            for memberDef in customMembers do
                memberDef
            runMember
            match obsoleteMember with
            | Some m -> m
            | None -> ()
        }

    if builder.Docs.IsEmpty then
        typeDef
    else
        typeDef.xmlDocs(builder.Docs)

let buildFunction (builder: BuilderDefinition) =
    let binding =
        bindingFromText $"let {builder.FunctionName} logicalId = {builder.BuilderName}(logicalId)"

    Ast.AnyModuleDecl(binding)

let buildModule providerName (builders: BuilderDefinition list) =
    Module(providerName) {
        for builder in builders do
            yield buildStateDeclaration builder
            yield buildBuilderType builder |> Ast.AnyModuleDecl
            yield buildFunction builder
    }

let renderXmlDocs indentLevel (docs: string list) =
    if docs.IsEmpty then
        ""
    else
        let indent = String.replicate (indentLevel * 4) " "
        docs
        |> List.map(fun line -> indent + "/// " + line)
        |> String.concat Environment.NewLine

let computeTypeParams (builder: BuilderDefinition) =
    builder.RequiredProperties
    |> List.map(fun prop -> prop.Name |> pascalCase)

let stateTypeName (builder: BuilderDefinition) =
    $"{builder.ResourceName}State"

let formatStateType (builder: BuilderDefinition) (args: string list) =
    let name = stateTypeName builder
    if args.IsEmpty then name else name + "<" + (String.concat ", " args) + ">"

let renderStateType builder =
    let typeParams = computeTypeParams builder
    let generics =
        if typeParams.IsEmpty then
            ""
        else
            "<" + (typeParams |> List.map(fun name -> $"'{name}") |> String.concat ", ") + ">"

    $"type {stateTypeName builder}{generics} = {{ assignments: ResizeArray<{builder.ConfigType} -> unit> }}"

let initialStateExpr builder =
    let typeParams = computeTypeParams builder
    if typeParams.IsEmpty then
        "{ assignments = ResizeArray() }"
    else
        let missingArgs = typeParams |> List.map(fun _ -> "Missing")
        let stateType = formatStateType builder missingArgs
        $"({{ assignments = ResizeArray() }} : {stateType})"

let operationToString builder (op: BuilderOperation) =
    let indent2 = String.replicate 8 " "
    let indent3 = String.replicate 12 " "

    let docs = renderXmlDocs 2 op.Docs

    let typeParams = computeTypeParams builder
    let propertyParamName = op.PropertyName

    let inputArgs =
        if typeParams.IsEmpty then []
        else
            typeParams
            |> List.map(fun name ->
                if op.IsRequired && name = propertyParamName then "Missing" else $"'{name}")

    let outputArgs =
        if typeParams.IsEmpty then []
        else
            typeParams
            |> List.map(fun name ->
                if op.IsRequired && name = propertyParamName then "Present" else $"'{name}")

    let inputStateType = formatStateType builder inputArgs
    let outputStateType = formatStateType builder outputArgs

    let bodyLines =
        if op.IsRequired && not typeParams.IsEmpty then
            [
                $"{indent3}state.assignments.Add(fun config -> {op.SetterExpr})"
                $"{indent3}({{ assignments = state.assignments }} : {outputStateType})"
            ]
        else
            [
                $"{indent3}state.assignments.Add(fun config -> {op.SetterExpr})"
                $"{indent3}state : {outputStateType}"
            ]

    let header =
        [
            if docs <> "" then docs else ""
            $"{indent2}[<CustomOperation \"{op.OperationName}\">]"
            $"{indent2}member _.{op.MethodName}(state: {inputStateType}, value: {op.ParameterType}) : {outputStateType} ="
        ]
        |> List.filter (fun line -> line <> "")

    String.concat Environment.NewLine (header @ bodyLines)

let builderToString builder =
    let indent1 = String.replicate 4 " "
    let indent2 = String.replicate 8 " "
    let indent3 = String.replicate 12 " "
    let indent4 = String.replicate 16 " "

    let typeParams = computeTypeParams builder
    let missingArgs = if typeParams.IsEmpty then [] else typeParams |> List.map(fun _ -> "Missing")
    let successArgs = if typeParams.IsEmpty then [] else typeParams |> List.map(fun _ -> "Present")
    let fallbackArgs = if typeParams.IsEmpty then [] else typeParams |> List.map(fun _ -> "_")

    let successStateType = formatStateType builder successArgs
    let fallbackStateType = formatStateType builder fallbackArgs

    let requiredNames =
        builder.RequiredProperties
        |> List.map(fun prop -> prop.Name |> snakeCase)
        |> String.concat ", "

    let operationsText =
        builder.Operations
        |> List.map (operationToString builder)
        |> String.concat (Environment.NewLine + Environment.NewLine)

    let xmlDoc = renderXmlDocs 1 builder.Docs
    let xmlDocBlock = if xmlDoc = "" then "" else xmlDoc + Environment.NewLine

    let fallbackBlock =
        if builder.RequiredProperties.IsEmpty then
            ""
        else
            let message = $"{builder.ModuleName}.{builder.FunctionName}: missing required arguments. Must call: {requiredNames}."
            $"\n\n{indent2}[<CompilerMessage(\"{message}\", 9999, IsError = true)>]\n{indent2}member _.Run(_: {fallbackStateType}) : {builder.ResourceType} =\n{indent3}Unchecked.defaultof<{builder.ResourceType}>"

    $"{xmlDocBlock}{indent1}type {builder.BuilderName}(logicalId: string) =\n{indent2}member _.Yield(_: unit) : {formatStateType builder missingArgs} =\n{indent3}{initialStateExpr builder}\n\n{indent2}member _.Zero(()) : {formatStateType builder missingArgs} =\n{indent3}{initialStateExpr builder}\n\n{operationsText}\n\n{indent2}member _.Run(state: {successStateType}) : {builder.ResourceType} =\n{indent3}let config = {builder.ConfigType}()\n{indent3}for setter in state.assignments do\n{indent4}setter config\n{indent3}{builder.ResourceType}(StackContext.get (), logicalId, config){fallbackBlock}"

let resourceFileContent options builder =
    [
        "namespace Nelknet.Cdktf.Providers"
        ""
        "open System"
        "open System.Collections.Generic"
        "open HashiCorp.Cdktf"
        "open Nelknet.Cdktf"
        "open Nelknet.Cdktf.Internal"
        ""
        renderStateType builder
        ""
        builderToString builder
    ]
    |> List.filter (fun line -> not (String.IsNullOrEmpty(line)))
    |> String.concat Environment.NewLine
    |> fun text -> text + Environment.NewLine

let aggregatorContent options builders =
    let indent1 = String.replicate 4 " "
    let functions =
        builders
        |> List.map(fun builder ->
            $"{indent1}let {builder.FunctionName} logicalId = {builder.BuilderName}(logicalId)")
        |> String.concat Environment.NewLine

    [
        "namespace Nelknet.Cdktf.Providers"
        ""
        "open Nelknet.Cdktf"
        ""
        $"module {options.ModuleName} ="
        functions
    ]
    |> String.concat Environment.NewLine
    |> fun text -> text + Environment.NewLine

let generateProvider (options: GeneratorOptions) =
    let packageDir = Path.GetFullPath(options.PackageDirectory)

    if not (Directory.Exists(packageDir)) then
        failwith $"Provider directory '{packageDir}' not found. Run 'cdktf provider add {options.ProviderId}' first."

    let outputRoot = Path.GetFullPath(options.OutputRoot)

    let tarball =
        Directory.GetFiles(packageDir, "*.tgz")
        |> Array.tryHead
        |> Option.defaultWith(fun () -> failwith $"No provider package (.tgz) found in '{packageDir}'.")

    use json = loadJsii tarball |> parseJsonDocument

    let root = json.RootElement

    let targets = root.GetProperty("targets")
    let dotnetNamespace = targets.GetProperty("dotnet").GetProperty("namespace").GetString()
    let typeMap = buildTypeMap packageDir options.ProviderId

    let resolveType fqn =
        match typeMap.TryGetValue(fqn) with
        | true, typeName -> typeName
        | _ -> toDotnetType dotnetNamespace fqn

    let types = root.GetProperty("types")

    let interfaces =
        types.EnumerateObject()
        |> Seq.choose(fun typeProp ->
            let element = typeProp.Value

            match tryGetProperty element "kind" with
            | Some kind when kind.GetString() = "interface" ->
                let isDatatype =
                    match tryGetProperty element "datatype" with
                    | Some datatype when datatype.GetBoolean() -> true
                    | _ -> false

                if not isDatatype then
                    None
                else
                    let fqn = element.GetProperty("fqn").GetString()

                    let properties =
                        match tryGetProperty element "properties" with
                        | Some props ->
                            props.EnumerateArray()
                            |> Seq.map(fun propElem ->
                                let optional =
                                    match tryGetProperty propElem "optional" with
                                    | Some opt when opt.GetBoolean() -> true
                                    | _ -> false

                                { Name = propElem.GetProperty("name").GetString()
                                  Optional = optional
                                  Type = parseTypeRef(propElem.GetProperty("type"))
                                  Docs = readDocs propElem })
                            |> Seq.toList
                        | None -> []

                    Some(fqn, properties)
            | _ -> None)
        |> dict

    let classes =
        types.EnumerateObject()
        |> Seq.choose(fun typeProp ->
            let element = typeProp.Value

            match tryGetProperty element "kind" with
            | Some kind when kind.GetString() = "class" ->
                let baseType =
                    match tryGetProperty element "base" with
                    | Some baseElem -> Some(baseElem.GetString())
                    | None -> None

                let initializer =
                    match tryGetProperty element "initializer" with
                    | Some init ->
                        match tryGetProperty init "parameters" with
                        | Some parameters ->
                            parameters.EnumerateArray()
                            |> Seq.tryFind(fun param -> param.GetProperty("name").GetString() = "config")
                            |> Option.bind(fun param ->
                                let paramType = param.GetProperty("type")
                                match tryGetProperty paramType "fqn" with
                                | Some fqn -> Some(fqn.GetString())
                                | None -> None)
                        | None -> None
                    | None -> None

                let docs = readDocs element
                let fqn = element.GetProperty("fqn").GetString()

                Some(fqn, baseType, initializer, docs)
            | _ -> None)
        |> Seq.toList

    let resourceClasses =
        classes
        |> List.choose(fun (fqn, baseType, configFqn, docs) ->
            match baseType, configFqn with
            | Some baseType, Some config when
                baseType = "cdktf.TerraformResource"
                || baseType = "cdktf.TerraformDataSource"
                || baseType = "cdktf.TerraformProvider" ->
                if interfaces.ContainsKey(config) then
                    let resourceType = resolveType fqn
                    let configType = resolveType config
                    let resourceName = fqn.Split('.') |> Array.last

                    let docLines =
                        [ docs.Summary; docs.Remarks ]
                        |> List.choose id
                        |> List.collect(fun text ->
                            text.Split('\n', StringSplitOptions.RemoveEmptyEntries)
                            |> Array.map(fun line -> line.Trim())
                            |> Array.filter(fun line -> String.IsNullOrWhiteSpace(line) |> not)
                            |> Array.toList)

                    Some(struct {| BaseType = baseType
                                   ResourceType = resourceType
                                   ConfigType = configType
                                   ResourceName = resourceName
                                   ConfigFqn = config
                                   Docs = docLines |})
                else
                    None
            | _ -> None)
        |> List.ofSeq

    let builders =
        resourceClasses
        |> List.map(fun resource ->
            let props = interfaces[resource.ConfigFqn]
            buildBuilderDefinition options.ModuleName dotnetNamespace typeMap resource.BaseType resource.ResourceType resource.ConfigType resource.ResourceName resource.Docs props)

    let outputDir = outputRoot

    Directory.CreateDirectory(outputDir) |> ignore

    if Directory.Exists(outputDir) then
        Directory.GetFiles(outputDir, "*.fs", SearchOption.AllDirectories)
        |> Array.iter File.Delete

    for builder in builders do
        let fileName = $"{builder.ResourceName}.fs"
        let filePath = Path.Combine(outputDir, "Resources", fileName)
        Directory.CreateDirectory(Path.GetDirectoryName(filePath)) |> ignore
        let content = resourceFileContent options builder
        File.WriteAllText(filePath, content)
        printfn "Generated %s" filePath

    let aggregatorPath = Path.Combine(outputDir, $"{options.ModuleName}.Module.fs")
    let aggregator = aggregatorContent options builders
    File.WriteAllText(aggregatorPath, aggregator)
    printfn "Generated %s" aggregatorPath

[<EntryPoint>]
let main argv =
    match parseArgs argv with
    | Ok options ->
        try
            generateProvider options
            0
        with ex ->
            printfn "Code generation failed: %s" ex.Message
            1
    | Error message ->
        printfn "%s" message
        1
