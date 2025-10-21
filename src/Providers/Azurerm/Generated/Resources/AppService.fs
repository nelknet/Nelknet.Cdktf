namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AppService.AppServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service">azurerm_app_service</a>.
    /// </summary>
    type AppServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#app_service_plan_id-1">AppService#app_service_plan_id</a>.
        /// </summary>
        [<CustomOperation "app_service_plan_id">]
        member _.AppServicePlanId(state: AppServiceState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppServicePlanId <- value)
            ({ assignments = state.assignments } : AppServiceState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#location-1">AppService#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AppServiceState<'AppServicePlanId, Missing, 'Name, 'ResourceGroupName>, value: string) : AppServiceState<'AppServicePlanId, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AppServiceState<'AppServicePlanId, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#name-1">AppService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppServiceState<'AppServicePlanId, 'Location, Missing, 'ResourceGroupName>, value: string) : AppServiceState<'AppServicePlanId, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppServiceState<'AppServicePlanId, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#resource_group_name-1">AppService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, Missing>, value: string) : AppServiceState<'AppServicePlanId, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AppServiceState<'AppServicePlanId, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#app_settings-1">AppService#app_settings</a>.
        /// </summary>
        [<CustomOperation "app_settings">]
        member _.AppSettings(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppSettings <- dict value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// auth_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#auth_settings-1">AppService#auth_settings</a>
        /// </summary>
        [<CustomOperation "auth_settings">]
        member _.AuthSettings(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppService.AppServiceAuthSettings) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuthSettings <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// backup block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#backup-1">AppService#backup</a>
        /// </summary>
        [<CustomOperation "backup">]
        member _.Backup(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppService.AppServiceBackup) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Backup <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#client_affinity_enabled-1">AppService#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: bool) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#client_affinity_enabled-1">AppService#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#client_cert_enabled-1">AppService#client_cert_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_cert_enabled">]
        member _.ClientCertEnabled(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: bool) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientCertEnabled <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#client_cert_enabled-1">AppService#client_cert_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_cert_enabled">]
        member _.ClientCertEnabled(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientCertEnabled <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#client_cert_mode-1">AppService#client_cert_mode</a>.
        /// </summary>
        [<CustomOperation "client_cert_mode">]
        member _.ClientCertMode(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientCertMode <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// connection_string block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#connection_string-1">AppService#connection_string</a> Accepts: azurerm.IResolvable | azurerm.AppService.AppServiceConnectionString[]
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#enabled-1">AppService#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: bool) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#enabled-1">AppService#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#https_only-1">AppService#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: bool) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#https_only-1">AppService#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#id-1">AppService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#identity-1">AppService#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppService.AppServiceIdentity) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#key_vault_reference_identity_id-1">AppService#key_vault_reference_identity_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_reference_identity_id">]
        member _.KeyVaultReferenceIdentityId(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyVaultReferenceIdentityId <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#logs-1">AppService#logs</a>
        /// </summary>
        [<CustomOperation "logs">]
        member _.Logs(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppService.AppServiceLogs) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Logs <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// site_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#site_config-1">AppService#site_config</a>
        /// </summary>
        [<CustomOperation "site_config">]
        member _.SiteConfig(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppService.AppServiceSiteConfig) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SiteConfig <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// source_control block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#source_control-1">AppService#source_control</a>
        /// </summary>
        [<CustomOperation "source_control">]
        member _.SourceControl(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppService.AppServiceSourceControl) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceControl <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#storage_account-1">AppService#storage_account</a> Accepts: azurerm.IResolvable | azurerm.AppService.AppServiceStorageAccount[]
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#tags-1">AppService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#timeouts-1">AppService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppService.AppServiceTimeouts) : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: AppServiceState<Present, Present, Present, Present>) : azurerm.AppService.AppService =
            let config = azurerm.AppService.AppServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppService.AppService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appService: missing required arguments. Must call: app_service_plan_id, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AppServiceState<_, _, _, _>) : azurerm.AppService.AppService =
            Unchecked.defaultof<azurerm.AppService.AppService>
