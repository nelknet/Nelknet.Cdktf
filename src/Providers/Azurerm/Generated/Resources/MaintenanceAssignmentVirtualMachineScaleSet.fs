namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MaintenanceAssignmentVirtualMachineScaleSetState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineScaleSetId> = { assignments: ResizeArray<azurerm.MaintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine_scale_set">azurerm_maintenance_assignment_virtual_machine_scale_set</a>.
    /// </summary>
    type MaintenanceAssignmentVirtualMachineScaleSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : MaintenanceAssignmentVirtualMachineScaleSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MaintenanceAssignmentVirtualMachineScaleSetState<Missing, Missing, Missing>)

        member _.Zero(()) : MaintenanceAssignmentVirtualMachineScaleSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MaintenanceAssignmentVirtualMachineScaleSetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine_scale_set#location-1">MaintenanceAssignmentVirtualMachineScaleSet#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MaintenanceAssignmentVirtualMachineScaleSetState<Missing, 'MaintenanceConfigurationId, 'VirtualMachineScaleSetId>, value: string) : MaintenanceAssignmentVirtualMachineScaleSetState<Present, 'MaintenanceConfigurationId, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MaintenanceAssignmentVirtualMachineScaleSetState<Present, 'MaintenanceConfigurationId, 'VirtualMachineScaleSetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine_scale_set#maintenance_configuration_id-1">MaintenanceAssignmentVirtualMachineScaleSet#maintenance_configuration_id</a>.
        /// </summary>
        [<CustomOperation "maintenance_configuration_id">]
        member _.MaintenanceConfigurationId(state: MaintenanceAssignmentVirtualMachineScaleSetState<'Location, Missing, 'VirtualMachineScaleSetId>, value: string) : MaintenanceAssignmentVirtualMachineScaleSetState<'Location, Present, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.MaintenanceConfigurationId <- value)
            ({ assignments = state.assignments } : MaintenanceAssignmentVirtualMachineScaleSetState<'Location, Present, 'VirtualMachineScaleSetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine_scale_set#virtual_machine_scale_set_id-1">MaintenanceAssignmentVirtualMachineScaleSet#virtual_machine_scale_set_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_scale_set_id">]
        member _.VirtualMachineScaleSetId(state: MaintenanceAssignmentVirtualMachineScaleSetState<'Location, 'MaintenanceConfigurationId, Missing>, value: string) : MaintenanceAssignmentVirtualMachineScaleSetState<'Location, 'MaintenanceConfigurationId, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineScaleSetId <- value)
            ({ assignments = state.assignments } : MaintenanceAssignmentVirtualMachineScaleSetState<'Location, 'MaintenanceConfigurationId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine_scale_set#id-1">MaintenanceAssignmentVirtualMachineScaleSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MaintenanceAssignmentVirtualMachineScaleSetState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineScaleSetId>, value: string) : MaintenanceAssignmentVirtualMachineScaleSetState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MaintenanceAssignmentVirtualMachineScaleSetState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineScaleSetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine_scale_set#timeouts-1">MaintenanceAssignmentVirtualMachineScaleSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MaintenanceAssignmentVirtualMachineScaleSetState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineScaleSetId>, value: azurerm.MaintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSetTimeouts) : MaintenanceAssignmentVirtualMachineScaleSetState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MaintenanceAssignmentVirtualMachineScaleSetState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineScaleSetId>

        member _.Run(state: MaintenanceAssignmentVirtualMachineScaleSetState<Present, Present, Present>) : azurerm.MaintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSet =
            let config = azurerm.MaintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.MaintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.maintenanceAssignmentVirtualMachineScaleSet: missing required arguments. Must call: location, maintenance_configuration_id, virtual_machine_scale_set_id.", 9999, IsError = true)>]
        member _.Run(_: MaintenanceAssignmentVirtualMachineScaleSetState<_, _, _>) : azurerm.MaintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSet =
            Unchecked.defaultof<azurerm.MaintenanceAssignmentVirtualMachineScaleSet.MaintenanceAssignmentVirtualMachineScaleSet>
