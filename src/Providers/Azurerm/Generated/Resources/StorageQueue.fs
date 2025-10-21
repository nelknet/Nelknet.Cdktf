namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageQueueState<'Name, 'StorageAccountName> = { assignments: ResizeArray<azurerm.StorageQueue.StorageQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_queue">azurerm_storage_queue</a>.
    /// </summary>
    type StorageQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageQueueState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageQueueState<Missing, Missing>)

        member _.Zero(()) : StorageQueueState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageQueueState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_queue#name-1">StorageQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageQueueState<Missing, 'StorageAccountName>, value: string) : StorageQueueState<Present, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageQueueState<Present, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_queue#storage_account_name-1">StorageQueue#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: StorageQueueState<'Name, Missing>, value: string) : StorageQueueState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : StorageQueueState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_queue#id-1">StorageQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageQueueState<'Name, 'StorageAccountName>, value: string) : StorageQueueState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageQueueState<'Name, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_queue#metadata-1">StorageQueue#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: StorageQueueState<'Name, 'StorageAccountName>, value: seq<string * string>) : StorageQueueState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : StorageQueueState<'Name, 'StorageAccountName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_queue#timeouts-1">StorageQueue#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageQueueState<'Name, 'StorageAccountName>, value: azurerm.StorageQueue.StorageQueueTimeouts) : StorageQueueState<'Name, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageQueueState<'Name, 'StorageAccountName>

        member _.Run(state: StorageQueueState<Present, Present>) : azurerm.StorageQueue.StorageQueue =
            let config = azurerm.StorageQueue.StorageQueueConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageQueue.StorageQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageQueue: missing required arguments. Must call: name, storage_account_name.", 9999, IsError = true)>]
        member _.Run(_: StorageQueueState<_, _>) : azurerm.StorageQueue.StorageQueue =
            Unchecked.defaultof<azurerm.StorageQueue.StorageQueue>
