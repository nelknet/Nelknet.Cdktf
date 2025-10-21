namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDbClusterSnapshotState = { assignments: ResizeArray<aws.DataAwsDbClusterSnapshot.DataAwsDbClusterSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_cluster_snapshot">aws_db_cluster_snapshot</a>.
    /// </summary>
    type DataAwsDbClusterSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDbClusterSnapshotState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsDbClusterSnapshotState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_cluster_snapshot#db_cluster_identifier-1">DataAwsDbClusterSnapshot#db_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "db_cluster_identifier">]
        member _.DbClusterIdentifier(state: DataAwsDbClusterSnapshotState, value: string) : DataAwsDbClusterSnapshotState =
            state.assignments.Add(fun config -> config.DbClusterIdentifier <- value)
            state : DataAwsDbClusterSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_cluster_snapshot#db_cluster_snapshot_identifier-1">DataAwsDbClusterSnapshot#db_cluster_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "db_cluster_snapshot_identifier">]
        member _.DbClusterSnapshotIdentifier(state: DataAwsDbClusterSnapshotState, value: string) : DataAwsDbClusterSnapshotState =
            state.assignments.Add(fun config -> config.DbClusterSnapshotIdentifier <- value)
            state : DataAwsDbClusterSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_cluster_snapshot#id-1">DataAwsDbClusterSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDbClusterSnapshotState, value: string) : DataAwsDbClusterSnapshotState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDbClusterSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_cluster_snapshot#include_public-1">DataAwsDbClusterSnapshot#include_public</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_public">]
        member _.IncludePublic(state: DataAwsDbClusterSnapshotState, value: bool) : DataAwsDbClusterSnapshotState =
            state.assignments.Add(fun config -> config.IncludePublic <- value)
            state : DataAwsDbClusterSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_cluster_snapshot#include_public-1">DataAwsDbClusterSnapshot#include_public</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_public">]
        member _.IncludePublic(state: DataAwsDbClusterSnapshotState, value: HashiCorp.Cdktf.IResolvable) : DataAwsDbClusterSnapshotState =
            state.assignments.Add(fun config -> config.IncludePublic <- value)
            state : DataAwsDbClusterSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_cluster_snapshot#include_shared-1">DataAwsDbClusterSnapshot#include_shared</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_shared">]
        member _.IncludeShared(state: DataAwsDbClusterSnapshotState, value: bool) : DataAwsDbClusterSnapshotState =
            state.assignments.Add(fun config -> config.IncludeShared <- value)
            state : DataAwsDbClusterSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_cluster_snapshot#include_shared-1">DataAwsDbClusterSnapshot#include_shared</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_shared">]
        member _.IncludeShared(state: DataAwsDbClusterSnapshotState, value: HashiCorp.Cdktf.IResolvable) : DataAwsDbClusterSnapshotState =
            state.assignments.Add(fun config -> config.IncludeShared <- value)
            state : DataAwsDbClusterSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_cluster_snapshot#most_recent-1">DataAwsDbClusterSnapshot#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsDbClusterSnapshotState, value: bool) : DataAwsDbClusterSnapshotState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsDbClusterSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_cluster_snapshot#most_recent-1">DataAwsDbClusterSnapshot#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsDbClusterSnapshotState, value: HashiCorp.Cdktf.IResolvable) : DataAwsDbClusterSnapshotState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsDbClusterSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_cluster_snapshot#snapshot_type-1">DataAwsDbClusterSnapshot#snapshot_type</a>.
        /// </summary>
        [<CustomOperation "snapshot_type">]
        member _.SnapshotType(state: DataAwsDbClusterSnapshotState, value: string) : DataAwsDbClusterSnapshotState =
            state.assignments.Add(fun config -> config.SnapshotType <- value)
            state : DataAwsDbClusterSnapshotState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_cluster_snapshot#tags-1">DataAwsDbClusterSnapshot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDbClusterSnapshotState, value: seq<string * string>) : DataAwsDbClusterSnapshotState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsDbClusterSnapshotState

        member _.Run(state: DataAwsDbClusterSnapshotState) : aws.DataAwsDbClusterSnapshot.DataAwsDbClusterSnapshot =
            let config = aws.DataAwsDbClusterSnapshot.DataAwsDbClusterSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDbClusterSnapshot.DataAwsDbClusterSnapshot(StackContext.get (), logicalId, config)
