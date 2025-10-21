namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> = { assignments: ResizeArray<azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrtConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt">azurerm_sentinel_alert_rule_nrt</a>.
    /// </summary>
    type SentinelAlertRuleNrtBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelAlertRuleNrtState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleNrtState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SentinelAlertRuleNrtState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleNrtState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#display_name-1">SentinelAlertRuleNrt#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SentinelAlertRuleNrtState<Missing, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleNrtState<Present, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleNrtState<Present, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>)

        /// <summary>
        /// event_grouping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#event_grouping-1">SentinelAlertRuleNrt#event_grouping</a>
        /// </summary>
        [<CustomOperation "event_grouping">]
        member _.EventGrouping(state: SentinelAlertRuleNrtState<'DisplayName, Missing, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrtEventGrouping) : SentinelAlertRuleNrtState<'DisplayName, Present, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.EventGrouping <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleNrtState<'DisplayName, Present, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#log_analytics_workspace_id-1">SentinelAlertRuleNrt#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, Missing, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, Present, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, Present, 'Name, 'Query, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#name-1">SentinelAlertRuleNrt#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, Missing, 'Query, 'Severity>, value: string) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, Present, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, Present, 'Query, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#query-1">SentinelAlertRuleNrt#query</a>.
        /// </summary>
        [<CustomOperation "query">]
        member _.Query(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, Missing, 'Severity>, value: string) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, Present, 'Severity> =
            state.assignments.Add(fun config -> config.Query <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, Present, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#severity-1">SentinelAlertRuleNrt#severity</a>.
        /// </summary>
        [<CustomOperation "severity">]
        member _.Severity(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, Missing>, value: string) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, Present> =
            state.assignments.Add(fun config -> config.Severity <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, Present>)

        /// <summary>
        /// alert_details_override block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#alert_details_override-1">SentinelAlertRuleNrt#alert_details_override</a> Accepts: azurerm.IResolvable | azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrtAlertDetailsOverride[]
        /// </summary>
        [<CustomOperation "alert_details_override">]
        member _.AlertDetailsOverride(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.AlertDetailsOverride <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#alert_rule_template_guid-1">SentinelAlertRuleNrt#alert_rule_template_guid</a>.
        /// </summary>
        [<CustomOperation "alert_rule_template_guid">]
        member _.AlertRuleTemplateGuid(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.AlertRuleTemplateGuid <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#alert_rule_template_version-1">SentinelAlertRuleNrt#alert_rule_template_version</a>.
        /// </summary>
        [<CustomOperation "alert_rule_template_version">]
        member _.AlertRuleTemplateVersion(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.AlertRuleTemplateVersion <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#custom_details-1">SentinelAlertRuleNrt#custom_details</a>.
        /// </summary>
        [<CustomOperation "custom_details">]
        member _.CustomDetails(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: seq<string * string>) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.CustomDetails <- dict value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#description-1">SentinelAlertRuleNrt#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#enabled-1">SentinelAlertRuleNrt#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: bool) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#enabled-1">SentinelAlertRuleNrt#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// entity_mapping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#entity_mapping-1">SentinelAlertRuleNrt#entity_mapping</a> Accepts: azurerm.IResolvable | azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrtEntityMapping[]
        /// </summary>
        [<CustomOperation "entity_mapping">]
        member _.EntityMapping(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.EntityMapping <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#id-1">SentinelAlertRuleNrt#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// incident block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#incident-1">SentinelAlertRuleNrt#incident</a>
        /// </summary>
        [<CustomOperation "incident">]
        member _.Incident(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrtIncident) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Incident <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// sentinel_entity_mapping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#sentinel_entity_mapping-1">SentinelAlertRuleNrt#sentinel_entity_mapping</a> Accepts: azurerm.IResolvable | azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrtSentinelEntityMapping[]
        /// </summary>
        [<CustomOperation "sentinel_entity_mapping">]
        member _.SentinelEntityMapping(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.SentinelEntityMapping <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#suppression_duration-1">SentinelAlertRuleNrt#suppression_duration</a>.
        /// </summary>
        [<CustomOperation "suppression_duration">]
        member _.SuppressionDuration(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: string) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.SuppressionDuration <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#suppression_enabled-1">SentinelAlertRuleNrt#suppression_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "suppression_enabled">]
        member _.SuppressionEnabled(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: bool) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.SuppressionEnabled <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#suppression_enabled-1">SentinelAlertRuleNrt#suppression_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "suppression_enabled">]
        member _.SuppressionEnabled(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.SuppressionEnabled <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#tactics-1">SentinelAlertRuleNrt#tactics</a>.
        /// </summary>
        [<CustomOperation "tactics">]
        member _.Tactics(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: seq<string>) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Tactics <- (value |> Seq.toArray))
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#techniques-1">SentinelAlertRuleNrt#techniques</a>.
        /// </summary>
        [<CustomOperation "techniques">]
        member _.Techniques(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: seq<string>) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Techniques <- (value |> Seq.toArray))
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#timeouts-1">SentinelAlertRuleNrt#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>, value: azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrtTimeouts) : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelAlertRuleNrtState<'DisplayName, 'EventGrouping, 'LogAnalyticsWorkspaceId, 'Name, 'Query, 'Severity>

        member _.Run(state: SentinelAlertRuleNrtState<Present, Present, Present, Present, Present, Present>) : azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrt =
            let config = azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrtConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrt(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelAlertRuleNrt: missing required arguments. Must call: display_name, event_grouping, log_analytics_workspace_id, name, query, severity.", 9999, IsError = true)>]
        member _.Run(_: SentinelAlertRuleNrtState<_, _, _, _, _, _>) : azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrt =
            Unchecked.defaultof<azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrt>
