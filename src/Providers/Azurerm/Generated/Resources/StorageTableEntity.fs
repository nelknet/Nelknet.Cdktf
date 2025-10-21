namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageTableEntityState<'Entity, 'PartitionKey, 'RowKey, 'StorageTableId> = { assignments: ResizeArray<azurerm.StorageTableEntity.StorageTableEntityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table_entity">azurerm_storage_table_entity</a>.
    /// </summary>
    type StorageTableEntityBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageTableEntityState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageTableEntityState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StorageTableEntityState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageTableEntityState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table_entity#entity-1">StorageTableEntity#entity</a>.
        /// </summary>
        [<CustomOperation "entity">]
        member _.Entity(state: StorageTableEntityState<Missing, 'PartitionKey, 'RowKey, 'StorageTableId>, value: seq<string * string>) : StorageTableEntityState<Present, 'PartitionKey, 'RowKey, 'StorageTableId> =
            state.assignments.Add(fun config -> config.Entity <- dict value)
            ({ assignments = state.assignments } : StorageTableEntityState<Present, 'PartitionKey, 'RowKey, 'StorageTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table_entity#partition_key-1">StorageTableEntity#partition_key</a>.
        /// </summary>
        [<CustomOperation "partition_key">]
        member _.PartitionKey(state: StorageTableEntityState<'Entity, Missing, 'RowKey, 'StorageTableId>, value: string) : StorageTableEntityState<'Entity, Present, 'RowKey, 'StorageTableId> =
            state.assignments.Add(fun config -> config.PartitionKey <- value)
            ({ assignments = state.assignments } : StorageTableEntityState<'Entity, Present, 'RowKey, 'StorageTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table_entity#row_key-1">StorageTableEntity#row_key</a>.
        /// </summary>
        [<CustomOperation "row_key">]
        member _.RowKey(state: StorageTableEntityState<'Entity, 'PartitionKey, Missing, 'StorageTableId>, value: string) : StorageTableEntityState<'Entity, 'PartitionKey, Present, 'StorageTableId> =
            state.assignments.Add(fun config -> config.RowKey <- value)
            ({ assignments = state.assignments } : StorageTableEntityState<'Entity, 'PartitionKey, Present, 'StorageTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table_entity#storage_table_id-1">StorageTableEntity#storage_table_id</a>.
        /// </summary>
        [<CustomOperation "storage_table_id">]
        member _.StorageTableId(state: StorageTableEntityState<'Entity, 'PartitionKey, 'RowKey, Missing>, value: string) : StorageTableEntityState<'Entity, 'PartitionKey, 'RowKey, Present> =
            state.assignments.Add(fun config -> config.StorageTableId <- value)
            ({ assignments = state.assignments } : StorageTableEntityState<'Entity, 'PartitionKey, 'RowKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table_entity#id-1">StorageTableEntity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageTableEntityState<'Entity, 'PartitionKey, 'RowKey, 'StorageTableId>, value: string) : StorageTableEntityState<'Entity, 'PartitionKey, 'RowKey, 'StorageTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageTableEntityState<'Entity, 'PartitionKey, 'RowKey, 'StorageTableId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_table_entity#timeouts-1">StorageTableEntity#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageTableEntityState<'Entity, 'PartitionKey, 'RowKey, 'StorageTableId>, value: azurerm.StorageTableEntity.StorageTableEntityTimeouts) : StorageTableEntityState<'Entity, 'PartitionKey, 'RowKey, 'StorageTableId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageTableEntityState<'Entity, 'PartitionKey, 'RowKey, 'StorageTableId>

        member _.Run(state: StorageTableEntityState<Present, Present, Present, Present>) : azurerm.StorageTableEntity.StorageTableEntity =
            let config = azurerm.StorageTableEntity.StorageTableEntityConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageTableEntity.StorageTableEntity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageTableEntity: missing required arguments. Must call: entity, partition_key, row_key, storage_table_id.", 9999, IsError = true)>]
        member _.Run(_: StorageTableEntityState<_, _, _, _>) : azurerm.StorageTableEntity.StorageTableEntity =
            Unchecked.defaultof<azurerm.StorageTableEntity.StorageTableEntity>
