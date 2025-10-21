namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsClusterState<'Engine> = { assignments: ResizeArray<aws.RdsCluster.RdsClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster">aws_rds_cluster</a>.
    /// </summary>
    type RdsClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsClusterState<Missing> =
            ({ assignments = ResizeArray() } : RdsClusterState<Missing>)

        member _.Zero(()) : RdsClusterState<Missing> =
            ({ assignments = ResizeArray() } : RdsClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#engine-1">RdsCluster#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: RdsClusterState<Missing>, value: string) : RdsClusterState<Present> =
            state.assignments.Add(fun config -> config.Engine <- value)
            ({ assignments = state.assignments } : RdsClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#allocated_storage-1">RdsCluster#allocated_storage</a>.
        /// </summary>
        [<CustomOperation "allocated_storage">]
        member _.AllocatedStorage(state: RdsClusterState<'Engine>, value: double) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.AllocatedStorage <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#allow_major_version_upgrade-1">RdsCluster#allow_major_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_major_version_upgrade">]
        member _.AllowMajorVersionUpgrade(state: RdsClusterState<'Engine>, value: bool) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.AllowMajorVersionUpgrade <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#allow_major_version_upgrade-1">RdsCluster#allow_major_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_major_version_upgrade">]
        member _.AllowMajorVersionUpgrade(state: RdsClusterState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.AllowMajorVersionUpgrade <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#apply_immediately-1">RdsCluster#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: RdsClusterState<'Engine>, value: bool) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#apply_immediately-1">RdsCluster#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: RdsClusterState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#availability_zones-1">RdsCluster#availability_zones</a>.
        /// </summary>
        [<CustomOperation "availability_zones">]
        member _.AvailabilityZones(state: RdsClusterState<'Engine>, value: seq<string>) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.AvailabilityZones <- (value |> Seq.toArray))
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#backtrack_window-1">RdsCluster#backtrack_window</a>.
        /// </summary>
        [<CustomOperation "backtrack_window">]
        member _.BacktrackWindow(state: RdsClusterState<'Engine>, value: double) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.BacktrackWindow <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#backup_retention_period-1">RdsCluster#backup_retention_period</a>.
        /// </summary>
        [<CustomOperation "backup_retention_period">]
        member _.BackupRetentionPeriod(state: RdsClusterState<'Engine>, value: double) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.BackupRetentionPeriod <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#ca_certificate_identifier-1">RdsCluster#ca_certificate_identifier</a>.
        /// </summary>
        [<CustomOperation "ca_certificate_identifier">]
        member _.CaCertificateIdentifier(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.CaCertificateIdentifier <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#cluster_identifier-1">RdsCluster#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#cluster_identifier_prefix-1">RdsCluster#cluster_identifier_prefix</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier_prefix">]
        member _.ClusterIdentifierPrefix(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.ClusterIdentifierPrefix <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#cluster_members-1">RdsCluster#cluster_members</a>.
        /// </summary>
        [<CustomOperation "cluster_members">]
        member _.ClusterMembers(state: RdsClusterState<'Engine>, value: seq<string>) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.ClusterMembers <- (value |> Seq.toArray))
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#cluster_scalability_type-1">RdsCluster#cluster_scalability_type</a>.
        /// </summary>
        [<CustomOperation "cluster_scalability_type">]
        member _.ClusterScalabilityType(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.ClusterScalabilityType <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#copy_tags_to_snapshot-1">RdsCluster#copy_tags_to_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_snapshot">]
        member _.CopyTagsToSnapshot(state: RdsClusterState<'Engine>, value: bool) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.CopyTagsToSnapshot <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#copy_tags_to_snapshot-1">RdsCluster#copy_tags_to_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_snapshot">]
        member _.CopyTagsToSnapshot(state: RdsClusterState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.CopyTagsToSnapshot <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#database_insights_mode-1">RdsCluster#database_insights_mode</a>.
        /// </summary>
        [<CustomOperation "database_insights_mode">]
        member _.DatabaseInsightsMode(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.DatabaseInsightsMode <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#database_name-1">RdsCluster#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#db_cluster_instance_class-1">RdsCluster#db_cluster_instance_class</a>.
        /// </summary>
        [<CustomOperation "db_cluster_instance_class">]
        member _.DbClusterInstanceClass(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.DbClusterInstanceClass <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#db_cluster_parameter_group_name-1">RdsCluster#db_cluster_parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "db_cluster_parameter_group_name">]
        member _.DbClusterParameterGroupName(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.DbClusterParameterGroupName <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#db_instance_parameter_group_name-1">RdsCluster#db_instance_parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "db_instance_parameter_group_name">]
        member _.DbInstanceParameterGroupName(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.DbInstanceParameterGroupName <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#db_subnet_group_name-1">RdsCluster#db_subnet_group_name</a>.
        /// </summary>
        [<CustomOperation "db_subnet_group_name">]
        member _.DbSubnetGroupName(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.DbSubnetGroupName <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#db_system_id-1">RdsCluster#db_system_id</a>.
        /// </summary>
        [<CustomOperation "db_system_id">]
        member _.DbSystemId(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.DbSystemId <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#delete_automated_backups-1">RdsCluster#delete_automated_backups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_automated_backups">]
        member _.DeleteAutomatedBackups(state: RdsClusterState<'Engine>, value: bool) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.DeleteAutomatedBackups <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#delete_automated_backups-1">RdsCluster#delete_automated_backups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_automated_backups">]
        member _.DeleteAutomatedBackups(state: RdsClusterState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.DeleteAutomatedBackups <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#deletion_protection-1">RdsCluster#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: RdsClusterState<'Engine>, value: bool) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#deletion_protection-1">RdsCluster#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: RdsClusterState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#domain-1">RdsCluster#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.Domain <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#domain_iam_role_name-1">RdsCluster#domain_iam_role_name</a>.
        /// </summary>
        [<CustomOperation "domain_iam_role_name">]
        member _.DomainIamRoleName(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.DomainIamRoleName <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#enabled_cloudwatch_logs_exports-1">RdsCluster#enabled_cloudwatch_logs_exports</a>.
        /// </summary>
        [<CustomOperation "enabled_cloudwatch_logs_exports">]
        member _.EnabledCloudwatchLogsExports(state: RdsClusterState<'Engine>, value: seq<string>) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.EnabledCloudwatchLogsExports <- (value |> Seq.toArray))
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#enable_global_write_forwarding-1">RdsCluster#enable_global_write_forwarding</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_global_write_forwarding">]
        member _.EnableGlobalWriteForwarding(state: RdsClusterState<'Engine>, value: bool) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.EnableGlobalWriteForwarding <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#enable_global_write_forwarding-1">RdsCluster#enable_global_write_forwarding</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_global_write_forwarding">]
        member _.EnableGlobalWriteForwarding(state: RdsClusterState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.EnableGlobalWriteForwarding <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#enable_http_endpoint-1">RdsCluster#enable_http_endpoint</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_http_endpoint">]
        member _.EnableHttpEndpoint(state: RdsClusterState<'Engine>, value: bool) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.EnableHttpEndpoint <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#enable_http_endpoint-1">RdsCluster#enable_http_endpoint</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_http_endpoint">]
        member _.EnableHttpEndpoint(state: RdsClusterState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.EnableHttpEndpoint <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#enable_local_write_forwarding-1">RdsCluster#enable_local_write_forwarding</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_local_write_forwarding">]
        member _.EnableLocalWriteForwarding(state: RdsClusterState<'Engine>, value: bool) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.EnableLocalWriteForwarding <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#enable_local_write_forwarding-1">RdsCluster#enable_local_write_forwarding</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_local_write_forwarding">]
        member _.EnableLocalWriteForwarding(state: RdsClusterState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.EnableLocalWriteForwarding <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#engine_lifecycle_support-1">RdsCluster#engine_lifecycle_support</a>.
        /// </summary>
        [<CustomOperation "engine_lifecycle_support">]
        member _.EngineLifecycleSupport(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.EngineLifecycleSupport <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#engine_mode-1">RdsCluster#engine_mode</a>.
        /// </summary>
        [<CustomOperation "engine_mode">]
        member _.EngineMode(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.EngineMode <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#engine_version-1">RdsCluster#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#final_snapshot_identifier-1">RdsCluster#final_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "final_snapshot_identifier">]
        member _.FinalSnapshotIdentifier(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.FinalSnapshotIdentifier <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#global_cluster_identifier-1">RdsCluster#global_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "global_cluster_identifier">]
        member _.GlobalClusterIdentifier(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.GlobalClusterIdentifier <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#iam_database_authentication_enabled-1">RdsCluster#iam_database_authentication_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "iam_database_authentication_enabled">]
        member _.IamDatabaseAuthenticationEnabled(state: RdsClusterState<'Engine>, value: bool) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.IamDatabaseAuthenticationEnabled <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#iam_database_authentication_enabled-1">RdsCluster#iam_database_authentication_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "iam_database_authentication_enabled">]
        member _.IamDatabaseAuthenticationEnabled(state: RdsClusterState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.IamDatabaseAuthenticationEnabled <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#iam_roles-1">RdsCluster#iam_roles</a>.
        /// </summary>
        [<CustomOperation "iam_roles">]
        member _.IamRoles(state: RdsClusterState<'Engine>, value: seq<string>) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.IamRoles <- (value |> Seq.toArray))
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#id-1">RdsCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#iops-1">RdsCluster#iops</a>.
        /// </summary>
        [<CustomOperation "iops">]
        member _.Iops(state: RdsClusterState<'Engine>, value: double) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.Iops <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#kms_key_id-1">RdsCluster#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#manage_master_user_password-1">RdsCluster#manage_master_user_password</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_master_user_password">]
        member _.ManageMasterUserPassword(state: RdsClusterState<'Engine>, value: bool) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.ManageMasterUserPassword <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#manage_master_user_password-1">RdsCluster#manage_master_user_password</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_master_user_password">]
        member _.ManageMasterUserPassword(state: RdsClusterState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.ManageMasterUserPassword <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#master_password-1">RdsCluster#master_password</a>.
        /// </summary>
        [<CustomOperation "master_password">]
        member _.MasterPassword(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.MasterPassword <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#master_password_wo-1">RdsCluster#master_password_wo</a>.
        /// </summary>
        [<CustomOperation "master_password_wo">]
        member _.MasterPasswordWo(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.MasterPasswordWo <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#master_password_wo_version-1">RdsCluster#master_password_wo_version</a>.
        /// </summary>
        [<CustomOperation "master_password_wo_version">]
        member _.MasterPasswordWoVersion(state: RdsClusterState<'Engine>, value: double) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.MasterPasswordWoVersion <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#master_username-1">RdsCluster#master_username</a>.
        /// </summary>
        [<CustomOperation "master_username">]
        member _.MasterUsername(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.MasterUsername <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#master_user_secret_kms_key_id-1">RdsCluster#master_user_secret_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "master_user_secret_kms_key_id">]
        member _.MasterUserSecretKmsKeyId(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.MasterUserSecretKmsKeyId <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#monitoring_interval-1">RdsCluster#monitoring_interval</a>.
        /// </summary>
        [<CustomOperation "monitoring_interval">]
        member _.MonitoringInterval(state: RdsClusterState<'Engine>, value: double) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.MonitoringInterval <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#monitoring_role_arn-1">RdsCluster#monitoring_role_arn</a>.
        /// </summary>
        [<CustomOperation "monitoring_role_arn">]
        member _.MonitoringRoleArn(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.MonitoringRoleArn <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#network_type-1">RdsCluster#network_type</a>.
        /// </summary>
        [<CustomOperation "network_type">]
        member _.NetworkType(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.NetworkType <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#performance_insights_enabled-1">RdsCluster#performance_insights_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "performance_insights_enabled">]
        member _.PerformanceInsightsEnabled(state: RdsClusterState<'Engine>, value: bool) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.PerformanceInsightsEnabled <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#performance_insights_enabled-1">RdsCluster#performance_insights_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "performance_insights_enabled">]
        member _.PerformanceInsightsEnabled(state: RdsClusterState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.PerformanceInsightsEnabled <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#performance_insights_kms_key_id-1">RdsCluster#performance_insights_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "performance_insights_kms_key_id">]
        member _.PerformanceInsightsKmsKeyId(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.PerformanceInsightsKmsKeyId <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#performance_insights_retention_period-1">RdsCluster#performance_insights_retention_period</a>.
        /// </summary>
        [<CustomOperation "performance_insights_retention_period">]
        member _.PerformanceInsightsRetentionPeriod(state: RdsClusterState<'Engine>, value: double) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.PerformanceInsightsRetentionPeriod <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#port-1">RdsCluster#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: RdsClusterState<'Engine>, value: double) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#preferred_backup_window-1">RdsCluster#preferred_backup_window</a>.
        /// </summary>
        [<CustomOperation "preferred_backup_window">]
        member _.PreferredBackupWindow(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.PreferredBackupWindow <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#preferred_maintenance_window-1">RdsCluster#preferred_maintenance_window</a>.
        /// </summary>
        [<CustomOperation "preferred_maintenance_window">]
        member _.PreferredMaintenanceWindow(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.PreferredMaintenanceWindow <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#replication_source_identifier-1">RdsCluster#replication_source_identifier</a>.
        /// </summary>
        [<CustomOperation "replication_source_identifier">]
        member _.ReplicationSourceIdentifier(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.ReplicationSourceIdentifier <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// restore_to_point_in_time block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#restore_to_point_in_time-1">RdsCluster#restore_to_point_in_time</a>
        /// </summary>
        [<CustomOperation "restore_to_point_in_time">]
        member _.RestoreToPointInTime(state: RdsClusterState<'Engine>, value: aws.RdsCluster.RdsClusterRestoreToPointInTime) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.RestoreToPointInTime <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// s3_import block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#s3_import-1">RdsCluster#s3_import</a>
        /// </summary>
        [<CustomOperation "s3_import">]
        member _.S3Import(state: RdsClusterState<'Engine>, value: aws.RdsCluster.RdsClusterS3Import) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.S3Import <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// scaling_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#scaling_configuration-1">RdsCluster#scaling_configuration</a>
        /// </summary>
        [<CustomOperation "scaling_configuration">]
        member _.ScalingConfiguration(state: RdsClusterState<'Engine>, value: aws.RdsCluster.RdsClusterScalingConfiguration) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.ScalingConfiguration <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// serverlessv2_scaling_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#serverlessv2_scaling_configuration-1">RdsCluster#serverlessv2_scaling_configuration</a>
        /// </summary>
        [<CustomOperation "serverlessv2_scaling_configuration">]
        member _.Serverlessv2ScalingConfiguration(state: RdsClusterState<'Engine>, value: aws.RdsCluster.RdsClusterServerlessv2ScalingConfiguration) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.Serverlessv2ScalingConfiguration <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#skip_final_snapshot-1">RdsCluster#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: RdsClusterState<'Engine>, value: bool) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#skip_final_snapshot-1">RdsCluster#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: RdsClusterState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#snapshot_identifier-1">RdsCluster#snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "snapshot_identifier">]
        member _.SnapshotIdentifier(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.SnapshotIdentifier <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#source_region-1">RdsCluster#source_region</a>.
        /// </summary>
        [<CustomOperation "source_region">]
        member _.SourceRegion(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.SourceRegion <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#storage_encrypted-1">RdsCluster#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: RdsClusterState<'Engine>, value: bool) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#storage_encrypted-1">RdsCluster#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: RdsClusterState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#storage_type-1">RdsCluster#storage_type</a>.
        /// </summary>
        [<CustomOperation "storage_type">]
        member _.StorageType(state: RdsClusterState<'Engine>, value: string) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.StorageType <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#tags-1">RdsCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RdsClusterState<'Engine>, value: seq<string * string>) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#tags_all-1">RdsCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RdsClusterState<'Engine>, value: seq<string * string>) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#timeouts-1">RdsCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RdsClusterState<'Engine>, value: aws.RdsCluster.RdsClusterTimeouts) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RdsClusterState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster#vpc_security_group_ids-1">RdsCluster#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: RdsClusterState<'Engine>, value: seq<string>) : RdsClusterState<'Engine> =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : RdsClusterState<'Engine>

        member _.Run(state: RdsClusterState<Present>) : aws.RdsCluster.RdsCluster =
            let config = aws.RdsCluster.RdsClusterConfig()
            for setter in state.assignments do
                setter config
            aws.RdsCluster.RdsCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsCluster: missing required arguments. Must call: engine.", 9999, IsError = true)>]
        member _.Run(_: RdsClusterState<_>) : aws.RdsCluster.RdsCluster =
            Unchecked.defaultof<aws.RdsCluster.RdsCluster>
