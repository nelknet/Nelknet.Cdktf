namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId> = { assignments: ResizeArray<aws.ElasticacheGlobalReplicationGroup.ElasticacheGlobalReplicationGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_global_replication_group">aws_elasticache_global_replication_group</a>.
    /// </summary>
    type ElasticacheGlobalReplicationGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticacheGlobalReplicationGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheGlobalReplicationGroupState<Missing, Missing>)

        member _.Zero(()) : ElasticacheGlobalReplicationGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheGlobalReplicationGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_global_replication_group#global_replication_group_id_suffix-1">ElasticacheGlobalReplicationGroup#global_replication_group_id_suffix</a>.
        /// </summary>
        [<CustomOperation "global_replication_group_id_suffix">]
        member _.GlobalReplicationGroupIdSuffix(state: ElasticacheGlobalReplicationGroupState<Missing, 'PrimaryReplicationGroupId>, value: string) : ElasticacheGlobalReplicationGroupState<Present, 'PrimaryReplicationGroupId> =
            state.assignments.Add(fun config -> config.GlobalReplicationGroupIdSuffix <- value)
            ({ assignments = state.assignments } : ElasticacheGlobalReplicationGroupState<Present, 'PrimaryReplicationGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_global_replication_group#primary_replication_group_id-1">ElasticacheGlobalReplicationGroup#primary_replication_group_id</a>.
        /// </summary>
        [<CustomOperation "primary_replication_group_id">]
        member _.PrimaryReplicationGroupId(state: ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, Missing>, value: string) : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, Present> =
            state.assignments.Add(fun config -> config.PrimaryReplicationGroupId <- value)
            ({ assignments = state.assignments } : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_global_replication_group#automatic_failover_enabled-1">ElasticacheGlobalReplicationGroup#automatic_failover_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "automatic_failover_enabled">]
        member _.AutomaticFailoverEnabled(state: ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>, value: bool) : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId> =
            state.assignments.Add(fun config -> config.AutomaticFailoverEnabled <- value)
            state : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_global_replication_group#automatic_failover_enabled-1">ElasticacheGlobalReplicationGroup#automatic_failover_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "automatic_failover_enabled">]
        member _.AutomaticFailoverEnabled(state: ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>, value: HashiCorp.Cdktf.IResolvable) : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId> =
            state.assignments.Add(fun config -> config.AutomaticFailoverEnabled <- value)
            state : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_global_replication_group#cache_node_type-1">ElasticacheGlobalReplicationGroup#cache_node_type</a>.
        /// </summary>
        [<CustomOperation "cache_node_type">]
        member _.CacheNodeType(state: ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>, value: string) : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId> =
            state.assignments.Add(fun config -> config.CacheNodeType <- value)
            state : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_global_replication_group#engine_version-1">ElasticacheGlobalReplicationGroup#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>, value: string) : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_global_replication_group#global_replication_group_description-1">ElasticacheGlobalReplicationGroup#global_replication_group_description</a>.
        /// </summary>
        [<CustomOperation "global_replication_group_description">]
        member _.GlobalReplicationGroupDescription(state: ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>, value: string) : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId> =
            state.assignments.Add(fun config -> config.GlobalReplicationGroupDescription <- value)
            state : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_global_replication_group#id-1">ElasticacheGlobalReplicationGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>, value: string) : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_global_replication_group#num_node_groups-1">ElasticacheGlobalReplicationGroup#num_node_groups</a>.
        /// </summary>
        [<CustomOperation "num_node_groups">]
        member _.NumNodeGroups(state: ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>, value: double) : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId> =
            state.assignments.Add(fun config -> config.NumNodeGroups <- value)
            state : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_global_replication_group#parameter_group_name-1">ElasticacheGlobalReplicationGroup#parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "parameter_group_name">]
        member _.ParameterGroupName(state: ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>, value: string) : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId> =
            state.assignments.Add(fun config -> config.ParameterGroupName <- value)
            state : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_global_replication_group#timeouts-1">ElasticacheGlobalReplicationGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>, value: aws.ElasticacheGlobalReplicationGroup.ElasticacheGlobalReplicationGroupTimeouts) : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticacheGlobalReplicationGroupState<'GlobalReplicationGroupIdSuffix, 'PrimaryReplicationGroupId>

        member _.Run(state: ElasticacheGlobalReplicationGroupState<Present, Present>) : aws.ElasticacheGlobalReplicationGroup.ElasticacheGlobalReplicationGroup =
            let config = aws.ElasticacheGlobalReplicationGroup.ElasticacheGlobalReplicationGroupConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticacheGlobalReplicationGroup.ElasticacheGlobalReplicationGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticacheGlobalReplicationGroup: missing required arguments. Must call: global_replication_group_id_suffix, primary_replication_group_id.", 9999, IsError = true)>]
        member _.Run(_: ElasticacheGlobalReplicationGroupState<_, _>) : aws.ElasticacheGlobalReplicationGroup.ElasticacheGlobalReplicationGroup =
            Unchecked.defaultof<aws.ElasticacheGlobalReplicationGroup.ElasticacheGlobalReplicationGroup>
