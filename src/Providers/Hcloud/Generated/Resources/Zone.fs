namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ZoneState<'Mode, 'Name> = { assignments: ResizeArray<hcloud.Zone.ZoneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone">hcloud_zone</a>.
    /// </summary>
    type ZoneBuilder(logicalId: string) =
        member _.Yield(_: unit) : ZoneState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ZoneState<Missing, Missing>)

        member _.Zero(()) : ZoneState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ZoneState<Missing, Missing>)

        /// <summary>
        /// Mode of the Zone. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#mode-1">Zone#mode</a>
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: ZoneState<Missing, 'Name>, value: string) : ZoneState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Mode <- value)
            ({ assignments = state.assignments } : ZoneState<Present, 'Name>)

        /// <summary>
        /// Name of the Zone. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#name-1">Zone#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ZoneState<'Mode, Missing>, value: string) : ZoneState<'Mode, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ZoneState<'Mode, Present>)

        /// <summary>
        /// Whether delete protection is enabled. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#delete_protection-1">Zone#delete_protection</a> Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: ZoneState<'Mode, 'Name>, value: bool) : ZoneState<'Mode, 'Name> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : ZoneState<'Mode, 'Name>

        /// <summary>
        /// Whether delete protection is enabled. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#delete_protection-1">Zone#delete_protection</a> Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: ZoneState<'Mode, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ZoneState<'Mode, 'Name> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : ZoneState<'Mode, 'Name>

        /// <summary>
        /// User-defined [labels](https://docs.hetzner.cloud/reference/cloud#labels) (key-value pairs) for the resource. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#labels-1">Zone#labels</a>
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: ZoneState<'Mode, 'Name>, value: seq<string * string>) : ZoneState<'Mode, 'Name> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : ZoneState<'Mode, 'Name>

        /// <summary>
        /// Primary nameservers of the Zone. Forbidden when mode is primary and required when mode is secondary. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#primary_nameservers-1">Zone#primary_nameservers</a> Accepts: hcloud.IResolvable | hcloud.Zone.ZonePrimaryNameservers[]
        /// </summary>
        [<CustomOperation "primary_nameservers">]
        member _.PrimaryNameservers(state: ZoneState<'Mode, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ZoneState<'Mode, 'Name> =
            state.assignments.Add(fun config -> config.PrimaryNameservers <- value)
            state : ZoneState<'Mode, 'Name>

        /// <summary>
        /// Default Time To Live (TTL) of the Zone. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#ttl-1">Zone#ttl</a>
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: ZoneState<'Mode, 'Name>, value: double) : ZoneState<'Mode, 'Name> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            state : ZoneState<'Mode, 'Name>

        member _.Run(state: ZoneState<Present, Present>) : hcloud.Zone.Zone =
            let config = hcloud.Zone.ZoneConfig()
            for setter in state.assignments do
                setter config
            hcloud.Zone.Zone(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.zone: missing required arguments. Must call: mode, name.", 9999, IsError = true)>]
        member _.Run(_: ZoneState<_, _>) : hcloud.Zone.Zone =
            Unchecked.defaultof<hcloud.Zone.Zone>
