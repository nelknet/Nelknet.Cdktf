module Nelknet.Cdktf.ProviderManager

open System
open System.IO
open System.Diagnostics
open System.Text
open System.Text.Json
open System.Text.Json.Nodes
open System.Xml.Linq
open System.Collections.Generic
open System.Linq
open System.Threading
open Microsoft.FSharp.Core

type ProviderOptions =
    { ProviderId: string
      Source: string
      Version: string
      ModuleName: string
      Namespace: string
      CreateProviderProject: bool
      AddToSolution: bool
      RefreshOnly: bool
      Configuration: string
      Force: bool }

let private showUsage () =
    printfn """Usage:
  dotnet run --project tools/Nelknet.Cdktf.ProviderManager -- scaffold --provider-id <id> --source <publisher/name> --version <x.y.z> [--module <Module>] [--namespace <Namespace>] [--skip-project] [--skip-solution]
  dotnet run --project tools/Nelknet.Cdktf.ProviderManager -- refresh  --provider-id <id> --source <publisher/name> --version <x.y.z> [--module <Module>] [--namespace <Namespace>] [--skip-solution]
  dotnet run --project tools/Nelknet.Cdktf.ProviderManager -- ensure   --provider-id <id> --source <publisher/name> --version <x.y.z> [--module <Module>] [--namespace <Namespace>] [--configuration <Debug|Release>] [--force]
  dotnet run --project tools/Nelknet.Cdktf.ProviderManager -- ensure-all [--configuration <Debug|Release>] [--force]

Examples:
  dotnet run --project tools/Nelknet.Cdktf.ProviderManager -- scaffold --provider-id aws --source hashicorp/aws --version 5.100.0 --module Aws --namespace Nelknet.Cdktf.Providers.Aws
  dotnet run --project tools/Nelknet.Cdktf.ProviderManager -- refresh  --provider-id hcloud --source hetznercloud/hcloud --version 1.54.0
  dotnet run --project tools/Nelknet.Cdktf.ProviderManager -- ensure   --provider-id hcloud --source hetznercloud/hcloud --version 1.54.0 --configuration Release
  dotnet run --project tools/Nelknet.Cdktf.ProviderManager -- ensure-all --configuration Debug
"""

let private capitalize (segment: string) =
    if String.IsNullOrWhiteSpace(segment) then
        ""
    else
        let lower = segment.ToLowerInvariant()
        string (Char.ToUpperInvariant(lower[0])) + lower.Substring(1)

let private moduleNameFromProviderId (providerId: string) =
    providerId.Split([| '-'; '_' |], StringSplitOptions.RemoveEmptyEntries)
    |> Array.map capitalize
    |> String.concat ""

let private parseOptions (args: string[]) =
    try
        let dict = Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        let flags = HashSet<string>(StringComparer.OrdinalIgnoreCase)

        let rec loop idx =
            if idx < args.Length then
                let token = args[idx]
                if token.StartsWith("--", StringComparison.Ordinal) then
                    if idx + 1 < args.Length && not (args[idx + 1].StartsWith("--", StringComparison.Ordinal)) then
                        dict[token.Substring(2)] <- args[idx + 1]
                        loop (idx + 2)
                    else
                        flags.Add(token.Substring(2)) |> ignore
                        loop (idx + 1)
                else
                    failwithf "Unexpected argument '%s'" token

        loop 0

        let get name =
            match dict.TryGetValue(name) with
            | true, value when not (String.IsNullOrWhiteSpace(value)) -> value.Trim()
            | _ -> failwithf "Missing required option --%s" name

        let providerId = get "provider-id"
        let source = get "source"
        let version = get "version"

        let moduleName =
            match dict.TryGetValue("module") with
            | true, value when not (String.IsNullOrWhiteSpace(value)) -> value.Trim()
            | _ -> moduleNameFromProviderId providerId

        let ns =
            match dict.TryGetValue("namespace") with
            | true, value when not (String.IsNullOrWhiteSpace(value)) -> value.Trim()
            | _ -> $"Nelknet.Cdktf.Providers.{moduleName}"

        let createProject = not (flags.Contains("skip-project"))
        let addToSolution = not (flags.Contains("skip-solution"))
        let configuration =
            match dict.TryGetValue("configuration") with
            | true, value when not (String.IsNullOrWhiteSpace(value)) -> value.Trim()
            | _ -> "Debug"
        let force = flags.Contains("force")

        Ok { ProviderId = providerId
             Source = source
             Version = version
             ModuleName = moduleName
             Namespace = ns
             CreateProviderProject = createProject
             AddToSolution = addToSolution
             RefreshOnly = false
             Configuration = configuration
             Force = force }
    with ex ->
        Error ex.Message

