namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageSyncGroupState<'Name, 'StorageSyncId> = { assignments: ResizeArray<azurerm.StorageSyncGroup.StorageSyncGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_group">azurerm_storage_sync_group</a>.
    /// </summary>
    type StorageSyncGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageSyncGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageSyncGroupState<Missing, Missing>)

        member _.Zero(()) : StorageSyncGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageSyncGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_group#name-1">StorageSyncGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageSyncGroupState<Missing, 'StorageSyncId>, value: string) : StorageSyncGroupState<Present, 'StorageSyncId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageSyncGroupState<Present, 'StorageSyncId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_group#storage_sync_id-1">StorageSyncGroup#storage_sync_id</a>.
        /// </summary>
        [<CustomOperation "storage_sync_id">]
        member _.StorageSyncId(state: StorageSyncGroupState<'Name, Missing>, value: string) : StorageSyncGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageSyncId <- value)
            ({ assignments = state.assignments } : StorageSyncGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_group#id-1">StorageSyncGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageSyncGroupState<'Name, 'StorageSyncId>, value: string) : StorageSyncGroupState<'Name, 'StorageSyncId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageSyncGroupState<'Name, 'StorageSyncId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_group#timeouts-1">StorageSyncGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageSyncGroupState<'Name, 'StorageSyncId>, value: azurerm.StorageSyncGroup.StorageSyncGroupTimeouts) : StorageSyncGroupState<'Name, 'StorageSyncId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageSyncGroupState<'Name, 'StorageSyncId>

        member _.Run(state: StorageSyncGroupState<Present, Present>) : azurerm.StorageSyncGroup.StorageSyncGroup =
            let config = azurerm.StorageSyncGroup.StorageSyncGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageSyncGroup.StorageSyncGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageSyncGroup: missing required arguments. Must call: name, storage_sync_id.", 9999, IsError = true)>]
        member _.Run(_: StorageSyncGroupState<_, _>) : azurerm.StorageSyncGroup.StorageSyncGroup =
            Unchecked.defaultof<azurerm.StorageSyncGroup.StorageSyncGroup>
