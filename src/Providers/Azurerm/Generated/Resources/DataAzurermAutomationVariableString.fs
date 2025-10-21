namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAutomationVariableString.DataAzurermAutomationVariableStringConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_string">azurerm_automation_variable_string</a>.
    /// </summary>
    type DataAzurermAutomationVariableStringBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAutomationVariableStringState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationVariableStringState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermAutomationVariableStringState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationVariableStringState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_string#automation_account_name-1">DataAzurermAutomationVariableString#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: DataAzurermAutomationVariableStringState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableStringState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableStringState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_string#name-1">DataAzurermAutomationVariableString#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAutomationVariableStringState<'AutomationAccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableStringState<'AutomationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableStringState<'AutomationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_string#resource_group_name-1">DataAzurermAutomationVariableString#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAutomationVariableStringState<'AutomationAccountName, 'Name, Missing>, value: string) : DataAzurermAutomationVariableStringState<'AutomationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableStringState<'AutomationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_string#id-1">DataAzurermAutomationVariableString#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_string#timeouts-1">DataAzurermAutomationVariableString#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAutomationVariableString.DataAzurermAutomationVariableStringTimeouts) : DataAzurermAutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAutomationVariableStringState<Present, Present, Present>) : azurerm.DataAzurermAutomationVariableString.DataAzurermAutomationVariableString =
            let config = azurerm.DataAzurermAutomationVariableString.DataAzurermAutomationVariableStringConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAutomationVariableString.DataAzurermAutomationVariableString(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAutomationVariableString: missing required arguments. Must call: automation_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAutomationVariableStringState<_, _, _>) : azurerm.DataAzurermAutomationVariableString.DataAzurermAutomationVariableString =
            Unchecked.defaultof<azurerm.DataAzurermAutomationVariableString.DataAzurermAutomationVariableString>
