namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier> = { assignments: ResizeArray<aws.DbSnapshot.DbSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot">aws_db_snapshot</a>.
    /// </summary>
    type DbSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DbSnapshotState<Missing, Missing>)

        member _.Zero(()) : DbSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DbSnapshotState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot#db_instance_identifier-1">DbSnapshot#db_instance_identifier</a>.
        /// </summary>
        [<CustomOperation "db_instance_identifier">]
        member _.DbInstanceIdentifier(state: DbSnapshotState<Missing, 'DbSnapshotIdentifier>, value: string) : DbSnapshotState<Present, 'DbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.DbInstanceIdentifier <- value)
            ({ assignments = state.assignments } : DbSnapshotState<Present, 'DbSnapshotIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot#db_snapshot_identifier-1">DbSnapshot#db_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "db_snapshot_identifier">]
        member _.DbSnapshotIdentifier(state: DbSnapshotState<'DbInstanceIdentifier, Missing>, value: string) : DbSnapshotState<'DbInstanceIdentifier, Present> =
            state.assignments.Add(fun config -> config.DbSnapshotIdentifier <- value)
            ({ assignments = state.assignments } : DbSnapshotState<'DbInstanceIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot#id-1">DbSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier>, value: string) : DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot#shared_accounts-1">DbSnapshot#shared_accounts</a>.
        /// </summary>
        [<CustomOperation "shared_accounts">]
        member _.SharedAccounts(state: DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier>, value: seq<string>) : DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.SharedAccounts <- (value |> Seq.toArray))
            state : DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot#tags-1">DbSnapshot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier>, value: seq<string * string>) : DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot#tags_all-1">DbSnapshot#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier>, value: seq<string * string>) : DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot#timeouts-1">DbSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier>, value: aws.DbSnapshot.DbSnapshotTimeouts) : DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DbSnapshotState<'DbInstanceIdentifier, 'DbSnapshotIdentifier>

        member _.Run(state: DbSnapshotState<Present, Present>) : aws.DbSnapshot.DbSnapshot =
            let config = aws.DbSnapshot.DbSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.DbSnapshot.DbSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbSnapshot: missing required arguments. Must call: db_instance_identifier, db_snapshot_identifier.", 9999, IsError = true)>]
        member _.Run(_: DbSnapshotState<_, _>) : aws.DbSnapshot.DbSnapshot =
            Unchecked.defaultof<aws.DbSnapshot.DbSnapshot>
