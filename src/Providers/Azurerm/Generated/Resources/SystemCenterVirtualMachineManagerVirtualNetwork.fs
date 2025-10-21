namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> = { assignments: ResizeArray<azurerm.SystemCenterVirtualMachineManagerVirtualNetwork.SystemCenterVirtualMachineManagerVirtualNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_network">azurerm_system_center_virtual_machine_manager_virtual_network</a>.
    /// </summary>
    type SystemCenterVirtualMachineManagerVirtualNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : SystemCenterVirtualMachineManagerVirtualNetworkState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SystemCenterVirtualMachineManagerVirtualNetworkState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SystemCenterVirtualMachineManagerVirtualNetworkState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SystemCenterVirtualMachineManagerVirtualNetworkState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_network#custom_location_id-1">SystemCenterVirtualMachineManagerVirtualNetwork#custom_location_id</a>.
        /// </summary>
        [<CustomOperation "custom_location_id">]
        member _.CustomLocationId(state: SystemCenterVirtualMachineManagerVirtualNetworkState<Missing, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerVirtualNetworkState<Present, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.CustomLocationId <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerVirtualNetworkState<Present, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_network#location-1">SystemCenterVirtualMachineManagerVirtualNetwork#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, Missing, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, Present, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, Present, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_network#name-1">SystemCenterVirtualMachineManagerVirtualNetwork#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, Missing, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, Present, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, Present, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_network#resource_group_name-1">SystemCenterVirtualMachineManagerVirtualNetwork#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, Missing, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, Present, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, Present, 'SystemCenterVirtualMachineManagerServerInventoryItemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_network#system_center_virtual_machine_manager_server_inventory_item_id-1">SystemCenterVirtualMachineManagerVirtualNetwork#system_center_virtual_machine_manager_server_inventory_item_id</a>.
        /// </summary>
        [<CustomOperation "system_center_virtual_machine_manager_server_inventory_item_id">]
        member _.SystemCenterVirtualMachineManagerServerInventoryItemId(state: SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SystemCenterVirtualMachineManagerServerInventoryItemId <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_network#id-1">SystemCenterVirtualMachineManagerVirtualNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_network#tags-1">SystemCenterVirtualMachineManagerVirtualNetwork#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: seq<string * string>) : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_network#timeouts-1">SystemCenterVirtualMachineManagerVirtualNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: azurerm.SystemCenterVirtualMachineManagerVirtualNetwork.SystemCenterVirtualMachineManagerVirtualNetworkTimeouts) : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SystemCenterVirtualMachineManagerVirtualNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>

        member _.Run(state: SystemCenterVirtualMachineManagerVirtualNetworkState<Present, Present, Present, Present, Present>) : azurerm.SystemCenterVirtualMachineManagerVirtualNetwork.SystemCenterVirtualMachineManagerVirtualNetwork =
            let config = azurerm.SystemCenterVirtualMachineManagerVirtualNetwork.SystemCenterVirtualMachineManagerVirtualNetworkConfig()
            for setter in state.assignments do
                setter config
            azurerm.SystemCenterVirtualMachineManagerVirtualNetwork.SystemCenterVirtualMachineManagerVirtualNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.systemCenterVirtualMachineManagerVirtualNetwork: missing required arguments. Must call: custom_location_id, location, name, resource_group_name, system_center_virtual_machine_manager_server_inventory_item_id.", 9999, IsError = true)>]
        member _.Run(_: SystemCenterVirtualMachineManagerVirtualNetworkState<_, _, _, _, _>) : azurerm.SystemCenterVirtualMachineManagerVirtualNetwork.SystemCenterVirtualMachineManagerVirtualNetwork =
            Unchecked.defaultof<azurerm.SystemCenterVirtualMachineManagerVirtualNetwork.SystemCenterVirtualMachineManagerVirtualNetwork>