let private parseEnsureAllArgs (args: string[]) =
    try
        let dict = Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        let flags = HashSet<string>(StringComparer.OrdinalIgnoreCase)

        let rec loop idx =
            if idx < args.Length then
                let token = args[idx]
                if token.StartsWith("--", StringComparison.Ordinal) then
                    if idx + 1 < args.Length && not (args[idx + 1].StartsWith("--", StringComparison.Ordinal)) then
                        dict[token.Substring(2)] <- args[idx + 1]
                        loop (idx + 2)
                    else
                        flags.Add(token.Substring(2)) |> ignore
                        loop (idx + 1)
                else
                    failwithf "Unexpected argument '%s'" token

        loop 0

        let configuration =
            match dict.TryGetValue("configuration") with
            | true, value when not (String.IsNullOrWhiteSpace(value)) -> value.Trim()
            | _ -> "Debug"

        let force = flags.Contains("force")
        Ok(configuration, force)
    with ex -> Error ex.Message

let private tryParseProviderEntry (entry: string) =
    let trimmed = entry.Trim()
    if String.IsNullOrWhiteSpace(trimmed) then
        None
    else
        let atIndex = trimmed.IndexOf('@')
        if atIndex < 0 then
            None
        else
            let source = trimmed.Substring(0, atIndex).Trim()
            let versionPart = trimmed.Substring(atIndex + 1).Trim()
            let version = versionPart.TrimStart('=').Trim()
            if String.IsNullOrWhiteSpace(source) || String.IsNullOrWhiteSpace(version) then
                None
            else
                let providerSegments = source.Split('/', StringSplitOptions.RemoveEmptyEntries)
                if providerSegments.Length = 0 then
                    None
                else
                    let providerId = providerSegments[providerSegments.Length - 1]
                    let moduleName = moduleNameFromProviderId providerId
                    let ns = $"Nelknet.Cdktf.Providers.{moduleName}"
                    Some(source, version, providerId, moduleName, ns)

let private loadProvidersFromManifest (repoRoot: string) (configuration: string) (force: bool) =
    let manifestPath = Path.Combine(repoRoot, "cdktf.json")
    if not (File.Exists(manifestPath)) then
        failwith $"cdktf.json not found at {manifestPath}"

    let json = JsonNode.Parse(File.ReadAllText(manifestPath))
    if isNull json then
        failwith "Unable to parse cdktf.json"

    let providersNode =
        match json["terraformProviders"] with
        | null -> failwith "cdktf.json missing terraformProviders array"
        | value -> value.AsArray()

    providersNode
    |> Seq.choose (fun node ->
        match node with
        | null -> None
        | value ->
            let text = value.GetValue<string>()
            tryParseProviderEntry text)
    |> Seq.map (fun (source, version, providerId, moduleName, ns) ->
        { ProviderId = providerId
          Source = source
          Version = version
          ModuleName = moduleName
          Namespace = ns
          CreateProviderProject = false
          AddToSolution = false
          RefreshOnly = false
          Configuration = configuration
          Force = force })
    |> Seq.toList

let rec private findRepoRoot path =
    if String.IsNullOrEmpty(path) then
        None
    else
        let manifest = Path.Combine(path, "cdktf.json")
        if File.Exists(manifest) then
            Some path
        else
            let parent = Directory.GetParent(path)
            if isNull parent then None else findRepoRoot parent.FullName

