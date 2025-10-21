namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityCenterStorageDefenderState<'StorageAccountId> = { assignments: ResizeArray<azurerm.SecurityCenterStorageDefender.SecurityCenterStorageDefenderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_storage_defender">azurerm_security_center_storage_defender</a>.
    /// </summary>
    type SecurityCenterStorageDefenderBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityCenterStorageDefenderState<Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterStorageDefenderState<Missing>)

        member _.Zero(()) : SecurityCenterStorageDefenderState<Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterStorageDefenderState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_storage_defender#storage_account_id-1">SecurityCenterStorageDefender#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: SecurityCenterStorageDefenderState<Missing>, value: string) : SecurityCenterStorageDefenderState<Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : SecurityCenterStorageDefenderState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_storage_defender#id-1">SecurityCenterStorageDefender#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityCenterStorageDefenderState<'StorageAccountId>, value: string) : SecurityCenterStorageDefenderState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityCenterStorageDefenderState<'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_storage_defender#malware_scanning_on_upload_cap_gb_per_month-1">SecurityCenterStorageDefender#malware_scanning_on_upload_cap_gb_per_month</a>.
        /// </summary>
        [<CustomOperation "malware_scanning_on_upload_cap_gb_per_month">]
        member _.MalwareScanningOnUploadCapGbPerMonth(state: SecurityCenterStorageDefenderState<'StorageAccountId>, value: double) : SecurityCenterStorageDefenderState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.MalwareScanningOnUploadCapGbPerMonth <- value)
            state : SecurityCenterStorageDefenderState<'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_storage_defender#malware_scanning_on_upload_enabled-1">SecurityCenterStorageDefender#malware_scanning_on_upload_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "malware_scanning_on_upload_enabled">]
        member _.MalwareScanningOnUploadEnabled(state: SecurityCenterStorageDefenderState<'StorageAccountId>, value: bool) : SecurityCenterStorageDefenderState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.MalwareScanningOnUploadEnabled <- value)
            state : SecurityCenterStorageDefenderState<'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_storage_defender#malware_scanning_on_upload_enabled-1">SecurityCenterStorageDefender#malware_scanning_on_upload_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "malware_scanning_on_upload_enabled">]
        member _.MalwareScanningOnUploadEnabled(state: SecurityCenterStorageDefenderState<'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : SecurityCenterStorageDefenderState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.MalwareScanningOnUploadEnabled <- value)
            state : SecurityCenterStorageDefenderState<'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_storage_defender#override_subscription_settings_enabled-1">SecurityCenterStorageDefender#override_subscription_settings_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "override_subscription_settings_enabled">]
        member _.OverrideSubscriptionSettingsEnabled(state: SecurityCenterStorageDefenderState<'StorageAccountId>, value: bool) : SecurityCenterStorageDefenderState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.OverrideSubscriptionSettingsEnabled <- value)
            state : SecurityCenterStorageDefenderState<'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_storage_defender#override_subscription_settings_enabled-1">SecurityCenterStorageDefender#override_subscription_settings_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "override_subscription_settings_enabled">]
        member _.OverrideSubscriptionSettingsEnabled(state: SecurityCenterStorageDefenderState<'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : SecurityCenterStorageDefenderState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.OverrideSubscriptionSettingsEnabled <- value)
            state : SecurityCenterStorageDefenderState<'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_storage_defender#scan_results_event_grid_topic_id-1">SecurityCenterStorageDefender#scan_results_event_grid_topic_id</a>.
        /// </summary>
        [<CustomOperation "scan_results_event_grid_topic_id">]
        member _.ScanResultsEventGridTopicId(state: SecurityCenterStorageDefenderState<'StorageAccountId>, value: string) : SecurityCenterStorageDefenderState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.ScanResultsEventGridTopicId <- value)
            state : SecurityCenterStorageDefenderState<'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_storage_defender#sensitive_data_discovery_enabled-1">SecurityCenterStorageDefender#sensitive_data_discovery_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sensitive_data_discovery_enabled">]
        member _.SensitiveDataDiscoveryEnabled(state: SecurityCenterStorageDefenderState<'StorageAccountId>, value: bool) : SecurityCenterStorageDefenderState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.SensitiveDataDiscoveryEnabled <- value)
            state : SecurityCenterStorageDefenderState<'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_storage_defender#sensitive_data_discovery_enabled-1">SecurityCenterStorageDefender#sensitive_data_discovery_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sensitive_data_discovery_enabled">]
        member _.SensitiveDataDiscoveryEnabled(state: SecurityCenterStorageDefenderState<'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : SecurityCenterStorageDefenderState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.SensitiveDataDiscoveryEnabled <- value)
            state : SecurityCenterStorageDefenderState<'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_storage_defender#timeouts-1">SecurityCenterStorageDefender#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityCenterStorageDefenderState<'StorageAccountId>, value: azurerm.SecurityCenterStorageDefender.SecurityCenterStorageDefenderTimeouts) : SecurityCenterStorageDefenderState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityCenterStorageDefenderState<'StorageAccountId>

        member _.Run(state: SecurityCenterStorageDefenderState<Present>) : azurerm.SecurityCenterStorageDefender.SecurityCenterStorageDefender =
            let config = azurerm.SecurityCenterStorageDefender.SecurityCenterStorageDefenderConfig()
            for setter in state.assignments do
                setter config
            azurerm.SecurityCenterStorageDefender.SecurityCenterStorageDefender(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.securityCenterStorageDefender: missing required arguments. Must call: storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: SecurityCenterStorageDefenderState<_>) : azurerm.SecurityCenterStorageDefender.SecurityCenterStorageDefender =
            Unchecked.defaultof<azurerm.SecurityCenterStorageDefender.SecurityCenterStorageDefender>
