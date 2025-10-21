namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> = { assignments: ResizeArray<aws.FsxOpenzfsFileSystem.FsxOpenzfsFileSystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system">aws_fsx_openzfs_file_system</a>.
    /// </summary>
    type FsxOpenzfsFileSystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : FsxOpenzfsFileSystemState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxOpenzfsFileSystemState<Missing, Missing, Missing>)

        member _.Zero(()) : FsxOpenzfsFileSystemState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxOpenzfsFileSystemState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#deployment_type-1">FsxOpenzfsFileSystem#deployment_type</a>.
        /// </summary>
        [<CustomOperation "deployment_type">]
        member _.DeploymentType(state: FsxOpenzfsFileSystemState<Missing, 'SubnetIds, 'ThroughputCapacity>, value: string) : FsxOpenzfsFileSystemState<Present, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.DeploymentType <- value)
            ({ assignments = state.assignments } : FsxOpenzfsFileSystemState<Present, 'SubnetIds, 'ThroughputCapacity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#subnet_ids-1">FsxOpenzfsFileSystem#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: FsxOpenzfsFileSystemState<'DeploymentType, Missing, 'ThroughputCapacity>, value: seq<string>) : FsxOpenzfsFileSystemState<'DeploymentType, Present, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : FsxOpenzfsFileSystemState<'DeploymentType, Present, 'ThroughputCapacity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#throughput_capacity-1">FsxOpenzfsFileSystem#throughput_capacity</a>.
        /// </summary>
        [<CustomOperation "throughput_capacity">]
        member _.ThroughputCapacity(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, Missing>, value: double) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, Present> =
            state.assignments.Add(fun config -> config.ThroughputCapacity <- value)
            ({ assignments = state.assignments } : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#automatic_backup_retention_days-1">FsxOpenzfsFileSystem#automatic_backup_retention_days</a>.
        /// </summary>
        [<CustomOperation "automatic_backup_retention_days">]
        member _.AutomaticBackupRetentionDays(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: double) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.AutomaticBackupRetentionDays <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#backup_id-1">FsxOpenzfsFileSystem#backup_id</a>.
        /// </summary>
        [<CustomOperation "backup_id">]
        member _.BackupId(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: string) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.BackupId <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#copy_tags_to_backups-1">FsxOpenzfsFileSystem#copy_tags_to_backups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_backups">]
        member _.CopyTagsToBackups(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: bool) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.CopyTagsToBackups <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#copy_tags_to_backups-1">FsxOpenzfsFileSystem#copy_tags_to_backups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_backups">]
        member _.CopyTagsToBackups(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: HashiCorp.Cdktf.IResolvable) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.CopyTagsToBackups <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#copy_tags_to_volumes-1">FsxOpenzfsFileSystem#copy_tags_to_volumes</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_volumes">]
        member _.CopyTagsToVolumes(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: bool) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.CopyTagsToVolumes <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#copy_tags_to_volumes-1">FsxOpenzfsFileSystem#copy_tags_to_volumes</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_volumes">]
        member _.CopyTagsToVolumes(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: HashiCorp.Cdktf.IResolvable) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.CopyTagsToVolumes <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#daily_automatic_backup_start_time-1">FsxOpenzfsFileSystem#daily_automatic_backup_start_time</a>.
        /// </summary>
        [<CustomOperation "daily_automatic_backup_start_time">]
        member _.DailyAutomaticBackupStartTime(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: string) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.DailyAutomaticBackupStartTime <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#delete_options-1">FsxOpenzfsFileSystem#delete_options</a>.
        /// </summary>
        [<CustomOperation "delete_options">]
        member _.DeleteOptions(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: seq<string>) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.DeleteOptions <- (value |> Seq.toArray))
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// disk_iops_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#disk_iops_configuration-1">FsxOpenzfsFileSystem#disk_iops_configuration</a>
        /// </summary>
        [<CustomOperation "disk_iops_configuration">]
        member _.DiskIopsConfiguration(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: aws.FsxOpenzfsFileSystem.FsxOpenzfsFileSystemDiskIopsConfiguration) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.DiskIopsConfiguration <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#endpoint_ip_address_range-1">FsxOpenzfsFileSystem#endpoint_ip_address_range</a>.
        /// </summary>
        [<CustomOperation "endpoint_ip_address_range">]
        member _.EndpointIpAddressRange(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: string) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.EndpointIpAddressRange <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#final_backup_tags-1">FsxOpenzfsFileSystem#final_backup_tags</a>.
        /// </summary>
        [<CustomOperation "final_backup_tags">]
        member _.FinalBackupTags(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: seq<string * string>) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.FinalBackupTags <- dict value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#id-1">FsxOpenzfsFileSystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: string) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#kms_key_id-1">FsxOpenzfsFileSystem#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: string) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#preferred_subnet_id-1">FsxOpenzfsFileSystem#preferred_subnet_id</a>.
        /// </summary>
        [<CustomOperation "preferred_subnet_id">]
        member _.PreferredSubnetId(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: string) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.PreferredSubnetId <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// root_volume_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#root_volume_configuration-1">FsxOpenzfsFileSystem#root_volume_configuration</a>
        /// </summary>
        [<CustomOperation "root_volume_configuration">]
        member _.RootVolumeConfiguration(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: aws.FsxOpenzfsFileSystem.FsxOpenzfsFileSystemRootVolumeConfiguration) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.RootVolumeConfiguration <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#route_table_ids-1">FsxOpenzfsFileSystem#route_table_ids</a>.
        /// </summary>
        [<CustomOperation "route_table_ids">]
        member _.RouteTableIds(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: seq<string>) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.RouteTableIds <- (value |> Seq.toArray))
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#security_group_ids-1">FsxOpenzfsFileSystem#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: seq<string>) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#skip_final_backup-1">FsxOpenzfsFileSystem#skip_final_backup</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_backup">]
        member _.SkipFinalBackup(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: bool) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.SkipFinalBackup <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#skip_final_backup-1">FsxOpenzfsFileSystem#skip_final_backup</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_backup">]
        member _.SkipFinalBackup(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: HashiCorp.Cdktf.IResolvable) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.SkipFinalBackup <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#storage_capacity-1">FsxOpenzfsFileSystem#storage_capacity</a>.
        /// </summary>
        [<CustomOperation "storage_capacity">]
        member _.StorageCapacity(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: double) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.StorageCapacity <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#storage_type-1">FsxOpenzfsFileSystem#storage_type</a>.
        /// </summary>
        [<CustomOperation "storage_type">]
        member _.StorageType(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: string) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.StorageType <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#tags-1">FsxOpenzfsFileSystem#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: seq<string * string>) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#tags_all-1">FsxOpenzfsFileSystem#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: seq<string * string>) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#timeouts-1">FsxOpenzfsFileSystem#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: aws.FsxOpenzfsFileSystem.FsxOpenzfsFileSystemTimeouts) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_file_system#weekly_maintenance_start_time-1">FsxOpenzfsFileSystem#weekly_maintenance_start_time</a>.
        /// </summary>
        [<CustomOperation "weekly_maintenance_start_time">]
        member _.WeeklyMaintenanceStartTime(state: FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>, value: string) : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.WeeklyMaintenanceStartTime <- value)
            state : FsxOpenzfsFileSystemState<'DeploymentType, 'SubnetIds, 'ThroughputCapacity>

        member _.Run(state: FsxOpenzfsFileSystemState<Present, Present, Present>) : aws.FsxOpenzfsFileSystem.FsxOpenzfsFileSystem =
            let config = aws.FsxOpenzfsFileSystem.FsxOpenzfsFileSystemConfig()
            for setter in state.assignments do
                setter config
            aws.FsxOpenzfsFileSystem.FsxOpenzfsFileSystem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.fsxOpenzfsFileSystem: missing required arguments. Must call: deployment_type, subnet_ids, throughput_capacity.", 9999, IsError = true)>]
        member _.Run(_: FsxOpenzfsFileSystemState<_, _, _>) : aws.FsxOpenzfsFileSystem.FsxOpenzfsFileSystem =
            Unchecked.defaultof<aws.FsxOpenzfsFileSystem.FsxOpenzfsFileSystem>
