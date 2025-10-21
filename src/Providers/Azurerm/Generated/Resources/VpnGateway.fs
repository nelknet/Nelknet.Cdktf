namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId> = { assignments: ResizeArray<azurerm.VpnGateway.VpnGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway">azurerm_vpn_gateway</a>.
    /// </summary>
    type VpnGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpnGatewayState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnGatewayState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VpnGatewayState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnGatewayState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#location-1">VpnGateway#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VpnGatewayState<Missing, 'Name, 'ResourceGroupName, 'VirtualHubId>, value: string) : VpnGatewayState<Present, 'Name, 'ResourceGroupName, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VpnGatewayState<Present, 'Name, 'ResourceGroupName, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#name-1">VpnGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VpnGatewayState<'Location, Missing, 'ResourceGroupName, 'VirtualHubId>, value: string) : VpnGatewayState<'Location, Present, 'ResourceGroupName, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VpnGatewayState<'Location, Present, 'ResourceGroupName, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#resource_group_name-1">VpnGateway#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VpnGatewayState<'Location, 'Name, Missing, 'VirtualHubId>, value: string) : VpnGatewayState<'Location, 'Name, Present, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VpnGatewayState<'Location, 'Name, Present, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#virtual_hub_id-1">VpnGateway#virtual_hub_id</a>.
        /// </summary>
        [<CustomOperation "virtual_hub_id">]
        member _.VirtualHubId(state: VpnGatewayState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VirtualHubId <- value)
            ({ assignments = state.assignments } : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#bgp_route_translation_for_nat_enabled-1">VpnGateway#bgp_route_translation_for_nat_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "bgp_route_translation_for_nat_enabled">]
        member _.BgpRouteTranslationForNatEnabled(state: VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>, value: bool) : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.BgpRouteTranslationForNatEnabled <- value)
            state : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#bgp_route_translation_for_nat_enabled-1">VpnGateway#bgp_route_translation_for_nat_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "bgp_route_translation_for_nat_enabled">]
        member _.BgpRouteTranslationForNatEnabled(state: VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>, value: HashiCorp.Cdktf.IResolvable) : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.BgpRouteTranslationForNatEnabled <- value)
            state : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>

        /// <summary>
        /// bgp_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#bgp_settings-1">VpnGateway#bgp_settings</a>
        /// </summary>
        [<CustomOperation "bgp_settings">]
        member _.BgpSettings(state: VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>, value: azurerm.VpnGateway.VpnGatewayBgpSettings) : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.BgpSettings <- value)
            state : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#id-1">VpnGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>, value: string) : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#routing_preference-1">VpnGateway#routing_preference</a>.
        /// </summary>
        [<CustomOperation "routing_preference">]
        member _.RoutingPreference(state: VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>, value: string) : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.RoutingPreference <- value)
            state : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#scale_unit-1">VpnGateway#scale_unit</a>.
        /// </summary>
        [<CustomOperation "scale_unit">]
        member _.ScaleUnit(state: VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>, value: double) : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.ScaleUnit <- value)
            state : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#tags-1">VpnGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>, value: seq<string * string>) : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#timeouts-1">VpnGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>, value: azurerm.VpnGateway.VpnGatewayTimeouts) : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpnGatewayState<'Location, 'Name, 'ResourceGroupName, 'VirtualHubId>

        member _.Run(state: VpnGatewayState<Present, Present, Present, Present>) : azurerm.VpnGateway.VpnGateway =
            let config = azurerm.VpnGateway.VpnGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.VpnGateway.VpnGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.vpnGateway: missing required arguments. Must call: location, name, resource_group_name, virtual_hub_id.", 9999, IsError = true)>]
        member _.Run(_: VpnGatewayState<_, _, _, _>) : azurerm.VpnGateway.VpnGateway =
            Unchecked.defaultof<azurerm.VpnGateway.VpnGateway>
