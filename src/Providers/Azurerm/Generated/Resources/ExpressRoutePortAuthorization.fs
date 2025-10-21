namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ExpressRoutePortAuthorizationState<'ExpressRoutePortName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ExpressRoutePortAuthorization.ExpressRoutePortAuthorizationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port_authorization">azurerm_express_route_port_authorization</a>.
    /// </summary>
    type ExpressRoutePortAuthorizationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ExpressRoutePortAuthorizationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRoutePortAuthorizationState<Missing, Missing, Missing>)

        member _.Zero(()) : ExpressRoutePortAuthorizationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRoutePortAuthorizationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port_authorization#express_route_port_name-1">ExpressRoutePortAuthorization#express_route_port_name</a>.
        /// </summary>
        [<CustomOperation "express_route_port_name">]
        member _.ExpressRoutePortName(state: ExpressRoutePortAuthorizationState<Missing, 'Name, 'ResourceGroupName>, value: string) : ExpressRoutePortAuthorizationState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ExpressRoutePortName <- value)
            ({ assignments = state.assignments } : ExpressRoutePortAuthorizationState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port_authorization#name-1">ExpressRoutePortAuthorization#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ExpressRoutePortAuthorizationState<'ExpressRoutePortName, Missing, 'ResourceGroupName>, value: string) : ExpressRoutePortAuthorizationState<'ExpressRoutePortName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ExpressRoutePortAuthorizationState<'ExpressRoutePortName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port_authorization#resource_group_name-1">ExpressRoutePortAuthorization#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ExpressRoutePortAuthorizationState<'ExpressRoutePortName, 'Name, Missing>, value: string) : ExpressRoutePortAuthorizationState<'ExpressRoutePortName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ExpressRoutePortAuthorizationState<'ExpressRoutePortName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port_authorization#id-1">ExpressRoutePortAuthorization#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ExpressRoutePortAuthorizationState<'ExpressRoutePortName, 'Name, 'ResourceGroupName>, value: string) : ExpressRoutePortAuthorizationState<'ExpressRoutePortName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ExpressRoutePortAuthorizationState<'ExpressRoutePortName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port_authorization#timeouts-1">ExpressRoutePortAuthorization#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ExpressRoutePortAuthorizationState<'ExpressRoutePortName, 'Name, 'ResourceGroupName>, value: azurerm.ExpressRoutePortAuthorization.ExpressRoutePortAuthorizationTimeouts) : ExpressRoutePortAuthorizationState<'ExpressRoutePortName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ExpressRoutePortAuthorizationState<'ExpressRoutePortName, 'Name, 'ResourceGroupName>

        member _.Run(state: ExpressRoutePortAuthorizationState<Present, Present, Present>) : azurerm.ExpressRoutePortAuthorization.ExpressRoutePortAuthorization =
            let config = azurerm.ExpressRoutePortAuthorization.ExpressRoutePortAuthorizationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ExpressRoutePortAuthorization.ExpressRoutePortAuthorization(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.expressRoutePortAuthorization: missing required arguments. Must call: express_route_port_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ExpressRoutePortAuthorizationState<_, _, _>) : azurerm.ExpressRoutePortAuthorization.ExpressRoutePortAuthorization =
            Unchecked.defaultof<azurerm.ExpressRoutePortAuthorization.ExpressRoutePortAuthorization>
