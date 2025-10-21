namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageSyncState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermStorageSync.DataAzurermStorageSyncConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync">azurerm_storage_sync</a>.
    /// </summary>
    type DataAzurermStorageSyncBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageSyncState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageSyncState<Missing, Missing>)

        member _.Zero(()) : DataAzurermStorageSyncState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageSyncState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync#name-1">DataAzurermStorageSync#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermStorageSyncState<Missing, 'ResourceGroupName>, value: string) : DataAzurermStorageSyncState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermStorageSyncState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync#resource_group_name-1">DataAzurermStorageSync#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermStorageSyncState<'Name, Missing>, value: string) : DataAzurermStorageSyncState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermStorageSyncState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync#id-1">DataAzurermStorageSync#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageSyncState<'Name, 'ResourceGroupName>, value: string) : DataAzurermStorageSyncState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageSyncState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync#timeouts-1">DataAzurermStorageSync#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageSyncState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermStorageSync.DataAzurermStorageSyncTimeouts) : DataAzurermStorageSyncState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageSyncState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermStorageSyncState<Present, Present>) : azurerm.DataAzurermStorageSync.DataAzurermStorageSync =
            let config = azurerm.DataAzurermStorageSync.DataAzurermStorageSyncConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageSync.DataAzurermStorageSync(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageSync: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageSyncState<_, _>) : azurerm.DataAzurermStorageSync.DataAzurermStorageSync =
            Unchecked.defaultof<azurerm.DataAzurermStorageSync.DataAzurermStorageSync>
