namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> = { assignments: ResizeArray<azurerm.LinuxWebAppSlot.LinuxWebAppSlotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot">azurerm_linux_web_app_slot</a>.
    /// </summary>
    type LinuxWebAppSlotBuilder(logicalId: string) =
        member _.Yield(_: unit) : LinuxWebAppSlotState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LinuxWebAppSlotState<Missing, Missing, Missing>)

        member _.Zero(()) : LinuxWebAppSlotState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LinuxWebAppSlotState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#app_service_id-1">LinuxWebAppSlot#app_service_id</a>.
        /// </summary>
        [<CustomOperation "app_service_id">]
        member _.AppServiceId(state: LinuxWebAppSlotState<Missing, 'Name, 'SiteConfig>, value: string) : LinuxWebAppSlotState<Present, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AppServiceId <- value)
            ({ assignments = state.assignments } : LinuxWebAppSlotState<Present, 'Name, 'SiteConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#name-1">LinuxWebAppSlot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LinuxWebAppSlotState<'AppServiceId, Missing, 'SiteConfig>, value: string) : LinuxWebAppSlotState<'AppServiceId, Present, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LinuxWebAppSlotState<'AppServiceId, Present, 'SiteConfig>)

        /// <summary>
        /// site_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#site_config-1">LinuxWebAppSlot#site_config</a>
        /// </summary>
        [<CustomOperation "site_config">]
        member _.SiteConfig(state: LinuxWebAppSlotState<'AppServiceId, 'Name, Missing>, value: azurerm.LinuxWebAppSlot.LinuxWebAppSlotSiteConfig) : LinuxWebAppSlotState<'AppServiceId, 'Name, Present> =
            state.assignments.Add(fun config -> config.SiteConfig <- value)
            ({ assignments = state.assignments } : LinuxWebAppSlotState<'AppServiceId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#app_settings-1">LinuxWebAppSlot#app_settings</a>.
        /// </summary>
        [<CustomOperation "app_settings">]
        member _.AppSettings(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: seq<string * string>) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AppSettings <- dict value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// auth_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#auth_settings-1">LinuxWebAppSlot#auth_settings</a>
        /// </summary>
        [<CustomOperation "auth_settings">]
        member _.AuthSettings(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: azurerm.LinuxWebAppSlot.LinuxWebAppSlotAuthSettings) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AuthSettings <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// auth_settings_v2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#auth_settings_v2-1">LinuxWebAppSlot#auth_settings_v2</a>
        /// </summary>
        [<CustomOperation "auth_settings_v2">]
        member _.AuthSettingsV2(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: azurerm.LinuxWebAppSlot.LinuxWebAppSlotAuthSettingsV2) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AuthSettingsV2 <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// backup block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#backup-1">LinuxWebAppSlot#backup</a>
        /// </summary>
        [<CustomOperation "backup">]
        member _.Backup(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: azurerm.LinuxWebAppSlot.LinuxWebAppSlotBackup) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Backup <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#client_affinity_enabled-1">LinuxWebAppSlot#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#client_affinity_enabled-1">LinuxWebAppSlot#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#client_certificate_enabled-1">LinuxWebAppSlot#client_certificate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#client_certificate_enabled-1">LinuxWebAppSlot#client_certificate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Paths to exclude when using client certificates, separated by ; Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#client_certificate_exclusion_paths-1">LinuxWebAppSlot#client_certificate_exclusion_paths</a>
        /// </summary>
        [<CustomOperation "client_certificate_exclusion_paths">]
        member _.ClientCertificateExclusionPaths(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateExclusionPaths <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#client_certificate_mode-1">LinuxWebAppSlot#client_certificate_mode</a>.
        /// </summary>
        [<CustomOperation "client_certificate_mode">]
        member _.ClientCertificateMode(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateMode <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// connection_string block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#connection_string-1">LinuxWebAppSlot#connection_string</a> Accepts: azurerm.IResolvable | azurerm.LinuxWebAppSlot.LinuxWebAppSlotConnectionString[]
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#enabled-1">LinuxWebAppSlot#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#enabled-1">LinuxWebAppSlot#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#ftp_publish_basic_authentication_enabled-1">LinuxWebAppSlot#ftp_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ftp_publish_basic_authentication_enabled">]
        member _.FtpPublishBasicAuthenticationEnabled(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FtpPublishBasicAuthenticationEnabled <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#ftp_publish_basic_authentication_enabled-1">LinuxWebAppSlot#ftp_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ftp_publish_basic_authentication_enabled">]
        member _.FtpPublishBasicAuthenticationEnabled(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FtpPublishBasicAuthenticationEnabled <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#https_only-1">LinuxWebAppSlot#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#https_only-1">LinuxWebAppSlot#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#id-1">LinuxWebAppSlot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#identity-1">LinuxWebAppSlot#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: azurerm.LinuxWebAppSlot.LinuxWebAppSlotIdentity) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#key_vault_reference_identity_id-1">LinuxWebAppSlot#key_vault_reference_identity_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_reference_identity_id">]
        member _.KeyVaultReferenceIdentityId(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.KeyVaultReferenceIdentityId <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#logs-1">LinuxWebAppSlot#logs</a>
        /// </summary>
        [<CustomOperation "logs">]
        member _.Logs(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: azurerm.LinuxWebAppSlot.LinuxWebAppSlotLogs) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Logs <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#public_network_access_enabled-1">LinuxWebAppSlot#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#public_network_access_enabled-1">LinuxWebAppSlot#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#service_plan_id-1">LinuxWebAppSlot#service_plan_id</a>.
        /// </summary>
        [<CustomOperation "service_plan_id">]
        member _.ServicePlanId(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ServicePlanId <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#storage_account-1">LinuxWebAppSlot#storage_account</a> Accepts: azurerm.IResolvable | azurerm.LinuxWebAppSlot.LinuxWebAppSlotStorageAccount[]
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#tags-1">LinuxWebAppSlot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: seq<string * string>) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#timeouts-1">LinuxWebAppSlot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: azurerm.LinuxWebAppSlot.LinuxWebAppSlotTimeouts) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#virtual_network_subnet_id-1">LinuxWebAppSlot#virtual_network_subnet_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_subnet_id">]
        member _.VirtualNetworkSubnetId(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.VirtualNetworkSubnetId <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#webdeploy_publish_basic_authentication_enabled-1">LinuxWebAppSlot#webdeploy_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "webdeploy_publish_basic_authentication_enabled">]
        member _.WebdeployPublishBasicAuthenticationEnabled(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: bool) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.WebdeployPublishBasicAuthenticationEnabled <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#webdeploy_publish_basic_authentication_enabled-1">LinuxWebAppSlot#webdeploy_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "webdeploy_publish_basic_authentication_enabled">]
        member _.WebdeployPublishBasicAuthenticationEnabled(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.WebdeployPublishBasicAuthenticationEnabled <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        /// <summary>
        /// The local path and filename of the Zip packaged application to deploy to this Windows Web App. **Note:** Using this value requires `WEBSITE_RUN_FROM_PACKAGE=1` on the App in `app_settings`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#zip_deploy_file-1">LinuxWebAppSlot#zip_deploy_file</a>
        /// </summary>
        [<CustomOperation "zip_deploy_file">]
        member _.ZipDeployFile(state: LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>, value: string) : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ZipDeployFile <- value)
            state : LinuxWebAppSlotState<'AppServiceId, 'Name, 'SiteConfig>

        member _.Run(state: LinuxWebAppSlotState<Present, Present, Present>) : azurerm.LinuxWebAppSlot.LinuxWebAppSlot =
            let config = azurerm.LinuxWebAppSlot.LinuxWebAppSlotConfig()
            for setter in state.assignments do
                setter config
            azurerm.LinuxWebAppSlot.LinuxWebAppSlot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.linuxWebAppSlot: missing required arguments. Must call: app_service_id, name, site_config.", 9999, IsError = true)>]
        member _.Run(_: LinuxWebAppSlotState<_, _, _>) : azurerm.LinuxWebAppSlot.LinuxWebAppSlot =
            Unchecked.defaultof<azurerm.LinuxWebAppSlot.LinuxWebAppSlot>
