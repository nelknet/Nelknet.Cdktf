namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule> = { assignments: ResizeArray<aws.CloudwatchCompositeAlarm.CloudwatchCompositeAlarmConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm">aws_cloudwatch_composite_alarm</a>.
    /// </summary>
    type CloudwatchCompositeAlarmBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchCompositeAlarmState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchCompositeAlarmState<Missing, Missing>)

        member _.Zero(()) : CloudwatchCompositeAlarmState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchCompositeAlarmState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#alarm_name-1">CloudwatchCompositeAlarm#alarm_name</a>.
        /// </summary>
        [<CustomOperation "alarm_name">]
        member _.AlarmName(state: CloudwatchCompositeAlarmState<Missing, 'AlarmRule>, value: string) : CloudwatchCompositeAlarmState<Present, 'AlarmRule> =
            state.assignments.Add(fun config -> config.AlarmName <- value)
            ({ assignments = state.assignments } : CloudwatchCompositeAlarmState<Present, 'AlarmRule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#alarm_rule-1">CloudwatchCompositeAlarm#alarm_rule</a>.
        /// </summary>
        [<CustomOperation "alarm_rule">]
        member _.AlarmRule(state: CloudwatchCompositeAlarmState<'AlarmName, Missing>, value: string) : CloudwatchCompositeAlarmState<'AlarmName, Present> =
            state.assignments.Add(fun config -> config.AlarmRule <- value)
            ({ assignments = state.assignments } : CloudwatchCompositeAlarmState<'AlarmName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#actions_enabled-1">CloudwatchCompositeAlarm#actions_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "actions_enabled">]
        member _.ActionsEnabled(state: CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>, value: bool) : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule> =
            state.assignments.Add(fun config -> config.ActionsEnabled <- value)
            state : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#actions_enabled-1">CloudwatchCompositeAlarm#actions_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "actions_enabled">]
        member _.ActionsEnabled(state: CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule> =
            state.assignments.Add(fun config -> config.ActionsEnabled <- value)
            state : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>

        /// <summary>
        /// actions_suppressor block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#actions_suppressor-1">CloudwatchCompositeAlarm#actions_suppressor</a>
        /// </summary>
        [<CustomOperation "actions_suppressor">]
        member _.ActionsSuppressor(state: CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>, value: aws.CloudwatchCompositeAlarm.CloudwatchCompositeAlarmActionsSuppressor) : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule> =
            state.assignments.Add(fun config -> config.ActionsSuppressor <- value)
            state : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#alarm_actions-1">CloudwatchCompositeAlarm#alarm_actions</a>.
        /// </summary>
        [<CustomOperation "alarm_actions">]
        member _.AlarmActions(state: CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>, value: seq<string>) : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule> =
            state.assignments.Add(fun config -> config.AlarmActions <- (value |> Seq.toArray))
            state : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#alarm_description-1">CloudwatchCompositeAlarm#alarm_description</a>.
        /// </summary>
        [<CustomOperation "alarm_description">]
        member _.AlarmDescription(state: CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>, value: string) : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule> =
            state.assignments.Add(fun config -> config.AlarmDescription <- value)
            state : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#id-1">CloudwatchCompositeAlarm#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>, value: string) : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#insufficient_data_actions-1">CloudwatchCompositeAlarm#insufficient_data_actions</a>.
        /// </summary>
        [<CustomOperation "insufficient_data_actions">]
        member _.InsufficientDataActions(state: CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>, value: seq<string>) : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule> =
            state.assignments.Add(fun config -> config.InsufficientDataActions <- (value |> Seq.toArray))
            state : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#ok_actions-1">CloudwatchCompositeAlarm#ok_actions</a>.
        /// </summary>
        [<CustomOperation "ok_actions">]
        member _.OkActions(state: CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>, value: seq<string>) : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule> =
            state.assignments.Add(fun config -> config.OkActions <- (value |> Seq.toArray))
            state : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#tags-1">CloudwatchCompositeAlarm#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>, value: seq<string * string>) : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_composite_alarm#tags_all-1">CloudwatchCompositeAlarm#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>, value: seq<string * string>) : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CloudwatchCompositeAlarmState<'AlarmName, 'AlarmRule>

        member _.Run(state: CloudwatchCompositeAlarmState<Present, Present>) : aws.CloudwatchCompositeAlarm.CloudwatchCompositeAlarm =
            let config = aws.CloudwatchCompositeAlarm.CloudwatchCompositeAlarmConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchCompositeAlarm.CloudwatchCompositeAlarm(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchCompositeAlarm: missing required arguments. Must call: alarm_name, alarm_rule.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchCompositeAlarmState<_, _>) : aws.CloudwatchCompositeAlarm.CloudwatchCompositeAlarm =
            Unchecked.defaultof<aws.CloudwatchCompositeAlarm.CloudwatchCompositeAlarm>
