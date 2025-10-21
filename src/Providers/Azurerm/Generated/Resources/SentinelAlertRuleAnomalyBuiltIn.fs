namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> = { assignments: ResizeArray<azurerm.SentinelAlertRuleAnomalyBuiltIn.SentinelAlertRuleAnomalyBuiltInConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_built_in">azurerm_sentinel_alert_rule_anomaly_built_in</a>.
    /// </summary>
    type SentinelAlertRuleAnomalyBuiltInBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelAlertRuleAnomalyBuiltInState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleAnomalyBuiltInState<Missing, Missing, Missing>)

        member _.Zero(()) : SentinelAlertRuleAnomalyBuiltInState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelAlertRuleAnomalyBuiltInState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_built_in#enabled-1">SentinelAlertRuleAnomalyBuiltIn#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleAnomalyBuiltInState<Missing, 'LogAnalyticsWorkspaceId, 'Mode>, value: bool) : SentinelAlertRuleAnomalyBuiltInState<Present, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleAnomalyBuiltInState<Present, 'LogAnalyticsWorkspaceId, 'Mode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_built_in#enabled-1">SentinelAlertRuleAnomalyBuiltIn#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SentinelAlertRuleAnomalyBuiltInState<Missing, 'LogAnalyticsWorkspaceId, 'Mode>, value: HashiCorp.Cdktf.IResolvable) : SentinelAlertRuleAnomalyBuiltInState<Present, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleAnomalyBuiltInState<Present, 'LogAnalyticsWorkspaceId, 'Mode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_built_in#log_analytics_workspace_id-1">SentinelAlertRuleAnomalyBuiltIn#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelAlertRuleAnomalyBuiltInState<'Enabled, Missing, 'Mode>, value: string) : SentinelAlertRuleAnomalyBuiltInState<'Enabled, Present, 'Mode> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleAnomalyBuiltInState<'Enabled, Present, 'Mode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_built_in#mode-1">SentinelAlertRuleAnomalyBuiltIn#mode</a>.
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Mode <- value)
            ({ assignments = state.assignments } : SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_built_in#display_name-1">SentinelAlertRuleAnomalyBuiltIn#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>, value: string) : SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_built_in#id-1">SentinelAlertRuleAnomalyBuiltIn#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>, value: string) : SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_built_in#name-1">SentinelAlertRuleAnomalyBuiltIn#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>, value: string) : SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_anomaly_built_in#timeouts-1">SentinelAlertRuleAnomalyBuiltIn#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>, value: azurerm.SentinelAlertRuleAnomalyBuiltIn.SentinelAlertRuleAnomalyBuiltInTimeouts) : SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, 'Mode> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelAlertRuleAnomalyBuiltInState<'Enabled, 'LogAnalyticsWorkspaceId, 'Mode>

        member _.Run(state: SentinelAlertRuleAnomalyBuiltInState<Present, Present, Present>) : azurerm.SentinelAlertRuleAnomalyBuiltIn.SentinelAlertRuleAnomalyBuiltIn =
            let config = azurerm.SentinelAlertRuleAnomalyBuiltIn.SentinelAlertRuleAnomalyBuiltInConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelAlertRuleAnomalyBuiltIn.SentinelAlertRuleAnomalyBuiltIn(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelAlertRuleAnomalyBuiltIn: missing required arguments. Must call: enabled, log_analytics_workspace_id, mode.", 9999, IsError = true)>]
        member _.Run(_: SentinelAlertRuleAnomalyBuiltInState<_, _, _>) : azurerm.SentinelAlertRuleAnomalyBuiltIn.SentinelAlertRuleAnomalyBuiltIn =
            Unchecked.defaultof<azurerm.SentinelAlertRuleAnomalyBuiltIn.SentinelAlertRuleAnomalyBuiltIn>
