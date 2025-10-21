namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NeptuneClusterState = { assignments: ResizeArray<aws.NeptuneCluster.NeptuneClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster">aws_neptune_cluster</a>.
    /// </summary>
    type NeptuneClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : NeptuneClusterState =
            { assignments = ResizeArray() }

        member _.Zero(()) : NeptuneClusterState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#allow_major_version_upgrade-1">NeptuneCluster#allow_major_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_major_version_upgrade">]
        member _.AllowMajorVersionUpgrade(state: NeptuneClusterState, value: bool) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.AllowMajorVersionUpgrade <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#allow_major_version_upgrade-1">NeptuneCluster#allow_major_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_major_version_upgrade">]
        member _.AllowMajorVersionUpgrade(state: NeptuneClusterState, value: HashiCorp.Cdktf.IResolvable) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.AllowMajorVersionUpgrade <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#apply_immediately-1">NeptuneCluster#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: NeptuneClusterState, value: bool) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#apply_immediately-1">NeptuneCluster#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: NeptuneClusterState, value: HashiCorp.Cdktf.IResolvable) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#availability_zones-1">NeptuneCluster#availability_zones</a>.
        /// </summary>
        [<CustomOperation "availability_zones">]
        member _.AvailabilityZones(state: NeptuneClusterState, value: seq<string>) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.AvailabilityZones <- (value |> Seq.toArray))
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#backup_retention_period-1">NeptuneCluster#backup_retention_period</a>.
        /// </summary>
        [<CustomOperation "backup_retention_period">]
        member _.BackupRetentionPeriod(state: NeptuneClusterState, value: double) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.BackupRetentionPeriod <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#cluster_identifier-1">NeptuneCluster#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#cluster_identifier_prefix-1">NeptuneCluster#cluster_identifier_prefix</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier_prefix">]
        member _.ClusterIdentifierPrefix(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.ClusterIdentifierPrefix <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#copy_tags_to_snapshot-1">NeptuneCluster#copy_tags_to_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_snapshot">]
        member _.CopyTagsToSnapshot(state: NeptuneClusterState, value: bool) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.CopyTagsToSnapshot <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#copy_tags_to_snapshot-1">NeptuneCluster#copy_tags_to_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_snapshot">]
        member _.CopyTagsToSnapshot(state: NeptuneClusterState, value: HashiCorp.Cdktf.IResolvable) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.CopyTagsToSnapshot <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#deletion_protection-1">NeptuneCluster#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: NeptuneClusterState, value: bool) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#deletion_protection-1">NeptuneCluster#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: NeptuneClusterState, value: HashiCorp.Cdktf.IResolvable) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#enable_cloudwatch_logs_exports-1">NeptuneCluster#enable_cloudwatch_logs_exports</a>.
        /// </summary>
        [<CustomOperation "enable_cloudwatch_logs_exports">]
        member _.EnableCloudwatchLogsExports(state: NeptuneClusterState, value: seq<string>) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.EnableCloudwatchLogsExports <- (value |> Seq.toArray))
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#engine-1">NeptuneCluster#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#engine_version-1">NeptuneCluster#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#final_snapshot_identifier-1">NeptuneCluster#final_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "final_snapshot_identifier">]
        member _.FinalSnapshotIdentifier(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.FinalSnapshotIdentifier <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#global_cluster_identifier-1">NeptuneCluster#global_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "global_cluster_identifier">]
        member _.GlobalClusterIdentifier(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.GlobalClusterIdentifier <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#iam_database_authentication_enabled-1">NeptuneCluster#iam_database_authentication_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "iam_database_authentication_enabled">]
        member _.IamDatabaseAuthenticationEnabled(state: NeptuneClusterState, value: bool) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.IamDatabaseAuthenticationEnabled <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#iam_database_authentication_enabled-1">NeptuneCluster#iam_database_authentication_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "iam_database_authentication_enabled">]
        member _.IamDatabaseAuthenticationEnabled(state: NeptuneClusterState, value: HashiCorp.Cdktf.IResolvable) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.IamDatabaseAuthenticationEnabled <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#iam_roles-1">NeptuneCluster#iam_roles</a>.
        /// </summary>
        [<CustomOperation "iam_roles">]
        member _.IamRoles(state: NeptuneClusterState, value: seq<string>) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.IamRoles <- (value |> Seq.toArray))
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#id-1">NeptuneCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#kms_key_arn-1">NeptuneCluster#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#neptune_cluster_parameter_group_name-1">NeptuneCluster#neptune_cluster_parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "neptune_cluster_parameter_group_name">]
        member _.NeptuneClusterParameterGroupName(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.NeptuneClusterParameterGroupName <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#neptune_instance_parameter_group_name-1">NeptuneCluster#neptune_instance_parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "neptune_instance_parameter_group_name">]
        member _.NeptuneInstanceParameterGroupName(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.NeptuneInstanceParameterGroupName <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#neptune_subnet_group_name-1">NeptuneCluster#neptune_subnet_group_name</a>.
        /// </summary>
        [<CustomOperation "neptune_subnet_group_name">]
        member _.NeptuneSubnetGroupName(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.NeptuneSubnetGroupName <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#port-1">NeptuneCluster#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: NeptuneClusterState, value: double) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.Port <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#preferred_backup_window-1">NeptuneCluster#preferred_backup_window</a>.
        /// </summary>
        [<CustomOperation "preferred_backup_window">]
        member _.PreferredBackupWindow(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.PreferredBackupWindow <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#preferred_maintenance_window-1">NeptuneCluster#preferred_maintenance_window</a>.
        /// </summary>
        [<CustomOperation "preferred_maintenance_window">]
        member _.PreferredMaintenanceWindow(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.PreferredMaintenanceWindow <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#replication_source_identifier-1">NeptuneCluster#replication_source_identifier</a>.
        /// </summary>
        [<CustomOperation "replication_source_identifier">]
        member _.ReplicationSourceIdentifier(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.ReplicationSourceIdentifier <- value)
            state : NeptuneClusterState

        /// <summary>
        /// serverless_v2_scaling_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#serverless_v2_scaling_configuration-1">NeptuneCluster#serverless_v2_scaling_configuration</a>
        /// </summary>
        [<CustomOperation "serverless_v2_scaling_configuration">]
        member _.ServerlessV2ScalingConfiguration(state: NeptuneClusterState, value: aws.NeptuneCluster.NeptuneClusterServerlessV2ScalingConfiguration) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.ServerlessV2ScalingConfiguration <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#skip_final_snapshot-1">NeptuneCluster#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: NeptuneClusterState, value: bool) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#skip_final_snapshot-1">NeptuneCluster#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: NeptuneClusterState, value: HashiCorp.Cdktf.IResolvable) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#snapshot_identifier-1">NeptuneCluster#snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "snapshot_identifier">]
        member _.SnapshotIdentifier(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.SnapshotIdentifier <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#storage_encrypted-1">NeptuneCluster#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: NeptuneClusterState, value: bool) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#storage_encrypted-1">NeptuneCluster#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: NeptuneClusterState, value: HashiCorp.Cdktf.IResolvable) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#storage_type-1">NeptuneCluster#storage_type</a>.
        /// </summary>
        [<CustomOperation "storage_type">]
        member _.StorageType(state: NeptuneClusterState, value: string) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.StorageType <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#tags-1">NeptuneCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NeptuneClusterState, value: seq<string * string>) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#tags_all-1">NeptuneCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NeptuneClusterState, value: seq<string * string>) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NeptuneClusterState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#timeouts-1">NeptuneCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NeptuneClusterState, value: aws.NeptuneCluster.NeptuneClusterTimeouts) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NeptuneClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#vpc_security_group_ids-1">NeptuneCluster#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: NeptuneClusterState, value: seq<string>) : NeptuneClusterState =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : NeptuneClusterState

        member _.Run(state: NeptuneClusterState) : aws.NeptuneCluster.NeptuneCluster =
            let config = aws.NeptuneCluster.NeptuneClusterConfig()
            for setter in state.assignments do
                setter config
            aws.NeptuneCluster.NeptuneCluster(StackContext.get (), logicalId, config)
