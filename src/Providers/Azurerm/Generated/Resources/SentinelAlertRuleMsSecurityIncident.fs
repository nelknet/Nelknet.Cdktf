namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter> = { assignments: ResizeArray<azurerm.SentinelAlertRuleMsSecurityIncident.SentinelAlertRuleMsSecurityIncidentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident">azurerm_sentinel_alert_rule_ms_security_incident</a>.
    /// </summary>
    type SentinelAlertRuleMsSecurityIncidentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelAlertRuleMsSecurityIncidentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleMsSecurityIncidentState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SentinelAlertRuleMsSecurityIncidentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleMsSecurityIncidentState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident#display_name-1">SentinelAlertRuleMsSecurityIncident#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SentinelAlertRuleMsSecurityIncidentState<Missing, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>, value: string) : SentinelAlertRuleMsSecurityIncidentState<Present, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleMsSecurityIncidentState<Present, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident#log_analytics_workspace_id-1">SentinelAlertRuleMsSecurityIncident#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelAlertRuleMsSecurityIncidentState<'DisplayName, Missing, 'Name, 'ProductFilter, 'SeverityFilter>, value: string) : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, Present, 'Name, 'ProductFilter, 'SeverityFilter> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, Present, 'Name, 'ProductFilter, 'SeverityFilter>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident#name-1">SentinelAlertRuleMsSecurityIncident#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, Missing, 'ProductFilter, 'SeverityFilter>, value: string) : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, Present, 'ProductFilter, 'SeverityFilter> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, Present, 'ProductFilter, 'SeverityFilter>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident#product_filter-1">SentinelAlertRuleMsSecurityIncident#product_filter</a>.
        /// </summary>
        [<CustomOperation "product_filter">]
        member _.ProductFilter(state: SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, Missing, 'SeverityFilter>, value: string) : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, Present, 'SeverityFilter> =
            state.assignments.Add(fun config -> config.ProductFilter <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, Present, 'SeverityFilter>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident#severity_filter-1">SentinelAlertRuleMsSecurityIncident#severity_filter</a>.
        /// </summary>
        [<CustomOperation "severity_filter">]
        member _.SeverityFilter(state: SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, Missing>, value: seq<string>) : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, Present> =
            state.assignments.Add(fun config -> config.SeverityFilter <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident#alert_rule_template_guid-1">SentinelAlertRuleMsSecurityIncident#alert_rule_template_guid</a>.
        /// </summary>
        [<CustomOperation "alert_rule_template_guid">]
        member _.AlertRuleTemplateGuid(state: SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>, value: string) : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter> =
            state.assignments.Add(fun config -> config.AlertRuleTemplateGuid <- value)
            state : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident#description-1">SentinelAlertRuleMsSecurityIncident#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>, value: string) : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident#display_name_exclude_filter-1">SentinelAlertRuleMsSecurityIncident#display_name_exclude_filter</a>.
        /// </summary>
        [<CustomOperation "display_name_exclude_filter">]
        member _.DisplayNameExcludeFilter(state: SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>, value: seq<string>) : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter> =
            state.assignments.Add(fun config -> config.DisplayNameExcludeFilter <- (value |> Seq.toArray))
            state : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident#display_name_filter-1">SentinelAlertRuleMsSecurityIncident#display_name_filter</a>.
        /// </summary>
        [<CustomOperation "display_name_filter">]
        member _.DisplayNameFilter(state: SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>, value: seq<string>) : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter> =
            state.assignments.Add(fun config -> config.DisplayNameFilter <- (value |> Seq.toArray))
            state : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident#enabled-1">SentinelAlertRuleMsSecurityIncident#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>, value: bool) : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident#enabled-1">SentinelAlertRuleMsSecurityIncident#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident#id-1">SentinelAlertRuleMsSecurityIncident#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>, value: string) : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_ms_security_incident#timeouts-1">SentinelAlertRuleMsSecurityIncident#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>, value: azurerm.SentinelAlertRuleMsSecurityIncident.SentinelAlertRuleMsSecurityIncidentTimeouts) : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelAlertRuleMsSecurityIncidentState<'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'ProductFilter, 'SeverityFilter>

        member _.Run(state: SentinelAlertRuleMsSecurityIncidentState<Present, Present, Present, Present, Present>) : azurerm.SentinelAlertRuleMsSecurityIncident.SentinelAlertRuleMsSecurityIncident =
            let config = azurerm.SentinelAlertRuleMsSecurityIncident.SentinelAlertRuleMsSecurityIncidentConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelAlertRuleMsSecurityIncident.SentinelAlertRuleMsSecurityIncident(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelAlertRuleMsSecurityIncident: missing required arguments. Must call: display_name, log_analytics_workspace_id, name, product_filter, severity_filter.", 9999, IsError = true)>]
        member _.Run(_: SentinelAlertRuleMsSecurityIncidentState<_, _, _, _, _>) : azurerm.SentinelAlertRuleMsSecurityIncident.SentinelAlertRuleMsSecurityIncident =
            Unchecked.defaultof<azurerm.SentinelAlertRuleMsSecurityIncident.SentinelAlertRuleMsSecurityIncident>
