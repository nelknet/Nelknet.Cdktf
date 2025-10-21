namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPolicyVirtualMachineConfigurationAssignmentState<'Name, 'ResourceGroupName, 'VirtualMachineName> = { assignments: ResizeArray<azurerm.DataAzurermPolicyVirtualMachineConfigurationAssignment.DataAzurermPolicyVirtualMachineConfigurationAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_virtual_machine_configuration_assignment">azurerm_policy_virtual_machine_configuration_assignment</a>.
    /// </summary>
    type DataAzurermPolicyVirtualMachineConfigurationAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_virtual_machine_configuration_assignment#name-1">DataAzurermPolicyVirtualMachineConfigurationAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPolicyVirtualMachineConfigurationAssignmentState<Missing, 'ResourceGroupName, 'VirtualMachineName>, value: string) : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<Present, 'ResourceGroupName, 'VirtualMachineName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<Present, 'ResourceGroupName, 'VirtualMachineName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_virtual_machine_configuration_assignment#resource_group_name-1">DataAzurermPolicyVirtualMachineConfigurationAssignment#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPolicyVirtualMachineConfigurationAssignmentState<'Name, Missing, 'VirtualMachineName>, value: string) : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<'Name, Present, 'VirtualMachineName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<'Name, Present, 'VirtualMachineName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_virtual_machine_configuration_assignment#virtual_machine_name-1">DataAzurermPolicyVirtualMachineConfigurationAssignment#virtual_machine_name</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_name">]
        member _.VirtualMachineName(state: DataAzurermPolicyVirtualMachineConfigurationAssignmentState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineName <- value)
            ({ assignments = state.assignments } : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_virtual_machine_configuration_assignment#id-1">DataAzurermPolicyVirtualMachineConfigurationAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPolicyVirtualMachineConfigurationAssignmentState<'Name, 'ResourceGroupName, 'VirtualMachineName>, value: string) : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<'Name, 'ResourceGroupName, 'VirtualMachineName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<'Name, 'ResourceGroupName, 'VirtualMachineName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_virtual_machine_configuration_assignment#timeouts-1">DataAzurermPolicyVirtualMachineConfigurationAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPolicyVirtualMachineConfigurationAssignmentState<'Name, 'ResourceGroupName, 'VirtualMachineName>, value: azurerm.DataAzurermPolicyVirtualMachineConfigurationAssignment.DataAzurermPolicyVirtualMachineConfigurationAssignmentTimeouts) : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<'Name, 'ResourceGroupName, 'VirtualMachineName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPolicyVirtualMachineConfigurationAssignmentState<'Name, 'ResourceGroupName, 'VirtualMachineName>

        member _.Run(state: DataAzurermPolicyVirtualMachineConfigurationAssignmentState<Present, Present, Present>) : azurerm.DataAzurermPolicyVirtualMachineConfigurationAssignment.DataAzurermPolicyVirtualMachineConfigurationAssignment =
            let config = azurerm.DataAzurermPolicyVirtualMachineConfigurationAssignment.DataAzurermPolicyVirtualMachineConfigurationAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPolicyVirtualMachineConfigurationAssignment.DataAzurermPolicyVirtualMachineConfigurationAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPolicyVirtualMachineConfigurationAssignment: missing required arguments. Must call: name, resource_group_name, virtual_machine_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPolicyVirtualMachineConfigurationAssignmentState<_, _, _>) : azurerm.DataAzurermPolicyVirtualMachineConfigurationAssignment.DataAzurermPolicyVirtualMachineConfigurationAssignment =
            Unchecked.defaultof<azurerm.DataAzurermPolicyVirtualMachineConfigurationAssignment.DataAzurermPolicyVirtualMachineConfigurationAssignment>
