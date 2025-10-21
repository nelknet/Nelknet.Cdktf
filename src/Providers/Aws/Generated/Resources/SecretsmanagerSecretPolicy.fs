namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecretsmanagerSecretPolicyState<'Policy, 'SecretArn> = { assignments: ResizeArray<aws.SecretsmanagerSecretPolicy.SecretsmanagerSecretPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_policy">aws_secretsmanager_secret_policy</a>.
    /// </summary>
    type SecretsmanagerSecretPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecretsmanagerSecretPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecretsmanagerSecretPolicyState<Missing, Missing>)

        member _.Zero(()) : SecretsmanagerSecretPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecretsmanagerSecretPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_policy#policy-1">SecretsmanagerSecretPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: SecretsmanagerSecretPolicyState<Missing, 'SecretArn>, value: string) : SecretsmanagerSecretPolicyState<Present, 'SecretArn> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : SecretsmanagerSecretPolicyState<Present, 'SecretArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_policy#secret_arn-1">SecretsmanagerSecretPolicy#secret_arn</a>.
        /// </summary>
        [<CustomOperation "secret_arn">]
        member _.SecretArn(state: SecretsmanagerSecretPolicyState<'Policy, Missing>, value: string) : SecretsmanagerSecretPolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.SecretArn <- value)
            ({ assignments = state.assignments } : SecretsmanagerSecretPolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_policy#block_public_policy-1">SecretsmanagerSecretPolicy#block_public_policy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "block_public_policy">]
        member _.BlockPublicPolicy(state: SecretsmanagerSecretPolicyState<'Policy, 'SecretArn>, value: bool) : SecretsmanagerSecretPolicyState<'Policy, 'SecretArn> =
            state.assignments.Add(fun config -> config.BlockPublicPolicy <- value)
            state : SecretsmanagerSecretPolicyState<'Policy, 'SecretArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_policy#block_public_policy-1">SecretsmanagerSecretPolicy#block_public_policy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "block_public_policy">]
        member _.BlockPublicPolicy(state: SecretsmanagerSecretPolicyState<'Policy, 'SecretArn>, value: HashiCorp.Cdktf.IResolvable) : SecretsmanagerSecretPolicyState<'Policy, 'SecretArn> =
            state.assignments.Add(fun config -> config.BlockPublicPolicy <- value)
            state : SecretsmanagerSecretPolicyState<'Policy, 'SecretArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/secretsmanager_secret_policy#id-1">SecretsmanagerSecretPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecretsmanagerSecretPolicyState<'Policy, 'SecretArn>, value: string) : SecretsmanagerSecretPolicyState<'Policy, 'SecretArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecretsmanagerSecretPolicyState<'Policy, 'SecretArn>

        member _.Run(state: SecretsmanagerSecretPolicyState<Present, Present>) : aws.SecretsmanagerSecretPolicy.SecretsmanagerSecretPolicy =
            let config = aws.SecretsmanagerSecretPolicy.SecretsmanagerSecretPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.SecretsmanagerSecretPolicy.SecretsmanagerSecretPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.secretsmanagerSecretPolicy: missing required arguments. Must call: policy, secret_arn.", 9999, IsError = true)>]
        member _.Run(_: SecretsmanagerSecretPolicyState<_, _>) : aws.SecretsmanagerSecretPolicy.SecretsmanagerSecretPolicy =
            Unchecked.defaultof<aws.SecretsmanagerSecretPolicy.SecretsmanagerSecretPolicy>
