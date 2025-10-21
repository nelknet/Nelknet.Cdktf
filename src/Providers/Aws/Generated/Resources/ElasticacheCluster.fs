namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticacheClusterState<'ClusterId> = { assignments: ResizeArray<aws.ElasticacheCluster.ElasticacheClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster">aws_elasticache_cluster</a>.
    /// </summary>
    type ElasticacheClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticacheClusterState<Missing> =
            ({ assignments = ResizeArray() } : ElasticacheClusterState<Missing>)

        member _.Zero(()) : ElasticacheClusterState<Missing> =
            ({ assignments = ResizeArray() } : ElasticacheClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#cluster_id-1">ElasticacheCluster#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: ElasticacheClusterState<Missing>, value: string) : ElasticacheClusterState<Present> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : ElasticacheClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#apply_immediately-1">ElasticacheCluster#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: ElasticacheClusterState<'ClusterId>, value: bool) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#apply_immediately-1">ElasticacheCluster#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: ElasticacheClusterState<'ClusterId>, value: HashiCorp.Cdktf.IResolvable) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#auto_minor_version_upgrade-1">ElasticacheCluster#auto_minor_version_upgrade</a>.
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#availability_zone-1">ElasticacheCluster#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#az_mode-1">ElasticacheCluster#az_mode</a>.
        /// </summary>
        [<CustomOperation "az_mode">]
        member _.AzMode(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.AzMode <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#engine-1">ElasticacheCluster#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#engine_version-1">ElasticacheCluster#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#final_snapshot_identifier-1">ElasticacheCluster#final_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "final_snapshot_identifier">]
        member _.FinalSnapshotIdentifier(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.FinalSnapshotIdentifier <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#id-1">ElasticacheCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#ip_discovery-1">ElasticacheCluster#ip_discovery</a>.
        /// </summary>
        [<CustomOperation "ip_discovery">]
        member _.IpDiscovery(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.IpDiscovery <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// log_delivery_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#log_delivery_configuration-1">ElasticacheCluster#log_delivery_configuration</a> Accepts: aws.IResolvable | aws.ElasticacheCluster.ElasticacheClusterLogDeliveryConfiguration[]
        /// </summary>
        [<CustomOperation "log_delivery_configuration">]
        member _.LogDeliveryConfiguration(state: ElasticacheClusterState<'ClusterId>, value: HashiCorp.Cdktf.IResolvable) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.LogDeliveryConfiguration <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#maintenance_window-1">ElasticacheCluster#maintenance_window</a>.
        /// </summary>
        [<CustomOperation "maintenance_window">]
        member _.MaintenanceWindow(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.MaintenanceWindow <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#network_type-1">ElasticacheCluster#network_type</a>.
        /// </summary>
        [<CustomOperation "network_type">]
        member _.NetworkType(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.NetworkType <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#node_type-1">ElasticacheCluster#node_type</a>.
        /// </summary>
        [<CustomOperation "node_type">]
        member _.NodeType(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.NodeType <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#notification_topic_arn-1">ElasticacheCluster#notification_topic_arn</a>.
        /// </summary>
        [<CustomOperation "notification_topic_arn">]
        member _.NotificationTopicArn(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.NotificationTopicArn <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#num_cache_nodes-1">ElasticacheCluster#num_cache_nodes</a>.
        /// </summary>
        [<CustomOperation "num_cache_nodes">]
        member _.NumCacheNodes(state: ElasticacheClusterState<'ClusterId>, value: double) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.NumCacheNodes <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#outpost_mode-1">ElasticacheCluster#outpost_mode</a>.
        /// </summary>
        [<CustomOperation "outpost_mode">]
        member _.OutpostMode(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.OutpostMode <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#parameter_group_name-1">ElasticacheCluster#parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "parameter_group_name">]
        member _.ParameterGroupName(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.ParameterGroupName <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#port-1">ElasticacheCluster#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: ElasticacheClusterState<'ClusterId>, value: double) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#preferred_availability_zones-1">ElasticacheCluster#preferred_availability_zones</a>.
        /// </summary>
        [<CustomOperation "preferred_availability_zones">]
        member _.PreferredAvailabilityZones(state: ElasticacheClusterState<'ClusterId>, value: seq<string>) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.PreferredAvailabilityZones <- (value |> Seq.toArray))
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#preferred_outpost_arn-1">ElasticacheCluster#preferred_outpost_arn</a>.
        /// </summary>
        [<CustomOperation "preferred_outpost_arn">]
        member _.PreferredOutpostArn(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.PreferredOutpostArn <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#replication_group_id-1">ElasticacheCluster#replication_group_id</a>.
        /// </summary>
        [<CustomOperation "replication_group_id">]
        member _.ReplicationGroupId(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.ReplicationGroupId <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#security_group_ids-1">ElasticacheCluster#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: ElasticacheClusterState<'ClusterId>, value: seq<string>) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#snapshot_arns-1">ElasticacheCluster#snapshot_arns</a>.
        /// </summary>
        [<CustomOperation "snapshot_arns">]
        member _.SnapshotArns(state: ElasticacheClusterState<'ClusterId>, value: seq<string>) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.SnapshotArns <- (value |> Seq.toArray))
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#snapshot_name-1">ElasticacheCluster#snapshot_name</a>.
        /// </summary>
        [<CustomOperation "snapshot_name">]
        member _.SnapshotName(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.SnapshotName <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#snapshot_retention_limit-1">ElasticacheCluster#snapshot_retention_limit</a>.
        /// </summary>
        [<CustomOperation "snapshot_retention_limit">]
        member _.SnapshotRetentionLimit(state: ElasticacheClusterState<'ClusterId>, value: double) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.SnapshotRetentionLimit <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#snapshot_window-1">ElasticacheCluster#snapshot_window</a>.
        /// </summary>
        [<CustomOperation "snapshot_window">]
        member _.SnapshotWindow(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.SnapshotWindow <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#subnet_group_name-1">ElasticacheCluster#subnet_group_name</a>.
        /// </summary>
        [<CustomOperation "subnet_group_name">]
        member _.SubnetGroupName(state: ElasticacheClusterState<'ClusterId>, value: string) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.SubnetGroupName <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#tags-1">ElasticacheCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticacheClusterState<'ClusterId>, value: seq<string * string>) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#tags_all-1">ElasticacheCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ElasticacheClusterState<'ClusterId>, value: seq<string * string>) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#timeouts-1">ElasticacheCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticacheClusterState<'ClusterId>, value: aws.ElasticacheCluster.ElasticacheClusterTimeouts) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#transit_encryption_enabled-1">ElasticacheCluster#transit_encryption_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_encryption_enabled">]
        member _.TransitEncryptionEnabled(state: ElasticacheClusterState<'ClusterId>, value: bool) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.TransitEncryptionEnabled <- value)
            state : ElasticacheClusterState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#transit_encryption_enabled-1">ElasticacheCluster#transit_encryption_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_encryption_enabled">]
        member _.TransitEncryptionEnabled(state: ElasticacheClusterState<'ClusterId>, value: HashiCorp.Cdktf.IResolvable) : ElasticacheClusterState<'ClusterId> =
            state.assignments.Add(fun config -> config.TransitEncryptionEnabled <- value)
            state : ElasticacheClusterState<'ClusterId>

        member _.Run(state: ElasticacheClusterState<Present>) : aws.ElasticacheCluster.ElasticacheCluster =
            let config = aws.ElasticacheCluster.ElasticacheClusterConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticacheCluster.ElasticacheCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticacheCluster: missing required arguments. Must call: cluster_id.", 9999, IsError = true)>]
        member _.Run(_: ElasticacheClusterState<_>) : aws.ElasticacheCluster.ElasticacheCluster =
            Unchecked.defaultof<aws.ElasticacheCluster.ElasticacheCluster>
