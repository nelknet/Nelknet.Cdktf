namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName> = { assignments: ResizeArray<aws.AutoscalingSchedule.AutoscalingScheduleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_schedule">aws_autoscaling_schedule</a>.
    /// </summary>
    type AutoscalingScheduleBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutoscalingScheduleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingScheduleState<Missing, Missing>)

        member _.Zero(()) : AutoscalingScheduleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingScheduleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_schedule#autoscaling_group_name-1">AutoscalingSchedule#autoscaling_group_name</a>.
        /// </summary>
        [<CustomOperation "autoscaling_group_name">]
        member _.AutoscalingGroupName(state: AutoscalingScheduleState<Missing, 'ScheduledActionName>, value: string) : AutoscalingScheduleState<Present, 'ScheduledActionName> =
            state.assignments.Add(fun config -> config.AutoscalingGroupName <- value)
            ({ assignments = state.assignments } : AutoscalingScheduleState<Present, 'ScheduledActionName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_schedule#scheduled_action_name-1">AutoscalingSchedule#scheduled_action_name</a>.
        /// </summary>
        [<CustomOperation "scheduled_action_name">]
        member _.ScheduledActionName(state: AutoscalingScheduleState<'AutoscalingGroupName, Missing>, value: string) : AutoscalingScheduleState<'AutoscalingGroupName, Present> =
            state.assignments.Add(fun config -> config.ScheduledActionName <- value)
            ({ assignments = state.assignments } : AutoscalingScheduleState<'AutoscalingGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_schedule#desired_capacity-1">AutoscalingSchedule#desired_capacity</a>.
        /// </summary>
        [<CustomOperation "desired_capacity">]
        member _.DesiredCapacity(state: AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>, value: double) : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName> =
            state.assignments.Add(fun config -> config.DesiredCapacity <- value)
            state : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_schedule#end_time-1">AutoscalingSchedule#end_time</a>.
        /// </summary>
        [<CustomOperation "end_time">]
        member _.EndTime(state: AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>, value: string) : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName> =
            state.assignments.Add(fun config -> config.EndTime <- value)
            state : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_schedule#id-1">AutoscalingSchedule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>, value: string) : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_schedule#max_size-1">AutoscalingSchedule#max_size</a>.
        /// </summary>
        [<CustomOperation "max_size">]
        member _.MaxSize(state: AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>, value: double) : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName> =
            state.assignments.Add(fun config -> config.MaxSize <- value)
            state : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_schedule#min_size-1">AutoscalingSchedule#min_size</a>.
        /// </summary>
        [<CustomOperation "min_size">]
        member _.MinSize(state: AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>, value: double) : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName> =
            state.assignments.Add(fun config -> config.MinSize <- value)
            state : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_schedule#recurrence-1">AutoscalingSchedule#recurrence</a>.
        /// </summary>
        [<CustomOperation "recurrence">]
        member _.Recurrence(state: AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>, value: string) : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName> =
            state.assignments.Add(fun config -> config.Recurrence <- value)
            state : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_schedule#start_time-1">AutoscalingSchedule#start_time</a>.
        /// </summary>
        [<CustomOperation "start_time">]
        member _.StartTime(state: AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>, value: string) : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName> =
            state.assignments.Add(fun config -> config.StartTime <- value)
            state : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_schedule#time_zone-1">AutoscalingSchedule#time_zone</a>.
        /// </summary>
        [<CustomOperation "time_zone">]
        member _.TimeZone(state: AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>, value: string) : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName> =
            state.assignments.Add(fun config -> config.TimeZone <- value)
            state : AutoscalingScheduleState<'AutoscalingGroupName, 'ScheduledActionName>

        member _.Run(state: AutoscalingScheduleState<Present, Present>) : aws.AutoscalingSchedule.AutoscalingSchedule =
            let config = aws.AutoscalingSchedule.AutoscalingScheduleConfig()
            for setter in state.assignments do
                setter config
            aws.AutoscalingSchedule.AutoscalingSchedule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.autoscalingSchedule: missing required arguments. Must call: autoscaling_group_name, scheduled_action_name.", 9999, IsError = true)>]
        member _.Run(_: AutoscalingScheduleState<_, _>) : aws.AutoscalingSchedule.AutoscalingSchedule =
            Unchecked.defaultof<aws.AutoscalingSchedule.AutoscalingSchedule>
