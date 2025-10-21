namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudZoneRrsetsState<'Zone> = { assignments: ResizeArray<hcloud.DataHcloudZoneRrsets.DataHcloudZoneRrsetsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrsets">hcloud_zone_rrsets</a>.
    /// </summary>
    type DataHcloudZoneRrsetsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudZoneRrsetsState<Missing> =
            ({ assignments = ResizeArray() } : DataHcloudZoneRrsetsState<Missing>)

        member _.Zero(()) : DataHcloudZoneRrsetsState<Missing> =
            ({ assignments = ResizeArray() } : DataHcloudZoneRrsetsState<Missing>)

        /// <summary>
        /// ID or Name of the parent Zone. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrsets#zone-1">DataHcloudZoneRrsets#zone</a>
        /// </summary>
        [<CustomOperation "zone">]
        member _.Zone(state: DataHcloudZoneRrsetsState<Missing>, value: string) : DataHcloudZoneRrsetsState<Present> =
            state.assignments.Add(fun config -> config.Zone <- value)
            ({ assignments = state.assignments } : DataHcloudZoneRrsetsState<Present>)

        /// <summary>
        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrsets#with_selector-1">DataHcloudZoneRrsets#with_selector</a>
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudZoneRrsetsState<'Zone>, value: string) : DataHcloudZoneRrsetsState<'Zone> =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudZoneRrsetsState<'Zone>

        member _.Run(state: DataHcloudZoneRrsetsState<Present>) : hcloud.DataHcloudZoneRrsets.DataHcloudZoneRrsets =
            let config = hcloud.DataHcloudZoneRrsets.DataHcloudZoneRrsetsConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudZoneRrsets.DataHcloudZoneRrsets(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.dataHcloudZoneRrsets: missing required arguments. Must call: zone.", 9999, IsError = true)>]
        member _.Run(_: DataHcloudZoneRrsetsState<_>) : hcloud.DataHcloudZoneRrsets.DataHcloudZoneRrsets =
            Unchecked.defaultof<hcloud.DataHcloudZoneRrsets.DataHcloudZoneRrsets>
