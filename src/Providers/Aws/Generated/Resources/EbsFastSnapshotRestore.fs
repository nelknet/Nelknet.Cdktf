namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EbsFastSnapshotRestoreState<'AvailabilityZone, 'SnapshotId> = { assignments: ResizeArray<aws.EbsFastSnapshotRestore.EbsFastSnapshotRestoreConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_fast_snapshot_restore">aws_ebs_fast_snapshot_restore</a>.
    /// </summary>
    type EbsFastSnapshotRestoreBuilder(logicalId: string) =
        member _.Yield(_: unit) : EbsFastSnapshotRestoreState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EbsFastSnapshotRestoreState<Missing, Missing>)

        member _.Zero(()) : EbsFastSnapshotRestoreState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EbsFastSnapshotRestoreState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_fast_snapshot_restore#availability_zone-1">EbsFastSnapshotRestore#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: EbsFastSnapshotRestoreState<Missing, 'SnapshotId>, value: string) : EbsFastSnapshotRestoreState<Present, 'SnapshotId> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            ({ assignments = state.assignments } : EbsFastSnapshotRestoreState<Present, 'SnapshotId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_fast_snapshot_restore#snapshot_id-1">EbsFastSnapshotRestore#snapshot_id</a>.
        /// </summary>
        [<CustomOperation "snapshot_id">]
        member _.SnapshotId(state: EbsFastSnapshotRestoreState<'AvailabilityZone, Missing>, value: string) : EbsFastSnapshotRestoreState<'AvailabilityZone, Present> =
            state.assignments.Add(fun config -> config.SnapshotId <- value)
            ({ assignments = state.assignments } : EbsFastSnapshotRestoreState<'AvailabilityZone, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_fast_snapshot_restore#timeouts-1">EbsFastSnapshotRestore#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EbsFastSnapshotRestoreState<'AvailabilityZone, 'SnapshotId>, value: aws.EbsFastSnapshotRestore.EbsFastSnapshotRestoreTimeouts) : EbsFastSnapshotRestoreState<'AvailabilityZone, 'SnapshotId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EbsFastSnapshotRestoreState<'AvailabilityZone, 'SnapshotId>

        member _.Run(state: EbsFastSnapshotRestoreState<Present, Present>) : aws.EbsFastSnapshotRestore.EbsFastSnapshotRestore =
            let config = aws.EbsFastSnapshotRestore.EbsFastSnapshotRestoreConfig()
            for setter in state.assignments do
                setter config
            aws.EbsFastSnapshotRestore.EbsFastSnapshotRestore(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ebsFastSnapshotRestore: missing required arguments. Must call: availability_zone, snapshot_id.", 9999, IsError = true)>]
        member _.Run(_: EbsFastSnapshotRestoreState<_, _>) : aws.EbsFastSnapshotRestore.EbsFastSnapshotRestore =
            Unchecked.defaultof<aws.EbsFastSnapshotRestore.EbsFastSnapshotRestore>
