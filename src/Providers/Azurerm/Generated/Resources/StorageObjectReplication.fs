namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageObjectReplicationState<'DestinationStorageAccountId, 'Rules, 'SourceStorageAccountId> = { assignments: ResizeArray<azurerm.StorageObjectReplication.StorageObjectReplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication">azurerm_storage_object_replication</a>.
    /// </summary>
    type StorageObjectReplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageObjectReplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageObjectReplicationState<Missing, Missing, Missing>)

        member _.Zero(()) : StorageObjectReplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageObjectReplicationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#destination_storage_account_id-1">StorageObjectReplication#destination_storage_account_id</a>.
        /// </summary>
        [<CustomOperation "destination_storage_account_id">]
        member _.DestinationStorageAccountId(state: StorageObjectReplicationState<Missing, 'Rules, 'SourceStorageAccountId>, value: string) : StorageObjectReplicationState<Present, 'Rules, 'SourceStorageAccountId> =
            state.assignments.Add(fun config -> config.DestinationStorageAccountId <- value)
            ({ assignments = state.assignments } : StorageObjectReplicationState<Present, 'Rules, 'SourceStorageAccountId>)

        /// <summary>
        /// rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#rules-1">StorageObjectReplication#rules</a> Accepts: azurerm.IResolvable | azurerm.StorageObjectReplication.StorageObjectReplicationRules[]
        /// </summary>
        [<CustomOperation "rules">]
        member _.Rules(state: StorageObjectReplicationState<'DestinationStorageAccountId, Missing, 'SourceStorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : StorageObjectReplicationState<'DestinationStorageAccountId, Present, 'SourceStorageAccountId> =
            state.assignments.Add(fun config -> config.Rules <- value)
            ({ assignments = state.assignments } : StorageObjectReplicationState<'DestinationStorageAccountId, Present, 'SourceStorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#source_storage_account_id-1">StorageObjectReplication#source_storage_account_id</a>.
        /// </summary>
        [<CustomOperation "source_storage_account_id">]
        member _.SourceStorageAccountId(state: StorageObjectReplicationState<'DestinationStorageAccountId, 'Rules, Missing>, value: string) : StorageObjectReplicationState<'DestinationStorageAccountId, 'Rules, Present> =
            state.assignments.Add(fun config -> config.SourceStorageAccountId <- value)
            ({ assignments = state.assignments } : StorageObjectReplicationState<'DestinationStorageAccountId, 'Rules, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#id-1">StorageObjectReplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageObjectReplicationState<'DestinationStorageAccountId, 'Rules, 'SourceStorageAccountId>, value: string) : StorageObjectReplicationState<'DestinationStorageAccountId, 'Rules, 'SourceStorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageObjectReplicationState<'DestinationStorageAccountId, 'Rules, 'SourceStorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_object_replication#timeouts-1">StorageObjectReplication#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageObjectReplicationState<'DestinationStorageAccountId, 'Rules, 'SourceStorageAccountId>, value: azurerm.StorageObjectReplication.StorageObjectReplicationTimeouts) : StorageObjectReplicationState<'DestinationStorageAccountId, 'Rules, 'SourceStorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageObjectReplicationState<'DestinationStorageAccountId, 'Rules, 'SourceStorageAccountId>

        member _.Run(state: StorageObjectReplicationState<Present, Present, Present>) : azurerm.StorageObjectReplication.StorageObjectReplication =
            let config = azurerm.StorageObjectReplication.StorageObjectReplicationConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageObjectReplication.StorageObjectReplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageObjectReplication: missing required arguments. Must call: destination_storage_account_id, rules, source_storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: StorageObjectReplicationState<_, _, _>) : azurerm.StorageObjectReplication.StorageObjectReplication =
            Unchecked.defaultof<azurerm.StorageObjectReplication.StorageObjectReplication>
