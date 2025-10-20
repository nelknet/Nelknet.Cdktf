# Nelknet.Cdktf

[![NuGet](https://img.shields.io/nuget/v/Nelknet.Cdktf.Core.svg?style=flat-square&label=Nelknet.Cdktf.Core)](https://www.nuget.org/packages/Nelknet.Cdktf.Core/)
[![NuGet](https://img.shields.io/nuget/v/Nelknet.Cdktf.Providers.Aws.svg?style=flat-square&label=AWS)](https://www.nuget.org/packages/Nelknet.Cdktf.Providers.Aws/)
[![NuGet](https://img.shields.io/nuget/v/Nelknet.Cdktf.Providers.Azurerm.svg?style=flat-square&label=Azure)](https://www.nuget.org/packages/Nelknet.Cdktf.Providers.Azurerm/)
[![NuGet](https://img.shields.io/nuget/v/Nelknet.Cdktf.Providers.Hcloud.svg?style=flat-square&label=Hetzner)](https://www.nuget.org/packages/Nelknet.Cdktf.Providers.Hcloud/)
[![NuGet](https://img.shields.io/nuget/v/Nelknet.Cdktf.Providers.Random.svg?style=flat-square&label=Random)](https://www.nuget.org/packages/Nelknet.Cdktf.Providers.Random/)

F# computation expressions and helpers that sit on top of the CDK for Terraform (CDKTF) .NET bindings.  The library is generated directly from a provider's JSII schema so the surface stays in sync with the official SDKs while feeling idiomatic in F# (maps as sequences, arrays as sequences, boolean flags as `bool`, etc.).

## Highlights

- **Schema‑driven generation** – provider projects carry MSBuild metadata; `dotnet build` (or `dotnet build -p:ForceCodeGen=true`) regenerates `src/Providers/<Provider>/Generated/...` on the fly and the generated files stay out of git.
- **F#‑friendly operations** – Terraform maps become `seq<string * string>`, repeated fields accept `seq<'T>`, and common unions (e.g., `bool | cdktf.IResolvable`) expose overloads so you don’t have to pass `obj`.
- **Compile-time required checks** – generated builders track required custom operations with phantom types (`Missing`/`Present`), so omitting a mandatory field (e.g., `name`, `server_type`) produces a compile-time `CompilerMessage` error instead of a runtime failure.
- **Ambient stack support** – `stack "name" { ... }` keeps the current `TerraformStack` available without threading it through every builder.

## Repository Layout

```
src/Core/Nelknet.Cdktf.Core/        – core helpers (stack DSL, output helpers)
src/Providers/Hcloud/            – generated Hetzner computation expression
src/Providers/_Template/         – scaffold template consumed by the provider manager
examples/Nelknet.Cdktf.Examples/ – minimal stack using the generated Hetzner example
generated/                       – raw .NET bindings emitted by `cdktf provider add` (ignored; recreated at build time)
tools/Nelknet.Cdktf.CodeGen/     – Fabulous.AST-based generator
```

> We keep the C# binding project because the generator needs it to resolve fully-qualified .NET type names (the JSII schema alone does not encode C# naming quirks such as `Certificate_`).
> The scaffold template lives as `Nelknet.Cdktf.Providers.Template.fsproj.template` so editors do not try to load it; the provider manager copies and renames it during scaffolding.

## Prerequisites

Install the following tools before working with this repository or consuming the generated packages in a new project:

- .NET SDK 8.0 (or newer) – used for building the DSL and running stacks.
- Node.js 18+ with npm or pnpm – required by the CDK for Terraform CLI.
- CDKTF CLI 0.21.x – `npm install --global cdktf-cli@0.21`. The CLI honours `cdktf.json` and downloads provider schemas.
- Terraform CLI 1.6+ – optional for local deploys, required for `cdktf deploy` / `cdktf destroy`.

After cloning this repository run:

```bash
npm install
dotnet build -p:ForceCodeGen=true
```

This installs the local Node dependencies (`cdktf` / `constructs`) and repopulates the ignored `generated/` and `src/Providers/*/Generated` directories so the solution builds immediately.


## Using Nelknet.Cdktf in a New Repository

This repo publishes two kinds of packages to NuGet: `Nelknet.Cdktf.Core` (shared helpers) and provider-specific DSLs (e.g., `Nelknet.Cdktf.Providers.Hcloud`, `Nelknet.Cdktf.Providers.Aws`). A minimal consumer project looks like this:

1. **Create an infrastructure project.**
   ```bash
   dotnet new console -lang F# -n Demo.Infra
   cd Demo.Infra
   ```
2. **Reference the DSL packages you need.** Install the provider package; it brings along `Nelknet.Cdktf.Core`, `HashiCorp.Cdktf`, and the generated bindings transitively:
   ```bash
   dotnet add package Nelknet.Cdktf.Providers.Hcloud    # or Aws / others
  ```
  When targeting AWS, replace `Hcloud` with `Aws`. You can mix and match providers as long as they are pinned to versions available on NuGet.
3. **Add a `cdktf.json` manifest** at the repo root so the CDKTF CLI knows how to execute your stack. Example:
   ```json
   {
     "language": "csharp",
     "app": "dotnet run --project ./Demo.Infra",
     "codeMakerOutput": "generated",
     "terraformProviders": [
       "hashicorp/aws@=5.100.0"
     ],
     "terraformModules": [],
     "context": {}
   }
   ```
   The `app` value should point at the F# project that defines your stacks. Keep provider versions exact for reproducibility, just like this repository does.
4. **Author your stack** using the computation-expression helpers:
   ```fsharp
   open Nelknet.Cdktf
   open Nelknet.Cdktf.Providers.Aws
   open Nelknet.Cdktf.Providers.Aws.Aws
   open Nelknet.Cdktf.Terraform

  [<EntryPoint>]
  let main _ =
      let app =
          stack "demo" {
              let _ =
                  Aws.provider "aws" {
                      region "us-east-1"
                  }

              Aws.s3Bucket "state" {
                  bucket "demo-state-bucket"
              }
          }

      app.Synth()
      0
  ```
   The `stack` computation expression returns the `Terraform.App`; call `app.Synth()` at the end of your program (or whenever you are ready) so CDKTF emits `cdktf.out/` before the process exits.
5. **Run the usual CDKTF workflow.** From the repository root:
   ```bash
   cdktf get         # downloads provider bindings into ./generated/
   dotnet build     # builds your project, ensures the DSL assemblies load
   cdktf synth       # emits Terraform JSON into cdktf.out/
   cdktf deploy      # requires credentials (e.g., AWS_PROFILE/HCLOUD_TOKEN)
   ```

When adding providers later, update `terraformProviders`, run `cdktf get`, and add the matching `Nelknet.Cdktf.Providers.*` NuGet package to your project.

## Generating providers

Generated code is intentionally untracked. The combination of `npm install` and `dotnet build` repopulates both the raw C# bindings under `generated/<provider>` and the F# computation expressions under `src/Providers/<Provider>/Generated`.

```bash
npm install                                # installs local cdktf + constructs packages
dotnet build -p:ForceCodeGen=true          # downloads providers and regenerates the F# surface
```

During the build MSBuild runs the Bootstrap helper (`tools/Nelknet.Cdktf.Bootstrap/`) once; it checks every provider listed in `cdktf.json`, downloads missing bindings, normalises the generated C# project, and keeps the cached assemblies up to date. When you add providers manually, regenerate any missing `.fsproj` files with:

```bash
dotnet fsi tools/scaffold-providers.fsx
```

The script scans `cdktf.json` and copies the template under `src/Providers/_Template/` for every provider that does not yet have a matching project.

## Adding a new provider

Adding a new provider is streamlined with the Bootstrap project. Follow these steps:

1. **Ask CDKTF to add the provider.** This updates `cdktf.json`, downloads the schema into `generated/<provider>/`, and primes the local cache in one step:
   ```bash
   cdktf provider add hashicorp/random@=3.6.0 --language csharp --force-local
   ```
   Replace the source and version with the provider you need. The `--language csharp` flag ensures the C# bindings (which our generator consumes) are emitted.

2. **Scaffold any missing provider projects.**
   ```bash
   dotnet fsi tools/scaffold-providers.fsx
   ```
   This reads `cdktf.json`, creates `src/Providers/<Module>/Nelknet.Cdktf.Providers.<Module>.fsproj` when missing, and stamps it with the correct provider metadata.

3. **Add the projects to the solution** so editors/builds pick them up:
   ```bash
   dotnet sln add src/Providers/Random/Nelknet.Cdktf.Providers.Random.fsproj
   dotnet sln add generated/random/random.csproj
   ```

4. **Run the build** which will automatically:
   - Verify the provider download (reusing the cached schema if it is already present)
   - Normalise the generated C# project and build the binding assembly
   - Generate / refresh the F# computation expressions under `src/Providers/<Provider>/Generated`
   - Stamp the provider project metadata with the upstream source/version (exposed in NuGet description & release notes)
   ```bash
   dotnet build -p:ForceCodeGen=true
   ```

5. **Commit the changes**:
   - The updated `cdktf.json`
   - The new provider's `.fsproj` file in `src/Providers/<Provider>/`
   - Any documentation updates

   Note: No generated code (C# or F#) should be committed - these remain in `.gitignore`.

### What happens during the build

The Bootstrap project (`tools/Nelknet.Cdktf.Bootstrap/`) automatically:
- Reads providers from `cdktf.json`
- Downloads missing providers using `cdktf provider add`
- Normalizes generated C# projects for Central Package Management
- Creates provider F# projects from the template in `src/Providers/_Template/`
- Caches everything to avoid redundant downloads

### Upgrading an existing provider

To upgrade a provider version:
1. Update the version in `cdktf.json`
2. Run `dotnet build -p:ForceCodeGen=true`
3. Commit only the `cdktf.json` change

The build automatically detects version changes and re-downloads the provider.

## Using the generated DSL

```fsharp
open Nelknet.Cdktf
open Nelknet.Cdktf.Providers.Hcloud
open Nelknet.Cdktf.Providers.Hcloud.Hcloud
open Nelknet.Cdktf.Terraform

let apiToken = System.Environment.GetEnvironmentVariable "HCLOUD_TOKEN"

let app =
    stack "hcloud-example" {
        // Registers the provider on the current stack
        let _ =
            Hcloud.provider "hcloud" {
                token apiToken
                poll_interval "750ms"
            }

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

app.Synth()
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
dotnet pack src/Core/Nelknet.Cdktf.Core/Nelknet.Cdktf.Core.fsproj -c Release -o artifacts

# Hetzner provider (generated)
dotnet pack src/Providers/Hcloud/Nelknet.Cdktf.Providers.Hcloud.fsproj -c Release -o artifacts
```

Publish whichever packages you need (`dotnet nuget push artifacts/*.nupkg`).  Consumers can depend on `Nelknet.Cdktf.Core` plus only the provider packages they require.

## Adding new helpers / improving ergonomics

The generator is intentionally small so it is easy to extend.  Examples of tweaks you can make quickly:

- detect additional union patterns and add typed overloads;
- add convenience operations (e.g., `labelsFrom` that loads a JSON file) by post-processing `BuilderDefinition`s;
- emit module-level aliases if you prefer short helper names (`Hcloud.server` vs. `Hcloud.serverResource`, etc.).

Because everything is schema-driven you only need to regenerate when the provider version changes—no manual edits to the generated files are necessary.

## Development scripts

- `dotnet run --project tools/Nelknet.Cdktf.CodeGen` – regenerate computation expressions from `.jsii`.
- `dotnet build` – restore and build all projects.
- `cdktf deploy/destroy` – run the example stack (requires `HCLOUD_TOKEN`).

Happy infrastructure hacking in F#!
