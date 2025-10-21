namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, 'NextHop, 'RouteTableId> = { assignments: ResizeArray<azurerm.VirtualHubRouteTableRoute.VirtualHubRouteTableRouteAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table_route">azurerm_virtual_hub_route_table_route</a>.
    /// </summary>
    type VirtualHubRouteTableRouteABuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualHubRouteTableRouteAState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubRouteTableRouteAState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualHubRouteTableRouteAState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubRouteTableRouteAState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table_route#destinations-1">VirtualHubRouteTableRouteA#destinations</a>.
        /// </summary>
        [<CustomOperation "destinations">]
        member _.Destinations(state: VirtualHubRouteTableRouteAState<Missing, 'DestinationsType, 'Name, 'NextHop, 'RouteTableId>, value: seq<string>) : VirtualHubRouteTableRouteAState<Present, 'DestinationsType, 'Name, 'NextHop, 'RouteTableId> =
            state.assignments.Add(fun config -> config.Destinations <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : VirtualHubRouteTableRouteAState<Present, 'DestinationsType, 'Name, 'NextHop, 'RouteTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table_route#destinations_type-1">VirtualHubRouteTableRouteA#destinations_type</a>.
        /// </summary>
        [<CustomOperation "destinations_type">]
        member _.DestinationsType(state: VirtualHubRouteTableRouteAState<'Destinations, Missing, 'Name, 'NextHop, 'RouteTableId>, value: string) : VirtualHubRouteTableRouteAState<'Destinations, Present, 'Name, 'NextHop, 'RouteTableId> =
            state.assignments.Add(fun config -> config.DestinationsType <- value)
            ({ assignments = state.assignments } : VirtualHubRouteTableRouteAState<'Destinations, Present, 'Name, 'NextHop, 'RouteTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table_route#name-1">VirtualHubRouteTableRouteA#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, Missing, 'NextHop, 'RouteTableId>, value: string) : VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, Present, 'NextHop, 'RouteTableId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, Present, 'NextHop, 'RouteTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table_route#next_hop-1">VirtualHubRouteTableRouteA#next_hop</a>.
        /// </summary>
        [<CustomOperation "next_hop">]
        member _.NextHop(state: VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, Missing, 'RouteTableId>, value: string) : VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, Present, 'RouteTableId> =
            state.assignments.Add(fun config -> config.NextHop <- value)
            ({ assignments = state.assignments } : VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, Present, 'RouteTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table_route#route_table_id-1">VirtualHubRouteTableRouteA#route_table_id</a>.
        /// </summary>
        [<CustomOperation "route_table_id">]
        member _.RouteTableId(state: VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, 'NextHop, Missing>, value: string) : VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, 'NextHop, Present> =
            state.assignments.Add(fun config -> config.RouteTableId <- value)
            ({ assignments = state.assignments } : VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, 'NextHop, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table_route#id-1">VirtualHubRouteTableRouteA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, 'NextHop, 'RouteTableId>, value: string) : VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, 'NextHop, 'RouteTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, 'NextHop, 'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table_route#next_hop_type-1">VirtualHubRouteTableRouteA#next_hop_type</a>.
        /// </summary>
        [<CustomOperation "next_hop_type">]
        member _.NextHopType(state: VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, 'NextHop, 'RouteTableId>, value: string) : VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, 'NextHop, 'RouteTableId> =
            state.assignments.Add(fun config -> config.NextHopType <- value)
            state : VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, 'NextHop, 'RouteTableId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table_route#timeouts-1">VirtualHubRouteTableRouteA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, 'NextHop, 'RouteTableId>, value: azurerm.VirtualHubRouteTableRoute.VirtualHubRouteTableRouteTimeouts) : VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, 'NextHop, 'RouteTableId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualHubRouteTableRouteAState<'Destinations, 'DestinationsType, 'Name, 'NextHop, 'RouteTableId>

        member _.Run(state: VirtualHubRouteTableRouteAState<Present, Present, Present, Present, Present>) : azurerm.VirtualHubRouteTableRoute.VirtualHubRouteTableRouteA =
            let config = azurerm.VirtualHubRouteTableRoute.VirtualHubRouteTableRouteAConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualHubRouteTableRoute.VirtualHubRouteTableRouteA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualHubRouteTableRouteA: missing required arguments. Must call: destinations, destinations_type, name, next_hop, route_table_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualHubRouteTableRouteAState<_, _, _, _, _>) : azurerm.VirtualHubRouteTableRoute.VirtualHubRouteTableRouteA =
            Unchecked.defaultof<azurerm.VirtualHubRouteTableRoute.VirtualHubRouteTableRouteA>
