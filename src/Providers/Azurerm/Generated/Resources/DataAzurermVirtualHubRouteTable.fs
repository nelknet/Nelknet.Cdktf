namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVirtualHubRouteTableState<'Name, 'ResourceGroupName, 'VirtualHubName> = { assignments: ResizeArray<azurerm.DataAzurermVirtualHubRouteTable.DataAzurermVirtualHubRouteTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_route_table">azurerm_virtual_hub_route_table</a>.
    /// </summary>
    type DataAzurermVirtualHubRouteTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVirtualHubRouteTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualHubRouteTableState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermVirtualHubRouteTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualHubRouteTableState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_route_table#name-1">DataAzurermVirtualHubRouteTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVirtualHubRouteTableState<Missing, 'ResourceGroupName, 'VirtualHubName>, value: string) : DataAzurermVirtualHubRouteTableState<Present, 'ResourceGroupName, 'VirtualHubName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualHubRouteTableState<Present, 'ResourceGroupName, 'VirtualHubName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_route_table#resource_group_name-1">DataAzurermVirtualHubRouteTable#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVirtualHubRouteTableState<'Name, Missing, 'VirtualHubName>, value: string) : DataAzurermVirtualHubRouteTableState<'Name, Present, 'VirtualHubName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualHubRouteTableState<'Name, Present, 'VirtualHubName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_route_table#virtual_hub_name-1">DataAzurermVirtualHubRouteTable#virtual_hub_name</a>.
        /// </summary>
        [<CustomOperation "virtual_hub_name">]
        member _.VirtualHubName(state: DataAzurermVirtualHubRouteTableState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermVirtualHubRouteTableState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VirtualHubName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualHubRouteTableState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_route_table#id-1">DataAzurermVirtualHubRouteTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVirtualHubRouteTableState<'Name, 'ResourceGroupName, 'VirtualHubName>, value: string) : DataAzurermVirtualHubRouteTableState<'Name, 'ResourceGroupName, 'VirtualHubName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVirtualHubRouteTableState<'Name, 'ResourceGroupName, 'VirtualHubName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub_route_table#timeouts-1">DataAzurermVirtualHubRouteTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVirtualHubRouteTableState<'Name, 'ResourceGroupName, 'VirtualHubName>, value: azurerm.DataAzurermVirtualHubRouteTable.DataAzurermVirtualHubRouteTableTimeouts) : DataAzurermVirtualHubRouteTableState<'Name, 'ResourceGroupName, 'VirtualHubName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVirtualHubRouteTableState<'Name, 'ResourceGroupName, 'VirtualHubName>

        member _.Run(state: DataAzurermVirtualHubRouteTableState<Present, Present, Present>) : azurerm.DataAzurermVirtualHubRouteTable.DataAzurermVirtualHubRouteTable =
            let config = azurerm.DataAzurermVirtualHubRouteTable.DataAzurermVirtualHubRouteTableConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVirtualHubRouteTable.DataAzurermVirtualHubRouteTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVirtualHubRouteTable: missing required arguments. Must call: name, resource_group_name, virtual_hub_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVirtualHubRouteTableState<_, _, _>) : azurerm.DataAzurermVirtualHubRouteTable.DataAzurermVirtualHubRouteTable =
            Unchecked.defaultof<azurerm.DataAzurermVirtualHubRouteTable.DataAzurermVirtualHubRouteTable>
