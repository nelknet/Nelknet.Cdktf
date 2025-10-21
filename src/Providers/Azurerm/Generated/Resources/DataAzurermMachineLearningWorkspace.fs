namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMachineLearningWorkspaceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermMachineLearningWorkspace.DataAzurermMachineLearningWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/machine_learning_workspace">azurerm_machine_learning_workspace</a>.
    /// </summary>
    type DataAzurermMachineLearningWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMachineLearningWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMachineLearningWorkspaceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMachineLearningWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMachineLearningWorkspaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/machine_learning_workspace#name-1">DataAzurermMachineLearningWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMachineLearningWorkspaceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermMachineLearningWorkspaceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMachineLearningWorkspaceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/machine_learning_workspace#resource_group_name-1">DataAzurermMachineLearningWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMachineLearningWorkspaceState<'Name, Missing>, value: string) : DataAzurermMachineLearningWorkspaceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMachineLearningWorkspaceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/machine_learning_workspace#id-1">DataAzurermMachineLearningWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMachineLearningWorkspaceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermMachineLearningWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMachineLearningWorkspaceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/machine_learning_workspace#timeouts-1">DataAzurermMachineLearningWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMachineLearningWorkspaceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermMachineLearningWorkspace.DataAzurermMachineLearningWorkspaceTimeouts) : DataAzurermMachineLearningWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMachineLearningWorkspaceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermMachineLearningWorkspaceState<Present, Present>) : azurerm.DataAzurermMachineLearningWorkspace.DataAzurermMachineLearningWorkspace =
            let config = azurerm.DataAzurermMachineLearningWorkspace.DataAzurermMachineLearningWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMachineLearningWorkspace.DataAzurermMachineLearningWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMachineLearningWorkspace: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMachineLearningWorkspaceState<_, _>) : azurerm.DataAzurermMachineLearningWorkspace.DataAzurermMachineLearningWorkspace =
            Unchecked.defaultof<azurerm.DataAzurermMachineLearningWorkspace.DataAzurermMachineLearningWorkspace>
