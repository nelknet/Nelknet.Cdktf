namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> = { assignments: ResizeArray<azurerm.VirtualNetworkGateway.VirtualNetworkGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway">azurerm_virtual_network_gateway</a>.
    /// </summary>
    type VirtualNetworkGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualNetworkGatewayState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualNetworkGatewayState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualNetworkGatewayState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualNetworkGatewayState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// ip_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#ip_configuration-1">VirtualNetworkGateway#ip_configuration</a> Accepts: azurerm.IResolvable | azurerm.VirtualNetworkGateway.VirtualNetworkGatewayIpConfiguration[]
        /// </summary>
        [<CustomOperation "ip_configuration">]
        member _.IpConfiguration(state: VirtualNetworkGatewayState<Missing, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayState<Present, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.IpConfiguration <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayState<Present, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#location-1">VirtualNetworkGateway#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualNetworkGatewayState<'IpConfiguration, Missing, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: string) : VirtualNetworkGatewayState<'IpConfiguration, Present, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayState<'IpConfiguration, Present, 'Name, 'ResourceGroupName, 'Sku, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#name-1">VirtualNetworkGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, Missing, 'ResourceGroupName, 'Sku, 'Type>, value: string) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, Present, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayState<'IpConfiguration, 'Location, Present, 'ResourceGroupName, 'Sku, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#resource_group_name-1">VirtualNetworkGateway#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, Missing, 'Sku, 'Type>, value: string) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, Present, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, Present, 'Sku, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#sku-1">VirtualNetworkGateway#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, Missing, 'Type>, value: string) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, Present, 'Type> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#type-1">VirtualNetworkGateway#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, Missing>, value: string) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#active_active-1">VirtualNetworkGateway#active_active</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "active_active">]
        member _.ActiveActive(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: bool) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.ActiveActive <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#active_active-1">VirtualNetworkGateway#active_active</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "active_active">]
        member _.ActiveActive(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.ActiveActive <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#bgp_route_translation_for_nat_enabled-1">VirtualNetworkGateway#bgp_route_translation_for_nat_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "bgp_route_translation_for_nat_enabled">]
        member _.BgpRouteTranslationForNatEnabled(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: bool) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.BgpRouteTranslationForNatEnabled <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#bgp_route_translation_for_nat_enabled-1">VirtualNetworkGateway#bgp_route_translation_for_nat_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "bgp_route_translation_for_nat_enabled">]
        member _.BgpRouteTranslationForNatEnabled(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.BgpRouteTranslationForNatEnabled <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// bgp_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#bgp_settings-1">VirtualNetworkGateway#bgp_settings</a>
        /// </summary>
        [<CustomOperation "bgp_settings">]
        member _.BgpSettings(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: azurerm.VirtualNetworkGateway.VirtualNetworkGatewayBgpSettings) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.BgpSettings <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// custom_route block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#custom_route-1">VirtualNetworkGateway#custom_route</a>
        /// </summary>
        [<CustomOperation "custom_route">]
        member _.CustomRoute(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: azurerm.VirtualNetworkGateway.VirtualNetworkGatewayCustomRoute) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.CustomRoute <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#default_local_network_gateway_id-1">VirtualNetworkGateway#default_local_network_gateway_id</a>.
        /// </summary>
        [<CustomOperation "default_local_network_gateway_id">]
        member _.DefaultLocalNetworkGatewayId(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: string) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.DefaultLocalNetworkGatewayId <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#dns_forwarding_enabled-1">VirtualNetworkGateway#dns_forwarding_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dns_forwarding_enabled">]
        member _.DnsForwardingEnabled(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: bool) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.DnsForwardingEnabled <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#dns_forwarding_enabled-1">VirtualNetworkGateway#dns_forwarding_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dns_forwarding_enabled">]
        member _.DnsForwardingEnabled(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.DnsForwardingEnabled <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#edge_zone-1">VirtualNetworkGateway#edge_zone</a>.
        /// </summary>
        [<CustomOperation "edge_zone">]
        member _.EdgeZone(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: string) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.EdgeZone <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#enable_bgp-1">VirtualNetworkGateway#enable_bgp</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_bgp">]
        member _.EnableBgp(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: bool) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.EnableBgp <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#enable_bgp-1">VirtualNetworkGateway#enable_bgp</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_bgp">]
        member _.EnableBgp(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.EnableBgp <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#generation-1">VirtualNetworkGateway#generation</a>.
        /// </summary>
        [<CustomOperation "generation">]
        member _.Generation(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: string) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.Generation <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#id-1">VirtualNetworkGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: string) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#ip_sec_replay_protection_enabled-1">VirtualNetworkGateway#ip_sec_replay_protection_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ip_sec_replay_protection_enabled">]
        member _.IpSecReplayProtectionEnabled(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: bool) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.IpSecReplayProtectionEnabled <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#ip_sec_replay_protection_enabled-1">VirtualNetworkGateway#ip_sec_replay_protection_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ip_sec_replay_protection_enabled">]
        member _.IpSecReplayProtectionEnabled(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.IpSecReplayProtectionEnabled <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// policy_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#policy_group-1">VirtualNetworkGateway#policy_group</a> Accepts: azurerm.IResolvable | azurerm.VirtualNetworkGateway.VirtualNetworkGatewayPolicyGroup[]
        /// </summary>
        [<CustomOperation "policy_group">]
        member _.PolicyGroup(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.PolicyGroup <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#private_ip_address_enabled-1">VirtualNetworkGateway#private_ip_address_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_ip_address_enabled">]
        member _.PrivateIpAddressEnabled(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: bool) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.PrivateIpAddressEnabled <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#private_ip_address_enabled-1">VirtualNetworkGateway#private_ip_address_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_ip_address_enabled">]
        member _.PrivateIpAddressEnabled(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.PrivateIpAddressEnabled <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#remote_vnet_traffic_enabled-1">VirtualNetworkGateway#remote_vnet_traffic_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "remote_vnet_traffic_enabled">]
        member _.RemoteVnetTrafficEnabled(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: bool) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.RemoteVnetTrafficEnabled <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#remote_vnet_traffic_enabled-1">VirtualNetworkGateway#remote_vnet_traffic_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "remote_vnet_traffic_enabled">]
        member _.RemoteVnetTrafficEnabled(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.RemoteVnetTrafficEnabled <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#tags-1">VirtualNetworkGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: seq<string * string>) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#timeouts-1">VirtualNetworkGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: azurerm.VirtualNetworkGateway.VirtualNetworkGatewayTimeouts) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#virtual_wan_traffic_enabled-1">VirtualNetworkGateway#virtual_wan_traffic_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "virtual_wan_traffic_enabled">]
        member _.VirtualWanTrafficEnabled(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: bool) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.VirtualWanTrafficEnabled <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#virtual_wan_traffic_enabled-1">VirtualNetworkGateway#virtual_wan_traffic_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "virtual_wan_traffic_enabled">]
        member _.VirtualWanTrafficEnabled(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.VirtualWanTrafficEnabled <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// vpn_client_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#vpn_client_configuration-1">VirtualNetworkGateway#vpn_client_configuration</a>
        /// </summary>
        [<CustomOperation "vpn_client_configuration">]
        member _.VpnClientConfiguration(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: azurerm.VirtualNetworkGateway.VirtualNetworkGatewayVpnClientConfiguration) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.VpnClientConfiguration <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#vpn_type-1">VirtualNetworkGateway#vpn_type</a>.
        /// </summary>
        [<CustomOperation "vpn_type">]
        member _.VpnType(state: VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>, value: string) : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type> =
            state.assignments.Add(fun config -> config.VpnType <- value)
            state : VirtualNetworkGatewayState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName, 'Sku, 'Type>

        member _.Run(state: VirtualNetworkGatewayState<Present, Present, Present, Present, Present, Present>) : azurerm.VirtualNetworkGateway.VirtualNetworkGateway =
            let config = azurerm.VirtualNetworkGateway.VirtualNetworkGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualNetworkGateway.VirtualNetworkGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualNetworkGateway: missing required arguments. Must call: ip_configuration, location, name, resource_group_name, sku, type.", 9999, IsError = true)>]
        member _.Run(_: VirtualNetworkGatewayState<_, _, _, _, _, _>) : azurerm.VirtualNetworkGateway.VirtualNetworkGateway =
            Unchecked.defaultof<azurerm.VirtualNetworkGateway.VirtualNetworkGateway>
