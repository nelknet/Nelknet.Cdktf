namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudZoneState = { assignments: ResizeArray<hcloud.DataHcloudZone.DataHcloudZoneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone">hcloud_zone</a>.
    /// </summary>
    type DataHcloudZoneBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudZoneState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudZoneState =
            { assignments = ResizeArray() }

        /// <summary>
        /// ID of the Zone. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone#id-1">DataHcloudZone#id</a> Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudZoneState, value: double) : DataHcloudZoneState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudZoneState

        /// <summary>
        /// Name of the Zone. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone#name-1">DataHcloudZone#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudZoneState, value: string) : DataHcloudZoneState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudZoneState

        /// <summary>
        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone#with_selector-1">DataHcloudZone#with_selector</a>
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudZoneState, value: string) : DataHcloudZoneState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudZoneState

        member _.Run(state: DataHcloudZoneState) : hcloud.DataHcloudZone.DataHcloudZone =
            let config = hcloud.DataHcloudZone.DataHcloudZoneConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudZone.DataHcloudZone(StackContext.get (), logicalId, config)
