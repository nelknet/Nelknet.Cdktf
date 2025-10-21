namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAutomationRunbookState<'AutomationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAutomationRunbook.DataAzurermAutomationRunbookConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_runbook">azurerm_automation_runbook</a>.
    /// </summary>
    type DataAzurermAutomationRunbookBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAutomationRunbookState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationRunbookState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermAutomationRunbookState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationRunbookState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_runbook#automation_account_name-1">DataAzurermAutomationRunbook#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: DataAzurermAutomationRunbookState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermAutomationRunbookState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationRunbookState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_runbook#name-1">DataAzurermAutomationRunbook#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAutomationRunbookState<'AutomationAccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermAutomationRunbookState<'AutomationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationRunbookState<'AutomationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_runbook#resource_group_name-1">DataAzurermAutomationRunbook#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAutomationRunbookState<'AutomationAccountName, 'Name, Missing>, value: string) : DataAzurermAutomationRunbookState<'AutomationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationRunbookState<'AutomationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_runbook#id-1">DataAzurermAutomationRunbook#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAutomationRunbookState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermAutomationRunbookState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAutomationRunbookState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_runbook#timeouts-1">DataAzurermAutomationRunbook#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAutomationRunbookState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAutomationRunbook.DataAzurermAutomationRunbookTimeouts) : DataAzurermAutomationRunbookState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAutomationRunbookState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAutomationRunbookState<Present, Present, Present>) : azurerm.DataAzurermAutomationRunbook.DataAzurermAutomationRunbook =
            let config = azurerm.DataAzurermAutomationRunbook.DataAzurermAutomationRunbookConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAutomationRunbook.DataAzurermAutomationRunbook(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAutomationRunbook: missing required arguments. Must call: automation_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAutomationRunbookState<_, _, _>) : azurerm.DataAzurermAutomationRunbook.DataAzurermAutomationRunbook =
            Unchecked.defaultof<azurerm.DataAzurermAutomationRunbook.DataAzurermAutomationRunbook>
