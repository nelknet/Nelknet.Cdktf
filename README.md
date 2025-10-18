# Nelknet.Cdktf.FSharp

F# computation expressions and helpers that sit on top of the CDK for Terraform (CDKTF) .NET bindings.  The library is generated directly from a provider’s JSII schema so the surface stays in sync with the official SDKs while feeling idiomatic in F# (maps as sequences, arrays as sequences, boolean flags as `bool`, etc.).

## Highlights

- **Schema‑driven generation** – each provider project carries MSBuild metadata; `dotnet build` runs the generator and refreshes `src/Providers/<Provider>/Generated/...`.
- **F#‑friendly operations** – Terraform maps become `seq<string * string>`, repeated fields accept `seq<'T>`, and common unions (e.g., `bool | cdktf.IResolvable`) expose overloads so you don’t have to pass `obj`.
- **Ambient stack support** – `stack "name" { ... }` keeps the current `TerraformStack` available without threading it through every builder.
- **Ready for NuGet** – `dotnet pack` produces individual packages (metadata lives in `src/Core/Nelknet.Cdktf.FSharp.Core` and each provider project).

## Repository Layout

```
src/Core/Nelknet.Cdktf.FSharp.Core/        – core helpers (stack DSL, output helpers)
src/Providers/Hcloud/            – generated Hetzner computation expression
samples/Nelknet.Cdktf.HcloudSample/ – minimal stack using the generated Hetzner CE
generated/hcloud/                – .NET binding emitted by `cdktf provider add`
tools/Nelknet.Cdktf.CodeGen/     – Fabulous.AST-based generator
```

> We keep the C# binding project because the generator needs it to resolve fully-qualified .NET type names (the JSII schema alone does not encode C# naming quirks such as `Certificate_`).

## Generating providers

1. Generate/refresh the provider binding (once per provider version):
   ```bash
   rm -rf generated/hcloud
   cdktf provider add hetznercloud/hcloud --language=csharp
   ```
   The CLI drops `.tgz` + C# bindings under `generated/hcloud/`.  The project already targets `net8.0` so no manual tweaks are required.
3. Ensure a provider project exists under `src/Providers/<Module>` with the correct MSBuild metadata (see `src/Providers/Hcloud/Nelknet.Cdktf.Providers.Hcloud.fsproj`).
4. Build the solution (or run the generator manually):
   ```bash
   dotnet build
   # or
   dotnet run --project tools/Nelknet.Cdktf.CodeGen -- --provider-id hcloud --module-name Hcloud --namespace Nelknet.Cdktf.Providers.Hcloud --package-dir generated/hcloud --output-root src/Providers/Hcloud/Generated
   ```
   New/updated files appear under `src/Providers/<Module>/Generated/...`.

Add more providers by copying the `src/Providers/Hcloud` project, adjusting the property group (`ProviderId`, `ProviderModule`, etc.), and running `dotnet build`.

## Using the generated DSL

```fsharp
open Nelknet.Cdktf.FSharp
open Nelknet.Cdktf.Providers.Hcloud
open Nelknet.Cdktf.Providers.Hcloud.Hcloud
open Nelknet.Cdktf.FSharp.Terraform

let apiToken = System.Environment.GetEnvironmentVariable "HCLOUD_TOKEN"
stack "hcloud-sample" {
    // Registers the provider on the current stack
    Hcloud.provider "hcloud" {
        token apiToken
        poll_interval "750ms"
    }
    |> ignore

    // Schema-driven CE: maps accept seq, optional flags accept bool, etc.
    let server =
        Hcloud.server "sample-server" {
            name "fsharp-sample"
            server_type "cpx11"
            image "ubuntu-22.04"
            labels [ "module", "nelknet" ]
        }

    Terraform.output "server-name" {
        value server.Name
        description "Expose the created Hetzner server name"
    }
    |> ignore
}
|> ignore
```

Run it with the CDKTF CLI:

```bash
export HCLOUD_TOKEN=... # Hetzner API token
cdktf deploy --auto-approve
cdktf destroy --auto-approve   # Clean up when you are done
```

## Packaging

Pack the core and providers independently:

```bash
# Core DSL
dotnet pack src/Core/Nelknet.Cdktf.FSharp.Core/Nelknet.Cdktf.FSharp.Core.fsproj -c Release -o artifacts

# Hetzner provider (generated)
dotnet pack src/Providers/Hcloud/Nelknet.Cdktf.Providers.Hcloud.fsproj -c Release -o artifacts
```

Publish whichever packages you need (`dotnet nuget push artifacts/*.nupkg`).  Consumers can depend on `Nelknet.Cdktf.FSharp.Core` plus only the provider packages they require.

## Adding new helpers / improving ergonomics

The generator is intentionally small so it is easy to extend.  Examples of tweaks you can make quickly:

- detect additional union patterns and add typed overloads;
- add convenience operations (e.g., `labelsFrom` that loads a JSON file) by post-processing `BuilderDefinition`s;
- emit module-level aliases if you prefer short helper names (`Hcloud.server` vs. `Hcloud.serverResource`, etc.).

Because everything is schema-driven you only need to regenerate when the provider version changes—no manual edits to the generated files are necessary.

## Development scripts

- `dotnet run --project tools/Nelknet.Cdktf.CodeGen` – regenerate computation expressions from `.jsii`.
- `dotnet build` – restore and build all projects.
- `cdktf deploy/destroy` – run the sample stack (requires `HCLOUD_TOKEN`).

Happy infrastructure hacking in F#!
