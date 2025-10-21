namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn> = { assignments: ResizeArray<aws.CloudwatchMetricStream.CloudwatchMetricStreamConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream">aws_cloudwatch_metric_stream</a>.
    /// </summary>
    type CloudwatchMetricStreamBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchMetricStreamState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchMetricStreamState<Missing, Missing, Missing>)

        member _.Zero(()) : CloudwatchMetricStreamState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchMetricStreamState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#firehose_arn-1">CloudwatchMetricStream#firehose_arn</a>.
        /// </summary>
        [<CustomOperation "firehose_arn">]
        member _.FirehoseArn(state: CloudwatchMetricStreamState<Missing, 'OutputFormat, 'RoleArn>, value: string) : CloudwatchMetricStreamState<Present, 'OutputFormat, 'RoleArn> =
            state.assignments.Add(fun config -> config.FirehoseArn <- value)
            ({ assignments = state.assignments } : CloudwatchMetricStreamState<Present, 'OutputFormat, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#output_format-1">CloudwatchMetricStream#output_format</a>.
        /// </summary>
        [<CustomOperation "output_format">]
        member _.OutputFormat(state: CloudwatchMetricStreamState<'FirehoseArn, Missing, 'RoleArn>, value: string) : CloudwatchMetricStreamState<'FirehoseArn, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.OutputFormat <- value)
            ({ assignments = state.assignments } : CloudwatchMetricStreamState<'FirehoseArn, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#role_arn-1">CloudwatchMetricStream#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, Missing>, value: string) : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, Present>)

        /// <summary>
        /// exclude_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#exclude_filter-1">CloudwatchMetricStream#exclude_filter</a> Accepts: aws.IResolvable | aws.CloudwatchMetricStream.CloudwatchMetricStreamExcludeFilter[]
        /// </summary>
        [<CustomOperation "exclude_filter">]
        member _.ExcludeFilter(state: CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn> =
            state.assignments.Add(fun config -> config.ExcludeFilter <- value)
            state : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#id-1">CloudwatchMetricStream#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>, value: string) : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>

        /// <summary>
        /// include_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#include_filter-1">CloudwatchMetricStream#include_filter</a> Accepts: aws.IResolvable | aws.CloudwatchMetricStream.CloudwatchMetricStreamIncludeFilter[]
        /// </summary>
        [<CustomOperation "include_filter">]
        member _.IncludeFilter(state: CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn> =
            state.assignments.Add(fun config -> config.IncludeFilter <- value)
            state : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#include_linked_accounts_metrics-1">CloudwatchMetricStream#include_linked_accounts_metrics</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_linked_accounts_metrics">]
        member _.IncludeLinkedAccountsMetrics(state: CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>, value: bool) : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn> =
            state.assignments.Add(fun config -> config.IncludeLinkedAccountsMetrics <- value)
            state : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#include_linked_accounts_metrics-1">CloudwatchMetricStream#include_linked_accounts_metrics</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_linked_accounts_metrics">]
        member _.IncludeLinkedAccountsMetrics(state: CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn> =
            state.assignments.Add(fun config -> config.IncludeLinkedAccountsMetrics <- value)
            state : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#name-1">CloudwatchMetricStream#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>, value: string) : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#name_prefix-1">CloudwatchMetricStream#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>, value: string) : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>

        /// <summary>
        /// statistics_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#statistics_configuration-1">CloudwatchMetricStream#statistics_configuration</a> Accepts: aws.IResolvable | aws.CloudwatchMetricStream.CloudwatchMetricStreamStatisticsConfiguration[]
        /// </summary>
        [<CustomOperation "statistics_configuration">]
        member _.StatisticsConfiguration(state: CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn> =
            state.assignments.Add(fun config -> config.StatisticsConfiguration <- value)
            state : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#tags-1">CloudwatchMetricStream#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>, value: seq<string * string>) : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#tags_all-1">CloudwatchMetricStream#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>, value: seq<string * string>) : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_metric_stream#timeouts-1">CloudwatchMetricStream#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>, value: aws.CloudwatchMetricStream.CloudwatchMetricStreamTimeouts) : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CloudwatchMetricStreamState<'FirehoseArn, 'OutputFormat, 'RoleArn>

        member _.Run(state: CloudwatchMetricStreamState<Present, Present, Present>) : aws.CloudwatchMetricStream.CloudwatchMetricStream =
            let config = aws.CloudwatchMetricStream.CloudwatchMetricStreamConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchMetricStream.CloudwatchMetricStream(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchMetricStream: missing required arguments. Must call: firehose_arn, output_format, role_arn.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchMetricStreamState<_, _, _>) : aws.CloudwatchMetricStream.CloudwatchMetricStream =
            Unchecked.defaultof<aws.CloudwatchMetricStream.CloudwatchMetricStream>
