namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAutomationVariableBool.DataAzurermAutomationVariableBoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_bool">azurerm_automation_variable_bool</a>.
    /// </summary>
    type DataAzurermAutomationVariableBoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAutomationVariableBoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationVariableBoolState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermAutomationVariableBoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationVariableBoolState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_bool#automation_account_name-1">DataAzurermAutomationVariableBool#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: DataAzurermAutomationVariableBoolState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableBoolState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableBoolState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_bool#name-1">DataAzurermAutomationVariableBool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAutomationVariableBoolState<'AutomationAccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableBoolState<'AutomationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableBoolState<'AutomationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_bool#resource_group_name-1">DataAzurermAutomationVariableBool#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAutomationVariableBoolState<'AutomationAccountName, 'Name, Missing>, value: string) : DataAzurermAutomationVariableBoolState<'AutomationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableBoolState<'AutomationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_bool#id-1">DataAzurermAutomationVariableBool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_bool#timeouts-1">DataAzurermAutomationVariableBool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAutomationVariableBool.DataAzurermAutomationVariableBoolTimeouts) : DataAzurermAutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAutomationVariableBoolState<Present, Present, Present>) : azurerm.DataAzurermAutomationVariableBool.DataAzurermAutomationVariableBool =
            let config = azurerm.DataAzurermAutomationVariableBool.DataAzurermAutomationVariableBoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAutomationVariableBool.DataAzurermAutomationVariableBool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAutomationVariableBool: missing required arguments. Must call: automation_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAutomationVariableBoolState<_, _, _>) : azurerm.DataAzurermAutomationVariableBool.DataAzurermAutomationVariableBool =
            Unchecked.defaultof<azurerm.DataAzurermAutomationVariableBool.DataAzurermAutomationVariableBool>
