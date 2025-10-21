namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermRouteTableState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermRouteTable.DataAzurermRouteTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_table">azurerm_route_table</a>.
    /// </summary>
    type DataAzurermRouteTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermRouteTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermRouteTableState<Missing, Missing>)

        member _.Zero(()) : DataAzurermRouteTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermRouteTableState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_table#name-1">DataAzurermRouteTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermRouteTableState<Missing, 'ResourceGroupName>, value: string) : DataAzurermRouteTableState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermRouteTableState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_table#resource_group_name-1">DataAzurermRouteTable#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermRouteTableState<'Name, Missing>, value: string) : DataAzurermRouteTableState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermRouteTableState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_table#id-1">DataAzurermRouteTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermRouteTableState<'Name, 'ResourceGroupName>, value: string) : DataAzurermRouteTableState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermRouteTableState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_table#timeouts-1">DataAzurermRouteTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermRouteTableState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermRouteTable.DataAzurermRouteTableTimeouts) : DataAzurermRouteTableState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermRouteTableState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermRouteTableState<Present, Present>) : azurerm.DataAzurermRouteTable.DataAzurermRouteTable =
            let config = azurerm.DataAzurermRouteTable.DataAzurermRouteTableConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermRouteTable.DataAzurermRouteTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermRouteTable: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermRouteTableState<_, _>) : azurerm.DataAzurermRouteTable.DataAzurermRouteTable =
            Unchecked.defaultof<azurerm.DataAzurermRouteTable.DataAzurermRouteTable>
