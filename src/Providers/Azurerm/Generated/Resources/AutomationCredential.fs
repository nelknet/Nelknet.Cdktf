namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, 'ResourceGroupName, 'Username> = { assignments: ResizeArray<azurerm.AutomationCredential.AutomationCredentialConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_credential">azurerm_automation_credential</a>.
    /// </summary>
    type AutomationCredentialBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationCredentialState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationCredentialState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationCredentialState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationCredentialState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_credential#automation_account_name-1">AutomationCredential#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationCredentialState<Missing, 'Name, 'Password, 'ResourceGroupName, 'Username>, value: string) : AutomationCredentialState<Present, 'Name, 'Password, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationCredentialState<Present, 'Name, 'Password, 'ResourceGroupName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_credential#name-1">AutomationCredential#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationCredentialState<'AutomationAccountName, Missing, 'Password, 'ResourceGroupName, 'Username>, value: string) : AutomationCredentialState<'AutomationAccountName, Present, 'Password, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationCredentialState<'AutomationAccountName, Present, 'Password, 'ResourceGroupName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_credential#password-1">AutomationCredential#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: AutomationCredentialState<'AutomationAccountName, 'Name, Missing, 'ResourceGroupName, 'Username>, value: string) : AutomationCredentialState<'AutomationAccountName, 'Name, Present, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : AutomationCredentialState<'AutomationAccountName, 'Name, Present, 'ResourceGroupName, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_credential#resource_group_name-1">AutomationCredential#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, Missing, 'Username>, value: string) : AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, Present, 'Username> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, Present, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_credential#username-1">AutomationCredential#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, 'ResourceGroupName, Missing>, value: string) : AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_credential#description-1">AutomationCredential#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, 'ResourceGroupName, 'Username>, value: string) : AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, 'ResourceGroupName, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_credential#id-1">AutomationCredential#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, 'ResourceGroupName, 'Username>, value: string) : AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, 'ResourceGroupName, 'Username>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_credential#timeouts-1">AutomationCredential#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, 'ResourceGroupName, 'Username>, value: azurerm.AutomationCredential.AutomationCredentialTimeouts) : AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, 'ResourceGroupName, 'Username> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationCredentialState<'AutomationAccountName, 'Name, 'Password, 'ResourceGroupName, 'Username>

        member _.Run(state: AutomationCredentialState<Present, Present, Present, Present, Present>) : azurerm.AutomationCredential.AutomationCredential =
            let config = azurerm.AutomationCredential.AutomationCredentialConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationCredential.AutomationCredential(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationCredential: missing required arguments. Must call: automation_account_name, name, password, resource_group_name, username.", 9999, IsError = true)>]
        member _.Run(_: AutomationCredentialState<_, _, _, _, _>) : azurerm.AutomationCredential.AutomationCredential =
            Unchecked.defaultof<azurerm.AutomationCredential.AutomationCredential>
