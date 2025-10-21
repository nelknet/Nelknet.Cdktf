namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSentinelAlertRuleTemplateState<'LogAnalyticsWorkspaceId> = { assignments: ResizeArray<azurerm.DataAzurermSentinelAlertRuleTemplate.DataAzurermSentinelAlertRuleTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_template">azurerm_sentinel_alert_rule_template</a>.
    /// </summary>
    type DataAzurermSentinelAlertRuleTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSentinelAlertRuleTemplateState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSentinelAlertRuleTemplateState<Missing>)

        member _.Zero(()) : DataAzurermSentinelAlertRuleTemplateState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSentinelAlertRuleTemplateState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_template#log_analytics_workspace_id-1">DataAzurermSentinelAlertRuleTemplate#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: DataAzurermSentinelAlertRuleTemplateState<Missing>, value: string) : DataAzurermSentinelAlertRuleTemplateState<Present> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : DataAzurermSentinelAlertRuleTemplateState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_template#display_name-1">DataAzurermSentinelAlertRuleTemplate#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: DataAzurermSentinelAlertRuleTemplateState<'LogAnalyticsWorkspaceId>, value: string) : DataAzurermSentinelAlertRuleTemplateState<'LogAnalyticsWorkspaceId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : DataAzurermSentinelAlertRuleTemplateState<'LogAnalyticsWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_template#id-1">DataAzurermSentinelAlertRuleTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSentinelAlertRuleTemplateState<'LogAnalyticsWorkspaceId>, value: string) : DataAzurermSentinelAlertRuleTemplateState<'LogAnalyticsWorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSentinelAlertRuleTemplateState<'LogAnalyticsWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_template#name-1">DataAzurermSentinelAlertRuleTemplate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSentinelAlertRuleTemplateState<'LogAnalyticsWorkspaceId>, value: string) : DataAzurermSentinelAlertRuleTemplateState<'LogAnalyticsWorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermSentinelAlertRuleTemplateState<'LogAnalyticsWorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule_template#timeouts-1">DataAzurermSentinelAlertRuleTemplate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSentinelAlertRuleTemplateState<'LogAnalyticsWorkspaceId>, value: azurerm.DataAzurermSentinelAlertRuleTemplate.DataAzurermSentinelAlertRuleTemplateTimeouts) : DataAzurermSentinelAlertRuleTemplateState<'LogAnalyticsWorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSentinelAlertRuleTemplateState<'LogAnalyticsWorkspaceId>

        member _.Run(state: DataAzurermSentinelAlertRuleTemplateState<Present>) : azurerm.DataAzurermSentinelAlertRuleTemplate.DataAzurermSentinelAlertRuleTemplate =
            let config = azurerm.DataAzurermSentinelAlertRuleTemplate.DataAzurermSentinelAlertRuleTemplateConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSentinelAlertRuleTemplate.DataAzurermSentinelAlertRuleTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSentinelAlertRuleTemplate: missing required arguments. Must call: log_analytics_workspace_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSentinelAlertRuleTemplateState<_>) : azurerm.DataAzurermSentinelAlertRuleTemplate.DataAzurermSentinelAlertRuleTemplate =
            Unchecked.defaultof<azurerm.DataAzurermSentinelAlertRuleTemplate.DataAzurermSentinelAlertRuleTemplate>