let private updateCdktfManifest (repoRoot: string) (source: string) (version: string) =
    let manifestPath = Path.Combine(repoRoot, "cdktf.json")
    if not (File.Exists(manifestPath)) then
        failwith $"cdktf.json not found at {manifestPath}"

    let json = JsonNode.Parse(File.ReadAllText(manifestPath))
    if isNull json then
        failwith "Unable to parse cdktf.json"

    let providers =
        match json["terraformProviders"] with
        | null -> failwith "cdktf.json missing terraformProviders array"
        | value -> value.AsArray()

    let entry = $"{source}@={version}"
    let mutable replaced = false

    for i in 0 .. providers.Count - 1 do
        match providers[i] with
        | null -> ()
        | existing ->
            let text = existing.GetValue<string>()
            if text.StartsWith(source + "@", StringComparison.OrdinalIgnoreCase) then
                providers[i] <- JsonValue.Create(entry)
                replaced <- true

    if not replaced then
        providers.Add(JsonValue.Create(entry))

    let options = JsonSerializerOptions()
    options.WriteIndented <- true
    let content = json.ToJsonString(options) + Environment.NewLine
    File.WriteAllText(manifestPath, content)

let private runProcess (psi: ProcessStartInfo) =
    use proc = new Process()
    proc.StartInfo <- psi
    if not (proc.Start()) then
        failwith $"Failed to start process '{psi.FileName}'."
    let stdout = proc.StandardOutput.ReadToEnd()
    let stderr = proc.StandardError.ReadToEnd()
    proc.WaitForExit()
    stdout.Trim(), stderr.Trim(), proc.ExitCode

let private runCdktf (repoRoot: string) (source: string) (version: string) =
    let psi = ProcessStartInfo()
    psi.WorkingDirectory <- repoRoot
    psi.ArgumentList.Add("provider")
    psi.ArgumentList.Add("add")
    psi.ArgumentList.Add($"{source}@={version}")
    psi.ArgumentList.Add("--language")
    psi.ArgumentList.Add("csharp")
    psi.ArgumentList.Add("--force-local")
    psi.RedirectStandardOutput <- true
    psi.RedirectStandardError <- true
    psi.UseShellExecute <- false

    let localCli =
        let binaryName =
            if OperatingSystem.IsWindows() then "cdktf.cmd" else "cdktf"
        Path.Combine(repoRoot, "node_modules", ".bin", binaryName)

    if File.Exists(localCli) then
        psi.FileName <- localCli
        let binDir = Path.GetDirectoryName(localCli)
        if not (String.IsNullOrEmpty(binDir)) then
            let existingPath =
                if psi.Environment.ContainsKey("PATH") then
                    psi.Environment["PATH"]
                else ""
            psi.Environment["PATH"] <- $"{binDir}{Path.PathSeparator}{existingPath}"
    else
        psi.FileName <- "cdktf"

    printfn ">>> Running: cdktf provider add %s@=%s --language=csharp --force-local" source version
    let stdout, stderr, code = runProcess psi

    if code <> 0 then
        let message =
            StringBuilder()
                .AppendLine("cdktf provider add failed.")
                .AppendLine(stdout)
                .AppendLine(stderr)
                .ToString()
        failwith message

    if stdout.Length > 0 then
        printfn "%s" stdout
    if stderr.Length > 0 then
        printfn "%s" stderr

let private runDotnetBuild (projectPath: string) (configuration: string) =
    let psi = ProcessStartInfo()
    psi.FileName <- "dotnet"
    psi.WorkingDirectory <- Path.GetDirectoryName(projectPath)
    psi.ArgumentList.Add("build")
    psi.ArgumentList.Add(projectPath)
    psi.ArgumentList.Add("-c")
    psi.ArgumentList.Add(configuration)
    psi.ArgumentList.Add("--nologo")
    psi.RedirectStandardOutput <- true
    psi.RedirectStandardError <- true
    psi.UseShellExecute <- false

    printfn ">>> Running: dotnet build %s -c %s" (Path.GetFileName(projectPath)) configuration
    let stdout, stderr, code = runProcess psi

    if code <> 0 then
        let message =
            StringBuilder()
                .AppendLine("dotnet build failed.")
                .AppendLine(stdout)
                .AppendLine(stderr)
                .ToString()
        failwith message

    if stdout.Length > 0 then
        printfn "%s" stdout
    if stderr.Length > 0 then
        printfn "%s" stderr

