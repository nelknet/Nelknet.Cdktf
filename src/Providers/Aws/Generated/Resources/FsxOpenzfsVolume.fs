namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> = { assignments: ResizeArray<aws.FsxOpenzfsVolume.FsxOpenzfsVolumeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume">aws_fsx_openzfs_volume</a>.
    /// </summary>
    type FsxOpenzfsVolumeBuilder(logicalId: string) =
        member _.Yield(_: unit) : FsxOpenzfsVolumeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxOpenzfsVolumeState<Missing, Missing>)

        member _.Zero(()) : FsxOpenzfsVolumeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxOpenzfsVolumeState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#name-1">FsxOpenzfsVolume#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FsxOpenzfsVolumeState<Missing, 'ParentVolumeId>, value: string) : FsxOpenzfsVolumeState<Present, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FsxOpenzfsVolumeState<Present, 'ParentVolumeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#parent_volume_id-1">FsxOpenzfsVolume#parent_volume_id</a>.
        /// </summary>
        [<CustomOperation "parent_volume_id">]
        member _.ParentVolumeId(state: FsxOpenzfsVolumeState<'Name, Missing>, value: string) : FsxOpenzfsVolumeState<'Name, Present> =
            state.assignments.Add(fun config -> config.ParentVolumeId <- value)
            ({ assignments = state.assignments } : FsxOpenzfsVolumeState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#copy_tags_to_snapshots-1">FsxOpenzfsVolume#copy_tags_to_snapshots</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_snapshots">]
        member _.CopyTagsToSnapshots(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: bool) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.CopyTagsToSnapshots <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#copy_tags_to_snapshots-1">FsxOpenzfsVolume#copy_tags_to_snapshots</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_snapshots">]
        member _.CopyTagsToSnapshots(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: HashiCorp.Cdktf.IResolvable) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.CopyTagsToSnapshots <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#data_compression_type-1">FsxOpenzfsVolume#data_compression_type</a>.
        /// </summary>
        [<CustomOperation "data_compression_type">]
        member _.DataCompressionType(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: string) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.DataCompressionType <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#delete_volume_options-1">FsxOpenzfsVolume#delete_volume_options</a>.
        /// </summary>
        [<CustomOperation "delete_volume_options">]
        member _.DeleteVolumeOptions(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: seq<string>) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.DeleteVolumeOptions <- (value |> Seq.toArray))
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#id-1">FsxOpenzfsVolume#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: string) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// nfs_exports block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#nfs_exports-1">FsxOpenzfsVolume#nfs_exports</a>
        /// </summary>
        [<CustomOperation "nfs_exports">]
        member _.NfsExports(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: aws.FsxOpenzfsVolume.FsxOpenzfsVolumeNfsExports) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.NfsExports <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// origin_snapshot block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#origin_snapshot-1">FsxOpenzfsVolume#origin_snapshot</a>
        /// </summary>
        [<CustomOperation "origin_snapshot">]
        member _.OriginSnapshot(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: aws.FsxOpenzfsVolume.FsxOpenzfsVolumeOriginSnapshot) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.OriginSnapshot <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#read_only-1">FsxOpenzfsVolume#read_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "read_only">]
        member _.ReadOnly(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: bool) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.ReadOnly <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#read_only-1">FsxOpenzfsVolume#read_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "read_only">]
        member _.ReadOnly(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: HashiCorp.Cdktf.IResolvable) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.ReadOnly <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#record_size_kib-1">FsxOpenzfsVolume#record_size_kib</a>.
        /// </summary>
        [<CustomOperation "record_size_kib">]
        member _.RecordSizeKib(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: double) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.RecordSizeKib <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#storage_capacity_quota_gib-1">FsxOpenzfsVolume#storage_capacity_quota_gib</a>.
        /// </summary>
        [<CustomOperation "storage_capacity_quota_gib">]
        member _.StorageCapacityQuotaGib(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: double) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.StorageCapacityQuotaGib <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#storage_capacity_reservation_gib-1">FsxOpenzfsVolume#storage_capacity_reservation_gib</a>.
        /// </summary>
        [<CustomOperation "storage_capacity_reservation_gib">]
        member _.StorageCapacityReservationGib(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: double) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.StorageCapacityReservationGib <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#tags-1">FsxOpenzfsVolume#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: seq<string * string>) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#tags_all-1">FsxOpenzfsVolume#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: seq<string * string>) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#timeouts-1">FsxOpenzfsVolume#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: aws.FsxOpenzfsVolume.FsxOpenzfsVolumeTimeouts) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// user_and_group_quotas block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#user_and_group_quotas-1">FsxOpenzfsVolume#user_and_group_quotas</a> Accepts: aws.IResolvable | aws.FsxOpenzfsVolume.FsxOpenzfsVolumeUserAndGroupQuotas[]
        /// </summary>
        [<CustomOperation "user_and_group_quotas">]
        member _.UserAndGroupQuotas(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: HashiCorp.Cdktf.IResolvable) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.UserAndGroupQuotas <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#volume_type-1">FsxOpenzfsVolume#volume_type</a>.
        /// </summary>
        [<CustomOperation "volume_type">]
        member _.VolumeType(state: FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>, value: string) : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId> =
            state.assignments.Add(fun config -> config.VolumeType <- value)
            state : FsxOpenzfsVolumeState<'Name, 'ParentVolumeId>

        member _.Run(state: FsxOpenzfsVolumeState<Present, Present>) : aws.FsxOpenzfsVolume.FsxOpenzfsVolume =
            let config = aws.FsxOpenzfsVolume.FsxOpenzfsVolumeConfig()
            for setter in state.assignments do
                setter config
            aws.FsxOpenzfsVolume.FsxOpenzfsVolume(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.fsxOpenzfsVolume: missing required arguments. Must call: name, parent_volume_id.", 9999, IsError = true)>]
        member _.Run(_: FsxOpenzfsVolumeState<_, _>) : aws.FsxOpenzfsVolume.FsxOpenzfsVolume =
            Unchecked.defaultof<aws.FsxOpenzfsVolume.FsxOpenzfsVolume>
