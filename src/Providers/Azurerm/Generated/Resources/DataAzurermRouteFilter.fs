namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermRouteFilterState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermRouteFilter.DataAzurermRouteFilterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_filter">azurerm_route_filter</a>.
    /// </summary>
    type DataAzurermRouteFilterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermRouteFilterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermRouteFilterState<Missing, Missing>)

        member _.Zero(()) : DataAzurermRouteFilterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermRouteFilterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_filter#name-1">DataAzurermRouteFilter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermRouteFilterState<Missing, 'ResourceGroupName>, value: string) : DataAzurermRouteFilterState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermRouteFilterState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_filter#resource_group_name-1">DataAzurermRouteFilter#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermRouteFilterState<'Name, Missing>, value: string) : DataAzurermRouteFilterState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermRouteFilterState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_filter#id-1">DataAzurermRouteFilter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermRouteFilterState<'Name, 'ResourceGroupName>, value: string) : DataAzurermRouteFilterState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermRouteFilterState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_filter#timeouts-1">DataAzurermRouteFilter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermRouteFilterState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermRouteFilter.DataAzurermRouteFilterTimeouts) : DataAzurermRouteFilterState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermRouteFilterState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermRouteFilterState<Present, Present>) : azurerm.DataAzurermRouteFilter.DataAzurermRouteFilter =
            let config = azurerm.DataAzurermRouteFilter.DataAzurermRouteFilterConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermRouteFilter.DataAzurermRouteFilter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermRouteFilter: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermRouteFilterState<_, _>) : azurerm.DataAzurermRouteFilter.DataAzurermRouteFilter =
            Unchecked.defaultof<azurerm.DataAzurermRouteFilter.DataAzurermRouteFilter>
