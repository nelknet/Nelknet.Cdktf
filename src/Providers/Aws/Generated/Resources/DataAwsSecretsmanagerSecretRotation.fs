namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSecretsmanagerSecretRotationState<'SecretId> = { assignments: ResizeArray<aws.DataAwsSecretsmanagerSecretRotation.DataAwsSecretsmanagerSecretRotationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret_rotation">aws_secretsmanager_secret_rotation</a>.
    /// </summary>
    type DataAwsSecretsmanagerSecretRotationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSecretsmanagerSecretRotationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSecretsmanagerSecretRotationState<Missing>)

        member _.Zero(()) : DataAwsSecretsmanagerSecretRotationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSecretsmanagerSecretRotationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret_rotation#secret_id-1">DataAwsSecretsmanagerSecretRotation#secret_id</a>.
        /// </summary>
        [<CustomOperation "secret_id">]
        member _.SecretId(state: DataAwsSecretsmanagerSecretRotationState<Missing>, value: string) : DataAwsSecretsmanagerSecretRotationState<Present> =
            state.assignments.Add(fun config -> config.SecretId <- value)
            ({ assignments = state.assignments } : DataAwsSecretsmanagerSecretRotationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/secretsmanager_secret_rotation#id-1">DataAwsSecretsmanagerSecretRotation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSecretsmanagerSecretRotationState<'SecretId>, value: string) : DataAwsSecretsmanagerSecretRotationState<'SecretId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSecretsmanagerSecretRotationState<'SecretId>

        member _.Run(state: DataAwsSecretsmanagerSecretRotationState<Present>) : aws.DataAwsSecretsmanagerSecretRotation.DataAwsSecretsmanagerSecretRotation =
            let config = aws.DataAwsSecretsmanagerSecretRotation.DataAwsSecretsmanagerSecretRotationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSecretsmanagerSecretRotation.DataAwsSecretsmanagerSecretRotation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSecretsmanagerSecretRotation: missing required arguments. Must call: secret_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSecretsmanagerSecretRotationState<_>) : aws.DataAwsSecretsmanagerSecretRotation.DataAwsSecretsmanagerSecretRotation =
            Unchecked.defaultof<aws.DataAwsSecretsmanagerSecretRotation.DataAwsSecretsmanagerSecretRotation>
