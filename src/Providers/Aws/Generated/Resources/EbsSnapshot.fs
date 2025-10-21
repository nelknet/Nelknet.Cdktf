namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EbsSnapshotState<'VolumeId> = { assignments: ResizeArray<aws.EbsSnapshot.EbsSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot">aws_ebs_snapshot</a>.
    /// </summary>
    type EbsSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : EbsSnapshotState<Missing> =
            ({ assignments = ResizeArray() } : EbsSnapshotState<Missing>)

        member _.Zero(()) : EbsSnapshotState<Missing> =
            ({ assignments = ResizeArray() } : EbsSnapshotState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot#volume_id-1">EbsSnapshot#volume_id</a>.
        /// </summary>
        [<CustomOperation "volume_id">]
        member _.VolumeId(state: EbsSnapshotState<Missing>, value: string) : EbsSnapshotState<Present> =
            state.assignments.Add(fun config -> config.VolumeId <- value)
            ({ assignments = state.assignments } : EbsSnapshotState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot#description-1">EbsSnapshot#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: EbsSnapshotState<'VolumeId>, value: string) : EbsSnapshotState<'VolumeId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : EbsSnapshotState<'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot#id-1">EbsSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EbsSnapshotState<'VolumeId>, value: string) : EbsSnapshotState<'VolumeId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EbsSnapshotState<'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot#outpost_arn-1">EbsSnapshot#outpost_arn</a>.
        /// </summary>
        [<CustomOperation "outpost_arn">]
        member _.OutpostArn(state: EbsSnapshotState<'VolumeId>, value: string) : EbsSnapshotState<'VolumeId> =
            state.assignments.Add(fun config -> config.OutpostArn <- value)
            state : EbsSnapshotState<'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot#permanent_restore-1">EbsSnapshot#permanent_restore</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "permanent_restore">]
        member _.PermanentRestore(state: EbsSnapshotState<'VolumeId>, value: bool) : EbsSnapshotState<'VolumeId> =
            state.assignments.Add(fun config -> config.PermanentRestore <- value)
            state : EbsSnapshotState<'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot#permanent_restore-1">EbsSnapshot#permanent_restore</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "permanent_restore">]
        member _.PermanentRestore(state: EbsSnapshotState<'VolumeId>, value: HashiCorp.Cdktf.IResolvable) : EbsSnapshotState<'VolumeId> =
            state.assignments.Add(fun config -> config.PermanentRestore <- value)
            state : EbsSnapshotState<'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot#storage_tier-1">EbsSnapshot#storage_tier</a>.
        /// </summary>
        [<CustomOperation "storage_tier">]
        member _.StorageTier(state: EbsSnapshotState<'VolumeId>, value: string) : EbsSnapshotState<'VolumeId> =
            state.assignments.Add(fun config -> config.StorageTier <- value)
            state : EbsSnapshotState<'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot#tags-1">EbsSnapshot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EbsSnapshotState<'VolumeId>, value: seq<string * string>) : EbsSnapshotState<'VolumeId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EbsSnapshotState<'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot#tags_all-1">EbsSnapshot#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EbsSnapshotState<'VolumeId>, value: seq<string * string>) : EbsSnapshotState<'VolumeId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EbsSnapshotState<'VolumeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot#temporary_restore_days-1">EbsSnapshot#temporary_restore_days</a>.
        /// </summary>
        [<CustomOperation "temporary_restore_days">]
        member _.TemporaryRestoreDays(state: EbsSnapshotState<'VolumeId>, value: double) : EbsSnapshotState<'VolumeId> =
            state.assignments.Add(fun config -> config.TemporaryRestoreDays <- value)
            state : EbsSnapshotState<'VolumeId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot#timeouts-1">EbsSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EbsSnapshotState<'VolumeId>, value: aws.EbsSnapshot.EbsSnapshotTimeouts) : EbsSnapshotState<'VolumeId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EbsSnapshotState<'VolumeId>

        member _.Run(state: EbsSnapshotState<Present>) : aws.EbsSnapshot.EbsSnapshot =
            let config = aws.EbsSnapshot.EbsSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.EbsSnapshot.EbsSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ebsSnapshot: missing required arguments. Must call: volume_id.", 9999, IsError = true)>]
        member _.Run(_: EbsSnapshotState<_>) : aws.EbsSnapshot.EbsSnapshot =
            Unchecked.defaultof<aws.EbsSnapshot.EbsSnapshot>
