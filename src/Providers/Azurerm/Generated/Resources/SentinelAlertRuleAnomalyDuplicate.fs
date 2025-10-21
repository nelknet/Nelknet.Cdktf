namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> = { assignments: ResizeArray<azurerm.SentinelAlertRuleAnomalyDuplicate.SentinelAlertRuleAnomalyDuplicateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_duplicate">azurerm_sentinel_alert_rule_anomaly_duplicate</a>.
    /// </summary>
    type SentinelAlertRuleAnomalyDuplicateBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelAlertRuleAnomalyDuplicateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleAnomalyDuplicateState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SentinelAlertRuleAnomalyDuplicateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleAnomalyDuplicateState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_duplicate#built_in_rule_id-1">SentinelAlertRuleAnomalyDuplicate#built_in_rule_id</a>.
        /// </summary>
        [<CustomOperation "built_in_rule_id">]
        member _.BuiltInRuleId(state: SentinelAlertRuleAnomalyDuplicateState<Missing, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>, value: string) : SentinelAlertRuleAnomalyDuplicateState<Present, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.BuiltInRuleId <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleAnomalyDuplicateState<Present, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_duplicate#display_name-1">SentinelAlertRuleAnomalyDuplicate#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, Missing, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>, value: string) : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, Present, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, Present, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_duplicate#enabled-1">SentinelAlertRuleAnomalyDuplicate#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, Missing, 'LogAnalyticsWorkspaceId, 'Mode>, value: bool) : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, Present, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, Present, 'LogAnalyticsWorkspaceId, 'Mode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_duplicate#enabled-1">SentinelAlertRuleAnomalyDuplicate#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, Missing, 'LogAnalyticsWorkspaceId, 'Mode>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, Present, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, Present, 'LogAnalyticsWorkspaceId, 'Mode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_duplicate#log_analytics_workspace_id-1">SentinelAlertRuleAnomalyDuplicate#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, Missing, 'Mode>, value: string) : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, Present, 'Mode> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, Present, 'Mode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_duplicate#mode-1">SentinelAlertRuleAnomalyDuplicate#mode</a>.
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Mode <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_duplicate#id-1">SentinelAlertRuleAnomalyDuplicate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>, value: string) : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>

        /// <summary>
        /// multi_select_observation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_duplicate#multi_select_observation-1">SentinelAlertRuleAnomalyDuplicate#multi_select_observation</a> Accepts: azurerm.IResolvable | azurerm.SentinelAlertRuleAnomalyDuplicate.SentinelAlertRuleAnomalyDuplicateMultiSelectObservation[]
        /// </summary>
        [<CustomOperation "multi_select_observation">]
        member _.MultiSelectObservation(state: SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.MultiSelectObservation <- value)
            state : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>

        /// <summary>
        /// prioritized_exclude_observation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_duplicate#prioritized_exclude_observation-1">SentinelAlertRuleAnomalyDuplicate#prioritized_exclude_observation</a> Accepts: azurerm.IResolvable | azurerm.SentinelAlertRuleAnomalyDuplicate.SentinelAlertRuleAnomalyDuplicatePrioritizedExcludeObservation[]
        /// </summary>
        [<CustomOperation "prioritized_exclude_observation">]
        member _.PrioritizedExcludeObservation(state: SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.PrioritizedExcludeObservation <- value)
            state : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>

        /// <summary>
        /// single_select_observation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_duplicate#single_select_observation-1">SentinelAlertRuleAnomalyDuplicate#single_select_observation</a> Accepts: azurerm.IResolvable | azurerm.SentinelAlertRuleAnomalyDuplicate.SentinelAlertRuleAnomalyDuplicateSingleSelectObservation[]
        /// </summary>
        [<CustomOperation "single_select_observation">]
        member _.SingleSelectObservation(state: SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.SingleSelectObservation <- value)
            state : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>

        /// <summary>
        /// threshold_observation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_duplicate#threshold_observation-1">SentinelAlertRuleAnomalyDuplicate#threshold_observation</a> Accepts: azurerm.IResolvable | azurerm.SentinelAlertRuleAnomalyDuplicate.SentinelAlertRuleAnomalyDuplicateThresholdObservation[]
        /// </summary>
        [<CustomOperation "threshold_observation">]
        member _.ThresholdObservation(state: SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.ThresholdObservation <- value)
            state : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_duplicate#timeouts-1">SentinelAlertRuleAnomalyDuplicate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>, value: azurerm.SentinelAlertRuleAnomalyDuplicate.SentinelAlertRuleAnomalyDuplicateTimeouts) : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelAlertRuleAnomalyDuplicateState<'BuiltInRuleId, 'DisplayName, 'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>

        member _.Run(state: SentinelAlertRuleAnomalyDuplicateState<Present, Present, Present, Present, Present>) : azurerm.SentinelAlertRuleAnomalyDuplicate.SentinelAlertRuleAnomalyDuplicate =
            let config = azurerm.SentinelAlertRuleAnomalyDuplicate.SentinelAlertRuleAnomalyDuplicateConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelAlertRuleAnomalyDuplicate.SentinelAlertRuleAnomalyDuplicate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelAlertRuleAnomalyDuplicate: missing required arguments. Must call: built_in_rule_id, display_name, enabled, log_analytics_workspace_id, mode.", 9999, IsError = true)>]
        member _.Run(_: SentinelAlertRuleAnomalyDuplicateState<_, _, _, _, _>) : azurerm.SentinelAlertRuleAnomalyDuplicate.SentinelAlertRuleAnomalyDuplicate =
            Unchecked.defaultof<azurerm.SentinelAlertRuleAnomalyDuplicate.SentinelAlertRuleAnomalyDuplicate>
