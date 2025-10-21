namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEbsSnapshotState = { assignments: ResizeArray<aws.DataAwsEbsSnapshot.DataAwsEbsSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot">aws_ebs_snapshot</a>.
    /// </summary>
    type DataAwsEbsSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEbsSnapshotState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEbsSnapshotState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot#filter-1">DataAwsEbsSnapshot#filter</a> Accepts: aws.IResolvable | aws.DataAwsEbsSnapshot.DataAwsEbsSnapshotFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEbsSnapshotState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEbsSnapshotState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEbsSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot#id-1">DataAwsEbsSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEbsSnapshotState, value: string) : DataAwsEbsSnapshotState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEbsSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot#most_recent-1">DataAwsEbsSnapshot#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsEbsSnapshotState, value: bool) : DataAwsEbsSnapshotState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsEbsSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot#most_recent-1">DataAwsEbsSnapshot#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsEbsSnapshotState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEbsSnapshotState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsEbsSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot#owners-1">DataAwsEbsSnapshot#owners</a>.
        /// </summary>
        [<CustomOperation "owners">]
        member _.Owners(state: DataAwsEbsSnapshotState, value: seq<string>) : DataAwsEbsSnapshotState =
            state.assignments.Add(fun config -> config.Owners <- (value |> Seq.toArray))
            state : DataAwsEbsSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot#restorable_by_user_ids-1">DataAwsEbsSnapshot#restorable_by_user_ids</a>.
        /// </summary>
        [<CustomOperation "restorable_by_user_ids">]
        member _.RestorableByUserIds(state: DataAwsEbsSnapshotState, value: seq<string>) : DataAwsEbsSnapshotState =
            state.assignments.Add(fun config -> config.RestorableByUserIds <- (value |> Seq.toArray))
            state : DataAwsEbsSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot#snapshot_ids-1">DataAwsEbsSnapshot#snapshot_ids</a>.
        /// </summary>
        [<CustomOperation "snapshot_ids">]
        member _.SnapshotIds(state: DataAwsEbsSnapshotState, value: seq<string>) : DataAwsEbsSnapshotState =
            state.assignments.Add(fun config -> config.SnapshotIds <- (value |> Seq.toArray))
            state : DataAwsEbsSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot#tags-1">DataAwsEbsSnapshot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEbsSnapshotState, value: seq<string * string>) : DataAwsEbsSnapshotState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEbsSnapshotState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot#timeouts-1">DataAwsEbsSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEbsSnapshotState, value: aws.DataAwsEbsSnapshot.DataAwsEbsSnapshotTimeouts) : DataAwsEbsSnapshotState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEbsSnapshotState

        member _.Run(state: DataAwsEbsSnapshotState) : aws.DataAwsEbsSnapshot.DataAwsEbsSnapshot =
            let config = aws.DataAwsEbsSnapshot.DataAwsEbsSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEbsSnapshot.DataAwsEbsSnapshot(StackContext.get (), logicalId, config)
