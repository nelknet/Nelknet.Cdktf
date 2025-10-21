namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelAlertRuleFusion.SentinelAlertRuleFusionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_fusion">azurerm_sentinel_alert_rule_fusion</a>.
    /// </summary>
    type SentinelAlertRuleFusionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelAlertRuleFusionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleFusionState<Missing, Missing, Missing>)

        member _.Zero(()) : SentinelAlertRuleFusionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleFusionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_fusion#alert_rule_template_guid-1">SentinelAlertRuleFusion#alert_rule_template_guid</a>.
        /// </summary>
        [<CustomOperation "alert_rule_template_guid">]
        member _.AlertRuleTemplateGuid(state: SentinelAlertRuleFusionState<Missing, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelAlertRuleFusionState<Present, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.AlertRuleTemplateGuid <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleFusionState<Present, 'LogAnalyticsWorkspaceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_fusion#log_analytics_workspace_id-1">SentinelAlertRuleFusion#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, Missing, 'Name>, value: string) : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_fusion#name-1">SentinelAlertRuleFusion#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_fusion#enabled-1">SentinelAlertRuleFusion#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>, value: bool) : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_fusion#enabled-1">SentinelAlertRuleFusion#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_fusion#id-1">SentinelAlertRuleFusion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_fusion#source-1">SentinelAlertRuleFusion#source</a> Accepts: azurerm.IResolvable | azurerm.SentinelAlertRuleFusion.SentinelAlertRuleFusionSource[]
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Source <- value)
            state : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_fusion#timeouts-1">SentinelAlertRuleFusion#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelAlertRuleFusion.SentinelAlertRuleFusionTimeouts) : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelAlertRuleFusionState<'AlertRuleTemplateGuid, 'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelAlertRuleFusionState<Present, Present, Present>) : azurerm.SentinelAlertRuleFusion.SentinelAlertRuleFusion =
            let config = azurerm.SentinelAlertRuleFusion.SentinelAlertRuleFusionConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelAlertRuleFusion.SentinelAlertRuleFusion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelAlertRuleFusion: missing required arguments. Must call: alert_rule_template_guid, log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelAlertRuleFusionState<_, _, _>) : azurerm.SentinelAlertRuleFusion.SentinelAlertRuleFusion =
            Unchecked.defaultof<azurerm.SentinelAlertRuleFusion.SentinelAlertRuleFusion>
