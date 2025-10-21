namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeResourcePolicyState<'Policy, 'ResourceArn> = { assignments: ResizeArray<aws.VpclatticeResourcePolicy.VpclatticeResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_policy">aws_vpclattice_resource_policy</a>.
    /// </summary>
    type VpclatticeResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeResourcePolicyState<Missing, Missing>)

        member _.Zero(()) : VpclatticeResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeResourcePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_policy#policy-1">VpclatticeResourcePolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: VpclatticeResourcePolicyState<Missing, 'ResourceArn>, value: string) : VpclatticeResourcePolicyState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : VpclatticeResourcePolicyState<Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_policy#resource_arn-1">VpclatticeResourcePolicy#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: VpclatticeResourcePolicyState<'Policy, Missing>, value: string) : VpclatticeResourcePolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : VpclatticeResourcePolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_policy#id-1">VpclatticeResourcePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpclatticeResourcePolicyState<'Policy, 'ResourceArn>, value: string) : VpclatticeResourcePolicyState<'Policy, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpclatticeResourcePolicyState<'Policy, 'ResourceArn>

        member _.Run(state: VpclatticeResourcePolicyState<Present, Present>) : aws.VpclatticeResourcePolicy.VpclatticeResourcePolicy =
            let config = aws.VpclatticeResourcePolicy.VpclatticeResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeResourcePolicy.VpclatticeResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeResourcePolicy: missing required arguments. Must call: policy, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeResourcePolicyState<_, _>) : aws.VpclatticeResourcePolicy.VpclatticeResourcePolicy =
            Unchecked.defaultof<aws.VpclatticeResourcePolicy.VpclatticeResourcePolicy>
