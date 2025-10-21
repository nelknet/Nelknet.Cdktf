namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVirtualMachineState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermVirtualMachine.DataAzurermVirtualMachineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine">azurerm_virtual_machine</a>.
    /// </summary>
    type DataAzurermVirtualMachineBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVirtualMachineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualMachineState<Missing, Missing>)

        member _.Zero(()) : DataAzurermVirtualMachineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualMachineState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine#name-1">DataAzurermVirtualMachine#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVirtualMachineState<Missing, 'ResourceGroupName>, value: string) : DataAzurermVirtualMachineState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualMachineState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine#resource_group_name-1">DataAzurermVirtualMachine#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVirtualMachineState<'Name, Missing>, value: string) : DataAzurermVirtualMachineState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualMachineState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine#id-1">DataAzurermVirtualMachine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVirtualMachineState<'Name, 'ResourceGroupName>, value: string) : DataAzurermVirtualMachineState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVirtualMachineState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine#timeouts-1">DataAzurermVirtualMachine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVirtualMachineState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermVirtualMachine.DataAzurermVirtualMachineTimeouts) : DataAzurermVirtualMachineState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVirtualMachineState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermVirtualMachineState<Present, Present>) : azurerm.DataAzurermVirtualMachine.DataAzurermVirtualMachine =
            let config = azurerm.DataAzurermVirtualMachine.DataAzurermVirtualMachineConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVirtualMachine.DataAzurermVirtualMachine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVirtualMachine: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVirtualMachineState<_, _>) : azurerm.DataAzurermVirtualMachine.DataAzurermVirtualMachine =
            Unchecked.defaultof<azurerm.DataAzurermVirtualMachine.DataAzurermVirtualMachine>
