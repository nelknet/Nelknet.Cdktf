namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorAadDiagnosticSettingState<'Name> = { assignments: ResizeArray<azurerm.MonitorAadDiagnosticSetting.MonitorAadDiagnosticSettingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting">azurerm_monitor_aad_diagnostic_setting</a>.
    /// </summary>
    type MonitorAadDiagnosticSettingBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorAadDiagnosticSettingState<Missing> =
            ({ assignments = ResizeArray() } : MonitorAadDiagnosticSettingState<Missing>)

        member _.Zero(()) : MonitorAadDiagnosticSettingState<Missing> =
            ({ assignments = ResizeArray() } : MonitorAadDiagnosticSettingState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#name-1">MonitorAadDiagnosticSetting#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorAadDiagnosticSettingState<Missing>, value: string) : MonitorAadDiagnosticSettingState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorAadDiagnosticSettingState<Present>)

        /// <summary>
        /// enabled_log block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#enabled_log-1">MonitorAadDiagnosticSetting#enabled_log</a> Accepts: azurerm.IResolvable | azurerm.MonitorAadDiagnosticSetting.MonitorAadDiagnosticSettingEnabledLog[]
        /// </summary>
        [<CustomOperation "enabled_log">]
        member _.EnabledLog(state: MonitorAadDiagnosticSettingState<'Name>, value: HashiCorp.Cdktf.IResolvable) : MonitorAadDiagnosticSettingState<'Name> =
            state.assignments.Add(fun config -> config.EnabledLog <- value)
            state : MonitorAadDiagnosticSettingState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#eventhub_authorization_rule_id-1">MonitorAadDiagnosticSetting#eventhub_authorization_rule_id</a>.
        /// </summary>
        [<CustomOperation "eventhub_authorization_rule_id">]
        member _.EventhubAuthorizationRuleId(state: MonitorAadDiagnosticSettingState<'Name>, value: string) : MonitorAadDiagnosticSettingState<'Name> =
            state.assignments.Add(fun config -> config.EventhubAuthorizationRuleId <- value)
            state : MonitorAadDiagnosticSettingState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#eventhub_name-1">MonitorAadDiagnosticSetting#eventhub_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_name">]
        member _.EventhubName(state: MonitorAadDiagnosticSettingState<'Name>, value: string) : MonitorAadDiagnosticSettingState<'Name> =
            state.assignments.Add(fun config -> config.EventhubName <- value)
            state : MonitorAadDiagnosticSettingState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#id-1">MonitorAadDiagnosticSetting#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorAadDiagnosticSettingState<'Name>, value: string) : MonitorAadDiagnosticSettingState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorAadDiagnosticSettingState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#log_analytics_workspace_id-1">MonitorAadDiagnosticSetting#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: MonitorAadDiagnosticSettingState<'Name>, value: string) : MonitorAadDiagnosticSettingState<'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            state : MonitorAadDiagnosticSettingState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#storage_account_id-1">MonitorAadDiagnosticSetting#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: MonitorAadDiagnosticSettingState<'Name>, value: string) : MonitorAadDiagnosticSettingState<'Name> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            state : MonitorAadDiagnosticSettingState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#timeouts-1">MonitorAadDiagnosticSetting#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorAadDiagnosticSettingState<'Name>, value: azurerm.MonitorAadDiagnosticSetting.MonitorAadDiagnosticSettingTimeouts) : MonitorAadDiagnosticSettingState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorAadDiagnosticSettingState<'Name>

        member _.Run(state: MonitorAadDiagnosticSettingState<Present>) : azurerm.MonitorAadDiagnosticSetting.MonitorAadDiagnosticSetting =
            let config = azurerm.MonitorAadDiagnosticSetting.MonitorAadDiagnosticSettingConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorAadDiagnosticSetting.MonitorAadDiagnosticSetting(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorAadDiagnosticSetting: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: MonitorAadDiagnosticSettingState<_>) : azurerm.MonitorAadDiagnosticSetting.MonitorAadDiagnosticSetting =
            Unchecked.defaultof<azurerm.MonitorAadDiagnosticSetting.MonitorAadDiagnosticSetting>
