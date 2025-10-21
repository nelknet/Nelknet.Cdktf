namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAppConfigurationKeysState<'ConfigurationStoreId> = { assignments: ResizeArray<azurerm.DataAzurermAppConfigurationKeys.DataAzurermAppConfigurationKeysConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_keys">azurerm_app_configuration_keys</a>.
    /// </summary>
    type DataAzurermAppConfigurationKeysBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAppConfigurationKeysState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppConfigurationKeysState<Missing>)

        member _.Zero(()) : DataAzurermAppConfigurationKeysState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppConfigurationKeysState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_keys#configuration_store_id-1">DataAzurermAppConfigurationKeys#configuration_store_id</a>.
        /// </summary>
        [<CustomOperation "configuration_store_id">]
        member _.ConfigurationStoreId(state: DataAzurermAppConfigurationKeysState<Missing>, value: string) : DataAzurermAppConfigurationKeysState<Present> =
            state.assignments.Add(fun config -> config.ConfigurationStoreId <- value)
            ({ assignments = state.assignments } : DataAzurermAppConfigurationKeysState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_keys#id-1">DataAzurermAppConfigurationKeys#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAppConfigurationKeysState<'ConfigurationStoreId>, value: string) : DataAzurermAppConfigurationKeysState<'ConfigurationStoreId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAppConfigurationKeysState<'ConfigurationStoreId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_keys#key-1">DataAzurermAppConfigurationKeys#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: DataAzurermAppConfigurationKeysState<'ConfigurationStoreId>, value: string) : DataAzurermAppConfigurationKeysState<'ConfigurationStoreId> =
            state.assignments.Add(fun config -> config.Key <- value)
            state : DataAzurermAppConfigurationKeysState<'ConfigurationStoreId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_keys#label-1">DataAzurermAppConfigurationKeys#label</a>.
        /// </summary>
        [<CustomOperation "label">]
        member _.Label(state: DataAzurermAppConfigurationKeysState<'ConfigurationStoreId>, value: string) : DataAzurermAppConfigurationKeysState<'ConfigurationStoreId> =
            state.assignments.Add(fun config -> config.Label <- value)
            state : DataAzurermAppConfigurationKeysState<'ConfigurationStoreId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_keys#timeouts-1">DataAzurermAppConfigurationKeys#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAppConfigurationKeysState<'ConfigurationStoreId>, value: azurerm.DataAzurermAppConfigurationKeys.DataAzurermAppConfigurationKeysTimeouts) : DataAzurermAppConfigurationKeysState<'ConfigurationStoreId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAppConfigurationKeysState<'ConfigurationStoreId>

        member _.Run(state: DataAzurermAppConfigurationKeysState<Present>) : azurerm.DataAzurermAppConfigurationKeys.DataAzurermAppConfigurationKeys =
            let config = azurerm.DataAzurermAppConfigurationKeys.DataAzurermAppConfigurationKeysConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAppConfigurationKeys.DataAzurermAppConfigurationKeys(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAppConfigurationKeys: missing required arguments. Must call: configuration_store_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAppConfigurationKeysState<_>) : azurerm.DataAzurermAppConfigurationKeys.DataAzurermAppConfigurationKeys =
            Unchecked.defaultof<azurerm.DataAzurermAppConfigurationKeys.DataAzurermAppConfigurationKeys>
