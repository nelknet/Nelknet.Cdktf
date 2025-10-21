namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogMetricFilterState<'LogGroupName, 'MetricTransformation, 'Name, 'Pattern> = { assignments: ResizeArray<aws.CloudwatchLogMetricFilter.CloudwatchLogMetricFilterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_metric_filter">aws_cloudwatch_log_metric_filter</a>.
    /// </summary>
    type CloudwatchLogMetricFilterBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogMetricFilterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogMetricFilterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CloudwatchLogMetricFilterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogMetricFilterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_metric_filter#log_group_name-1">CloudwatchLogMetricFilter#log_group_name</a>.
        /// </summary>
        [<CustomOperation "log_group_name">]
        member _.LogGroupName(state: CloudwatchLogMetricFilterState<Missing, 'MetricTransformation, 'Name, 'Pattern>, value: string) : CloudwatchLogMetricFilterState<Present, 'MetricTransformation, 'Name, 'Pattern> =
            state.assignments.Add(fun config -> config.LogGroupName <- value)
            ({ assignments = state.assignments } : CloudwatchLogMetricFilterState<Present, 'MetricTransformation, 'Name, 'Pattern>)

        /// <summary>
        /// metric_transformation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_metric_filter#metric_transformation-1">CloudwatchLogMetricFilter#metric_transformation</a>
        /// </summary>
        [<CustomOperation "metric_transformation">]
        member _.MetricTransformation(state: CloudwatchLogMetricFilterState<'LogGroupName, Missing, 'Name, 'Pattern>, value: aws.CloudwatchLogMetricFilter.CloudwatchLogMetricFilterMetricTransformation) : CloudwatchLogMetricFilterState<'LogGroupName, Present, 'Name, 'Pattern> =
            state.assignments.Add(fun config -> config.MetricTransformation <- value)
            ({ assignments = state.assignments } : CloudwatchLogMetricFilterState<'LogGroupName, Present, 'Name, 'Pattern>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_metric_filter#name-1">CloudwatchLogMetricFilter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchLogMetricFilterState<'LogGroupName, 'MetricTransformation, Missing, 'Pattern>, value: string) : CloudwatchLogMetricFilterState<'LogGroupName, 'MetricTransformation, Present, 'Pattern> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudwatchLogMetricFilterState<'LogGroupName, 'MetricTransformation, Present, 'Pattern>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_metric_filter#pattern-1">CloudwatchLogMetricFilter#pattern</a>.
        /// </summary>
        [<CustomOperation "pattern">]
        member _.Pattern(state: CloudwatchLogMetricFilterState<'LogGroupName, 'MetricTransformation, 'Name, Missing>, value: string) : CloudwatchLogMetricFilterState<'LogGroupName, 'MetricTransformation, 'Name, Present> =
            state.assignments.Add(fun config -> config.Pattern <- value)
            ({ assignments = state.assignments } : CloudwatchLogMetricFilterState<'LogGroupName, 'MetricTransformation, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_metric_filter#id-1">CloudwatchLogMetricFilter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchLogMetricFilterState<'LogGroupName, 'MetricTransformation, 'Name, 'Pattern>, value: string) : CloudwatchLogMetricFilterState<'LogGroupName, 'MetricTransformation, 'Name, 'Pattern> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchLogMetricFilterState<'LogGroupName, 'MetricTransformation, 'Name, 'Pattern>

        member _.Run(state: CloudwatchLogMetricFilterState<Present, Present, Present, Present>) : aws.CloudwatchLogMetricFilter.CloudwatchLogMetricFilter =
            let config = aws.CloudwatchLogMetricFilter.CloudwatchLogMetricFilterConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogMetricFilter.CloudwatchLogMetricFilter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogMetricFilter: missing required arguments. Must call: log_group_name, metric_transformation, name, pattern.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogMetricFilterState<_, _, _, _>) : aws.CloudwatchLogMetricFilter.CloudwatchLogMetricFilter =
            Unchecked.defaultof<aws.CloudwatchLogMetricFilter.CloudwatchLogMetricFilter>
