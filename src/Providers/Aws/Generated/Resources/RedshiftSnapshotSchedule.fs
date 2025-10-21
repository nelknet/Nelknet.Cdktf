namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftSnapshotScheduleState<'Definitions> = { assignments: ResizeArray<aws.RedshiftSnapshotSchedule.RedshiftSnapshotScheduleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule">aws_redshift_snapshot_schedule</a>.
    /// </summary>
    type RedshiftSnapshotScheduleBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftSnapshotScheduleState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftSnapshotScheduleState<Missing>)

        member _.Zero(()) : RedshiftSnapshotScheduleState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftSnapshotScheduleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule#definitions-1">RedshiftSnapshotSchedule#definitions</a>.
        /// </summary>
        [<CustomOperation "definitions">]
        member _.Definitions(state: RedshiftSnapshotScheduleState<Missing>, value: seq<string>) : RedshiftSnapshotScheduleState<Present> =
            state.assignments.Add(fun config -> config.Definitions <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : RedshiftSnapshotScheduleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule#description-1">RedshiftSnapshotSchedule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: RedshiftSnapshotScheduleState<'Definitions>, value: string) : RedshiftSnapshotScheduleState<'Definitions> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : RedshiftSnapshotScheduleState<'Definitions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule#force_destroy-1">RedshiftSnapshotSchedule#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: RedshiftSnapshotScheduleState<'Definitions>, value: bool) : RedshiftSnapshotScheduleState<'Definitions> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : RedshiftSnapshotScheduleState<'Definitions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule#force_destroy-1">RedshiftSnapshotSchedule#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: RedshiftSnapshotScheduleState<'Definitions>, value: HashiCorp.Cdktf.IResolvable) : RedshiftSnapshotScheduleState<'Definitions> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : RedshiftSnapshotScheduleState<'Definitions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule#id-1">RedshiftSnapshotSchedule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftSnapshotScheduleState<'Definitions>, value: string) : RedshiftSnapshotScheduleState<'Definitions> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftSnapshotScheduleState<'Definitions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule#identifier-1">RedshiftSnapshotSchedule#identifier</a>.
        /// </summary>
        [<CustomOperation "identifier">]
        member _.Identifier(state: RedshiftSnapshotScheduleState<'Definitions>, value: string) : RedshiftSnapshotScheduleState<'Definitions> =
            state.assignments.Add(fun config -> config.Identifier <- value)
            state : RedshiftSnapshotScheduleState<'Definitions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule#identifier_prefix-1">RedshiftSnapshotSchedule#identifier_prefix</a>.
        /// </summary>
        [<CustomOperation "identifier_prefix">]
        member _.IdentifierPrefix(state: RedshiftSnapshotScheduleState<'Definitions>, value: string) : RedshiftSnapshotScheduleState<'Definitions> =
            state.assignments.Add(fun config -> config.IdentifierPrefix <- value)
            state : RedshiftSnapshotScheduleState<'Definitions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule#tags-1">RedshiftSnapshotSchedule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedshiftSnapshotScheduleState<'Definitions>, value: seq<string * string>) : RedshiftSnapshotScheduleState<'Definitions> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedshiftSnapshotScheduleState<'Definitions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_schedule#tags_all-1">RedshiftSnapshotSchedule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RedshiftSnapshotScheduleState<'Definitions>, value: seq<string * string>) : RedshiftSnapshotScheduleState<'Definitions> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RedshiftSnapshotScheduleState<'Definitions>

        member _.Run(state: RedshiftSnapshotScheduleState<Present>) : aws.RedshiftSnapshotSchedule.RedshiftSnapshotSchedule =
            let config = aws.RedshiftSnapshotSchedule.RedshiftSnapshotScheduleConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftSnapshotSchedule.RedshiftSnapshotSchedule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftSnapshotSchedule: missing required arguments. Must call: definitions.", 9999, IsError = true)>]
        member _.Run(_: RedshiftSnapshotScheduleState<_>) : aws.RedshiftSnapshotSchedule.RedshiftSnapshotSchedule =
            Unchecked.defaultof<aws.RedshiftSnapshotSchedule.RedshiftSnapshotSchedule>
