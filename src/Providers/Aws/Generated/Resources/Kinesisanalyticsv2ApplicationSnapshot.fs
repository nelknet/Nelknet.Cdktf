namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Kinesisanalyticsv2ApplicationSnapshotState<'ApplicationName, 'SnapshotName> = { assignments: ResizeArray<aws.Kinesisanalyticsv2ApplicationSnapshot.Kinesisanalyticsv2ApplicationSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application_snapshot">aws_kinesisanalyticsv2_application_snapshot</a>.
    /// </summary>
    type Kinesisanalyticsv2ApplicationSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : Kinesisanalyticsv2ApplicationSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Kinesisanalyticsv2ApplicationSnapshotState<Missing, Missing>)

        member _.Zero(()) : Kinesisanalyticsv2ApplicationSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Kinesisanalyticsv2ApplicationSnapshotState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application_snapshot#application_name-1">Kinesisanalyticsv2ApplicationSnapshot#application_name</a>.
        /// </summary>
        [<CustomOperation "application_name">]
        member _.ApplicationName(state: Kinesisanalyticsv2ApplicationSnapshotState<Missing, 'SnapshotName>, value: string) : Kinesisanalyticsv2ApplicationSnapshotState<Present, 'SnapshotName> =
            state.assignments.Add(fun config -> config.ApplicationName <- value)
            ({ assignments = state.assignments } : Kinesisanalyticsv2ApplicationSnapshotState<Present, 'SnapshotName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application_snapshot#snapshot_name-1">Kinesisanalyticsv2ApplicationSnapshot#snapshot_name</a>.
        /// </summary>
        [<CustomOperation "snapshot_name">]
        member _.SnapshotName(state: Kinesisanalyticsv2ApplicationSnapshotState<'ApplicationName, Missing>, value: string) : Kinesisanalyticsv2ApplicationSnapshotState<'ApplicationName, Present> =
            state.assignments.Add(fun config -> config.SnapshotName <- value)
            ({ assignments = state.assignments } : Kinesisanalyticsv2ApplicationSnapshotState<'ApplicationName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application_snapshot#id-1">Kinesisanalyticsv2ApplicationSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Kinesisanalyticsv2ApplicationSnapshotState<'ApplicationName, 'SnapshotName>, value: string) : Kinesisanalyticsv2ApplicationSnapshotState<'ApplicationName, 'SnapshotName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Kinesisanalyticsv2ApplicationSnapshotState<'ApplicationName, 'SnapshotName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application_snapshot#timeouts-1">Kinesisanalyticsv2ApplicationSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Kinesisanalyticsv2ApplicationSnapshotState<'ApplicationName, 'SnapshotName>, value: aws.Kinesisanalyticsv2ApplicationSnapshot.Kinesisanalyticsv2ApplicationSnapshotTimeouts) : Kinesisanalyticsv2ApplicationSnapshotState<'ApplicationName, 'SnapshotName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Kinesisanalyticsv2ApplicationSnapshotState<'ApplicationName, 'SnapshotName>

        member _.Run(state: Kinesisanalyticsv2ApplicationSnapshotState<Present, Present>) : aws.Kinesisanalyticsv2ApplicationSnapshot.Kinesisanalyticsv2ApplicationSnapshot =
            let config = aws.Kinesisanalyticsv2ApplicationSnapshot.Kinesisanalyticsv2ApplicationSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.Kinesisanalyticsv2ApplicationSnapshot.Kinesisanalyticsv2ApplicationSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kinesisanalyticsv2ApplicationSnapshot: missing required arguments. Must call: application_name, snapshot_name.", 9999, IsError = true)>]
        member _.Run(_: Kinesisanalyticsv2ApplicationSnapshotState<_, _>) : aws.Kinesisanalyticsv2ApplicationSnapshot.Kinesisanalyticsv2ApplicationSnapshot =
            Unchecked.defaultof<aws.Kinesisanalyticsv2ApplicationSnapshot.Kinesisanalyticsv2ApplicationSnapshot>
