namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> = { assignments: ResizeArray<azurerm.SystemCenterVirtualMachineManagerCloud.SystemCenterVirtualMachineManagerCloudConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_cloud">azurerm_system_center_virtual_machine_manager_cloud</a>.
    /// </summary>
    type SystemCenterVirtualMachineManagerCloudBuilder(logicalId: string) =
        member _.Yield(_: unit) : SystemCenterVirtualMachineManagerCloudState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SystemCenterVirtualMachineManagerCloudState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SystemCenterVirtualMachineManagerCloudState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SystemCenterVirtualMachineManagerCloudState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_cloud#custom_location_id-1">SystemCenterVirtualMachineManagerCloud#custom_location_id</a>.
        /// </summary>
        [<CustomOperation "custom_location_id">]
        member _.CustomLocationId(state: SystemCenterVirtualMachineManagerCloudState<Missing, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerCloudState<Present, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.CustomLocationId <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerCloudState<Present, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_cloud#location-1">SystemCenterVirtualMachineManagerCloud#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, Missing, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, Present, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, Present, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_cloud#name-1">SystemCenterVirtualMachineManagerCloud#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, Missing, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, Present, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, Present, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_cloud#resource_group_name-1">SystemCenterVirtualMachineManagerCloud#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, Missing, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, Present, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, Present, 'SystemCenterVirtualMachineManagerServerInventoryItemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_cloud#system_center_virtual_machine_manager_server_inventory_item_id-1">SystemCenterVirtualMachineManagerCloud#system_center_virtual_machine_manager_server_inventory_item_id</a>.
        /// </summary>
        [<CustomOperation "system_center_virtual_machine_manager_server_inventory_item_id">]
        member _.SystemCenterVirtualMachineManagerServerInventoryItemId(state: SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SystemCenterVirtualMachineManagerServerInventoryItemId <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_cloud#id-1">SystemCenterVirtualMachineManagerCloud#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_cloud#tags-1">SystemCenterVirtualMachineManagerCloud#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: seq<string * string>) : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_cloud#timeouts-1">SystemCenterVirtualMachineManagerCloud#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: azurerm.SystemCenterVirtualMachineManagerCloud.SystemCenterVirtualMachineManagerCloudTimeouts) : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SystemCenterVirtualMachineManagerCloudState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>

        member _.Run(state: SystemCenterVirtualMachineManagerCloudState<Present, Present, Present, Present, Present>) : azurerm.SystemCenterVirtualMachineManagerCloud.SystemCenterVirtualMachineManagerCloud =
            let config = azurerm.SystemCenterVirtualMachineManagerCloud.SystemCenterVirtualMachineManagerCloudConfig()
            for setter in state.assignments do
                setter config
            azurerm.SystemCenterVirtualMachineManagerCloud.SystemCenterVirtualMachineManagerCloud(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.systemCenterVirtualMachineManagerCloud: missing required arguments. Must call: custom_location_id, location, name, resource_group_name, system_center_virtual_machine_manager_server_inventory_item_id.", 9999, IsError = true)>]
        member _.Run(_: SystemCenterVirtualMachineManagerCloudState<_, _, _, _, _>) : azurerm.SystemCenterVirtualMachineManagerCloud.SystemCenterVirtualMachineManagerCloud =
            Unchecked.defaultof<azurerm.SystemCenterVirtualMachineManagerCloud.SystemCenterVirtualMachineManagerCloud>
