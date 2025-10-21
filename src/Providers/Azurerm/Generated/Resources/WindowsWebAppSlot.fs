namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> = { assignments: ResizeArray<azurerm.WindowsWebAppSlot.WindowsWebAppSlotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot">azurerm_windows_web_app_slot</a>.
    /// </summary>
    type WindowsWebAppSlotBuilder(logicalId: string) =
        member _.Yield(_: unit) : WindowsWebAppSlotState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WindowsWebAppSlotState<Missing, Missing, Missing>)

        member _.Zero(()) : WindowsWebAppSlotState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WindowsWebAppSlotState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#app_service_id-1">WindowsWebAppSlot#app_service_id</a>.
        /// </summary>
        [<CustomOperation "app_service_id">]
        member _.AppServiceId(state: WindowsWebAppSlotState<Missing, 'Name, 'SiteConfig>, value: string) : WindowsWebAppSlotState<Present, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AppServiceId <- value)
            ({ assignments = state.assignments } : WindowsWebAppSlotState<Present, 'Name, 'SiteConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#name-1">WindowsWebAppSlot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WindowsWebAppSlotState<'AppServiceId, Missing, 'SiteConfig>, value: string) : WindowsWebAppSlotState<'AppServiceId, Present, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WindowsWebAppSlotState<'AppServiceId, Present, 'SiteConfig>)

        /// <summary>
        /// site_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#site_config-1">WindowsWebAppSlot#site_config</a>
        /// </summary>
        [<CustomOperation "site_config">]
        member _.SiteConfig(state: WindowsWebAppSlotState<'AppServiceId, 'Name, Missing>, value: azurerm.WindowsWebAppSlot.WindowsWebAppSlotSiteConfig) : WindowsWebAppSlotState<'AppServiceId, 'Name, Present> =
            state.assignments.Add(fun config -> config.SiteConfig <- value)
            ({ assignments = state.assignments } : WindowsWebAppSlotState<'AppServiceId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#app_settings-1">WindowsWebAppSlot#app_settings</a>.
        /// </summary>
        [<CustomOperation "app_settings">]
        member _.AppSettings(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: seq<string * string>) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AppSettings <- dict value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// auth_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#auth_settings-1">WindowsWebAppSlot#auth_settings</a>
        /// </summary>
        [<CustomOperation "auth_settings">]
        member _.AuthSettings(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettings) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AuthSettings <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// auth_settings_v2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#auth_settings_v2-1">WindowsWebAppSlot#auth_settings_v2</a>
        /// </summary>
        [<CustomOperation "auth_settings_v2">]
        member _.AuthSettingsV2(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsV2) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AuthSettingsV2 <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// backup block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#backup-1">WindowsWebAppSlot#backup</a>
        /// </summary>
        [<CustomOperation "backup">]
        member _.Backup(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: azurerm.WindowsWebAppSlot.WindowsWebAppSlotBackup) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Backup <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#client_affinity_enabled-1">WindowsWebAppSlot#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#client_affinity_enabled-1">WindowsWebAppSlot#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#client_certificate_enabled-1">WindowsWebAppSlot#client_certificate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#client_certificate_enabled-1">WindowsWebAppSlot#client_certificate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Paths to exclude when using client certificates, separated by ; Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#client_certificate_exclusion_paths-1">WindowsWebAppSlot#client_certificate_exclusion_paths</a>
        /// </summary>
        [<CustomOperation "client_certificate_exclusion_paths">]
        member _.ClientCertificateExclusionPaths(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateExclusionPaths <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#client_certificate_mode-1">WindowsWebAppSlot#client_certificate_mode</a>.
        /// </summary>
        [<CustomOperation "client_certificate_mode">]
        member _.ClientCertificateMode(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateMode <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// connection_string block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#connection_string-1">WindowsWebAppSlot#connection_string</a> Accepts: azurerm.IResolvable | azurerm.WindowsWebAppSlot.WindowsWebAppSlotConnectionString[]
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#enabled-1">WindowsWebAppSlot#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#enabled-1">WindowsWebAppSlot#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#ftp_publish_basic_authentication_enabled-1">WindowsWebAppSlot#ftp_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ftp_publish_basic_authentication_enabled">]
        member _.FtpPublishBasicAuthenticationEnabled(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FtpPublishBasicAuthenticationEnabled <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#ftp_publish_basic_authentication_enabled-1">WindowsWebAppSlot#ftp_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ftp_publish_basic_authentication_enabled">]
        member _.FtpPublishBasicAuthenticationEnabled(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FtpPublishBasicAuthenticationEnabled <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#https_only-1">WindowsWebAppSlot#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#https_only-1">WindowsWebAppSlot#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#id-1">WindowsWebAppSlot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#identity-1">WindowsWebAppSlot#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: azurerm.WindowsWebAppSlot.WindowsWebAppSlotIdentity) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#key_vault_reference_identity_id-1">WindowsWebAppSlot#key_vault_reference_identity_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_reference_identity_id">]
        member _.KeyVaultReferenceIdentityId(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.KeyVaultReferenceIdentityId <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#logs-1">WindowsWebAppSlot#logs</a>
        /// </summary>
        [<CustomOperation "logs">]
        member _.Logs(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: azurerm.WindowsWebAppSlot.WindowsWebAppSlotLogs) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Logs <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#public_network_access_enabled-1">WindowsWebAppSlot#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#public_network_access_enabled-1">WindowsWebAppSlot#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#service_plan_id-1">WindowsWebAppSlot#service_plan_id</a>.
        /// </summary>
        [<CustomOperation "service_plan_id">]
        member _.ServicePlanId(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ServicePlanId <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#storage_account-1">WindowsWebAppSlot#storage_account</a> Accepts: azurerm.IResolvable | azurerm.WindowsWebAppSlot.WindowsWebAppSlotStorageAccount[]
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#tags-1">WindowsWebAppSlot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: seq<string * string>) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#timeouts-1">WindowsWebAppSlot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: azurerm.WindowsWebAppSlot.WindowsWebAppSlotTimeouts) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#virtual_network_subnet_id-1">WindowsWebAppSlot#virtual_network_subnet_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_subnet_id">]
        member _.VirtualNetworkSubnetId(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.VirtualNetworkSubnetId <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#webdeploy_publish_basic_authentication_enabled-1">WindowsWebAppSlot#webdeploy_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "webdeploy_publish_basic_authentication_enabled">]
        member _.WebdeployPublishBasicAuthenticationEnabled(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.WebdeployPublishBasicAuthenticationEnabled <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#webdeploy_publish_basic_authentication_enabled-1">WindowsWebAppSlot#webdeploy_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "webdeploy_publish_basic_authentication_enabled">]
        member _.WebdeployPublishBasicAuthenticationEnabled(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.WebdeployPublishBasicAuthenticationEnabled <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// The local path and filename of the Zip packaged application to deploy to this Windows Web App. **Note:** Using this value requires `WEBSITE_RUN_FROM_PACKAGE=1` on the App in `app_settings`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#zip_deploy_file-1">WindowsWebAppSlot#zip_deploy_file</a>
        /// </summary>
        [<CustomOperation "zip_deploy_file">]
        member _.ZipDeployFile(state: WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ZipDeployFile <- value)
            state : WindowsWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        member _.Run(state: WindowsWebAppSlotState<Present, Present, Present>) : azurerm.WindowsWebAppSlot.WindowsWebAppSlot =
            let config = azurerm.WindowsWebAppSlot.WindowsWebAppSlotConfig()
            for setter in state.assignments do
                setter config
            azurerm.WindowsWebAppSlot.WindowsWebAppSlot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.windowsWebAppSlot: missing required arguments. Must call: app_service_id, name, site_config.", 9999, IsError = true)>]
        member _.Run(_: WindowsWebAppSlotState<_, _, _>) : azurerm.WindowsWebAppSlot.WindowsWebAppSlot =
            Unchecked.defaultof<azurerm.WindowsWebAppSlot.WindowsWebAppSlot>
