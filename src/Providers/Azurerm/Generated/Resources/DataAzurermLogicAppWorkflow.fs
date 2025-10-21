namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermLogicAppWorkflowState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermLogicAppWorkflow.DataAzurermLogicAppWorkflowConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_workflow">azurerm_logic_app_workflow</a>.
    /// </summary>
    type DataAzurermLogicAppWorkflowBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermLogicAppWorkflowState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLogicAppWorkflowState<Missing, Missing>)

        member _.Zero(()) : DataAzurermLogicAppWorkflowState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLogicAppWorkflowState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_workflow#name-1">DataAzurermLogicAppWorkflow#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermLogicAppWorkflowState<Missing, 'ResourceGroupName>, value: string) : DataAzurermLogicAppWorkflowState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermLogicAppWorkflowState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_workflow#resource_group_name-1">DataAzurermLogicAppWorkflow#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermLogicAppWorkflowState<'Name, Missing>, value: string) : DataAzurermLogicAppWorkflowState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermLogicAppWorkflowState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_workflow#id-1">DataAzurermLogicAppWorkflow#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermLogicAppWorkflowState<'Name, 'ResourceGroupName>, value: string) : DataAzurermLogicAppWorkflowState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermLogicAppWorkflowState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_workflow#timeouts-1">DataAzurermLogicAppWorkflow#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermLogicAppWorkflowState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermLogicAppWorkflow.DataAzurermLogicAppWorkflowTimeouts) : DataAzurermLogicAppWorkflowState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermLogicAppWorkflowState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermLogicAppWorkflowState<Present, Present>) : azurerm.DataAzurermLogicAppWorkflow.DataAzurermLogicAppWorkflow =
            let config = azurerm.DataAzurermLogicAppWorkflow.DataAzurermLogicAppWorkflowConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermLogicAppWorkflow.DataAzurermLogicAppWorkflow(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermLogicAppWorkflow: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermLogicAppWorkflowState<_, _>) : azurerm.DataAzurermLogicAppWorkflow.DataAzurermLogicAppWorkflow =
            Unchecked.defaultof<azurerm.DataAzurermLogicAppWorkflow.DataAzurermLogicAppWorkflow>
