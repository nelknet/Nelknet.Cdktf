namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsFsxOpenzfsSnapshotState = { assignments: ResizeArray<aws.DataAwsFsxOpenzfsSnapshot.DataAwsFsxOpenzfsSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_openzfs_snapshot">aws_fsx_openzfs_snapshot</a>.
    /// </summary>
    type DataAwsFsxOpenzfsSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsFsxOpenzfsSnapshotState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsFsxOpenzfsSnapshotState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_openzfs_snapshot#filter-1">DataAwsFsxOpenzfsSnapshot#filter</a> Accepts: aws.IResolvable | aws.DataAwsFsxOpenzfsSnapshot.DataAwsFsxOpenzfsSnapshotFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsFsxOpenzfsSnapshotState, value: HashiCorp.Cdktf.IResolvable) : DataAwsFsxOpenzfsSnapshotState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsFsxOpenzfsSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_openzfs_snapshot#id-1">DataAwsFsxOpenzfsSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsFsxOpenzfsSnapshotState, value: string) : DataAwsFsxOpenzfsSnapshotState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsFsxOpenzfsSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_openzfs_snapshot#most_recent-1">DataAwsFsxOpenzfsSnapshot#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsFsxOpenzfsSnapshotState, value: bool) : DataAwsFsxOpenzfsSnapshotState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsFsxOpenzfsSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_openzfs_snapshot#most_recent-1">DataAwsFsxOpenzfsSnapshot#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsFsxOpenzfsSnapshotState, value: HashiCorp.Cdktf.IResolvable) : DataAwsFsxOpenzfsSnapshotState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsFsxOpenzfsSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_openzfs_snapshot#name-1">DataAwsFsxOpenzfsSnapshot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsFsxOpenzfsSnapshotState, value: string) : DataAwsFsxOpenzfsSnapshotState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsFsxOpenzfsSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_openzfs_snapshot#snapshot_ids-1">DataAwsFsxOpenzfsSnapshot#snapshot_ids</a>.
        /// </summary>
        [<CustomOperation "snapshot_ids">]
        member _.SnapshotIds(state: DataAwsFsxOpenzfsSnapshotState, value: seq<string>) : DataAwsFsxOpenzfsSnapshotState =
            state.assignments.Add(fun config -> config.SnapshotIds <- (value |> Seq.toArray))
            state : DataAwsFsxOpenzfsSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fsx_openzfs_snapshot#tags-1">DataAwsFsxOpenzfsSnapshot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsFsxOpenzfsSnapshotState, value: seq<string * string>) : DataAwsFsxOpenzfsSnapshotState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsFsxOpenzfsSnapshotState

        member _.Run(state: DataAwsFsxOpenzfsSnapshotState) : aws.DataAwsFsxOpenzfsSnapshot.DataAwsFsxOpenzfsSnapshot =
            let config = aws.DataAwsFsxOpenzfsSnapshot.DataAwsFsxOpenzfsSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsFsxOpenzfsSnapshot.DataAwsFsxOpenzfsSnapshot(StackContext.get (), logicalId, config)
