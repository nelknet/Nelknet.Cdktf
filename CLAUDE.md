# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is an F# Infrastructure-as-Code DSL that wraps the CDK for Terraform (CDKTF). It provides computation expressions for defining Terraform infrastructure with strong typing and ergonomic F# syntax, similar to Pulumi.FSharp.Extensions but targeting Terraform providers.

## Common Development Commands

### Building and Running
```bash
# Build entire solution
dotnet build

# Run the Hetzner sample (requires HCLOUD_TOKEN)
HCLOUD_TOKEN=your-token dotnet run --project samples/Nelknet.Cdktf.HcloudSample

# Synthesize Terraform configuration to cdktf.out/
HCLOUD_TOKEN=your-token cdktf synth

# Run code generator to update Fabulous.AST preview
dotnet run --project tools/Nelknet.Cdktf.CodeGen -- --provider-id hcloud --module-name Hcloud --namespace Nelknet.Cdktf.Providers.Hcloud --package-dir generated/hcloud --output-root src/Providers/Hcloud/Generated

# Deploy to Hetzner (requires valid token)
HCLOUD_TOKEN=your-token cdktf deploy

# Show what would change without applying
HCLOUD_TOKEN=your-token cdktf diff
```

### Provider Management
```bash
# Refresh Hetzner provider bindings (C# + F#)
rm -rf generated/hcloud
cdktf provider add hetznercloud/hcloud --language=csharp
# Provider-specific .fsproj files will rerun the F# generator on build.
```

## Architecture & Key Design Patterns

### Stack Context Pattern
The `stack { }` computation expression manages CDKTF App/Stack lifecycle using `AsyncLocal<TerraformStack>` to provide ambient context. This eliminates explicit stack parameter passing to nested builders.

```fsharp
// Entry point - creates App and Stack, sets ambient context
stack "my-stack" {
    // All nested builders access stack via StackContext.get()
    let provider = Hcloud.provider "hcloud" { ... }
    let server = Hcloud.server "web" { ... }
}
```

### Computation Expression Builders
Each resource type has a dedicated builder with custom operations that mirror Terraform schema field names:

- `StackBuilder` in `Core.fs` - Top-level stack management
- `ProviderBuilder` in `HcloudDsl.fs` - Provider configuration (token, poll_interval)
- `ServerBuilder` in `HcloudDsl.fs` - Server resource (name, server_type, image, labels)
- `OutputBuilder` in `TerraformOutputs.fs` - Terraform outputs (value, description, sensitive)

Custom operations use snake_case to match Terraform schema conventions.

### Provider Bindings Architecture
```
F# DSL core (src/Core/Nelknet.Cdktf.FSharp.Core/)
    ↓ wraps
Generated C# bindings (generated/hcloud/)
    ↓ uses
CDKTF base classes (HashiCorp.Cdktf)
    ↓ via JSII Runtime
TypeScript CDKTF core
    ↓ synthesizes to
Terraform JSON (cdktf.out/)
```

## Code Organization

### Core DSL Files
- `src/Core/Nelknet.Cdktf.FSharp.Core/Core.fs` - Stack context and main computation expression
- `src/Core/Nelknet.Cdktf.FSharp.Core/TerraformOutputs.fs` - Output builder
- `src/Providers/<Provider>/Generated/...` - Generated provider DSL (Hetzner today, others later)

### Generated Code
- `generated/<provider>/` - C# provider bindings from `cdktf provider add` (do not edit)
- `src/Providers/<Provider>/Generated/...` - Fabulous.AST output (regenerates automatically via MSBuild targets)

### Important Configuration
- `cdktf.json` - CDKTF app configuration, points to sample project
- `Directory.Packages.props` - Central package versions (CDKTF 0.21.0, JSII 1.112.0)
- Solution targets .NET 8.0 throughout

## Development Guidelines

### When Adding New Providers
1. Run `cdktf provider add <provider> --language=csharp` (ensure the generated `.csproj` targets `net8.0`).
2. Copy `src/Providers/Hcloud` to `src/Providers/<Provider>` and update the property group (`ProviderId`, `ProviderModule`, `ProviderNamespace`, `ProviderPackageDir`).
3. Run `dotnet build` (or invoke the generator manually) to emit `src/Providers/<Provider>/Generated` files.
4. Custom operations mirror Terraform schema field names—changes should happen via the generator, not manual edits.

### Code Generation Strategy
- Using Fabulous.AST (not Myriad) for a simple build pipeline.
- Generator lives in `tools/Nelknet.Cdktf.CodeGen/` and accepts command-line arguments.
- Provider projects import `build/CodeGen.targets`, which runs the generator before build when needed.
- Generated code is kept in source control so schema diffs are reviewable.

### Testing Approach
- No automated tests yet - validate via `cdktf synth` and manual inspection
- Always run `dotnet build` before commits
- Check synthesized JSON in `cdktf.out/` matches expectations
- Never commit `cdktf.out/` or secrets

## Important Notes

- `source_code_references/Pulumi.FSharp.Extensions/` is read-only reference material
- The `cdktf.out/` directory is ephemeral - exclude from commits
- Environment variable `HCLOUD_TOKEN` required for Hetzner operations
- Generated C# projects use JSII for TypeScript interop - do not modify JSII metadata