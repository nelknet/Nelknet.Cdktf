namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAutomationVariablesState<'AutomationAccountId> = { assignments: ResizeArray<azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variables">azurerm_automation_variables</a>.
    /// </summary>
    type DataAzurermAutomationVariablesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAutomationVariablesState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationVariablesState<Missing>)

        member _.Zero(()) : DataAzurermAutomationVariablesState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationVariablesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variables#automation_account_id-1">DataAzurermAutomationVariables#automation_account_id</a>.
        /// </summary>
        [<CustomOperation "automation_account_id">]
        member _.AutomationAccountId(state: DataAzurermAutomationVariablesState<Missing>, value: string) : DataAzurermAutomationVariablesState<Present> =
            state.assignments.Add(fun config -> config.AutomationAccountId <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariablesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variables#id-1">DataAzurermAutomationVariables#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAutomationVariablesState<'AutomationAccountId>, value: string) : DataAzurermAutomationVariablesState<'AutomationAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAutomationVariablesState<'AutomationAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variables#timeouts-1">DataAzurermAutomationVariables#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAutomationVariablesState<'AutomationAccountId>, value: azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesTimeouts) : DataAzurermAutomationVariablesState<'AutomationAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAutomationVariablesState<'AutomationAccountId>

        member _.Run(state: DataAzurermAutomationVariablesState<Present>) : azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariables =
            let config = azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariables(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAutomationVariables: missing required arguments. Must call: automation_account_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAutomationVariablesState<_>) : azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariables =
            Unchecked.defaultof<azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariables>
