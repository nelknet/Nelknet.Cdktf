namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Sesv2EmailIdentityPolicyState<'EmailIdentity, 'Policy, 'PolicyName> = { assignments: ResizeArray<aws.Sesv2EmailIdentityPolicy.Sesv2EmailIdentityPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_policy">aws_sesv2_email_identity_policy</a>.
    /// </summary>
    type Sesv2EmailIdentityPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : Sesv2EmailIdentityPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Sesv2EmailIdentityPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : Sesv2EmailIdentityPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Sesv2EmailIdentityPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_policy#email_identity-1">Sesv2EmailIdentityPolicy#email_identity</a>.
        /// </summary>
        [<CustomOperation "email_identity">]
        member _.EmailIdentity(state: Sesv2EmailIdentityPolicyState<Missing, 'Policy, 'PolicyName>, value: string) : Sesv2EmailIdentityPolicyState<Present, 'Policy, 'PolicyName> =
            state.assignments.Add(fun config -> config.EmailIdentity <- value)
            ({ assignments = state.assignments } : Sesv2EmailIdentityPolicyState<Present, 'Policy, 'PolicyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_policy#policy-1">Sesv2EmailIdentityPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: Sesv2EmailIdentityPolicyState<'EmailIdentity, Missing, 'PolicyName>, value: string) : Sesv2EmailIdentityPolicyState<'EmailIdentity, Present, 'PolicyName> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : Sesv2EmailIdentityPolicyState<'EmailIdentity, Present, 'PolicyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_policy#policy_name-1">Sesv2EmailIdentityPolicy#policy_name</a>.
        /// </summary>
        [<CustomOperation "policy_name">]
        member _.PolicyName(state: Sesv2EmailIdentityPolicyState<'EmailIdentity, 'Policy, Missing>, value: string) : Sesv2EmailIdentityPolicyState<'EmailIdentity, 'Policy, Present> =
            state.assignments.Add(fun config -> config.PolicyName <- value)
            ({ assignments = state.assignments } : Sesv2EmailIdentityPolicyState<'EmailIdentity, 'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity_policy#id-1">Sesv2EmailIdentityPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Sesv2EmailIdentityPolicyState<'EmailIdentity, 'Policy, 'PolicyName>, value: string) : Sesv2EmailIdentityPolicyState<'EmailIdentity, 'Policy, 'PolicyName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Sesv2EmailIdentityPolicyState<'EmailIdentity, 'Policy, 'PolicyName>

        member _.Run(state: Sesv2EmailIdentityPolicyState<Present, Present, Present>) : aws.Sesv2EmailIdentityPolicy.Sesv2EmailIdentityPolicy =
            let config = aws.Sesv2EmailIdentityPolicy.Sesv2EmailIdentityPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.Sesv2EmailIdentityPolicy.Sesv2EmailIdentityPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesv2EmailIdentityPolicy: missing required arguments. Must call: email_identity, policy, policy_name.", 9999, IsError = true)>]
        member _.Run(_: Sesv2EmailIdentityPolicyState<_, _, _>) : aws.Sesv2EmailIdentityPolicy.Sesv2EmailIdentityPolicy =
            Unchecked.defaultof<aws.Sesv2EmailIdentityPolicy.Sesv2EmailIdentityPolicy>
