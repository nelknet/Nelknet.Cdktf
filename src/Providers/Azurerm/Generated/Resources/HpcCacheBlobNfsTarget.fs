namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel> = { assignments: ResizeArray<azurerm.HpcCacheBlobNfsTarget.HpcCacheBlobNfsTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_nfs_target">azurerm_hpc_cache_blob_nfs_target</a>.
    /// </summary>
    type HpcCacheBlobNfsTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : HpcCacheBlobNfsTargetState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HpcCacheBlobNfsTargetState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : HpcCacheBlobNfsTargetState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HpcCacheBlobNfsTargetState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_nfs_target#cache_name-1">HpcCacheBlobNfsTarget#cache_name</a>.
        /// </summary>
        [<CustomOperation "cache_name">]
        member _.CacheName(state: HpcCacheBlobNfsTargetState<Missing, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>, value: string) : HpcCacheBlobNfsTargetState<Present, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel> =
            state.assignments.Add(fun config -> config.CacheName <- value)
            ({ assignments = state.assignments } : HpcCacheBlobNfsTargetState<Present, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_nfs_target#name-1">HpcCacheBlobNfsTarget#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HpcCacheBlobNfsTargetState<'CacheName, Missing, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>, value: string) : HpcCacheBlobNfsTargetState<'CacheName, Present, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HpcCacheBlobNfsTargetState<'CacheName, Present, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_nfs_target#namespace_path-1">HpcCacheBlobNfsTarget#namespace_path</a>.
        /// </summary>
        [<CustomOperation "namespace_path">]
        member _.NamespacePath(state: HpcCacheBlobNfsTargetState<'CacheName, 'Name, Missing, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>, value: string) : HpcCacheBlobNfsTargetState<'CacheName, 'Name, Present, 'ResourceGroupName, 'StorageContainerId, 'UsageModel> =
            state.assignments.Add(fun config -> config.NamespacePath <- value)
            ({ assignments = state.assignments } : HpcCacheBlobNfsTargetState<'CacheName, 'Name, Present, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_nfs_target#resource_group_name-1">HpcCacheBlobNfsTarget#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, Missing, 'StorageContainerId, 'UsageModel>, value: string) : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, Present, 'StorageContainerId, 'UsageModel> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, Present, 'StorageContainerId, 'UsageModel>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_nfs_target#storage_container_id-1">HpcCacheBlobNfsTarget#storage_container_id</a>.
        /// </summary>
        [<CustomOperation "storage_container_id">]
        member _.StorageContainerId(state: HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, Missing, 'UsageModel>, value: string) : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, Present, 'UsageModel> =
            state.assignments.Add(fun config -> config.StorageContainerId <- value)
            ({ assignments = state.assignments } : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, Present, 'UsageModel>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_nfs_target#usage_model-1">HpcCacheBlobNfsTarget#usage_model</a>.
        /// </summary>
        [<CustomOperation "usage_model">]
        member _.UsageModel(state: HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, Missing>, value: string) : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, Present> =
            state.assignments.Add(fun config -> config.UsageModel <- value)
            ({ assignments = state.assignments } : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_nfs_target#access_policy_name-1">HpcCacheBlobNfsTarget#access_policy_name</a>.
        /// </summary>
        [<CustomOperation "access_policy_name">]
        member _.AccessPolicyName(state: HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>, value: string) : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel> =
            state.assignments.Add(fun config -> config.AccessPolicyName <- value)
            state : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_nfs_target#id-1">HpcCacheBlobNfsTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>, value: string) : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_nfs_target#timeouts-1">HpcCacheBlobNfsTarget#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>, value: azurerm.HpcCacheBlobNfsTarget.HpcCacheBlobNfsTargetTimeouts) : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_nfs_target#verification_timer_in_seconds-1">HpcCacheBlobNfsTarget#verification_timer_in_seconds</a>.
        /// </summary>
        [<CustomOperation "verification_timer_in_seconds">]
        member _.VerificationTimerInSeconds(state: HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>, value: double) : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel> =
            state.assignments.Add(fun config -> config.VerificationTimerInSeconds <- value)
            state : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_nfs_target#write_back_timer_in_seconds-1">HpcCacheBlobNfsTarget#write_back_timer_in_seconds</a>.
        /// </summary>
        [<CustomOperation "write_back_timer_in_seconds">]
        member _.WriteBackTimerInSeconds(state: HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>, value: double) : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel> =
            state.assignments.Add(fun config -> config.WriteBackTimerInSeconds <- value)
            state : HpcCacheBlobNfsTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId, 'UsageModel>

        member _.Run(state: HpcCacheBlobNfsTargetState<Present, Present, Present, Present, Present, Present>) : azurerm.HpcCacheBlobNfsTarget.HpcCacheBlobNfsTarget =
            let config = azurerm.HpcCacheBlobNfsTarget.HpcCacheBlobNfsTargetConfig()
            for setter in state.assignments do
                setter config
            azurerm.HpcCacheBlobNfsTarget.HpcCacheBlobNfsTarget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.hpcCacheBlobNfsTarget: missing required arguments. Must call: cache_name, name, namespace_path, resource_group_name, storage_container_id, usage_model.", 9999, IsError = true)>]
        member _.Run(_: HpcCacheBlobNfsTargetState<_, _, _, _, _, _>) : azurerm.HpcCacheBlobNfsTarget.HpcCacheBlobNfsTarget =
            Unchecked.defaultof<azurerm.HpcCacheBlobNfsTarget.HpcCacheBlobNfsTarget>
