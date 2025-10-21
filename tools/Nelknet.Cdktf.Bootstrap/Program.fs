module Nelknet.Cdktf.Bootstrap

open System
open System.IO
open System.Diagnostics
open System.Text.Json
open System.Text.Json.Nodes
open System.Xml.Linq
open System.Collections.Generic
open System.Linq

type Provider =
    { Id: string
      Source: string
      Version: string
      Module: string
      Namespace: string }

let private findRepoRoot path =
    let rec loop current =
        if String.IsNullOrEmpty(current) then None
        else
            let manifest = Path.Combine(current, "cdktf.json")
            if File.Exists(manifest) then Some current
            else
                match Directory.GetParent(current) with
                | null -> None
                | parent -> loop parent.FullName
    loop path

let private capitalize (segment: string) =
    if String.IsNullOrWhiteSpace(segment) then ""
    else
        let lower = segment.ToLowerInvariant()
        string (Char.ToUpperInvariant(lower[0])) + lower.Substring(1)

let private moduleNameFromProviderId (providerId: string) =
    providerId.Split([| '-'; '_' |], StringSplitOptions.RemoveEmptyEntries)
    |> Array.map capitalize
    |> String.concat ""

let private parseProvider (entry: string) =
    let trimmed = entry.Trim()
    if String.IsNullOrWhiteSpace(trimmed) then None
    else
        let atIndex = trimmed.IndexOf('@')
        if atIndex < 0 then None
        else
            let source = trimmed.Substring(0, atIndex).Trim()
            let versionPart = trimmed.Substring(atIndex + 1).Trim()
            let version = versionPart.TrimStart('=').Trim()

            if String.IsNullOrWhiteSpace(source) || String.IsNullOrWhiteSpace(version) then None
            else
                let segments = source.Split('/', StringSplitOptions.RemoveEmptyEntries)
                if segments.Length = 0 then None
                else
                    let providerId = segments[segments.Length - 1]
                    let moduleName = moduleNameFromProviderId providerId
                    let ns = $"Nelknet.Cdktf.Providers.{moduleName}"

                    Some { Id = providerId
                           Source = source
                           Version = version
                           Module = moduleName
                           Namespace = ns }

let private loadProviders (repoRoot: string) =
    let manifestPath = Path.Combine(repoRoot, "cdktf.json")
    if not (File.Exists(manifestPath)) then
        failwith $"cdktf.json not found at {manifestPath}"

    let json = JsonNode.Parse(File.ReadAllText(manifestPath))
    if isNull json then
        failwith "Unable to parse cdktf.json"

    match json["terraformProviders"] with
    | null -> []
    | node ->
        node.AsArray()
        |> Seq.choose (fun item ->
            if isNull item then None
            else parseProvider (item.GetValue<string>()))
        |> Seq.toList

let private runProcess (workingDir: string) (fileName: string) (args: string list) =
    use proc = new Process()
    let psi = proc.StartInfo
    psi.WorkingDirectory <- workingDir
    psi.FileName <- fileName
    for arg in args do
        psi.ArgumentList.Add(arg)
    psi.RedirectStandardOutput <- true
    psi.RedirectStandardError <- true
    psi.UseShellExecute <- false

    printfn ">>> Running: %s %s" fileName (String.Join(" ", args))
    if not (proc.Start()) then
        failwith $"Failed to start {fileName}"

    let output = proc.StandardOutput.ReadToEnd()
    let errors = proc.StandardError.ReadToEnd()
    proc.WaitForExit()

    if proc.ExitCode <> 0 then
        if output.Length > 0 then printfn "%s" output
        if errors.Length > 0 then printfn "%s" errors
        failwith $"Command failed with exit code {proc.ExitCode}"
    else
        if output.Length > 0 then printfn "%s" output
        if errors.Length > 0 then printfn "%s" errors
        proc.ExitCode

