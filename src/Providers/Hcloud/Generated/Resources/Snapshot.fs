namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SnapshotState<'ServerId> = { assignments: ResizeArray<hcloud.Snapshot.SnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/snapshot">hcloud_snapshot</a>.
    /// </summary>
    type SnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : SnapshotState<Missing> =
            ({ assignments = ResizeArray() } : SnapshotState<Missing>)

        member _.Zero(()) : SnapshotState<Missing> =
            ({ assignments = ResizeArray() } : SnapshotState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/snapshot#server_id-1">Snapshot#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: SnapshotState<Missing>, value: double) : SnapshotState<Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : SnapshotState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/snapshot#description-1">Snapshot#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SnapshotState<'ServerId>, value: string) : SnapshotState<'ServerId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SnapshotState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/snapshot#id-1">Snapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SnapshotState<'ServerId>, value: string) : SnapshotState<'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SnapshotState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/snapshot#labels-1">Snapshot#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: SnapshotState<'ServerId>, value: seq<string * string>) : SnapshotState<'ServerId> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : SnapshotState<'ServerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/snapshot#timeouts-1">Snapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SnapshotState<'ServerId>, value: hcloud.Snapshot.SnapshotTimeouts) : SnapshotState<'ServerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SnapshotState<'ServerId>

        member _.Run(state: SnapshotState<Present>) : hcloud.Snapshot.Snapshot =
            let config = hcloud.Snapshot.SnapshotConfig()
            for setter in state.assignments do
                setter config
            hcloud.Snapshot.Snapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.snapshot: missing required arguments. Must call: server_id.", 9999, IsError = true)>]
        member _.Run(_: SnapshotState<_>) : hcloud.Snapshot.Snapshot =
            Unchecked.defaultof<hcloud.Snapshot.Snapshot>
