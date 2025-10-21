namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IothubFallbackRoute.IothubFallbackRouteAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_fallback_route">azurerm_iothub_fallback_route</a>.
    /// </summary>
    type IothubFallbackRouteABuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubFallbackRouteAState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubFallbackRouteAState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IothubFallbackRouteAState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubFallbackRouteAState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_fallback_route#enabled-1">IothubFallbackRouteA#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: IothubFallbackRouteAState<Missing, 'EndpointNames, 'IothubName, 'ResourceGroupName>, value: bool) : IothubFallbackRouteAState<Present, 'EndpointNames, 'IothubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : IothubFallbackRouteAState<Present, 'EndpointNames, 'IothubName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_fallback_route#enabled-1">IothubFallbackRouteA#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: IothubFallbackRouteAState<Missing, 'EndpointNames, 'IothubName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IothubFallbackRouteAState<Present, 'EndpointNames, 'IothubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : IothubFallbackRouteAState<Present, 'EndpointNames, 'IothubName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_fallback_route#endpoint_names-1">IothubFallbackRouteA#endpoint_names</a>.
        /// </summary>
        [<CustomOperation "endpoint_names">]
        member _.EndpointNames(state: IothubFallbackRouteAState<'Enabled, Missing, 'IothubName, 'ResourceGroupName>, value: seq<string>) : IothubFallbackRouteAState<'Enabled, Present, 'IothubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EndpointNames <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IothubFallbackRouteAState<'Enabled, Present, 'IothubName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_fallback_route#iothub_name-1">IothubFallbackRouteA#iothub_name</a>.
        /// </summary>
        [<CustomOperation "iothub_name">]
        member _.IothubName(state: IothubFallbackRouteAState<'Enabled, 'EndpointNames, Missing, 'ResourceGroupName>, value: string) : IothubFallbackRouteAState<'Enabled, 'EndpointNames, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IothubName <- value)
            ({ assignments = state.assignments } : IothubFallbackRouteAState<'Enabled, 'EndpointNames, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_fallback_route#resource_group_name-1">IothubFallbackRouteA#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, Missing>, value: string) : IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_fallback_route#condition-1">IothubFallbackRouteA#condition</a>.
        /// </summary>
        [<CustomOperation "condition">]
        member _.Condition(state: IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'ResourceGroupName>, value: string) : IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Condition <- value)
            state : IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_fallback_route#id-1">IothubFallbackRouteA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'ResourceGroupName>, value: string) : IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_fallback_route#source-1">IothubFallbackRouteA#source</a>.
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'ResourceGroupName>, value: string) : IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Source <- value)
            state : IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_fallback_route#timeouts-1">IothubFallbackRouteA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'ResourceGroupName>, value: azurerm.IothubFallbackRoute.IothubFallbackRouteTimeouts) : IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubFallbackRouteAState<'Enabled, 'EndpointNames, 'IothubName, 'ResourceGroupName>

        member _.Run(state: IothubFallbackRouteAState<Present, Present, Present, Present>) : azurerm.IothubFallbackRoute.IothubFallbackRouteA =
            let config = azurerm.IothubFallbackRoute.IothubFallbackRouteAConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubFallbackRoute.IothubFallbackRouteA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubFallbackRouteA: missing required arguments. Must call: enabled, endpoint_names, iothub_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IothubFallbackRouteAState<_, _, _, _>) : azurerm.IothubFallbackRoute.IothubFallbackRouteA =
            Unchecked.defaultof<azurerm.IothubFallbackRoute.IothubFallbackRouteA>
