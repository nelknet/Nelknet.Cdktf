namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel> = { assignments: ResizeArray<azurerm.HpcCacheNfsTarget.HpcCacheNfsTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target">azurerm_hpc_cache_nfs_target</a>.
    /// </summary>
    type HpcCacheNfsTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : HpcCacheNfsTargetState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HpcCacheNfsTargetState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : HpcCacheNfsTargetState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HpcCacheNfsTargetState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#cache_name-1">HpcCacheNfsTarget#cache_name</a>.
        /// </summary>
        [<CustomOperation "cache_name">]
        member _.CacheName(state: HpcCacheNfsTargetState<Missing, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel>, value: string) : HpcCacheNfsTargetState<Present, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel> =
            state.assignments.Add(fun config -> config.CacheName <- value)
            ({ assignments = state.assignments } : HpcCacheNfsTargetState<Present, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#name-1">HpcCacheNfsTarget#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HpcCacheNfsTargetState<'CacheName, Missing, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel>, value: string) : HpcCacheNfsTargetState<'CacheName, Present, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HpcCacheNfsTargetState<'CacheName, Present, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel>)

        /// <summary>
        /// namespace_junction block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#namespace_junction-1">HpcCacheNfsTarget#namespace_junction</a> Accepts: azurerm.IResolvable | azurerm.HpcCacheNfsTarget.HpcCacheNfsTargetNamespaceJunction[]
        /// </summary>
        [<CustomOperation "namespace_junction">]
        member _.NamespaceJunction(state: HpcCacheNfsTargetState<'CacheName, 'Name, Missing, 'ResourceGroupName, 'TargetHostName, 'UsageModel>, value: HashiCorp.Cdktf.IResolvable) : HpcCacheNfsTargetState<'CacheName, 'Name, Present, 'ResourceGroupName, 'TargetHostName, 'UsageModel> =
            state.assignments.Add(fun config -> config.NamespaceJunction <- value)
            ({ assignments = state.assignments } : HpcCacheNfsTargetState<'CacheName, 'Name, Present, 'ResourceGroupName, 'TargetHostName, 'UsageModel>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#resource_group_name-1">HpcCacheNfsTarget#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, Missing, 'TargetHostName, 'UsageModel>, value: string) : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, Present, 'TargetHostName, 'UsageModel> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, Present, 'TargetHostName, 'UsageModel>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#target_host_name-1">HpcCacheNfsTarget#target_host_name</a>.
        /// </summary>
        [<CustomOperation "target_host_name">]
        member _.TargetHostName(state: HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, Missing, 'UsageModel>, value: string) : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, Present, 'UsageModel> =
            state.assignments.Add(fun config -> config.TargetHostName <- value)
            ({ assignments = state.assignments } : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, Present, 'UsageModel>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#usage_model-1">HpcCacheNfsTarget#usage_model</a>.
        /// </summary>
        [<CustomOperation "usage_model">]
        member _.UsageModel(state: HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, Missing>, value: string) : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, Present> =
            state.assignments.Add(fun config -> config.UsageModel <- value)
            ({ assignments = state.assignments } : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#id-1">HpcCacheNfsTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel>, value: string) : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#timeouts-1">HpcCacheNfsTarget#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel>, value: azurerm.HpcCacheNfsTarget.HpcCacheNfsTargetTimeouts) : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#verification_timer_in_seconds-1">HpcCacheNfsTarget#verification_timer_in_seconds</a>.
        /// </summary>
        [<CustomOperation "verification_timer_in_seconds">]
        member _.VerificationTimerInSeconds(state: HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel>, value: double) : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel> =
            state.assignments.Add(fun config -> config.VerificationTimerInSeconds <- value)
            state : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache_nfs_target#write_back_timer_in_seconds-1">HpcCacheNfsTarget#write_back_timer_in_seconds</a>.
        /// </summary>
        [<CustomOperation "write_back_timer_in_seconds">]
        member _.WriteBackTimerInSeconds(state: HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel>, value: double) : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel> =
            state.assignments.Add(fun config -> config.WriteBackTimerInSeconds <- value)
            state : HpcCacheNfsTargetState<'CacheName, 'Name, 'NamespaceJunction, 'ResourceGroupName, 'TargetHostName, 'UsageModel>

        member _.Run(state: HpcCacheNfsTargetState<Present, Present, Present, Present, Present, Present>) : azurerm.HpcCacheNfsTarget.HpcCacheNfsTarget =
            let config = azurerm.HpcCacheNfsTarget.HpcCacheNfsTargetConfig()
            for setter in state.assignments do
                setter config
            azurerm.HpcCacheNfsTarget.HpcCacheNfsTarget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.hpcCacheNfsTarget: missing required arguments. Must call: cache_name, name, namespace_junction, resource_group_name, target_host_name, usage_model.", 9999, IsError = true)>]
        member _.Run(_: HpcCacheNfsTargetState<_, _, _, _, _, _>) : azurerm.HpcCacheNfsTarget.HpcCacheNfsTarget =
            Unchecked.defaultof<azurerm.HpcCacheNfsTarget.HpcCacheNfsTarget>
