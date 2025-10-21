namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FsxOpenzfsSnapshotState<'Name, 'VolumeId> = { assignments: ResizeArray<aws.FsxOpenzfsSnapshot.FsxOpenzfsSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_snapshot">aws_fsx_openzfs_snapshot</a>.
    /// </summary>
    type FsxOpenzfsSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : FsxOpenzfsSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxOpenzfsSnapshotState<Missing, Missing>)

        member _.Zero(()) : FsxOpenzfsSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxOpenzfsSnapshotState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_snapshot#name-1">FsxOpenzfsSnapshot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FsxOpenzfsSnapshotState<Missing, 'VolumeId>, value: string) : FsxOpenzfsSnapshotState<Present, 'VolumeId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FsxOpenzfsSnapshotState<Present, 'VolumeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_snapshot#volume_id-1">FsxOpenzfsSnapshot#volume_id</a>.
        /// </summary>
        [<CustomOperation "volume_id">]
        member _.VolumeId(state: FsxOpenzfsSnapshotState<'Name, Missing>, value: string) : FsxOpenzfsSnapshotState<'Name, Present> =
            state.assignments.Add(fun config -> config.VolumeId <- value)
            ({ assignments = state.assignments } : FsxOpenzfsSnapshotState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_snapshot#id-1">FsxOpenzfsSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FsxOpenzfsSnapshotState<'Name, 'VolumeId>, value: string) : FsxOpenzfsSnapshotState<'Name, 'VolumeId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FsxOpenzfsSnapshotState<'Name, 'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_snapshot#tags-1">FsxOpenzfsSnapshot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FsxOpenzfsSnapshotState<'Name, 'VolumeId>, value: seq<string * string>) : FsxOpenzfsSnapshotState<'Name, 'VolumeId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FsxOpenzfsSnapshotState<'Name, 'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_snapshot#tags_all-1">FsxOpenzfsSnapshot#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FsxOpenzfsSnapshotState<'Name, 'VolumeId>, value: seq<string * string>) : FsxOpenzfsSnapshotState<'Name, 'VolumeId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FsxOpenzfsSnapshotState<'Name, 'VolumeId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_snapshot#timeouts-1">FsxOpenzfsSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FsxOpenzfsSnapshotState<'Name, 'VolumeId>, value: aws.FsxOpenzfsSnapshot.FsxOpenzfsSnapshotTimeouts) : FsxOpenzfsSnapshotState<'Name, 'VolumeId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FsxOpenzfsSnapshotState<'Name, 'VolumeId>

        member _.Run(state: FsxOpenzfsSnapshotState<Present, Present>) : aws.FsxOpenzfsSnapshot.FsxOpenzfsSnapshot =
            let config = aws.FsxOpenzfsSnapshot.FsxOpenzfsSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.FsxOpenzfsSnapshot.FsxOpenzfsSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.fsxOpenzfsSnapshot: missing required arguments. Must call: name, volume_id.", 9999, IsError = true)>]
        member _.Run(_: FsxOpenzfsSnapshotState<_, _>) : aws.FsxOpenzfsSnapshot.FsxOpenzfsSnapshot =
            Unchecked.defaultof<aws.FsxOpenzfsSnapshot.FsxOpenzfsSnapshot>
