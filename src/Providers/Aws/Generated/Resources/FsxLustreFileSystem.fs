namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FsxLustreFileSystemState<'SubnetIds> = { assignments: ResizeArray<aws.FsxLustreFileSystem.FsxLustreFileSystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system">aws_fsx_lustre_file_system</a>.
    /// </summary>
    type FsxLustreFileSystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : FsxLustreFileSystemState<Missing> =
            ({ assignments = ResizeArray() } : FsxLustreFileSystemState<Missing>)

        member _.Zero(()) : FsxLustreFileSystemState<Missing> =
            ({ assignments = ResizeArray() } : FsxLustreFileSystemState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#subnet_ids-1">FsxLustreFileSystem#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: FsxLustreFileSystemState<Missing>, value: seq<string>) : FsxLustreFileSystemState<Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : FsxLustreFileSystemState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#auto_import_policy-1">FsxLustreFileSystem#auto_import_policy</a>.
        /// </summary>
        [<CustomOperation "auto_import_policy">]
        member _.AutoImportPolicy(state: FsxLustreFileSystemState<'SubnetIds>, value: string) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.AutoImportPolicy <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#automatic_backup_retention_days-1">FsxLustreFileSystem#automatic_backup_retention_days</a>.
        /// </summary>
        [<CustomOperation "automatic_backup_retention_days">]
        member _.AutomaticBackupRetentionDays(state: FsxLustreFileSystemState<'SubnetIds>, value: double) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.AutomaticBackupRetentionDays <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#backup_id-1">FsxLustreFileSystem#backup_id</a>.
        /// </summary>
        [<CustomOperation "backup_id">]
        member _.BackupId(state: FsxLustreFileSystemState<'SubnetIds>, value: string) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.BackupId <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#copy_tags_to_backups-1">FsxLustreFileSystem#copy_tags_to_backups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_backups">]
        member _.CopyTagsToBackups(state: FsxLustreFileSystemState<'SubnetIds>, value: bool) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.CopyTagsToBackups <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#copy_tags_to_backups-1">FsxLustreFileSystem#copy_tags_to_backups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_backups">]
        member _.CopyTagsToBackups(state: FsxLustreFileSystemState<'SubnetIds>, value: HashiCorp.Cdktf.IResolvable) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.CopyTagsToBackups <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#daily_automatic_backup_start_time-1">FsxLustreFileSystem#daily_automatic_backup_start_time</a>.
        /// </summary>
        [<CustomOperation "daily_automatic_backup_start_time">]
        member _.DailyAutomaticBackupStartTime(state: FsxLustreFileSystemState<'SubnetIds>, value: string) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.DailyAutomaticBackupStartTime <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#data_compression_type-1">FsxLustreFileSystem#data_compression_type</a>.
        /// </summary>
        [<CustomOperation "data_compression_type">]
        member _.DataCompressionType(state: FsxLustreFileSystemState<'SubnetIds>, value: string) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.DataCompressionType <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// data_read_cache_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#data_read_cache_configuration-1">FsxLustreFileSystem#data_read_cache_configuration</a>
        /// </summary>
        [<CustomOperation "data_read_cache_configuration">]
        member _.DataReadCacheConfiguration(state: FsxLustreFileSystemState<'SubnetIds>, value: aws.FsxLustreFileSystem.FsxLustreFileSystemDataReadCacheConfiguration) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.DataReadCacheConfiguration <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#deployment_type-1">FsxLustreFileSystem#deployment_type</a>.
        /// </summary>
        [<CustomOperation "deployment_type">]
        member _.DeploymentType(state: FsxLustreFileSystemState<'SubnetIds>, value: string) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.DeploymentType <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#drive_cache_type-1">FsxLustreFileSystem#drive_cache_type</a>.
        /// </summary>
        [<CustomOperation "drive_cache_type">]
        member _.DriveCacheType(state: FsxLustreFileSystemState<'SubnetIds>, value: string) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.DriveCacheType <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#efa_enabled-1">FsxLustreFileSystem#efa_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "efa_enabled">]
        member _.EfaEnabled(state: FsxLustreFileSystemState<'SubnetIds>, value: bool) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.EfaEnabled <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#efa_enabled-1">FsxLustreFileSystem#efa_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "efa_enabled">]
        member _.EfaEnabled(state: FsxLustreFileSystemState<'SubnetIds>, value: HashiCorp.Cdktf.IResolvable) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.EfaEnabled <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#export_path-1">FsxLustreFileSystem#export_path</a>.
        /// </summary>
        [<CustomOperation "export_path">]
        member _.ExportPath(state: FsxLustreFileSystemState<'SubnetIds>, value: string) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.ExportPath <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#file_system_type_version-1">FsxLustreFileSystem#file_system_type_version</a>.
        /// </summary>
        [<CustomOperation "file_system_type_version">]
        member _.FileSystemTypeVersion(state: FsxLustreFileSystemState<'SubnetIds>, value: string) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.FileSystemTypeVersion <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#final_backup_tags-1">FsxLustreFileSystem#final_backup_tags</a>.
        /// </summary>
        [<CustomOperation "final_backup_tags">]
        member _.FinalBackupTags(state: FsxLustreFileSystemState<'SubnetIds>, value: seq<string * string>) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.FinalBackupTags <- dict value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#id-1">FsxLustreFileSystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FsxLustreFileSystemState<'SubnetIds>, value: string) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#imported_file_chunk_size-1">FsxLustreFileSystem#imported_file_chunk_size</a>.
        /// </summary>
        [<CustomOperation "imported_file_chunk_size">]
        member _.ImportedFileChunkSize(state: FsxLustreFileSystemState<'SubnetIds>, value: double) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.ImportedFileChunkSize <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#import_path-1">FsxLustreFileSystem#import_path</a>.
        /// </summary>
        [<CustomOperation "import_path">]
        member _.ImportPath(state: FsxLustreFileSystemState<'SubnetIds>, value: string) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.ImportPath <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#kms_key_id-1">FsxLustreFileSystem#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: FsxLustreFileSystemState<'SubnetIds>, value: string) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// log_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#log_configuration-1">FsxLustreFileSystem#log_configuration</a>
        /// </summary>
        [<CustomOperation "log_configuration">]
        member _.LogConfiguration(state: FsxLustreFileSystemState<'SubnetIds>, value: aws.FsxLustreFileSystem.FsxLustreFileSystemLogConfiguration) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.LogConfiguration <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// metadata_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#metadata_configuration-1">FsxLustreFileSystem#metadata_configuration</a>
        /// </summary>
        [<CustomOperation "metadata_configuration">]
        member _.MetadataConfiguration(state: FsxLustreFileSystemState<'SubnetIds>, value: aws.FsxLustreFileSystem.FsxLustreFileSystemMetadataConfiguration) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.MetadataConfiguration <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#per_unit_storage_throughput-1">FsxLustreFileSystem#per_unit_storage_throughput</a>.
        /// </summary>
        [<CustomOperation "per_unit_storage_throughput">]
        member _.PerUnitStorageThroughput(state: FsxLustreFileSystemState<'SubnetIds>, value: double) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.PerUnitStorageThroughput <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// root_squash_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#root_squash_configuration-1">FsxLustreFileSystem#root_squash_configuration</a>
        /// </summary>
        [<CustomOperation "root_squash_configuration">]
        member _.RootSquashConfiguration(state: FsxLustreFileSystemState<'SubnetIds>, value: aws.FsxLustreFileSystem.FsxLustreFileSystemRootSquashConfiguration) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.RootSquashConfiguration <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#security_group_ids-1">FsxLustreFileSystem#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: FsxLustreFileSystemState<'SubnetIds>, value: seq<string>) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#skip_final_backup-1">FsxLustreFileSystem#skip_final_backup</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_backup">]
        member _.SkipFinalBackup(state: FsxLustreFileSystemState<'SubnetIds>, value: bool) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.SkipFinalBackup <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#skip_final_backup-1">FsxLustreFileSystem#skip_final_backup</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_backup">]
        member _.SkipFinalBackup(state: FsxLustreFileSystemState<'SubnetIds>, value: HashiCorp.Cdktf.IResolvable) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.SkipFinalBackup <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#storage_capacity-1">FsxLustreFileSystem#storage_capacity</a>.
        /// </summary>
        [<CustomOperation "storage_capacity">]
        member _.StorageCapacity(state: FsxLustreFileSystemState<'SubnetIds>, value: double) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.StorageCapacity <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#storage_type-1">FsxLustreFileSystem#storage_type</a>.
        /// </summary>
        [<CustomOperation "storage_type">]
        member _.StorageType(state: FsxLustreFileSystemState<'SubnetIds>, value: string) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.StorageType <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#tags-1">FsxLustreFileSystem#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FsxLustreFileSystemState<'SubnetIds>, value: seq<string * string>) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#tags_all-1">FsxLustreFileSystem#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FsxLustreFileSystemState<'SubnetIds>, value: seq<string * string>) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#throughput_capacity-1">FsxLustreFileSystem#throughput_capacity</a>.
        /// </summary>
        [<CustomOperation "throughput_capacity">]
        member _.ThroughputCapacity(state: FsxLustreFileSystemState<'SubnetIds>, value: double) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.ThroughputCapacity <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#timeouts-1">FsxLustreFileSystem#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FsxLustreFileSystemState<'SubnetIds>, value: aws.FsxLustreFileSystem.FsxLustreFileSystemTimeouts) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_lustre_file_system#weekly_maintenance_start_time-1">FsxLustreFileSystem#weekly_maintenance_start_time</a>.
        /// </summary>
        [<CustomOperation "weekly_maintenance_start_time">]
        member _.WeeklyMaintenanceStartTime(state: FsxLustreFileSystemState<'SubnetIds>, value: string) : FsxLustreFileSystemState<'SubnetIds> =
            state.assignments.Add(fun config -> config.WeeklyMaintenanceStartTime <- value)
            state : FsxLustreFileSystemState<'SubnetIds>

        member _.Run(state: FsxLustreFileSystemState<Present>) : aws.FsxLustreFileSystem.FsxLustreFileSystem =
            let config = aws.FsxLustreFileSystem.FsxLustreFileSystemConfig()
            for setter in state.assignments do
                setter config
            aws.FsxLustreFileSystem.FsxLustreFileSystem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.fsxLustreFileSystem: missing required arguments. Must call: subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: FsxLustreFileSystemState<_>) : aws.FsxLustreFileSystem.FsxLustreFileSystem =
            Unchecked.defaultof<aws.FsxLustreFileSystem.FsxLustreFileSystem>