let private runNpmInstall (repoRoot: string) (tarballPath: string) =
    if not (File.Exists(tarballPath)) then
        failwith $"Tarball '{tarballPath}' not found."

    let psi = ProcessStartInfo()
    psi.WorkingDirectory <- repoRoot
    psi.FileName <- "npm"
    psi.ArgumentList.Add("install")
    psi.ArgumentList.Add("--no-save")
    psi.ArgumentList.Add(tarballPath)
    psi.RedirectStandardOutput <- true
    psi.RedirectStandardError <- true
    psi.UseShellExecute <- false

    printfn ">>> Running: npm install --no-save %s" tarballPath
    let stdout, stderr, code = runProcess psi

    if code <> 0 then
        let message =
            StringBuilder()
                .AppendLine("npm install failed.")
                .AppendLine(stdout)
                .AppendLine(stderr)
                .ToString()
        failwith message

    if stdout.Length > 0 then
        printfn "%s" stdout
    if stderr.Length > 0 then
        printfn "%s" stderr

let private setElementValue (group: XElement) name value =
    let name = XName.Get(name)
    let element = group.Element(name)
    if isNull element then
        let el = XElement(name)
        el.Value <- value
        group.Add(el)
    else
        element.Value <- value

let private normalizeGeneratedProject (repoRoot: string) (providerId: string) =
    let projectPath = Path.Combine(repoRoot, "generated", providerId, $"{providerId}.csproj")
    if File.Exists(projectPath) then
        let doc = XDocument.Load(projectPath)
        if isNull doc.Root then
            failwith $"Unable to load {projectPath}"

        let propertyGroups = doc.Root.Elements(XName.Get("PropertyGroup")) |> Seq.toList

        for group in propertyGroups do
            setElementValue group "TargetFramework" "net8.0"
            setElementValue group "GenerateDocumentationFile" "false"
            setElementValue group "GeneratePackageOnBuild" "false"
            setElementValue group "Nullable" "annotations"
            setElementValue group "EnableDefaultCompileItems" "false"

        // Remove EmbeddedResource entries that package the tarball only.
        for embedded in doc.Root.Descendants(XName.Get("EmbeddedResource")).ToArray() do
            embedded.Remove()

        // Ensure the generated C# sources are compiled.
        let compileItemExists =
            doc.Root
               .Descendants(XName.Get("Compile"))
            |> Seq.exists (fun c ->
                let attr = c.Attribute(XName.Get("Include"))
                if isNull attr then false else attr.Value.Contains($"{providerId}/"))

        if not compileItemExists then
            let itemGroup = XElement(XName.Get("ItemGroup"))
            let compile = XElement(XName.Get("Compile"))
            compile.SetAttributeValue(XName.Get("Include"), $"{providerId}/**/*.cs")
            itemGroup.Add(compile)
            doc.Root.Add(itemGroup)

        for reference in doc.Root.Descendants(XName.Get("PackageReference")) do
            let attr = reference.Attribute(XName.Get("Version"))
            if not (isNull attr) then
                attr.Remove()

        match propertyGroups with
        | [] -> ()
        | first :: _ ->
            let codes = HashSet<string>(StringComparer.OrdinalIgnoreCase)

            let addCodes (values: string) =
                values.Split([| ','; ';'; ' ' |], StringSplitOptions.RemoveEmptyEntries)
                |> Array.iter (fun code ->
                    if not (String.IsNullOrWhiteSpace(code)) then
                        codes.Add(code.Trim()) |> ignore)

            match first.Element(XName.Get("NoWarn")) with
            | null -> ()
            | element -> addCodes element.Value

            [ "0612"; "0618"; "1573"; "1591"; "1587"; "8600"; "8602"; "8618"; "8632" ]
            |> List.iter (fun code -> codes.Add(code) |> ignore)

            let joined =
                codes
                |> Seq.toArray
                |> Array.filter (String.IsNullOrWhiteSpace >> not)
                |> Array.map (fun s -> s.Trim())
                |> Array.distinct
                |> Array.sort
                |> String.concat ","

            setElementValue first "NoWarn" joined

        doc.Save(projectPath)
    else
        printfn ">>> Generated project '%s' not found, skipping normalization." (Path.GetRelativePath(repoRoot, projectPath))

