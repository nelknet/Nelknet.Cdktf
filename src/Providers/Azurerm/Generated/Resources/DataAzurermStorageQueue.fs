namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageQueueState<'Name, 'StorageAccountName> = { assignments: ResizeArray<azurerm.DataAzurermStorageQueue.DataAzurermStorageQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_queue">azurerm_storage_queue</a>.
    /// </summary>
    type DataAzurermStorageQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageQueueState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageQueueState<Missing, Missing>)

        member _.Zero(()) : DataAzurermStorageQueueState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageQueueState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_queue#name-1">DataAzurermStorageQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermStorageQueueState<Missing, 'StorageAccountName>, value: string) : DataAzurermStorageQueueState<Present, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermStorageQueueState<Present, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_queue#storage_account_name-1">DataAzurermStorageQueue#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: DataAzurermStorageQueueState<'Name, Missing>, value: string) : DataAzurermStorageQueueState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermStorageQueueState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_queue#id-1">DataAzurermStorageQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageQueueState<'Name, 'StorageAccountName>, value: string) : DataAzurermStorageQueueState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageQueueState<'Name, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_queue#metadata-1">DataAzurermStorageQueue#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: DataAzurermStorageQueueState<'Name, 'StorageAccountName>, value: seq<string * string>) : DataAzurermStorageQueueState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : DataAzurermStorageQueueState<'Name, 'StorageAccountName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_queue#timeouts-1">DataAzurermStorageQueue#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageQueueState<'Name, 'StorageAccountName>, value: azurerm.DataAzurermStorageQueue.DataAzurermStorageQueueTimeouts) : DataAzurermStorageQueueState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageQueueState<'Name, 'StorageAccountName>

        member _.Run(state: DataAzurermStorageQueueState<Present, Present>) : azurerm.DataAzurermStorageQueue.DataAzurermStorageQueue =
            let config = azurerm.DataAzurermStorageQueue.DataAzurermStorageQueueConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageQueue.DataAzurermStorageQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageQueue: missing required arguments. Must call: name, storage_account_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageQueueState<_, _>) : azurerm.DataAzurermStorageQueue.DataAzurermStorageQueue =
            Unchecked.defaultof<azurerm.DataAzurermStorageQueue.DataAzurermStorageQueue>
