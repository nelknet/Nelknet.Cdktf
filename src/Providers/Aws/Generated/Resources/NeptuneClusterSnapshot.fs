namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NeptuneClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier> = { assignments: ResizeArray<aws.NeptuneClusterSnapshot.NeptuneClusterSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_snapshot">aws_neptune_cluster_snapshot</a>.
    /// </summary>
    type NeptuneClusterSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : NeptuneClusterSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NeptuneClusterSnapshotState<Missing, Missing>)

        member _.Zero(()) : NeptuneClusterSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NeptuneClusterSnapshotState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_snapshot#db_cluster_identifier-1">NeptuneClusterSnapshot#db_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "db_cluster_identifier">]
        member _.DbClusterIdentifier(state: NeptuneClusterSnapshotState<Missing, 'DbClusterSnapshotIdentifier>, value: string) : NeptuneClusterSnapshotState<Present, 'DbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.DbClusterIdentifier <- value)
            ({ assignments = state.assignments } : NeptuneClusterSnapshotState<Present, 'DbClusterSnapshotIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_snapshot#db_cluster_snapshot_identifier-1">NeptuneClusterSnapshot#db_cluster_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "db_cluster_snapshot_identifier">]
        member _.DbClusterSnapshotIdentifier(state: NeptuneClusterSnapshotState<'DbClusterIdentifier, Missing>, value: string) : NeptuneClusterSnapshotState<'DbClusterIdentifier, Present> =
            state.assignments.Add(fun config -> config.DbClusterSnapshotIdentifier <- value)
            ({ assignments = state.assignments } : NeptuneClusterSnapshotState<'DbClusterIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_snapshot#id-1">NeptuneClusterSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NeptuneClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>, value: string) : NeptuneClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NeptuneClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_snapshot#timeouts-1">NeptuneClusterSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NeptuneClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>, value: aws.NeptuneClusterSnapshot.NeptuneClusterSnapshotTimeouts) : NeptuneClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NeptuneClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>

        member _.Run(state: NeptuneClusterSnapshotState<Present, Present>) : aws.NeptuneClusterSnapshot.NeptuneClusterSnapshot =
            let config = aws.NeptuneClusterSnapshot.NeptuneClusterSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.NeptuneClusterSnapshot.NeptuneClusterSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.neptuneClusterSnapshot: missing required arguments. Must call: db_cluster_identifier, db_cluster_snapshot_identifier.", 9999, IsError = true)>]
        member _.Run(_: NeptuneClusterSnapshotState<_, _>) : aws.NeptuneClusterSnapshot.NeptuneClusterSnapshot =
            Unchecked.defaultof<aws.NeptuneClusterSnapshot.NeptuneClusterSnapshot>
