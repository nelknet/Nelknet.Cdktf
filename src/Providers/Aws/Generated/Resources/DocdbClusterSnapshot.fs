namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DocdbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier> = { assignments: ResizeArray<aws.DocdbClusterSnapshot.DocdbClusterSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_snapshot">aws_docdb_cluster_snapshot</a>.
    /// </summary>
    type DocdbClusterSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : DocdbClusterSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DocdbClusterSnapshotState<Missing, Missing>)

        member _.Zero(()) : DocdbClusterSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DocdbClusterSnapshotState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_snapshot#db_cluster_identifier-1">DocdbClusterSnapshot#db_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "db_cluster_identifier">]
        member _.DbClusterIdentifier(state: DocdbClusterSnapshotState<Missing, 'DbClusterSnapshotIdentifier>, value: string) : DocdbClusterSnapshotState<Present, 'DbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.DbClusterIdentifier <- value)
            ({ assignments = state.assignments } : DocdbClusterSnapshotState<Present, 'DbClusterSnapshotIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_snapshot#db_cluster_snapshot_identifier-1">DocdbClusterSnapshot#db_cluster_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "db_cluster_snapshot_identifier">]
        member _.DbClusterSnapshotIdentifier(state: DocdbClusterSnapshotState<'DbClusterIdentifier, Missing>, value: string) : DocdbClusterSnapshotState<'DbClusterIdentifier, Present> =
            state.assignments.Add(fun config -> config.DbClusterSnapshotIdentifier <- value)
            ({ assignments = state.assignments } : DocdbClusterSnapshotState<'DbClusterIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_snapshot#id-1">DocdbClusterSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DocdbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>, value: string) : DocdbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DocdbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_snapshot#timeouts-1">DocdbClusterSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DocdbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>, value: aws.DocdbClusterSnapshot.DocdbClusterSnapshotTimeouts) : DocdbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DocdbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>

        member _.Run(state: DocdbClusterSnapshotState<Present, Present>) : aws.DocdbClusterSnapshot.DocdbClusterSnapshot =
            let config = aws.DocdbClusterSnapshot.DocdbClusterSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.DocdbClusterSnapshot.DocdbClusterSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.docdbClusterSnapshot: missing required arguments. Must call: db_cluster_identifier, db_cluster_snapshot_identifier.", 9999, IsError = true)>]
        member _.Run(_: DocdbClusterSnapshotState<_, _>) : aws.DocdbClusterSnapshot.DocdbClusterSnapshot =
            Unchecked.defaultof<aws.DocdbClusterSnapshot.DocdbClusterSnapshot>
