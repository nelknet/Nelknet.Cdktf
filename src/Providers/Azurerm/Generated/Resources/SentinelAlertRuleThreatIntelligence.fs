namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelAlertRuleThreatIntelligence.SentinelAlertRuleThreatIntelligenceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_threat_intelligence">azurerm_sentinel_alert_rule_threat_intelligence</a>.
    /// </summary>
    type SentinelAlertRuleThreatIntelligenceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelAlertRuleThreatIntelligenceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleThreatIntelligenceState<Missing, Missing, Missing>)

        member _.Zero(()) : SentinelAlertRuleThreatIntelligenceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleThreatIntelligenceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_threat_intelligence#alert_rule_template_guid-1">SentinelAlertRuleThreatIntelligence#alert_rule_template_guid</a>.
        /// </summary>
        [<CustomOperation "alert_rule_template_guid">]
        member _.AlertRuleTemplateGuid(state: SentinelAlertRuleThreatIntelligenceState<Missing, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelAlertRuleThreatIntelligenceState<Present, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.AlertRuleTemplateGuid <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleThreatIntelligenceState<Present, 'LogAnalyticsWorkspaceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_threat_intelligence#log_analytics_workspace_id-1">SentinelAlertRuleThreatIntelligence#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, Missing, 'Name>, value: string) : SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_threat_intelligence#name-1">SentinelAlertRuleThreatIntelligence#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_threat_intelligence#enabled-1">SentinelAlertRuleThreatIntelligence#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>, value: bool) : SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_threat_intelligence#enabled-1">SentinelAlertRuleThreatIntelligence#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_threat_intelligence#id-1">SentinelAlertRuleThreatIntelligence#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_threat_intelligence#timeouts-1">SentinelAlertRuleThreatIntelligence#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelAlertRuleThreatIntelligence.SentinelAlertRuleThreatIntelligenceTimeouts) : SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelAlertRuleThreatIntelligenceState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelAlertRuleThreatIntelligenceState<Present, Present, Present>) : azurerm.SentinelAlertRuleThreatIntelligence.SentinelAlertRuleThreatIntelligence =
            let config = azurerm.SentinelAlertRuleThreatIntelligence.SentinelAlertRuleThreatIntelligenceConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelAlertRuleThreatIntelligence.SentinelAlertRuleThreatIntelligence(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelAlertRuleThreatIntelligence: missing required arguments. Must call: alert_rule_template_guid, log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelAlertRuleThreatIntelligenceState<_, _, _>) : azurerm.SentinelAlertRuleThreatIntelligence.SentinelAlertRuleThreatIntelligence =
            Unchecked.defaultof<azurerm.SentinelAlertRuleThreatIntelligence.SentinelAlertRuleThreatIntelligence>
