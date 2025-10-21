namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsZoneState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.PrivateDnsZone.PrivateDnsZoneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone">azurerm_private_dns_zone</a>.
    /// </summary>
    type PrivateDnsZoneBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsZoneState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsZoneState<Missing, Missing>)

        member _.Zero(()) : PrivateDnsZoneState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsZoneState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone#name-1">PrivateDnsZone#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsZoneState<Missing, 'ResourceGroupName>, value: string) : PrivateDnsZoneState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateDnsZoneState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone#resource_group_name-1">PrivateDnsZone#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PrivateDnsZoneState<'Name, Missing>, value: string) : PrivateDnsZoneState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PrivateDnsZoneState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone#id-1">PrivateDnsZone#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsZoneState<'Name, 'ResourceGroupName>, value: string) : PrivateDnsZoneState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsZoneState<'Name, 'ResourceGroupName>

        /// <summary>
        /// soa_record block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone#soa_record-1">PrivateDnsZone#soa_record</a>
        /// </summary>
        [<CustomOperation "soa_record">]
        member _.SoaRecord(state: PrivateDnsZoneState<'Name, 'ResourceGroupName>, value: azurerm.PrivateDnsZone.PrivateDnsZoneSoaRecord) : PrivateDnsZoneState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SoaRecord <- value)
            state : PrivateDnsZoneState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone#tags-1">PrivateDnsZone#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateDnsZoneState<'Name, 'ResourceGroupName>, value: seq<string * string>) : PrivateDnsZoneState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateDnsZoneState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone#timeouts-1">PrivateDnsZone#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsZoneState<'Name, 'ResourceGroupName>, value: azurerm.PrivateDnsZone.PrivateDnsZoneTimeouts) : PrivateDnsZoneState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsZoneState<'Name, 'ResourceGroupName>

        member _.Run(state: PrivateDnsZoneState<Present, Present>) : azurerm.PrivateDnsZone.PrivateDnsZone =
            let config = azurerm.PrivateDnsZone.PrivateDnsZoneConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsZone.PrivateDnsZone(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsZone: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsZoneState<_, _>) : azurerm.PrivateDnsZone.PrivateDnsZone =
            Unchecked.defaultof<azurerm.PrivateDnsZone.PrivateDnsZone>
