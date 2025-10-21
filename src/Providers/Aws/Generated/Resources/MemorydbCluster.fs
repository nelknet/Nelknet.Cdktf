namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MemorydbClusterState<'AclName, 'NodeType> = { assignments: ResizeArray<aws.MemorydbCluster.MemorydbClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster">aws_memorydb_cluster</a>.
    /// </summary>
    type MemorydbClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : MemorydbClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MemorydbClusterState<Missing, Missing>)

        member _.Zero(()) : MemorydbClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MemorydbClusterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#acl_name-1">MemorydbCluster#acl_name</a>.
        /// </summary>
        [<CustomOperation "acl_name">]
        member _.AclName(state: MemorydbClusterState<Missing, 'NodeType>, value: string) : MemorydbClusterState<Present, 'NodeType> =
            state.assignments.Add(fun config -> config.AclName <- value)
            ({ assignments = state.assignments } : MemorydbClusterState<Present, 'NodeType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#node_type-1">MemorydbCluster#node_type</a>.
        /// </summary>
        [<CustomOperation "node_type">]
        member _.NodeType(state: MemorydbClusterState<'AclName, Missing>, value: string) : MemorydbClusterState<'AclName, Present> =
            state.assignments.Add(fun config -> config.NodeType <- value)
            ({ assignments = state.assignments } : MemorydbClusterState<'AclName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#auto_minor_version_upgrade-1">MemorydbCluster#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: MemorydbClusterState<'AclName, 'NodeType>, value: bool) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#auto_minor_version_upgrade-1">MemorydbCluster#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: MemorydbClusterState<'AclName, 'NodeType>, value: HashiCorp.Cdktf.IResolvable) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#data_tiering-1">MemorydbCluster#data_tiering</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "data_tiering">]
        member _.DataTiering(state: MemorydbClusterState<'AclName, 'NodeType>, value: bool) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.DataTiering <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#data_tiering-1">MemorydbCluster#data_tiering</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "data_tiering">]
        member _.DataTiering(state: MemorydbClusterState<'AclName, 'NodeType>, value: HashiCorp.Cdktf.IResolvable) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.DataTiering <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#description-1">MemorydbCluster#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#engine-1">MemorydbCluster#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#engine_version-1">MemorydbCluster#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#final_snapshot_name-1">MemorydbCluster#final_snapshot_name</a>.
        /// </summary>
        [<CustomOperation "final_snapshot_name">]
        member _.FinalSnapshotName(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.FinalSnapshotName <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#id-1">MemorydbCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#kms_key_arn-1">MemorydbCluster#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#maintenance_window-1">MemorydbCluster#maintenance_window</a>.
        /// </summary>
        [<CustomOperation "maintenance_window">]
        member _.MaintenanceWindow(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.MaintenanceWindow <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#multi_region_cluster_name-1">MemorydbCluster#multi_region_cluster_name</a>.
        /// </summary>
        [<CustomOperation "multi_region_cluster_name">]
        member _.MultiRegionClusterName(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.MultiRegionClusterName <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#name-1">MemorydbCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#name_prefix-1">MemorydbCluster#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#num_replicas_per_shard-1">MemorydbCluster#num_replicas_per_shard</a>.
        /// </summary>
        [<CustomOperation "num_replicas_per_shard">]
        member _.NumReplicasPerShard(state: MemorydbClusterState<'AclName, 'NodeType>, value: double) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.NumReplicasPerShard <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#num_shards-1">MemorydbCluster#num_shards</a>.
        /// </summary>
        [<CustomOperation "num_shards">]
        member _.NumShards(state: MemorydbClusterState<'AclName, 'NodeType>, value: double) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.NumShards <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#parameter_group_name-1">MemorydbCluster#parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "parameter_group_name">]
        member _.ParameterGroupName(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.ParameterGroupName <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#port-1">MemorydbCluster#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: MemorydbClusterState<'AclName, 'NodeType>, value: double) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#security_group_ids-1">MemorydbCluster#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: MemorydbClusterState<'AclName, 'NodeType>, value: seq<string>) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#snapshot_arns-1">MemorydbCluster#snapshot_arns</a>.
        /// </summary>
        [<CustomOperation "snapshot_arns">]
        member _.SnapshotArns(state: MemorydbClusterState<'AclName, 'NodeType>, value: seq<string>) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.SnapshotArns <- (value |> Seq.toArray))
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#snapshot_name-1">MemorydbCluster#snapshot_name</a>.
        /// </summary>
        [<CustomOperation "snapshot_name">]
        member _.SnapshotName(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.SnapshotName <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#snapshot_retention_limit-1">MemorydbCluster#snapshot_retention_limit</a>.
        /// </summary>
        [<CustomOperation "snapshot_retention_limit">]
        member _.SnapshotRetentionLimit(state: MemorydbClusterState<'AclName, 'NodeType>, value: double) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.SnapshotRetentionLimit <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#snapshot_window-1">MemorydbCluster#snapshot_window</a>.
        /// </summary>
        [<CustomOperation "snapshot_window">]
        member _.SnapshotWindow(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.SnapshotWindow <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#sns_topic_arn-1">MemorydbCluster#sns_topic_arn</a>.
        /// </summary>
        [<CustomOperation "sns_topic_arn">]
        member _.SnsTopicArn(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.SnsTopicArn <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#subnet_group_name-1">MemorydbCluster#subnet_group_name</a>.
        /// </summary>
        [<CustomOperation "subnet_group_name">]
        member _.SubnetGroupName(state: MemorydbClusterState<'AclName, 'NodeType>, value: string) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.SubnetGroupName <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#tags-1">MemorydbCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MemorydbClusterState<'AclName, 'NodeType>, value: seq<string * string>) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#tags_all-1">MemorydbCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MemorydbClusterState<'AclName, 'NodeType>, value: seq<string * string>) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#timeouts-1">MemorydbCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MemorydbClusterState<'AclName, 'NodeType>, value: aws.MemorydbCluster.MemorydbClusterTimeouts) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#tls_enabled-1">MemorydbCluster#tls_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "tls_enabled">]
        member _.TlsEnabled(state: MemorydbClusterState<'AclName, 'NodeType>, value: bool) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.TlsEnabled <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_cluster#tls_enabled-1">MemorydbCluster#tls_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "tls_enabled">]
        member _.TlsEnabled(state: MemorydbClusterState<'AclName, 'NodeType>, value: HashiCorp.Cdktf.IResolvable) : MemorydbClusterState<'AclName, 'NodeType> =
            state.assignments.Add(fun config -> config.TlsEnabled <- value)
            state : MemorydbClusterState<'AclName, 'NodeType>

        member _.Run(state: MemorydbClusterState<Present, Present>) : aws.MemorydbCluster.MemorydbCluster =
            let config = aws.MemorydbCluster.MemorydbClusterConfig()
            for setter in state.assignments do
                setter config
            aws.MemorydbCluster.MemorydbCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.memorydbCluster: missing required arguments. Must call: acl_name, node_type.", 9999, IsError = true)>]
        member _.Run(_: MemorydbClusterState<_, _>) : aws.MemorydbCluster.MemorydbCluster =
            Unchecked.defaultof<aws.MemorydbCluster.MemorydbCluster>
