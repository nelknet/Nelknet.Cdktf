namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageEncryptionScopeState<'Name, 'StorageAccountId> = { assignments: ResizeArray<azurerm.DataAzurermStorageEncryptionScope.DataAzurermStorageEncryptionScopeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_encryption_scope">azurerm_storage_encryption_scope</a>.
    /// </summary>
    type DataAzurermStorageEncryptionScopeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageEncryptionScopeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageEncryptionScopeState<Missing, Missing>)

        member _.Zero(()) : DataAzurermStorageEncryptionScopeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageEncryptionScopeState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_encryption_scope#name-1">DataAzurermStorageEncryptionScope#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermStorageEncryptionScopeState<Missing, 'StorageAccountId>, value: string) : DataAzurermStorageEncryptionScopeState<Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermStorageEncryptionScopeState<Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_encryption_scope#storage_account_id-1">DataAzurermStorageEncryptionScope#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: DataAzurermStorageEncryptionScopeState<'Name, Missing>, value: string) : DataAzurermStorageEncryptionScopeState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : DataAzurermStorageEncryptionScopeState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_encryption_scope#id-1">DataAzurermStorageEncryptionScope#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageEncryptionScopeState<'Name, 'StorageAccountId>, value: string) : DataAzurermStorageEncryptionScopeState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageEncryptionScopeState<'Name, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_encryption_scope#timeouts-1">DataAzurermStorageEncryptionScope#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageEncryptionScopeState<'Name, 'StorageAccountId>, value: azurerm.DataAzurermStorageEncryptionScope.DataAzurermStorageEncryptionScopeTimeouts) : DataAzurermStorageEncryptionScopeState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageEncryptionScopeState<'Name, 'StorageAccountId>

        member _.Run(state: DataAzurermStorageEncryptionScopeState<Present, Present>) : azurerm.DataAzurermStorageEncryptionScope.DataAzurermStorageEncryptionScope =
            let config = azurerm.DataAzurermStorageEncryptionScope.DataAzurermStorageEncryptionScopeConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageEncryptionScope.DataAzurermStorageEncryptionScope(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageEncryptionScope: missing required arguments. Must call: name, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageEncryptionScopeState<_, _>) : azurerm.DataAzurermStorageEncryptionScope.DataAzurermStorageEncryptionScope =
            Unchecked.defaultof<azurerm.DataAzurermStorageEncryptionScope.DataAzurermStorageEncryptionScope>
