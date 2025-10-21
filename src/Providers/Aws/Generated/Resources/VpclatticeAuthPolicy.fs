namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeAuthPolicyState<'Policy, 'ResourceIdentifier> = { assignments: ResizeArray<aws.VpclatticeAuthPolicy.VpclatticeAuthPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_auth_policy">aws_vpclattice_auth_policy</a>.
    /// </summary>
    type VpclatticeAuthPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeAuthPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeAuthPolicyState<Missing, Missing>)

        member _.Zero(()) : VpclatticeAuthPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeAuthPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_auth_policy#policy-1">VpclatticeAuthPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: VpclatticeAuthPolicyState<Missing, 'ResourceIdentifier>, value: string) : VpclatticeAuthPolicyState<Present, 'ResourceIdentifier> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : VpclatticeAuthPolicyState<Present, 'ResourceIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_auth_policy#resource_identifier-1">VpclatticeAuthPolicy#resource_identifier</a>.
        /// </summary>
        [<CustomOperation "resource_identifier">]
        member _.ResourceIdentifier(state: VpclatticeAuthPolicyState<'Policy, Missing>, value: string) : VpclatticeAuthPolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.ResourceIdentifier <- value)
            ({ assignments = state.assignments } : VpclatticeAuthPolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_auth_policy#id-1">VpclatticeAuthPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpclatticeAuthPolicyState<'Policy, 'ResourceIdentifier>, value: string) : VpclatticeAuthPolicyState<'Policy, 'ResourceIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpclatticeAuthPolicyState<'Policy, 'ResourceIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_auth_policy#state-1">VpclatticeAuthPolicy#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: VpclatticeAuthPolicyState<'Policy, 'ResourceIdentifier>, value: string) : VpclatticeAuthPolicyState<'Policy, 'ResourceIdentifier> =
            state.assignments.Add(fun config -> config.State <- value)
            state : VpclatticeAuthPolicyState<'Policy, 'ResourceIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_auth_policy#timeouts-1">VpclatticeAuthPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpclatticeAuthPolicyState<'Policy, 'ResourceIdentifier>, value: aws.VpclatticeAuthPolicy.VpclatticeAuthPolicyTimeouts) : VpclatticeAuthPolicyState<'Policy, 'ResourceIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpclatticeAuthPolicyState<'Policy, 'ResourceIdentifier>

        member _.Run(state: VpclatticeAuthPolicyState<Present, Present>) : aws.VpclatticeAuthPolicy.VpclatticeAuthPolicy =
            let config = aws.VpclatticeAuthPolicy.VpclatticeAuthPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeAuthPolicy.VpclatticeAuthPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeAuthPolicy: missing required arguments. Must call: policy, resource_identifier.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeAuthPolicyState<_, _>) : aws.VpclatticeAuthPolicy.VpclatticeAuthPolicy =
            Unchecked.defaultof<aws.VpclatticeAuthPolicy.VpclatticeAuthPolicy>