let private needsProviderDownload (repoRoot: string) (provider: Provider) =
    let providerDir = Path.Combine(repoRoot, "generated", provider.Id)
    let versionMarker = Path.Combine(providerDir, ".version")
    let expectedVersion = $"{provider.Source}@={provider.Version}"

    if not (Directory.Exists(providerDir)) then
        printfn "Provider %s not found, will download" provider.Id
        true
    elif not (File.Exists(versionMarker)) then
        printfn "Version marker missing for %s, will download" provider.Id
        true
    else
        let currentVersion = File.ReadAllText(versionMarker).Trim()
        if currentVersion <> expectedVersion then
            printfn "Provider %s version mismatch (current: %s, expected: %s), will download"
                provider.Id currentVersion expectedVersion
            true
        else
            printfn "Provider %s is up to date" provider.Id
            false

let private locateCdktf (repoRoot: string) =
    let binaryName = if OperatingSystem.IsWindows() then "cdktf.cmd" else "cdktf"
    let localCdktf = Path.Combine(repoRoot, "node_modules", ".bin", binaryName)
    if File.Exists(localCdktf) then localCdktf else "cdktf"

let private normalizeGeneratedProject (repoRoot: string) (providerId: string) =
    let projectPath = Path.Combine(repoRoot, "generated", providerId, $"{providerId}.csproj")
    if not (File.Exists(projectPath)) then
        printfn "Generated project %s not found, skipping normalization" projectPath
    else
        let doc = XDocument.Load(projectPath)
        if isNull doc.Root then
            failwith $"Unable to load {projectPath}"

        let propertyGroups = doc.Root.Elements(XName.Get("PropertyGroup")) |> Seq.toList

        // Update property values
        for group in propertyGroups do
            let setElementValue name value =
                let xname = XName.Get(name)
                match group.Element(xname) with
                | null ->
                    let el = XElement(xname)
                    el.Value <- value
                    group.Add(el)
                | element -> element.Value <- value

            setElementValue "TargetFramework" "net8.0"
            setElementValue "GenerateDocumentationFile" "false"
            setElementValue "GeneratePackageOnBuild" "false"
            setElementValue "Nullable" "annotations"
            setElementValue "EnableDefaultCompileItems" "false"

        // Remove embedded resources
        let embeddedResources = doc.Root.Descendants(XName.Get("EmbeddedResource")) |> Seq.toArray
        for embedded in embeddedResources do
            embedded.Remove()

        // Ensure compile items exist
        let compileExists =
            doc.Root.Descendants(XName.Get("Compile"))
            |> Seq.exists (fun c ->
                match c.Attribute(XName.Get("Include")) with
                | null -> false
                | attr -> attr.Value.Contains($"{providerId}/"))

        if not compileExists then
            let itemGroup = XElement(XName.Get("ItemGroup"))
            let compile = XElement(XName.Get("Compile"))
            compile.SetAttributeValue(XName.Get("Include"), $"{providerId}/**/*.cs")
            itemGroup.Add(compile)
            doc.Root.Add(itemGroup)

        // Remove version attributes from PackageReferences
        for reference in doc.Root.Descendants(XName.Get("PackageReference")) do
            match reference.Attribute(XName.Get("Version")) with
            | null -> ()
            | attr -> attr.Remove()

        // Add NoWarn codes
        match propertyGroups with
        | [] -> ()
        | first :: _ ->
            let codes = HashSet<string>(StringComparer.OrdinalIgnoreCase)

            match first.Element(XName.Get("NoWarn")) with
            | null -> ()
            | element ->
                element.Value.Split([| ','; ';'; ' ' |], StringSplitOptions.RemoveEmptyEntries)
                |> Array.iter (fun code -> codes.Add(code.Trim()) |> ignore)

            [ "0612"; "0618"; "1573"; "1591"; "1587"; "8600"; "8602"; "8618"; "8632" ]
            |> List.iter (fun code -> codes.Add(code) |> ignore)

            let joined = codes |> Seq.sort |> String.concat ","

            let setElementValue name value =
                let xname = XName.Get(name)
                match first.Element(xname) with
                | null ->
                    let el = XElement(xname)
                    el.Value <- value
                    first.Add(el)
                | element -> element.Value <- value

            setElementValue "NoWarn" joined

        doc.Save(projectPath)

