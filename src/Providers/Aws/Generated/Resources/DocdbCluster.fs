namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DocdbClusterState = { assignments: ResizeArray<aws.DocdbCluster.DocdbClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster">aws_docdb_cluster</a>.
    /// </summary>
    type DocdbClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DocdbClusterState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DocdbClusterState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#allow_major_version_upgrade-1">DocdbCluster#allow_major_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_major_version_upgrade">]
        member _.AllowMajorVersionUpgrade(state: DocdbClusterState, value: bool) : DocdbClusterState =
            state.assignments.Add(fun config -> config.AllowMajorVersionUpgrade <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#allow_major_version_upgrade-1">DocdbCluster#allow_major_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_major_version_upgrade">]
        member _.AllowMajorVersionUpgrade(state: DocdbClusterState, value: HashiCorp.Cdktf.IResolvable) : DocdbClusterState =
            state.assignments.Add(fun config -> config.AllowMajorVersionUpgrade <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#apply_immediately-1">DocdbCluster#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: DocdbClusterState, value: bool) : DocdbClusterState =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#apply_immediately-1">DocdbCluster#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: DocdbClusterState, value: HashiCorp.Cdktf.IResolvable) : DocdbClusterState =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#availability_zones-1">DocdbCluster#availability_zones</a>.
        /// </summary>
        [<CustomOperation "availability_zones">]
        member _.AvailabilityZones(state: DocdbClusterState, value: seq<string>) : DocdbClusterState =
            state.assignments.Add(fun config -> config.AvailabilityZones <- (value |> Seq.toArray))
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#backup_retention_period-1">DocdbCluster#backup_retention_period</a>.
        /// </summary>
        [<CustomOperation "backup_retention_period">]
        member _.BackupRetentionPeriod(state: DocdbClusterState, value: double) : DocdbClusterState =
            state.assignments.Add(fun config -> config.BackupRetentionPeriod <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#cluster_identifier-1">DocdbCluster#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#cluster_identifier_prefix-1">DocdbCluster#cluster_identifier_prefix</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier_prefix">]
        member _.ClusterIdentifierPrefix(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.ClusterIdentifierPrefix <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#cluster_members-1">DocdbCluster#cluster_members</a>.
        /// </summary>
        [<CustomOperation "cluster_members">]
        member _.ClusterMembers(state: DocdbClusterState, value: seq<string>) : DocdbClusterState =
            state.assignments.Add(fun config -> config.ClusterMembers <- (value |> Seq.toArray))
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#db_cluster_parameter_group_name-1">DocdbCluster#db_cluster_parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "db_cluster_parameter_group_name">]
        member _.DbClusterParameterGroupName(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.DbClusterParameterGroupName <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#db_subnet_group_name-1">DocdbCluster#db_subnet_group_name</a>.
        /// </summary>
        [<CustomOperation "db_subnet_group_name">]
        member _.DbSubnetGroupName(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.DbSubnetGroupName <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#deletion_protection-1">DocdbCluster#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: DocdbClusterState, value: bool) : DocdbClusterState =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#deletion_protection-1">DocdbCluster#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: DocdbClusterState, value: HashiCorp.Cdktf.IResolvable) : DocdbClusterState =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#enabled_cloudwatch_logs_exports-1">DocdbCluster#enabled_cloudwatch_logs_exports</a>.
        /// </summary>
        [<CustomOperation "enabled_cloudwatch_logs_exports">]
        member _.EnabledCloudwatchLogsExports(state: DocdbClusterState, value: seq<string>) : DocdbClusterState =
            state.assignments.Add(fun config -> config.EnabledCloudwatchLogsExports <- (value |> Seq.toArray))
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#engine-1">DocdbCluster#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#engine_version-1">DocdbCluster#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#final_snapshot_identifier-1">DocdbCluster#final_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "final_snapshot_identifier">]
        member _.FinalSnapshotIdentifier(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.FinalSnapshotIdentifier <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#global_cluster_identifier-1">DocdbCluster#global_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "global_cluster_identifier">]
        member _.GlobalClusterIdentifier(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.GlobalClusterIdentifier <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#id-1">DocdbCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#kms_key_id-1">DocdbCluster#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#manage_master_user_password-1">DocdbCluster#manage_master_user_password</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_master_user_password">]
        member _.ManageMasterUserPassword(state: DocdbClusterState, value: bool) : DocdbClusterState =
            state.assignments.Add(fun config -> config.ManageMasterUserPassword <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#manage_master_user_password-1">DocdbCluster#manage_master_user_password</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_master_user_password">]
        member _.ManageMasterUserPassword(state: DocdbClusterState, value: HashiCorp.Cdktf.IResolvable) : DocdbClusterState =
            state.assignments.Add(fun config -> config.ManageMasterUserPassword <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#master_password-1">DocdbCluster#master_password</a>.
        /// </summary>
        [<CustomOperation "master_password">]
        member _.MasterPassword(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.MasterPassword <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#master_password_wo-1">DocdbCluster#master_password_wo</a>.
        /// </summary>
        [<CustomOperation "master_password_wo">]
        member _.MasterPasswordWo(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.MasterPasswordWo <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#master_password_wo_version-1">DocdbCluster#master_password_wo_version</a>.
        /// </summary>
        [<CustomOperation "master_password_wo_version">]
        member _.MasterPasswordWoVersion(state: DocdbClusterState, value: double) : DocdbClusterState =
            state.assignments.Add(fun config -> config.MasterPasswordWoVersion <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#master_username-1">DocdbCluster#master_username</a>.
        /// </summary>
        [<CustomOperation "master_username">]
        member _.MasterUsername(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.MasterUsername <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#port-1">DocdbCluster#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: DocdbClusterState, value: double) : DocdbClusterState =
            state.assignments.Add(fun config -> config.Port <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#preferred_backup_window-1">DocdbCluster#preferred_backup_window</a>.
        /// </summary>
        [<CustomOperation "preferred_backup_window">]
        member _.PreferredBackupWindow(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.PreferredBackupWindow <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#preferred_maintenance_window-1">DocdbCluster#preferred_maintenance_window</a>.
        /// </summary>
        [<CustomOperation "preferred_maintenance_window">]
        member _.PreferredMaintenanceWindow(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.PreferredMaintenanceWindow <- value)
            state : DocdbClusterState

        /// <summary>
        /// restore_to_point_in_time block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#restore_to_point_in_time-1">DocdbCluster#restore_to_point_in_time</a>
        /// </summary>
        [<CustomOperation "restore_to_point_in_time">]
        member _.RestoreToPointInTime(state: DocdbClusterState, value: aws.DocdbCluster.DocdbClusterRestoreToPointInTime) : DocdbClusterState =
            state.assignments.Add(fun config -> config.RestoreToPointInTime <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#skip_final_snapshot-1">DocdbCluster#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: DocdbClusterState, value: bool) : DocdbClusterState =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#skip_final_snapshot-1">DocdbCluster#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: DocdbClusterState, value: HashiCorp.Cdktf.IResolvable) : DocdbClusterState =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#snapshot_identifier-1">DocdbCluster#snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "snapshot_identifier">]
        member _.SnapshotIdentifier(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.SnapshotIdentifier <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#storage_encrypted-1">DocdbCluster#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: DocdbClusterState, value: bool) : DocdbClusterState =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#storage_encrypted-1">DocdbCluster#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: DocdbClusterState, value: HashiCorp.Cdktf.IResolvable) : DocdbClusterState =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#storage_type-1">DocdbCluster#storage_type</a>.
        /// </summary>
        [<CustomOperation "storage_type">]
        member _.StorageType(state: DocdbClusterState, value: string) : DocdbClusterState =
            state.assignments.Add(fun config -> config.StorageType <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#tags-1">DocdbCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DocdbClusterState, value: seq<string * string>) : DocdbClusterState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#tags_all-1">DocdbCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DocdbClusterState, value: seq<string * string>) : DocdbClusterState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DocdbClusterState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#timeouts-1">DocdbCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DocdbClusterState, value: aws.DocdbCluster.DocdbClusterTimeouts) : DocdbClusterState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DocdbClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster#vpc_security_group_ids-1">DocdbCluster#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: DocdbClusterState, value: seq<string>) : DocdbClusterState =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : DocdbClusterState

        member _.Run(state: DocdbClusterState) : aws.DocdbCluster.DocdbCluster =
            let config = aws.DocdbCluster.DocdbClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DocdbCluster.DocdbCluster(StackContext.get (), logicalId, config)
