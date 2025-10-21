namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAutomationVariableDatetime.DataAzurermAutomationVariableDatetimeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_datetime">azurerm_automation_variable_datetime</a>.
    /// </summary>
    type DataAzurermAutomationVariableDatetimeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAutomationVariableDatetimeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationVariableDatetimeState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermAutomationVariableDatetimeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationVariableDatetimeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_datetime#automation_account_name-1">DataAzurermAutomationVariableDatetime#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: DataAzurermAutomationVariableDatetimeState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableDatetimeState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableDatetimeState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_datetime#name-1">DataAzurermAutomationVariableDatetime#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAutomationVariableDatetimeState<'AutomationAccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableDatetimeState<'AutomationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableDatetimeState<'AutomationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_datetime#resource_group_name-1">DataAzurermAutomationVariableDatetime#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAutomationVariableDatetimeState<'AutomationAccountName, 'Name, Missing>, value: string) : DataAzurermAutomationVariableDatetimeState<'AutomationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableDatetimeState<'AutomationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_datetime#id-1">DataAzurermAutomationVariableDatetime#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_datetime#timeouts-1">DataAzurermAutomationVariableDatetime#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAutomationVariableDatetime.DataAzurermAutomationVariableDatetimeTimeouts) : DataAzurermAutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAutomationVariableDatetimeState<Present, Present, Present>) : azurerm.DataAzurermAutomationVariableDatetime.DataAzurermAutomationVariableDatetime =
            let config = azurerm.DataAzurermAutomationVariableDatetime.DataAzurermAutomationVariableDatetimeConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAutomationVariableDatetime.DataAzurermAutomationVariableDatetime(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAutomationVariableDatetime: missing required arguments. Must call: automation_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAutomationVariableDatetimeState<_, _, _>) : azurerm.DataAzurermAutomationVariableDatetime.DataAzurermAutomationVariableDatetime =
            Unchecked.defaultof<azurerm.DataAzurermAutomationVariableDatetime.DataAzurermAutomationVariableDatetime>
