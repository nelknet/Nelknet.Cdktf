namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualHubRouteTableState<'Name, 'VirtualHubId> = { assignments: ResizeArray<azurerm.VirtualHubRouteTable.VirtualHubRouteTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table">azurerm_virtual_hub_route_table</a>.
    /// </summary>
    type VirtualHubRouteTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualHubRouteTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubRouteTableState<Missing, Missing>)

        member _.Zero(()) : VirtualHubRouteTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubRouteTableState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table#name-1">VirtualHubRouteTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualHubRouteTableState<Missing, 'VirtualHubId>, value: string) : VirtualHubRouteTableState<Present, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualHubRouteTableState<Present, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table#virtual_hub_id-1">VirtualHubRouteTable#virtual_hub_id</a>.
        /// </summary>
        [<CustomOperation "virtual_hub_id">]
        member _.VirtualHubId(state: VirtualHubRouteTableState<'Name, Missing>, value: string) : VirtualHubRouteTableState<'Name, Present> =
            state.assignments.Add(fun config -> config.VirtualHubId <- value)
            ({ assignments = state.assignments } : VirtualHubRouteTableState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table#id-1">VirtualHubRouteTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualHubRouteTableState<'Name, 'VirtualHubId>, value: string) : VirtualHubRouteTableState<'Name, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualHubRouteTableState<'Name, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table#labels-1">VirtualHubRouteTable#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: VirtualHubRouteTableState<'Name, 'VirtualHubId>, value: seq<string>) : VirtualHubRouteTableState<'Name, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Labels <- (value |> Seq.toArray))
            state : VirtualHubRouteTableState<'Name, 'VirtualHubId>

        /// <summary>
        /// route block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table#route-1">VirtualHubRouteTable#route</a> Accepts: azurerm.IResolvable | azurerm.VirtualHubRouteTable.VirtualHubRouteTableRoute[]
        /// </summary>
        [<CustomOperation "route">]
        member _.Route(state: VirtualHubRouteTableState<'Name, 'VirtualHubId>, value: HashiCorp.Cdktf.IResolvable) : VirtualHubRouteTableState<'Name, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Route <- value)
            state : VirtualHubRouteTableState<'Name, 'VirtualHubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table#timeouts-1">VirtualHubRouteTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualHubRouteTableState<'Name, 'VirtualHubId>, value: azurerm.VirtualHubRouteTable.VirtualHubRouteTableTimeouts) : VirtualHubRouteTableState<'Name, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualHubRouteTableState<'Name, 'VirtualHubId>

        member _.Run(state: VirtualHubRouteTableState<Present, Present>) : azurerm.VirtualHubRouteTable.VirtualHubRouteTable =
            let config = azurerm.VirtualHubRouteTable.VirtualHubRouteTableConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualHubRouteTable.VirtualHubRouteTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualHubRouteTable: missing required arguments. Must call: name, virtual_hub_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualHubRouteTableState<_, _>) : azurerm.VirtualHubRouteTable.VirtualHubRouteTable =
            Unchecked.defaultof<azurerm.VirtualHubRouteTable.VirtualHubRouteTable>
