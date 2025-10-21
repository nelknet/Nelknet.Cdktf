namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> = { assignments: ResizeArray<azurerm.FunctionApp.FunctionAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app">azurerm_function_app</a>.
    /// </summary>
    type FunctionAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : FunctionAppState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FunctionAppState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FunctionAppState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FunctionAppState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#app_service_plan_id-1">FunctionApp#app_service_plan_id</a>.
        /// </summary>
        [<CustomOperation "app_service_plan_id">]
        member _.AppServicePlanId(state: FunctionAppState<Missing, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppState<Present, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.AppServicePlanId <- value)
            ({ assignments = state.assignments } : FunctionAppState<Present, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#location-1">FunctionApp#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: FunctionAppState<'AppServicePlanId, Missing, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppState<'AppServicePlanId, Present, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : FunctionAppState<'AppServicePlanId, Present, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#name-1">FunctionApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FunctionAppState<'AppServicePlanId, 'Location, Missing, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppState<'AppServicePlanId, 'Location, Present, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FunctionAppState<'AppServicePlanId, 'Location, Present, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#resource_group_name-1">FunctionApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, Missing, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, Present, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : FunctionAppState<'AppServicePlanId, 'Location, 'Name, Present, 'StorageAccountAccessKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#storage_account_access_key-1">FunctionApp#storage_account_access_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, Missing, 'StorageAccountName>, value: string) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, Present, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            ({ assignments = state.assignments } : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, Present, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#storage_account_name-1">FunctionApp#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, Missing>, value: string) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, Present> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#app_settings-1">FunctionApp#app_settings</a>.
        /// </summary>
        [<CustomOperation "app_settings">]
        member _.AppSettings(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: seq<string * string>) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.AppSettings <- dict value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// auth_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#auth_settings-1">FunctionApp#auth_settings</a>
        /// </summary>
        [<CustomOperation "auth_settings">]
        member _.AuthSettings(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: azurerm.FunctionApp.FunctionAppAuthSettings) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.AuthSettings <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#client_cert_mode-1">FunctionApp#client_cert_mode</a>.
        /// </summary>
        [<CustomOperation "client_cert_mode">]
        member _.ClientCertMode(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.ClientCertMode <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// connection_string block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#connection_string-1">FunctionApp#connection_string</a> Accepts: azurerm.IResolvable | azurerm.FunctionApp.FunctionAppConnectionString[]
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#daily_memory_time_quota-1">FunctionApp#daily_memory_time_quota</a>.
        /// </summary>
        [<CustomOperation "daily_memory_time_quota">]
        member _.DailyMemoryTimeQuota(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: double) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.DailyMemoryTimeQuota <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#enable_builtin_logging-1">FunctionApp#enable_builtin_logging</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_builtin_logging">]
        member _.EnableBuiltinLogging(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: bool) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.EnableBuiltinLogging <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#enable_builtin_logging-1">FunctionApp#enable_builtin_logging</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_builtin_logging">]
        member _.EnableBuiltinLogging(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.EnableBuiltinLogging <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#enabled-1">FunctionApp#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: bool) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#enabled-1">FunctionApp#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#https_only-1">FunctionApp#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: bool) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#https_only-1">FunctionApp#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#id-1">FunctionApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#identity-1">FunctionApp#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: azurerm.FunctionApp.FunctionAppIdentity) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#key_vault_reference_identity_id-1">FunctionApp#key_vault_reference_identity_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_reference_identity_id">]
        member _.KeyVaultReferenceIdentityId(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.KeyVaultReferenceIdentityId <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#os_type-1">FunctionApp#os_type</a>.
        /// </summary>
        [<CustomOperation "os_type">]
        member _.OsType(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.OsType <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// site_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#site_config-1">FunctionApp#site_config</a>
        /// </summary>
        [<CustomOperation "site_config">]
        member _.SiteConfig(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: azurerm.FunctionApp.FunctionAppSiteConfig) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.SiteConfig <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// source_control block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#source_control-1">FunctionApp#source_control</a>
        /// </summary>
        [<CustomOperation "source_control">]
        member _.SourceControl(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: azurerm.FunctionApp.FunctionAppSourceControl) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.SourceControl <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#tags-1">FunctionApp#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: seq<string * string>) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#timeouts-1">FunctionApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: azurerm.FunctionApp.FunctionAppTimeouts) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app#version-1">FunctionApp#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : FunctionAppState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        member _.Run(state: FunctionAppState<Present, Present, Present, Present, Present, Present>) : azurerm.FunctionApp.FunctionApp =
            let config = azurerm.FunctionApp.FunctionAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.FunctionApp.FunctionApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.functionApp: missing required arguments. Must call: app_service_plan_id, location, name, resource_group_name, storage_account_access_key, storage_account_name.", 9999, IsError = true)>]
        member _.Run(_: FunctionAppState<_, _, _, _, _, _>) : azurerm.FunctionApp.FunctionApp =
            Unchecked.defaultof<azurerm.FunctionApp.FunctionApp>
