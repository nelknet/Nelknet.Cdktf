namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAutomationVariableObject.DataAzurermAutomationVariableObjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_object">azurerm_automation_variable_object</a>.
    /// </summary>
    type DataAzurermAutomationVariableObjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAutomationVariableObjectState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationVariableObjectState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermAutomationVariableObjectState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationVariableObjectState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_object#automation_account_name-1">DataAzurermAutomationVariableObject#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: DataAzurermAutomationVariableObjectState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableObjectState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableObjectState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_object#name-1">DataAzurermAutomationVariableObject#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAutomationVariableObjectState<'AutomationAccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableObjectState<'AutomationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableObjectState<'AutomationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_object#resource_group_name-1">DataAzurermAutomationVariableObject#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAutomationVariableObjectState<'AutomationAccountName, 'Name, Missing>, value: string) : DataAzurermAutomationVariableObjectState<'AutomationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationVariableObjectState<'AutomationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_object#id-1">DataAzurermAutomationVariableObject#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermAutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_object#timeouts-1">DataAzurermAutomationVariableObject#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAutomationVariableObject.DataAzurermAutomationVariableObjectTimeouts) : DataAzurermAutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAutomationVariableObjectState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAutomationVariableObjectState<Present, Present, Present>) : azurerm.DataAzurermAutomationVariableObject.DataAzurermAutomationVariableObject =
            let config = azurerm.DataAzurermAutomationVariableObject.DataAzurermAutomationVariableObjectConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAutomationVariableObject.DataAzurermAutomationVariableObject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAutomationVariableObject: missing required arguments. Must call: automation_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAutomationVariableObjectState<_, _, _>) : azurerm.DataAzurermAutomationVariableObject.DataAzurermAutomationVariableObject =
            Unchecked.defaultof<azurerm.DataAzurermAutomationVariableObject.DataAzurermAutomationVariableObject>
