namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> = { assignments: ResizeArray<azurerm.LogicAppStandard.LogicAppStandardConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard">azurerm_logic_app_standard</a>.
    /// </summary>
    type LogicAppStandardBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppStandardState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppStandardState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppStandardState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppStandardState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#app_service_plan_id-1">LogicAppStandard#app_service_plan_id</a>.
        /// </summary>
        [<CustomOperation "app_service_plan_id">]
        member _.AppServicePlanId(state: LogicAppStandardState<Missing, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : LogicAppStandardState<Present, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.AppServicePlanId <- value)
            ({ assignments = state.assignments } : LogicAppStandardState<Present, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#location-1">LogicAppStandard#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LogicAppStandardState<'AppServicePlanId, Missing, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : LogicAppStandardState<'AppServicePlanId, Present, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : LogicAppStandardState<'AppServicePlanId, Present, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#name-1">LogicAppStandard#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppStandardState<'AppServicePlanId, 'Location, Missing, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : LogicAppStandardState<'AppServicePlanId, 'Location, Present, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppStandardState<'AppServicePlanId, 'Location, Present, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#resource_group_name-1">LogicAppStandard#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, Missing, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, Present, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, Present, 'StorageAccountAccessKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#storage_account_access_key-1">LogicAppStandard#storage_account_access_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, Missing, 'StorageAccountName>, value: string) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, Present, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            ({ assignments = state.assignments } : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, Present, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#storage_account_name-1">LogicAppStandard#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, Missing>, value: string) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, Present> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#app_settings-1">LogicAppStandard#app_settings</a>.
        /// </summary>
        [<CustomOperation "app_settings">]
        member _.AppSettings(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: seq<string * string>) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.AppSettings <- dict value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#bundle_version-1">LogicAppStandard#bundle_version</a>.
        /// </summary>
        [<CustomOperation "bundle_version">]
        member _.BundleVersion(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.BundleVersion <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#client_affinity_enabled-1">LogicAppStandard#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: bool) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#client_affinity_enabled-1">LogicAppStandard#client_affinity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_affinity_enabled">]
        member _.ClientAffinityEnabled(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.ClientAffinityEnabled <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#client_certificate_mode-1">LogicAppStandard#client_certificate_mode</a>.
        /// </summary>
        [<CustomOperation "client_certificate_mode">]
        member _.ClientCertificateMode(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.ClientCertificateMode <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// connection_string block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#connection_string-1">LogicAppStandard#connection_string</a> Accepts: azurerm.IResolvable | azurerm.LogicAppStandard.LogicAppStandardConnectionString[]
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#enabled-1">LogicAppStandard#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: bool) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#enabled-1">LogicAppStandard#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#https_only-1">LogicAppStandard#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: bool) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#https_only-1">LogicAppStandard#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#id-1">LogicAppStandard#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#identity-1">LogicAppStandard#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: azurerm.LogicAppStandard.LogicAppStandardIdentity) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// site_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#site_config-1">LogicAppStandard#site_config</a>
        /// </summary>
        [<CustomOperation "site_config">]
        member _.SiteConfig(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: azurerm.LogicAppStandard.LogicAppStandardSiteConfig) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.SiteConfig <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#storage_account_share_name-1">LogicAppStandard#storage_account_share_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_share_name">]
        member _.StorageAccountShareName(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.StorageAccountShareName <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#tags-1">LogicAppStandard#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: seq<string * string>) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#timeouts-1">LogicAppStandard#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: azurerm.LogicAppStandard.LogicAppStandardTimeouts) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#use_extension_bundle-1">LogicAppStandard#use_extension_bundle</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_extension_bundle">]
        member _.UseExtensionBundle(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: bool) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.UseExtensionBundle <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#use_extension_bundle-1">LogicAppStandard#use_extension_bundle</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_extension_bundle">]
        member _.UseExtensionBundle(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.UseExtensionBundle <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#version-1">LogicAppStandard#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_standard#virtual_network_subnet_id-1">LogicAppStandard#virtual_network_subnet_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_subnet_id">]
        member _.VirtualNetworkSubnetId(state: LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>, value: string) : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.VirtualNetworkSubnetId <- value)
            state : LogicAppStandardState<'AppServicePlanId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountAccessKey, 'StorageAccountName>

        member _.Run(state: LogicAppStandardState<Present, Present, Present, Present, Present, Present>) : azurerm.LogicAppStandard.LogicAppStandard =
            let config = azurerm.LogicAppStandard.LogicAppStandardConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppStandard.LogicAppStandard(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppStandard: missing required arguments. Must call: app_service_plan_id, location, name, resource_group_name, storage_account_access_key, storage_account_name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppStandardState<_, _, _, _, _, _>) : azurerm.LogicAppStandard.LogicAppStandard =
            Unchecked.defaultof<azurerm.LogicAppStandard.LogicAppStandard>
