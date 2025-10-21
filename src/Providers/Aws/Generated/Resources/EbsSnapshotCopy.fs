namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> = { assignments: ResizeArray<aws.EbsSnapshotCopy.EbsSnapshotCopyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy">aws_ebs_snapshot_copy</a>.
    /// </summary>
    type EbsSnapshotCopyBuilder(logicalId: string) =
        member _.Yield(_: unit) : EbsSnapshotCopyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EbsSnapshotCopyState<Missing, Missing>)

        member _.Zero(()) : EbsSnapshotCopyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EbsSnapshotCopyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#source_region-1">EbsSnapshotCopy#source_region</a>.
        /// </summary>
        [<CustomOperation "source_region">]
        member _.SourceRegion(state: EbsSnapshotCopyState<Missing, 'SourceSnapshotId>, value: string) : EbsSnapshotCopyState<Present, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.SourceRegion <- value)
            ({ assignments = state.assignments } : EbsSnapshotCopyState<Present, 'SourceSnapshotId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#source_snapshot_id-1">EbsSnapshotCopy#source_snapshot_id</a>.
        /// </summary>
        [<CustomOperation "source_snapshot_id">]
        member _.SourceSnapshotId(state: EbsSnapshotCopyState<'SourceRegion, Missing>, value: string) : EbsSnapshotCopyState<'SourceRegion, Present> =
            state.assignments.Add(fun config -> config.SourceSnapshotId <- value)
            ({ assignments = state.assignments } : EbsSnapshotCopyState<'SourceRegion, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#completion_duration_minutes-1">EbsSnapshotCopy#completion_duration_minutes</a>.
        /// </summary>
        [<CustomOperation "completion_duration_minutes">]
        member _.CompletionDurationMinutes(state: EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>, value: double) : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.CompletionDurationMinutes <- value)
            state : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#description-1">EbsSnapshotCopy#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>, value: string) : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#encrypted-1">EbsSnapshotCopy#encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>, value: bool) : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#encrypted-1">EbsSnapshotCopy#encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>, value: HashiCorp.Cdktf.IResolvable) : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#id-1">EbsSnapshotCopy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>, value: string) : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#kms_key_id-1">EbsSnapshotCopy#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>, value: string) : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#permanent_restore-1">EbsSnapshotCopy#permanent_restore</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "permanent_restore">]
        member _.PermanentRestore(state: EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>, value: bool) : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.PermanentRestore <- value)
            state : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#permanent_restore-1">EbsSnapshotCopy#permanent_restore</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "permanent_restore">]
        member _.PermanentRestore(state: EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>, value: HashiCorp.Cdktf.IResolvable) : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.PermanentRestore <- value)
            state : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#storage_tier-1">EbsSnapshotCopy#storage_tier</a>.
        /// </summary>
        [<CustomOperation "storage_tier">]
        member _.StorageTier(state: EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>, value: string) : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.StorageTier <- value)
            state : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#tags-1">EbsSnapshotCopy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>, value: seq<string * string>) : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#tags_all-1">EbsSnapshotCopy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>, value: seq<string * string>) : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#temporary_restore_days-1">EbsSnapshotCopy#temporary_restore_days</a>.
        /// </summary>
        [<CustomOperation "temporary_restore_days">]
        member _.TemporaryRestoreDays(state: EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>, value: double) : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.TemporaryRestoreDays <- value)
            state : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_copy#timeouts-1">EbsSnapshotCopy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>, value: aws.EbsSnapshotCopy.EbsSnapshotCopyTimeouts) : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EbsSnapshotCopyState<'SourceRegion, 'SourceSnapshotId>

        member _.Run(state: EbsSnapshotCopyState<Present, Present>) : aws.EbsSnapshotCopy.EbsSnapshotCopy =
            let config = aws.EbsSnapshotCopy.EbsSnapshotCopyConfig()
            for setter in state.assignments do
                setter config
            aws.EbsSnapshotCopy.EbsSnapshotCopy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ebsSnapshotCopy: missing required arguments. Must call: source_region, source_snapshot_id.", 9999, IsError = true)>]
        member _.Run(_: EbsSnapshotCopyState<_, _>) : aws.EbsSnapshotCopy.EbsSnapshotCopy =
            Unchecked.defaultof<aws.EbsSnapshotCopy.EbsSnapshotCopy>
