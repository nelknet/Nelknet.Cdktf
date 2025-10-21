namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecretsmanagerSecretVersionState<'SecretId> = { assignments: ResizeArray<aws.SecretsmanagerSecretVersion.SecretsmanagerSecretVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_version">aws_secretsmanager_secret_version</a>.
    /// </summary>
    type SecretsmanagerSecretVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecretsmanagerSecretVersionState<Missing> =
            ({ assignments = ResizeArray() } : SecretsmanagerSecretVersionState<Missing>)

        member _.Zero(()) : SecretsmanagerSecretVersionState<Missing> =
            ({ assignments = ResizeArray() } : SecretsmanagerSecretVersionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_version#secret_id-1">SecretsmanagerSecretVersion#secret_id</a>.
        /// </summary>
        [<CustomOperation "secret_id">]
        member _.SecretId(state: SecretsmanagerSecretVersionState<Missing>, value: string) : SecretsmanagerSecretVersionState<Present> =
            state.assignments.Add(fun config -> config.SecretId <- value)
            ({ assignments = state.assignments } : SecretsmanagerSecretVersionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_version#id-1">SecretsmanagerSecretVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecretsmanagerSecretVersionState<'SecretId>, value: string) : SecretsmanagerSecretVersionState<'SecretId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecretsmanagerSecretVersionState<'SecretId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_version#secret_binary-1">SecretsmanagerSecretVersion#secret_binary</a>.
        /// </summary>
        [<CustomOperation "secret_binary">]
        member _.SecretBinary(state: SecretsmanagerSecretVersionState<'SecretId>, value: string) : SecretsmanagerSecretVersionState<'SecretId> =
            state.assignments.Add(fun config -> config.SecretBinary <- value)
            state : SecretsmanagerSecretVersionState<'SecretId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_version#secret_string-1">SecretsmanagerSecretVersion#secret_string</a>.
        /// </summary>
        [<CustomOperation "secret_string">]
        member _.SecretString(state: SecretsmanagerSecretVersionState<'SecretId>, value: string) : SecretsmanagerSecretVersionState<'SecretId> =
            state.assignments.Add(fun config -> config.SecretString <- value)
            state : SecretsmanagerSecretVersionState<'SecretId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_version#secret_string_wo-1">SecretsmanagerSecretVersion#secret_string_wo</a>.
        /// </summary>
        [<CustomOperation "secret_string_wo">]
        member _.SecretStringWo(state: SecretsmanagerSecretVersionState<'SecretId>, value: string) : SecretsmanagerSecretVersionState<'SecretId> =
            state.assignments.Add(fun config -> config.SecretStringWo <- value)
            state : SecretsmanagerSecretVersionState<'SecretId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_version#secret_string_wo_version-1">SecretsmanagerSecretVersion#secret_string_wo_version</a>.
        /// </summary>
        [<CustomOperation "secret_string_wo_version">]
        member _.SecretStringWoVersion(state: SecretsmanagerSecretVersionState<'SecretId>, value: double) : SecretsmanagerSecretVersionState<'SecretId> =
            state.assignments.Add(fun config -> config.SecretStringWoVersion <- value)
            state : SecretsmanagerSecretVersionState<'SecretId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_version#version_stages-1">SecretsmanagerSecretVersion#version_stages</a>.
        /// </summary>
        [<CustomOperation "version_stages">]
        member _.VersionStages(state: SecretsmanagerSecretVersionState<'SecretId>, value: seq<string>) : SecretsmanagerSecretVersionState<'SecretId> =
            state.assignments.Add(fun config -> config.VersionStages <- (value |> Seq.toArray))
            state : SecretsmanagerSecretVersionState<'SecretId>

        member _.Run(state: SecretsmanagerSecretVersionState<Present>) : aws.SecretsmanagerSecretVersion.SecretsmanagerSecretVersion =
            let config = aws.SecretsmanagerSecretVersion.SecretsmanagerSecretVersionConfig()
            for setter in state.assignments do
                setter config
            aws.SecretsmanagerSecretVersion.SecretsmanagerSecretVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.secretsmanagerSecretVersion: missing required arguments. Must call: secret_id.", 9999, IsError = true)>]
        member _.Run(_: SecretsmanagerSecretVersionState<_>) : aws.SecretsmanagerSecretVersion.SecretsmanagerSecretVersion =
            Unchecked.defaultof<aws.SecretsmanagerSecretVersion.SecretsmanagerSecretVersion>
