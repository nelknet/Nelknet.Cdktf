namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType> = { assignments: ResizeArray<aws.MemorydbMultiRegionCluster.MemorydbMultiRegionClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_multi_region_cluster">aws_memorydb_multi_region_cluster</a>.
    /// </summary>
    type MemorydbMultiRegionClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : MemorydbMultiRegionClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MemorydbMultiRegionClusterState<Missing, Missing>)

        member _.Zero(()) : MemorydbMultiRegionClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MemorydbMultiRegionClusterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_multi_region_cluster#multi_region_cluster_name_suffix-1">MemorydbMultiRegionCluster#multi_region_cluster_name_suffix</a>.
        /// </summary>
        [<CustomOperation "multi_region_cluster_name_suffix">]
        member _.MultiRegionClusterNameSuffix(state: MemorydbMultiRegionClusterState<Missing, 'NodeType>, value: string) : MemorydbMultiRegionClusterState<Present, 'NodeType> =
            state.assignments.Add(fun config -> config.MultiRegionClusterNameSuffix <- value)
            ({ assignments = state.assignments } : MemorydbMultiRegionClusterState<Present, 'NodeType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_multi_region_cluster#node_type-1">MemorydbMultiRegionCluster#node_type</a>.
        /// </summary>
        [<CustomOperation "node_type">]
        member _.NodeType(state: MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, Missing>, value: string) : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, Present> =
            state.assignments.Add(fun config -> config.NodeType <- value)
            ({ assignments = state.assignments } : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_multi_region_cluster#description-1">MemorydbMultiRegionCluster#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>, value: string) : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_multi_region_cluster#engine-1">MemorydbMultiRegionCluster#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>, value: string) : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType> =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_multi_region_cluster#engine_version-1">MemorydbMultiRegionCluster#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>, value: string) : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_multi_region_cluster#multi_region_parameter_group_name-1">MemorydbMultiRegionCluster#multi_region_parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "multi_region_parameter_group_name">]
        member _.MultiRegionParameterGroupName(state: MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>, value: string) : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType> =
            state.assignments.Add(fun config -> config.MultiRegionParameterGroupName <- value)
            state : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_multi_region_cluster#num_shards-1">MemorydbMultiRegionCluster#num_shards</a>.
        /// </summary>
        [<CustomOperation "num_shards">]
        member _.NumShards(state: MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>, value: double) : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType> =
            state.assignments.Add(fun config -> config.NumShards <- value)
            state : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_multi_region_cluster#tags-1">MemorydbMultiRegionCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>, value: seq<string * string>) : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_multi_region_cluster#timeouts-1">MemorydbMultiRegionCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>, value: aws.MemorydbMultiRegionCluster.MemorydbMultiRegionClusterTimeouts) : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_multi_region_cluster#tls_enabled-1">MemorydbMultiRegionCluster#tls_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "tls_enabled">]
        member _.TlsEnabled(state: MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>, value: bool) : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType> =
            state.assignments.Add(fun config -> config.TlsEnabled <- value)
            state : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_multi_region_cluster#tls_enabled-1">MemorydbMultiRegionCluster#tls_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "tls_enabled">]
        member _.TlsEnabled(state: MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>, value: HashiCorp.Cdktf.IResolvable) : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType> =
            state.assignments.Add(fun config -> config.TlsEnabled <- value)
            state : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_multi_region_cluster#update_strategy-1">MemorydbMultiRegionCluster#update_strategy</a>.
        /// </summary>
        [<CustomOperation "update_strategy">]
        member _.UpdateStrategy(state: MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>, value: string) : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType> =
            state.assignments.Add(fun config -> config.UpdateStrategy <- value)
            state : MemorydbMultiRegionClusterState<'MultiRegionClusterNameSuffix, 'NodeType>

        member _.Run(state: MemorydbMultiRegionClusterState<Present, Present>) : aws.MemorydbMultiRegionCluster.MemorydbMultiRegionCluster =
            let config = aws.MemorydbMultiRegionCluster.MemorydbMultiRegionClusterConfig()
            for setter in state.assignments do
                setter config
            aws.MemorydbMultiRegionCluster.MemorydbMultiRegionCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.memorydbMultiRegionCluster: missing required arguments. Must call: multi_region_cluster_name_suffix, node_type.", 9999, IsError = true)>]
        member _.Run(_: MemorydbMultiRegionClusterState<_, _>) : aws.MemorydbMultiRegionCluster.MemorydbMultiRegionCluster =
            Unchecked.defaultof<aws.MemorydbMultiRegionCluster.MemorydbMultiRegionCluster>
