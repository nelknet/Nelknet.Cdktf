namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> = { assignments: ResizeArray<azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot">azurerm_windows_function_app_slot</a>.
    /// </summary>
    type WindowsFunctionAppSlotBuilder(logicalId: string) =
        member _.Yield(_: unit) : WindowsFunctionAppSlotState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WindowsFunctionAppSlotState<Missing, Missing, Missing>)

        member _.Zero(()) : WindowsFunctionAppSlotState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WindowsFunctionAppSlotState<Missing, Missing, Missing>)

        /// <summary>
        /// The ID of the Windows Function App this Slot is a member of. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#function_app_id-1">WindowsFunctionAppSlot#function_app_id</a>
        /// </summary>
        [<CustomOperation "function_app_id">]
        member _.FunctionAppId(state: WindowsFunctionAppSlotState<Missing, 'Name, 'SiteConfig>, value: string) : WindowsFunctionAppSlotState<Present, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FunctionAppId <- value)
            ({ assignments = state.assignments } : WindowsFunctionAppSlotState<Present, 'Name, 'SiteConfig>)

        /// <summary>
        /// Specifies the name of the Windows Function App Slot. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#name-1">WindowsFunctionAppSlot#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WindowsFunctionAppSlotState<'FunctionAppId, Missing, 'SiteConfig>, value: string) : WindowsFunctionAppSlotState<'FunctionAppId, Present, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WindowsFunctionAppSlotState<'FunctionAppId, Present, 'SiteConfig>)

        /// <summary>
        /// site_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#site_config-1">WindowsFunctionAppSlot#site_config</a>
        /// </summary>
        [<CustomOperation "site_config">]
        member _.SiteConfig(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, Missing>, value: azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlotSiteConfig) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, Present> =
            state.assignments.Add(fun config -> config.SiteConfig <- value)
            ({ assignments = state.assignments } : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, Present>)

        /// <summary>
        /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#app_settings-1">WindowsFunctionAppSlot#app_settings</a>
        /// </summary>
        [<CustomOperation "app_settings">]
        member _.AppSettings(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: seq<string * string>) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AppSettings <- dict value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// auth_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#auth_settings-1">WindowsFunctionAppSlot#auth_settings</a>
        /// </summary>
        [<CustomOperation "auth_settings">]
        member _.AuthSettings(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettings) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AuthSettings <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// auth_settings_v2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#auth_settings_v2-1">WindowsFunctionAppSlot#auth_settings_v2</a>
        /// </summary>
        [<CustomOperation "auth_settings_v2">]
        member _.AuthSettingsV2(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettingsV2) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AuthSettingsV2 <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// backup block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#backup-1">WindowsFunctionAppSlot#backup</a>
        /// </summary>
        [<CustomOperation "backup">]
        member _.Backup(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlotBackup) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Backup <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#builtin_logging_enabled-1">WindowsFunctionAppSlot#builtin_logging_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "builtin_logging_enabled">]
        member _.BuiltinLoggingEnabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: bool) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.BuiltinLoggingEnabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#builtin_logging_enabled-1">WindowsFunctionAppSlot#builtin_logging_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "builtin_logging_enabled">]
        member _.BuiltinLoggingEnabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.BuiltinLoggingEnabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Should the Function App Slot use Client Certificates. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#client_certificate_enabled-1">WindowsFunctionAppSlot#client_certificate_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: bool) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Should the Function App Slot use Client Certificates. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#client_certificate_enabled-1">WindowsFunctionAppSlot#client_certificate_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Paths to exclude when using client certificates, separated by ; Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#client_certificate_exclusion_paths-1">WindowsFunctionAppSlot#client_certificate_exclusion_paths</a>
        /// </summary>
        [<CustomOperation "client_certificate_exclusion_paths">]
        member _.ClientCertificateExclusionPaths(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: string) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateExclusionPaths <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// The mode of the Function App Slot's client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#client_certificate_mode-1">WindowsFunctionAppSlot#client_certificate_mode</a>
        /// </summary>
        [<CustomOperation "client_certificate_mode">]
        member _.ClientCertificateMode(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: string) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateMode <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// connection_string block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#connection_string-1">WindowsFunctionAppSlot#connection_string</a> Accepts: azurerm.IResolvable | azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlotConnectionString[]
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Force disable the content share settings. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#content_share_force_disabled-1">WindowsFunctionAppSlot#content_share_force_disabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "content_share_force_disabled">]
        member _.ContentShareForceDisabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: bool) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ContentShareForceDisabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Force disable the content share settings. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#content_share_force_disabled-1">WindowsFunctionAppSlot#content_share_force_disabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "content_share_force_disabled">]
        member _.ContentShareForceDisabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ContentShareForceDisabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#daily_memory_time_quota-1">WindowsFunctionAppSlot#daily_memory_time_quota</a>
        /// </summary>
        [<CustomOperation "daily_memory_time_quota">]
        member _.DailyMemoryTimeQuota(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: double) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.DailyMemoryTimeQuota <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Is the Windows Function App Slot enabled. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#enabled-1">WindowsFunctionAppSlot#enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: bool) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Is the Windows Function App Slot enabled. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#enabled-1">WindowsFunctionAppSlot#enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#ftp_publish_basic_authentication_enabled-1">WindowsFunctionAppSlot#ftp_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ftp_publish_basic_authentication_enabled">]
        member _.FtpPublishBasicAuthenticationEnabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: bool) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FtpPublishBasicAuthenticationEnabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#ftp_publish_basic_authentication_enabled-1">WindowsFunctionAppSlot#ftp_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ftp_publish_basic_authentication_enabled">]
        member _.FtpPublishBasicAuthenticationEnabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FtpPublishBasicAuthenticationEnabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// The runtime version associated with the Function App Slot. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#functions_extension_version-1">WindowsFunctionAppSlot#functions_extension_version</a>
        /// </summary>
        [<CustomOperation "functions_extension_version">]
        member _.FunctionsExtensionVersion(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: string) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FunctionsExtensionVersion <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Can the Function App Slot only be accessed via HTTPS? Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#https_only-1">WindowsFunctionAppSlot#https_only</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: bool) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Can the Function App Slot only be accessed via HTTPS? Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#https_only-1">WindowsFunctionAppSlot#https_only</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#id-1">WindowsFunctionAppSlot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: string) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#identity-1">WindowsFunctionAppSlot#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlotIdentity) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// The User Assigned Identity to use for Key Vault access. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#key_vault_reference_identity_id-1">WindowsFunctionAppSlot#key_vault_reference_identity_id</a>
        /// </summary>
        [<CustomOperation "key_vault_reference_identity_id">]
        member _.KeyVaultReferenceIdentityId(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: string) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.KeyVaultReferenceIdentityId <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#public_network_access_enabled-1">WindowsFunctionAppSlot#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: bool) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#public_network_access_enabled-1">WindowsFunctionAppSlot#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#service_plan_id-1">WindowsFunctionAppSlot#service_plan_id</a>.
        /// </summary>
        [<CustomOperation "service_plan_id">]
        member _.ServicePlanId(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: string) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ServicePlanId <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#storage_account-1">WindowsFunctionAppSlot#storage_account</a> Accepts: azurerm.IResolvable | azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlotStorageAccount[]
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// The access key which will be used to access the storage account for the Function App Slot. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#storage_account_access_key-1">WindowsFunctionAppSlot#storage_account_access_key</a>
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: string) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// The backend storage account name which will be used by this Function App Slot. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#storage_account_name-1">WindowsFunctionAppSlot#storage_account_name</a>
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: string) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#storage_key_vault_secret_id-1">WindowsFunctionAppSlot#storage_key_vault_secret_id</a>
        /// </summary>
        [<CustomOperation "storage_key_vault_secret_id">]
        member _.StorageKeyVaultSecretId(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: string) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageKeyVaultSecretId <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Should the Function App Slot use its Managed Identity to access storage? Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#storage_uses_managed_identity-1">WindowsFunctionAppSlot#storage_uses_managed_identity</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_uses_managed_identity">]
        member _.StorageUsesManagedIdentity(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: bool) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageUsesManagedIdentity <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Should the Function App Slot use its Managed Identity to access storage? Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#storage_uses_managed_identity-1">WindowsFunctionAppSlot#storage_uses_managed_identity</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_uses_managed_identity">]
        member _.StorageUsesManagedIdentity(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageUsesManagedIdentity <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#tags-1">WindowsFunctionAppSlot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: seq<string * string>) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#timeouts-1">WindowsFunctionAppSlot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlotTimeouts) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#virtual_network_subnet_id-1">WindowsFunctionAppSlot#virtual_network_subnet_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_subnet_id">]
        member _.VirtualNetworkSubnetId(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: string) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.VirtualNetworkSubnetId <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Is container image pull over virtual network enabled? Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#vnet_image_pull_enabled-1">WindowsFunctionAppSlot#vnet_image_pull_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vnet_image_pull_enabled">]
        member _.VnetImagePullEnabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: bool) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.VnetImagePullEnabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Is container image pull over virtual network enabled? Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#vnet_image_pull_enabled-1">WindowsFunctionAppSlot#vnet_image_pull_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vnet_image_pull_enabled">]
        member _.VnetImagePullEnabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.VnetImagePullEnabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#webdeploy_publish_basic_authentication_enabled-1">WindowsFunctionAppSlot#webdeploy_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "webdeploy_publish_basic_authentication_enabled">]
        member _.WebdeployPublishBasicAuthenticationEnabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: bool) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.WebdeployPublishBasicAuthenticationEnabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#webdeploy_publish_basic_authentication_enabled-1">WindowsFunctionAppSlot#webdeploy_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "webdeploy_publish_basic_authentication_enabled">]
        member _.WebdeployPublishBasicAuthenticationEnabled(state: WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.WebdeployPublishBasicAuthenticationEnabled <- value)
            state : WindowsFunctionAppSlotState<'FunctionAppId, 'Name, 'SiteConfig>

        member _.Run(state: WindowsFunctionAppSlotState<Present, Present, Present>) : azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlot =
            let config = azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlotConfig()
            for setter in state.assignments do
                setter config
            azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.windowsFunctionAppSlot: missing required arguments. Must call: function_app_id, name, site_config.", 9999, IsError = true)>]
        member _.Run(_: WindowsFunctionAppSlotState<_, _, _>) : azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlot =
            Unchecked.defaultof<azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlot>
