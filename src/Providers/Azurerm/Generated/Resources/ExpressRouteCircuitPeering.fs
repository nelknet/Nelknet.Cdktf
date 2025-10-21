namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId> = { assignments: ResizeArray<azurerm.ExpressRouteCircuitPeering.ExpressRouteCircuitPeeringConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering">azurerm_express_route_circuit_peering</a>.
    /// </summary>
    type ExpressRouteCircuitPeeringBuilder(logicalId: string) =
        member _.Yield(_: unit) : ExpressRouteCircuitPeeringState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRouteCircuitPeeringState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ExpressRouteCircuitPeeringState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRouteCircuitPeeringState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#express_route_circuit_name-1">ExpressRouteCircuitPeering#express_route_circuit_name</a>.
        /// </summary>
        [<CustomOperation "express_route_circuit_name">]
        member _.ExpressRouteCircuitName(state: ExpressRouteCircuitPeeringState<Missing, 'PeeringType, 'ResourceGroupName, 'VlanId>, value: string) : ExpressRouteCircuitPeeringState<Present, 'PeeringType, 'ResourceGroupName, 'VlanId> =
            state.assignments.Add(fun config -> config.ExpressRouteCircuitName <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitPeeringState<Present, 'PeeringType, 'ResourceGroupName, 'VlanId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#peering_type-1">ExpressRouteCircuitPeering#peering_type</a>.
        /// </summary>
        [<CustomOperation "peering_type">]
        member _.PeeringType(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, Missing, 'ResourceGroupName, 'VlanId>, value: string) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, Present, 'ResourceGroupName, 'VlanId> =
            state.assignments.Add(fun config -> config.PeeringType <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, Present, 'ResourceGroupName, 'VlanId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#resource_group_name-1">ExpressRouteCircuitPeering#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, Missing, 'VlanId>, value: string) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, Present, 'VlanId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, Present, 'VlanId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#vlan_id-1">ExpressRouteCircuitPeering#vlan_id</a>.
        /// </summary>
        [<CustomOperation "vlan_id">]
        member _.VlanId(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, Missing>, value: double) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VlanId <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#id-1">ExpressRouteCircuitPeering#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>, value: string) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#ipv4_enabled-1">ExpressRouteCircuitPeering#ipv4_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ipv4_enabled">]
        member _.Ipv4Enabled(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>, value: bool) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId> =
            state.assignments.Add(fun config -> config.Ipv4Enabled <- value)
            state : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#ipv4_enabled-1">ExpressRouteCircuitPeering#ipv4_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ipv4_enabled">]
        member _.Ipv4Enabled(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>, value: HashiCorp.Cdktf.IResolvable) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId> =
            state.assignments.Add(fun config -> config.Ipv4Enabled <- value)
            state : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>

        /// <summary>
        /// ipv6 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#ipv6-1">ExpressRouteCircuitPeering#ipv6</a>
        /// </summary>
        [<CustomOperation "ipv6">]
        member _.Ipv6(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>, value: azurerm.ExpressRouteCircuitPeering.ExpressRouteCircuitPeeringIpv6) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId> =
            state.assignments.Add(fun config -> config.Ipv6 <- value)
            state : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>

        /// <summary>
        /// microsoft_peering_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#microsoft_peering_config-1">ExpressRouteCircuitPeering#microsoft_peering_config</a>
        /// </summary>
        [<CustomOperation "microsoft_peering_config">]
        member _.MicrosoftPeeringConfig(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>, value: azurerm.ExpressRouteCircuitPeering.ExpressRouteCircuitPeeringMicrosoftPeeringConfig) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId> =
            state.assignments.Add(fun config -> config.MicrosoftPeeringConfig <- value)
            state : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#peer_asn-1">ExpressRouteCircuitPeering#peer_asn</a>.
        /// </summary>
        [<CustomOperation "peer_asn">]
        member _.PeerAsn(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>, value: double) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId> =
            state.assignments.Add(fun config -> config.PeerAsn <- value)
            state : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#primary_peer_address_prefix-1">ExpressRouteCircuitPeering#primary_peer_address_prefix</a>.
        /// </summary>
        [<CustomOperation "primary_peer_address_prefix">]
        member _.PrimaryPeerAddressPrefix(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>, value: string) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId> =
            state.assignments.Add(fun config -> config.PrimaryPeerAddressPrefix <- value)
            state : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#route_filter_id-1">ExpressRouteCircuitPeering#route_filter_id</a>.
        /// </summary>
        [<CustomOperation "route_filter_id">]
        member _.RouteFilterId(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>, value: string) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId> =
            state.assignments.Add(fun config -> config.RouteFilterId <- value)
            state : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#secondary_peer_address_prefix-1">ExpressRouteCircuitPeering#secondary_peer_address_prefix</a>.
        /// </summary>
        [<CustomOperation "secondary_peer_address_prefix">]
        member _.SecondaryPeerAddressPrefix(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>, value: string) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId> =
            state.assignments.Add(fun config -> config.SecondaryPeerAddressPrefix <- value)
            state : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#shared_key-1">ExpressRouteCircuitPeering#shared_key</a>.
        /// </summary>
        [<CustomOperation "shared_key">]
        member _.SharedKey(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>, value: string) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId> =
            state.assignments.Add(fun config -> config.SharedKey <- value)
            state : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#timeouts-1">ExpressRouteCircuitPeering#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>, value: azurerm.ExpressRouteCircuitPeering.ExpressRouteCircuitPeeringTimeouts) : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName, 'VlanId>

        member _.Run(state: ExpressRouteCircuitPeeringState<Present, Present, Present, Present>) : azurerm.ExpressRouteCircuitPeering.ExpressRouteCircuitPeering =
            let config = azurerm.ExpressRouteCircuitPeering.ExpressRouteCircuitPeeringConfig()
            for setter in state.assignments do
                setter config
            azurerm.ExpressRouteCircuitPeering.ExpressRouteCircuitPeering(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.expressRouteCircuitPeering: missing required arguments. Must call: express_route_circuit_name, peering_type, resource_group_name, vlan_id.", 9999, IsError = true)>]
        member _.Run(_: ExpressRouteCircuitPeeringState<_, _, _, _>) : azurerm.ExpressRouteCircuitPeering.ExpressRouteCircuitPeering =
            Unchecked.defaultof<azurerm.ExpressRouteCircuitPeering.ExpressRouteCircuitPeering>
