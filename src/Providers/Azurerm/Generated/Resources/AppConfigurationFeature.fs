namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> = { assignments: ResizeArray<azurerm.AppConfigurationFeature.AppConfigurationFeatureConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature">azurerm_app_configuration_feature</a>.
    /// </summary>
    type AppConfigurationFeatureBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppConfigurationFeatureState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppConfigurationFeatureState<Missing, Missing>)

        member _.Zero(()) : AppConfigurationFeatureState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppConfigurationFeatureState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#configuration_store_id-1">AppConfigurationFeature#configuration_store_id</a>.
        /// </summary>
        [<CustomOperation "configuration_store_id">]
        member _.ConfigurationStoreId(state: AppConfigurationFeatureState<Missing, 'Name>, value: string) : AppConfigurationFeatureState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ConfigurationStoreId <- value)
            ({ assignments = state.assignments } : AppConfigurationFeatureState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#name-1">AppConfigurationFeature#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppConfigurationFeatureState<'ConfigurationStoreId, Missing>, value: string) : AppConfigurationFeatureState<'ConfigurationStoreId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppConfigurationFeatureState<'ConfigurationStoreId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#description-1">AppConfigurationFeature#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: string) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#enabled-1">AppConfigurationFeature#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: bool) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#enabled-1">AppConfigurationFeature#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#etag-1">AppConfigurationFeature#etag</a>.
        /// </summary>
        [<CustomOperation "etag">]
        member _.Etag(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: string) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.Etag <- value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#id-1">AppConfigurationFeature#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: string) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#key-1">AppConfigurationFeature#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: string) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.Key <- value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#label-1">AppConfigurationFeature#label</a>.
        /// </summary>
        [<CustomOperation "label">]
        member _.Label(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: string) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.Label <- value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#locked-1">AppConfigurationFeature#locked</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "locked">]
        member _.Locked(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: bool) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.Locked <- value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#locked-1">AppConfigurationFeature#locked</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "locked">]
        member _.Locked(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.Locked <- value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#percentage_filter_value-1">AppConfigurationFeature#percentage_filter_value</a>.
        /// </summary>
        [<CustomOperation "percentage_filter_value">]
        member _.PercentageFilterValue(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: double) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.PercentageFilterValue <- value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#tags-1">AppConfigurationFeature#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: seq<string * string>) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        /// <summary>
        /// targeting_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#targeting_filter-1">AppConfigurationFeature#targeting_filter</a> Accepts: azurerm.IResolvable | azurerm.AppConfigurationFeature.AppConfigurationFeatureTargetingFilter[]
        /// </summary>
        [<CustomOperation "targeting_filter">]
        member _.TargetingFilter(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.TargetingFilter <- value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#timeouts-1">AppConfigurationFeature#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: azurerm.AppConfigurationFeature.AppConfigurationFeatureTimeouts) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        /// <summary>
        /// timewindow_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#timewindow_filter-1">AppConfigurationFeature#timewindow_filter</a> Accepts: azurerm.IResolvable | azurerm.AppConfigurationFeature.AppConfigurationFeatureTimewindowFilter[]
        /// </summary>
        [<CustomOperation "timewindow_filter">]
        member _.TimewindowFilter(state: AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name> =
            state.assignments.Add(fun config -> config.TimewindowFilter <- value)
            state : AppConfigurationFeatureState<'ConfigurationStoreId, 'Name>

        member _.Run(state: AppConfigurationFeatureState<Present, Present>) : azurerm.AppConfigurationFeature.AppConfigurationFeature =
            let config = azurerm.AppConfigurationFeature.AppConfigurationFeatureConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppConfigurationFeature.AppConfigurationFeature(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appConfigurationFeature: missing required arguments. Must call: configuration_store_id, name.", 9999, IsError = true)>]
        member _.Run(_: AppConfigurationFeatureState<_, _>) : azurerm.AppConfigurationFeature.AppConfigurationFeature =
            Unchecked.defaultof<azurerm.AppConfigurationFeature.AppConfigurationFeature>
