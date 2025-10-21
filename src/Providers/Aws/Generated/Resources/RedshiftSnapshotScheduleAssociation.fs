namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftSnapshotScheduleAssociationState<'ClusterIdentifier, 'ScheduleIdentifier> = { assignments: ResizeArray<aws.RedshiftSnapshotScheduleAssociation.RedshiftSnapshotScheduleAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule_association">aws_redshift_snapshot_schedule_association</a>.
    /// </summary>
    type RedshiftSnapshotScheduleAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftSnapshotScheduleAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftSnapshotScheduleAssociationState<Missing, Missing>)

        member _.Zero(()) : RedshiftSnapshotScheduleAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftSnapshotScheduleAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule_association#cluster_identifier-1">RedshiftSnapshotScheduleAssociation#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RedshiftSnapshotScheduleAssociationState<Missing, 'ScheduleIdentifier>, value: string) : RedshiftSnapshotScheduleAssociationState<Present, 'ScheduleIdentifier> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftSnapshotScheduleAssociationState<Present, 'ScheduleIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule_association#schedule_identifier-1">RedshiftSnapshotScheduleAssociation#schedule_identifier</a>.
        /// </summary>
        [<CustomOperation "schedule_identifier">]
        member _.ScheduleIdentifier(state: RedshiftSnapshotScheduleAssociationState<'ClusterIdentifier, Missing>, value: string) : RedshiftSnapshotScheduleAssociationState<'ClusterIdentifier, Present> =
            state.assignments.Add(fun config -> config.ScheduleIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftSnapshotScheduleAssociationState<'ClusterIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule_association#id-1">RedshiftSnapshotScheduleAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftSnapshotScheduleAssociationState<'ClusterIdentifier, 'ScheduleIdentifier>, value: string) : RedshiftSnapshotScheduleAssociationState<'ClusterIdentifier, 'ScheduleIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftSnapshotScheduleAssociationState<'ClusterIdentifier, 'ScheduleIdentifier>

        member _.Run(state: RedshiftSnapshotScheduleAssociationState<Present, Present>) : aws.RedshiftSnapshotScheduleAssociation.RedshiftSnapshotScheduleAssociation =
            let config = aws.RedshiftSnapshotScheduleAssociation.RedshiftSnapshotScheduleAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftSnapshotScheduleAssociation.RedshiftSnapshotScheduleAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftSnapshotScheduleAssociation: missing required arguments. Must call: cluster_identifier, schedule_identifier.", 9999, IsError = true)>]
        member _.Run(_: RedshiftSnapshotScheduleAssociationState<_, _>) : aws.RedshiftSnapshotScheduleAssociation.RedshiftSnapshotScheduleAssociation =
            Unchecked.defaultof<aws.RedshiftSnapshotScheduleAssociation.RedshiftSnapshotScheduleAssociation>
