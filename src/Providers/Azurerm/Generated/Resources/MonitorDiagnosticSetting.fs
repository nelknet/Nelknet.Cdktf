namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorDiagnosticSettingState<'Name, 'TargetResourceId> = { assignments: ResizeArray<azurerm.MonitorDiagnosticSetting.MonitorDiagnosticSettingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting">azurerm_monitor_diagnostic_setting</a>.
    /// </summary>
    type MonitorDiagnosticSettingBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorDiagnosticSettingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorDiagnosticSettingState<Missing, Missing>)

        member _.Zero(()) : MonitorDiagnosticSettingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorDiagnosticSettingState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#name-1">MonitorDiagnosticSetting#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorDiagnosticSettingState<Missing, 'TargetResourceId>, value: string) : MonitorDiagnosticSettingState<Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorDiagnosticSettingState<Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#target_resource_id-1">MonitorDiagnosticSetting#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: MonitorDiagnosticSettingState<'Name, Missing>, value: string) : MonitorDiagnosticSettingState<'Name, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : MonitorDiagnosticSettingState<'Name, Present>)

        /// <summary>
        /// enabled_log block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#enabled_log-1">MonitorDiagnosticSetting#enabled_log</a> Accepts: azurerm.IResolvable | azurerm.MonitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLog[]
        /// </summary>
        [<CustomOperation "enabled_log">]
        member _.EnabledLog(state: MonitorDiagnosticSettingState<'Name, 'TargetResourceId>, value: HashiCorp.Cdktf.IResolvable) : MonitorDiagnosticSettingState<'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.EnabledLog <- value)
            state : MonitorDiagnosticSettingState<'Name, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#eventhub_authorization_rule_id-1">MonitorDiagnosticSetting#eventhub_authorization_rule_id</a>.
        /// </summary>
        [<CustomOperation "eventhub_authorization_rule_id">]
        member _.EventhubAuthorizationRuleId(state: MonitorDiagnosticSettingState<'Name, 'TargetResourceId>, value: string) : MonitorDiagnosticSettingState<'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.EventhubAuthorizationRuleId <- value)
            state : MonitorDiagnosticSettingState<'Name, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#eventhub_name-1">MonitorDiagnosticSetting#eventhub_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_name">]
        member _.EventhubName(state: MonitorDiagnosticSettingState<'Name, 'TargetResourceId>, value: string) : MonitorDiagnosticSettingState<'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.EventhubName <- value)
            state : MonitorDiagnosticSettingState<'Name, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#id-1">MonitorDiagnosticSetting#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorDiagnosticSettingState<'Name, 'TargetResourceId>, value: string) : MonitorDiagnosticSettingState<'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorDiagnosticSettingState<'Name, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#log_analytics_destination_type-1">MonitorDiagnosticSetting#log_analytics_destination_type</a>.
        /// </summary>
        [<CustomOperation "log_analytics_destination_type">]
        member _.LogAnalyticsDestinationType(state: MonitorDiagnosticSettingState<'Name, 'TargetResourceId>, value: string) : MonitorDiagnosticSettingState<'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.LogAnalyticsDestinationType <- value)
            state : MonitorDiagnosticSettingState<'Name, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#log_analytics_workspace_id-1">MonitorDiagnosticSetting#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: MonitorDiagnosticSettingState<'Name, 'TargetResourceId>, value: string) : MonitorDiagnosticSettingState<'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            state : MonitorDiagnosticSettingState<'Name, 'TargetResourceId>

        /// <summary>
        /// metric block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#metric-1">MonitorDiagnosticSetting#metric</a> Accepts: azurerm.IResolvable | azurerm.MonitorDiagnosticSetting.MonitorDiagnosticSettingMetric[]
        /// </summary>
        [<CustomOperation "metric">]
        member _.Metric(state: MonitorDiagnosticSettingState<'Name, 'TargetResourceId>, value: HashiCorp.Cdktf.IResolvable) : MonitorDiagnosticSettingState<'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Metric <- value)
            state : MonitorDiagnosticSettingState<'Name, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#partner_solution_id-1">MonitorDiagnosticSetting#partner_solution_id</a>.
        /// </summary>
        [<CustomOperation "partner_solution_id">]
        member _.PartnerSolutionId(state: MonitorDiagnosticSettingState<'Name, 'TargetResourceId>, value: string) : MonitorDiagnosticSettingState<'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.PartnerSolutionId <- value)
            state : MonitorDiagnosticSettingState<'Name, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#storage_account_id-1">MonitorDiagnosticSetting#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: MonitorDiagnosticSettingState<'Name, 'TargetResourceId>, value: string) : MonitorDiagnosticSettingState<'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            state : MonitorDiagnosticSettingState<'Name, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#timeouts-1">MonitorDiagnosticSetting#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorDiagnosticSettingState<'Name, 'TargetResourceId>, value: azurerm.MonitorDiagnosticSetting.MonitorDiagnosticSettingTimeouts) : MonitorDiagnosticSettingState<'Name, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorDiagnosticSettingState<'Name, 'TargetResourceId>

        member _.Run(state: MonitorDiagnosticSettingState<Present, Present>) : azurerm.MonitorDiagnosticSetting.MonitorDiagnosticSetting =
            let config = azurerm.MonitorDiagnosticSetting.MonitorDiagnosticSettingConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorDiagnosticSetting.MonitorDiagnosticSetting(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorDiagnosticSetting: missing required arguments. Must call: name, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: MonitorDiagnosticSettingState<_, _>) : azurerm.MonitorDiagnosticSetting.MonitorDiagnosticSetting =
            Unchecked.defaultof<azurerm.MonitorDiagnosticSetting.MonitorDiagnosticSetting>
