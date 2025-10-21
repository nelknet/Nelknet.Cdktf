namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualMachineAutomanageConfigurationAssignmentState<'ConfigurationId, 'VirtualMachineId> = { assignments: ResizeArray<azurerm.VirtualMachineAutomanageConfigurationAssignment.VirtualMachineAutomanageConfigurationAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_automanage_configuration_assignment">azurerm_virtual_machine_automanage_configuration_assignment</a>.
    /// </summary>
    type VirtualMachineAutomanageConfigurationAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualMachineAutomanageConfigurationAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineAutomanageConfigurationAssignmentState<Missing, Missing>)

        member _.Zero(()) : VirtualMachineAutomanageConfigurationAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineAutomanageConfigurationAssignmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_automanage_configuration_assignment#configuration_id-1">VirtualMachineAutomanageConfigurationAssignment#configuration_id</a>.
        /// </summary>
        [<CustomOperation "configuration_id">]
        member _.ConfigurationId(state: VirtualMachineAutomanageConfigurationAssignmentState<Missing, 'VirtualMachineId>, value: string) : VirtualMachineAutomanageConfigurationAssignmentState<Present, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.ConfigurationId <- value)
            ({ assignments = state.assignments } : VirtualMachineAutomanageConfigurationAssignmentState<Present, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_automanage_configuration_assignment#virtual_machine_id-1">VirtualMachineAutomanageConfigurationAssignment#virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_id">]
        member _.VirtualMachineId(state: VirtualMachineAutomanageConfigurationAssignmentState<'ConfigurationId, Missing>, value: string) : VirtualMachineAutomanageConfigurationAssignmentState<'ConfigurationId, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineId <- value)
            ({ assignments = state.assignments } : VirtualMachineAutomanageConfigurationAssignmentState<'ConfigurationId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_automanage_configuration_assignment#id-1">VirtualMachineAutomanageConfigurationAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualMachineAutomanageConfigurationAssignmentState<'ConfigurationId, 'VirtualMachineId>, value: string) : VirtualMachineAutomanageConfigurationAssignmentState<'ConfigurationId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualMachineAutomanageConfigurationAssignmentState<'ConfigurationId, 'VirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_automanage_configuration_assignment#timeouts-1">VirtualMachineAutomanageConfigurationAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualMachineAutomanageConfigurationAssignmentState<'ConfigurationId, 'VirtualMachineId>, value: azurerm.VirtualMachineAutomanageConfigurationAssignment.VirtualMachineAutomanageConfigurationAssignmentTimeouts) : VirtualMachineAutomanageConfigurationAssignmentState<'ConfigurationId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualMachineAutomanageConfigurationAssignmentState<'ConfigurationId, 'VirtualMachineId>

        member _.Run(state: VirtualMachineAutomanageConfigurationAssignmentState<Present, Present>) : azurerm.VirtualMachineAutomanageConfigurationAssignment.VirtualMachineAutomanageConfigurationAssignment =
            let config = azurerm.VirtualMachineAutomanageConfigurationAssignment.VirtualMachineAutomanageConfigurationAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualMachineAutomanageConfigurationAssignment.VirtualMachineAutomanageConfigurationAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualMachineAutomanageConfigurationAssignment: missing required arguments. Must call: configuration_id, virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualMachineAutomanageConfigurationAssignmentState<_, _>) : azurerm.VirtualMachineAutomanageConfigurationAssignment.VirtualMachineAutomanageConfigurationAssignment =
            Unchecked.defaultof<azurerm.VirtualMachineAutomanageConfigurationAssignment.VirtualMachineAutomanageConfigurationAssignment>
