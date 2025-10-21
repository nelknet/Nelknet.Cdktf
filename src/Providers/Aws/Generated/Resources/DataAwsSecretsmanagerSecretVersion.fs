namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSecretsmanagerSecretVersionState<'SecretId> = { assignments: ResizeArray<aws.DataAwsSecretsmanagerSecretVersion.DataAwsSecretsmanagerSecretVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret_version">aws_secretsmanager_secret_version</a>.
    /// </summary>
    type DataAwsSecretsmanagerSecretVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSecretsmanagerSecretVersionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSecretsmanagerSecretVersionState<Missing>)

        member _.Zero(()) : DataAwsSecretsmanagerSecretVersionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSecretsmanagerSecretVersionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret_version#secret_id-1">DataAwsSecretsmanagerSecretVersion#secret_id</a>.
        /// </summary>
        [<CustomOperation "secret_id">]
        member _.SecretId(state: DataAwsSecretsmanagerSecretVersionState<Missing>, value: string) : DataAwsSecretsmanagerSecretVersionState<Present> =
            state.assignments.Add(fun config -> config.SecretId <- value)
            ({ assignments = state.assignments } : DataAwsSecretsmanagerSecretVersionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret_version#id-1">DataAwsSecretsmanagerSecretVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSecretsmanagerSecretVersionState<'SecretId>, value: string) : DataAwsSecretsmanagerSecretVersionState<'SecretId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSecretsmanagerSecretVersionState<'SecretId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret_version#version_id-1">DataAwsSecretsmanagerSecretVersion#version_id</a>.
        /// </summary>
        [<CustomOperation "version_id">]
        member _.VersionId(state: DataAwsSecretsmanagerSecretVersionState<'SecretId>, value: string) : DataAwsSecretsmanagerSecretVersionState<'SecretId> =
            state.assignments.Add(fun config -> config.VersionId <- value)
            state : DataAwsSecretsmanagerSecretVersionState<'SecretId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret_version#version_stage-1">DataAwsSecretsmanagerSecretVersion#version_stage</a>.
        /// </summary>
        [<CustomOperation "version_stage">]
        member _.VersionStage(state: DataAwsSecretsmanagerSecretVersionState<'SecretId>, value: string) : DataAwsSecretsmanagerSecretVersionState<'SecretId> =
            state.assignments.Add(fun config -> config.VersionStage <- value)
            state : DataAwsSecretsmanagerSecretVersionState<'SecretId>

        member _.Run(state: DataAwsSecretsmanagerSecretVersionState<Present>) : aws.DataAwsSecretsmanagerSecretVersion.DataAwsSecretsmanagerSecretVersion =
            let config = aws.DataAwsSecretsmanagerSecretVersion.DataAwsSecretsmanagerSecretVersionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSecretsmanagerSecretVersion.DataAwsSecretsmanagerSecretVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSecretsmanagerSecretVersion: missing required arguments. Must call: secret_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSecretsmanagerSecretVersionState<_>) : aws.DataAwsSecretsmanagerSecretVersion.DataAwsSecretsmanagerSecretVersion =
            Unchecked.defaultof<aws.DataAwsSecretsmanagerSecretVersion.DataAwsSecretsmanagerSecretVersion>
