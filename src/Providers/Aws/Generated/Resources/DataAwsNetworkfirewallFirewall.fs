namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkfirewallFirewallState = { assignments: ResizeArray<aws.DataAwsNetworkfirewallFirewall.DataAwsNetworkfirewallFirewallConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkfirewall_firewall">aws_networkfirewall_firewall</a>.
    /// </summary>
    type DataAwsNetworkfirewallFirewallBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkfirewallFirewallState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsNetworkfirewallFirewallState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkfirewall_firewall#arn-1">DataAwsNetworkfirewallFirewall#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsNetworkfirewallFirewallState, value: string) : DataAwsNetworkfirewallFirewallState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsNetworkfirewallFirewallState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkfirewall_firewall#id-1">DataAwsNetworkfirewallFirewall#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkfirewallFirewallState, value: string) : DataAwsNetworkfirewallFirewallState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkfirewallFirewallState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkfirewall_firewall#name-1">DataAwsNetworkfirewallFirewall#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsNetworkfirewallFirewallState, value: string) : DataAwsNetworkfirewallFirewallState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsNetworkfirewallFirewallState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkfirewall_firewall#tags-1">DataAwsNetworkfirewallFirewall#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkfirewallFirewallState, value: seq<string * string>) : DataAwsNetworkfirewallFirewallState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkfirewallFirewallState

        member _.Run(state: DataAwsNetworkfirewallFirewallState) : aws.DataAwsNetworkfirewallFirewall.DataAwsNetworkfirewallFirewall =
            let config = aws.DataAwsNetworkfirewallFirewall.DataAwsNetworkfirewallFirewallConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkfirewallFirewall.DataAwsNetworkfirewallFirewall(StackContext.get (), logicalId, config)
