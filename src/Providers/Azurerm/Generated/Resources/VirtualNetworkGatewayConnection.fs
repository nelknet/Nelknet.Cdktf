namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> = { assignments: ResizeArray<azurerm.VirtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection">azurerm_virtual_network_gateway_connection</a>.
    /// </summary>
    type VirtualNetworkGatewayConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualNetworkGatewayConnectionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualNetworkGatewayConnectionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualNetworkGatewayConnectionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualNetworkGatewayConnectionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#location-1">VirtualNetworkGatewayConnection#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualNetworkGatewayConnectionState<Missing, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayConnectionState<Present, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayConnectionState<Present, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#name-1">VirtualNetworkGatewayConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualNetworkGatewayConnectionState<'Location, Missing, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayConnectionState<'Location, Present, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayConnectionState<'Location, Present, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#resource_group_name-1">VirtualNetworkGatewayConnection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, Missing, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayConnectionState<'Location, 'Name, Present, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayConnectionState<'Location, 'Name, Present, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#shared_key-1">VirtualNetworkGatewayConnection#shared_key</a>.
        /// </summary>
        [<CustomOperation "shared_key">]
        member _.SharedKey(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, Missing, 'Type, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, Present, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.SharedKey <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, Present, 'Type, 'VirtualNetworkGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#type-1">VirtualNetworkGatewayConnection#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, Missing, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, Present, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, Present, 'VirtualNetworkGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#virtual_network_gateway_id-1">VirtualNetworkGatewayConnection#virtual_network_gateway_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_gateway_id">]
        member _.VirtualNetworkGatewayId(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, Missing>, value: string) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, Present> =
            state.assignments.Add(fun config -> config.VirtualNetworkGatewayId <- value)
            ({ assignments = state.assignments } : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#authorization_key-1">VirtualNetworkGatewayConnection#authorization_key</a>.
        /// </summary>
        [<CustomOperation "authorization_key">]
        member _.AuthorizationKey(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.AuthorizationKey <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#connection_mode-1">VirtualNetworkGatewayConnection#connection_mode</a>.
        /// </summary>
        [<CustomOperation "connection_mode">]
        member _.ConnectionMode(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.ConnectionMode <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#connection_protocol-1">VirtualNetworkGatewayConnection#connection_protocol</a>.
        /// </summary>
        [<CustomOperation "connection_protocol">]
        member _.ConnectionProtocol(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.ConnectionProtocol <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// custom_bgp_addresses block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#custom_bgp_addresses-1">VirtualNetworkGatewayConnection#custom_bgp_addresses</a>
        /// </summary>
        [<CustomOperation "custom_bgp_addresses">]
        member _.CustomBgpAddresses(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: azurerm.VirtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionCustomBgpAddresses) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.CustomBgpAddresses <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#dpd_timeout_seconds-1">VirtualNetworkGatewayConnection#dpd_timeout_seconds</a>.
        /// </summary>
        [<CustomOperation "dpd_timeout_seconds">]
        member _.DpdTimeoutSeconds(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: double) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.DpdTimeoutSeconds <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#egress_nat_rule_ids-1">VirtualNetworkGatewayConnection#egress_nat_rule_ids</a>.
        /// </summary>
        [<CustomOperation "egress_nat_rule_ids">]
        member _.EgressNatRuleIds(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: seq<string>) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.EgressNatRuleIds <- (value |> Seq.toArray))
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#enable_bgp-1">VirtualNetworkGatewayConnection#enable_bgp</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_bgp">]
        member _.EnableBgp(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: bool) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.EnableBgp <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#enable_bgp-1">VirtualNetworkGatewayConnection#enable_bgp</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_bgp">]
        member _.EnableBgp(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.EnableBgp <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#express_route_circuit_id-1">VirtualNetworkGatewayConnection#express_route_circuit_id</a>.
        /// </summary>
        [<CustomOperation "express_route_circuit_id">]
        member _.ExpressRouteCircuitId(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.ExpressRouteCircuitId <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#express_route_gateway_bypass-1">VirtualNetworkGatewayConnection#express_route_gateway_bypass</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "express_route_gateway_bypass">]
        member _.ExpressRouteGatewayBypass(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: bool) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.ExpressRouteGatewayBypass <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#express_route_gateway_bypass-1">VirtualNetworkGatewayConnection#express_route_gateway_bypass</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "express_route_gateway_bypass">]
        member _.ExpressRouteGatewayBypass(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.ExpressRouteGatewayBypass <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#id-1">VirtualNetworkGatewayConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#ingress_nat_rule_ids-1">VirtualNetworkGatewayConnection#ingress_nat_rule_ids</a>.
        /// </summary>
        [<CustomOperation "ingress_nat_rule_ids">]
        member _.IngressNatRuleIds(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: seq<string>) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.IngressNatRuleIds <- (value |> Seq.toArray))
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// ipsec_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#ipsec_policy-1">VirtualNetworkGatewayConnection#ipsec_policy</a>
        /// </summary>
        [<CustomOperation "ipsec_policy">]
        member _.IpsecPolicy(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: azurerm.VirtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionIpsecPolicy) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.IpsecPolicy <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#local_azure_ip_address_enabled-1">VirtualNetworkGatewayConnection#local_azure_ip_address_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_azure_ip_address_enabled">]
        member _.LocalAzureIpAddressEnabled(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: bool) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.LocalAzureIpAddressEnabled <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#local_azure_ip_address_enabled-1">VirtualNetworkGatewayConnection#local_azure_ip_address_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_azure_ip_address_enabled">]
        member _.LocalAzureIpAddressEnabled(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.LocalAzureIpAddressEnabled <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#local_network_gateway_id-1">VirtualNetworkGatewayConnection#local_network_gateway_id</a>.
        /// </summary>
        [<CustomOperation "local_network_gateway_id">]
        member _.LocalNetworkGatewayId(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.LocalNetworkGatewayId <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#peer_virtual_network_gateway_id-1">VirtualNetworkGatewayConnection#peer_virtual_network_gateway_id</a>.
        /// </summary>
        [<CustomOperation "peer_virtual_network_gateway_id">]
        member _.PeerVirtualNetworkGatewayId(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: string) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.PeerVirtualNetworkGatewayId <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#private_link_fast_path_enabled-1">VirtualNetworkGatewayConnection#private_link_fast_path_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_link_fast_path_enabled">]
        member _.PrivateLinkFastPathEnabled(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: bool) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.PrivateLinkFastPathEnabled <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#private_link_fast_path_enabled-1">VirtualNetworkGatewayConnection#private_link_fast_path_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_link_fast_path_enabled">]
        member _.PrivateLinkFastPathEnabled(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.PrivateLinkFastPathEnabled <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#routing_weight-1">VirtualNetworkGatewayConnection#routing_weight</a>.
        /// </summary>
        [<CustomOperation "routing_weight">]
        member _.RoutingWeight(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: double) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.RoutingWeight <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#tags-1">VirtualNetworkGatewayConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: seq<string * string>) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#timeouts-1">VirtualNetworkGatewayConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: azurerm.VirtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionTimeouts) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// traffic_selector_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#traffic_selector_policy-1">VirtualNetworkGatewayConnection#traffic_selector_policy</a> Accepts: azurerm.IResolvable | azurerm.VirtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionTrafficSelectorPolicy[]
        /// </summary>
        [<CustomOperation "traffic_selector_policy">]
        member _.TrafficSelectorPolicy(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.TrafficSelectorPolicy <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#use_policy_based_traffic_selectors-1">VirtualNetworkGatewayConnection#use_policy_based_traffic_selectors</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_policy_based_traffic_selectors">]
        member _.UsePolicyBasedTrafficSelectors(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: bool) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.UsePolicyBasedTrafficSelectors <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#use_policy_based_traffic_selectors-1">VirtualNetworkGatewayConnection#use_policy_based_traffic_selectors</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_policy_based_traffic_selectors">]
        member _.UsePolicyBasedTrafficSelectors(state: VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId> =
            state.assignments.Add(fun config -> config.UsePolicyBasedTrafficSelectors <- value)
            state : VirtualNetworkGatewayConnectionState<'Location, 'Name, 'ResourceGroupName, 'SharedKey, 'Type, 'VirtualNetworkGatewayId>

        member _.Run(state: VirtualNetworkGatewayConnectionState<Present, Present, Present, Present, Present, Present>) : azurerm.VirtualNetworkGatewayConnection.VirtualNetworkGatewayConnection =
            let config = azurerm.VirtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualNetworkGatewayConnection.VirtualNetworkGatewayConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualNetworkGatewayConnection: missing required arguments. Must call: location, name, resource_group_name, shared_key, type, virtual_network_gateway_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualNetworkGatewayConnectionState<_, _, _, _, _, _>) : azurerm.VirtualNetworkGatewayConnection.VirtualNetworkGatewayConnection =
            Unchecked.defaultof<azurerm.VirtualNetworkGatewayConnection.VirtualNetworkGatewayConnection>
