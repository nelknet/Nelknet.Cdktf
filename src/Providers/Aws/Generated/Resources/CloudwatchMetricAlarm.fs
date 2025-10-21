namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> = { assignments: ResizeArray<aws.CloudwatchMetricAlarm.CloudwatchMetricAlarmConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm">aws_cloudwatch_metric_alarm</a>.
    /// </summary>
    type CloudwatchMetricAlarmBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchMetricAlarmState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchMetricAlarmState<Missing, Missing, Missing>)

        member _.Zero(()) : CloudwatchMetricAlarmState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchMetricAlarmState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#alarm_name-1">CloudwatchMetricAlarm#alarm_name</a>.
        /// </summary>
        [<CustomOperation "alarm_name">]
        member _.AlarmName(state: CloudwatchMetricAlarmState<Missing, 'ComparisonOperator, 'EvaluationPeriods>, value: string) : CloudwatchMetricAlarmState<Present, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.AlarmName <- value)
            ({ assignments = state.assignments } : CloudwatchMetricAlarmState<Present, 'ComparisonOperator, 'EvaluationPeriods>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#comparison_operator-1">CloudwatchMetricAlarm#comparison_operator</a>.
        /// </summary>
        [<CustomOperation "comparison_operator">]
        member _.ComparisonOperator(state: CloudwatchMetricAlarmState<'AlarmName, Missing, 'EvaluationPeriods>, value: string) : CloudwatchMetricAlarmState<'AlarmName, Present, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.ComparisonOperator <- value)
            ({ assignments = state.assignments } : CloudwatchMetricAlarmState<'AlarmName, Present, 'EvaluationPeriods>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#evaluation_periods-1">CloudwatchMetricAlarm#evaluation_periods</a>.
        /// </summary>
        [<CustomOperation "evaluation_periods">]
        member _.EvaluationPeriods(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, Missing>, value: double) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, Present> =
            state.assignments.Add(fun config -> config.EvaluationPeriods <- value)
            ({ assignments = state.assignments } : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#actions_enabled-1">CloudwatchMetricAlarm#actions_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "actions_enabled">]
        member _.ActionsEnabled(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: bool) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.ActionsEnabled <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#actions_enabled-1">CloudwatchMetricAlarm#actions_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "actions_enabled">]
        member _.ActionsEnabled(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.ActionsEnabled <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#alarm_actions-1">CloudwatchMetricAlarm#alarm_actions</a>.
        /// </summary>
        [<CustomOperation "alarm_actions">]
        member _.AlarmActions(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: seq<string>) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.AlarmActions <- (value |> Seq.toArray))
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#alarm_description-1">CloudwatchMetricAlarm#alarm_description</a>.
        /// </summary>
        [<CustomOperation "alarm_description">]
        member _.AlarmDescription(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: string) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.AlarmDescription <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#datapoints_to_alarm-1">CloudwatchMetricAlarm#datapoints_to_alarm</a>.
        /// </summary>
        [<CustomOperation "datapoints_to_alarm">]
        member _.DatapointsToAlarm(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: double) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.DatapointsToAlarm <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#dimensions-1">CloudwatchMetricAlarm#dimensions</a>.
        /// </summary>
        [<CustomOperation "dimensions">]
        member _.Dimensions(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: seq<string * string>) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.Dimensions <- dict value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#evaluate_low_sample_count_percentiles-1">CloudwatchMetricAlarm#evaluate_low_sample_count_percentiles</a>.
        /// </summary>
        [<CustomOperation "evaluate_low_sample_count_percentiles">]
        member _.EvaluateLowSampleCountPercentiles(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: string) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.EvaluateLowSampleCountPercentiles <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#extended_statistic-1">CloudwatchMetricAlarm#extended_statistic</a>.
        /// </summary>
        [<CustomOperation "extended_statistic">]
        member _.ExtendedStatistic(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: string) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.ExtendedStatistic <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#id-1">CloudwatchMetricAlarm#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: string) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#insufficient_data_actions-1">CloudwatchMetricAlarm#insufficient_data_actions</a>.
        /// </summary>
        [<CustomOperation "insufficient_data_actions">]
        member _.InsufficientDataActions(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: seq<string>) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.InsufficientDataActions <- (value |> Seq.toArray))
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#metric_name-1">CloudwatchMetricAlarm#metric_name</a>.
        /// </summary>
        [<CustomOperation "metric_name">]
        member _.MetricName(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: string) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.MetricName <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// metric_query block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#metric_query-1">CloudwatchMetricAlarm#metric_query</a> Accepts: aws.IResolvable | aws.CloudwatchMetricAlarm.CloudwatchMetricAlarmMetricQuery[]
        /// </summary>
        [<CustomOperation "metric_query">]
        member _.MetricQuery(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.MetricQuery <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#namespace-1">CloudwatchMetricAlarm#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: string) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#ok_actions-1">CloudwatchMetricAlarm#ok_actions</a>.
        /// </summary>
        [<CustomOperation "ok_actions">]
        member _.OkActions(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: seq<string>) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.OkActions <- (value |> Seq.toArray))
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#period-1">CloudwatchMetricAlarm#period</a>.
        /// </summary>
        [<CustomOperation "period">]
        member _.Period(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: double) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.Period <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#statistic-1">CloudwatchMetricAlarm#statistic</a>.
        /// </summary>
        [<CustomOperation "statistic">]
        member _.Statistic(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: string) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.Statistic <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#tags-1">CloudwatchMetricAlarm#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: seq<string * string>) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#tags_all-1">CloudwatchMetricAlarm#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: seq<string * string>) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#threshold-1">CloudwatchMetricAlarm#threshold</a>.
        /// </summary>
        [<CustomOperation "threshold">]
        member _.Threshold(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: double) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.Threshold <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#threshold_metric_id-1">CloudwatchMetricAlarm#threshold_metric_id</a>.
        /// </summary>
        [<CustomOperation "threshold_metric_id">]
        member _.ThresholdMetricId(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: string) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.ThresholdMetricId <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#treat_missing_data-1">CloudwatchMetricAlarm#treat_missing_data</a>.
        /// </summary>
        [<CustomOperation "treat_missing_data">]
        member _.TreatMissingData(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: string) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.TreatMissingData <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_alarm#unit-1">CloudwatchMetricAlarm#unit</a>.
        /// </summary>
        [<CustomOperation "unit">]
        member _.Unit(state: CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>, value: string) : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods> =
            state.assignments.Add(fun config -> config.Unit <- value)
            state : CloudwatchMetricAlarmState<'AlarmName, 'ComparisonOperator, 'EvaluationPeriods>

        member _.Run(state: CloudwatchMetricAlarmState<Present, Present, Present>) : aws.CloudwatchMetricAlarm.CloudwatchMetricAlarm =
            let config = aws.CloudwatchMetricAlarm.CloudwatchMetricAlarmConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchMetricAlarm.CloudwatchMetricAlarm(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchMetricAlarm: missing required arguments. Must call: alarm_name, comparison_operator, evaluation_periods.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchMetricAlarmState<_, _, _>) : aws.CloudwatchMetricAlarm.CloudwatchMetricAlarm =
            Unchecked.defaultof<aws.CloudwatchMetricAlarm.CloudwatchMetricAlarm>
