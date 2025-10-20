# Nelknet.Cdktf

F# computation expressions and helpers that sit on top of the CDK for Terraform (CDKTF) .NET bindings.  The library is generated directly from a provider’s JSII schema so the surface stays in sync with the official SDKs while feeling idiomatic in F# (maps as sequences, arrays as sequences, boolean flags as `bool`, etc.).

## Highlights

- **Schema‑driven generation** – provider projects carry MSBuild metadata; `dotnet build` (or `dotnet build -p:ForceCodeGen=true`) regenerates `src/Providers/<Provider>/Generated/...` on the fly and the generated files stay out of git.
- **F#‑friendly operations** – Terraform maps become `seq<string * string>`, repeated fields accept `seq<'T>`, and common unions (e.g., `bool | cdktf.IResolvable`) expose overloads so you don’t have to pass `obj`.
- **Compile-time required checks** – generated builders track required custom operations with phantom types (`Missing`/`Present`), so omitting a mandatory field (e.g., `name`, `server_type`) produces a compile-time `CompilerMessage` error instead of a runtime failure.
- **Ambient stack support** – `stack "name" { ... }` keeps the current `TerraformStack` available without threading it through every builder.
- **Ready for NuGet** – `dotnet pack` produces individual packages (metadata lives in `src/Core/Nelknet.Cdktf.Core` and each provider project).

## Repository Layout

```
src/Core/Nelknet.Cdktf.Core/        – core helpers (stack DSL, output helpers)
src/Providers/Hcloud/            – generated Hetzner computation expression
src/Providers/_Template/         – scaffold template consumed by the provider manager
samples/Nelknet.Cdktf.HcloudSample/ – minimal stack using the generated Hetzner CE
generated/                       – raw .NET bindings emitted by `cdktf provider add` (ignored; recreated at build time)
tools/Nelknet.Cdktf.CodeGen/     – Fabulous.AST-based generator
tools/Nelknet.Cdktf.ProviderManager/ – CLI helper that refreshes/scaffolds providers
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
2. **Reference the DSL packages you need.** At minimum add the core library plus the provider(s) you want to use:
   ```bash
   dotnet add package Nelknet.Cdktf.Core
   dotnet add package Nelknet.Cdktf.Providers.Hcloud    # or Aws / others
   dotnet add package HashiCorp.Cdktf                   # brings in runtime support
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

During the build MSBuild invokes `tools/Nelknet.Cdktf.ProviderManager` with the `ensure` command for every entry in `cdktf.json`. `ensure` runs `cdktf provider add ... --force-local`, normalises the emitted C# project, builds the `hcloud.dll`/`aws.dll` assemblies, and writes a small marker so subsequent builds skip redundant work.

To refresh a single provider by hand you can call the same helper directly:

```bash
dotnet run --no-build --project tools/Nelknet.Cdktf.ProviderManager \
   -- ensure --provider-id hcloud --source hetznercloud/hcloud --version 1.54.0
```

Afterwards `dotnet build -p:ForceCodeGen=true` (or a plain `dotnet build`) will regenerate the F# DSL using the newly downloaded schema.

## Adding a new provider

Adding a provider no longer involves committing generated artifacts. A typical flow looks like:

1. Edit `cdktf.json` and add the new provider/version to `terraformProviders`.
2. Run the scaffold command once so the deterministic `.fsproj` is created and added to the solution (module/namespace names are derived from the provider id automatically):
   ```bash
   dotnet run --project tools/Nelknet.Cdktf.ProviderManager -- scaffold \
      --provider-id aws \
      --source hashicorp/aws \
      --version 5.100.0
   ```
   The command copies the template under `src/Providers/_Template/`, fills in the metadata, and updates `Nelknet.Cdktf.slnx`.
3. Regenerate code locally (nothing is committed):
   ```bash
   npm install
   dotnet build -p:ForceCodeGen=true
   ```
4. Commit just the handwritten pieces: `cdktf.json`, the new `.fsproj`, and any documentation updates.

Upgrading an existing provider follows the same steps (`scaffold` accepts `--skip-project` if you only want to bump the version). No generated C# or F# files should show up in the diff.

## Using the generated DSL

```fsharp
open Nelknet.Cdktf
open Nelknet.Cdktf.Providers.Hcloud
open Nelknet.Cdktf.Providers.Hcloud.Hcloud
open Nelknet.Cdktf.Terraform

let apiToken = System.Environment.GetEnvironmentVariable "HCLOUD_TOKEN"

let app =
    stack "hcloud-sample" {
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
- `cdktf deploy/destroy` – run the sample stack (requires `HCLOUD_TOKEN`).

Happy infrastructure hacking in F#!
