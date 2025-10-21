namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomationVariableInt.AutomationVariableIntConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_int">azurerm_automation_variable_int</a>.
    /// </summary>
    type AutomationVariableIntBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationVariableIntState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationVariableIntState<Missing, Missing, Missing>)

        member _.Zero(()) : AutomationVariableIntState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationVariableIntState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_int#automation_account_name-1">AutomationVariableInt#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationVariableIntState<Missing, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableIntState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationVariableIntState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_int#name-1">AutomationVariableInt#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationVariableIntState<'AutomationAccountName, Missing, 'ResourceGroupName>, value: string) : AutomationVariableIntState<'AutomationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationVariableIntState<'AutomationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_int#resource_group_name-1">AutomationVariableInt#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationVariableIntState<'AutomationAccountName, 'Name, Missing>, value: string) : AutomationVariableIntState<'AutomationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationVariableIntState<'AutomationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_int#description-1">AutomationVariableInt#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_int#encrypted-1">AutomationVariableInt#encrypted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: bool) : AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_int#encrypted-1">AutomationVariableInt#encrypted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_int#id-1">AutomationVariableInt#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_int#timeouts-1">AutomationVariableInt#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.AutomationVariableInt.AutomationVariableIntTimeouts) : AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_int#value-1">AutomationVariableInt#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: double) : AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Value <- value)
            state : AutomationVariableIntState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomationVariableIntState<Present, Present, Present>) : azurerm.AutomationVariableInt.AutomationVariableInt =
            let config = azurerm.AutomationVariableInt.AutomationVariableIntConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationVariableInt.AutomationVariableInt(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationVariableInt: missing required arguments. Must call: automation_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationVariableIntState<_, _, _>) : azurerm.AutomationVariableInt.AutomationVariableInt =
            Unchecked.defaultof<azurerm.AutomationVariableInt.AutomationVariableInt>
