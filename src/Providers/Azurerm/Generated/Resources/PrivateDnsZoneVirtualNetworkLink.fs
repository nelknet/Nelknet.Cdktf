namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId> = { assignments: ResizeArray<azurerm.PrivateDnsZoneVirtualNetworkLink.PrivateDnsZoneVirtualNetworkLinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone_virtual_network_link">azurerm_private_dns_zone_virtual_network_link</a>.
    /// </summary>
    type PrivateDnsZoneVirtualNetworkLinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateDnsZoneVirtualNetworkLinkState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsZoneVirtualNetworkLinkState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateDnsZoneVirtualNetworkLinkState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateDnsZoneVirtualNetworkLinkState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone_virtual_network_link#name-1">PrivateDnsZoneVirtualNetworkLink#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateDnsZoneVirtualNetworkLinkState<Missing, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId>, value: string) : PrivateDnsZoneVirtualNetworkLinkState<Present, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateDnsZoneVirtualNetworkLinkState<Present, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone_virtual_network_link#private_dns_zone_name-1">PrivateDnsZoneVirtualNetworkLink#private_dns_zone_name</a>.
        /// </summary>
        [<CustomOperation "private_dns_zone_name">]
        member _.PrivateDnsZoneName(state: PrivateDnsZoneVirtualNetworkLinkState<'Name, Missing, 'ResourceGroupName, 'VirtualNetworkId>, value: string) : PrivateDnsZoneVirtualNetworkLinkState<'Name, Present, 'ResourceGroupName, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.PrivateDnsZoneName <- value)
            ({ assignments = state.assignments } : PrivateDnsZoneVirtualNetworkLinkState<'Name, Present, 'ResourceGroupName, 'VirtualNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone_virtual_network_link#resource_group_name-1">PrivateDnsZoneVirtualNetworkLink#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, Missing, 'VirtualNetworkId>, value: string) : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, Present, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, Present, 'VirtualNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone_virtual_network_link#virtual_network_id-1">PrivateDnsZoneVirtualNetworkLink#virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_id">]
        member _.VirtualNetworkId(state: PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, Missing>, value: string) : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VirtualNetworkId <- value)
            ({ assignments = state.assignments } : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone_virtual_network_link#id-1">PrivateDnsZoneVirtualNetworkLink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId>, value: string) : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone_virtual_network_link#registration_enabled-1">PrivateDnsZoneVirtualNetworkLink#registration_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "registration_enabled">]
        member _.RegistrationEnabled(state: PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId>, value: bool) : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.RegistrationEnabled <- value)
            state : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone_virtual_network_link#registration_enabled-1">PrivateDnsZoneVirtualNetworkLink#registration_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "registration_enabled">]
        member _.RegistrationEnabled(state: PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId>, value: HashiCorp.Cdktf.IResolvable) : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.RegistrationEnabled <- value)
            state : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone_virtual_network_link#tags-1">PrivateDnsZoneVirtualNetworkLink#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId>, value: seq<string * string>) : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_zone_virtual_network_link#timeouts-1">PrivateDnsZoneVirtualNetworkLink#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId>, value: azurerm.PrivateDnsZoneVirtualNetworkLink.PrivateDnsZoneVirtualNetworkLinkTimeouts) : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateDnsZoneVirtualNetworkLinkState<'Name, 'PrivateDnsZoneName, 'ResourceGroupName, 'VirtualNetworkId>

        member _.Run(state: PrivateDnsZoneVirtualNetworkLinkState<Present, Present, Present, Present>) : azurerm.PrivateDnsZoneVirtualNetworkLink.PrivateDnsZoneVirtualNetworkLink =
            let config = azurerm.PrivateDnsZoneVirtualNetworkLink.PrivateDnsZoneVirtualNetworkLinkConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateDnsZoneVirtualNetworkLink.PrivateDnsZoneVirtualNetworkLink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateDnsZoneVirtualNetworkLink: missing required arguments. Must call: name, private_dns_zone_name, resource_group_name, virtual_network_id.", 9999, IsError = true)>]
        member _.Run(_: PrivateDnsZoneVirtualNetworkLinkState<_, _, _, _>) : azurerm.PrivateDnsZoneVirtualNetworkLink.PrivateDnsZoneVirtualNetworkLink =
            Unchecked.defaultof<azurerm.PrivateDnsZoneVirtualNetworkLink.PrivateDnsZoneVirtualNetworkLink>
