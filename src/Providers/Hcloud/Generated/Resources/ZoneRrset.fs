namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ZoneRrsetState<'Name, 'Records, 'Type, 'Zone> = { assignments: ResizeArray<hcloud.ZoneRrset.ZoneRrsetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset">hcloud_zone_rrset</a>.
    /// </summary>
    type ZoneRrsetBuilder(logicalId: string) =
        member _.Yield(_: unit) : ZoneRrsetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ZoneRrsetState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ZoneRrsetState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ZoneRrsetState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Name of the Zone RRSet. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#name-1">ZoneRrset#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ZoneRrsetState<Missing, 'Records, 'Type, 'Zone>, value: string) : ZoneRrsetState<Present, 'Records, 'Type, 'Zone> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ZoneRrsetState<Present, 'Records, 'Type, 'Zone>)

        /// <summary>
        /// Records of the Zone RRSet. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#records-1">ZoneRrset#records</a> Accepts: hcloud.IResolvable | hcloud.ZoneRrset.ZoneRrsetRecords[]
        /// </summary>
        [<CustomOperation "records">]
        member _.Records(state: ZoneRrsetState<'Name, Missing, 'Type, 'Zone>, value: HashiCorp.Cdktf.IResolvable) : ZoneRrsetState<'Name, Present, 'Type, 'Zone> =
            state.assignments.Add(fun config -> config.Records <- value)
            ({ assignments = state.assignments } : ZoneRrsetState<'Name, Present, 'Type, 'Zone>)

        /// <summary>
        /// Type of the Zone RRSet. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#type-1">ZoneRrset#type</a>
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ZoneRrsetState<'Name, 'Records, Missing, 'Zone>, value: string) : ZoneRrsetState<'Name, 'Records, Present, 'Zone> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : ZoneRrsetState<'Name, 'Records, Present, 'Zone>)

        /// <summary>
        /// ID or Name of the parent Zone. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#zone-1">ZoneRrset#zone</a>
        /// </summary>
        [<CustomOperation "zone">]
        member _.Zone(state: ZoneRrsetState<'Name, 'Records, 'Type, Missing>, value: string) : ZoneRrsetState<'Name, 'Records, 'Type, Present> =
            state.assignments.Add(fun config -> config.Zone <- value)
            ({ assignments = state.assignments } : ZoneRrsetState<'Name, 'Records, 'Type, Present>)

        /// <summary>
        /// Whether change protection is enabled. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#change_protection-1">ZoneRrset#change_protection</a> Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "change_protection">]
        member _.ChangeProtection(state: ZoneRrsetState<'Name, 'Records, 'Type, 'Zone>, value: bool) : ZoneRrsetState<'Name, 'Records, 'Type, 'Zone> =
            state.assignments.Add(fun config -> config.ChangeProtection <- value)
            state : ZoneRrsetState<'Name, 'Records, 'Type, 'Zone>

        /// <summary>
        /// Whether change protection is enabled. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#change_protection-1">ZoneRrset#change_protection</a> Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "change_protection">]
        member _.ChangeProtection(state: ZoneRrsetState<'Name, 'Records, 'Type, 'Zone>, value: HashiCorp.Cdktf.IResolvable) : ZoneRrsetState<'Name, 'Records, 'Type, 'Zone> =
            state.assignments.Add(fun config -> config.ChangeProtection <- value)
            state : ZoneRrsetState<'Name, 'Records, 'Type, 'Zone>

        /// <summary>
        /// User-defined [labels](https://docs.hetzner.cloud/reference/cloud#labels) (key-value pairs) for the resource. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#labels-1">ZoneRrset#labels</a>
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: ZoneRrsetState<'Name, 'Records, 'Type, 'Zone>, value: seq<string * string>) : ZoneRrsetState<'Name, 'Records, 'Type, 'Zone> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : ZoneRrsetState<'Name, 'Records, 'Type, 'Zone>

        /// <summary>
        /// Time To Live (TTL) of the Zone RRSet. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#ttl-1">ZoneRrset#ttl</a>
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: ZoneRrsetState<'Name, 'Records, 'Type, 'Zone>, value: double) : ZoneRrsetState<'Name, 'Records, 'Type, 'Zone> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            state : ZoneRrsetState<'Name, 'Records, 'Type, 'Zone>

        member _.Run(state: ZoneRrsetState<Present, Present, Present, Present>) : hcloud.ZoneRrset.ZoneRrset =
            let config = hcloud.ZoneRrset.ZoneRrsetConfig()
            for setter in state.assignments do
                setter config
            hcloud.ZoneRrset.ZoneRrset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.zoneRrset: missing required arguments. Must call: name, records, type, zone.", 9999, IsError = true)>]
        member _.Run(_: ZoneRrsetState<_, _, _, _>) : hcloud.ZoneRrset.ZoneRrset =
            Unchecked.defaultof<hcloud.ZoneRrset.ZoneRrset>
