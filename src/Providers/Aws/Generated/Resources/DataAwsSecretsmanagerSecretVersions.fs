namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSecretsmanagerSecretVersionsState<'SecretId> = { assignments: ResizeArray<aws.DataAwsSecretsmanagerSecretVersions.DataAwsSecretsmanagerSecretVersionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret_versions">aws_secretsmanager_secret_versions</a>.
    /// </summary>
    type DataAwsSecretsmanagerSecretVersionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSecretsmanagerSecretVersionsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSecretsmanagerSecretVersionsState<Missing>)

        member _.Zero(()) : DataAwsSecretsmanagerSecretVersionsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSecretsmanagerSecretVersionsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret_versions#secret_id-1">DataAwsSecretsmanagerSecretVersions#secret_id</a>.
        /// </summary>
        [<CustomOperation "secret_id">]
        member _.SecretId(state: DataAwsSecretsmanagerSecretVersionsState<Missing>, value: string) : DataAwsSecretsmanagerSecretVersionsState<Present> =
            state.assignments.Add(fun config -> config.SecretId <- value)
            ({ assignments = state.assignments } : DataAwsSecretsmanagerSecretVersionsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret_versions#include_deprecated-1">DataAwsSecretsmanagerSecretVersions#include_deprecated</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated(state: DataAwsSecretsmanagerSecretVersionsState<'SecretId>, value: bool) : DataAwsSecretsmanagerSecretVersionsState<'SecretId> =
            state.assignments.Add(fun config -> config.IncludeDeprecated <- value)
            state : DataAwsSecretsmanagerSecretVersionsState<'SecretId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret_versions#include_deprecated-1">DataAwsSecretsmanagerSecretVersions#include_deprecated</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated(state: DataAwsSecretsmanagerSecretVersionsState<'SecretId>, value: HashiCorp.Cdktf.IResolvable) : DataAwsSecretsmanagerSecretVersionsState<'SecretId> =
            state.assignments.Add(fun config -> config.IncludeDeprecated <- value)
            state : DataAwsSecretsmanagerSecretVersionsState<'SecretId>

        member _.Run(state: DataAwsSecretsmanagerSecretVersionsState<Present>) : aws.DataAwsSecretsmanagerSecretVersions.DataAwsSecretsmanagerSecretVersions =
            let config = aws.DataAwsSecretsmanagerSecretVersions.DataAwsSecretsmanagerSecretVersionsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSecretsmanagerSecretVersions.DataAwsSecretsmanagerSecretVersions(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSecretsmanagerSecretVersions: missing required arguments. Must call: secret_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSecretsmanagerSecretVersionsState<_>) : aws.DataAwsSecretsmanagerSecretVersions.DataAwsSecretsmanagerSecretVersions =
            Unchecked.defaultof<aws.DataAwsSecretsmanagerSecretVersions.DataAwsSecretsmanagerSecretVersions>
