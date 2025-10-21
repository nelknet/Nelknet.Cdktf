namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsJobScheduleState<'StartMode, 'StreamAnalyticsJobId> = { assignments: ResizeArray<azurerm.StreamAnalyticsJobSchedule.StreamAnalyticsJobScheduleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job_schedule">azurerm_stream_analytics_job_schedule</a>.
    /// </summary>
    type StreamAnalyticsJobScheduleBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsJobScheduleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsJobScheduleState<Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsJobScheduleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsJobScheduleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job_schedule#start_mode-1">StreamAnalyticsJobSchedule#start_mode</a>.
        /// </summary>
        [<CustomOperation "start_mode">]
        member _.StartMode(state: StreamAnalyticsJobScheduleState<Missing, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsJobScheduleState<Present, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.StartMode <- value)
            ({ assignments = state.assignments } : StreamAnalyticsJobScheduleState<Present, 'StreamAnalyticsJobId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job_schedule#stream_analytics_job_id-1">StreamAnalyticsJobSchedule#stream_analytics_job_id</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_id">]
        member _.StreamAnalyticsJobId(state: StreamAnalyticsJobScheduleState<'StartMode, Missing>, value: string) : StreamAnalyticsJobScheduleState<'StartMode, Present> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobId <- value)
            ({ assignments = state.assignments } : StreamAnalyticsJobScheduleState<'StartMode, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job_schedule#id-1">StreamAnalyticsJobSchedule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsJobScheduleState<'StartMode, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsJobScheduleState<'StartMode, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsJobScheduleState<'StartMode, 'StreamAnalyticsJobId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job_schedule#start_time-1">StreamAnalyticsJobSchedule#start_time</a>.
        /// </summary>
        [<CustomOperation "start_time">]
        member _.StartTime(state: StreamAnalyticsJobScheduleState<'StartMode, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsJobScheduleState<'StartMode, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.StartTime <- value)
            state : StreamAnalyticsJobScheduleState<'StartMode, 'StreamAnalyticsJobId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job_schedule#timeouts-1">StreamAnalyticsJobSchedule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsJobScheduleState<'StartMode, 'StreamAnalyticsJobId>, value: azurerm.StreamAnalyticsJobSchedule.StreamAnalyticsJobScheduleTimeouts) : StreamAnalyticsJobScheduleState<'StartMode, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsJobScheduleState<'StartMode, 'StreamAnalyticsJobId>

        member _.Run(state: StreamAnalyticsJobScheduleState<Present, Present>) : azurerm.StreamAnalyticsJobSchedule.StreamAnalyticsJobSchedule =
            let config = azurerm.StreamAnalyticsJobSchedule.StreamAnalyticsJobScheduleConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsJobSchedule.StreamAnalyticsJobSchedule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsJobSchedule: missing required arguments. Must call: start_mode, stream_analytics_job_id.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsJobScheduleState<_, _>) : azurerm.StreamAnalyticsJobSchedule.StreamAnalyticsJobSchedule =
            Unchecked.defaultof<azurerm.StreamAnalyticsJobSchedule.StreamAnalyticsJobSchedule>
