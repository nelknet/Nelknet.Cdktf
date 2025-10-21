namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkfirewallFirewallPolicyState = { assignments: ResizeArray<aws.DataAwsNetworkfirewallFirewallPolicy.DataAwsNetworkfirewallFirewallPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkfirewall_firewall_policy">aws_networkfirewall_firewall_policy</a>.
    /// </summary>
    type DataAwsNetworkfirewallFirewallPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkfirewallFirewallPolicyState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsNetworkfirewallFirewallPolicyState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkfirewall_firewall_policy#arn-1">DataAwsNetworkfirewallFirewallPolicy#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsNetworkfirewallFirewallPolicyState, value: string) : DataAwsNetworkfirewallFirewallPolicyState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsNetworkfirewallFirewallPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkfirewall_firewall_policy#id-1">DataAwsNetworkfirewallFirewallPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkfirewallFirewallPolicyState, value: string) : DataAwsNetworkfirewallFirewallPolicyState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkfirewallFirewallPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkfirewall_firewall_policy#name-1">DataAwsNetworkfirewallFirewallPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsNetworkfirewallFirewallPolicyState, value: string) : DataAwsNetworkfirewallFirewallPolicyState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsNetworkfirewallFirewallPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkfirewall_firewall_policy#tags-1">DataAwsNetworkfirewallFirewallPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkfirewallFirewallPolicyState, value: seq<string * string>) : DataAwsNetworkfirewallFirewallPolicyState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkfirewallFirewallPolicyState

        member _.Run(state: DataAwsNetworkfirewallFirewallPolicyState) : aws.DataAwsNetworkfirewallFirewallPolicy.DataAwsNetworkfirewallFirewallPolicy =
            let config = aws.DataAwsNetworkfirewallFirewallPolicy.DataAwsNetworkfirewallFirewallPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkfirewallFirewallPolicy.DataAwsNetworkfirewallFirewallPolicy(StackContext.get (), logicalId, config)
