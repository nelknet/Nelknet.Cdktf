# Repository Guidelines

## Project Structure & Module Organization
- `src/Core/Nelknet.Cdktf.Core`: core computation-expression infrastructure (`Core.fs`, `TerraformOutputs.fs`); published as the `Nelknet.Cdktf.Core` package.
- `src/Providers/<Provider>`: generated provider modules (e.g., `src/Providers/Hcloud`); each contains a provider-specific `.fsproj` and `Generated/` subtree emitted by the code generator.  Treat generated files as read-only.
- `generated/<provider>`: raw C# bindings emitted by `cdktf provider add`; the directory is ignored by git and repopulated automatically by the build.
- `samples/Nelknet.Cdktf.HcloudSample`: runnable stack exercising the generated Hetzner DSL; requires `HCLOUD_TOKEN`.
- `tools/Nelknet.Cdktf.CodeGen`: Fabulous.AST generator.  MSBuild targets call it automatically before build; you can also run it manually for a single provider.
- `cdktf.out` is throwaway Terraform output; exclude from commits. `source_code_references/` is read-only inspiration—do not modify.

## Build, Test, and Development Commands
- `npm install` (once per clone) to install the local `cdktf`/`constructs` packages.
- `dotnet build -p:ForceCodeGen=true` (or just `dotnet build`) restores core projects, runs the provider ensure step, and regenerates the F# surface.
- `dotnet run --project samples/Nelknet.Cdktf.HcloudSample`: executes the Hetzner sample; fails fast if `HCLOUD_TOKEN` is missing.
- `HCLOUD_TOKEN=... cdktf synth|diff|deploy`: synthesize, diff, or deploy using the generated DSL.
- `dotnet run --project tools/Nelknet.Cdktf.CodeGen -- --provider-id <id> --module-name <Module> --namespace <ns> --package-dir <path> --output-root <path>`: manually regenerate a specific provider (MSBuild normally handles this).

## Coding Style & Naming Conventions
Use 4-space indentation and organise modules per file (`ModuleName.fs`). Keep `open` statements minimal and sorted by dependency depth. Public modules, types, and computation expressions stay PascalCase; builder operations mirror provider field names (`server_type`, `poll_interval`) to match Terraform schemas. Generated files should not be edited manually; prefer updating the generator instead.

## Testing Guidelines
There is no dedicated test project yet; validate changes by running the Hetzner sample and inspecting `cdktf synth` output before opening a PR. When adding automated tests, prefer F#-native frameworks (e.g., Expecto) and place them alongside the domain (`*/Tests` project per area). Name test modules after the feature under test and keep test data provider-neutral to allow offline execution. Document any manual verification steps (diff, deploy) in the PR body.

## Commit & Pull Request Guidelines
Git metadata is not bundled with this sandbox, but upstream history uses concise imperative subjects. Follow a Conventional Commit-style prefix when it clarifies scope (`feat(stack):`, `fix(hcloud):`). One change per commit, and note Terraform-impacting updates in the body. Pull requests should include: summary of intent, list of validation commands (`dotnet build`, `cdktf synth`), and links to related issues. Attach `cdktf diff` output or screenshots when infrastructure changes user-visible resources. Confirm secrets (like `HCLOUD_TOKEN`) remain out of tracked files.
