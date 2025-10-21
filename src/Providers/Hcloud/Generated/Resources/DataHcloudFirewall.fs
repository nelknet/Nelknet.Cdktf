namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudFirewallState = { assignments: ResizeArray<hcloud.DataHcloudFirewall.DataHcloudFirewallConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall">hcloud_firewall</a>.
    /// </summary>
    type DataHcloudFirewallBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudFirewallState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudFirewallState =
            { assignments = ResizeArray() }

        /// <summary>
        /// apply_to block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#apply_to-1">DataHcloudFirewall#apply_to</a> Accepts: hcloud.IResolvable | hcloud.DataHcloudFirewall.DataHcloudFirewallApplyTo[]
        /// </summary>
        [<CustomOperation "apply_to">]
        member _.ApplyTo(state: DataHcloudFirewallState, value: HashiCorp.Cdktf.IResolvable) : DataHcloudFirewallState =
            state.assignments.Add(fun config -> config.ApplyTo <- value)
            state : DataHcloudFirewallState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#id-1">DataHcloudFirewall#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudFirewallState, value: double) : DataHcloudFirewallState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudFirewallState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#labels-1">DataHcloudFirewall#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: DataHcloudFirewallState, value: seq<string * string>) : DataHcloudFirewallState =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : DataHcloudFirewallState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#most_recent-1">DataHcloudFirewall#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudFirewallState, value: bool) : DataHcloudFirewallState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudFirewallState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#most_recent-1">DataHcloudFirewall#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudFirewallState, value: HashiCorp.Cdktf.IResolvable) : DataHcloudFirewallState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudFirewallState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#name-1">DataHcloudFirewall#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudFirewallState, value: string) : DataHcloudFirewallState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudFirewallState

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#rule-1">DataHcloudFirewall#rule</a> Accepts: hcloud.IResolvable | hcloud.DataHcloudFirewall.DataHcloudFirewallRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: DataHcloudFirewallState, value: HashiCorp.Cdktf.IResolvable) : DataHcloudFirewallState =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : DataHcloudFirewallState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#with_selector-1">DataHcloudFirewall#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudFirewallState, value: string) : DataHcloudFirewallState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudFirewallState

        member _.Run(state: DataHcloudFirewallState) : hcloud.DataHcloudFirewall.DataHcloudFirewall =
            let config = hcloud.DataHcloudFirewall.DataHcloudFirewallConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudFirewall.DataHcloudFirewall(StackContext.get (), logicalId, config)
