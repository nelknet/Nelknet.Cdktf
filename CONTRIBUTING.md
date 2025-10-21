# Contributing

Thanks for helping shape the Nelknet.Cdktf ecosystem! The generated provider surface lives in the repository, so every change needs to keep those files in sync. The high-level loop is:

1. Edit the source you care about (for example `cdktf.json`, templates, documentation, etc.).
2. Run `dotnet build -p:ForceCodeGen=true` (or `./scripts/regenerate.sh`) so the generated code under `generated/` and `src/Providers/*/Generated/` updates.
3. Review `git status`, stage both your intent changes and the regenerated output, and open a PR.

The CI workflow is intentionally minimal—it only runs `dotnet build -p:ForceCodeGen=true` on pull requests and pushes to `main`. If the build passes locally, it should pass in CI as well.

## Releasing packages

A manual **Release** workflow is available under the Actions tab. It expects a `NUGET_API_KEY` secret (or environment variable when run locally). The job builds the solution in Release mode, packs:

- `Nelknet.Cdktf.Core`
- `Nelknet.Cdktf.Providers.Aws`
- `Nelknet.Cdktf.Providers.Azurerm`
- `Nelknet.Cdktf.Providers.Hcloud`
- `Nelknet.Cdktf.Providers.Random`

and pushes all packages to NuGet with version `0.1.0` (the version declared in each project). Each provider package already bundles the generated C# assembly (`aws.dll`, `hcloud.dll`, etc.), so consumers can install a provider package and reference it directly without extra steps.

## Need help?

Open an issue or discussion if you run into problems with the build or release flow.
