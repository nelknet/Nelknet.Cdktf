namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermOrchestratedVirtualMachineScaleSetState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermOrchestratedVirtualMachineScaleSet.DataAzurermOrchestratedVirtualMachineScaleSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/orchestrated_virtual_machine_scale_set">azurerm_orchestrated_virtual_machine_scale_set</a>.
    /// </summary>
    type DataAzurermOrchestratedVirtualMachineScaleSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermOrchestratedVirtualMachineScaleSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermOrchestratedVirtualMachineScaleSetState<Missing, Missing>)

        member _.Zero(()) : DataAzurermOrchestratedVirtualMachineScaleSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermOrchestratedVirtualMachineScaleSetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/orchestrated_virtual_machine_scale_set#name-1">DataAzurermOrchestratedVirtualMachineScaleSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermOrchestratedVirtualMachineScaleSetState<Missing, 'ResourceGroupName>, value: string) : DataAzurermOrchestratedVirtualMachineScaleSetState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermOrchestratedVirtualMachineScaleSetState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/orchestrated_virtual_machine_scale_set#resource_group_name-1">DataAzurermOrchestratedVirtualMachineScaleSet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermOrchestratedVirtualMachineScaleSetState<'Name, Missing>, value: string) : DataAzurermOrchestratedVirtualMachineScaleSetState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermOrchestratedVirtualMachineScaleSetState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/orchestrated_virtual_machine_scale_set#id-1">DataAzurermOrchestratedVirtualMachineScaleSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermOrchestratedVirtualMachineScaleSetState<'Name, 'ResourceGroupName>, value: string) : DataAzurermOrchestratedVirtualMachineScaleSetState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermOrchestratedVirtualMachineScaleSetState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/orchestrated_virtual_machine_scale_set#timeouts-1">DataAzurermOrchestratedVirtualMachineScaleSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermOrchestratedVirtualMachineScaleSetState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermOrchestratedVirtualMachineScaleSet.DataAzurermOrchestratedVirtualMachineScaleSetTimeouts) : DataAzurermOrchestratedVirtualMachineScaleSetState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermOrchestratedVirtualMachineScaleSetState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermOrchestratedVirtualMachineScaleSetState<Present, Present>) : azurerm.DataAzurermOrchestratedVirtualMachineScaleSet.DataAzurermOrchestratedVirtualMachineScaleSet =
            let config = azurerm.DataAzurermOrchestratedVirtualMachineScaleSet.DataAzurermOrchestratedVirtualMachineScaleSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermOrchestratedVirtualMachineScaleSet.DataAzurermOrchestratedVirtualMachineScaleSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermOrchestratedVirtualMachineScaleSet: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermOrchestratedVirtualMachineScaleSetState<_, _>) : azurerm.DataAzurermOrchestratedVirtualMachineScaleSet.DataAzurermOrchestratedVirtualMachineScaleSet =
            Unchecked.defaultof<azurerm.DataAzurermOrchestratedVirtualMachineScaleSet.DataAzurermOrchestratedVirtualMachineScaleSet>
