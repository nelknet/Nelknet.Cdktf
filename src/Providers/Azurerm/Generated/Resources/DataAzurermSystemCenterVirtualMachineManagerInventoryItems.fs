namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<'InventoryType, 'SystemCenterVirtualMachineManagerServerId> = { assignments: ResizeArray<azurerm.DataAzurermSystemCenterVirtualMachineManagerInventoryItems.DataAzurermSystemCenterVirtualMachineManagerInventoryItemsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/system_center_virtual_machine_manager_inventory_items">azurerm_system_center_virtual_machine_manager_inventory_items</a>.
    /// </summary>
    type DataAzurermSystemCenterVirtualMachineManagerInventoryItemsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<Missing, Missing>)

        member _.Zero(()) : DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/system_center_virtual_machine_manager_inventory_items#inventory_type-1">DataAzurermSystemCenterVirtualMachineManagerInventoryItems#inventory_type</a>.
        /// </summary>
        [<CustomOperation "inventory_type">]
        member _.InventoryType(state: DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<Missing, 'SystemCenterVirtualMachineManagerServerId>, value: string) : DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<Present, 'SystemCenterVirtualMachineManagerServerId> =
            state.assignments.Add(fun config -> config.InventoryType <- value)
            ({ assignments = state.assignments } : DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<Present, 'SystemCenterVirtualMachineManagerServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/system_center_virtual_machine_manager_inventory_items#system_center_virtual_machine_manager_server_id-1">DataAzurermSystemCenterVirtualMachineManagerInventoryItems#system_center_virtual_machine_manager_server_id</a>.
        /// </summary>
        [<CustomOperation "system_center_virtual_machine_manager_server_id">]
        member _.SystemCenterVirtualMachineManagerServerId(state: DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<'InventoryType, Missing>, value: string) : DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<'InventoryType, Present> =
            state.assignments.Add(fun config -> config.SystemCenterVirtualMachineManagerServerId <- value)
            ({ assignments = state.assignments } : DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<'InventoryType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/system_center_virtual_machine_manager_inventory_items#id-1">DataAzurermSystemCenterVirtualMachineManagerInventoryItems#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<'InventoryType, 'SystemCenterVirtualMachineManagerServerId>, value: string) : DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<'InventoryType, 'SystemCenterVirtualMachineManagerServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<'InventoryType, 'SystemCenterVirtualMachineManagerServerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/system_center_virtual_machine_manager_inventory_items#timeouts-1">DataAzurermSystemCenterVirtualMachineManagerInventoryItems#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<'InventoryType, 'SystemCenterVirtualMachineManagerServerId>, value: azurerm.DataAzurermSystemCenterVirtualMachineManagerInventoryItems.DataAzurermSystemCenterVirtualMachineManagerInventoryItemsTimeouts) : DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<'InventoryType, 'SystemCenterVirtualMachineManagerServerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<'InventoryType, 'SystemCenterVirtualMachineManagerServerId>

        member _.Run(state: DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<Present, Present>) : azurerm.DataAzurermSystemCenterVirtualMachineManagerInventoryItems.DataAzurermSystemCenterVirtualMachineManagerInventoryItems =
            let config = azurerm.DataAzurermSystemCenterVirtualMachineManagerInventoryItems.DataAzurermSystemCenterVirtualMachineManagerInventoryItemsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSystemCenterVirtualMachineManagerInventoryItems.DataAzurermSystemCenterVirtualMachineManagerInventoryItems(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSystemCenterVirtualMachineManagerInventoryItems: missing required arguments. Must call: inventory_type, system_center_virtual_machine_manager_server_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSystemCenterVirtualMachineManagerInventoryItemsState<_, _>) : azurerm.DataAzurermSystemCenterVirtualMachineManagerInventoryItems.DataAzurermSystemCenterVirtualMachineManagerInventoryItems =
            Unchecked.defaultof<azurerm.DataAzurermSystemCenterVirtualMachineManagerInventoryItems.DataAzurermSystemCenterVirtualMachineManagerInventoryItems>
