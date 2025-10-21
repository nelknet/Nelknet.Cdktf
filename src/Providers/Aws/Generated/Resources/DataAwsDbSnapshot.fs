namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDbSnapshotState = { assignments: ResizeArray<aws.DataAwsDbSnapshot.DataAwsDbSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_snapshot">aws_db_snapshot</a>.
    /// </summary>
    type DataAwsDbSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDbSnapshotState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsDbSnapshotState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_snapshot#db_instance_identifier-1">DataAwsDbSnapshot#db_instance_identifier</a>.
        /// </summary>
        [<CustomOperation "db_instance_identifier">]
        member _.DbInstanceIdentifier(state: DataAwsDbSnapshotState, value: string) : DataAwsDbSnapshotState =
            state.assignments.Add(fun config -> config.DbInstanceIdentifier <- value)
            state : DataAwsDbSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_snapshot#db_snapshot_identifier-1">DataAwsDbSnapshot#db_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "db_snapshot_identifier">]
        member _.DbSnapshotIdentifier(state: DataAwsDbSnapshotState, value: string) : DataAwsDbSnapshotState =
            state.assignments.Add(fun config -> config.DbSnapshotIdentifier <- value)
            state : DataAwsDbSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_snapshot#id-1">DataAwsDbSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDbSnapshotState, value: string) : DataAwsDbSnapshotState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDbSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_snapshot#include_public-1">DataAwsDbSnapshot#include_public</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_public">]
        member _.IncludePublic(state: DataAwsDbSnapshotState, value: bool) : DataAwsDbSnapshotState =
            state.assignments.Add(fun config -> config.IncludePublic <- value)
            state : DataAwsDbSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_snapshot#include_public-1">DataAwsDbSnapshot#include_public</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_public">]
        member _.IncludePublic(state: DataAwsDbSnapshotState, value: HashiCorp.Cdktf.IResolvable) : DataAwsDbSnapshotState =
            state.assignments.Add(fun config -> config.IncludePublic <- value)
            state : DataAwsDbSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_snapshot#include_shared-1">DataAwsDbSnapshot#include_shared</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_shared">]
        member _.IncludeShared(state: DataAwsDbSnapshotState, value: bool) : DataAwsDbSnapshotState =
            state.assignments.Add(fun config -> config.IncludeShared <- value)
            state : DataAwsDbSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_snapshot#include_shared-1">DataAwsDbSnapshot#include_shared</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_shared">]
        member _.IncludeShared(state: DataAwsDbSnapshotState, value: HashiCorp.Cdktf.IResolvable) : DataAwsDbSnapshotState =
            state.assignments.Add(fun config -> config.IncludeShared <- value)
            state : DataAwsDbSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_snapshot#most_recent-1">DataAwsDbSnapshot#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsDbSnapshotState, value: bool) : DataAwsDbSnapshotState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsDbSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_snapshot#most_recent-1">DataAwsDbSnapshot#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsDbSnapshotState, value: HashiCorp.Cdktf.IResolvable) : DataAwsDbSnapshotState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsDbSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_snapshot#snapshot_type-1">DataAwsDbSnapshot#snapshot_type</a>.
        /// </summary>
        [<CustomOperation "snapshot_type">]
        member _.SnapshotType(state: DataAwsDbSnapshotState, value: string) : DataAwsDbSnapshotState =
            state.assignments.Add(fun config -> config.SnapshotType <- value)
            state : DataAwsDbSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_snapshot#tags-1">DataAwsDbSnapshot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDbSnapshotState, value: seq<string * string>) : DataAwsDbSnapshotState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsDbSnapshotState

        member _.Run(state: DataAwsDbSnapshotState) : aws.DataAwsDbSnapshot.DataAwsDbSnapshot =
            let config = aws.DataAwsDbSnapshot.DataAwsDbSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDbSnapshot.DataAwsDbSnapshot(StackContext.get (), logicalId, config)
