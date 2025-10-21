namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> = { assignments: ResizeArray<aws.FsxOntapVolume.FsxOntapVolumeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume">aws_fsx_ontap_volume</a>.
    /// </summary>
    type FsxOntapVolumeBuilder(logicalId: string) =
        member _.Yield(_: unit) : FsxOntapVolumeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxOntapVolumeState<Missing, Missing>)

        member _.Zero(()) : FsxOntapVolumeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxOntapVolumeState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#name-1">FsxOntapVolume#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FsxOntapVolumeState<Missing, 'StorageVirtualMachineId>, value: string) : FsxOntapVolumeState<Present, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FsxOntapVolumeState<Present, 'StorageVirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#storage_virtual_machine_id-1">FsxOntapVolume#storage_virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "storage_virtual_machine_id">]
        member _.StorageVirtualMachineId(state: FsxOntapVolumeState<'Name, Missing>, value: string) : FsxOntapVolumeState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageVirtualMachineId <- value)
            ({ assignments = state.assignments } : FsxOntapVolumeState<'Name, Present>)

        /// <summary>
        /// aggregate_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#aggregate_configuration-1">FsxOntapVolume#aggregate_configuration</a>
        /// </summary>
        [<CustomOperation "aggregate_configuration">]
        member _.AggregateConfiguration(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: aws.FsxOntapVolume.FsxOntapVolumeAggregateConfiguration) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.AggregateConfiguration <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#bypass_snaplock_enterprise_retention-1">FsxOntapVolume#bypass_snaplock_enterprise_retention</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_snaplock_enterprise_retention">]
        member _.BypassSnaplockEnterpriseRetention(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: bool) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.BypassSnaplockEnterpriseRetention <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#bypass_snaplock_enterprise_retention-1">FsxOntapVolume#bypass_snaplock_enterprise_retention</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_snaplock_enterprise_retention">]
        member _.BypassSnaplockEnterpriseRetention(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.BypassSnaplockEnterpriseRetention <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#copy_tags_to_backups-1">FsxOntapVolume#copy_tags_to_backups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_backups">]
        member _.CopyTagsToBackups(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: bool) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.CopyTagsToBackups <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#copy_tags_to_backups-1">FsxOntapVolume#copy_tags_to_backups</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_backups">]
        member _.CopyTagsToBackups(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.CopyTagsToBackups <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#final_backup_tags-1">FsxOntapVolume#final_backup_tags</a>.
        /// </summary>
        [<CustomOperation "final_backup_tags">]
        member _.FinalBackupTags(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: seq<string * string>) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.FinalBackupTags <- dict value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#id-1">FsxOntapVolume#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: string) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#junction_path-1">FsxOntapVolume#junction_path</a>.
        /// </summary>
        [<CustomOperation "junction_path">]
        member _.JunctionPath(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: string) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.JunctionPath <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#ontap_volume_type-1">FsxOntapVolume#ontap_volume_type</a>.
        /// </summary>
        [<CustomOperation "ontap_volume_type">]
        member _.OntapVolumeType(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: string) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.OntapVolumeType <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#security_style-1">FsxOntapVolume#security_style</a>.
        /// </summary>
        [<CustomOperation "security_style">]
        member _.SecurityStyle(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: string) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.SecurityStyle <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#size_in_bytes-1">FsxOntapVolume#size_in_bytes</a>.
        /// </summary>
        [<CustomOperation "size_in_bytes">]
        member _.SizeInBytes(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: string) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.SizeInBytes <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#size_in_megabytes-1">FsxOntapVolume#size_in_megabytes</a>.
        /// </summary>
        [<CustomOperation "size_in_megabytes">]
        member _.SizeInMegabytes(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: double) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.SizeInMegabytes <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#skip_final_backup-1">FsxOntapVolume#skip_final_backup</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_backup">]
        member _.SkipFinalBackup(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: bool) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.SkipFinalBackup <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#skip_final_backup-1">FsxOntapVolume#skip_final_backup</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_backup">]
        member _.SkipFinalBackup(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.SkipFinalBackup <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// snaplock_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#snaplock_configuration-1">FsxOntapVolume#snaplock_configuration</a>
        /// </summary>
        [<CustomOperation "snaplock_configuration">]
        member _.SnaplockConfiguration(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: aws.FsxOntapVolume.FsxOntapVolumeSnaplockConfiguration) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.SnaplockConfiguration <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#snapshot_policy-1">FsxOntapVolume#snapshot_policy</a>.
        /// </summary>
        [<CustomOperation "snapshot_policy">]
        member _.SnapshotPolicy(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: string) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.SnapshotPolicy <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#storage_efficiency_enabled-1">FsxOntapVolume#storage_efficiency_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_efficiency_enabled">]
        member _.StorageEfficiencyEnabled(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: bool) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.StorageEfficiencyEnabled <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#storage_efficiency_enabled-1">FsxOntapVolume#storage_efficiency_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_efficiency_enabled">]
        member _.StorageEfficiencyEnabled(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.StorageEfficiencyEnabled <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#tags-1">FsxOntapVolume#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: seq<string * string>) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#tags_all-1">FsxOntapVolume#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: seq<string * string>) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// tiering_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#tiering_policy-1">FsxOntapVolume#tiering_policy</a>
        /// </summary>
        [<CustomOperation "tiering_policy">]
        member _.TieringPolicy(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: aws.FsxOntapVolume.FsxOntapVolumeTieringPolicy) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.TieringPolicy <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#timeouts-1">FsxOntapVolume#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: aws.FsxOntapVolume.FsxOntapVolumeTimeouts) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#volume_style-1">FsxOntapVolume#volume_style</a>.
        /// </summary>
        [<CustomOperation "volume_style">]
        member _.VolumeStyle(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: string) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.VolumeStyle <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_volume#volume_type-1">FsxOntapVolume#volume_type</a>.
        /// </summary>
        [<CustomOperation "volume_type">]
        member _.VolumeType(state: FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>, value: string) : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId> =
            state.assignments.Add(fun config -> config.VolumeType <- value)
            state : FsxOntapVolumeState<'Name, 'StorageVirtualMachineId>

        member _.Run(state: FsxOntapVolumeState<Present, Present>) : aws.FsxOntapVolume.FsxOntapVolume =
            let config = aws.FsxOntapVolume.FsxOntapVolumeConfig()
            for setter in state.assignments do
                setter config
            aws.FsxOntapVolume.FsxOntapVolume(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.fsxOntapVolume: missing required arguments. Must call: name, storage_virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: FsxOntapVolumeState<_, _>) : aws.FsxOntapVolume.FsxOntapVolume =
            Unchecked.defaultof<aws.FsxOntapVolume.FsxOntapVolume>
