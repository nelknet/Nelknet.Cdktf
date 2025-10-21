namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermArcMachineState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermArcMachine.DataAzurermArcMachineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_machine">azurerm_arc_machine</a>.
    /// </summary>
    type DataAzurermArcMachineBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermArcMachineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermArcMachineState<Missing, Missing>)

        member _.Zero(()) : DataAzurermArcMachineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermArcMachineState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_machine#name-1">DataAzurermArcMachine#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermArcMachineState<Missing, 'ResourceGroupName>, value: string) : DataAzurermArcMachineState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermArcMachineState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_machine#resource_group_name-1">DataAzurermArcMachine#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermArcMachineState<'Name, Missing>, value: string) : DataAzurermArcMachineState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermArcMachineState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_machine#id-1">DataAzurermArcMachine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermArcMachineState<'Name, 'ResourceGroupName>, value: string) : DataAzurermArcMachineState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermArcMachineState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_machine#timeouts-1">DataAzurermArcMachine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermArcMachineState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermArcMachine.DataAzurermArcMachineTimeouts) : DataAzurermArcMachineState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermArcMachineState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermArcMachineState<Present, Present>) : azurerm.DataAzurermArcMachine.DataAzurermArcMachine =
            let config = azurerm.DataAzurermArcMachine.DataAzurermArcMachineConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermArcMachine.DataAzurermArcMachine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermArcMachine: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermArcMachineState<_, _>) : azurerm.DataAzurermArcMachine.DataAzurermArcMachine =
            Unchecked.defaultof<azurerm.DataAzurermArcMachine.DataAzurermArcMachine>
