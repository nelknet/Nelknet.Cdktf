namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RouteMapState<'Name, 'VirtualHubId> = { assignments: ResizeArray<azurerm.RouteMap.RouteMapConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map">azurerm_route_map</a>.
    /// </summary>
    type RouteMapBuilder(logicalId: string) =
        member _.Yield(_: unit) : RouteMapState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RouteMapState<Missing, Missing>)

        member _.Zero(()) : RouteMapState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RouteMapState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#name-1">RouteMap#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RouteMapState<Missing, 'VirtualHubId>, value: string) : RouteMapState<Present, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RouteMapState<Present, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#virtual_hub_id-1">RouteMap#virtual_hub_id</a>.
        /// </summary>
        [<CustomOperation "virtual_hub_id">]
        member _.VirtualHubId(state: RouteMapState<'Name, Missing>, value: string) : RouteMapState<'Name, Present> =
            state.assignments.Add(fun config -> config.VirtualHubId <- value)
            ({ assignments = state.assignments } : RouteMapState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#id-1">RouteMap#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RouteMapState<'Name, 'VirtualHubId>, value: string) : RouteMapState<'Name, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RouteMapState<'Name, 'VirtualHubId>

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#rule-1">RouteMap#rule</a> Accepts: azurerm.IResolvable | azurerm.RouteMap.RouteMapRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: RouteMapState<'Name, 'VirtualHubId>, value: HashiCorp.Cdktf.IResolvable) : RouteMapState<'Name, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : RouteMapState<'Name, 'VirtualHubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_map#timeouts-1">RouteMap#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RouteMapState<'Name, 'VirtualHubId>, value: azurerm.RouteMap.RouteMapTimeouts) : RouteMapState<'Name, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RouteMapState<'Name, 'VirtualHubId>

        member _.Run(state: RouteMapState<Present, Present>) : azurerm.RouteMap.RouteMap =
            let config = azurerm.RouteMap.RouteMapConfig()
            for setter in state.assignments do
                setter config
            azurerm.RouteMap.RouteMap(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.routeMap: missing required arguments. Must call: name, virtual_hub_id.", 9999, IsError = true)>]
        member _.Run(_: RouteMapState<_, _>) : azurerm.RouteMap.RouteMap =
            Unchecked.defaultof<azurerm.RouteMap.RouteMap>
