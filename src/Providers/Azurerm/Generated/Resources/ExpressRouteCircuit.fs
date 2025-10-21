namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.ExpressRouteCircuit.ExpressRouteCircuitConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit">azurerm_express_route_circuit</a>.
    /// </summary>
    type ExpressRouteCircuitBuilder(logicalId: string) =
        member _.Yield(_: unit) : ExpressRouteCircuitState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRouteCircuitState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ExpressRouteCircuitState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRouteCircuitState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#location-1">ExpressRouteCircuit#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ExpressRouteCircuitState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ExpressRouteCircuitState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#name-1">ExpressRouteCircuit#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ExpressRouteCircuitState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : ExpressRouteCircuitState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#resource_group_name-1">ExpressRouteCircuit#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ExpressRouteCircuitState<'Location, 'Name, Missing, 'Sku>, value: string) : ExpressRouteCircuitState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// sku block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#sku-1">ExpressRouteCircuit#sku</a>
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, Missing>, value: azurerm.ExpressRouteCircuit.ExpressRouteCircuitSku) : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#allow_classic_operations-1">ExpressRouteCircuit#allow_classic_operations</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_classic_operations">]
        member _.AllowClassicOperations(state: ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AllowClassicOperations <- value)
            state : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#allow_classic_operations-1">ExpressRouteCircuit#allow_classic_operations</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_classic_operations">]
        member _.AllowClassicOperations(state: ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AllowClassicOperations <- value)
            state : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#authorization_key-1">ExpressRouteCircuit#authorization_key</a>.
        /// </summary>
        [<CustomOperation "authorization_key">]
        member _.AuthorizationKey(state: ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AuthorizationKey <- value)
            state : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#bandwidth_in_gbps-1">ExpressRouteCircuit#bandwidth_in_gbps</a>.
        /// </summary>
        [<CustomOperation "bandwidth_in_gbps">]
        member _.BandwidthInGbps(state: ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.BandwidthInGbps <- value)
            state : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#bandwidth_in_mbps-1">ExpressRouteCircuit#bandwidth_in_mbps</a>.
        /// </summary>
        [<CustomOperation "bandwidth_in_mbps">]
        member _.BandwidthInMbps(state: ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.BandwidthInMbps <- value)
            state : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#express_route_port_id-1">ExpressRouteCircuit#express_route_port_id</a>.
        /// </summary>
        [<CustomOperation "express_route_port_id">]
        member _.ExpressRoutePortId(state: ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ExpressRoutePortId <- value)
            state : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#id-1">ExpressRouteCircuit#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#peering_location-1">ExpressRouteCircuit#peering_location</a>.
        /// </summary>
        [<CustomOperation "peering_location">]
        member _.PeeringLocation(state: ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PeeringLocation <- value)
            state : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#service_provider_name-1">ExpressRouteCircuit#service_provider_name</a>.
        /// </summary>
        [<CustomOperation "service_provider_name">]
        member _.ServiceProviderName(state: ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ServiceProviderName <- value)
            state : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#tags-1">ExpressRouteCircuit#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#timeouts-1">ExpressRouteCircuit#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.ExpressRouteCircuit.ExpressRouteCircuitTimeouts) : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ExpressRouteCircuitState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: ExpressRouteCircuitState<Present, Present, Present, Present>) : azurerm.ExpressRouteCircuit.ExpressRouteCircuit =
            let config = azurerm.ExpressRouteCircuit.ExpressRouteCircuitConfig()
            for setter in state.assignments do
                setter config
            azurerm.ExpressRouteCircuit.ExpressRouteCircuit(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.expressRouteCircuit: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: ExpressRouteCircuitState<_, _, _, _>) : azurerm.ExpressRouteCircuit.ExpressRouteCircuit =
            Unchecked.defaultof<azurerm.ExpressRouteCircuit.ExpressRouteCircuit>