let private finalizeProvider (repoRoot: string) (provider: Provider) =
    let providerDir = Path.Combine(repoRoot, "generated", provider.Id)
    Directory.CreateDirectory(providerDir) |> ignore

    normalizeGeneratedProject repoRoot provider.Id

    let versionMarker = Path.Combine(providerDir, ".version")
    File.WriteAllText(versionMarker, $"{provider.Source}@={provider.Version}")

    let projectPath = Path.Combine(providerDir, $"{provider.Id}.csproj")
    if File.Exists(projectPath) then
        runProcess (Path.GetDirectoryName(projectPath)) "dotnet" ["build"; "-c"; "Debug"] |> ignore



let private ensureProviderProject (repoRoot: string) (provider: Provider) =
    let providerDir = Path.Combine(repoRoot, "src", "Providers", provider.Module)
    let projectPath = Path.Combine(providerDir, $"Nelknet.Cdktf.Providers.{provider.Module}.fsproj")

    if not (File.Exists(projectPath)) then
        printfn "Creating provider project for %s" provider.Id

        let templatePath = Path.Combine(repoRoot, "src", "Providers", "_Template",
                                        "Nelknet.Cdktf.Providers.Template.fsproj.template")

        if not (File.Exists(templatePath)) then
            failwith $"Template not found at {templatePath}"

        Directory.CreateDirectory(providerDir) |> ignore

        let template = File.ReadAllText(templatePath)
        let content =
            template
                .Replace("{{ProviderId}}", provider.Id)
                .Replace("{{Module}}", provider.Module)
                .Replace("{{Namespace}}", provider.Namespace)
                .Replace("{{NamespacePath}}", provider.Namespace.Replace('.', '/'))
                .Replace("{{PackageTags}}", $"cdktf;terraform;fsharp;{provider.Id}")
                .Replace("{{Source}}", provider.Source)
                .Replace("{{Version}}", provider.Version)

        File.WriteAllText(projectPath, content)
        printfn "Created %s" projectPath

[<EntryPoint>]
let main argv =
    try
        match findRepoRoot (Directory.GetCurrentDirectory()) with
        | None ->
            printfn "Unable to find repository root (cdktf.json not found)"
            1
        | Some repoRoot ->
            printfn "=== Nelknet.Cdktf.Bootstrap ==="
            printfn "Repository root: %s" repoRoot

            // Load providers and check what actually needs updating
            let providers = loadProviders repoRoot
            printfn "Found %d providers in cdktf.json" providers.Length

            // Check if any provider needs updating or if F# projects are missing
            let providersNeedingWork =
                providers
                |> List.filter (fun p ->
                    needsProviderDownload repoRoot p ||
                    not (File.Exists(Path.Combine(repoRoot, "src", "Providers", p.Module,
                                                  $"Nelknet.Cdktf.Providers.{p.Module}.fsproj"))))

            if List.isEmpty providersNeedingWork then
                printfn "All providers are up to date"
                0
            else
                printfn "Found %d provider(s) needing updates" providersNeedingWork.Length

                // Ensure node_modules exist if we need to download
                let packageJson = Path.Combine(repoRoot, "package.json")
                let nodeModules = Path.Combine(repoRoot, "node_modules")

                if File.Exists(packageJson) && not (Directory.Exists(nodeModules)) then
                    printfn "Running npm install to get cdktf CLI..."
                    runProcess repoRoot "npm" ["install"] |> ignore

                printfn "\n--- Running cdktf get ---"
                runProcess repoRoot (locateCdktf repoRoot) ["get"; "--language"; "csharp"; "--force-local"] |> ignore

                for provider in providersNeedingWork do
                    printfn "\n--- Finalizing %s ---" provider.Id
                    finalizeProvider repoRoot provider
                    ensureProviderProject repoRoot provider

                printfn "\n=== Bootstrap complete ==="
                0

    with ex ->
        printfn "Bootstrap failed: %s" ex.Message
        1
