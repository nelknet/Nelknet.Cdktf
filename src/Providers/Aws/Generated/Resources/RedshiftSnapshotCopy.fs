namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftSnapshotCopyState<'ClusterIdentifier, 'DestinationRegion> = { assignments: ResizeArray<aws.RedshiftSnapshotCopy.RedshiftSnapshotCopyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_copy">aws_redshift_snapshot_copy</a>.
    /// </summary>
    type RedshiftSnapshotCopyBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftSnapshotCopyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftSnapshotCopyState<Missing, Missing>)

        member _.Zero(()) : RedshiftSnapshotCopyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftSnapshotCopyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_copy#cluster_identifier-1">RedshiftSnapshotCopy#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RedshiftSnapshotCopyState<Missing, 'DestinationRegion>, value: string) : RedshiftSnapshotCopyState<Present, 'DestinationRegion> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftSnapshotCopyState<Present, 'DestinationRegion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_copy#destination_region-1">RedshiftSnapshotCopy#destination_region</a>.
        /// </summary>
        [<CustomOperation "destination_region">]
        member _.DestinationRegion(state: RedshiftSnapshotCopyState<'ClusterIdentifier, Missing>, value: string) : RedshiftSnapshotCopyState<'ClusterIdentifier, Present> =
            state.assignments.Add(fun config -> config.DestinationRegion <- value)
            ({ assignments = state.assignments } : RedshiftSnapshotCopyState<'ClusterIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_copy#manual_snapshot_retention_period-1">RedshiftSnapshotCopy#manual_snapshot_retention_period</a>.
        /// </summary>
        [<CustomOperation "manual_snapshot_retention_period">]
        member _.ManualSnapshotRetentionPeriod(state: RedshiftSnapshotCopyState<'ClusterIdentifier, 'DestinationRegion>, value: double) : RedshiftSnapshotCopyState<'ClusterIdentifier, 'DestinationRegion> =
            state.assignments.Add(fun config -> config.ManualSnapshotRetentionPeriod <- value)
            state : RedshiftSnapshotCopyState<'ClusterIdentifier, 'DestinationRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_copy#retention_period-1">RedshiftSnapshotCopy#retention_period</a>.
        /// </summary>
        [<CustomOperation "retention_period">]
        member _.RetentionPeriod(state: RedshiftSnapshotCopyState<'ClusterIdentifier, 'DestinationRegion>, value: double) : RedshiftSnapshotCopyState<'ClusterIdentifier, 'DestinationRegion> =
            state.assignments.Add(fun config -> config.RetentionPeriod <- value)
            state : RedshiftSnapshotCopyState<'ClusterIdentifier, 'DestinationRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_copy#snapshot_copy_grant_name-1">RedshiftSnapshotCopy#snapshot_copy_grant_name</a>.
        /// </summary>
        [<CustomOperation "snapshot_copy_grant_name">]
        member _.SnapshotCopyGrantName(state: RedshiftSnapshotCopyState<'ClusterIdentifier, 'DestinationRegion>, value: string) : RedshiftSnapshotCopyState<'ClusterIdentifier, 'DestinationRegion> =
            state.assignments.Add(fun config -> config.SnapshotCopyGrantName <- value)
            state : RedshiftSnapshotCopyState<'ClusterIdentifier, 'DestinationRegion>

        member _.Run(state: RedshiftSnapshotCopyState<Present, Present>) : aws.RedshiftSnapshotCopy.RedshiftSnapshotCopy =
            let config = aws.RedshiftSnapshotCopy.RedshiftSnapshotCopyConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftSnapshotCopy.RedshiftSnapshotCopy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftSnapshotCopy: missing required arguments. Must call: cluster_identifier, destination_region.", 9999, IsError = true)>]
        member _.Run(_: RedshiftSnapshotCopyState<_, _>) : aws.RedshiftSnapshotCopy.RedshiftSnapshotCopy =
            Unchecked.defaultof<aws.RedshiftSnapshotCopy.RedshiftSnapshotCopy>
