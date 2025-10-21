namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAppConfigurationKeyState<'ConfigurationStoreId, 'Key> = { assignments: ResizeArray<azurerm.DataAzurermAppConfigurationKey.DataAzurermAppConfigurationKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_key">azurerm_app_configuration_key</a>.
    /// </summary>
    type DataAzurermAppConfigurationKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAppConfigurationKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppConfigurationKeyState<Missing, Missing>)

        member _.Zero(()) : DataAzurermAppConfigurationKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppConfigurationKeyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_key#configuration_store_id-1">DataAzurermAppConfigurationKey#configuration_store_id</a>.
        /// </summary>
        [<CustomOperation "configuration_store_id">]
        member _.ConfigurationStoreId(state: DataAzurermAppConfigurationKeyState<Missing, 'Key>, value: string) : DataAzurermAppConfigurationKeyState<Present, 'Key> =
            state.assignments.Add(fun config -> config.ConfigurationStoreId <- value)
            ({ assignments = state.assignments } : DataAzurermAppConfigurationKeyState<Present, 'Key>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_key#key-1">DataAzurermAppConfigurationKey#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: DataAzurermAppConfigurationKeyState<'ConfigurationStoreId, Missing>, value: string) : DataAzurermAppConfigurationKeyState<'ConfigurationStoreId, Present> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : DataAzurermAppConfigurationKeyState<'ConfigurationStoreId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_key#id-1">DataAzurermAppConfigurationKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: string) : DataAzurermAppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_key#label-1">DataAzurermAppConfigurationKey#label</a>.
        /// </summary>
        [<CustomOperation "label">]
        member _.Label(state: DataAzurermAppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: string) : DataAzurermAppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.Label <- value)
            state : DataAzurermAppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_key#timeouts-1">DataAzurermAppConfigurationKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: azurerm.DataAzurermAppConfigurationKey.DataAzurermAppConfigurationKeyTimeouts) : DataAzurermAppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        member _.Run(state: DataAzurermAppConfigurationKeyState<Present, Present>) : azurerm.DataAzurermAppConfigurationKey.DataAzurermAppConfigurationKey =
            let config = azurerm.DataAzurermAppConfigurationKey.DataAzurermAppConfigurationKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAppConfigurationKey.DataAzurermAppConfigurationKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAppConfigurationKey: missing required arguments. Must call: configuration_store_id, key.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAppConfigurationKeyState<_, _>) : azurerm.DataAzurermAppConfigurationKey.DataAzurermAppConfigurationKey =
            Unchecked.defaultof<azurerm.DataAzurermAppConfigurationKey.DataAzurermAppConfigurationKey>
