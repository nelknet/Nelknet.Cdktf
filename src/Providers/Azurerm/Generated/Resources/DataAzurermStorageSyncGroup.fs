namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageSyncGroupState<'Name, 'StorageSyncId> = { assignments: ResizeArray<azurerm.DataAzurermStorageSyncGroup.DataAzurermStorageSyncGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync_group">azurerm_storage_sync_group</a>.
    /// </summary>
    type DataAzurermStorageSyncGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageSyncGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageSyncGroupState<Missing, Missing>)

        member _.Zero(()) : DataAzurermStorageSyncGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageSyncGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync_group#name-1">DataAzurermStorageSyncGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermStorageSyncGroupState<Missing, 'StorageSyncId>, value: string) : DataAzurermStorageSyncGroupState<Present, 'StorageSyncId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermStorageSyncGroupState<Present, 'StorageSyncId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync_group#storage_sync_id-1">DataAzurermStorageSyncGroup#storage_sync_id</a>.
        /// </summary>
        [<CustomOperation "storage_sync_id">]
        member _.StorageSyncId(state: DataAzurermStorageSyncGroupState<'Name, Missing>, value: string) : DataAzurermStorageSyncGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageSyncId <- value)
            ({ assignments = state.assignments } : DataAzurermStorageSyncGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync_group#id-1">DataAzurermStorageSyncGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageSyncGroupState<'Name, 'StorageSyncId>, value: string) : DataAzurermStorageSyncGroupState<'Name, 'StorageSyncId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageSyncGroupState<'Name, 'StorageSyncId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync_group#timeouts-1">DataAzurermStorageSyncGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageSyncGroupState<'Name, 'StorageSyncId>, value: azurerm.DataAzurermStorageSyncGroup.DataAzurermStorageSyncGroupTimeouts) : DataAzurermStorageSyncGroupState<'Name, 'StorageSyncId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageSyncGroupState<'Name, 'StorageSyncId>

        member _.Run(state: DataAzurermStorageSyncGroupState<Present, Present>) : azurerm.DataAzurermStorageSyncGroup.DataAzurermStorageSyncGroup =
            let config = azurerm.DataAzurermStorageSyncGroup.DataAzurermStorageSyncGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageSyncGroup.DataAzurermStorageSyncGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageSyncGroup: missing required arguments. Must call: name, storage_sync_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageSyncGroupState<_, _>) : azurerm.DataAzurermStorageSyncGroup.DataAzurermStorageSyncGroup =
            Unchecked.defaultof<azurerm.DataAzurermStorageSyncGroup.DataAzurermStorageSyncGroup>
