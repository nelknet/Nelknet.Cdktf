namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit_peering">azurerm_express_route_circuit_peering</a>.
    /// </summary>
    type DataAzurermExpressRouteCircuitPeeringBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermExpressRouteCircuitPeeringState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermExpressRouteCircuitPeeringState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermExpressRouteCircuitPeeringState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermExpressRouteCircuitPeeringState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit_peering#express_route_circuit_name-1">DataAzurermExpressRouteCircuitPeering#express_route_circuit_name</a>.
        /// </summary>
        [<CustomOperation "express_route_circuit_name">]
        member _.ExpressRouteCircuitName(state: DataAzurermExpressRouteCircuitPeeringState<Missing, 'PeeringType, 'ResourceGroupName>, value: string) : DataAzurermExpressRouteCircuitPeeringState<Present, 'PeeringType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ExpressRouteCircuitName <- value)
            ({ assignments = state.assignments } : DataAzurermExpressRouteCircuitPeeringState<Present, 'PeeringType, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit_peering#peering_type-1">DataAzurermExpressRouteCircuitPeering#peering_type</a>.
        /// </summary>
        [<CustomOperation "peering_type">]
        member _.PeeringType(state: DataAzurermExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, Missing, 'ResourceGroupName>, value: string) : DataAzurermExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PeeringType <- value)
            ({ assignments = state.assignments } : DataAzurermExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit_peering#resource_group_name-1">DataAzurermExpressRouteCircuitPeering#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, Missing>, value: string) : DataAzurermExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit_peering#id-1">DataAzurermExpressRouteCircuitPeering#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName>, value: string) : DataAzurermExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit_peering#timeouts-1">DataAzurermExpressRouteCircuitPeering#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName>, value: azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringTimeouts) : DataAzurermExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermExpressRouteCircuitPeeringState<'ExpressRouteCircuitName, 'PeeringType, 'ResourceGroupName>

        member _.Run(state: DataAzurermExpressRouteCircuitPeeringState<Present, Present, Present>) : azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeering =
            let config = azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeeringConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeering(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermExpressRouteCircuitPeering: missing required arguments. Must call: express_route_circuit_name, peering_type, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermExpressRouteCircuitPeeringState<_, _, _>) : azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeering =
            Unchecked.defaultof<azurerm.DataAzurermExpressRouteCircuitPeering.DataAzurermExpressRouteCircuitPeering>
