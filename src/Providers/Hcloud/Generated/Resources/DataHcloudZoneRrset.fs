namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudZoneRrsetState<'Zone> = { assignments: ResizeArray<hcloud.DataHcloudZoneRrset.DataHcloudZoneRrsetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrset">hcloud_zone_rrset</a>.
    /// </summary>
    type DataHcloudZoneRrsetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudZoneRrsetState<Missing> =
            ({ assignments = ResizeArray() } : DataHcloudZoneRrsetState<Missing>)

        member _.Zero(()) : DataHcloudZoneRrsetState<Missing> =
            ({ assignments = ResizeArray() } : DataHcloudZoneRrsetState<Missing>)

        /// <summary>
        /// ID or Name of the parent Zone. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrset#zone-1">DataHcloudZoneRrset#zone</a>
        /// </summary>
        [<CustomOperation "zone">]
        member _.Zone(state: DataHcloudZoneRrsetState<Missing>, value: string) : DataHcloudZoneRrsetState<Present> =
            state.assignments.Add(fun config -> config.Zone <- value)
            ({ assignments = state.assignments } : DataHcloudZoneRrsetState<Present>)

        /// <summary>
        /// ID of the Zone RRSet. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrset#id-1">DataHcloudZoneRrset#id</a> Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudZoneRrsetState<'Zone>, value: string) : DataHcloudZoneRrsetState<'Zone> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudZoneRrsetState<'Zone>

        /// <summary>
        /// Name of the Zone RRSet. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrset#name-1">DataHcloudZoneRrset#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudZoneRrsetState<'Zone>, value: string) : DataHcloudZoneRrsetState<'Zone> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudZoneRrsetState<'Zone>

        /// <summary>
        /// Type of the Zone RRSet. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrset#type-1">DataHcloudZoneRrset#type</a>
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataHcloudZoneRrsetState<'Zone>, value: string) : DataHcloudZoneRrsetState<'Zone> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : DataHcloudZoneRrsetState<'Zone>

        /// <summary>
        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrset#with_selector-1">DataHcloudZoneRrset#with_selector</a>
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudZoneRrsetState<'Zone>, value: string) : DataHcloudZoneRrsetState<'Zone> =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudZoneRrsetState<'Zone>

        member _.Run(state: DataHcloudZoneRrsetState<Present>) : hcloud.DataHcloudZoneRrset.DataHcloudZoneRrset =
            let config = hcloud.DataHcloudZoneRrset.DataHcloudZoneRrsetConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudZoneRrset.DataHcloudZoneRrset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.dataHcloudZoneRrset: missing required arguments. Must call: zone.", 9999, IsError = true)>]
        member _.Run(_: DataHcloudZoneRrsetState<_>) : hcloud.DataHcloudZoneRrset.DataHcloudZoneRrset =
            Unchecked.defaultof<hcloud.DataHcloudZoneRrset.DataHcloudZoneRrset>
