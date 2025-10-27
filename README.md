# Nelknet.Cdktf

[![NuGet](https://img.shields.io/nuget/v/Nelknet.Cdktf.Core.svg?style=flat-square&label=Nelknet.Cdktf.Core)](https://www.nuget.org/packages/Nelknet.Cdktf.Core/)
[![NuGet](https://img.shields.io/nuget/v/Nelknet.Cdktf.Providers.Aws.svg?style=flat-square&label=AWS)](https://www.nuget.org/packages/Nelknet.Cdktf.Providers.Aws/)
[![NuGet](https://img.shields.io/nuget/v/Nelknet.Cdktf.Providers.Azurerm.svg?style=flat-square&label=Azure)](https://www.nuget.org/packages/Nelknet.Cdktf.Providers.Azurerm/)
[![NuGet](https://img.shields.io/nuget/v/Nelknet.Cdktf.Providers.Hcloud.svg?style=flat-square&label=Hetzner)](https://www.nuget.org/packages/Nelknet.Cdktf.Providers.Hcloud/)
[![NuGet](https://img.shields.io/nuget/v/Nelknet.Cdktf.Providers.Random.svg?style=flat-square&label=Random)](https://www.nuget.org/packages/Nelknet.Cdktf.Providers.Random/)

F# computation expressions and helpers that sit on top of the CDK for Terraform (CDKTF) .NET bindings.  The library is generated directly from a provider's JSII schema so the surface stays in sync with the official SDKs while feeling idiomatic in F# (maps as sequences, arrays as sequences, boolean flags as `bool`, etc.).

## Highlights


https://github.com/user-attachments/assets/8d1e7dd7-f04a-4114-8eae-63253d8f495c


- **Schema‑driven generation** – provider projects carry MSBuild metadata; run `dotnet build` (or `dotnet build -p:ForceCodeGen=true`) to refresh `src/Providers/<Provider>/Generated/...` and commit the regenerated surface alongside your changes.
- **F#‑friendly operations** – Terraform maps become `seq<string * string>`, repeated fields accept `seq<'T>`, and common unions (e.g., `bool | cdktf.IResolvable`) expose overloads so you don't have to pass `obj`.
- **Compile-time required checks** – generated builders track required custom operations with phantom types (`Missing`/`Present`), so omitting a mandatory field (e.g., `name`, `server_type`) produces a compile-time `CompilerMessage` error instead of a runtime failure.
- **Ambient stack support** – `stack "name" { ... }` keeps the current `TerraformStack` available without threading it through every builder.

## Getting Started

Install the NuGet packages for the providers you need, then create your infrastructure as code in F#.

### Prerequisites

- .NET 8 SDK (`dotnet --version` ≥ 8.0)
- Node.js 20.x or 22.x with npm (required by the CDKTF CLI)
- CDKTF CLI 0.21.x – `npm install --global cdktf-cli@0.21`
- Terraform CLI 1.6+ (for `cdktf deploy` / `cdktf destroy`)
- Cloud credentials for the providers you plan to use (e.g., `HCLOUD_TOKEN` for Hetzner)

### Quick Start

1. **Create an infrastructure project**
   ```bash
   mkdir Demo.Infra
   cd Demo.Infra
   dotnet new console -lang F# --framework net8.0
   ```

2. **Install the providers you need**
   ```bash
   dotnet add package Nelknet.Cdktf.Providers.Aws      # For AWS
   dotnet add package Nelknet.Cdktf.Providers.Azurerm  # For Azure
   dotnet add package Nelknet.Cdktf.Providers.Hcloud   # For Hetzner
   ```
   Provider packages bring `Nelknet.Cdktf.Core`, the CDKTF runtime, and the generated C# bindings.

3. **Write your infrastructure**
   ```fsharp
   open Nelknet.Cdktf
   open Nelknet.Cdktf.Providers
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

4. **Add a `cdktf.json` manifest** at the repo root
   ```json
   {
     "language": "csharp",
     "app": "dotnet run --no-build",
     "codeMakerOutput": "generated",
     "terraformProviders": [
       "hashicorp/aws@=5.100.0"
     ],
     "terraformModules": [],
     "context": {}
   }
   ```

5. **Deploy your infrastructure**
   ```bash
   cdktf get         # Download provider tarballs for the CDKTF CLI
   dotnet build      # Compile your stack and verify references
   cdktf synth       # Run the app command and emit Terraform JSON
   cdktf deploy      # Apply the stack (requires provider credentials)
   ```
   `dotnet run` will also synthesize the stack, but `cdktf synth` is what the CLI executes before `cdktf deploy`.

## Example: Hetzner Cloud Server

Here's a complete example using the Hetzner Cloud provider:

```fsharp
open Nelknet.Cdktf
open Nelknet.Cdktf.Providers
open Nelknet.Cdktf.Terraform

let apiToken = System.Environment.GetEnvironmentVariable "HCLOUD_TOKEN"

let app =
    stack "hcloud-example" {
        // Register the provider
        let _ =
            Hcloud.provider "hcloud" {
                token apiToken
                poll_interval "750ms"
            }

        // Create a server - schema-driven CE with compile-time checks
        let server =
            Hcloud.server "sample-server" {
                name "fsharp-sample"           // Required field
                server_type "cpx11"            // Required field
                image "ubuntu-22.04"            // Required field
                labels [ "module", "nelknet" ] // Maps as sequences
            }

        // Expose outputs
        Terraform.output "server-name" {
            value server.Name
            description "Expose the created Hetzner server name"
        }
        |> ignore
    }

app.Synth()
```

Deploy with:
```bash
export HCLOUD_TOKEN=... # Your Hetzner API token
cdktf get
cdktf deploy --auto-approve
cdktf destroy --auto-approve   # Clean up when done
```

## Repository Layout

```plaintext
src/Core/Nelknet.Cdktf.Core/     – core helpers (stack DSL, output helpers)
src/Providers/Hcloud/             – generated Hetzner computation expression
src/Providers/_Template/          – scaffold template consumed by the provider manager
examples/Nelknet.Cdktf.Examples/  – minimal stack using the generated Hetzner example
generated/                        – raw .NET bindings emitted by cdktf provider add (ignored)
tools/Nelknet.Cdktf.CodeGen/      – Fabulous.AST-based generator
```

## Prerequisites

For working with this repository or consuming the packages:

- .NET SDK 8.0 (or newer) – for building the DSL and running stacks
- Node.js 18+ with npm – required by the CDK for Terraform CLI
- CDKTF CLI 0.21.x – `npm install --global cdktf-cli@0.21`
- Terraform CLI 1.6+ – optional for local deploys, required for `cdktf deploy` / `cdktf destroy`

## Development

### Building from Source

After cloning this repository:

```bash
npm install
dotnet build -p:ForceCodeGen=true
```

This installs the local Node dependencies and repopulates the tracked `generated/` and `src/Providers/*/Generated` directories so the solution builds immediately.

You can rerun the combined restore/build pipeline at any time with:

```bash
./scripts/regenerate.sh
```

The same script is used by CI before it commits regenerated outputs back to `main`.

### Adding a New Provider

Adding a new provider is streamlined with the Bootstrap project:

1. **Ask CDKTF to add the provider**
   ```bash
   cdktf provider add hashicorp/random@=3.6.0 --language csharp --force-local
   ```

2. **Scaffold any missing provider projects**
   ```bash
   dotnet fsi tools/scaffold-providers.fsx
   ```

3. **Add the projects to the solution**
   ```bash
   dotnet sln add src/Providers/Random/Nelknet.Cdktf.Providers.Random.fsproj
   dotnet sln add generated/random/random.csproj
   ```

4. **Run the build**
   ```bash
   dotnet build -p:ForceCodeGen=true
   ```

5. **Commit everything**
   - The updated `cdktf.json`
   - The new provider's `.fsproj` file in `src/Providers/<Provider>/`
   - Any documentation updates
   - All generated changes (both `generated/<provider>` and `src/Providers/<Provider>/Generated/**`)

   Push your branch and open a PR. The build workflow simply runs `dotnet build`, so the PR must include the regenerated artifacts to stay green.

### What Happens During the Build

The Bootstrap project (`tools/Nelknet.Cdktf.Bootstrap/`) automatically:
- Reads providers from `cdktf.json`
- Downloads missing providers using `cdktf provider add`
- Normalizes generated C# projects for Central Package Management
- Creates provider F# projects from the template in `src/Providers/_Template/`
- Caches everything to avoid redundant downloads

### Upgrading an Existing Provider

To upgrade a provider version:
1. Update the version in `cdktf.json`.
2. Run `dotnet build -p:ForceCodeGen=true` (or `scripts/regenerate.sh`) to refresh the generated surface.
3. Commit the updated `cdktf.json` together with the regenerated files and open a PR.

## Packaging

Pack the core and providers independently:

```bash
# Core DSL
dotnet pack src/Core/Nelknet.Cdktf.Core/Nelknet.Cdktf.Core.fsproj -c Release -o artifacts

# Hetzner provider (generated)
dotnet pack src/Providers/Hcloud/Nelknet.Cdktf.Providers.Hcloud.fsproj -c Release -o artifacts
```

Publish whichever packages you need (`dotnet nuget push artifacts/*.nupkg`). Consumers can depend on `Nelknet.Cdktf.Core` plus only the provider packages they require.

The repository also ships a `Release` workflow (Actions tab) that builds, packs, and publishes every package to NuGet. Set `NUGET_API_KEY` in your environment or as a repository secret before running it.

## Extending the Generator

The generator is intentionally small so it is easy to extend. Examples of tweaks you can make quickly:

- Detect additional union patterns and add typed overloads
- Add convenience operations (e.g., `labelsFrom` that loads a JSON file) by post-processing `BuilderDefinition`s
- Emit module-level aliases if you prefer short helper names (`Hcloud.server` vs. `Hcloud.serverResource`, etc.)

Because everything is schema-driven you only need to regenerate when the provider version changes—no manual edits to the generated files are necessary.

## Development Scripts

- `dotnet run --project tools/Nelknet.Cdktf.CodeGen` – regenerate computation expressions from `.jsii`
- `dotnet build` – restore and build all projects
- `cdktf deploy/destroy` – run the example stack (requires `HCLOUD_TOKEN`)

Happy infrastructure hacking in F#!
