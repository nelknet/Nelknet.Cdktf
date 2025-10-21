namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> = { assignments: ResizeArray<azurerm.LinuxWebApp.LinuxWebAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app">azurerm_linux_web_app</a>.
    /// </summary>
    type LinuxWebAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : LinuxWebAppState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LinuxWebAppState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LinuxWebAppState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LinuxWebAppState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#location-1">LinuxWebApp#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LinuxWebAppState<Missing, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : LinuxWebAppState<Present, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : LinuxWebAppState<Present, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#name-1">LinuxWebApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LinuxWebAppState<'Location, Missing, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : LinuxWebAppState<'Location, Present, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LinuxWebAppState<'Location, Present, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#resource_group_name-1">LinuxWebApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LinuxWebAppState<'Location, 'Name, Missing, 'ServicePlanId, 'SiteConfig>, value: string) : LinuxWebAppState<'Location, 'Name, Present, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LinuxWebAppState<'Location, 'Name, Present, 'ServicePlanId, 'SiteConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#service_plan_id-1">LinuxWebApp#service_plan_id</a>.
        /// </summary>
        [<CustomOperation "service_plan_id">]
        member _.ServicePlanId(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, Missing, 'SiteConfig>, value: string) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, Present, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ServicePlanId <- value)
            ({ assignments = state.assignments } : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, Present, 'SiteConfig>)

        /// <summary>
        /// site_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#site_config-1">LinuxWebApp#site_config</a>
        /// </summary>
        [<CustomOperation "site_config">]
        member _.SiteConfig(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, Missing>, value: azurerm.LinuxWebApp.LinuxWebAppSiteConfig) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, Present> =
            state.assignments.Add(fun config -> config.SiteConfig <- value)
            ({ assignments = state.assignments } : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#app_settings-1">LinuxWebApp#app_settings</a>.
        /// </summary>
        [<CustomOperation "app_settings">]
        member _.AppSettings(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: seq<string * string>) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AppSettings <- dict value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// auth_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#auth_settings-1">LinuxWebApp#auth_settings</a>
        /// </summary>
        [<CustomOperation "auth_settings">]
        member _.AuthSettings(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.LinuxWebApp.LinuxWebAppAuthSettings) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AuthSettings <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// auth_settings_v2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#auth_settings_v2-1">LinuxWebApp#auth_settings_v2</a>
        /// </summary>
        [<CustomOperation "auth_settings_v2">]
        member _.AuthSettingsV2(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.LinuxWebApp.LinuxWebAppAuthSettingsV2) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.AuthSettingsV2 <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// backup block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#backup-1">LinuxWebApp#backup</a>
        /// </summary>
        [<CustomOperation "backup">]
        member _.Backup(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.LinuxWebApp.LinuxWebAppBackup) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Backup <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#client_affinity_enabled-1">LinuxWebApp#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#client_affinity_enabled-1">LinuxWebApp#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#client_certificate_enabled-1">LinuxWebApp#client_certificate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#client_certificate_enabled-1">LinuxWebApp#client_certificate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Paths to exclude when using client certificates, separated by ; Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#client_certificate_exclusion_paths-1">LinuxWebApp#client_certificate_exclusion_paths</a>
        /// </summary>
        [<CustomOperation "client_certificate_exclusion_paths">]
        member _.ClientCertificateExclusionPaths(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateExclusionPaths <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#client_certificate_mode-1">LinuxWebApp#client_certificate_mode</a>.
        /// </summary>
        [<CustomOperation "client_certificate_mode">]
        member _.ClientCertificateMode(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ClientCertificateMode <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// connection_string block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#connection_string-1">LinuxWebApp#connection_string</a> Accepts: azurerm.IResolvable | azurerm.LinuxWebApp.LinuxWebAppConnectionString[]
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#enabled-1">LinuxWebApp#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#enabled-1">LinuxWebApp#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#ftp_publish_basic_authentication_enabled-1">LinuxWebApp#ftp_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ftp_publish_basic_authentication_enabled">]
        member _.FtpPublishBasicAuthenticationEnabled(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FtpPublishBasicAuthenticationEnabled <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#ftp_publish_basic_authentication_enabled-1">LinuxWebApp#ftp_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ftp_publish_basic_authentication_enabled">]
        member _.FtpPublishBasicAuthenticationEnabled(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.FtpPublishBasicAuthenticationEnabled <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#https_only-1">LinuxWebApp#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#https_only-1">LinuxWebApp#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#id-1">LinuxWebApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#identity-1">LinuxWebApp#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.LinuxWebApp.LinuxWebAppIdentity) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#key_vault_reference_identity_id-1">LinuxWebApp#key_vault_reference_identity_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_reference_identity_id">]
        member _.KeyVaultReferenceIdentityId(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.KeyVaultReferenceIdentityId <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#logs-1">LinuxWebApp#logs</a>
        /// </summary>
        [<CustomOperation "logs">]
        member _.Logs(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.LinuxWebApp.LinuxWebAppLogs) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Logs <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#public_network_access_enabled-1">LinuxWebApp#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#public_network_access_enabled-1">LinuxWebApp#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// sticky_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#sticky_settings-1">LinuxWebApp#sticky_settings</a>
        /// </summary>
        [<CustomOperation "sticky_settings">]
        member _.StickySettings(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.LinuxWebApp.LinuxWebAppStickySettings) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StickySettings <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#storage_account-1">LinuxWebApp#storage_account</a> Accepts: azurerm.IResolvable | azurerm.LinuxWebApp.LinuxWebAppStorageAccount[]
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#tags-1">LinuxWebApp#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: seq<string * string>) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#timeouts-1">LinuxWebApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: azurerm.LinuxWebApp.LinuxWebAppTimeouts) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#virtual_network_subnet_id-1">LinuxWebApp#virtual_network_subnet_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_subnet_id">]
        member _.VirtualNetworkSubnetId(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.VirtualNetworkSubnetId <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#webdeploy_publish_basic_authentication_enabled-1">LinuxWebApp#webdeploy_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "webdeploy_publish_basic_authentication_enabled">]
        member _.WebdeployPublishBasicAuthenticationEnabled(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: bool) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.WebdeployPublishBasicAuthenticationEnabled <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#webdeploy_publish_basic_authentication_enabled-1">LinuxWebApp#webdeploy_publish_basic_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "webdeploy_publish_basic_authentication_enabled">]
        member _.WebdeployPublishBasicAuthenticationEnabled(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: HashiCorp.Cdktf.IResolvable) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.WebdeployPublishBasicAuthenticationEnabled <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        /// <summary>
        /// The local path and filename of the Zip packaged application to deploy to this Linux Web App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#zip_deploy_file-1">LinuxWebApp#zip_deploy_file</a>
        /// </summary>
        [<CustomOperation "zip_deploy_file">]
        member _.ZipDeployFile(state: LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>, value: string) : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig> =
            state.assignments.Add(fun config -> config.ZipDeployFile <- value)
            state : LinuxWebAppState<'Location, 'Name, 'ResourceGroupName, 'ServicePlanId, 'SiteConfig>

        member _.Run(state: LinuxWebAppState<Present, Present, Present, Present, Present>) : azurerm.LinuxWebApp.LinuxWebApp =
            let config = azurerm.LinuxWebApp.LinuxWebAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.LinuxWebApp.LinuxWebApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.linuxWebApp: missing required arguments. Must call: location, name, resource_group_name, service_plan_id, site_config.", 9999, IsError = true)>]
        member _.Run(_: LinuxWebAppState<_, _, _, _, _>) : azurerm.LinuxWebApp.LinuxWebApp =
            Unchecked.defaultof<azurerm.LinuxWebApp.LinuxWebApp>
