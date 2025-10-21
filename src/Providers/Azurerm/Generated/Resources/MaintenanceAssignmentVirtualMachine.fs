namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MaintenanceAssignmentVirtualMachineState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineId> = { assignments: ResizeArray<azurerm.MaintenanceAssignmentVirtualMachine.MaintenanceAssignmentVirtualMachineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine">azurerm_maintenance_assignment_virtual_machine</a>.
    /// </summary>
    type MaintenanceAssignmentVirtualMachineBuilder(logicalId: string) =
        member _.Yield(_: unit) : MaintenanceAssignmentVirtualMachineState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MaintenanceAssignmentVirtualMachineState<Missing, Missing, Missing>)

        member _.Zero(()) : MaintenanceAssignmentVirtualMachineState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MaintenanceAssignmentVirtualMachineState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine#location-1">MaintenanceAssignmentVirtualMachine#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MaintenanceAssignmentVirtualMachineState<Missing, 'MaintenanceConfigurationId, 'VirtualMachineId>, value: string) : MaintenanceAssignmentVirtualMachineState<Present, 'MaintenanceConfigurationId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MaintenanceAssignmentVirtualMachineState<Present, 'MaintenanceConfigurationId, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine#maintenance_configuration_id-1">MaintenanceAssignmentVirtualMachine#maintenance_configuration_id</a>.
        /// </summary>
        [<CustomOperation "maintenance_configuration_id">]
        member _.MaintenanceConfigurationId(state: MaintenanceAssignmentVirtualMachineState<'Location, Missing, 'VirtualMachineId>, value: string) : MaintenanceAssignmentVirtualMachineState<'Location, Present, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.MaintenanceConfigurationId <- value)
            ({ assignments = state.assignments } : MaintenanceAssignmentVirtualMachineState<'Location, Present, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine#virtual_machine_id-1">MaintenanceAssignmentVirtualMachine#virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_id">]
        member _.VirtualMachineId(state: MaintenanceAssignmentVirtualMachineState<'Location, 'MaintenanceConfigurationId, Missing>, value: string) : MaintenanceAssignmentVirtualMachineState<'Location, 'MaintenanceConfigurationId, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineId <- value)
            ({ assignments = state.assignments } : MaintenanceAssignmentVirtualMachineState<'Location, 'MaintenanceConfigurationId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine#id-1">MaintenanceAssignmentVirtualMachine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MaintenanceAssignmentVirtualMachineState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineId>, value: string) : MaintenanceAssignmentVirtualMachineState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MaintenanceAssignmentVirtualMachineState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine#timeouts-1">MaintenanceAssignmentVirtualMachine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MaintenanceAssignmentVirtualMachineState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineId>, value: azurerm.MaintenanceAssignmentVirtualMachine.MaintenanceAssignmentVirtualMachineTimeouts) : MaintenanceAssignmentVirtualMachineState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MaintenanceAssignmentVirtualMachineState<'Location, 'MaintenanceConfigurationId, 'VirtualMachineId>

        member _.Run(state: MaintenanceAssignmentVirtualMachineState<Present, Present, Present>) : azurerm.MaintenanceAssignmentVirtualMachine.MaintenanceAssignmentVirtualMachine =
            let config = azurerm.MaintenanceAssignmentVirtualMachine.MaintenanceAssignmentVirtualMachineConfig()
            for setter in state.assignments do
                setter config
            azurerm.MaintenanceAssignmentVirtualMachine.MaintenanceAssignmentVirtualMachine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.maintenanceAssignmentVirtualMachine: missing required arguments. Must call: location, maintenance_configuration_id, virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: MaintenanceAssignmentVirtualMachineState<_, _, _>) : azurerm.MaintenanceAssignmentVirtualMachine.MaintenanceAssignmentVirtualMachine =
            Unchecked.defaultof<azurerm.MaintenanceAssignmentVirtualMachine.MaintenanceAssignmentVirtualMachine>
