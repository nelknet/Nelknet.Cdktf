namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order> = { assignments: ResizeArray<azurerm.SentinelAutomationRule.SentinelAutomationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule">azurerm_sentinel_automation_rule</a>.
    /// </summary>
    type SentinelAutomationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelAutomationRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAutomationRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SentinelAutomationRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAutomationRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#display_name-1">SentinelAutomationRule#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SentinelAutomationRuleState<Missing, 'LogAnalyticsWorkspaceId, 'Name, 'Order>, value: string) : SentinelAutomationRuleState<Present, 'LogAnalyticsWorkspaceId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : SentinelAutomationRuleState<Present, 'LogAnalyticsWorkspaceId, 'Name, 'Order>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#log_analytics_workspace_id-1">SentinelAutomationRule#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelAutomationRuleState<'DisplayName, Missing, 'Name, 'Order>, value: string) : SentinelAutomationRuleState<'DisplayName, Present, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelAutomationRuleState<'DisplayName, Present, 'Name, 'Order>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#name-1">SentinelAutomationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, Missing, 'Order>, value: string) : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, Present, 'Order> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, Present, 'Order>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#order-1">SentinelAutomationRule#order</a>.
        /// </summary>
        [<CustomOperation "order">]
        member _.Order(state: SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, Missing>, value: double) : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Order <- value)
            ({ assignments = state.assignments } : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, Present>)

        /// <summary>
        /// action_incident block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#action_incident-1">SentinelAutomationRule#action_incident</a> Accepts: azurerm.IResolvable | azurerm.SentinelAutomationRule.SentinelAutomationRuleActionIncident[]
        /// </summary>
        [<CustomOperation "action_incident">]
        member _.ActionIncident(state: SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>, value: HashiCorp.Cdktf.IResolvable) : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.ActionIncident <- value)
            state : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>

        /// <summary>
        /// action_playbook block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#action_playbook-1">SentinelAutomationRule#action_playbook</a> Accepts: azurerm.IResolvable | azurerm.SentinelAutomationRule.SentinelAutomationRuleActionPlaybook[]
        /// </summary>
        [<CustomOperation "action_playbook">]
        member _.ActionPlaybook(state: SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>, value: HashiCorp.Cdktf.IResolvable) : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.ActionPlaybook <- value)
            state : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#condition_json-1">SentinelAutomationRule#condition_json</a>.
        /// </summary>
        [<CustomOperation "condition_json">]
        member _.ConditionJson(state: SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>, value: string) : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.ConditionJson <- value)
            state : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#enabled-1">SentinelAutomationRule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>, value: bool) : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#enabled-1">SentinelAutomationRule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>, value: HashiCorp.Cdktf.IResolvable) : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#expiration-1">SentinelAutomationRule#expiration</a>.
        /// </summary>
        [<CustomOperation "expiration">]
        member _.Expiration(state: SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>, value: string) : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.Expiration <- value)
            state : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#id-1">SentinelAutomationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>, value: string) : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#timeouts-1">SentinelAutomationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>, value: azurerm.SentinelAutomationRule.SentinelAutomationRuleTimeouts) : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#triggers_on-1">SentinelAutomationRule#triggers_on</a>.
        /// </summary>
        [<CustomOperation "triggers_on">]
        member _.TriggersOn(state: SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>, value: string) : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.TriggersOn <- value)
            state : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_automation_rule#triggers_when-1">SentinelAutomationRule#triggers_when</a>.
        /// </summary>
        [<CustomOperation "triggers_when">]
        member _.TriggersWhen(state: SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>, value: string) : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.TriggersWhen <- value)
            state : SentinelAutomationRuleState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Order>

        member _.Run(state: SentinelAutomationRuleState<Present, Present, Present, Present>) : azurerm.SentinelAutomationRule.SentinelAutomationRule =
            let config = azurerm.SentinelAutomationRule.SentinelAutomationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelAutomationRule.SentinelAutomationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelAutomationRule: missing required arguments. Must call: display_name, log_analytics_workspace_id, name, order.", 9999, IsError = true)>]
        member _.Run(_: SentinelAutomationRuleState<_, _, _, _>) : azurerm.SentinelAutomationRule.SentinelAutomationRule =
            Unchecked.defaultof<azurerm.SentinelAutomationRule.SentinelAutomationRule>
