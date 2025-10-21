namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier> = { assignments: ResizeArray<aws.DbClusterSnapshot.DbClusterSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_cluster_snapshot">aws_db_cluster_snapshot</a>.
    /// </summary>
    type DbClusterSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbClusterSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DbClusterSnapshotState<Missing, Missing>)

        member _.Zero(()) : DbClusterSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DbClusterSnapshotState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_cluster_snapshot#db_cluster_identifier-1">DbClusterSnapshot#db_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "db_cluster_identifier">]
        member _.DbClusterIdentifier(state: DbClusterSnapshotState<Missing, 'DbClusterSnapshotIdentifier>, value: string) : DbClusterSnapshotState<Present, 'DbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.DbClusterIdentifier <- value)
            ({ assignments = state.assignments } : DbClusterSnapshotState<Present, 'DbClusterSnapshotIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_cluster_snapshot#db_cluster_snapshot_identifier-1">DbClusterSnapshot#db_cluster_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "db_cluster_snapshot_identifier">]
        member _.DbClusterSnapshotIdentifier(state: DbClusterSnapshotState<'DbClusterIdentifier, Missing>, value: string) : DbClusterSnapshotState<'DbClusterIdentifier, Present> =
            state.assignments.Add(fun config -> config.DbClusterSnapshotIdentifier <- value)
            ({ assignments = state.assignments } : DbClusterSnapshotState<'DbClusterIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_cluster_snapshot#id-1">DbClusterSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>, value: string) : DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_cluster_snapshot#shared_accounts-1">DbClusterSnapshot#shared_accounts</a>.
        /// </summary>
        [<CustomOperation "shared_accounts">]
        member _.SharedAccounts(state: DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>, value: seq<string>) : DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.SharedAccounts <- (value |> Seq.toArray))
            state : DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_cluster_snapshot#tags-1">DbClusterSnapshot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>, value: seq<string * string>) : DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_cluster_snapshot#tags_all-1">DbClusterSnapshot#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>, value: seq<string * string>) : DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_cluster_snapshot#timeouts-1">DbClusterSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>, value: aws.DbClusterSnapshot.DbClusterSnapshotTimeouts) : DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DbClusterSnapshotState<'DbClusterIdentifier, 'DbClusterSnapshotIdentifier>

        member _.Run(state: DbClusterSnapshotState<Present, Present>) : aws.DbClusterSnapshot.DbClusterSnapshot =
            let config = aws.DbClusterSnapshot.DbClusterSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.DbClusterSnapshot.DbClusterSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbClusterSnapshot: missing required arguments. Must call: db_cluster_identifier, db_cluster_snapshot_identifier.", 9999, IsError = true)>]
        member _.Run(_: DbClusterSnapshotState<_, _>) : aws.DbClusterSnapshot.DbClusterSnapshot =
            Unchecked.defaultof<aws.DbClusterSnapshot.DbClusterSnapshot>
