# Contributing

Thanks for helping shape the Nelknet.Cdktf ecosystem! This project keeps the generated provider surface out of review and lets automation own the heavy lifting. The guiding principle is:

> **You commit intent; the bot commits generated code.**

## Authoring Changes

1. Update declarative inputs such as `cdktf.json`, provider manifests, or generator settings.
2. Run `scripts/regenerate.sh` if you want to verify the build locally (optional, but recommended before opening a PR).
3. Commit only the source changes from step 1. Leave the generated F# provider code and `generated/<provider>` contents untouched—CI will update them for you.

## Pull Request Flow

Every push to `main` triggers the **Regenerate Providers** workflow:

1. Install dependencies and run `dotnet build -p:ForceCodeGen=true`.
2. Commit any regenerated files with a signed `chore(codegen):` message.
3. Push the automation commit to `main`.

That means a merged contribution typically lands as:

```
<your change>        # authored by you
chore(codegen): ...  # authored by Nelknet CodeGen Bot
```

If you need to inspect or reproduce the generated output locally, re-run `scripts/regenerate.sh`. The script mirrors the CI workflow.

## Automated Signing

The GitHub Action can optionally sign its commits. Add the following repository secrets if you want verified signatures:

| Secret | Purpose |
| --- | --- |
| `REGEN_GPG_PRIVATE_KEY` | ASCII-armored private key used to sign commits |
| `REGEN_GPG_PASSPHRASE` | Passphrase for the private key (leave empty if none) |
| `REGEN_GPG_KEY_ID` | The key ID (short or long) to configure as `user.signingkey` |

If these secrets are not present, the workflow still commits with the GitHub Actions bot identity.

## Questions?

Open an issue or start a discussion if the workflow needs to cover additional scenarios. We're happy to evolve the automation as the provider surface grows.
