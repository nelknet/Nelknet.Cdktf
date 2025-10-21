namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ExpressRouteCircuitAuthorizationState<'ExpressRouteCircuitName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ExpressRouteCircuitAuthorization.ExpressRouteCircuitAuthorizationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_authorization">azurerm_express_route_circuit_authorization</a>.
    /// </summary>
    type ExpressRouteCircuitAuthorizationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ExpressRouteCircuitAuthorizationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRouteCircuitAuthorizationState<Missing, Missing, Missing>)

        member _.Zero(()) : ExpressRouteCircuitAuthorizationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRouteCircuitAuthorizationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_authorization#express_route_circuit_name-1">ExpressRouteCircuitAuthorization#express_route_circuit_name</a>.
        /// </summary>
        [<CustomOperation "express_route_circuit_name">]
        member _.ExpressRouteCircuitName(state: ExpressRouteCircuitAuthorizationState<Missing, 'Name, 'ResourceGroupName>, value: string) : ExpressRouteCircuitAuthorizationState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ExpressRouteCircuitName <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitAuthorizationState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_authorization#name-1">ExpressRouteCircuitAuthorization#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ExpressRouteCircuitAuthorizationState<'ExpressRouteCircuitName, Missing, 'ResourceGroupName>, value: string) : ExpressRouteCircuitAuthorizationState<'ExpressRouteCircuitName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitAuthorizationState<'ExpressRouteCircuitName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_authorization#resource_group_name-1">ExpressRouteCircuitAuthorization#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ExpressRouteCircuitAuthorizationState<'ExpressRouteCircuitName, 'Name, Missing>, value: string) : ExpressRouteCircuitAuthorizationState<'ExpressRouteCircuitName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ExpressRouteCircuitAuthorizationState<'ExpressRouteCircuitName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_authorization#id-1">ExpressRouteCircuitAuthorization#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ExpressRouteCircuitAuthorizationState<'ExpressRouteCircuitName, 'Name, 'ResourceGroupName>, value: string) : ExpressRouteCircuitAuthorizationState<'ExpressRouteCircuitName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ExpressRouteCircuitAuthorizationState<'ExpressRouteCircuitName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_authorization#timeouts-1">ExpressRouteCircuitAuthorization#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ExpressRouteCircuitAuthorizationState<'ExpressRouteCircuitName, 'Name, 'ResourceGroupName>, value: azurerm.ExpressRouteCircuitAuthorization.ExpressRouteCircuitAuthorizationTimeouts) : ExpressRouteCircuitAuthorizationState<'ExpressRouteCircuitName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ExpressRouteCircuitAuthorizationState<'ExpressRouteCircuitName, 'Name, 'ResourceGroupName>

        member _.Run(state: ExpressRouteCircuitAuthorizationState<Present, Present, Present>) : azurerm.ExpressRouteCircuitAuthorization.ExpressRouteCircuitAuthorization =
            let config = azurerm.ExpressRouteCircuitAuthorization.ExpressRouteCircuitAuthorizationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ExpressRouteCircuitAuthorization.ExpressRouteCircuitAuthorization(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.expressRouteCircuitAuthorization: missing required arguments. Must call: express_route_circuit_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ExpressRouteCircuitAuthorizationState<_, _, _>) : azurerm.ExpressRouteCircuitAuthorization.ExpressRouteCircuitAuthorization =
            Unchecked.defaultof<azurerm.ExpressRouteCircuitAuthorization.ExpressRouteCircuitAuthorization>
