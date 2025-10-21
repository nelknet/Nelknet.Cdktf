namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSentinelAlertRuleAnomalyState<'LogAnalyticsWorkspaceId> = { assignments: ResizeArray<azurerm.DataAzurermSentinelAlertRuleAnomaly.DataAzurermSentinelAlertRuleAnomalyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_anomaly">azurerm_sentinel_alert_rule_anomaly</a>.
    /// </summary>
    type DataAzurermSentinelAlertRuleAnomalyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSentinelAlertRuleAnomalyState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSentinelAlertRuleAnomalyState<Missing>)

        member _.Zero(()) : DataAzurermSentinelAlertRuleAnomalyState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSentinelAlertRuleAnomalyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_anomaly#log_analytics_workspace_id-1">DataAzurermSentinelAlertRuleAnomaly#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: DataAzurermSentinelAlertRuleAnomalyState<Missing>, value: string) : DataAzurermSentinelAlertRuleAnomalyState<Present> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : DataAzurermSentinelAlertRuleAnomalyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_anomaly#display_name-1">DataAzurermSentinelAlertRuleAnomaly#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: DataAzurermSentinelAlertRuleAnomalyState<'LogAnalyticsWorkspaceId>, value: string) : DataAzurermSentinelAlertRuleAnomalyState<'LogAnalyticsWorkspaceId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : DataAzurermSentinelAlertRuleAnomalyState<'LogAnalyticsWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_anomaly#id-1">DataAzurermSentinelAlertRuleAnomaly#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSentinelAlertRuleAnomalyState<'LogAnalyticsWorkspaceId>, value: string) : DataAzurermSentinelAlertRuleAnomalyState<'LogAnalyticsWorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSentinelAlertRuleAnomalyState<'LogAnalyticsWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_anomaly#name-1">DataAzurermSentinelAlertRuleAnomaly#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSentinelAlertRuleAnomalyState<'LogAnalyticsWorkspaceId>, value: string) : DataAzurermSentinelAlertRuleAnomalyState<'LogAnalyticsWorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermSentinelAlertRuleAnomalyState<'LogAnalyticsWorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_anomaly#timeouts-1">DataAzurermSentinelAlertRuleAnomaly#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSentinelAlertRuleAnomalyState<'LogAnalyticsWorkspaceId>, value: azurerm.DataAzurermSentinelAlertRuleAnomaly.DataAzurermSentinelAlertRuleAnomalyTimeouts) : DataAzurermSentinelAlertRuleAnomalyState<'LogAnalyticsWorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSentinelAlertRuleAnomalyState<'LogAnalyticsWorkspaceId>

        member _.Run(state: DataAzurermSentinelAlertRuleAnomalyState<Present>) : azurerm.DataAzurermSentinelAlertRuleAnomaly.DataAzurermSentinelAlertRuleAnomaly =
            let config = azurerm.DataAzurermSentinelAlertRuleAnomaly.DataAzurermSentinelAlertRuleAnomalyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSentinelAlertRuleAnomaly.DataAzurermSentinelAlertRuleAnomaly(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSentinelAlertRuleAnomaly: missing required arguments. Must call: log_analytics_workspace_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSentinelAlertRuleAnomalyState<_>) : azurerm.DataAzurermSentinelAlertRuleAnomaly.DataAzurermSentinelAlertRuleAnomaly =
            Unchecked.defaultof<azurerm.DataAzurermSentinelAlertRuleAnomaly.DataAzurermSentinelAlertRuleAnomaly>
