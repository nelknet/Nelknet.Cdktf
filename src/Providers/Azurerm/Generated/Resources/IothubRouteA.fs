namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source> = { assignments: ResizeArray<azurerm.IothubRoute.IothubRouteAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_route">azurerm_iothub_route</a>.
    /// </summary>
    type IothubRouteABuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubRouteAState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubRouteAState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IothubRouteAState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubRouteAState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_route#enabled-1">IothubRouteA#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: IothubRouteAState<Missing, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source>, value: bool) : IothubRouteAState<Present, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : IothubRouteAState<Present, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_route#enabled-1">IothubRouteA#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: IothubRouteAState<Missing, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source>, value: HashiCorp.Cdktf.IResolvable) : IothubRouteAState<Present, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : IothubRouteAState<Present, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_route#endpoint_names-1">IothubRouteA#endpoint_names</a>.
        /// </summary>
        [<CustomOperation "endpoint_names">]
        member _.EndpointNames(state: IothubRouteAState<'Enabled, Missing, 'IothubName, 'Name, 'ResourceGroupName, 'Source>, value: seq<string>) : IothubRouteAState<'Enabled, Present, 'IothubName, 'Name, 'ResourceGroupName, 'Source> =
            state.assignments.Add(fun config -> config.EndpointNames <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IothubRouteAState<'Enabled, Present, 'IothubName, 'Name, 'ResourceGroupName, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_route#iothub_name-1">IothubRouteA#iothub_name</a>.
        /// </summary>
        [<CustomOperation "iothub_name">]
        member _.IothubName(state: IothubRouteAState<'Enabled, 'EndpointNames, Missing, 'Name, 'ResourceGroupName, 'Source>, value: string) : IothubRouteAState<'Enabled, 'EndpointNames, Present, 'Name, 'ResourceGroupName, 'Source> =
            state.assignments.Add(fun config -> config.IothubName <- value)
            ({ assignments = state.assignments } : IothubRouteAState<'Enabled, 'EndpointNames, Present, 'Name, 'ResourceGroupName, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_route#name-1">IothubRouteA#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, Missing, 'ResourceGroupName, 'Source>, value: string) : IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, Present, 'ResourceGroupName, 'Source> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, Present, 'ResourceGroupName, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_route#resource_group_name-1">IothubRouteA#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, Missing, 'Source>, value: string) : IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, Present, 'Source> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, Present, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_route#source-1">IothubRouteA#source</a>.
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, Missing>, value: string) : IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_route#condition-1">IothubRouteA#condition</a>.
        /// </summary>
        [<CustomOperation "condition">]
        member _.Condition(state: IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source>, value: string) : IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source> =
            state.assignments.Add(fun config -> config.Condition <- value)
            state : IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_route#id-1">IothubRouteA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source>, value: string) : IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_route#timeouts-1">IothubRouteA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source>, value: azurerm.IothubRoute.IothubRouteTimeouts) : IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'Name, 'ResourceGroupName, 'Source>

        member _.Run(state: IothubRouteAState<Present, Present, Present, Present, Present, Present>) : azurerm.IothubRoute.IothubRouteA =
            let config = azurerm.IothubRoute.IothubRouteAConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubRoute.IothubRouteA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubRouteA: missing required arguments. Must call: enabled, endpoint_names, iothub_name, name, resource_group_name, source.", 9999, IsError = true)>]
        member _.Run(_: IothubRouteAState<_, _, _, _, _, _>) : azurerm.IothubRoute.IothubRouteA =
            Unchecked.defaultof<azurerm.IothubRoute.IothubRouteA>
