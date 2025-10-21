namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageTableEntitiesState<'Filter, 'StorageTableId> = { assignments: ResizeArray<azurerm.DataAzurermStorageTableEntities.DataAzurermStorageTableEntitiesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entities">azurerm_storage_table_entities</a>.
    /// </summary>
    type DataAzurermStorageTableEntitiesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageTableEntitiesState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageTableEntitiesState<Missing, Missing>)

        member _.Zero(()) : DataAzurermStorageTableEntitiesState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageTableEntitiesState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entities#filter-1">DataAzurermStorageTableEntities#filter</a>.
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAzurermStorageTableEntitiesState<Missing, 'StorageTableId>, value: string) : DataAzurermStorageTableEntitiesState<Present, 'StorageTableId> =
            state.assignments.Add(fun config -> config.Filter <- value)
            ({ assignments = state.assignments } : DataAzurermStorageTableEntitiesState<Present, 'StorageTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entities#storage_table_id-1">DataAzurermStorageTableEntities#storage_table_id</a>.
        /// </summary>
        [<CustomOperation "storage_table_id">]
        member _.StorageTableId(state: DataAzurermStorageTableEntitiesState<'Filter, Missing>, value: string) : DataAzurermStorageTableEntitiesState<'Filter, Present> =
            state.assignments.Add(fun config -> config.StorageTableId <- value)
            ({ assignments = state.assignments } : DataAzurermStorageTableEntitiesState<'Filter, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entities#id-1">DataAzurermStorageTableEntities#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageTableEntitiesState<'Filter, 'StorageTableId>, value: string) : DataAzurermStorageTableEntitiesState<'Filter, 'StorageTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageTableEntitiesState<'Filter, 'StorageTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entities#select-1">DataAzurermStorageTableEntities#select</a>.
        /// </summary>
        [<CustomOperation "select">]
        member _.Select(state: DataAzurermStorageTableEntitiesState<'Filter, 'StorageTableId>, value: seq<string>) : DataAzurermStorageTableEntitiesState<'Filter, 'StorageTableId> =
            state.assignments.Add(fun config -> config.Select <- (value |> Seq.toArray))
            state : DataAzurermStorageTableEntitiesState<'Filter, 'StorageTableId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entities#timeouts-1">DataAzurermStorageTableEntities#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageTableEntitiesState<'Filter, 'StorageTableId>, value: azurerm.DataAzurermStorageTableEntities.DataAzurermStorageTableEntitiesTimeouts) : DataAzurermStorageTableEntitiesState<'Filter, 'StorageTableId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageTableEntitiesState<'Filter, 'StorageTableId>

        member _.Run(state: DataAzurermStorageTableEntitiesState<Present, Present>) : azurerm.DataAzurermStorageTableEntities.DataAzurermStorageTableEntities =
            let config = azurerm.DataAzurermStorageTableEntities.DataAzurermStorageTableEntitiesConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageTableEntities.DataAzurermStorageTableEntities(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageTableEntities: missing required arguments. Must call: filter, storage_table_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageTableEntitiesState<_, _>) : azurerm.DataAzurermStorageTableEntities.DataAzurermStorageTableEntities =
            Unchecked.defaultof<azurerm.DataAzurermStorageTableEntities.DataAzurermStorageTableEntities>
