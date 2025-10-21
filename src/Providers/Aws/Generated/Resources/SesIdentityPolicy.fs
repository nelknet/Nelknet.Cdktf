namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesIdentityPolicyState<'Identity, 'Name, 'Policy> = { assignments: ResizeArray<aws.SesIdentityPolicy.SesIdentityPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_identity_policy">aws_ses_identity_policy</a>.
    /// </summary>
    type SesIdentityPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesIdentityPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SesIdentityPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : SesIdentityPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SesIdentityPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_identity_policy#identity-1">SesIdentityPolicy#identity</a>.
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: SesIdentityPolicyState<Missing, 'Name, 'Policy>, value: string) : SesIdentityPolicyState<Present, 'Name, 'Policy> =
            state.assignments.Add(fun config -> config.Identity <- value)
            ({ assignments = state.assignments } : SesIdentityPolicyState<Present, 'Name, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_identity_policy#name-1">SesIdentityPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SesIdentityPolicyState<'Identity, Missing, 'Policy>, value: string) : SesIdentityPolicyState<'Identity, Present, 'Policy> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SesIdentityPolicyState<'Identity, Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_identity_policy#policy-1">SesIdentityPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: SesIdentityPolicyState<'Identity, 'Name, Missing>, value: string) : SesIdentityPolicyState<'Identity, 'Name, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : SesIdentityPolicyState<'Identity, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_identity_policy#id-1">SesIdentityPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesIdentityPolicyState<'Identity, 'Name, 'Policy>, value: string) : SesIdentityPolicyState<'Identity, 'Name, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesIdentityPolicyState<'Identity, 'Name, 'Policy>

        member _.Run(state: SesIdentityPolicyState<Present, Present, Present>) : aws.SesIdentityPolicy.SesIdentityPolicy =
            let config = aws.SesIdentityPolicy.SesIdentityPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.SesIdentityPolicy.SesIdentityPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesIdentityPolicy: missing required arguments. Must call: identity, name, policy.", 9999, IsError = true)>]
        member _.Run(_: SesIdentityPolicyState<_, _, _>) : aws.SesIdentityPolicy.SesIdentityPolicy =
            Unchecked.defaultof<aws.SesIdentityPolicy.SesIdentityPolicy>
