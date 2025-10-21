namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RouteTableState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.RouteTable.RouteTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table">azurerm_route_table</a>.
    /// </summary>
    type RouteTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : RouteTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RouteTableState<Missing, Missing, Missing>)

        member _.Zero(()) : RouteTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RouteTableState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table#location-1">RouteTable#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: RouteTableState<Missing, 'Name, 'ResourceGroupName>, value: string) : RouteTableState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : RouteTableState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table#name-1">RouteTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RouteTableState<'Location, Missing, 'ResourceGroupName>, value: string) : RouteTableState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RouteTableState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table#resource_group_name-1">RouteTable#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RouteTableState<'Location, 'Name, Missing>, value: string) : RouteTableState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RouteTableState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table#bgp_route_propagation_enabled-1">RouteTable#bgp_route_propagation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "bgp_route_propagation_enabled">]
        member _.BgpRoutePropagationEnabled(state: RouteTableState<'Location, 'Name, 'ResourceGroupName>, value: bool) : RouteTableState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BgpRoutePropagationEnabled <- value)
            state : RouteTableState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table#bgp_route_propagation_enabled-1">RouteTable#bgp_route_propagation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "bgp_route_propagation_enabled">]
        member _.BgpRoutePropagationEnabled(state: RouteTableState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : RouteTableState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BgpRoutePropagationEnabled <- value)
            state : RouteTableState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table#id-1">RouteTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RouteTableState<'Location, 'Name, 'ResourceGroupName>, value: string) : RouteTableState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RouteTableState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table#route-1">RouteTable#route</a>. Accepts: azurerm.IResolvable | azurerm.RouteTable.RouteTableRoute[]
        /// </summary>
        [<CustomOperation "route">]
        member _.Route(state: RouteTableState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : RouteTableState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Route <- value)
            state : RouteTableState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table#tags-1">RouteTable#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RouteTableState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : RouteTableState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RouteTableState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table#timeouts-1">RouteTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RouteTableState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.RouteTable.RouteTableTimeouts) : RouteTableState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RouteTableState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: RouteTableState<Present, Present, Present>) : azurerm.RouteTable.RouteTable =
            let config = azurerm.RouteTable.RouteTableConfig()
            for setter in state.assignments do
                setter config
            azurerm.RouteTable.RouteTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.routeTable: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: RouteTableState<_, _, _>) : azurerm.RouteTable.RouteTable =
            Unchecked.defaultof<azurerm.RouteTable.RouteTable>
