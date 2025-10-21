namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName> = { assignments: ResizeArray<azurerm.AutomationWebhook.AutomationWebhookConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_webhook">azurerm_automation_webhook</a>.
    /// </summary>
    type AutomationWebhookBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationWebhookState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationWebhookState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationWebhookState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationWebhookState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_webhook#automation_account_name-1">AutomationWebhook#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationWebhookState<Missing, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>, value: string) : AutomationWebhookState<Present, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationWebhookState<Present, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_webhook#expiry_time-1">AutomationWebhook#expiry_time</a>.
        /// </summary>
        [<CustomOperation "expiry_time">]
        member _.ExpiryTime(state: AutomationWebhookState<'AutomationAccountName, Missing, 'Name, 'ResourceGroupName, 'RunbookName>, value: string) : AutomationWebhookState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName, 'RunbookName> =
            state.assignments.Add(fun config -> config.ExpiryTime <- value)
            ({ assignments = state.assignments } : AutomationWebhookState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName, 'RunbookName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_webhook#name-1">AutomationWebhook#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, Missing, 'ResourceGroupName, 'RunbookName>, value: string) : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, Present, 'ResourceGroupName, 'RunbookName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, Present, 'ResourceGroupName, 'RunbookName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_webhook#resource_group_name-1">AutomationWebhook#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, Missing, 'RunbookName>, value: string) : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, Present, 'RunbookName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, Present, 'RunbookName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_webhook#runbook_name-1">AutomationWebhook#runbook_name</a>.
        /// </summary>
        [<CustomOperation "runbook_name">]
        member _.RunbookName(state: AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, Missing>, value: string) : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.RunbookName <- value)
            ({ assignments = state.assignments } : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_webhook#enabled-1">AutomationWebhook#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>, value: bool) : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_webhook#enabled-1">AutomationWebhook#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>, value: HashiCorp.Cdktf.IResolvable) : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_webhook#id-1">AutomationWebhook#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>, value: string) : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_webhook#parameters-1">AutomationWebhook#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>, value: seq<string * string>) : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_webhook#run_on_worker_group-1">AutomationWebhook#run_on_worker_group</a>.
        /// </summary>
        [<CustomOperation "run_on_worker_group">]
        member _.RunOnWorkerGroup(state: AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>, value: string) : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName> =
            state.assignments.Add(fun config -> config.RunOnWorkerGroup <- value)
            state : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_webhook#timeouts-1">AutomationWebhook#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>, value: azurerm.AutomationWebhook.AutomationWebhookTimeouts) : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_webhook#uri-1">AutomationWebhook#uri</a>.
        /// </summary>
        [<CustomOperation "uri">]
        member _.Uri(state: AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>, value: string) : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName> =
            state.assignments.Add(fun config -> config.Uri <- value)
            state : AutomationWebhookState<'AutomationAccountName, 'ExpiryTime, 'Name, 'ResourceGroupName, 'RunbookName>

        member _.Run(state: AutomationWebhookState<Present, Present, Present, Present, Present>) : azurerm.AutomationWebhook.AutomationWebhook =
            let config = azurerm.AutomationWebhook.AutomationWebhookConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationWebhook.AutomationWebhook(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationWebhook: missing required arguments. Must call: automation_account_name, expiry_time, name, resource_group_name, runbook_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationWebhookState<_, _, _, _, _>) : azurerm.AutomationWebhook.AutomationWebhook =
            Unchecked.defaultof<azurerm.AutomationWebhook.AutomationWebhook>
