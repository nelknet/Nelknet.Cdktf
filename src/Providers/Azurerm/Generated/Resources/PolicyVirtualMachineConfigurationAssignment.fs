namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PolicyVirtualMachineConfigurationAssignmentState<'Configuration, 'Location, 'Name, 'VirtualMachineId> = { assignments: ResizeArray<azurerm.PolicyVirtualMachineConfigurationAssignment.PolicyVirtualMachineConfigurationAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_virtual_machine_configuration_assignment">azurerm_policy_virtual_machine_configuration_assignment</a>.
    /// </summary>
    type PolicyVirtualMachineConfigurationAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : PolicyVirtualMachineConfigurationAssignmentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PolicyVirtualMachineConfigurationAssignmentState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PolicyVirtualMachineConfigurationAssignmentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PolicyVirtualMachineConfigurationAssignmentState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_virtual_machine_configuration_assignment#configuration-1">PolicyVirtualMachineConfigurationAssignment#configuration</a>
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: PolicyVirtualMachineConfigurationAssignmentState<Missing, 'Location, 'Name, 'VirtualMachineId>, value: azurerm.PolicyVirtualMachineConfigurationAssignment.PolicyVirtualMachineConfigurationAssignmentConfiguration) : PolicyVirtualMachineConfigurationAssignmentState<Present, 'Location, 'Name, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            ({ assignments = state.assignments } : PolicyVirtualMachineConfigurationAssignmentState<Present, 'Location, 'Name, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_virtual_machine_configuration_assignment#location-1">PolicyVirtualMachineConfigurationAssignment#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PolicyVirtualMachineConfigurationAssignmentState<'Configuration, Missing, 'Name, 'VirtualMachineId>, value: string) : PolicyVirtualMachineConfigurationAssignmentState<'Configuration, Present, 'Name, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PolicyVirtualMachineConfigurationAssignmentState<'Configuration, Present, 'Name, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_virtual_machine_configuration_assignment#name-1">PolicyVirtualMachineConfigurationAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PolicyVirtualMachineConfigurationAssignmentState<'Configuration, 'Location, Missing, 'VirtualMachineId>, value: string) : PolicyVirtualMachineConfigurationAssignmentState<'Configuration, 'Location, Present, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PolicyVirtualMachineConfigurationAssignmentState<'Configuration, 'Location, Present, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_virtual_machine_configuration_assignment#virtual_machine_id-1">PolicyVirtualMachineConfigurationAssignment#virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_id">]
        member _.VirtualMachineId(state: PolicyVirtualMachineConfigurationAssignmentState<'Configuration, 'Location, 'Name, Missing>, value: string) : PolicyVirtualMachineConfigurationAssignmentState<'Configuration, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineId <- value)
            ({ assignments = state.assignments } : PolicyVirtualMachineConfigurationAssignmentState<'Configuration, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_virtual_machine_configuration_assignment#id-1">PolicyVirtualMachineConfigurationAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PolicyVirtualMachineConfigurationAssignmentState<'Configuration, 'Location, 'Name, 'VirtualMachineId>, value: string) : PolicyVirtualMachineConfigurationAssignmentState<'Configuration, 'Location, 'Name, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PolicyVirtualMachineConfigurationAssignmentState<'Configuration, 'Location, 'Name, 'VirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_virtual_machine_configuration_assignment#timeouts-1">PolicyVirtualMachineConfigurationAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PolicyVirtualMachineConfigurationAssignmentState<'Configuration, 'Location, 'Name, 'VirtualMachineId>, value: azurerm.PolicyVirtualMachineConfigurationAssignment.PolicyVirtualMachineConfigurationAssignmentTimeouts) : PolicyVirtualMachineConfigurationAssignmentState<'Configuration, 'Location, 'Name, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PolicyVirtualMachineConfigurationAssignmentState<'Configuration, 'Location, 'Name, 'VirtualMachineId>

        member _.Run(state: PolicyVirtualMachineConfigurationAssignmentState<Present, Present, Present, Present>) : azurerm.PolicyVirtualMachineConfigurationAssignment.PolicyVirtualMachineConfigurationAssignment =
            let config = azurerm.PolicyVirtualMachineConfigurationAssignment.PolicyVirtualMachineConfigurationAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.PolicyVirtualMachineConfigurationAssignment.PolicyVirtualMachineConfigurationAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.policyVirtualMachineConfigurationAssignment: missing required arguments. Must call: configuration, location, name, virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: PolicyVirtualMachineConfigurationAssignmentState<_, _, _, _>) : azurerm.PolicyVirtualMachineConfigurationAssignment.PolicyVirtualMachineConfigurationAssignment =
            Unchecked.defaultof<azurerm.PolicyVirtualMachineConfigurationAssignment.PolicyVirtualMachineConfigurationAssignment>