let private scaffoldProviderProject (repoRoot: string) (options: ProviderOptions) =
    if options.RefreshOnly || not options.CreateProviderProject then
        ()
    else
        let templatePath =
            Path.Combine(repoRoot, "src", "Providers", "_Template", "Nelknet.Cdktf.Providers.Template.fsproj.template")

        if not (File.Exists(templatePath)) then
            failwith $"Template project not found at {templatePath}"

        let providersRoot = Path.Combine(repoRoot, "src", "Providers")
        let providerFolder = Path.Combine(providersRoot, options.ModuleName)
        Directory.CreateDirectory(providerFolder) |> ignore

        let targetProject =
            Path.Combine(providerFolder, $"Nelknet.Cdktf.Providers.{options.ModuleName}.fsproj")

        if not (File.Exists(targetProject)) then
            let templateContent = File.ReadAllText(templatePath)
            let namespacePath = options.Namespace.Replace('.', '/')
            let replacements =
                [ "{{ProviderId}}", options.ProviderId
                  "{{Module}}", options.ModuleName
                  "{{Namespace}}", options.Namespace
                  "{{NamespacePath}}", namespacePath
                  "{{PackageTags}}", $"cdktf;terraform;fsharp;{options.ProviderId}"
                  "{{Source}}", options.Source
                  "{{Version}}", options.Version ]

            let finalContent =
                replacements
                |> List.fold (fun (acc: string) (key, value) -> acc.Replace(key, value)) templateContent

            File.WriteAllText(targetProject, finalContent)
            printfn ">>> Created provider project %s" (Path.GetRelativePath(repoRoot, targetProject))

let private ensureProviderArtifacts (repoRoot: string) (options: ProviderOptions) =
    use mutex = new Mutex(false, "Nelknet.Cdktf.ProviderManager.EnsureLock")
    mutex.WaitOne() |> ignore
    try
        let providerDir = Path.Combine(repoRoot, "generated", options.ProviderId)
        let versionMarker = Path.Combine(providerDir, ".nelknet-provider.version")
        let expectedToken = $"{options.Source}@={options.Version}"
        let configuration =
            if String.IsNullOrWhiteSpace(options.Configuration) then
                "Debug"
            else
                options.Configuration

        let needsDownload =
            options.Force
            || not (Directory.Exists(providerDir))
            || not (File.Exists(versionMarker))
            || (File.ReadAllText(versionMarker).Trim() <> expectedToken)

        if needsDownload then
            Directory.CreateDirectory(providerDir) |> ignore
            let constraintsPath = Path.Combine(repoRoot, "generated", "constraints.json")
            if File.Exists(constraintsPath) then
                File.Delete(constraintsPath)
            let versionsPath = Path.Combine(repoRoot, "generated", "versions.json")
            if File.Exists(versionsPath) then
                File.Delete(versionsPath)
            runCdktf repoRoot options.Source options.Version
            normalizeGeneratedProject repoRoot options.ProviderId
            Directory.CreateDirectory(providerDir) |> ignore
            let tarball = Path.Combine(providerDir, $"{options.ProviderId}-0.0.0.tgz")
            if File.Exists(tarball) then
                runNpmInstall repoRoot tarball

        let projectPath = Path.Combine(providerDir, $"{options.ProviderId}.csproj")
        if not (File.Exists(projectPath)) then
            failwith $"Generated project '{projectPath}' not found. Run 'cdktf provider add {options.Source}@={options.Version}' first."

        Directory.CreateDirectory(providerDir) |> ignore
        File.WriteAllText(versionMarker, expectedToken)

        let assemblyPath = Path.Combine(providerDir, "bin", configuration, "net8.0", $"{options.ProviderId}.dll")
        let assemblyMarker = Path.Combine(providerDir, $".nelknet-provider.{configuration}.built")

        let needsBuild =
            options.Force
            || not (File.Exists(assemblyPath))
            || not (File.Exists(assemblyMarker))
            || (File.ReadAllText(assemblyMarker).Trim() <> expectedToken)

        if needsBuild then
            runDotnetBuild projectPath configuration
            Directory.CreateDirectory(Path.GetDirectoryName(assemblyPath)) |> ignore
            File.WriteAllText(assemblyMarker, expectedToken)
    finally
        mutex.ReleaseMutex()

