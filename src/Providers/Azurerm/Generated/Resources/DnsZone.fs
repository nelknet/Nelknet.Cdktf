namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DnsZoneState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DnsZone.DnsZoneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone">azurerm_dns_zone</a>.
    /// </summary>
    type DnsZoneBuilder(logicalId: string) =
        member _.Yield(_: unit) : DnsZoneState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsZoneState<Missing, Missing>)

        member _.Zero(()) : DnsZoneState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DnsZoneState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#name-1">DnsZone#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DnsZoneState<Missing, 'ResourceGroupName>, value: string) : DnsZoneState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DnsZoneState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#resource_group_name-1">DnsZone#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DnsZoneState<'Name, Missing>, value: string) : DnsZoneState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DnsZoneState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#id-1">DnsZone#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DnsZoneState<'Name, 'ResourceGroupName>, value: string) : DnsZoneState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DnsZoneState<'Name, 'ResourceGroupName>

        /// <summary>
        /// soa_record block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#soa_record-1">DnsZone#soa_record</a>
        /// </summary>
        [<CustomOperation "soa_record">]
        member _.SoaRecord(state: DnsZoneState<'Name, 'ResourceGroupName>, value: azurerm.DnsZone.DnsZoneSoaRecord) : DnsZoneState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SoaRecord <- value)
            state : DnsZoneState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#tags-1">DnsZone#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DnsZoneState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DnsZoneState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DnsZoneState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_zone#timeouts-1">DnsZone#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DnsZoneState<'Name, 'ResourceGroupName>, value: azurerm.DnsZone.DnsZoneTimeouts) : DnsZoneState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DnsZoneState<'Name, 'ResourceGroupName>

        member _.Run(state: DnsZoneState<Present, Present>) : azurerm.DnsZone.DnsZone =
            let config = azurerm.DnsZone.DnsZoneConfig()
            for setter in state.assignments do
                setter config
            azurerm.DnsZone.DnsZone(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dnsZone: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DnsZoneState<_, _>) : azurerm.DnsZone.DnsZone =
            Unchecked.defaultof<azurerm.DnsZone.DnsZone>
