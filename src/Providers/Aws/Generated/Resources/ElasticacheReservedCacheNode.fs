namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticacheReservedCacheNodeState<'ReservedCacheNodesOfferingId> = { assignments: ResizeArray<aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNodeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_reserved_cache_node">aws_elasticache_reserved_cache_node</a>.
    /// </summary>
    type ElasticacheReservedCacheNodeBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticacheReservedCacheNodeState<Missing> =
            ({ assignments = ResizeArray() } : ElasticacheReservedCacheNodeState<Missing>)

        member _.Zero(()) : ElasticacheReservedCacheNodeState<Missing> =
            ({ assignments = ResizeArray() } : ElasticacheReservedCacheNodeState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_reserved_cache_node#reserved_cache_nodes_offering_id-1">ElasticacheReservedCacheNode#reserved_cache_nodes_offering_id</a>.
        /// </summary>
        [<CustomOperation "reserved_cache_nodes_offering_id">]
        member _.ReservedCacheNodesOfferingId(state: ElasticacheReservedCacheNodeState<Missing>, value: string) : ElasticacheReservedCacheNodeState<Present> =
            state.assignments.Add(fun config -> config.ReservedCacheNodesOfferingId <- value)
            ({ assignments = state.assignments } : ElasticacheReservedCacheNodeState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_reserved_cache_node#cache_node_count-1">ElasticacheReservedCacheNode#cache_node_count</a>.
        /// </summary>
        [<CustomOperation "cache_node_count">]
        member _.CacheNodeCount(state: ElasticacheReservedCacheNodeState<'ReservedCacheNodesOfferingId>, value: double) : ElasticacheReservedCacheNodeState<'ReservedCacheNodesOfferingId> =
            state.assignments.Add(fun config -> config.CacheNodeCount <- value)
            state : ElasticacheReservedCacheNodeState<'ReservedCacheNodesOfferingId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_reserved_cache_node#id-1">ElasticacheReservedCacheNode#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticacheReservedCacheNodeState<'ReservedCacheNodesOfferingId>, value: string) : ElasticacheReservedCacheNodeState<'ReservedCacheNodesOfferingId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticacheReservedCacheNodeState<'ReservedCacheNodesOfferingId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_reserved_cache_node#tags-1">ElasticacheReservedCacheNode#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticacheReservedCacheNodeState<'ReservedCacheNodesOfferingId>, value: seq<string * string>) : ElasticacheReservedCacheNodeState<'ReservedCacheNodesOfferingId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticacheReservedCacheNodeState<'ReservedCacheNodesOfferingId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_reserved_cache_node#timeouts-1">ElasticacheReservedCacheNode#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticacheReservedCacheNodeState<'ReservedCacheNodesOfferingId>, value: aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNodeTimeouts) : ElasticacheReservedCacheNodeState<'ReservedCacheNodesOfferingId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticacheReservedCacheNodeState<'ReservedCacheNodesOfferingId>

        member _.Run(state: ElasticacheReservedCacheNodeState<Present>) : aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNode =
            let config = aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNodeConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNode(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticacheReservedCacheNode: missing required arguments. Must call: reserved_cache_nodes_offering_id.", 9999, IsError = true)>]
        member _.Run(_: ElasticacheReservedCacheNodeState<_>) : aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNode =
            Unchecked.defaultof<aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNode>
