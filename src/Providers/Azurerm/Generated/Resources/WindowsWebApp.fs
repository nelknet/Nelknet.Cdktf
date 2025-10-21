namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> = { assignments: ResizeArray<azurerm.WindowsWebApp.WindowsWebAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app">azurerm_windows_web_app</a>.
    /// </summary>
    type WindowsWebAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : WindowsWebAppState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WindowsWebAppState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WindowsWebAppState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WindowsWebAppState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#location-1">WindowsWebApp#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: WindowsWebAppState<Missing, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsWebAppState<Present, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : WindowsWebAppState<Present, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#name-1">WindowsWebApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WindowsWebAppState<'Location, Missing, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsWebAppState<'Location, Present, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WindowsWebAppState<'Location, Present, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#resource_group_name-1">WindowsWebApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: WindowsWebAppState<'Location, 'Name, Missing, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsWebAppState<'Location, 'Name, Present, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : WindowsWebAppState<'Location, 'Name, Present, 'ServicePlanId, 'SiteConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#service_plan_id-1">WindowsWebApp#service_plan_id</a>.
        /// </summary>
        [<CustomOperation "service_plan_id">]
        member _.ServicePlanId(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, Missing, 'SiteConfig>, value: string) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, Present, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ServicePlanId <- value)
            ({ assignments = state.assignments } : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, Present, 'SiteConfig>)

        /// <summary>
        /// site_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#site_config-1">WindowsWebApp#site_config</a>
        /// </summary>
        [<CustomOperation "site_config">]
        member _.SiteConfig(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, Missing>, value: azurerm.WindowsWebApp.WindowsWebAppSiteConfig) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, Present> =
            state.assignments.Add(fun config -> config.SiteConfig <- value)
            ({ assignments = state.assignments } : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#app_settings-1">WindowsWebApp#app_settings</a>.
        /// </summary>
        [<CustomOperation "app_settings">]
        member _.AppSettings(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: seq<string * string>) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AppSettings <- dict value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// auth_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#auth_settings-1">WindowsWebApp#auth_settings</a>
        /// </summary>
        [<CustomOperation "auth_settings">]
        member _.AuthSettings(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.WindowsWebApp.WindowsWebAppAuthSettings) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AuthSettings <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// auth_settings_v2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#auth_settings_v2-1">WindowsWebApp#auth_settings_v2</a>
        /// </summary>
        [<CustomOperation "auth_settings_v2">]
        member _.AuthSettingsV2(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AuthSettingsV2 <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// backup block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#backup-1">WindowsWebApp#backup</a>
        /// </summary>
        [<CustomOperation "backup">]
        member _.Backup(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.WindowsWebApp.WindowsWebAppBackup) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Backup <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#client_affinity_enabled-1">WindowsWebApp#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#client_affinity_enabled-1">WindowsWebApp#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#client_certificate_enabled-1">WindowsWebApp#client_certificate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#client_certificate_enabled-1">WindowsWebApp#client_certificate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Paths to exclude when using client certificates, separated by ; Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#client_certificate_exclusion_paths-1">WindowsWebApp#client_certificate_exclusion_paths</a>
        /// </summary>
        [<CustomOperation "client_certificate_exclusion_paths">]
        member _.ClientCertificateExclusionPaths(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateExclusionPaths <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#client_certificate_mode-1">WindowsWebApp#client_certificate_mode</a>.
        /// </summary>
        [<CustomOperation "client_certificate_mode">]
        member _.ClientCertificateMode(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateMode <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// connection_string block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#connection_string-1">WindowsWebApp#connection_string</a> Accepts: azurerm.IResolvable | azurerm.WindowsWebApp.WindowsWebAppConnectionString[]
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#enabled-1">WindowsWebApp#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#enabled-1">WindowsWebApp#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#ftp_publish_basic_authentication_enabled-1">WindowsWebApp#ftp_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ftp_publish_basic_authentication_enabled">]
        member _.FtpPublishBasicAuthenticationEnabled(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FtpPublishBasicAuthenticationEnabled <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#ftp_publish_basic_authentication_enabled-1">WindowsWebApp#ftp_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ftp_publish_basic_authentication_enabled">]
        member _.FtpPublishBasicAuthenticationEnabled(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FtpPublishBasicAuthenticationEnabled <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#https_only-1">WindowsWebApp#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#https_only-1">WindowsWebApp#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#id-1">WindowsWebApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#identity-1">WindowsWebApp#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.WindowsWebApp.WindowsWebAppIdentity) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#key_vault_reference_identity_id-1">WindowsWebApp#key_vault_reference_identity_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_reference_identity_id">]
        member _.KeyVaultReferenceIdentityId(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.KeyVaultReferenceIdentityId <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#logs-1">WindowsWebApp#logs</a>
        /// </summary>
        [<CustomOperation "logs">]
        member _.Logs(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.WindowsWebApp.WindowsWebAppLogs) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Logs <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#public_network_access_enabled-1">WindowsWebApp#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#public_network_access_enabled-1">WindowsWebApp#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// sticky_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#sticky_settings-1">WindowsWebApp#sticky_settings</a>
        /// </summary>
        [<CustomOperation "sticky_settings">]
        member _.StickySettings(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.WindowsWebApp.WindowsWebAppStickySettings) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StickySettings <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#storage_account-1">WindowsWebApp#storage_account</a> Accepts: azurerm.IResolvable | azurerm.WindowsWebApp.WindowsWebAppStorageAccount[]
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#tags-1">WindowsWebApp#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: seq<string * string>) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#timeouts-1">WindowsWebApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.WindowsWebApp.WindowsWebAppTimeouts) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#virtual_network_subnet_id-1">WindowsWebApp#virtual_network_subnet_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_subnet_id">]
        member _.VirtualNetworkSubnetId(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.VirtualNetworkSubnetId <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#webdeploy_publish_basic_authentication_enabled-1">WindowsWebApp#webdeploy_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "webdeploy_publish_basic_authentication_enabled">]
        member _.WebdeployPublishBasicAuthenticationEnabled(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.WebdeployPublishBasicAuthenticationEnabled <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#webdeploy_publish_basic_authentication_enabled-1">WindowsWebApp#webdeploy_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "webdeploy_publish_basic_authentication_enabled">]
        member _.WebdeployPublishBasicAuthenticationEnabled(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.WebdeployPublishBasicAuthenticationEnabled <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// The local path and filename of the Zip packaged application to deploy to this Windows Web App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#zip_deploy_file-1">WindowsWebApp#zip_deploy_file</a>
        /// </summary>
        [<CustomOperation "zip_deploy_file">]
        member _.ZipDeployFile(state: WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ZipDeployFile <- value)
            state : WindowsWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        member _.Run(state: WindowsWebAppState<Present, Present, Present, Present, Present>) : azurerm.WindowsWebApp.WindowsWebApp =
            let config = azurerm.WindowsWebApp.WindowsWebAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.WindowsWebApp.WindowsWebApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.windowsWebApp: missing required arguments. Must call: location, name, resource_group_name, service_plan_id, site_config.", 9999, IsError = true)>]
        member _.Run(_: WindowsWebAppState<_, _, _, _, _>) : azurerm.WindowsWebApp.WindowsWebApp =
            Unchecked.defaultof<azurerm.WindowsWebApp.WindowsWebApp>
