namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AppServiceSlot.AppServiceSlotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot">azurerm_app_service_slot</a>.
    /// </summary>
    type AppServiceSlotBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceSlotState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceSlotState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppServiceSlotState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceSlotState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#app_service_name-1">AppServiceSlot#app_service_name</a>.
        /// </summary>
        [<CustomOperation "app_service_name">]
        member _.AppServiceName(state: AppServiceSlotState<Missing, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceSlotState<Present, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppServiceName <- value)
            ({ assignments = state.assignments } : AppServiceSlotState<Present, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#app_service_plan_id-1">AppServiceSlot#app_service_plan_id</a>.
        /// </summary>
        [<CustomOperation "app_service_plan_id">]
        member _.AppServicePlanId(state: AppServiceSlotState<'AppServiceName, Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceSlotState<'AppServiceName, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppServicePlanId <- value)
            ({ assignments = state.assignments } : AppServiceSlotState<'AppServiceName, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#location-1">AppServiceSlot#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, Missing, 'Name, 'ResourceGroupName>, value: string) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#name-1">AppServiceSlot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, Missing, 'ResourceGroupName>, value: string) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#resource_group_name-1">AppServiceSlot#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, Missing>, value: string) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#app_settings-1">AppServiceSlot#app_settings</a>.
        /// </summary>
        [<CustomOperation "app_settings">]
        member _.AppSettings(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppSettings <- dict value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// auth_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#auth_settings-1">AppServiceSlot#auth_settings</a>
        /// </summary>
        [<CustomOperation "auth_settings">]
        member _.AuthSettings(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppServiceSlot.AppServiceSlotAuthSettings) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuthSettings <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#client_affinity_enabled-1">AppServiceSlot#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: bool) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#client_affinity_enabled-1">AppServiceSlot#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// connection_string block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#connection_string-1">AppServiceSlot#connection_string</a> Accepts: azurerm.IResolvable | azurerm.AppServiceSlot.AppServiceSlotConnectionString[]
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#enabled-1">AppServiceSlot#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: bool) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#enabled-1">AppServiceSlot#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#https_only-1">AppServiceSlot#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: bool) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#https_only-1">AppServiceSlot#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#id-1">AppServiceSlot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#identity-1">AppServiceSlot#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppServiceSlot.AppServiceSlotIdentity) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#key_vault_reference_identity_id-1">AppServiceSlot#key_vault_reference_identity_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_reference_identity_id">]
        member _.KeyVaultReferenceIdentityId(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: string) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyVaultReferenceIdentityId <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#logs-1">AppServiceSlot#logs</a>
        /// </summary>
        [<CustomOperation "logs">]
        member _.Logs(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppServiceSlot.AppServiceSlotLogs) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Logs <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// site_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#site_config-1">AppServiceSlot#site_config</a>
        /// </summary>
        [<CustomOperation "site_config">]
        member _.SiteConfig(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppServiceSlot.AppServiceSlotSiteConfig) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SiteConfig <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#storage_account-1">AppServiceSlot#storage_account</a> Accepts: azurerm.IResolvable | azurerm.AppServiceSlot.AppServiceSlotStorageAccount[]
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#tags-1">AppServiceSlot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#timeouts-1">AppServiceSlot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.AppServiceSlot.AppServiceSlotTimeouts) : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceSlotState<'AppServiceName, 'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: AppServiceSlotState<Present, Present, Present, Present, Present>) : azurerm.AppServiceSlot.AppServiceSlot =
            let config = azurerm.AppServiceSlot.AppServiceSlotConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceSlot.AppServiceSlot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceSlot: missing required arguments. Must call: app_service_name, app_service_plan_id, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AppServiceSlotState<_, _, _, _, _>) : azurerm.AppServiceSlot.AppServiceSlot =
            Unchecked.defaultof<azurerm.AppServiceSlot.AppServiceSlot>
