#r "System.Text.Json"

open System
open System.IO
open System.Text
open System.Text.Json
open System.Text.Json.Nodes

let repoRoot =
    let current = Directory.GetParent(__SOURCE_DIRECTORY__)
    if isNull current then
        failwith "Unable to determine repository root."
    else
        current.FullName

let manifestPath = Path.Combine(repoRoot, "cdktf.json")
if not (File.Exists(manifestPath)) then
    failwithf "cdktf.json not found at %s" manifestPath

let templatePath =
    Path.Combine(repoRoot, "src", "Providers", "_Template", "Nelknet.Cdktf.Providers.Template.fsproj.template")

if not (File.Exists(templatePath)) then
    failwithf "Provider template not found at %s" templatePath

let toPascalCase (value: string) =
    value.Split([| '-'; '_' |], StringSplitOptions.RemoveEmptyEntries)
    |> Array.choose (fun segment ->
        if String.IsNullOrWhiteSpace(segment) then None
        else
            let lower = segment.ToLowerInvariant()
            let head = Char.ToUpperInvariant(lower[0])
            let tail = if lower.Length > 1 then lower.Substring(1) else ""
            Some($"{head}{tail}"))
    |> String.concat ""
    |> fun result ->
        if String.IsNullOrWhiteSpace(result) then
            value
        else
            result

let manifest = JsonNode.Parse(File.ReadAllText(manifestPath))
if isNull manifest then
    failwith "Unable to parse cdktf.json"

let providersNode =
    match manifest["terraformProviders"] with
    | null -> failwith "cdktf.json missing terraformProviders array"
    | node -> node.AsArray()

let ensureProject (entry: string) =
    let trimmed = entry.Trim()
    if String.IsNullOrWhiteSpace(trimmed) then
        None
    else
        let atIndex = trimmed.IndexOf('@')
        if atIndex < 0 then
            printfn "Skipping '%s' (expected '<source>@=<version>')" trimmed
            None
        else
            let source = trimmed.Substring(0, atIndex).Trim()
            let version = trimmed.Substring(atIndex + 1).TrimStart('=').Trim()
            if String.IsNullOrWhiteSpace(source) || String.IsNullOrWhiteSpace(version) then
                printfn "Skipping '%s' (missing source or version)" trimmed
                None
            else
                let segments = source.Split('/', StringSplitOptions.RemoveEmptyEntries)
                if segments.Length = 0 then
                    printfn "Skipping '%s' (unable to determine provider id)" trimmed
                    None
                else
                    let providerId = segments[segments.Length - 1]
                    if String.IsNullOrWhiteSpace(providerId) then
                        printfn "Skipping '%s' (empty provider id)" trimmed
                        None
                    else
                        let moduleName = toPascalCase providerId
                        let namespaceName = $"Nelknet.Cdktf.Providers.{moduleName}"
                        let providerDir = Path.Combine(repoRoot, "src", "Providers", moduleName)
                        Directory.CreateDirectory(providerDir) |> ignore
                        let projectPath = Path.Combine(providerDir, $"Nelknet.Cdktf.Providers.{moduleName}.fsproj")

                        if File.Exists(projectPath) then
                            None
                        else
                            let replacements =
                                [ "{{ProviderId}}", providerId
                                  "{{Module}}", moduleName
                                  "{{Namespace}}", namespaceName
                                  "{{NamespacePath}}", namespaceName.Replace('.', '/')
                                  "{{PackageTags}}", $"cdktf;terraform;fsharp;{providerId}"
                                  "{{Source}}", source
                                  "{{Version}}", version ]

                            let content =
                                replacements
                                |> List.fold (fun (acc: string) (key, value) -> acc.Replace(key, value)) (File.ReadAllText(templatePath))

                            File.WriteAllText(projectPath, content)
                            Some projectPath

let created =
    providersNode
    |> Seq.choose (fun node ->
        if isNull node then None
        else
            let value = node.GetValue<string>()
            ensureProject value)
    |> Seq.toList

match created with
| [] ->
    printfn "No provider projects needed scaffolding."
| projects ->
    projects
    |> List.iter (fun path ->
        let relative = Path.GetRelativePath(repoRoot, path)
        printfn "Scaffolded %s" relative)

printfn "Done."
