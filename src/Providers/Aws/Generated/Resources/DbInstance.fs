namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbInstanceState<'InstanceClass> = { assignments: ResizeArray<aws.DbInstance.DbInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance">aws_db_instance</a>.
    /// </summary>
    type DbInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbInstanceState<Missing> =
            ({ assignments = ResizeArray() } : DbInstanceState<Missing>)

        member _.Zero(()) : DbInstanceState<Missing> =
            ({ assignments = ResizeArray() } : DbInstanceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#instance_class-1">DbInstance#instance_class</a>.
        /// </summary>
        [<CustomOperation "instance_class">]
        member _.InstanceClass(state: DbInstanceState<Missing>, value: string) : DbInstanceState<Present> =
            state.assignments.Add(fun config -> config.InstanceClass <- value)
            ({ assignments = state.assignments } : DbInstanceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#allocated_storage-1">DbInstance#allocated_storage</a>.
        /// </summary>
        [<CustomOperation "allocated_storage">]
        member _.AllocatedStorage(state: DbInstanceState<'InstanceClass>, value: double) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.AllocatedStorage <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#allow_major_version_upgrade-1">DbInstance#allow_major_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_major_version_upgrade">]
        member _.AllowMajorVersionUpgrade(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.AllowMajorVersionUpgrade <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#allow_major_version_upgrade-1">DbInstance#allow_major_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_major_version_upgrade">]
        member _.AllowMajorVersionUpgrade(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.AllowMajorVersionUpgrade <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#apply_immediately-1">DbInstance#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#apply_immediately-1">DbInstance#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#auto_minor_version_upgrade-1">DbInstance#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#auto_minor_version_upgrade-1">DbInstance#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#availability_zone-1">DbInstance#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#backup_retention_period-1">DbInstance#backup_retention_period</a>.
        /// </summary>
        [<CustomOperation "backup_retention_period">]
        member _.BackupRetentionPeriod(state: DbInstanceState<'InstanceClass>, value: double) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.BackupRetentionPeriod <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#backup_target-1">DbInstance#backup_target</a>.
        /// </summary>
        [<CustomOperation "backup_target">]
        member _.BackupTarget(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.BackupTarget <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#backup_window-1">DbInstance#backup_window</a>.
        /// </summary>
        [<CustomOperation "backup_window">]
        member _.BackupWindow(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.BackupWindow <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// blue_green_update block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#blue_green_update-1">DbInstance#blue_green_update</a>
        /// </summary>
        [<CustomOperation "blue_green_update">]
        member _.BlueGreenUpdate(state: DbInstanceState<'InstanceClass>, value: aws.DbInstance.DbInstanceBlueGreenUpdate) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.BlueGreenUpdate <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#ca_cert_identifier-1">DbInstance#ca_cert_identifier</a>.
        /// </summary>
        [<CustomOperation "ca_cert_identifier">]
        member _.CaCertIdentifier(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.CaCertIdentifier <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#character_set_name-1">DbInstance#character_set_name</a>.
        /// </summary>
        [<CustomOperation "character_set_name">]
        member _.CharacterSetName(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.CharacterSetName <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#copy_tags_to_snapshot-1">DbInstance#copy_tags_to_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_snapshot">]
        member _.CopyTagsToSnapshot(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.CopyTagsToSnapshot <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#copy_tags_to_snapshot-1">DbInstance#copy_tags_to_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_snapshot">]
        member _.CopyTagsToSnapshot(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.CopyTagsToSnapshot <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#customer_owned_ip_enabled-1">DbInstance#customer_owned_ip_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "customer_owned_ip_enabled">]
        member _.CustomerOwnedIpEnabled(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.CustomerOwnedIpEnabled <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#customer_owned_ip_enabled-1">DbInstance#customer_owned_ip_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "customer_owned_ip_enabled">]
        member _.CustomerOwnedIpEnabled(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.CustomerOwnedIpEnabled <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#custom_iam_instance_profile-1">DbInstance#custom_iam_instance_profile</a>.
        /// </summary>
        [<CustomOperation "custom_iam_instance_profile">]
        member _.CustomIamInstanceProfile(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.CustomIamInstanceProfile <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#database_insights_mode-1">DbInstance#database_insights_mode</a>.
        /// </summary>
        [<CustomOperation "database_insights_mode">]
        member _.DatabaseInsightsMode(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DatabaseInsightsMode <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#db_name-1">DbInstance#db_name</a>.
        /// </summary>
        [<CustomOperation "db_name">]
        member _.DbName(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DbName <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#db_subnet_group_name-1">DbInstance#db_subnet_group_name</a>.
        /// </summary>
        [<CustomOperation "db_subnet_group_name">]
        member _.DbSubnetGroupName(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DbSubnetGroupName <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#dedicated_log_volume-1">DbInstance#dedicated_log_volume</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "dedicated_log_volume">]
        member _.DedicatedLogVolume(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DedicatedLogVolume <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#dedicated_log_volume-1">DbInstance#dedicated_log_volume</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "dedicated_log_volume">]
        member _.DedicatedLogVolume(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DedicatedLogVolume <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#delete_automated_backups-1">DbInstance#delete_automated_backups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_automated_backups">]
        member _.DeleteAutomatedBackups(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DeleteAutomatedBackups <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#delete_automated_backups-1">DbInstance#delete_automated_backups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_automated_backups">]
        member _.DeleteAutomatedBackups(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DeleteAutomatedBackups <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#deletion_protection-1">DbInstance#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#deletion_protection-1">DbInstance#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#domain-1">DbInstance#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.Domain <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#domain_auth_secret_arn-1">DbInstance#domain_auth_secret_arn</a>.
        /// </summary>
        [<CustomOperation "domain_auth_secret_arn">]
        member _.DomainAuthSecretArn(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DomainAuthSecretArn <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#domain_dns_ips-1">DbInstance#domain_dns_ips</a>.
        /// </summary>
        [<CustomOperation "domain_dns_ips">]
        member _.DomainDnsIps(state: DbInstanceState<'InstanceClass>, value: seq<string>) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DomainDnsIps <- (value |> Seq.toArray))
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#domain_fqdn-1">DbInstance#domain_fqdn</a>.
        /// </summary>
        [<CustomOperation "domain_fqdn">]
        member _.DomainFqdn(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DomainFqdn <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#domain_iam_role_name-1">DbInstance#domain_iam_role_name</a>.
        /// </summary>
        [<CustomOperation "domain_iam_role_name">]
        member _.DomainIamRoleName(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DomainIamRoleName <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#domain_ou-1">DbInstance#domain_ou</a>.
        /// </summary>
        [<CustomOperation "domain_ou">]
        member _.DomainOu(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.DomainOu <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#enabled_cloudwatch_logs_exports-1">DbInstance#enabled_cloudwatch_logs_exports</a>.
        /// </summary>
        [<CustomOperation "enabled_cloudwatch_logs_exports">]
        member _.EnabledCloudwatchLogsExports(state: DbInstanceState<'InstanceClass>, value: seq<string>) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.EnabledCloudwatchLogsExports <- (value |> Seq.toArray))
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#engine-1">DbInstance#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#engine_lifecycle_support-1">DbInstance#engine_lifecycle_support</a>.
        /// </summary>
        [<CustomOperation "engine_lifecycle_support">]
        member _.EngineLifecycleSupport(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.EngineLifecycleSupport <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#engine_version-1">DbInstance#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#final_snapshot_identifier-1">DbInstance#final_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "final_snapshot_identifier">]
        member _.FinalSnapshotIdentifier(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.FinalSnapshotIdentifier <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#iam_database_authentication_enabled-1">DbInstance#iam_database_authentication_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "iam_database_authentication_enabled">]
        member _.IamDatabaseAuthenticationEnabled(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.IamDatabaseAuthenticationEnabled <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#iam_database_authentication_enabled-1">DbInstance#iam_database_authentication_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "iam_database_authentication_enabled">]
        member _.IamDatabaseAuthenticationEnabled(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.IamDatabaseAuthenticationEnabled <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#id-1">DbInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#identifier-1">DbInstance#identifier</a>.
        /// </summary>
        [<CustomOperation "identifier">]
        member _.Identifier(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.Identifier <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#identifier_prefix-1">DbInstance#identifier_prefix</a>.
        /// </summary>
        [<CustomOperation "identifier_prefix">]
        member _.IdentifierPrefix(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.IdentifierPrefix <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#iops-1">DbInstance#iops</a>.
        /// </summary>
        [<CustomOperation "iops">]
        member _.Iops(state: DbInstanceState<'InstanceClass>, value: double) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.Iops <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#kms_key_id-1">DbInstance#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#license_model-1">DbInstance#license_model</a>.
        /// </summary>
        [<CustomOperation "license_model">]
        member _.LicenseModel(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.LicenseModel <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#maintenance_window-1">DbInstance#maintenance_window</a>.
        /// </summary>
        [<CustomOperation "maintenance_window">]
        member _.MaintenanceWindow(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.MaintenanceWindow <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#manage_master_user_password-1">DbInstance#manage_master_user_password</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_master_user_password">]
        member _.ManageMasterUserPassword(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.ManageMasterUserPassword <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#manage_master_user_password-1">DbInstance#manage_master_user_password</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manage_master_user_password">]
        member _.ManageMasterUserPassword(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.ManageMasterUserPassword <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#master_user_secret_kms_key_id-1">DbInstance#master_user_secret_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "master_user_secret_kms_key_id">]
        member _.MasterUserSecretKmsKeyId(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.MasterUserSecretKmsKeyId <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#max_allocated_storage-1">DbInstance#max_allocated_storage</a>.
        /// </summary>
        [<CustomOperation "max_allocated_storage">]
        member _.MaxAllocatedStorage(state: DbInstanceState<'InstanceClass>, value: double) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.MaxAllocatedStorage <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#monitoring_interval-1">DbInstance#monitoring_interval</a>.
        /// </summary>
        [<CustomOperation "monitoring_interval">]
        member _.MonitoringInterval(state: DbInstanceState<'InstanceClass>, value: double) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.MonitoringInterval <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#monitoring_role_arn-1">DbInstance#monitoring_role_arn</a>.
        /// </summary>
        [<CustomOperation "monitoring_role_arn">]
        member _.MonitoringRoleArn(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.MonitoringRoleArn <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#multi_az-1">DbInstance#multi_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_az">]
        member _.MultiAz(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.MultiAz <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#multi_az-1">DbInstance#multi_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_az">]
        member _.MultiAz(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.MultiAz <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#nchar_character_set_name-1">DbInstance#nchar_character_set_name</a>.
        /// </summary>
        [<CustomOperation "nchar_character_set_name">]
        member _.NcharCharacterSetName(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.NcharCharacterSetName <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#network_type-1">DbInstance#network_type</a>.
        /// </summary>
        [<CustomOperation "network_type">]
        member _.NetworkType(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.NetworkType <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#option_group_name-1">DbInstance#option_group_name</a>.
        /// </summary>
        [<CustomOperation "option_group_name">]
        member _.OptionGroupName(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.OptionGroupName <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#parameter_group_name-1">DbInstance#parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "parameter_group_name">]
        member _.ParameterGroupName(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.ParameterGroupName <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#password-1">DbInstance#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#password_wo-1">DbInstance#password_wo</a>.
        /// </summary>
        [<CustomOperation "password_wo">]
        member _.PasswordWo(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.PasswordWo <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#password_wo_version-1">DbInstance#password_wo_version</a>.
        /// </summary>
        [<CustomOperation "password_wo_version">]
        member _.PasswordWoVersion(state: DbInstanceState<'InstanceClass>, value: double) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.PasswordWoVersion <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#performance_insights_enabled-1">DbInstance#performance_insights_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "performance_insights_enabled">]
        member _.PerformanceInsightsEnabled(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.PerformanceInsightsEnabled <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#performance_insights_enabled-1">DbInstance#performance_insights_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "performance_insights_enabled">]
        member _.PerformanceInsightsEnabled(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.PerformanceInsightsEnabled <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#performance_insights_kms_key_id-1">DbInstance#performance_insights_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "performance_insights_kms_key_id">]
        member _.PerformanceInsightsKmsKeyId(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.PerformanceInsightsKmsKeyId <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#performance_insights_retention_period-1">DbInstance#performance_insights_retention_period</a>.
        /// </summary>
        [<CustomOperation "performance_insights_retention_period">]
        member _.PerformanceInsightsRetentionPeriod(state: DbInstanceState<'InstanceClass>, value: double) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.PerformanceInsightsRetentionPeriod <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#port-1">DbInstance#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: DbInstanceState<'InstanceClass>, value: double) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#publicly_accessible-1">DbInstance#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#publicly_accessible-1">DbInstance#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#replica_mode-1">DbInstance#replica_mode</a>.
        /// </summary>
        [<CustomOperation "replica_mode">]
        member _.ReplicaMode(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.ReplicaMode <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#replicate_source_db-1">DbInstance#replicate_source_db</a>.
        /// </summary>
        [<CustomOperation "replicate_source_db">]
        member _.ReplicateSourceDb(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.ReplicateSourceDb <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// restore_to_point_in_time block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#restore_to_point_in_time-1">DbInstance#restore_to_point_in_time</a>
        /// </summary>
        [<CustomOperation "restore_to_point_in_time">]
        member _.RestoreToPointInTime(state: DbInstanceState<'InstanceClass>, value: aws.DbInstance.DbInstanceRestoreToPointInTime) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.RestoreToPointInTime <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// s3_import block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#s3_import-1">DbInstance#s3_import</a>
        /// </summary>
        [<CustomOperation "s3_import">]
        member _.S3Import(state: DbInstanceState<'InstanceClass>, value: aws.DbInstance.DbInstanceS3Import) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.S3Import <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#skip_final_snapshot-1">DbInstance#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#skip_final_snapshot-1">DbInstance#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#snapshot_identifier-1">DbInstance#snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "snapshot_identifier">]
        member _.SnapshotIdentifier(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.SnapshotIdentifier <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#storage_encrypted-1">DbInstance#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#storage_encrypted-1">DbInstance#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#storage_throughput-1">DbInstance#storage_throughput</a>.
        /// </summary>
        [<CustomOperation "storage_throughput">]
        member _.StorageThroughput(state: DbInstanceState<'InstanceClass>, value: double) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.StorageThroughput <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#storage_type-1">DbInstance#storage_type</a>.
        /// </summary>
        [<CustomOperation "storage_type">]
        member _.StorageType(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.StorageType <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#tags-1">DbInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DbInstanceState<'InstanceClass>, value: seq<string * string>) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#tags_all-1">DbInstance#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DbInstanceState<'InstanceClass>, value: seq<string * string>) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#timeouts-1">DbInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DbInstanceState<'InstanceClass>, value: aws.DbInstance.DbInstanceTimeouts) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#timezone-1">DbInstance#timezone</a>.
        /// </summary>
        [<CustomOperation "timezone">]
        member _.Timezone(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.Timezone <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#upgrade_storage_config-1">DbInstance#upgrade_storage_config</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "upgrade_storage_config">]
        member _.UpgradeStorageConfig(state: DbInstanceState<'InstanceClass>, value: bool) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.UpgradeStorageConfig <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#upgrade_storage_config-1">DbInstance#upgrade_storage_config</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "upgrade_storage_config">]
        member _.UpgradeStorageConfig(state: DbInstanceState<'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.UpgradeStorageConfig <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#username-1">DbInstance#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: DbInstanceState<'InstanceClass>, value: string) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.Username <- value)
            state : DbInstanceState<'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance#vpc_security_group_ids-1">DbInstance#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: DbInstanceState<'InstanceClass>, value: seq<string>) : DbInstanceState<'InstanceClass> =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : DbInstanceState<'InstanceClass>

        member _.Run(state: DbInstanceState<Present>) : aws.DbInstance.DbInstance =
            let config = aws.DbInstance.DbInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.DbInstance.DbInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbInstance: missing required arguments. Must call: instance_class.", 9999, IsError = true)>]
        member _.Run(_: DbInstanceState<_>) : aws.DbInstance.DbInstance =
            Unchecked.defaultof<aws.DbInstance.DbInstance>
