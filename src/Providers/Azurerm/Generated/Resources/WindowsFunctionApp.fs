namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> = { assignments: ResizeArray<azurerm.WindowsFunctionApp.WindowsFunctionAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app">azurerm_windows_function_app</a>.
    /// </summary>
    type WindowsFunctionAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : WindowsFunctionAppState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WindowsFunctionAppState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WindowsFunctionAppState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WindowsFunctionAppState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#location-1">WindowsFunctionApp#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: WindowsFunctionAppState<Missing, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsFunctionAppState<Present, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : WindowsFunctionAppState<Present, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>)

        /// <summary>
        /// Specifies the name of the Function App. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#name-1">WindowsFunctionApp#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WindowsFunctionAppState<'Location, Missing, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsFunctionAppState<'Location, Present, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WindowsFunctionAppState<'Location, Present, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#resource_group_name-1">WindowsFunctionApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: WindowsFunctionAppState<'Location, 'Name, Missing, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsFunctionAppState<'Location, 'Name, Present, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : WindowsFunctionAppState<'Location, 'Name, Present, 'ServicePlanId, 'SiteConfig>)

        /// <summary>
        /// The ID of the App Service Plan within which to create this Function App. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#service_plan_id-1">WindowsFunctionApp#service_plan_id</a>
        /// </summary>
        [<CustomOperation "service_plan_id">]
        member _.ServicePlanId(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, Missing, 'SiteConfig>, value: string) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, Present, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ServicePlanId <- value)
            ({ assignments = state.assignments } : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, Present, 'SiteConfig>)

        /// <summary>
        /// site_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#site_config-1">WindowsFunctionApp#site_config</a>
        /// </summary>
        [<CustomOperation "site_config">]
        member _.SiteConfig(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, Missing>, value: azurerm.WindowsFunctionApp.WindowsFunctionAppSiteConfig) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, Present> =
            state.assignments.Add(fun config -> config.SiteConfig <- value)
            ({ assignments = state.assignments } : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, Present>)

        /// <summary>
        /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#app_settings-1">WindowsFunctionApp#app_settings</a>
        /// </summary>
        [<CustomOperation "app_settings">]
        member _.AppSettings(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: seq<string * string>) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AppSettings <- dict value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// auth_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#auth_settings-1">WindowsFunctionApp#auth_settings</a>
        /// </summary>
        [<CustomOperation "auth_settings">]
        member _.AuthSettings(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.WindowsFunctionApp.WindowsFunctionAppAuthSettings) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AuthSettings <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// auth_settings_v2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#auth_settings_v2-1">WindowsFunctionApp#auth_settings_v2</a>
        /// </summary>
        [<CustomOperation "auth_settings_v2">]
        member _.AuthSettingsV2(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.WindowsFunctionApp.WindowsFunctionAppAuthSettingsV2) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AuthSettingsV2 <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// backup block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#backup-1">WindowsFunctionApp#backup</a>
        /// </summary>
        [<CustomOperation "backup">]
        member _.Backup(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.WindowsFunctionApp.WindowsFunctionAppBackup) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Backup <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#builtin_logging_enabled-1">WindowsFunctionApp#builtin_logging_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "builtin_logging_enabled">]
        member _.BuiltinLoggingEnabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.BuiltinLoggingEnabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#builtin_logging_enabled-1">WindowsFunctionApp#builtin_logging_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "builtin_logging_enabled">]
        member _.BuiltinLoggingEnabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.BuiltinLoggingEnabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Should the function app use Client Certificates. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_certificate_enabled-1">WindowsFunctionApp#client_certificate_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Should the function app use Client Certificates. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_certificate_enabled-1">WindowsFunctionApp#client_certificate_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Paths to exclude when using client certificates, separated by ; Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_certificate_exclusion_paths-1">WindowsFunctionApp#client_certificate_exclusion_paths</a>
        /// </summary>
        [<CustomOperation "client_certificate_exclusion_paths">]
        member _.ClientCertificateExclusionPaths(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateExclusionPaths <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// The mode of the Function App's client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser` Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_certificate_mode-1">WindowsFunctionApp#client_certificate_mode</a>
        /// </summary>
        [<CustomOperation "client_certificate_mode">]
        member _.ClientCertificateMode(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateMode <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// connection_string block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#connection_string-1">WindowsFunctionApp#connection_string</a> Accepts: azurerm.IResolvable | azurerm.WindowsFunctionApp.WindowsFunctionAppConnectionString[]
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Force disable the content share settings. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#content_share_force_disabled-1">WindowsFunctionApp#content_share_force_disabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "content_share_force_disabled">]
        member _.ContentShareForceDisabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ContentShareForceDisabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Force disable the content share settings. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#content_share_force_disabled-1">WindowsFunctionApp#content_share_force_disabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "content_share_force_disabled">]
        member _.ContentShareForceDisabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ContentShareForceDisabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#daily_memory_time_quota-1">WindowsFunctionApp#daily_memory_time_quota</a>
        /// </summary>
        [<CustomOperation "daily_memory_time_quota">]
        member _.DailyMemoryTimeQuota(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: double) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.DailyMemoryTimeQuota <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Is the Windows Function App enabled. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#enabled-1">WindowsFunctionApp#enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Is the Windows Function App enabled. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#enabled-1">WindowsFunctionApp#enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#ftp_publish_basic_authentication_enabled-1">WindowsFunctionApp#ftp_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ftp_publish_basic_authentication_enabled">]
        member _.FtpPublishBasicAuthenticationEnabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FtpPublishBasicAuthenticationEnabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#ftp_publish_basic_authentication_enabled-1">WindowsFunctionApp#ftp_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ftp_publish_basic_authentication_enabled">]
        member _.FtpPublishBasicAuthenticationEnabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FtpPublishBasicAuthenticationEnabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// The runtime version associated with the Function App. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#functions_extension_version-1">WindowsFunctionApp#functions_extension_version</a>
        /// </summary>
        [<CustomOperation "functions_extension_version">]
        member _.FunctionsExtensionVersion(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FunctionsExtensionVersion <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Can the Function App only be accessed via HTTPS? Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#https_only-1">WindowsFunctionApp#https_only</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Can the Function App only be accessed via HTTPS? Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#https_only-1">WindowsFunctionApp#https_only</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#id-1">WindowsFunctionApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#identity-1">WindowsFunctionApp#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.WindowsFunctionApp.WindowsFunctionAppIdentity) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// The User Assigned Identity to use for Key Vault access. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#key_vault_reference_identity_id-1">WindowsFunctionApp#key_vault_reference_identity_id</a>
        /// </summary>
        [<CustomOperation "key_vault_reference_identity_id">]
        member _.KeyVaultReferenceIdentityId(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.KeyVaultReferenceIdentityId <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#public_network_access_enabled-1">WindowsFunctionApp#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#public_network_access_enabled-1">WindowsFunctionApp#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// sticky_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#sticky_settings-1">WindowsFunctionApp#sticky_settings</a>
        /// </summary>
        [<CustomOperation "sticky_settings">]
        member _.StickySettings(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.WindowsFunctionApp.WindowsFunctionAppStickySettings) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StickySettings <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#storage_account-1">WindowsFunctionApp#storage_account</a> Accepts: azurerm.IResolvable | azurerm.WindowsFunctionApp.WindowsFunctionAppStorageAccount[]
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// The access key which will be used to access the storage account for the Function App. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#storage_account_access_key-1">WindowsFunctionApp#storage_account_access_key</a>
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// The backend storage account name which will be used by this Function App. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#storage_account_name-1">WindowsFunctionApp#storage_account_name</a>
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#storage_key_vault_secret_id-1">WindowsFunctionApp#storage_key_vault_secret_id</a>
        /// </summary>
        [<CustomOperation "storage_key_vault_secret_id">]
        member _.StorageKeyVaultSecretId(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageKeyVaultSecretId <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Should the Function App use its Managed Identity to access storage? Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#storage_uses_managed_identity-1">WindowsFunctionApp#storage_uses_managed_identity</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_uses_managed_identity">]
        member _.StorageUsesManagedIdentity(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageUsesManagedIdentity <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Should the Function App use its Managed Identity to access storage? Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#storage_uses_managed_identity-1">WindowsFunctionApp#storage_uses_managed_identity</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_uses_managed_identity">]
        member _.StorageUsesManagedIdentity(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageUsesManagedIdentity <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#tags-1">WindowsFunctionApp#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: seq<string * string>) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#timeouts-1">WindowsFunctionApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.WindowsFunctionApp.WindowsFunctionAppTimeouts) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#virtual_network_subnet_id-1">WindowsFunctionApp#virtual_network_subnet_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_subnet_id">]
        member _.VirtualNetworkSubnetId(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.VirtualNetworkSubnetId <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Is container image pull over virtual network enabled? Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#vnet_image_pull_enabled-1">WindowsFunctionApp#vnet_image_pull_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vnet_image_pull_enabled">]
        member _.VnetImagePullEnabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.VnetImagePullEnabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Is container image pull over virtual network enabled? Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#vnet_image_pull_enabled-1">WindowsFunctionApp#vnet_image_pull_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "vnet_image_pull_enabled">]
        member _.VnetImagePullEnabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.VnetImagePullEnabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#webdeploy_publish_basic_authentication_enabled-1">WindowsFunctionApp#webdeploy_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "webdeploy_publish_basic_authentication_enabled">]
        member _.WebdeployPublishBasicAuthenticationEnabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.WebdeployPublishBasicAuthenticationEnabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#webdeploy_publish_basic_authentication_enabled-1">WindowsFunctionApp#webdeploy_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "webdeploy_publish_basic_authentication_enabled">]
        member _.WebdeployPublishBasicAuthenticationEnabled(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.WebdeployPublishBasicAuthenticationEnabled <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// The local path and filename of the Zip packaged application to deploy to this Windows Function App. **Note:** Using this value requires `WEBSITE_RUN_FROM_PACKAGE=1` to be set on the App in `app_settings`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#zip_deploy_file-1">WindowsFunctionApp#zip_deploy_file</a>
        /// </summary>
        [<CustomOperation "zip_deploy_file">]
        member _.ZipDeployFile(state: WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ZipDeployFile <- value)
            state : WindowsFunctionAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        member _.Run(state: WindowsFunctionAppState<Present, Present, Present, Present, Present>) : azurerm.WindowsFunctionApp.WindowsFunctionApp =
            let config = azurerm.WindowsFunctionApp.WindowsFunctionAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.WindowsFunctionApp.WindowsFunctionApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.windowsFunctionApp: missing required arguments. Must call: location, name, resource_group_name, service_plan_id, site_config.", 9999, IsError = true)>]
        member _.Run(_: WindowsFunctionAppState<_, _, _, _, _>) : azurerm.WindowsFunctionApp.WindowsFunctionApp =
            Unchecked.defaultof<azurerm.WindowsFunctionApp.WindowsFunctionApp>
