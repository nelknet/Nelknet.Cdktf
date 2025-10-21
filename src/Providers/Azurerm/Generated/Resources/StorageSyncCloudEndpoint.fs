namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageSyncCloudEndpointState<'FileShareName, 'Name, 'StorageAccountId, 'StorageSyncGroupId> = { assignments: ResizeArray<azurerm.StorageSyncCloudEndpoint.StorageSyncCloudEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_cloud_endpoint">azurerm_storage_sync_cloud_endpoint</a>.
    /// </summary>
    type StorageSyncCloudEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageSyncCloudEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageSyncCloudEndpointState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StorageSyncCloudEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageSyncCloudEndpointState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_cloud_endpoint#file_share_name-1">StorageSyncCloudEndpoint#file_share_name</a>.
        /// </summary>
        [<CustomOperation "file_share_name">]
        member _.FileShareName(state: StorageSyncCloudEndpointState<Missing, 'Name, 'StorageAccountId, 'StorageSyncGroupId>, value: string) : StorageSyncCloudEndpointState<Present, 'Name, 'StorageAccountId, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.FileShareName <- value)
            ({ assignments = state.assignments } : StorageSyncCloudEndpointState<Present, 'Name, 'StorageAccountId, 'StorageSyncGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_cloud_endpoint#name-1">StorageSyncCloudEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageSyncCloudEndpointState<'FileShareName, Missing, 'StorageAccountId, 'StorageSyncGroupId>, value: string) : StorageSyncCloudEndpointState<'FileShareName, Present, 'StorageAccountId, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageSyncCloudEndpointState<'FileShareName, Present, 'StorageAccountId, 'StorageSyncGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_cloud_endpoint#storage_account_id-1">StorageSyncCloudEndpoint#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: StorageSyncCloudEndpointState<'FileShareName, 'Name, Missing, 'StorageSyncGroupId>, value: string) : StorageSyncCloudEndpointState<'FileShareName, 'Name, Present, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : StorageSyncCloudEndpointState<'FileShareName, 'Name, Present, 'StorageSyncGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_cloud_endpoint#storage_sync_group_id-1">StorageSyncCloudEndpoint#storage_sync_group_id</a>.
        /// </summary>
        [<CustomOperation "storage_sync_group_id">]
        member _.StorageSyncGroupId(state: StorageSyncCloudEndpointState<'FileShareName, 'Name, 'StorageAccountId, Missing>, value: string) : StorageSyncCloudEndpointState<'FileShareName, 'Name, 'StorageAccountId, Present> =
            state.assignments.Add(fun config -> config.StorageSyncGroupId <- value)
            ({ assignments = state.assignments } : StorageSyncCloudEndpointState<'FileShareName, 'Name, 'StorageAccountId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_cloud_endpoint#id-1">StorageSyncCloudEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageSyncCloudEndpointState<'FileShareName, 'Name, 'StorageAccountId, 'StorageSyncGroupId>, value: string) : StorageSyncCloudEndpointState<'FileShareName, 'Name, 'StorageAccountId, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageSyncCloudEndpointState<'FileShareName, 'Name, 'StorageAccountId, 'StorageSyncGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_cloud_endpoint#storage_account_tenant_id-1">StorageSyncCloudEndpoint#storage_account_tenant_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_tenant_id">]
        member _.StorageAccountTenantId(state: StorageSyncCloudEndpointState<'FileShareName, 'Name, 'StorageAccountId, 'StorageSyncGroupId>, value: string) : StorageSyncCloudEndpointState<'FileShareName, 'Name, 'StorageAccountId, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.StorageAccountTenantId <- value)
            state : StorageSyncCloudEndpointState<'FileShareName, 'Name, 'StorageAccountId, 'StorageSyncGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_cloud_endpoint#timeouts-1">StorageSyncCloudEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageSyncCloudEndpointState<'FileShareName, 'Name, 'StorageAccountId, 'StorageSyncGroupId>, value: azurerm.StorageSyncCloudEndpoint.StorageSyncCloudEndpointTimeouts) : StorageSyncCloudEndpointState<'FileShareName, 'Name, 'StorageAccountId, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageSyncCloudEndpointState<'FileShareName, 'Name, 'StorageAccountId, 'StorageSyncGroupId>

        member _.Run(state: StorageSyncCloudEndpointState<Present, Present, Present, Present>) : azurerm.StorageSyncCloudEndpoint.StorageSyncCloudEndpoint =
            let config = azurerm.StorageSyncCloudEndpoint.StorageSyncCloudEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageSyncCloudEndpoint.StorageSyncCloudEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageSyncCloudEndpoint: missing required arguments. Must call: file_share_name, name, storage_account_id, storage_sync_group_id.", 9999, IsError = true)>]
        member _.Run(_: StorageSyncCloudEndpointState<_, _, _, _>) : azurerm.StorageSyncCloudEndpoint.StorageSyncCloudEndpoint =
            Unchecked.defaultof<azurerm.StorageSyncCloudEndpoint.StorageSyncCloudEndpoint>
