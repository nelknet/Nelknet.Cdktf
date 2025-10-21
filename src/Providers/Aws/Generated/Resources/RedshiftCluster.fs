namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftClusterState<'ClusterIdentifier, 'NodeType> = { assignments: ResizeArray<aws.RedshiftCluster.RedshiftClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster">aws_redshift_cluster</a>.
    /// </summary>
    type RedshiftClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftClusterState<Missing, Missing>)

        member _.Zero(()) : RedshiftClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftClusterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#cluster_identifier-1">RedshiftCluster#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RedshiftClusterState<Missing, 'NodeType>, value: string) : RedshiftClusterState<Present, 'NodeType> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftClusterState<Present, 'NodeType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#node_type-1">RedshiftCluster#node_type</a>.
        /// </summary>
        [<CustomOperation "node_type">]
        member _.NodeType(state: RedshiftClusterState<'ClusterIdentifier, Missing>, value: string) : RedshiftClusterState<'ClusterIdentifier, Present> =
            state.assignments.Add(fun config -> config.NodeType <- value)
            ({ assignments = state.assignments } : RedshiftClusterState<'ClusterIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#allow_version_upgrade-1">RedshiftCluster#allow_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_version_upgrade">]
        member _.AllowVersionUpgrade(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: bool) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.AllowVersionUpgrade <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#allow_version_upgrade-1">RedshiftCluster#allow_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_version_upgrade">]
        member _.AllowVersionUpgrade(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: HashiCorp.Cdktf.IResolvable) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.AllowVersionUpgrade <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#apply_immediately-1">RedshiftCluster#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: bool) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#apply_immediately-1">RedshiftCluster#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: HashiCorp.Cdktf.IResolvable) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#aqua_configuration_status-1">RedshiftCluster#aqua_configuration_status</a>.
        /// </summary>
        [<CustomOperation "aqua_configuration_status">]
        member _.AquaConfigurationStatus(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.AquaConfigurationStatus <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#automated_snapshot_retention_period-1">RedshiftCluster#automated_snapshot_retention_period</a>.
        /// </summary>
        [<CustomOperation "automated_snapshot_retention_period">]
        member _.AutomatedSnapshotRetentionPeriod(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: double) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.AutomatedSnapshotRetentionPeriod <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#availability_zone-1">RedshiftCluster#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#availability_zone_relocation_enabled-1">RedshiftCluster#availability_zone_relocation_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "availability_zone_relocation_enabled">]
        member _.AvailabilityZoneRelocationEnabled(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: bool) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.AvailabilityZoneRelocationEnabled <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#availability_zone_relocation_enabled-1">RedshiftCluster#availability_zone_relocation_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "availability_zone_relocation_enabled">]
        member _.AvailabilityZoneRelocationEnabled(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: HashiCorp.Cdktf.IResolvable) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.AvailabilityZoneRelocationEnabled <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#cluster_parameter_group_name-1">RedshiftCluster#cluster_parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "cluster_parameter_group_name">]
        member _.ClusterParameterGroupName(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.ClusterParameterGroupName <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#cluster_public_key-1">RedshiftCluster#cluster_public_key</a>.
        /// </summary>
        [<CustomOperation "cluster_public_key">]
        member _.ClusterPublicKey(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.ClusterPublicKey <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#cluster_revision_number-1">RedshiftCluster#cluster_revision_number</a>.
        /// </summary>
        [<CustomOperation "cluster_revision_number">]
        member _.ClusterRevisionNumber(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.ClusterRevisionNumber <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#cluster_subnet_group_name-1">RedshiftCluster#cluster_subnet_group_name</a>.
        /// </summary>
        [<CustomOperation "cluster_subnet_group_name">]
        member _.ClusterSubnetGroupName(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.ClusterSubnetGroupName <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#cluster_type-1">RedshiftCluster#cluster_type</a>.
        /// </summary>
        [<CustomOperation "cluster_type">]
        member _.ClusterType(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.ClusterType <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#cluster_version-1">RedshiftCluster#cluster_version</a>.
        /// </summary>
        [<CustomOperation "cluster_version">]
        member _.ClusterVersion(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.ClusterVersion <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#database_name-1">RedshiftCluster#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#default_iam_role_arn-1">RedshiftCluster#default_iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "default_iam_role_arn">]
        member _.DefaultIamRoleArn(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.DefaultIamRoleArn <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#elastic_ip-1">RedshiftCluster#elastic_ip</a>.
        /// </summary>
        [<CustomOperation "elastic_ip">]
        member _.ElasticIp(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.ElasticIp <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#encrypted-1">RedshiftCluster#encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: bool) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#encrypted-1">RedshiftCluster#encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: HashiCorp.Cdktf.IResolvable) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#endpoint-1">RedshiftCluster#endpoint</a>.
        /// </summary>
        [<CustomOperation "endpoint">]
        member _.Endpoint(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.Endpoint <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#enhanced_vpc_routing-1">RedshiftCluster#enhanced_vpc_routing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enhanced_vpc_routing">]
        member _.EnhancedVpcRouting(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: bool) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.EnhancedVpcRouting <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#enhanced_vpc_routing-1">RedshiftCluster#enhanced_vpc_routing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enhanced_vpc_routing">]
        member _.EnhancedVpcRouting(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: HashiCorp.Cdktf.IResolvable) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.EnhancedVpcRouting <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#final_snapshot_identifier-1">RedshiftCluster#final_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "final_snapshot_identifier">]
        member _.FinalSnapshotIdentifier(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.FinalSnapshotIdentifier <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#iam_roles-1">RedshiftCluster#iam_roles</a>.
        /// </summary>
        [<CustomOperation "iam_roles">]
        member _.IamRoles(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: seq<string>) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.IamRoles <- (value |> Seq.toArray))
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#id-1">RedshiftCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#kms_key_id-1">RedshiftCluster#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// logging block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#logging-1">RedshiftCluster#logging</a>
        /// </summary>
        [<CustomOperation "logging">]
        member _.Logging(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: aws.RedshiftCluster.RedshiftClusterLogging) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.Logging <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#maintenance_track_name-1">RedshiftCluster#maintenance_track_name</a>.
        /// </summary>
        [<CustomOperation "maintenance_track_name">]
        member _.MaintenanceTrackName(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.MaintenanceTrackName <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#manage_master_password-1">RedshiftCluster#manage_master_password</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_master_password">]
        member _.ManageMasterPassword(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: bool) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.ManageMasterPassword <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#manage_master_password-1">RedshiftCluster#manage_master_password</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_master_password">]
        member _.ManageMasterPassword(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: HashiCorp.Cdktf.IResolvable) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.ManageMasterPassword <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#manual_snapshot_retention_period-1">RedshiftCluster#manual_snapshot_retention_period</a>.
        /// </summary>
        [<CustomOperation "manual_snapshot_retention_period">]
        member _.ManualSnapshotRetentionPeriod(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: double) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.ManualSnapshotRetentionPeriod <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#master_password-1">RedshiftCluster#master_password</a>.
        /// </summary>
        [<CustomOperation "master_password">]
        member _.MasterPassword(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.MasterPassword <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#master_password_secret_kms_key_id-1">RedshiftCluster#master_password_secret_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "master_password_secret_kms_key_id">]
        member _.MasterPasswordSecretKmsKeyId(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.MasterPasswordSecretKmsKeyId <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#master_password_wo-1">RedshiftCluster#master_password_wo</a>.
        /// </summary>
        [<CustomOperation "master_password_wo">]
        member _.MasterPasswordWo(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.MasterPasswordWo <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#master_password_wo_version-1">RedshiftCluster#master_password_wo_version</a>.
        /// </summary>
        [<CustomOperation "master_password_wo_version">]
        member _.MasterPasswordWoVersion(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: double) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.MasterPasswordWoVersion <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#master_username-1">RedshiftCluster#master_username</a>.
        /// </summary>
        [<CustomOperation "master_username">]
        member _.MasterUsername(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.MasterUsername <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#multi_az-1">RedshiftCluster#multi_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_az">]
        member _.MultiAz(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: bool) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.MultiAz <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#multi_az-1">RedshiftCluster#multi_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_az">]
        member _.MultiAz(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: HashiCorp.Cdktf.IResolvable) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.MultiAz <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#number_of_nodes-1">RedshiftCluster#number_of_nodes</a>.
        /// </summary>
        [<CustomOperation "number_of_nodes">]
        member _.NumberOfNodes(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: double) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.NumberOfNodes <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#owner_account-1">RedshiftCluster#owner_account</a>.
        /// </summary>
        [<CustomOperation "owner_account">]
        member _.OwnerAccount(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.OwnerAccount <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#port-1">RedshiftCluster#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: double) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#preferred_maintenance_window-1">RedshiftCluster#preferred_maintenance_window</a>.
        /// </summary>
        [<CustomOperation "preferred_maintenance_window">]
        member _.PreferredMaintenanceWindow(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.PreferredMaintenanceWindow <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#publicly_accessible-1">RedshiftCluster#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: bool) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#publicly_accessible-1">RedshiftCluster#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: HashiCorp.Cdktf.IResolvable) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#skip_final_snapshot-1">RedshiftCluster#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: bool) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#skip_final_snapshot-1">RedshiftCluster#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: HashiCorp.Cdktf.IResolvable) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#snapshot_arn-1">RedshiftCluster#snapshot_arn</a>.
        /// </summary>
        [<CustomOperation "snapshot_arn">]
        member _.SnapshotArn(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.SnapshotArn <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#snapshot_cluster_identifier-1">RedshiftCluster#snapshot_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "snapshot_cluster_identifier">]
        member _.SnapshotClusterIdentifier(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.SnapshotClusterIdentifier <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// snapshot_copy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#snapshot_copy-1">RedshiftCluster#snapshot_copy</a>
        /// </summary>
        [<CustomOperation "snapshot_copy">]
        member _.SnapshotCopy(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: aws.RedshiftCluster.RedshiftClusterSnapshotCopy) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.SnapshotCopy <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#snapshot_identifier-1">RedshiftCluster#snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "snapshot_identifier">]
        member _.SnapshotIdentifier(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: string) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.SnapshotIdentifier <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#tags-1">RedshiftCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: seq<string * string>) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#tags_all-1">RedshiftCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: seq<string * string>) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#timeouts-1">RedshiftCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: aws.RedshiftCluster.RedshiftClusterTimeouts) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster#vpc_security_group_ids-1">RedshiftCluster#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: RedshiftClusterState<'ClusterIdentifier, 'NodeType>, value: seq<string>) : RedshiftClusterState<'ClusterIdentifier, 'NodeType> =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : RedshiftClusterState<'ClusterIdentifier, 'NodeType>

        member _.Run(state: RedshiftClusterState<Present, Present>) : aws.RedshiftCluster.RedshiftCluster =
            let config = aws.RedshiftCluster.RedshiftClusterConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftCluster.RedshiftCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftCluster: missing required arguments. Must call: cluster_identifier, node_type.", 9999, IsError = true)>]
        member _.Run(_: RedshiftClusterState<_, _>) : aws.RedshiftCluster.RedshiftCluster =
            Unchecked.defaultof<aws.RedshiftCluster.RedshiftCluster>
