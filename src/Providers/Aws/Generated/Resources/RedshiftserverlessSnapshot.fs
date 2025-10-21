namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftserverlessSnapshotState<'NamespaceName, 'SnapshotName> = { assignments: ResizeArray<aws.RedshiftserverlessSnapshot.RedshiftserverlessSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_snapshot">aws_redshiftserverless_snapshot</a>.
    /// </summary>
    type RedshiftserverlessSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftserverlessSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessSnapshotState<Missing, Missing>)

        member _.Zero(()) : RedshiftserverlessSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessSnapshotState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_snapshot#namespace_name-1">RedshiftserverlessSnapshot#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: RedshiftserverlessSnapshotState<Missing, 'SnapshotName>, value: string) : RedshiftserverlessSnapshotState<Present, 'SnapshotName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : RedshiftserverlessSnapshotState<Present, 'SnapshotName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_snapshot#snapshot_name-1">RedshiftserverlessSnapshot#snapshot_name</a>.
        /// </summary>
        [<CustomOperation "snapshot_name">]
        member _.SnapshotName(state: RedshiftserverlessSnapshotState<'NamespaceName, Missing>, value: string) : RedshiftserverlessSnapshotState<'NamespaceName, Present> =
            state.assignments.Add(fun config -> config.SnapshotName <- value)
            ({ assignments = state.assignments } : RedshiftserverlessSnapshotState<'NamespaceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_snapshot#id-1">RedshiftserverlessSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftserverlessSnapshotState<'NamespaceName, 'SnapshotName>, value: string) : RedshiftserverlessSnapshotState<'NamespaceName, 'SnapshotName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftserverlessSnapshotState<'NamespaceName, 'SnapshotName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_snapshot#retention_period-1">RedshiftserverlessSnapshot#retention_period</a>.
        /// </summary>
        [<CustomOperation "retention_period">]
        member _.RetentionPeriod(state: RedshiftserverlessSnapshotState<'NamespaceName, 'SnapshotName>, value: double) : RedshiftserverlessSnapshotState<'NamespaceName, 'SnapshotName> =
            state.assignments.Add(fun config -> config.RetentionPeriod <- value)
            state : RedshiftserverlessSnapshotState<'NamespaceName, 'SnapshotName>

        member _.Run(state: RedshiftserverlessSnapshotState<Present, Present>) : aws.RedshiftserverlessSnapshot.RedshiftserverlessSnapshot =
            let config = aws.RedshiftserverlessSnapshot.RedshiftserverlessSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftserverlessSnapshot.RedshiftserverlessSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftserverlessSnapshot: missing required arguments. Must call: namespace_name, snapshot_name.", 9999, IsError = true)>]
        member _.Run(_: RedshiftserverlessSnapshotState<_, _>) : aws.RedshiftserverlessSnapshot.RedshiftserverlessSnapshot =
            Unchecked.defaultof<aws.RedshiftserverlessSnapshot.RedshiftserverlessSnapshot>
