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
      AssignmentExpr: string
      Docs: string list }

type BuilderDefinition =
    { BuilderName: string
      FunctionName: string
      ResourceType: string
      ConfigType: string
      Docs: string list
      Operations: BuilderOperation list }

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
                let text = value.GetString()
                if String.IsNullOrWhiteSpace(text) then None else Some text
            | None -> None

        let remarks =
            match tryGetProperty docs "remarks" with
            | Some value ->
                let text = value.GetString()
                if String.IsNullOrWhiteSpace(text) then None else Some text
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

let parameterPattern (name: string) (typeName: string option) : WidgetBuilder<Syntax.Pattern> =
    match typeName with
    | Some t -> Ast.ParameterPat(name, t)
    | None -> Ast.ParameterPat(name)

let unitParameter (name: string) : WidgetBuilder<Syntax.Pattern> = Ast.ParameterPat(name, "unit")

let buildBuilderDefinition rootNamespace (typeMap: IReadOnlyDictionary<string, string>) baseType resourceType configType resourceName docs configProperties =
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

    let mkOperation methodName operationName propertyName docs parameterType assignment =
        { PropertyName = propertyName
          MethodName = methodName
          OperationName = operationName
          ParameterType = parameterType
          AssignmentExpr = assignment
          Docs = docs }

    let operations =
        configProperties
        |> List.collect(fun prop ->
            let propertyName = prop.Name |> pascalCase
            let methodName = propertyName
            let customName = prop.Name |> snakeCase
            let docs = createDocLines prop

            let defaultType = mapTypeToSignature rootNamespace typeMap prop.Type
            let defaultAssignment = $"assignments.Add(\"{propertyName}\", box value)"
            let defaultOp () = [ mkOperation methodName customName propertyName docs defaultType defaultAssignment ]

            match prop.Type with
            | Collection("map", element) ->
                match element with
                | Primitive "string" ->
                    let assignment =
                        $"assignments.Add(\"{propertyName}\", box (dict value))"
                    [ mkOperation methodName customName propertyName docs "seq<string * string>" assignment ]
                | _ ->
                    let valueType = mapTypeToSignature rootNamespace typeMap element
                    let assignment =
                        $"assignments.Add(\"{propertyName}\", box (dict value))"
                    [ mkOperation methodName customName propertyName docs $"seq<string * {valueType}>" assignment ]

            | Collection(kind, element) when kind = "array" || kind = "list" ->
                let elementType = mapTypeToSignature rootNamespace typeMap element
                let assignment = $"assignments.Add(\"{propertyName}\", box (value |> Seq.toArray))"
                [ mkOperation methodName customName propertyName docs $"seq<{elementType}>" assignment ]

            | Union unionTypes ->
                let overOps =
                    unionTypes
                    |> List.choose(fun u ->
                        match u with
                        | Primitive "boolean" ->
                            Some(mkOperation methodName customName propertyName docs "bool" defaultAssignment)
                        | Primitive "number" ->
                            Some(mkOperation methodName customName propertyName docs "double" defaultAssignment)
                        | Primitive "string" ->
                            Some(mkOperation methodName customName propertyName docs "string" defaultAssignment)
                        | Primitive "any" ->
                            Some(mkOperation methodName customName propertyName docs "obj" defaultAssignment)
                        | Fqn f when f = "cdktf.IResolvable" ->
                            Some(mkOperation methodName customName propertyName docs "HashiCorp.Cdktf.IResolvable" defaultAssignment)
                        | Fqn f when typeMap.ContainsKey(f) ->
                            let resolved = mapTypeToSignature rootNamespace typeMap u
                            Some(mkOperation methodName customName propertyName docs resolved defaultAssignment)
                        | _ -> None)

                if overOps.IsEmpty then
                    defaultOp ()
                else
                    overOps

            | _ ->
                defaultOp ())

    { BuilderName = builderName
      FunctionName = functionName
      ResourceType = resourceType
      ConfigType = configType
      Docs = docs
      Operations = operations }

let buildType (builder: BuilderDefinition) =
    let constructor =
        Ast.Constructor(
            Ast.ParenPat(
                Ast.ParameterPat("logicalId", "string")
            )
        )

    let assignmentsBinding =
        Ast.LetBinding(bindingFromText "let assignments = ResizeArray<string * obj>()")

    let yieldMember =
        Ast.Member("_.Yield", Ast.ParenPat(Ast.TuplePat([ unitParameter "_" ])), exprFromText "()")

    let zeroMember =
        Ast.Member("_.Zero", Ast.ParenPat(Ast.UnitPat()), exprFromText "()")

    let customMembers =
        builder.Operations
        |> List.map(fun op ->
            let tupleItems : WidgetBuilder<Syntax.Pattern> list =
                [ Ast.UnitPat()
                  parameterPattern "value" (Some op.ParameterType) ]
            let pattern =
                Ast.ParenPat(Ast.TuplePat(tupleItems :> seq<_>))

            let body =
                exprFromText op.AssignmentExpr

            let memberBuilder = Ast.Member($"_.{op.MethodName}", pattern, body)

            let withDocs =
                if op.Docs.IsEmpty then
                    memberBuilder
                else
                    memberBuilder.xmlDocs(op.Docs)

            withDocs.attribute(Ast.Attribute("CustomOperation", Ast.String(op.OperationName))))

    let runMember =
        let tupleItems : WidgetBuilder<Syntax.Pattern> list = [ unitParameter "_" ]
        let pattern = Ast.ParenPat(Ast.TuplePat(tupleItems :> seq<_>))

        let body =
            exprFromText
                $"let config = {builder.ConfigType}()\nBuilderInternals.apply assignments config\n{builder.ResourceType}(StackContext.get(), logicalId, config)"

        Ast.Member("_.Run", pattern, body)

    let typeDef =
        TypeDefn(builder.BuilderName, constructor) {
            assignmentsBinding
            yieldMember
            zeroMember
            for memberDef in customMembers do
                memberDef
            runMember
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
            yield buildType builder |> Ast.AnyModuleDecl
            yield buildFunction builder
    }

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
            buildBuilderDefinition dotnetNamespace typeMap resource.BaseType resource.ResourceType resource.ConfigType resource.ResourceName resource.Docs props)

    let moduleOak = buildModule options.ModuleName builders

    let code =
        Oak() {
            Namespace(options.OutputNamespace) {
                Open("System")
                Open("System.Collections.Generic")
                Open("HashiCorp.Cdktf")
                Open("Nelknet.Cdktf.FSharp")
                moduleOak
            }
        }
        |> Gen.mkOak
        |> Gen.run

    let outputDir =
        options.OutputNamespace.Split('.')
        |> Array.fold (fun path segment -> Path.Combine(path, segment)) outputRoot

    Directory.CreateDirectory(outputDir) |> ignore

    let outputPath = Path.Combine(outputDir, $"{options.ModuleName}.fs")
    File.WriteAllText(outputPath, code)
    printfn "Generated %s" outputPath

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
