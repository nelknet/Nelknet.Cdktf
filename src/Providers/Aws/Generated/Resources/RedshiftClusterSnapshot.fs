namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftClusterSnapshotState<'ClusterIdentifier, 'SnapshotIdentifier> = { assignments: ResizeArray<aws.RedshiftClusterSnapshot.RedshiftClusterSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster_snapshot">aws_redshift_cluster_snapshot</a>.
    /// </summary>
    type RedshiftClusterSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftClusterSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftClusterSnapshotState<Missing, Missing>)

        member _.Zero(()) : RedshiftClusterSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftClusterSnapshotState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster_snapshot#cluster_identifier-1">RedshiftClusterSnapshot#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RedshiftClusterSnapshotState<Missing, 'SnapshotIdentifier>, value: string) : RedshiftClusterSnapshotState<Present, 'SnapshotIdentifier> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftClusterSnapshotState<Present, 'SnapshotIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster_snapshot#snapshot_identifier-1">RedshiftClusterSnapshot#snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "snapshot_identifier">]
        member _.SnapshotIdentifier(state: RedshiftClusterSnapshotState<'ClusterIdentifier, Missing>, value: string) : RedshiftClusterSnapshotState<'ClusterIdentifier, Present> =
            state.assignments.Add(fun config -> config.SnapshotIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftClusterSnapshotState<'ClusterIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster_snapshot#id-1">RedshiftClusterSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftClusterSnapshotState<'ClusterIdentifier, 'SnapshotIdentifier>, value: string) : RedshiftClusterSnapshotState<'ClusterIdentifier, 'SnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftClusterSnapshotState<'ClusterIdentifier, 'SnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster_snapshot#manual_snapshot_retention_period-1">RedshiftClusterSnapshot#manual_snapshot_retention_period</a>.
        /// </summary>
        [<CustomOperation "manual_snapshot_retention_period">]
        member _.ManualSnapshotRetentionPeriod(state: RedshiftClusterSnapshotState<'ClusterIdentifier, 'SnapshotIdentifier>, value: double) : RedshiftClusterSnapshotState<'ClusterIdentifier, 'SnapshotIdentifier> =
            state.assignments.Add(fun config -> config.ManualSnapshotRetentionPeriod <- value)
            state : RedshiftClusterSnapshotState<'ClusterIdentifier, 'SnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster_snapshot#tags-1">RedshiftClusterSnapshot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedshiftClusterSnapshotState<'ClusterIdentifier, 'SnapshotIdentifier>, value: seq<string * string>) : RedshiftClusterSnapshotState<'ClusterIdentifier, 'SnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedshiftClusterSnapshotState<'ClusterIdentifier, 'SnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_cluster_snapshot#tags_all-1">RedshiftClusterSnapshot#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RedshiftClusterSnapshotState<'ClusterIdentifier, 'SnapshotIdentifier>, value: seq<string * string>) : RedshiftClusterSnapshotState<'ClusterIdentifier, 'SnapshotIdentifier> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RedshiftClusterSnapshotState<'ClusterIdentifier, 'SnapshotIdentifier>

        member _.Run(state: RedshiftClusterSnapshotState<Present, Present>) : aws.RedshiftClusterSnapshot.RedshiftClusterSnapshot =
            let config = aws.RedshiftClusterSnapshot.RedshiftClusterSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftClusterSnapshot.RedshiftClusterSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftClusterSnapshot: missing required arguments. Must call: cluster_identifier, snapshot_identifier.", 9999, IsError = true)>]
        member _.Run(_: RedshiftClusterSnapshotState<_, _>) : aws.RedshiftClusterSnapshot.RedshiftClusterSnapshot =
            Unchecked.defaultof<aws.RedshiftClusterSnapshot.RedshiftClusterSnapshot>
