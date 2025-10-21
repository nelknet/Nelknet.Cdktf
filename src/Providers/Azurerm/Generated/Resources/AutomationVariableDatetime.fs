namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomationVariableDatetime.AutomationVariableDatetimeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_datetime">azurerm_automation_variable_datetime</a>.
    /// </summary>
    type AutomationVariableDatetimeBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationVariableDatetimeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationVariableDatetimeState<Missing, Missing, Missing>)

        member _.Zero(()) : AutomationVariableDatetimeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationVariableDatetimeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_datetime#automation_account_name-1">AutomationVariableDatetime#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationVariableDatetimeState<Missing, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableDatetimeState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationVariableDatetimeState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_datetime#name-1">AutomationVariableDatetime#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationVariableDatetimeState<'AutomationAccountName, Missing, 'ResourceGroupName>, value: string) : AutomationVariableDatetimeState<'AutomationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationVariableDatetimeState<'AutomationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_datetime#resource_group_name-1">AutomationVariableDatetime#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationVariableDatetimeState<'AutomationAccountName, 'Name, Missing>, value: string) : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_datetime#description-1">AutomationVariableDatetime#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_datetime#encrypted-1">AutomationVariableDatetime#encrypted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: bool) : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_datetime#encrypted-1">AutomationVariableDatetime#encrypted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_datetime#id-1">AutomationVariableDatetime#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_datetime#timeouts-1">AutomationVariableDatetime#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.AutomationVariableDatetime.AutomationVariableDatetimeTimeouts) : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_variable_datetime#value-1">AutomationVariableDatetime#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>, value: string) : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Value <- value)
            state : AutomationVariableDatetimeState<'AutomationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomationVariableDatetimeState<Present, Present, Present>) : azurerm.AutomationVariableDatetime.AutomationVariableDatetime =
            let config = azurerm.AutomationVariableDatetime.AutomationVariableDatetimeConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationVariableDatetime.AutomationVariableDatetime(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationVariableDatetime: missing required arguments. Must call: automation_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationVariableDatetimeState<_, _, _>) : azurerm.AutomationVariableDatetime.AutomationVariableDatetime =
            Unchecked.defaultof<azurerm.AutomationVariableDatetime.AutomationVariableDatetime>
