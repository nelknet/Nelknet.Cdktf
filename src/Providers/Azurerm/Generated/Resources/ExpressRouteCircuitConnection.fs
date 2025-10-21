namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, 'PeerPeeringId> = { assignments: ResizeArray<azurerm.ExpressRouteCircuitConnection.ExpressRouteCircuitConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_connection">azurerm_express_route_circuit_connection</a>.
    /// </summary>
    type ExpressRouteCircuitConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ExpressRouteCircuitConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRouteCircuitConnectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ExpressRouteCircuitConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRouteCircuitConnectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_connection#address_prefix_ipv4-1">ExpressRouteCircuitConnection#address_prefix_ipv4</a>.
        /// </summary>
        [<CustomOperation "address_prefix_ipv4">]
        member _.AddressPrefixIpv4(state: ExpressRouteCircuitConnectionState<Missing, 'Name, 'PeeringId, 'PeerPeeringId>, value: string) : ExpressRouteCircuitConnectionState<Present, 'Name, 'PeeringId, 'PeerPeeringId> =
            state.assignments.Add(fun config -> config.AddressPrefixIpv4 <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitConnectionState<Present, 'Name, 'PeeringId, 'PeerPeeringId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_connection#name-1">ExpressRouteCircuitConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, Missing, 'PeeringId, 'PeerPeeringId>, value: string) : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, Present, 'PeeringId, 'PeerPeeringId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, Present, 'PeeringId, 'PeerPeeringId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_connection#peering_id-1">ExpressRouteCircuitConnection#peering_id</a>.
        /// </summary>
        [<CustomOperation "peering_id">]
        member _.PeeringId(state: ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, Missing, 'PeerPeeringId>, value: string) : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, Present, 'PeerPeeringId> =
            state.assignments.Add(fun config -> config.PeeringId <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, Present, 'PeerPeeringId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_connection#peer_peering_id-1">ExpressRouteCircuitConnection#peer_peering_id</a>.
        /// </summary>
        [<CustomOperation "peer_peering_id">]
        member _.PeerPeeringId(state: ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, Missing>, value: string) : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, Present> =
            state.assignments.Add(fun config -> config.PeerPeeringId <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_connection#address_prefix_ipv6-1">ExpressRouteCircuitConnection#address_prefix_ipv6</a>.
        /// </summary>
        [<CustomOperation "address_prefix_ipv6">]
        member _.AddressPrefixIpv6(state: ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, 'PeerPeeringId>, value: string) : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, 'PeerPeeringId> =
            state.assignments.Add(fun config -> config.AddressPrefixIpv6 <- value)
            state : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, 'PeerPeeringId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_connection#authorization_key-1">ExpressRouteCircuitConnection#authorization_key</a>.
        /// </summary>
        [<CustomOperation "authorization_key">]
        member _.AuthorizationKey(state: ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, 'PeerPeeringId>, value: string) : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, 'PeerPeeringId> =
            state.assignments.Add(fun config -> config.AuthorizationKey <- value)
            state : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, 'PeerPeeringId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_connection#id-1">ExpressRouteCircuitConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, 'PeerPeeringId>, value: string) : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, 'PeerPeeringId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, 'PeerPeeringId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_connection#timeouts-1">ExpressRouteCircuitConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, 'PeerPeeringId>, value: azurerm.ExpressRouteCircuitConnection.ExpressRouteCircuitConnectionTimeouts) : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, 'PeerPeeringId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ExpressRouteCircuitConnectionState<'AddressPrefixIpv4, 'Name, 'PeeringId, 'PeerPeeringId>

        member _.Run(state: ExpressRouteCircuitConnectionState<Present, Present, Present, Present>) : azurerm.ExpressRouteCircuitConnection.ExpressRouteCircuitConnection =
            let config = azurerm.ExpressRouteCircuitConnection.ExpressRouteCircuitConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.ExpressRouteCircuitConnection.ExpressRouteCircuitConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.expressRouteCircuitConnection: missing required arguments. Must call: address_prefix_ipv4, name, peering_id, peer_peering_id.", 9999, IsError = true)>]
        member _.Run(_: ExpressRouteCircuitConnectionState<_, _, _, _>) : azurerm.ExpressRouteCircuitConnection.ExpressRouteCircuitConnection =
            Unchecked.defaultof<azurerm.ExpressRouteCircuitConnection.ExpressRouteCircuitConnection>
