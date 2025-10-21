namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> = { assignments: ResizeArray<aws.RdsClusterInstance.RdsClusterInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance">aws_rds_cluster_instance</a>.
    /// </summary>
    type RdsClusterInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsClusterInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsClusterInstanceState<Missing, Missing, Missing>)

        member _.Zero(()) : RdsClusterInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsClusterInstanceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#cluster_identifier-1">RdsClusterInstance#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RdsClusterInstanceState<Missing, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<Present, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : RdsClusterInstanceState<Present, 'Engine, 'InstanceClass>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#engine-1">RdsClusterInstance#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: RdsClusterInstanceState<'ClusterIdentifier, Missing, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, Present, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Engine <- value)
            ({ assignments = state.assignments } : RdsClusterInstanceState<'ClusterIdentifier, Present, 'InstanceClass>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#instance_class-1">RdsClusterInstance#instance_class</a>.
        /// </summary>
        [<CustomOperation "instance_class">]
        member _.InstanceClass(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, Missing>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, Present> =
            state.assignments.Add(fun config -> config.InstanceClass <- value)
            ({ assignments = state.assignments } : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#apply_immediately-1">RdsClusterInstance#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: bool) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#apply_immediately-1">RdsClusterInstance#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#auto_minor_version_upgrade-1">RdsClusterInstance#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: bool) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#auto_minor_version_upgrade-1">RdsClusterInstance#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#availability_zone-1">RdsClusterInstance#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#ca_cert_identifier-1">RdsClusterInstance#ca_cert_identifier</a>.
        /// </summary>
        [<CustomOperation "ca_cert_identifier">]
        member _.CaCertIdentifier(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.CaCertIdentifier <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#copy_tags_to_snapshot-1">RdsClusterInstance#copy_tags_to_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_snapshot">]
        member _.CopyTagsToSnapshot(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: bool) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.CopyTagsToSnapshot <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#copy_tags_to_snapshot-1">RdsClusterInstance#copy_tags_to_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_snapshot">]
        member _.CopyTagsToSnapshot(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.CopyTagsToSnapshot <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#custom_iam_instance_profile-1">RdsClusterInstance#custom_iam_instance_profile</a>.
        /// </summary>
        [<CustomOperation "custom_iam_instance_profile">]
        member _.CustomIamInstanceProfile(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.CustomIamInstanceProfile <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#db_parameter_group_name-1">RdsClusterInstance#db_parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "db_parameter_group_name">]
        member _.DbParameterGroupName(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.DbParameterGroupName <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#db_subnet_group_name-1">RdsClusterInstance#db_subnet_group_name</a>.
        /// </summary>
        [<CustomOperation "db_subnet_group_name">]
        member _.DbSubnetGroupName(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.DbSubnetGroupName <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#engine_version-1">RdsClusterInstance#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#force_destroy-1">RdsClusterInstance#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: bool) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#force_destroy-1">RdsClusterInstance#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#id-1">RdsClusterInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#identifier-1">RdsClusterInstance#identifier</a>.
        /// </summary>
        [<CustomOperation "identifier">]
        member _.Identifier(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Identifier <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#identifier_prefix-1">RdsClusterInstance#identifier_prefix</a>.
        /// </summary>
        [<CustomOperation "identifier_prefix">]
        member _.IdentifierPrefix(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.IdentifierPrefix <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#monitoring_interval-1">RdsClusterInstance#monitoring_interval</a>.
        /// </summary>
        [<CustomOperation "monitoring_interval">]
        member _.MonitoringInterval(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: double) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.MonitoringInterval <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#monitoring_role_arn-1">RdsClusterInstance#monitoring_role_arn</a>.
        /// </summary>
        [<CustomOperation "monitoring_role_arn">]
        member _.MonitoringRoleArn(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.MonitoringRoleArn <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#performance_insights_enabled-1">RdsClusterInstance#performance_insights_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "performance_insights_enabled">]
        member _.PerformanceInsightsEnabled(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: bool) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PerformanceInsightsEnabled <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#performance_insights_enabled-1">RdsClusterInstance#performance_insights_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "performance_insights_enabled">]
        member _.PerformanceInsightsEnabled(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PerformanceInsightsEnabled <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#performance_insights_kms_key_id-1">RdsClusterInstance#performance_insights_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "performance_insights_kms_key_id">]
        member _.PerformanceInsightsKmsKeyId(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PerformanceInsightsKmsKeyId <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#performance_insights_retention_period-1">RdsClusterInstance#performance_insights_retention_period</a>.
        /// </summary>
        [<CustomOperation "performance_insights_retention_period">]
        member _.PerformanceInsightsRetentionPeriod(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: double) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PerformanceInsightsRetentionPeriod <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#preferred_backup_window-1">RdsClusterInstance#preferred_backup_window</a>.
        /// </summary>
        [<CustomOperation "preferred_backup_window">]
        member _.PreferredBackupWindow(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PreferredBackupWindow <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#preferred_maintenance_window-1">RdsClusterInstance#preferred_maintenance_window</a>.
        /// </summary>
        [<CustomOperation "preferred_maintenance_window">]
        member _.PreferredMaintenanceWindow(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: string) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PreferredMaintenanceWindow <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#promotion_tier-1">RdsClusterInstance#promotion_tier</a>.
        /// </summary>
        [<CustomOperation "promotion_tier">]
        member _.PromotionTier(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: double) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PromotionTier <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#publicly_accessible-1">RdsClusterInstance#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: bool) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#publicly_accessible-1">RdsClusterInstance#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#tags-1">RdsClusterInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: seq<string * string>) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#tags_all-1">RdsClusterInstance#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: seq<string * string>) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_instance#timeouts-1">RdsClusterInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>, value: aws.RdsClusterInstance.RdsClusterInstanceTimeouts) : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RdsClusterInstanceState<'ClusterIdentifier, 'Engine, 'InstanceClass>

        member _.Run(state: RdsClusterInstanceState<Present, Present, Present>) : aws.RdsClusterInstance.RdsClusterInstance =
            let config = aws.RdsClusterInstance.RdsClusterInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.RdsClusterInstance.RdsClusterInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsClusterInstance: missing required arguments. Must call: cluster_identifier, engine, instance_class.", 9999, IsError = true)>]
        member _.Run(_: RdsClusterInstanceState<_, _, _>) : aws.RdsClusterInstance.RdsClusterInstance =
            Unchecked.defaultof<aws.RdsClusterInstance.RdsClusterInstance>
