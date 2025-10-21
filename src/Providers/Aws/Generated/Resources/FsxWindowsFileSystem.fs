namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> = { assignments: ResizeArray<aws.FsxWindowsFileSystem.FsxWindowsFileSystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system">aws_fsx_windows_file_system</a>.
    /// </summary>
    type FsxWindowsFileSystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : FsxWindowsFileSystemState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxWindowsFileSystemState<Missing, Missing>)

        member _.Zero(()) : FsxWindowsFileSystemState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxWindowsFileSystemState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#subnet_ids-1">FsxWindowsFileSystem#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: FsxWindowsFileSystemState<Missing, 'ThroughputCapacity>, value: seq<string>) : FsxWindowsFileSystemState<Present, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : FsxWindowsFileSystemState<Present, 'ThroughputCapacity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#throughput_capacity-1">FsxWindowsFileSystem#throughput_capacity</a>.
        /// </summary>
        [<CustomOperation "throughput_capacity">]
        member _.ThroughputCapacity(state: FsxWindowsFileSystemState<'SubnetIds, Missing>, value: double) : FsxWindowsFileSystemState<'SubnetIds, Present> =
            state.assignments.Add(fun config -> config.ThroughputCapacity <- value)
            ({ assignments = state.assignments } : FsxWindowsFileSystemState<'SubnetIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#active_directory_id-1">FsxWindowsFileSystem#active_directory_id</a>.
        /// </summary>
        [<CustomOperation "active_directory_id">]
        member _.ActiveDirectoryId(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: string) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.ActiveDirectoryId <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#aliases-1">FsxWindowsFileSystem#aliases</a>.
        /// </summary>
        [<CustomOperation "aliases">]
        member _.Aliases(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: seq<string>) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.Aliases <- (value |> Seq.toArray))
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// audit_log_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#audit_log_configuration-1">FsxWindowsFileSystem#audit_log_configuration</a>
        /// </summary>
        [<CustomOperation "audit_log_configuration">]
        member _.AuditLogConfiguration(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: aws.FsxWindowsFileSystem.FsxWindowsFileSystemAuditLogConfiguration) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.AuditLogConfiguration <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#automatic_backup_retention_days-1">FsxWindowsFileSystem#automatic_backup_retention_days</a>.
        /// </summary>
        [<CustomOperation "automatic_backup_retention_days">]
        member _.AutomaticBackupRetentionDays(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: double) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.AutomaticBackupRetentionDays <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#backup_id-1">FsxWindowsFileSystem#backup_id</a>.
        /// </summary>
        [<CustomOperation "backup_id">]
        member _.BackupId(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: string) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.BackupId <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#copy_tags_to_backups-1">FsxWindowsFileSystem#copy_tags_to_backups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_backups">]
        member _.CopyTagsToBackups(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: bool) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.CopyTagsToBackups <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#copy_tags_to_backups-1">FsxWindowsFileSystem#copy_tags_to_backups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_backups">]
        member _.CopyTagsToBackups(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: HashiCorp.Cdktf.IResolvable) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.CopyTagsToBackups <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#daily_automatic_backup_start_time-1">FsxWindowsFileSystem#daily_automatic_backup_start_time</a>.
        /// </summary>
        [<CustomOperation "daily_automatic_backup_start_time">]
        member _.DailyAutomaticBackupStartTime(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: string) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.DailyAutomaticBackupStartTime <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#deployment_type-1">FsxWindowsFileSystem#deployment_type</a>.
        /// </summary>
        [<CustomOperation "deployment_type">]
        member _.DeploymentType(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: string) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.DeploymentType <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// disk_iops_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#disk_iops_configuration-1">FsxWindowsFileSystem#disk_iops_configuration</a>
        /// </summary>
        [<CustomOperation "disk_iops_configuration">]
        member _.DiskIopsConfiguration(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: aws.FsxWindowsFileSystem.FsxWindowsFileSystemDiskIopsConfiguration) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.DiskIopsConfiguration <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#final_backup_tags-1">FsxWindowsFileSystem#final_backup_tags</a>.
        /// </summary>
        [<CustomOperation "final_backup_tags">]
        member _.FinalBackupTags(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: seq<string * string>) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.FinalBackupTags <- dict value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#id-1">FsxWindowsFileSystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: string) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#kms_key_id-1">FsxWindowsFileSystem#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: string) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#preferred_subnet_id-1">FsxWindowsFileSystem#preferred_subnet_id</a>.
        /// </summary>
        [<CustomOperation "preferred_subnet_id">]
        member _.PreferredSubnetId(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: string) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.PreferredSubnetId <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#security_group_ids-1">FsxWindowsFileSystem#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: seq<string>) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// self_managed_active_directory block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#self_managed_active_directory-1">FsxWindowsFileSystem#self_managed_active_directory</a>
        /// </summary>
        [<CustomOperation "self_managed_active_directory">]
        member _.SelfManagedActiveDirectory(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: aws.FsxWindowsFileSystem.FsxWindowsFileSystemSelfManagedActiveDirectory) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.SelfManagedActiveDirectory <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#skip_final_backup-1">FsxWindowsFileSystem#skip_final_backup</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_backup">]
        member _.SkipFinalBackup(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: bool) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.SkipFinalBackup <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#skip_final_backup-1">FsxWindowsFileSystem#skip_final_backup</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_backup">]
        member _.SkipFinalBackup(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: HashiCorp.Cdktf.IResolvable) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.SkipFinalBackup <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#storage_capacity-1">FsxWindowsFileSystem#storage_capacity</a>.
        /// </summary>
        [<CustomOperation "storage_capacity">]
        member _.StorageCapacity(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: double) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.StorageCapacity <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#storage_type-1">FsxWindowsFileSystem#storage_type</a>.
        /// </summary>
        [<CustomOperation "storage_type">]
        member _.StorageType(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: string) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.StorageType <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#tags-1">FsxWindowsFileSystem#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: seq<string * string>) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#tags_all-1">FsxWindowsFileSystem#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: seq<string * string>) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#timeouts-1">FsxWindowsFileSystem#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: aws.FsxWindowsFileSystem.FsxWindowsFileSystemTimeouts) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_windows_file_system#weekly_maintenance_start_time-1">FsxWindowsFileSystem#weekly_maintenance_start_time</a>.
        /// </summary>
        [<CustomOperation "weekly_maintenance_start_time">]
        member _.WeeklyMaintenanceStartTime(state: FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>, value: string) : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity> =
            state.assignments.Add(fun config -> config.WeeklyMaintenanceStartTime <- value)
            state : FsxWindowsFileSystemState<'SubnetIds, 'ThroughputCapacity>

        member _.Run(state: FsxWindowsFileSystemState<Present, Present>) : aws.FsxWindowsFileSystem.FsxWindowsFileSystem =
            let config = aws.FsxWindowsFileSystem.FsxWindowsFileSystemConfig()
            for setter in state.assignments do
                setter config
            aws.FsxWindowsFileSystem.FsxWindowsFileSystem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.fsxWindowsFileSystem: missing required arguments. Must call: subnet_ids, throughput_capacity.", 9999, IsError = true)>]
        member _.Run(_: FsxWindowsFileSystemState<_, _>) : aws.FsxWindowsFileSystem.FsxWindowsFileSystem =
            Unchecked.defaultof<aws.FsxWindowsFileSystem.FsxWindowsFileSystem>
