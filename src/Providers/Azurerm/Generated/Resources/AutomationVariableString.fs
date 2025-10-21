namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomationVariableString.AutomationVariableStringConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_string">azurerm_automation_variable_string</a>.
    /// </summary>
    type AutomationVariableStringBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationVariableStringState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationVariableStringState<Missing, Missing, Missing>)

        member _.Zero(()) : AutomationVariableStringState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationVariableStringState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_string#automation_account_name-1">AutomationVariableString#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationVariableStringState<Missing, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableStringState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationVariableStringState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_string#name-1">AutomationVariableString#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationVariableStringState<'AutomationAccountName, Missing, 'ResourceGroupName>, value: string) : AutomationVariableStringState<'AutomationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationVariableStringState<'AutomationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_string#resource_group_name-1">AutomationVariableString#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationVariableStringState<'AutomationAccountName, 'Name, Missing>, value: string) : AutomationVariableStringState<'AutomationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationVariableStringState<'AutomationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_string#description-1">AutomationVariableString#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_string#encrypted-1">AutomationVariableString#encrypted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: bool) : AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_string#encrypted-1">AutomationVariableString#encrypted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_string#id-1">AutomationVariableString#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_string#timeouts-1">AutomationVariableString#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.AutomationVariableString.AutomationVariableStringTimeouts) : AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_string#value-1">AutomationVariableString#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Value <- value)
            state : AutomationVariableStringState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomationVariableStringState<Present, Present, Present>) : azurerm.AutomationVariableString.AutomationVariableString =
            let config = azurerm.AutomationVariableString.AutomationVariableStringConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationVariableString.AutomationVariableString(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationVariableString: missing required arguments. Must call: automation_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationVariableStringState<_, _, _>) : azurerm.AutomationVariableString.AutomationVariableString =
            Unchecked.defaultof<azurerm.AutomationVariableString.AutomationVariableString>
