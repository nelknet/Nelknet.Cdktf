namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelAlertRuleMachineLearningBehaviorAnalytics.SentinelAlertRuleMachineLearningBehaviorAnalyticsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics">azurerm_sentinel_alert_rule_machine_learning_behavior_analytics</a>.
    /// </summary>
    type SentinelAlertRuleMachineLearningBehaviorAnalyticsBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<Missing, Missing, Missing>)

        member _.Zero(()) : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#alert_rule_template_guid-1">SentinelAlertRuleMachineLearningBehaviorAnalytics#alert_rule_template_guid</a>.
        /// </summary>
        [<CustomOperation "alert_rule_template_guid">]
        member _.AlertRuleTemplateGuid(state: SentinelAlertRuleMachineLearningBehaviorAnalyticsState<Missing, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<Present, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.AlertRuleTemplateGuid <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<Present, 'LogAnalyticsWorkspaceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#log_analytics_workspace_id-1">SentinelAlertRuleMachineLearningBehaviorAnalytics#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, Missing, 'Name>, value: string) : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#name-1">SentinelAlertRuleMachineLearningBehaviorAnalytics#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#enabled-1">SentinelAlertRuleMachineLearningBehaviorAnalytics#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>, value: bool) : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#enabled-1">SentinelAlertRuleMachineLearningBehaviorAnalytics#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#id-1">SentinelAlertRuleMachineLearningBehaviorAnalytics#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_machine_learning_behavior_analytics#timeouts-1">SentinelAlertRuleMachineLearningBehaviorAnalytics#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelAlertRuleMachineLearningBehaviorAnalytics.SentinelAlertRuleMachineLearningBehaviorAnalyticsTimeouts) : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelAlertRuleMachineLearningBehaviorAnalyticsState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelAlertRuleMachineLearningBehaviorAnalyticsState<Present, Present, Present>) : azurerm.SentinelAlertRuleMachineLearningBehaviorAnalytics.SentinelAlertRuleMachineLearningBehaviorAnalytics =
            let config = azurerm.SentinelAlertRuleMachineLearningBehaviorAnalytics.SentinelAlertRuleMachineLearningBehaviorAnalyticsConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelAlertRuleMachineLearningBehaviorAnalytics.SentinelAlertRuleMachineLearningBehaviorAnalytics(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelAlertRuleMachineLearningBehaviorAnalytics: missing required arguments. Must call: alert_rule_template_guid, log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelAlertRuleMachineLearningBehaviorAnalyticsState<_, _, _>) : azurerm.SentinelAlertRuleMachineLearningBehaviorAnalytics.SentinelAlertRuleMachineLearningBehaviorAnalytics =
            Unchecked.defaultof<azurerm.SentinelAlertRuleMachineLearningBehaviorAnalytics.SentinelAlertRuleMachineLearningBehaviorAnalytics>
