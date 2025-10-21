namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> = { assignments: ResizeArray<aws.DmsReplicationInstance.DmsReplicationInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance">aws_dms_replication_instance</a>.
    /// </summary>
    type DmsReplicationInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DmsReplicationInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsReplicationInstanceState<Missing, Missing>)

        member _.Zero(()) : DmsReplicationInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsReplicationInstanceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#replication_instance_class-1">DmsReplicationInstance#replication_instance_class</a>.
        /// </summary>
        [<CustomOperation "replication_instance_class">]
        member _.ReplicationInstanceClass(state: DmsReplicationInstanceState<Missing, 'ReplicationInstanceId>, value: string) : DmsReplicationInstanceState<Present, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.ReplicationInstanceClass <- value)
            ({ assignments = state.assignments } : DmsReplicationInstanceState<Present, 'ReplicationInstanceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#replication_instance_id-1">DmsReplicationInstance#replication_instance_id</a>.
        /// </summary>
        [<CustomOperation "replication_instance_id">]
        member _.ReplicationInstanceId(state: DmsReplicationInstanceState<'ReplicationInstanceClass, Missing>, value: string) : DmsReplicationInstanceState<'ReplicationInstanceClass, Present> =
            state.assignments.Add(fun config -> config.ReplicationInstanceId <- value)
            ({ assignments = state.assignments } : DmsReplicationInstanceState<'ReplicationInstanceClass, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#allocated_storage-1">DmsReplicationInstance#allocated_storage</a>.
        /// </summary>
        [<CustomOperation "allocated_storage">]
        member _.AllocatedStorage(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: double) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.AllocatedStorage <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#allow_major_version_upgrade-1">DmsReplicationInstance#allow_major_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_major_version_upgrade">]
        member _.AllowMajorVersionUpgrade(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: bool) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.AllowMajorVersionUpgrade <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#allow_major_version_upgrade-1">DmsReplicationInstance#allow_major_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_major_version_upgrade">]
        member _.AllowMajorVersionUpgrade(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: HashiCorp.Cdktf.IResolvable) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.AllowMajorVersionUpgrade <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#apply_immediately-1">DmsReplicationInstance#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: bool) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#apply_immediately-1">DmsReplicationInstance#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: HashiCorp.Cdktf.IResolvable) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#auto_minor_version_upgrade-1">DmsReplicationInstance#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: bool) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#auto_minor_version_upgrade-1">DmsReplicationInstance#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: HashiCorp.Cdktf.IResolvable) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#availability_zone-1">DmsReplicationInstance#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: string) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#engine_version-1">DmsReplicationInstance#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: string) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#id-1">DmsReplicationInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: string) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#kms_key_arn-1">DmsReplicationInstance#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: string) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#multi_az-1">DmsReplicationInstance#multi_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_az">]
        member _.MultiAz(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: bool) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.MultiAz <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#multi_az-1">DmsReplicationInstance#multi_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_az">]
        member _.MultiAz(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: HashiCorp.Cdktf.IResolvable) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.MultiAz <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#network_type-1">DmsReplicationInstance#network_type</a>.
        /// </summary>
        [<CustomOperation "network_type">]
        member _.NetworkType(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: string) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.NetworkType <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#preferred_maintenance_window-1">DmsReplicationInstance#preferred_maintenance_window</a>.
        /// </summary>
        [<CustomOperation "preferred_maintenance_window">]
        member _.PreferredMaintenanceWindow(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: string) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.PreferredMaintenanceWindow <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#publicly_accessible-1">DmsReplicationInstance#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: bool) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#publicly_accessible-1">DmsReplicationInstance#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: HashiCorp.Cdktf.IResolvable) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#replication_subnet_group_id-1">DmsReplicationInstance#replication_subnet_group_id</a>.
        /// </summary>
        [<CustomOperation "replication_subnet_group_id">]
        member _.ReplicationSubnetGroupId(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: string) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.ReplicationSubnetGroupId <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#tags-1">DmsReplicationInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: seq<string * string>) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#tags_all-1">DmsReplicationInstance#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: seq<string * string>) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#timeouts-1">DmsReplicationInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: aws.DmsReplicationInstance.DmsReplicationInstanceTimeouts) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_instance#vpc_security_group_ids-1">DmsReplicationInstance#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>, value: seq<string>) : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : DmsReplicationInstanceState<'ReplicationInstanceClass, 'ReplicationInstanceId>

        member _.Run(state: DmsReplicationInstanceState<Present, Present>) : aws.DmsReplicationInstance.DmsReplicationInstance =
            let config = aws.DmsReplicationInstance.DmsReplicationInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.DmsReplicationInstance.DmsReplicationInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dmsReplicationInstance: missing required arguments. Must call: replication_instance_class, replication_instance_id.", 9999, IsError = true)>]
        member _.Run(_: DmsReplicationInstanceState<_, _>) : aws.DmsReplicationInstance.DmsReplicationInstance =
            Unchecked.defaultof<aws.DmsReplicationInstance.DmsReplicationInstance>
