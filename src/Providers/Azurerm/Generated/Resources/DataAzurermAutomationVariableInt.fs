namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAutomationVariableInt.DataAzurermAutomationVariableIntConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_int">azurerm_automation_variable_int</a>.
    /// </summary>
    type DataAzurermAutomationVariableIntBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAutomationVariableIntState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationVariableIntState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermAutomationVariableIntState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationVariableIntState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_int#automation_account_name-1">DataAzurermAutomationVariableInt#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: DataAzurermAutomationVariableIntState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableIntState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableIntState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_int#name-1">DataAzurermAutomationVariableInt#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAutomationVariableIntState<'AutomationAccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableIntState<'AutomationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableIntState<'AutomationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_int#resource_group_name-1">DataAzurermAutomationVariableInt#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAutomationVariableIntState<'AutomationAccountName, 'Name, Missing>, value: string) : DataAzurermAutomationVariableIntState<'AutomationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableIntState<'AutomationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_int#id-1">DataAzurermAutomationVariableInt#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_int#timeouts-1">DataAzurermAutomationVariableInt#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAutomationVariableInt.DataAzurermAutomationVariableIntTimeouts) : DataAzurermAutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAutomationVariableIntState<Present, Present, Present>) : azurerm.DataAzurermAutomationVariableInt.DataAzurermAutomationVariableInt =
            let config = azurerm.DataAzurermAutomationVariableInt.DataAzurermAutomationVariableIntConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAutomationVariableInt.DataAzurermAutomationVariableInt(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAutomationVariableInt: missing required arguments. Must call: automation_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAutomationVariableIntState<_, _, _>) : azurerm.DataAzurermAutomationVariableInt.DataAzurermAutomationVariableInt =
            Unchecked.defaultof<azurerm.DataAzurermAutomationVariableInt.DataAzurermAutomationVariableInt>
