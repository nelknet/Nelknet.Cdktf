namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVirtualMachineScaleSetState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine_scale_set">azurerm_virtual_machine_scale_set</a>.
    /// </summary>
    type DataAzurermVirtualMachineScaleSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVirtualMachineScaleSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualMachineScaleSetState<Missing, Missing>)

        member _.Zero(()) : DataAzurermVirtualMachineScaleSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualMachineScaleSetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine_scale_set#name-1">DataAzurermVirtualMachineScaleSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVirtualMachineScaleSetState<Missing, 'ResourceGroupName>, value: string) : DataAzurermVirtualMachineScaleSetState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualMachineScaleSetState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine_scale_set#resource_group_name-1">DataAzurermVirtualMachineScaleSet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVirtualMachineScaleSetState<'Name, Missing>, value: string) : DataAzurermVirtualMachineScaleSetState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualMachineScaleSetState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine_scale_set#id-1">DataAzurermVirtualMachineScaleSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVirtualMachineScaleSetState<'Name, 'ResourceGroupName>, value: string) : DataAzurermVirtualMachineScaleSetState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVirtualMachineScaleSetState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine_scale_set#timeouts-1">DataAzurermVirtualMachineScaleSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVirtualMachineScaleSetState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetTimeouts) : DataAzurermVirtualMachineScaleSetState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVirtualMachineScaleSetState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermVirtualMachineScaleSetState<Present, Present>) : azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSet =
            let config = azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVirtualMachineScaleSet: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVirtualMachineScaleSetState<_, _>) : azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSet =
            Unchecked.defaultof<azurerm.DataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSet>
