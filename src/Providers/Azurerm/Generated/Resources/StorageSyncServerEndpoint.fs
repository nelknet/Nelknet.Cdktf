namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId> = { assignments: ResizeArray<azurerm.StorageSyncServerEndpoint.StorageSyncServerEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_server_endpoint">azurerm_storage_sync_server_endpoint</a>.
    /// </summary>
    type StorageSyncServerEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageSyncServerEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageSyncServerEndpointState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StorageSyncServerEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageSyncServerEndpointState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_server_endpoint#name-1">StorageSyncServerEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageSyncServerEndpointState<Missing, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>, value: string) : StorageSyncServerEndpointState<Present, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageSyncServerEndpointState<Present, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_server_endpoint#registered_server_id-1">StorageSyncServerEndpoint#registered_server_id</a>.
        /// </summary>
        [<CustomOperation "registered_server_id">]
        member _.RegisteredServerId(state: StorageSyncServerEndpointState<'Name, Missing, 'ServerLocalPath, 'StorageSyncGroupId>, value: string) : StorageSyncServerEndpointState<'Name, Present, 'ServerLocalPath, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.RegisteredServerId <- value)
            ({ assignments = state.assignments } : StorageSyncServerEndpointState<'Name, Present, 'ServerLocalPath, 'StorageSyncGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_server_endpoint#server_local_path-1">StorageSyncServerEndpoint#server_local_path</a>.
        /// </summary>
        [<CustomOperation "server_local_path">]
        member _.ServerLocalPath(state: StorageSyncServerEndpointState<'Name, 'RegisteredServerId, Missing, 'StorageSyncGroupId>, value: string) : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, Present, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.ServerLocalPath <- value)
            ({ assignments = state.assignments } : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, Present, 'StorageSyncGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_server_endpoint#storage_sync_group_id-1">StorageSyncServerEndpoint#storage_sync_group_id</a>.
        /// </summary>
        [<CustomOperation "storage_sync_group_id">]
        member _.StorageSyncGroupId(state: StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, Missing>, value: string) : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, Present> =
            state.assignments.Add(fun config -> config.StorageSyncGroupId <- value)
            ({ assignments = state.assignments } : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_server_endpoint#cloud_tiering_enabled-1">StorageSyncServerEndpoint#cloud_tiering_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "cloud_tiering_enabled">]
        member _.CloudTieringEnabled(state: StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>, value: bool) : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.CloudTieringEnabled <- value)
            state : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_server_endpoint#cloud_tiering_enabled-1">StorageSyncServerEndpoint#cloud_tiering_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "cloud_tiering_enabled">]
        member _.CloudTieringEnabled(state: StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>, value: HashiCorp.Cdktf.IResolvable) : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.CloudTieringEnabled <- value)
            state : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_server_endpoint#id-1">StorageSyncServerEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>, value: string) : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_server_endpoint#initial_download_policy-1">StorageSyncServerEndpoint#initial_download_policy</a>.
        /// </summary>
        [<CustomOperation "initial_download_policy">]
        member _.InitialDownloadPolicy(state: StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>, value: string) : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.InitialDownloadPolicy <- value)
            state : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_server_endpoint#local_cache_mode-1">StorageSyncServerEndpoint#local_cache_mode</a>.
        /// </summary>
        [<CustomOperation "local_cache_mode">]
        member _.LocalCacheMode(state: StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>, value: string) : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.LocalCacheMode <- value)
            state : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_server_endpoint#tier_files_older_than_days-1">StorageSyncServerEndpoint#tier_files_older_than_days</a>.
        /// </summary>
        [<CustomOperation "tier_files_older_than_days">]
        member _.TierFilesOlderThanDays(state: StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>, value: double) : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.TierFilesOlderThanDays <- value)
            state : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_server_endpoint#timeouts-1">StorageSyncServerEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>, value: azurerm.StorageSyncServerEndpoint.StorageSyncServerEndpointTimeouts) : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync_server_endpoint#volume_free_space_percent-1">StorageSyncServerEndpoint#volume_free_space_percent</a>.
        /// </summary>
        [<CustomOperation "volume_free_space_percent">]
        member _.VolumeFreeSpacePercent(state: StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>, value: double) : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId> =
            state.assignments.Add(fun config -> config.VolumeFreeSpacePercent <- value)
            state : StorageSyncServerEndpointState<'Name, 'RegisteredServerId, 'ServerLocalPath, 'StorageSyncGroupId>

        member _.Run(state: StorageSyncServerEndpointState<Present, Present, Present, Present>) : azurerm.StorageSyncServerEndpoint.StorageSyncServerEndpoint =
            let config = azurerm.StorageSyncServerEndpoint.StorageSyncServerEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageSyncServerEndpoint.StorageSyncServerEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageSyncServerEndpoint: missing required arguments. Must call: name, registered_server_id, server_local_path, storage_sync_group_id.", 9999, IsError = true)>]
        member _.Run(_: StorageSyncServerEndpointState<_, _, _, _>) : azurerm.StorageSyncServerEndpoint.StorageSyncServerEndpoint =
            Unchecked.defaultof<azurerm.StorageSyncServerEndpoint.StorageSyncServerEndpoint>
