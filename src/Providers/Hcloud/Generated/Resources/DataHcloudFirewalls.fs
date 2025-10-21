namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudFirewallsState = { assignments: ResizeArray<hcloud.DataHcloudFirewalls.DataHcloudFirewallsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewalls">hcloud_firewalls</a>.
    /// </summary>
    type DataHcloudFirewallsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudFirewallsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudFirewallsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewalls#id-1">DataHcloudFirewalls#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudFirewallsState, value: string) : DataHcloudFirewallsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudFirewallsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewalls#most_recent-1">DataHcloudFirewalls#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudFirewallsState, value: bool) : DataHcloudFirewallsState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudFirewallsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewalls#most_recent-1">DataHcloudFirewalls#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudFirewallsState, value: HashiCorp.Cdktf.IResolvable) : DataHcloudFirewallsState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudFirewallsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewalls#with_selector-1">DataHcloudFirewalls#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudFirewallsState, value: string) : DataHcloudFirewallsState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudFirewallsState

        member _.Run(state: DataHcloudFirewallsState) : hcloud.DataHcloudFirewalls.DataHcloudFirewalls =
            let config = hcloud.DataHcloudFirewalls.DataHcloudFirewallsConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudFirewalls.DataHcloudFirewalls(StackContext.get (), logicalId, config)
