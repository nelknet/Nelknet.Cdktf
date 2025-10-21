namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> = { assignments: ResizeArray<aws.ElasticacheReplicationGroup.ElasticacheReplicationGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group">aws_elasticache_replication_group</a>.
    /// </summary>
    type ElasticacheReplicationGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticacheReplicationGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheReplicationGroupState<Missing, Missing>)

        member _.Zero(()) : ElasticacheReplicationGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheReplicationGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#description-1">ElasticacheReplicationGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ElasticacheReplicationGroupState<Missing, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<Present, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : ElasticacheReplicationGroupState<Present, 'ReplicationGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#replication_group_id-1">ElasticacheReplicationGroup#replication_group_id</a>.
        /// </summary>
        [<CustomOperation "replication_group_id">]
        member _.ReplicationGroupId(state: ElasticacheReplicationGroupState<'Description, Missing>, value: string) : ElasticacheReplicationGroupState<'Description, Present> =
            state.assignments.Add(fun config -> config.ReplicationGroupId <- value)
            ({ assignments = state.assignments } : ElasticacheReplicationGroupState<'Description, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#apply_immediately-1">ElasticacheReplicationGroup#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: bool) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#apply_immediately-1">ElasticacheReplicationGroup#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: HashiCorp.Cdktf.IResolvable) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#at_rest_encryption_enabled-1">ElasticacheReplicationGroup#at_rest_encryption_enabled</a>.
        /// </summary>
        [<CustomOperation "at_rest_encryption_enabled">]
        member _.AtRestEncryptionEnabled(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.AtRestEncryptionEnabled <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#auth_token-1">ElasticacheReplicationGroup#auth_token</a>.
        /// </summary>
        [<CustomOperation "auth_token">]
        member _.AuthToken(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.AuthToken <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#auth_token_update_strategy-1">ElasticacheReplicationGroup#auth_token_update_strategy</a>.
        /// </summary>
        [<CustomOperation "auth_token_update_strategy">]
        member _.AuthTokenUpdateStrategy(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.AuthTokenUpdateStrategy <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#automatic_failover_enabled-1">ElasticacheReplicationGroup#automatic_failover_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "automatic_failover_enabled">]
        member _.AutomaticFailoverEnabled(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: bool) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.AutomaticFailoverEnabled <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#automatic_failover_enabled-1">ElasticacheReplicationGroup#automatic_failover_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "automatic_failover_enabled">]
        member _.AutomaticFailoverEnabled(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: HashiCorp.Cdktf.IResolvable) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.AutomaticFailoverEnabled <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#auto_minor_version_upgrade-1">ElasticacheReplicationGroup#auto_minor_version_upgrade</a>.
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#cluster_mode-1">ElasticacheReplicationGroup#cluster_mode</a>.
        /// </summary>
        [<CustomOperation "cluster_mode">]
        member _.ClusterMode(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.ClusterMode <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#data_tiering_enabled-1">ElasticacheReplicationGroup#data_tiering_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "data_tiering_enabled">]
        member _.DataTieringEnabled(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: bool) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.DataTieringEnabled <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#data_tiering_enabled-1">ElasticacheReplicationGroup#data_tiering_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "data_tiering_enabled">]
        member _.DataTieringEnabled(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: HashiCorp.Cdktf.IResolvable) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.DataTieringEnabled <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#engine-1">ElasticacheReplicationGroup#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#engine_version-1">ElasticacheReplicationGroup#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#final_snapshot_identifier-1">ElasticacheReplicationGroup#final_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "final_snapshot_identifier">]
        member _.FinalSnapshotIdentifier(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.FinalSnapshotIdentifier <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#global_replication_group_id-1">ElasticacheReplicationGroup#global_replication_group_id</a>.
        /// </summary>
        [<CustomOperation "global_replication_group_id">]
        member _.GlobalReplicationGroupId(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.GlobalReplicationGroupId <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#id-1">ElasticacheReplicationGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#ip_discovery-1">ElasticacheReplicationGroup#ip_discovery</a>.
        /// </summary>
        [<CustomOperation "ip_discovery">]
        member _.IpDiscovery(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.IpDiscovery <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#kms_key_id-1">ElasticacheReplicationGroup#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// log_delivery_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#log_delivery_configuration-1">ElasticacheReplicationGroup#log_delivery_configuration</a> Accepts: aws.IResolvable | aws.ElasticacheReplicationGroup.ElasticacheReplicationGroupLogDeliveryConfiguration[]
        /// </summary>
        [<CustomOperation "log_delivery_configuration">]
        member _.LogDeliveryConfiguration(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: HashiCorp.Cdktf.IResolvable) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.LogDeliveryConfiguration <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#maintenance_window-1">ElasticacheReplicationGroup#maintenance_window</a>.
        /// </summary>
        [<CustomOperation "maintenance_window">]
        member _.MaintenanceWindow(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.MaintenanceWindow <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#multi_az_enabled-1">ElasticacheReplicationGroup#multi_az_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_az_enabled">]
        member _.MultiAzEnabled(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: bool) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.MultiAzEnabled <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#multi_az_enabled-1">ElasticacheReplicationGroup#multi_az_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_az_enabled">]
        member _.MultiAzEnabled(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: HashiCorp.Cdktf.IResolvable) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.MultiAzEnabled <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#network_type-1">ElasticacheReplicationGroup#network_type</a>.
        /// </summary>
        [<CustomOperation "network_type">]
        member _.NetworkType(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.NetworkType <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#node_type-1">ElasticacheReplicationGroup#node_type</a>.
        /// </summary>
        [<CustomOperation "node_type">]
        member _.NodeType(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.NodeType <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#notification_topic_arn-1">ElasticacheReplicationGroup#notification_topic_arn</a>.
        /// </summary>
        [<CustomOperation "notification_topic_arn">]
        member _.NotificationTopicArn(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.NotificationTopicArn <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#num_cache_clusters-1">ElasticacheReplicationGroup#num_cache_clusters</a>.
        /// </summary>
        [<CustomOperation "num_cache_clusters">]
        member _.NumCacheClusters(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: double) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.NumCacheClusters <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#num_node_groups-1">ElasticacheReplicationGroup#num_node_groups</a>.
        /// </summary>
        [<CustomOperation "num_node_groups">]
        member _.NumNodeGroups(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: double) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.NumNodeGroups <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#parameter_group_name-1">ElasticacheReplicationGroup#parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "parameter_group_name">]
        member _.ParameterGroupName(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.ParameterGroupName <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#port-1">ElasticacheReplicationGroup#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: double) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#preferred_cache_cluster_azs-1">ElasticacheReplicationGroup#preferred_cache_cluster_azs</a>.
        /// </summary>
        [<CustomOperation "preferred_cache_cluster_azs">]
        member _.PreferredCacheClusterAzs(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: seq<string>) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.PreferredCacheClusterAzs <- (value |> Seq.toArray))
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#replicas_per_node_group-1">ElasticacheReplicationGroup#replicas_per_node_group</a>.
        /// </summary>
        [<CustomOperation "replicas_per_node_group">]
        member _.ReplicasPerNodeGroup(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: double) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.ReplicasPerNodeGroup <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#security_group_ids-1">ElasticacheReplicationGroup#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: seq<string>) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#security_group_names-1">ElasticacheReplicationGroup#security_group_names</a>.
        /// </summary>
        [<CustomOperation "security_group_names">]
        member _.SecurityGroupNames(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: seq<string>) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.SecurityGroupNames <- (value |> Seq.toArray))
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#snapshot_arns-1">ElasticacheReplicationGroup#snapshot_arns</a>.
        /// </summary>
        [<CustomOperation "snapshot_arns">]
        member _.SnapshotArns(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: seq<string>) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.SnapshotArns <- (value |> Seq.toArray))
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#snapshot_name-1">ElasticacheReplicationGroup#snapshot_name</a>.
        /// </summary>
        [<CustomOperation "snapshot_name">]
        member _.SnapshotName(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.SnapshotName <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#snapshot_retention_limit-1">ElasticacheReplicationGroup#snapshot_retention_limit</a>.
        /// </summary>
        [<CustomOperation "snapshot_retention_limit">]
        member _.SnapshotRetentionLimit(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: double) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.SnapshotRetentionLimit <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#snapshot_window-1">ElasticacheReplicationGroup#snapshot_window</a>.
        /// </summary>
        [<CustomOperation "snapshot_window">]
        member _.SnapshotWindow(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.SnapshotWindow <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#subnet_group_name-1">ElasticacheReplicationGroup#subnet_group_name</a>.
        /// </summary>
        [<CustomOperation "subnet_group_name">]
        member _.SubnetGroupName(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.SubnetGroupName <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#tags-1">ElasticacheReplicationGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: seq<string * string>) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#tags_all-1">ElasticacheReplicationGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: seq<string * string>) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#timeouts-1">ElasticacheReplicationGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: aws.ElasticacheReplicationGroup.ElasticacheReplicationGroupTimeouts) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#transit_encryption_enabled-1">ElasticacheReplicationGroup#transit_encryption_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_encryption_enabled">]
        member _.TransitEncryptionEnabled(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: bool) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.TransitEncryptionEnabled <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#transit_encryption_enabled-1">ElasticacheReplicationGroup#transit_encryption_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_encryption_enabled">]
        member _.TransitEncryptionEnabled(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: HashiCorp.Cdktf.IResolvable) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.TransitEncryptionEnabled <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#transit_encryption_mode-1">ElasticacheReplicationGroup#transit_encryption_mode</a>.
        /// </summary>
        [<CustomOperation "transit_encryption_mode">]
        member _.TransitEncryptionMode(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: string) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.TransitEncryptionMode <- value)
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#user_group_ids-1">ElasticacheReplicationGroup#user_group_ids</a>.
        /// </summary>
        [<CustomOperation "user_group_ids">]
        member _.UserGroupIds(state: ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>, value: seq<string>) : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId> =
            state.assignments.Add(fun config -> config.UserGroupIds <- (value |> Seq.toArray))
            state : ElasticacheReplicationGroupState<'Description, 'ReplicationGroupId>

        member _.Run(state: ElasticacheReplicationGroupState<Present, Present>) : aws.ElasticacheReplicationGroup.ElasticacheReplicationGroup =
            let config = aws.ElasticacheReplicationGroup.ElasticacheReplicationGroupConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticacheReplicationGroup.ElasticacheReplicationGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticacheReplicationGroup: missing required arguments. Must call: description, replication_group_id.", 9999, IsError = true)>]
        member _.Run(_: ElasticacheReplicationGroupState<_, _>) : aws.ElasticacheReplicationGroup.ElasticacheReplicationGroup =
            Unchecked.defaultof<aws.ElasticacheReplicationGroup.ElasticacheReplicationGroup>
