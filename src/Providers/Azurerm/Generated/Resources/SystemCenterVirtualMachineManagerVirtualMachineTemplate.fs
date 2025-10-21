namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> = { assignments: ResizeArray<azurerm.SystemCenterVirtualMachineManagerVirtualMachineTemplate.SystemCenterVirtualMachineManagerVirtualMachineTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_template">azurerm_system_center_virtual_machine_manager_virtual_machine_template</a>.
    /// </summary>
    type SystemCenterVirtualMachineManagerVirtualMachineTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_template#custom_location_id-1">SystemCenterVirtualMachineManagerVirtualMachineTemplate#custom_location_id</a>.
        /// </summary>
        [<CustomOperation "custom_location_id">]
        member _.CustomLocationId(state: SystemCenterVirtualMachineManagerVirtualMachineTemplateState<Missing, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<Present, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.CustomLocationId <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<Present, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_template#location-1">SystemCenterVirtualMachineManagerVirtualMachineTemplate#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, Missing, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, Present, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, Present, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_template#name-1">SystemCenterVirtualMachineManagerVirtualMachineTemplate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, Missing, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, Present, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, Present, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_template#resource_group_name-1">SystemCenterVirtualMachineManagerVirtualMachineTemplate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, Missing, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, Present, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, Present, 'SystemCenterVirtualMachineManagerServerInventoryItemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_template#system_center_virtual_machine_manager_server_inventory_item_id-1">SystemCenterVirtualMachineManagerVirtualMachineTemplate#system_center_virtual_machine_manager_server_inventory_item_id</a>.
        /// </summary>
        [<CustomOperation "system_center_virtual_machine_manager_server_inventory_item_id">]
        member _.SystemCenterVirtualMachineManagerServerInventoryItemId(state: SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SystemCenterVirtualMachineManagerServerInventoryItemId <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_template#id-1">SystemCenterVirtualMachineManagerVirtualMachineTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: string) : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_template#tags-1">SystemCenterVirtualMachineManagerVirtualMachineTemplate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: seq<string * string>) : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_template#timeouts-1">SystemCenterVirtualMachineManagerVirtualMachineTemplate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>, value: azurerm.SystemCenterVirtualMachineManagerVirtualMachineTemplate.SystemCenterVirtualMachineManagerVirtualMachineTemplateTimeouts) : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SystemCenterVirtualMachineManagerVirtualMachineTemplateState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerInventoryItemId>

        member _.Run(state: SystemCenterVirtualMachineManagerVirtualMachineTemplateState<Present, Present, Present, Present, Present>) : azurerm.SystemCenterVirtualMachineManagerVirtualMachineTemplate.SystemCenterVirtualMachineManagerVirtualMachineTemplate =
            let config = azurerm.SystemCenterVirtualMachineManagerVirtualMachineTemplate.SystemCenterVirtualMachineManagerVirtualMachineTemplateConfig()
            for setter in state.assignments do
                setter config
            azurerm.SystemCenterVirtualMachineManagerVirtualMachineTemplate.SystemCenterVirtualMachineManagerVirtualMachineTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.systemCenterVirtualMachineManagerVirtualMachineTemplate: missing required arguments. Must call: custom_location_id, location, name, resource_group_name, system_center_virtual_machine_manager_server_inventory_item_id.", 9999, IsError = true)>]
        member _.Run(_: SystemCenterVirtualMachineManagerVirtualMachineTemplateState<_, _, _, _, _>) : azurerm.SystemCenterVirtualMachineManagerVirtualMachineTemplate.SystemCenterVirtualMachineManagerVirtualMachineTemplate =
            Unchecked.defaultof<azurerm.SystemCenterVirtualMachineManagerVirtualMachineTemplate.SystemCenterVirtualMachineManagerVirtualMachineTemplate>
