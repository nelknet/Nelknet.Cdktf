namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageTableEntityState<'PartitionKey, 'RowKey, 'StorageTableId> = { assignments: ResizeArray<azurerm.DataAzurermStorageTableEntity.DataAzurermStorageTableEntityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entity">azurerm_storage_table_entity</a>.
    /// </summary>
    type DataAzurermStorageTableEntityBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageTableEntityState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageTableEntityState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermStorageTableEntityState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageTableEntityState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entity#partition_key-1">DataAzurermStorageTableEntity#partition_key</a>.
        /// </summary>
        [<CustomOperation "partition_key">]
        member _.PartitionKey(state: DataAzurermStorageTableEntityState<Missing, 'RowKey, 'StorageTableId>, value: string) : DataAzurermStorageTableEntityState<Present, 'RowKey, 'StorageTableId> =
            state.assignments.Add(fun config -> config.PartitionKey <- value)
            ({ assignments = state.assignments } : DataAzurermStorageTableEntityState<Present, 'RowKey, 'StorageTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entity#row_key-1">DataAzurermStorageTableEntity#row_key</a>.
        /// </summary>
        [<CustomOperation "row_key">]
        member _.RowKey(state: DataAzurermStorageTableEntityState<'PartitionKey, Missing, 'StorageTableId>, value: string) : DataAzurermStorageTableEntityState<'PartitionKey, Present, 'StorageTableId> =
            state.assignments.Add(fun config -> config.RowKey <- value)
            ({ assignments = state.assignments } : DataAzurermStorageTableEntityState<'PartitionKey, Present, 'StorageTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entity#storage_table_id-1">DataAzurermStorageTableEntity#storage_table_id</a>.
        /// </summary>
        [<CustomOperation "storage_table_id">]
        member _.StorageTableId(state: DataAzurermStorageTableEntityState<'PartitionKey, 'RowKey, Missing>, value: string) : DataAzurermStorageTableEntityState<'PartitionKey, 'RowKey, Present> =
            state.assignments.Add(fun config -> config.StorageTableId <- value)
            ({ assignments = state.assignments } : DataAzurermStorageTableEntityState<'PartitionKey, 'RowKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entity#id-1">DataAzurermStorageTableEntity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageTableEntityState<'PartitionKey, 'RowKey, 'StorageTableId>, value: string) : DataAzurermStorageTableEntityState<'PartitionKey, 'RowKey, 'StorageTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageTableEntityState<'PartitionKey, 'RowKey, 'StorageTableId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entity#timeouts-1">DataAzurermStorageTableEntity#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageTableEntityState<'PartitionKey, 'RowKey, 'StorageTableId>, value: azurerm.DataAzurermStorageTableEntity.DataAzurermStorageTableEntityTimeouts) : DataAzurermStorageTableEntityState<'PartitionKey, 'RowKey, 'StorageTableId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageTableEntityState<'PartitionKey, 'RowKey, 'StorageTableId>

        member _.Run(state: DataAzurermStorageTableEntityState<Present, Present, Present>) : azurerm.DataAzurermStorageTableEntity.DataAzurermStorageTableEntity =
            let config = azurerm.DataAzurermStorageTableEntity.DataAzurermStorageTableEntityConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageTableEntity.DataAzurermStorageTableEntity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageTableEntity: missing required arguments. Must call: partition_key, row_key, storage_table_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageTableEntityState<_, _, _>) : azurerm.DataAzurermStorageTableEntity.DataAzurermStorageTableEntity =
            Unchecked.defaultof<azurerm.DataAzurermStorageTableEntity.DataAzurermStorageTableEntity>
