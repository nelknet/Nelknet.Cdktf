namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsZoneVirtualNetworkLink.DataAzurermPrivateDnsZoneVirtualNetworkLinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_zone_virtual_network_link">azurerm_private_dns_zone_virtual_network_link</a>.
    /// </summary>
    type DataAzurermPrivateDnsZoneVirtualNetworkLinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_zone_virtual_network_link#name-1">DataAzurermPrivateDnsZoneVirtualNetworkLink#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsZoneVirtualNetworkLinkState<Missing, 'PrivateDnsZoneName, 'ResourceGroupName>, value: string) : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<Present, 'PrivateDnsZoneName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<Present, 'PrivateDnsZoneName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_zone_virtual_network_link#private_dns_zone_name-1">DataAzurermPrivateDnsZoneVirtualNetworkLink#private_dns_zone_name</a>.
        /// </summary>
        [<CustomOperation "private_dns_zone_name">]
        member _.PrivateDnsZoneName(state: DataAzurermPrivateDnsZoneVirtualNetworkLinkState<'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrivateDnsZoneName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_zone_virtual_network_link#resource_group_name-1">DataAzurermPrivateDnsZoneVirtualNetworkLink#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, Missing>, value: string) : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_zone_virtual_network_link#id-1">DataAzurermPrivateDnsZoneVirtualNetworkLink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName>, value: string) : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_zone_virtual_network_link#timeouts-1">DataAzurermPrivateDnsZoneVirtualNetworkLink#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName>, value: azurerm.DataAzurermPrivateDnsZoneVirtualNetworkLink.DataAzurermPrivateDnsZoneVirtualNetworkLinkTimeouts) : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName>

        member _.Run(state: DataAzurermPrivateDnsZoneVirtualNetworkLinkState<Present, Present, Present>) : azurerm.DataAzurermPrivateDnsZoneVirtualNetworkLink.DataAzurermPrivateDnsZoneVirtualNetworkLink =
            let config = azurerm.DataAzurermPrivateDnsZoneVirtualNetworkLink.DataAzurermPrivateDnsZoneVirtualNetworkLinkConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsZoneVirtualNetworkLink.DataAzurermPrivateDnsZoneVirtualNetworkLink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsZoneVirtualNetworkLink: missing required arguments. Must call: name, private_dns_zone_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsZoneVirtualNetworkLinkState<_, _, _>) : azurerm.DataAzurermPrivateDnsZoneVirtualNetworkLink.DataAzurermPrivateDnsZoneVirtualNetworkLink =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsZoneVirtualNetworkLink.DataAzurermPrivateDnsZoneVirtualNetworkLink>
