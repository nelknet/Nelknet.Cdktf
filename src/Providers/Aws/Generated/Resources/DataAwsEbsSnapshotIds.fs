namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEbsSnapshotIdsState = { assignments: ResizeArray<aws.DataAwsEbsSnapshotIds.DataAwsEbsSnapshotIdsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot_ids">aws_ebs_snapshot_ids</a>.
    /// </summary>
    type DataAwsEbsSnapshotIdsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEbsSnapshotIdsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEbsSnapshotIdsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot_ids#filter-1">DataAwsEbsSnapshotIds#filter</a> Accepts: aws.IResolvable | aws.DataAwsEbsSnapshotIds.DataAwsEbsSnapshotIdsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEbsSnapshotIdsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEbsSnapshotIdsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEbsSnapshotIdsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot_ids#id-1">DataAwsEbsSnapshotIds#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEbsSnapshotIdsState, value: string) : DataAwsEbsSnapshotIdsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEbsSnapshotIdsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot_ids#owners-1">DataAwsEbsSnapshotIds#owners</a>.
        /// </summary>
        [<CustomOperation "owners">]
        member _.Owners(state: DataAwsEbsSnapshotIdsState, value: seq<string>) : DataAwsEbsSnapshotIdsState =
            state.assignments.Add(fun config -> config.Owners <- (value |> Seq.toArray))
            state : DataAwsEbsSnapshotIdsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot_ids#restorable_by_user_ids-1">DataAwsEbsSnapshotIds#restorable_by_user_ids</a>.
        /// </summary>
        [<CustomOperation "restorable_by_user_ids">]
        member _.RestorableByUserIds(state: DataAwsEbsSnapshotIdsState, value: seq<string>) : DataAwsEbsSnapshotIdsState =
            state.assignments.Add(fun config -> config.RestorableByUserIds <- (value |> Seq.toArray))
            state : DataAwsEbsSnapshotIdsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot_ids#timeouts-1">DataAwsEbsSnapshotIds#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEbsSnapshotIdsState, value: aws.DataAwsEbsSnapshotIds.DataAwsEbsSnapshotIdsTimeouts) : DataAwsEbsSnapshotIdsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEbsSnapshotIdsState

        member _.Run(state: DataAwsEbsSnapshotIdsState) : aws.DataAwsEbsSnapshotIds.DataAwsEbsSnapshotIds =
            let config = aws.DataAwsEbsSnapshotIds.DataAwsEbsSnapshotIdsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEbsSnapshotIds.DataAwsEbsSnapshotIds(StackContext.get (), logicalId, config)
