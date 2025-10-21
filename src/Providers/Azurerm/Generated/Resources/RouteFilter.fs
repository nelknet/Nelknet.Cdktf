namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RouteFilterState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.RouteFilter.RouteFilterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_filter">azurerm_route_filter</a>.
    /// </summary>
    type RouteFilterBuilder(logicalId: string) =
        member _.Yield(_: unit) : RouteFilterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RouteFilterState<Missing, Missing, Missing>)

        member _.Zero(()) : RouteFilterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RouteFilterState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_filter#location-1">RouteFilter#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: RouteFilterState<Missing, 'Name, 'ResourceGroupName>, value: string) : RouteFilterState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : RouteFilterState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_filter#name-1">RouteFilter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RouteFilterState<'Location, Missing, 'ResourceGroupName>, value: string) : RouteFilterState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RouteFilterState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_filter#resource_group_name-1">RouteFilter#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RouteFilterState<'Location, 'Name, Missing>, value: string) : RouteFilterState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RouteFilterState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_filter#id-1">RouteFilter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RouteFilterState<'Location, 'Name, 'ResourceGroupName>, value: string) : RouteFilterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RouteFilterState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_filter#rule-1">RouteFilter#rule</a>. Accepts: azurerm.IResolvable | azurerm.RouteFilter.RouteFilterRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: RouteFilterState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : RouteFilterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : RouteFilterState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_filter#tags-1">RouteFilter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RouteFilterState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : RouteFilterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RouteFilterState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_filter#timeouts-1">RouteFilter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RouteFilterState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.RouteFilter.RouteFilterTimeouts) : RouteFilterState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RouteFilterState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: RouteFilterState<Present, Present, Present>) : azurerm.RouteFilter.RouteFilter =
            let config = azurerm.RouteFilter.RouteFilterConfig()
            for setter in state.assignments do
                setter config
            azurerm.RouteFilter.RouteFilter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.routeFilter: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: RouteFilterState<_, _, _>) : azurerm.RouteFilter.RouteFilter =
            Unchecked.defaultof<azurerm.RouteFilter.RouteFilter>
