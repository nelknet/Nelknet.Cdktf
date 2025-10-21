namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId> = { assignments: ResizeArray<azurerm.HpcCacheBlobTarget.HpcCacheBlobTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_target">azurerm_hpc_cache_blob_target</a>.
    /// </summary>
    type HpcCacheBlobTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : HpcCacheBlobTargetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HpcCacheBlobTargetState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : HpcCacheBlobTargetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HpcCacheBlobTargetState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_target#cache_name-1">HpcCacheBlobTarget#cache_name</a>.
        /// </summary>
        [<CustomOperation "cache_name">]
        member _.CacheName(state: HpcCacheBlobTargetState<Missing, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId>, value: string) : HpcCacheBlobTargetState<Present, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId> =
            state.assignments.Add(fun config -> config.CacheName <- value)
            ({ assignments = state.assignments } : HpcCacheBlobTargetState<Present, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_target#name-1">HpcCacheBlobTarget#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HpcCacheBlobTargetState<'CacheName, Missing, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId>, value: string) : HpcCacheBlobTargetState<'CacheName, Present, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HpcCacheBlobTargetState<'CacheName, Present, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_target#namespace_path-1">HpcCacheBlobTarget#namespace_path</a>.
        /// </summary>
        [<CustomOperation "namespace_path">]
        member _.NamespacePath(state: HpcCacheBlobTargetState<'CacheName, 'Name, Missing, 'ResourceGroupName, 'StorageContainerId>, value: string) : HpcCacheBlobTargetState<'CacheName, 'Name, Present, 'ResourceGroupName, 'StorageContainerId> =
            state.assignments.Add(fun config -> config.NamespacePath <- value)
            ({ assignments = state.assignments } : HpcCacheBlobTargetState<'CacheName, 'Name, Present, 'ResourceGroupName, 'StorageContainerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_target#resource_group_name-1">HpcCacheBlobTarget#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, Missing, 'StorageContainerId>, value: string) : HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, Present, 'StorageContainerId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, Present, 'StorageContainerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_target#storage_container_id-1">HpcCacheBlobTarget#storage_container_id</a>.
        /// </summary>
        [<CustomOperation "storage_container_id">]
        member _.StorageContainerId(state: HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, Missing>, value: string) : HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.StorageContainerId <- value)
            ({ assignments = state.assignments } : HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_target#access_policy_name-1">HpcCacheBlobTarget#access_policy_name</a>.
        /// </summary>
        [<CustomOperation "access_policy_name">]
        member _.AccessPolicyName(state: HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId>, value: string) : HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId> =
            state.assignments.Add(fun config -> config.AccessPolicyName <- value)
            state : HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_target#id-1">HpcCacheBlobTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId>, value: string) : HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_blob_target#timeouts-1">HpcCacheBlobTarget#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId>, value: azurerm.HpcCacheBlobTarget.HpcCacheBlobTargetTimeouts) : HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HpcCacheBlobTargetState<'CacheName, 'Name, 'NamespacePath, 'ResourceGroupName, 'StorageContainerId>

        member _.Run(state: HpcCacheBlobTargetState<Present, Present, Present, Present, Present>) : azurerm.HpcCacheBlobTarget.HpcCacheBlobTarget =
            let config = azurerm.HpcCacheBlobTarget.HpcCacheBlobTargetConfig()
            for setter in state.assignments do
                setter config
            azurerm.HpcCacheBlobTarget.HpcCacheBlobTarget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.hpcCacheBlobTarget: missing required arguments. Must call: cache_name, name, namespace_path, resource_group_name, storage_container_id.", 9999, IsError = true)>]
        member _.Run(_: HpcCacheBlobTargetState<_, _, _, _, _>) : azurerm.HpcCacheBlobTarget.HpcCacheBlobTarget =
            Unchecked.defaultof<azurerm.HpcCacheBlobTarget.HpcCacheBlobTarget>
