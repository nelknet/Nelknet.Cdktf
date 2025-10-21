namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> = { assignments: ResizeArray<azurerm.FunctionAppSlot.FunctionAppSlotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot">azurerm_function_app_slot</a>.
    /// </summary>
    type FunctionAppSlotBuilder(logicalId: string) =
        member _.Yield(_: unit) : FunctionAppSlotState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FunctionAppSlotState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FunctionAppSlotState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FunctionAppSlotState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#app_service_plan_id-1">FunctionAppSlot#app_service_plan_id</a>.
        /// </summary>
        [<CustomOperation "app_service_plan_id">]
        member _.AppServicePlanId(state: FunctionAppSlotState<Missing, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppSlotState<Present, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.AppServicePlanId <- value)
            ({ assignments = state.assignments } : FunctionAppSlotState<Present, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#function_app_name-1">FunctionAppSlot#function_app_name</a>.
        /// </summary>
        [<CustomOperation "function_app_name">]
        member _.FunctionAppName(state: FunctionAppSlotState<'AppServicePlanId, Missing, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppSlotState<'AppServicePlanId, Present, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.FunctionAppName <- value)
            ({ assignments = state.assignments } : FunctionAppSlotState<'AppServicePlanId, Present, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#location-1">FunctionAppSlot#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, Missing, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, Present, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, Present, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#name-1">FunctionAppSlot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, Missing, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, Present, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, Present, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#resource_group_name-1">FunctionAppSlot#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, Missing, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, Present, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, Present, 'StorageAccountAccessKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#storage_account_access_key-1">FunctionAppSlot#storage_account_access_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, Missing, 'StorageAccountName>, value: string) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, Present, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            ({ assignments = state.assignments } : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, Present, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#storage_account_name-1">FunctionAppSlot#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, Missing>, value: string) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, Present> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#app_settings-1">FunctionAppSlot#app_settings</a>.
        /// </summary>
        [<CustomOperation "app_settings">]
        member _.AppSettings(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: seq<string * string>) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.AppSettings <- dict value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// auth_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#auth_settings-1">FunctionAppSlot#auth_settings</a>
        /// </summary>
        [<CustomOperation "auth_settings">]
        member _.AuthSettings(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: azurerm.FunctionAppSlot.FunctionAppSlotAuthSettings) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.AuthSettings <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// connection_string block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#connection_string-1">FunctionAppSlot#connection_string</a> Accepts: azurerm.IResolvable | azurerm.FunctionAppSlot.FunctionAppSlotConnectionString[]
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#daily_memory_time_quota-1">FunctionAppSlot#daily_memory_time_quota</a>.
        /// </summary>
        [<CustomOperation "daily_memory_time_quota">]
        member _.DailyMemoryTimeQuota(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: double) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.DailyMemoryTimeQuota <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#enable_builtin_logging-1">FunctionAppSlot#enable_builtin_logging</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_builtin_logging">]
        member _.EnableBuiltinLogging(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: bool) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.EnableBuiltinLogging <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#enable_builtin_logging-1">FunctionAppSlot#enable_builtin_logging</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_builtin_logging">]
        member _.EnableBuiltinLogging(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.EnableBuiltinLogging <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#enabled-1">FunctionAppSlot#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: bool) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#enabled-1">FunctionAppSlot#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#https_only-1">FunctionAppSlot#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: bool) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#https_only-1">FunctionAppSlot#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#id-1">FunctionAppSlot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#identity-1">FunctionAppSlot#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: azurerm.FunctionAppSlot.FunctionAppSlotIdentity) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#os_type-1">FunctionAppSlot#os_type</a>.
        /// </summary>
        [<CustomOperation "os_type">]
        member _.OsType(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.OsType <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// site_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#site_config-1">FunctionAppSlot#site_config</a>
        /// </summary>
        [<CustomOperation "site_config">]
        member _.SiteConfig(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: azurerm.FunctionAppSlot.FunctionAppSlotSiteConfig) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.SiteConfig <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#tags-1">FunctionAppSlot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: seq<string * string>) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#timeouts-1">FunctionAppSlot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: azurerm.FunctionAppSlot.FunctionAppSlotTimeouts) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#version-1">FunctionAppSlot#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : FunctionAppSlotState<'AppServicePlanId, 'FunctionAppName, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        member _.Run(state: FunctionAppSlotState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.FunctionAppSlot.FunctionAppSlot =
            let config = azurerm.FunctionAppSlot.FunctionAppSlotConfig()
            for setter in state.assignments do
                setter config
            azurerm.FunctionAppSlot.FunctionAppSlot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.functionAppSlot: missing required arguments. Must call: app_service_plan_id, function_app_name, location, name, resource_group_name, storage_account_access_key, storage_account_name.", 9999, IsError = true)>]
        member _.Run(_: FunctionAppSlotState<_, _, _, _, _, _, _>) : azurerm.FunctionAppSlot.FunctionAppSlot =
            Unchecked.defaultof<azurerm.FunctionAppSlot.FunctionAppSlot>
