namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermExpressRouteCircuitState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuitConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit">azurerm_express_route_circuit</a>.
    /// </summary>
    type DataAzurermExpressRouteCircuitBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermExpressRouteCircuitState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermExpressRouteCircuitState<Missing, Missing>)

        member _.Zero(()) : DataAzurermExpressRouteCircuitState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermExpressRouteCircuitState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit#name-1">DataAzurermExpressRouteCircuit#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermExpressRouteCircuitState<Missing, 'ResourceGroupName>, value: string) : DataAzurermExpressRouteCircuitState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermExpressRouteCircuitState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit#resource_group_name-1">DataAzurermExpressRouteCircuit#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermExpressRouteCircuitState<'Name, Missing>, value: string) : DataAzurermExpressRouteCircuitState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermExpressRouteCircuitState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit#id-1">DataAzurermExpressRouteCircuit#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermExpressRouteCircuitState<'Name, 'ResourceGroupName>, value: string) : DataAzurermExpressRouteCircuitState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermExpressRouteCircuitState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit#timeouts-1">DataAzurermExpressRouteCircuit#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermExpressRouteCircuitState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuitTimeouts) : DataAzurermExpressRouteCircuitState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermExpressRouteCircuitState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermExpressRouteCircuitState<Present, Present>) : azurerm.DataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuit =
            let config = azurerm.DataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuitConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuit(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermExpressRouteCircuit: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermExpressRouteCircuitState<_, _>) : azurerm.DataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuit =
            Unchecked.defaultof<azurerm.DataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuit>
