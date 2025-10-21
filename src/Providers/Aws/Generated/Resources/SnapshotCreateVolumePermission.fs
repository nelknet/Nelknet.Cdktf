namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SnapshotCreateVolumePermissionState<'AccountId, 'SnapshotId> = { assignments: ResizeArray<aws.SnapshotCreateVolumePermission.SnapshotCreateVolumePermissionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/snapshot_create_volume_permission">aws_snapshot_create_volume_permission</a>.
    /// </summary>
    type SnapshotCreateVolumePermissionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SnapshotCreateVolumePermissionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SnapshotCreateVolumePermissionState<Missing, Missing>)

        member _.Zero(()) : SnapshotCreateVolumePermissionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SnapshotCreateVolumePermissionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/snapshot_create_volume_permission#account_id-1">SnapshotCreateVolumePermission#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: SnapshotCreateVolumePermissionState<Missing, 'SnapshotId>, value: string) : SnapshotCreateVolumePermissionState<Present, 'SnapshotId> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : SnapshotCreateVolumePermissionState<Present, 'SnapshotId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/snapshot_create_volume_permission#snapshot_id-1">SnapshotCreateVolumePermission#snapshot_id</a>.
        /// </summary>
        [<CustomOperation "snapshot_id">]
        member _.SnapshotId(state: SnapshotCreateVolumePermissionState<'AccountId, Missing>, value: string) : SnapshotCreateVolumePermissionState<'AccountId, Present> =
            state.assignments.Add(fun config -> config.SnapshotId <- value)
            ({ assignments = state.assignments } : SnapshotCreateVolumePermissionState<'AccountId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/snapshot_create_volume_permission#id-1">SnapshotCreateVolumePermission#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SnapshotCreateVolumePermissionState<'AccountId, 'SnapshotId>, value: string) : SnapshotCreateVolumePermissionState<'AccountId, 'SnapshotId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SnapshotCreateVolumePermissionState<'AccountId, 'SnapshotId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/snapshot_create_volume_permission#timeouts-1">SnapshotCreateVolumePermission#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SnapshotCreateVolumePermissionState<'AccountId, 'SnapshotId>, value: aws.SnapshotCreateVolumePermission.SnapshotCreateVolumePermissionTimeouts) : SnapshotCreateVolumePermissionState<'AccountId, 'SnapshotId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SnapshotCreateVolumePermissionState<'AccountId, 'SnapshotId>

        member _.Run(state: SnapshotCreateVolumePermissionState<Present, Present>) : aws.SnapshotCreateVolumePermission.SnapshotCreateVolumePermission =
            let config = aws.SnapshotCreateVolumePermission.SnapshotCreateVolumePermissionConfig()
            for setter in state.assignments do
                setter config
            aws.SnapshotCreateVolumePermission.SnapshotCreateVolumePermission(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.snapshotCreateVolumePermission: missing required arguments. Must call: account_id, snapshot_id.", 9999, IsError = true)>]
        member _.Run(_: SnapshotCreateVolumePermissionState<_, _>) : aws.SnapshotCreateVolumePermission.SnapshotCreateVolumePermission =
            Unchecked.defaultof<aws.SnapshotCreateVolumePermission.SnapshotCreateVolumePermission>
