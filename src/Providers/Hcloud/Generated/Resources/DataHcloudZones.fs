namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudZonesState = { assignments: ResizeArray<hcloud.DataHcloudZones.DataHcloudZonesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zones">hcloud_zones</a>.
    /// </summary>
    type DataHcloudZonesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudZonesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudZonesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zones#with_selector-1">DataHcloudZones#with_selector</a>
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudZonesState, value: string) : DataHcloudZonesState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudZonesState

        member _.Run(state: DataHcloudZonesState) : hcloud.DataHcloudZones.DataHcloudZones =
            let config = hcloud.DataHcloudZones.DataHcloudZonesConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudZones.DataHcloudZones(StackContext.get (), logicalId, config)
