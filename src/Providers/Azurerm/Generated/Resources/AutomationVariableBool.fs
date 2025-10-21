namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomationVariableBool.AutomationVariableBoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_bool">azurerm_automation_variable_bool</a>.
    /// </summary>
    type AutomationVariableBoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationVariableBoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationVariableBoolState<Missing, Missing, Missing>)

        member _.Zero(()) : AutomationVariableBoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationVariableBoolState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_bool#automation_account_name-1">AutomationVariableBool#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationVariableBoolState<Missing, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableBoolState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationVariableBoolState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_bool#name-1">AutomationVariableBool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationVariableBoolState<'AutomationAccountName, Missing, 'ResourceGroupName>, value: string) : AutomationVariableBoolState<'AutomationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationVariableBoolState<'AutomationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_bool#resource_group_name-1">AutomationVariableBool#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationVariableBoolState<'AutomationAccountName, 'Name, Missing>, value: string) : AutomationVariableBoolState<'AutomationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationVariableBoolState<'AutomationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_bool#description-1">AutomationVariableBool#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_bool#encrypted-1">AutomationVariableBool#encrypted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: bool) : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_bool#encrypted-1">AutomationVariableBool#encrypted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_bool#id-1">AutomationVariableBool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_bool#timeouts-1">AutomationVariableBool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.AutomationVariableBool.AutomationVariableBoolTimeouts) : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_bool#value-1">AutomationVariableBool#value</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: bool) : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Value <- value)
            state : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_bool#value-1">AutomationVariableBool#value</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Value <- value)
            state : AutomationVariableBoolState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomationVariableBoolState<Present, Present, Present>) : azurerm.AutomationVariableBool.AutomationVariableBool =
            let config = azurerm.AutomationVariableBool.AutomationVariableBoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationVariableBool.AutomationVariableBool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationVariableBool: missing required arguments. Must call: automation_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationVariableBoolState<_, _, _>) : azurerm.AutomationVariableBool.AutomationVariableBool =
            Unchecked.defaultof<azurerm.AutomationVariableBool.AutomationVariableBool>
