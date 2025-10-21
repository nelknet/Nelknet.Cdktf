namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightRefreshScheduleState<'DataSetId, 'ScheduleId> = { assignments: ResizeArray<aws.QuicksightRefreshSchedule.QuicksightRefreshScheduleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule">aws_quicksight_refresh_schedule</a>.
    /// </summary>
    type QuicksightRefreshScheduleBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightRefreshScheduleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightRefreshScheduleState<Missing, Missing>)

        member _.Zero(()) : QuicksightRefreshScheduleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightRefreshScheduleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#data_set_id-1">QuicksightRefreshSchedule#data_set_id</a>.
        /// </summary>
        [<CustomOperation "data_set_id">]
        member _.DataSetId(state: QuicksightRefreshScheduleState<Missing, 'ScheduleId>, value: string) : QuicksightRefreshScheduleState<Present, 'ScheduleId> =
            state.assignments.Add(fun config -> config.DataSetId <- value)
            ({ assignments = state.assignments } : QuicksightRefreshScheduleState<Present, 'ScheduleId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#schedule_id-1">QuicksightRefreshSchedule#schedule_id</a>.
        /// </summary>
        [<CustomOperation "schedule_id">]
        member _.ScheduleId(state: QuicksightRefreshScheduleState<'DataSetId, Missing>, value: string) : QuicksightRefreshScheduleState<'DataSetId, Present> =
            state.assignments.Add(fun config -> config.ScheduleId <- value)
            ({ assignments = state.assignments } : QuicksightRefreshScheduleState<'DataSetId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#aws_account_id-1">QuicksightRefreshSchedule#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightRefreshScheduleState<'DataSetId, 'ScheduleId>, value: string) : QuicksightRefreshScheduleState<'DataSetId, 'ScheduleId> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightRefreshScheduleState<'DataSetId, 'ScheduleId>

        /// <summary>
        /// schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#schedule-1">QuicksightRefreshSchedule#schedule</a> Accepts: aws.IResolvable | aws.QuicksightRefreshSchedule.QuicksightRefreshScheduleSchedule[]
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: QuicksightRefreshScheduleState<'DataSetId, 'ScheduleId>, value: HashiCorp.Cdktf.IResolvable) : QuicksightRefreshScheduleState<'DataSetId, 'ScheduleId> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            state : QuicksightRefreshScheduleState<'DataSetId, 'ScheduleId>

        member _.Run(state: QuicksightRefreshScheduleState<Present, Present>) : aws.QuicksightRefreshSchedule.QuicksightRefreshSchedule =
            let config = aws.QuicksightRefreshSchedule.QuicksightRefreshScheduleConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightRefreshSchedule.QuicksightRefreshSchedule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightRefreshSchedule: missing required arguments. Must call: data_set_id, schedule_id.", 9999, IsError = true)>]
        member _.Run(_: QuicksightRefreshScheduleState<_, _>) : aws.QuicksightRefreshSchedule.QuicksightRefreshSchedule =
            Unchecked.defaultof<aws.QuicksightRefreshSchedule.QuicksightRefreshSchedule>
