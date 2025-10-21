namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name> = { assignments: ResizeArray<azurerm.ExpressRouteConnection.ExpressRouteConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection">azurerm_express_route_connection</a>.
    /// </summary>
    type ExpressRouteConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ExpressRouteConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRouteConnectionState<Missing, Missing, Missing>)

        member _.Zero(()) : ExpressRouteConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRouteConnectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#express_route_circuit_peering_id-1">ExpressRouteConnection#express_route_circuit_peering_id</a>.
        /// </summary>
        [<CustomOperation "express_route_circuit_peering_id">]
        member _.ExpressRouteCircuitPeeringId(state: ExpressRouteConnectionState<Missing, 'ExpressRouteGatewayId, 'Name>, value: string) : ExpressRouteConnectionState<Present, 'ExpressRouteGatewayId, 'Name> =
            state.assignments.Add(fun config -> config.ExpressRouteCircuitPeeringId <- value)
            ({ assignments = state.assignments } : ExpressRouteConnectionState<Present, 'ExpressRouteGatewayId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#express_route_gateway_id-1">ExpressRouteConnection#express_route_gateway_id</a>.
        /// </summary>
        [<CustomOperation "express_route_gateway_id">]
        member _.ExpressRouteGatewayId(state: ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, Missing, 'Name>, value: string) : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, Present, 'Name> =
            state.assignments.Add(fun config -> config.ExpressRouteGatewayId <- value)
            ({ assignments = state.assignments } : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#name-1">ExpressRouteConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, Missing>, value: string) : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#authorization_key-1">ExpressRouteConnection#authorization_key</a>.
        /// </summary>
        [<CustomOperation "authorization_key">]
        member _.AuthorizationKey(state: ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>, value: string) : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name> =
            state.assignments.Add(fun config -> config.AuthorizationKey <- value)
            state : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#enable_internet_security-1">ExpressRouteConnection#enable_internet_security</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_internet_security">]
        member _.EnableInternetSecurity(state: ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>, value: bool) : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name> =
            state.assignments.Add(fun config -> config.EnableInternetSecurity <- value)
            state : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#enable_internet_security-1">ExpressRouteConnection#enable_internet_security</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_internet_security">]
        member _.EnableInternetSecurity(state: ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name> =
            state.assignments.Add(fun config -> config.EnableInternetSecurity <- value)
            state : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#express_route_gateway_bypass_enabled-1">ExpressRouteConnection#express_route_gateway_bypass_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "express_route_gateway_bypass_enabled">]
        member _.ExpressRouteGatewayBypassEnabled(state: ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>, value: bool) : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name> =
            state.assignments.Add(fun config -> config.ExpressRouteGatewayBypassEnabled <- value)
            state : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#express_route_gateway_bypass_enabled-1">ExpressRouteConnection#express_route_gateway_bypass_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "express_route_gateway_bypass_enabled">]
        member _.ExpressRouteGatewayBypassEnabled(state: ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name> =
            state.assignments.Add(fun config -> config.ExpressRouteGatewayBypassEnabled <- value)
            state : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#id-1">ExpressRouteConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>, value: string) : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#private_link_fast_path_enabled-1">ExpressRouteConnection#private_link_fast_path_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_link_fast_path_enabled">]
        member _.PrivateLinkFastPathEnabled(state: ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>, value: bool) : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name> =
            state.assignments.Add(fun config -> config.PrivateLinkFastPathEnabled <- value)
            state : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#private_link_fast_path_enabled-1">ExpressRouteConnection#private_link_fast_path_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_link_fast_path_enabled">]
        member _.PrivateLinkFastPathEnabled(state: ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name> =
            state.assignments.Add(fun config -> config.PrivateLinkFastPathEnabled <- value)
            state : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>

        /// <summary>
        /// routing block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#routing-1">ExpressRouteConnection#routing</a>
        /// </summary>
        [<CustomOperation "routing">]
        member _.Routing(state: ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>, value: azurerm.ExpressRouteConnection.ExpressRouteConnectionRouting) : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name> =
            state.assignments.Add(fun config -> config.Routing <- value)
            state : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#routing_weight-1">ExpressRouteConnection#routing_weight</a>.
        /// </summary>
        [<CustomOperation "routing_weight">]
        member _.RoutingWeight(state: ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>, value: double) : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name> =
            state.assignments.Add(fun config -> config.RoutingWeight <- value)
            state : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#timeouts-1">ExpressRouteConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>, value: azurerm.ExpressRouteConnection.ExpressRouteConnectionTimeouts) : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ExpressRouteConnectionState<'ExpressRouteCircuitPeeringId, 'ExpressRouteGatewayId, 'Name>

        member _.Run(state: ExpressRouteConnectionState<Present, Present, Present>) : azurerm.ExpressRouteConnection.ExpressRouteConnection =
            let config = azurerm.ExpressRouteConnection.ExpressRouteConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.ExpressRouteConnection.ExpressRouteConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.expressRouteConnection: missing required arguments. Must call: express_route_circuit_peering_id, express_route_gateway_id, name.", 9999, IsError = true)>]
        member _.Run(_: ExpressRouteConnectionState<_, _, _>) : azurerm.ExpressRouteConnection.ExpressRouteConnection =
            Unchecked.defaultof<azurerm.ExpressRouteConnection.ExpressRouteConnection>
