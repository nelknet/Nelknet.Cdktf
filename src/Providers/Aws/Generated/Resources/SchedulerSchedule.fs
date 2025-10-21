namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target> = { assignments: ResizeArray<aws.SchedulerSchedule.SchedulerScheduleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule">aws_scheduler_schedule</a>.
    /// </summary>
    type SchedulerScheduleBuilder(logicalId: string) =
        member _.Yield(_: unit) : SchedulerScheduleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SchedulerScheduleState<Missing, Missing, Missing>)

        member _.Zero(()) : SchedulerScheduleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SchedulerScheduleState<Missing, Missing, Missing>)

        /// <summary>
        /// flexible_time_window block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#flexible_time_window-1">SchedulerSchedule#flexible_time_window</a>
        /// </summary>
        [<CustomOperation "flexible_time_window">]
        member _.FlexibleTimeWindow(state: SchedulerScheduleState<Missing, 'ScheduleExpression, 'Target>, value: aws.SchedulerSchedule.SchedulerScheduleFlexibleTimeWindow) : SchedulerScheduleState<Present, 'ScheduleExpression, 'Target> =
            state.assignments.Add(fun config -> config.FlexibleTimeWindow <- value)
            ({ assignments = state.assignments } : SchedulerScheduleState<Present, 'ScheduleExpression, 'Target>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#schedule_expression-1">SchedulerSchedule#schedule_expression</a>.
        /// </summary>
        [<CustomOperation "schedule_expression">]
        member _.ScheduleExpression(state: SchedulerScheduleState<'FlexibleTimeWindow, Missing, 'Target>, value: string) : SchedulerScheduleState<'FlexibleTimeWindow, Present, 'Target> =
            state.assignments.Add(fun config -> config.ScheduleExpression <- value)
            ({ assignments = state.assignments } : SchedulerScheduleState<'FlexibleTimeWindow, Present, 'Target>)

        /// <summary>
        /// target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#target-1">SchedulerSchedule#target</a>
        /// </summary>
        [<CustomOperation "target">]
        member _.Target(state: SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, Missing>, value: aws.SchedulerSchedule.SchedulerScheduleTarget) : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, Present> =
            state.assignments.Add(fun config -> config.Target <- value)
            ({ assignments = state.assignments } : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#description-1">SchedulerSchedule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>, value: string) : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#end_date-1">SchedulerSchedule#end_date</a>.
        /// </summary>
        [<CustomOperation "end_date">]
        member _.EndDate(state: SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>, value: string) : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target> =
            state.assignments.Add(fun config -> config.EndDate <- value)
            state : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#group_name-1">SchedulerSchedule#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>, value: string) : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            state : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#id-1">SchedulerSchedule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>, value: string) : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#kms_key_arn-1">SchedulerSchedule#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>, value: string) : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#name-1">SchedulerSchedule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>, value: string) : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#name_prefix-1">SchedulerSchedule#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>, value: string) : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#schedule_expression_timezone-1">SchedulerSchedule#schedule_expression_timezone</a>.
        /// </summary>
        [<CustomOperation "schedule_expression_timezone">]
        member _.ScheduleExpressionTimezone(state: SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>, value: string) : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target> =
            state.assignments.Add(fun config -> config.ScheduleExpressionTimezone <- value)
            state : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#start_date-1">SchedulerSchedule#start_date</a>.
        /// </summary>
        [<CustomOperation "start_date">]
        member _.StartDate(state: SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>, value: string) : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target> =
            state.assignments.Add(fun config -> config.StartDate <- value)
            state : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#state-1">SchedulerSchedule#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>, value: string) : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target> =
            state.assignments.Add(fun config -> config.State <- value)
            state : SchedulerScheduleState<'FlexibleTimeWindow, 'ScheduleExpression, 'Target>

        member _.Run(state: SchedulerScheduleState<Present, Present, Present>) : aws.SchedulerSchedule.SchedulerSchedule =
            let config = aws.SchedulerSchedule.SchedulerScheduleConfig()
            for setter in state.assignments do
                setter config
            aws.SchedulerSchedule.SchedulerSchedule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.schedulerSchedule: missing required arguments. Must call: flexible_time_window, schedule_expression, target.", 9999, IsError = true)>]
        member _.Run(_: SchedulerScheduleState<_, _, _>) : aws.SchedulerSchedule.SchedulerSchedule =
            Unchecked.defaultof<aws.SchedulerSchedule.SchedulerSchedule>
