namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkfirewallResourcePolicyState<'Policy, 'ResourceArn> = { assignments: ResizeArray<aws.NetworkfirewallResourcePolicy.NetworkfirewallResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_resource_policy">aws_networkfirewall_resource_policy</a>.
    /// </summary>
    type NetworkfirewallResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkfirewallResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkfirewallResourcePolicyState<Missing, Missing>)

        member _.Zero(()) : NetworkfirewallResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkfirewallResourcePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_resource_policy#policy-1">NetworkfirewallResourcePolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: NetworkfirewallResourcePolicyState<Missing, 'ResourceArn>, value: string) : NetworkfirewallResourcePolicyState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : NetworkfirewallResourcePolicyState<Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_resource_policy#resource_arn-1">NetworkfirewallResourcePolicy#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: NetworkfirewallResourcePolicyState<'Policy, Missing>, value: string) : NetworkfirewallResourcePolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : NetworkfirewallResourcePolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_resource_policy#id-1">NetworkfirewallResourcePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkfirewallResourcePolicyState<'Policy, 'ResourceArn>, value: string) : NetworkfirewallResourcePolicyState<'Policy, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkfirewallResourcePolicyState<'Policy, 'ResourceArn>

        member _.Run(state: NetworkfirewallResourcePolicyState<Present, Present>) : aws.NetworkfirewallResourcePolicy.NetworkfirewallResourcePolicy =
            let config = aws.NetworkfirewallResourcePolicy.NetworkfirewallResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkfirewallResourcePolicy.NetworkfirewallResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkfirewallResourcePolicy: missing required arguments. Must call: policy, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: NetworkfirewallResourcePolicyState<_, _>) : aws.NetworkfirewallResourcePolicy.NetworkfirewallResourcePolicy =
            Unchecked.defaultof<aws.NetworkfirewallResourcePolicy.NetworkfirewallResourcePolicy>