let private runDotnetSln (repoRoot: string) (projectRelativePath: string) =
    let psi = ProcessStartInfo()
    psi.FileName <- "dotnet"
    psi.WorkingDirectory <- repoRoot
    psi.ArgumentList.Add("sln")
    psi.ArgumentList.Add("Nelknet.Cdktf.slnx")
    psi.ArgumentList.Add("add")
    psi.ArgumentList.Add(projectRelativePath)
    psi.RedirectStandardOutput <- true
    psi.RedirectStandardError <- true
    psi.UseShellExecute <- false

    let stdout, stderr, code = runProcess psi

    if code <> 0 then
        if stdout.Contains("already contains", StringComparison.OrdinalIgnoreCase)
           || stderr.Contains("already contains", StringComparison.OrdinalIgnoreCase) then
            printfn "Solution already references %s, skipping." projectRelativePath
        else
            printfn "dotnet sln add failed for %s" projectRelativePath
            printfn "%s" stdout
            printfn "%s" stderr
    else
        if stdout.Length > 0 then printfn "%s" stdout
        if stderr.Length > 0 then printfn "%s" stderr

let private addProjectsToSolution (repoRoot: string) (options: ProviderOptions) =
    if options.AddToSolution then
        runDotnetSln repoRoot $"generated/{options.ProviderId}/{options.ProviderId}.csproj"
        runDotnetSln repoRoot $"src/Providers/{options.ModuleName}/Nelknet.Cdktf.Providers.{options.ModuleName}.fsproj"

let private ensureAllProviders (repoRoot: string) (configuration: string) (force: bool) =
    let providers = loadProvidersFromManifest repoRoot configuration force

    if List.isEmpty providers then
        printfn "No providers listed in cdktf.json."
    else
        for provider in providers do
            printfn "=== Ensuring provider %s@=%s" provider.Source provider.Version
            updateCdktfManifest repoRoot provider.Source provider.Version
            ensureProviderArtifacts repoRoot provider

let private execute (repoRoot: string) (options: ProviderOptions) =
    printfn ">>> Preparing provider '%s@=%s' (id '%s')" options.Source options.Version options.ProviderId
    updateCdktfManifest repoRoot options.Source options.Version
    runCdktf repoRoot options.Source options.Version
    normalizeGeneratedProject repoRoot options.ProviderId
    scaffoldProviderProject repoRoot options
    addProjectsToSolution repoRoot options
    printfn ">>> Provider scaffold complete."

[<EntryPoint>]
let main argv =
    if argv.Length = 0 then
        showUsage ()
        1
    else
        let command = argv[0].ToLowerInvariant()
        let args = argv |> Array.skip 1
        match command with
        | "ensure-all" ->
            match parseEnsureAllArgs args with
            | Error message ->
                printfn "%s" message
                showUsage ()
                1
            | Ok (configuration, force) ->
                match findRepoRoot (Directory.GetCurrentDirectory()) with
                | None ->
                    printfn "Unable to locate repository root (expected to find cdktf.json)."
                    1
                | Some repoRoot ->
                    try
                        ensureAllProviders repoRoot configuration force
                        0
                    with ex ->
                        printfn "Provider manager failed: %s" ex.Message
                        1
        | _ ->
            match parseOptions args with
            | Error message ->
                printfn "%s" message
                showUsage ()
                1
            | Ok options ->
                match findRepoRoot (Directory.GetCurrentDirectory()) with
                | None ->
                    printfn "Unable to locate repository root (expected to find cdktf.json)."
                    1
                | Some repoRoot ->
                    try
                        match command with
                        | "scaffold" ->
                            let opts =
                                { options with
                                    CreateProviderProject = true
                                    AddToSolution = true
                                    RefreshOnly = false }
                            execute repoRoot opts
                            0
                        | "refresh" ->
                            let opts =
                                { options with
                                    CreateProviderProject = false
                                    RefreshOnly = true }
                            execute repoRoot opts
                            0
                        | "ensure" ->
                            let opts =
                                { options with
                                    CreateProviderProject = false
                                    AddToSolution = false
                                    RefreshOnly = false }
                            ensureProviderArtifacts repoRoot opts
                            0
                        | _ ->
                            printfn "Unknown command '%s'." command
                            showUsage ()
                            1
                    with ex ->
                        printfn "Provider manager failed: %s" ex.Message
                        1
