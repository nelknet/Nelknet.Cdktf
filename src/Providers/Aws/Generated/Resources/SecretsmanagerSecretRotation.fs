namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecretsmanagerSecretRotationState<'RotationRules, 'SecretId> = { assignments: ResizeArray<aws.SecretsmanagerSecretRotation.SecretsmanagerSecretRotationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_rotation">aws_secretsmanager_secret_rotation</a>.
    /// </summary>
    type SecretsmanagerSecretRotationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecretsmanagerSecretRotationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecretsmanagerSecretRotationState<Missing, Missing>)

        member _.Zero(()) : SecretsmanagerSecretRotationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecretsmanagerSecretRotationState<Missing, Missing>)

        /// <summary>
        /// rotation_rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_rotation#rotation_rules-1">SecretsmanagerSecretRotation#rotation_rules</a>
        /// </summary>
        [<CustomOperation "rotation_rules">]
        member _.RotationRules(state: SecretsmanagerSecretRotationState<Missing, 'SecretId>, value: aws.SecretsmanagerSecretRotation.SecretsmanagerSecretRotationRotationRules) : SecretsmanagerSecretRotationState<Present, 'SecretId> =
            state.assignments.Add(fun config -> config.RotationRules <- value)
            ({ assignments = state.assignments } : SecretsmanagerSecretRotationState<Present, 'SecretId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_rotation#secret_id-1">SecretsmanagerSecretRotation#secret_id</a>.
        /// </summary>
        [<CustomOperation "secret_id">]
        member _.SecretId(state: SecretsmanagerSecretRotationState<'RotationRules, Missing>, value: string) : SecretsmanagerSecretRotationState<'RotationRules, Present> =
            state.assignments.Add(fun config -> config.SecretId <- value)
            ({ assignments = state.assignments } : SecretsmanagerSecretRotationState<'RotationRules, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_rotation#id-1">SecretsmanagerSecretRotation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecretsmanagerSecretRotationState<'RotationRules, 'SecretId>, value: string) : SecretsmanagerSecretRotationState<'RotationRules, 'SecretId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecretsmanagerSecretRotationState<'RotationRules, 'SecretId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_rotation#rotate_immediately-1">SecretsmanagerSecretRotation#rotate_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "rotate_immediately">]
        member _.RotateImmediately(state: SecretsmanagerSecretRotationState<'RotationRules, 'SecretId>, value: bool) : SecretsmanagerSecretRotationState<'RotationRules, 'SecretId> =
            state.assignments.Add(fun config -> config.RotateImmediately <- value)
            state : SecretsmanagerSecretRotationState<'RotationRules, 'SecretId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_rotation#rotate_immediately-1">SecretsmanagerSecretRotation#rotate_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "rotate_immediately">]
        member _.RotateImmediately(state: SecretsmanagerSecretRotationState<'RotationRules, 'SecretId>, value: HashiCorp.Cdktf.IResolvable) : SecretsmanagerSecretRotationState<'RotationRules, 'SecretId> =
            state.assignments.Add(fun config -> config.RotateImmediately <- value)
            state : SecretsmanagerSecretRotationState<'RotationRules, 'SecretId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_rotation#rotation_lambda_arn-1">SecretsmanagerSecretRotation#rotation_lambda_arn</a>.
        /// </summary>
        [<CustomOperation "rotation_lambda_arn">]
        member _.RotationLambdaArn(state: SecretsmanagerSecretRotationState<'RotationRules, 'SecretId>, value: string) : SecretsmanagerSecretRotationState<'RotationRules, 'SecretId> =
            state.assignments.Add(fun config -> config.RotationLambdaArn <- value)
            state : SecretsmanagerSecretRotationState<'RotationRules, 'SecretId>

        member _.Run(state: SecretsmanagerSecretRotationState<Present, Present>) : aws.SecretsmanagerSecretRotation.SecretsmanagerSecretRotation =
            let config = aws.SecretsmanagerSecretRotation.SecretsmanagerSecretRotationConfig()
            for setter in state.assignments do
                setter config
            aws.SecretsmanagerSecretRotation.SecretsmanagerSecretRotation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.secretsmanagerSecretRotation: missing required arguments. Must call: rotation_rules, secret_id.", 9999, IsError = true)>]
        member _.Run(_: SecretsmanagerSecretRotationState<_, _>) : aws.SecretsmanagerSecretRotation.SecretsmanagerSecretRotation =
            Unchecked.defaultof<aws.SecretsmanagerSecretRotation.SecretsmanagerSecretRotation>
