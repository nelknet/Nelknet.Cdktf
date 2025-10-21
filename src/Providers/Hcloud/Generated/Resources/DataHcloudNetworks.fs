namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudNetworksState = { assignments: ResizeArray<hcloud.DataHcloudNetworks.DataHcloudNetworksConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/networks">hcloud_networks</a>.
    /// </summary>
    type DataHcloudNetworksBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudNetworksState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudNetworksState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/networks#id-1">DataHcloudNetworks#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudNetworksState, value: string) : DataHcloudNetworksState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudNetworksState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/networks#with_selector-1">DataHcloudNetworks#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudNetworksState, value: string) : DataHcloudNetworksState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudNetworksState

        member _.Run(state: DataHcloudNetworksState) : hcloud.DataHcloudNetworks.DataHcloudNetworks =
            let config = hcloud.DataHcloudNetworks.DataHcloudNetworksConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudNetworks.DataHcloudNetworks(StackContext.get (), logicalId, config)
