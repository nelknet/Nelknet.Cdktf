namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudNetworkState = { assignments: ResizeArray<hcloud.DataHcloudNetwork.DataHcloudNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network">hcloud_network</a>.
    /// </summary>
    type DataHcloudNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudNetworkState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudNetworkState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#id-1">DataHcloudNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudNetworkState, value: double) : DataHcloudNetworkState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudNetworkState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#ip_range-1">DataHcloudNetwork#ip_range</a>.
        /// </summary>
        [<CustomOperation "ip_range">]
        member _.IpRange(state: DataHcloudNetworkState, value: string) : DataHcloudNetworkState =
            state.assignments.Add(fun config -> config.IpRange <- value)
            state : DataHcloudNetworkState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#labels-1">DataHcloudNetwork#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: DataHcloudNetworkState, value: seq<string * string>) : DataHcloudNetworkState =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : DataHcloudNetworkState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#most_recent-1">DataHcloudNetwork#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudNetworkState, value: bool) : DataHcloudNetworkState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudNetworkState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#most_recent-1">DataHcloudNetwork#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudNetworkState, value: HashiCorp.Cdktf.IResolvable) : DataHcloudNetworkState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudNetworkState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#name-1">DataHcloudNetwork#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudNetworkState, value: string) : DataHcloudNetworkState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudNetworkState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#with_selector-1">DataHcloudNetwork#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudNetworkState, value: string) : DataHcloudNetworkState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudNetworkState

        member _.Run(state: DataHcloudNetworkState) : hcloud.DataHcloudNetwork.DataHcloudNetwork =
            let config = hcloud.DataHcloudNetwork.DataHcloudNetworkConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudNetwork.DataHcloudNetwork(StackContext.get (), logicalId, config)
