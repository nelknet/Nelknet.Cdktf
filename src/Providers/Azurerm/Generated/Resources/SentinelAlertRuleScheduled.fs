namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> = { assignments: ResizeArray<azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduledConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled">azurerm_sentinel_alert_rule_scheduled</a>.
    /// </summary>
    type SentinelAlertRuleScheduledBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelAlertRuleScheduledState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleScheduledState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SentinelAlertRuleScheduledState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleScheduledState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#display_name-1">SentinelAlertRuleScheduled#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SentinelAlertRuleScheduledState<Missing, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleScheduledState<Present, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleScheduledState<Present, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#log_analytics_workspace_id-1">SentinelAlertRuleScheduled#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelAlertRuleScheduledState<'DisplayName, Missing, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleScheduledState<'DisplayName, Present, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleScheduledState<'DisplayName, Present, 'Name, 'Query, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#name-1">SentinelAlertRuleScheduled#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, Missing, 'Query, 'Severity>, value: string) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, Present, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, Present, 'Query, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#query-1">SentinelAlertRuleScheduled#query</a>.
        /// </summary>
        [<CustomOperation "query">]
        member _.Query(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, Missing, 'Severity>, value: string) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, Present, 'Severity> =
            state.assignments.Add(fun config -> config.Query <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, Present, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#severity-1">SentinelAlertRuleScheduled#severity</a>.
        /// </summary>
        [<CustomOperation "severity">]
        member _.Severity(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, Missing>, value: string) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, Present> =
            state.assignments.Add(fun config -> config.Severity <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, Present>)

        /// <summary>
        /// alert_details_override block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#alert_details_override-1">SentinelAlertRuleScheduled#alert_details_override</a> Accepts: azurerm.IResolvable | azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduledAlertDetailsOverride[]
        /// </summary>
        [<CustomOperation "alert_details_override">]
        member _.AlertDetailsOverride(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.AlertDetailsOverride <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#alert_rule_template_guid-1">SentinelAlertRuleScheduled#alert_rule_template_guid</a>.
        /// </summary>
        [<CustomOperation "alert_rule_template_guid">]
        member _.AlertRuleTemplateGuid(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.AlertRuleTemplateGuid <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#alert_rule_template_version-1">SentinelAlertRuleScheduled#alert_rule_template_version</a>.
        /// </summary>
        [<CustomOperation "alert_rule_template_version">]
        member _.AlertRuleTemplateVersion(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.AlertRuleTemplateVersion <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#custom_details-1">SentinelAlertRuleScheduled#custom_details</a>.
        /// </summary>
        [<CustomOperation "custom_details">]
        member _.CustomDetails(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: seq<string * string>) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.CustomDetails <- dict value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#description-1">SentinelAlertRuleScheduled#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#enabled-1">SentinelAlertRuleScheduled#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: bool) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#enabled-1">SentinelAlertRuleScheduled#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// entity_mapping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#entity_mapping-1">SentinelAlertRuleScheduled#entity_mapping</a> Accepts: azurerm.IResolvable | azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduledEntityMapping[]
        /// </summary>
        [<CustomOperation "entity_mapping">]
        member _.EntityMapping(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.EntityMapping <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// event_grouping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#event_grouping-1">SentinelAlertRuleScheduled#event_grouping</a>
        /// </summary>
        [<CustomOperation "event_grouping">]
        member _.EventGrouping(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduledEventGrouping) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.EventGrouping <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#id-1">SentinelAlertRuleScheduled#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// incident block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#incident-1">SentinelAlertRuleScheduled#incident</a>
        /// </summary>
        [<CustomOperation "incident">]
        member _.Incident(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncident) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Incident <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#query_frequency-1">SentinelAlertRuleScheduled#query_frequency</a>.
        /// </summary>
        [<CustomOperation "query_frequency">]
        member _.QueryFrequency(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.QueryFrequency <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#query_period-1">SentinelAlertRuleScheduled#query_period</a>.
        /// </summary>
        [<CustomOperation "query_period">]
        member _.QueryPeriod(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.QueryPeriod <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// sentinel_entity_mapping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#sentinel_entity_mapping-1">SentinelAlertRuleScheduled#sentinel_entity_mapping</a> Accepts: azurerm.IResolvable | azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduledSentinelEntityMapping[]
        /// </summary>
        [<CustomOperation "sentinel_entity_mapping">]
        member _.SentinelEntityMapping(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.SentinelEntityMapping <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#suppression_duration-1">SentinelAlertRuleScheduled#suppression_duration</a>.
        /// </summary>
        [<CustomOperation "suppression_duration">]
        member _.SuppressionDuration(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.SuppressionDuration <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#suppression_enabled-1">SentinelAlertRuleScheduled#suppression_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "suppression_enabled">]
        member _.SuppressionEnabled(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: bool) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.SuppressionEnabled <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#suppression_enabled-1">SentinelAlertRuleScheduled#suppression_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "suppression_enabled">]
        member _.SuppressionEnabled(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.SuppressionEnabled <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#tactics-1">SentinelAlertRuleScheduled#tactics</a>.
        /// </summary>
        [<CustomOperation "tactics">]
        member _.Tactics(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: seq<string>) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Tactics <- (value |> Seq.toArray))
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#techniques-1">SentinelAlertRuleScheduled#techniques</a>.
        /// </summary>
        [<CustomOperation "techniques">]
        member _.Techniques(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: seq<string>) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Techniques <- (value |> Seq.toArray))
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#timeouts-1">SentinelAlertRuleScheduled#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduledTimeouts) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#trigger_operator-1">SentinelAlertRuleScheduled#trigger_operator</a>.
        /// </summary>
        [<CustomOperation "trigger_operator">]
        member _.TriggerOperator(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.TriggerOperator <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#trigger_threshold-1">SentinelAlertRuleScheduled#trigger_threshold</a>.
        /// </summary>
        [<CustomOperation "trigger_threshold">]
        member _.TriggerThreshold(state: SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: double) : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.TriggerThreshold <- value)
            state : SentinelAlertRuleScheduledState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        member _.Run(state: SentinelAlertRuleScheduledState<Present, Present, Present, Present, Present>) : azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduled =
            let config = azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduledConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduled(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelAlertRuleScheduled: missing required arguments. Must call: display_name, log_analytics_workspace_id, name, query, severity.", 9999, IsError = true)>]
        member _.Run(_: SentinelAlertRuleScheduledState<_, _, _, _, _>) : azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduled =
            Unchecked.defaultof<azurerm.SentinelAlertRuleScheduled.SentinelAlertRuleScheduled>
