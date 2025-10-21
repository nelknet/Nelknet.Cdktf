using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamqueryScheduledQuery
{
    [JsiiByValue(fqn: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryRecentlyFailedRuns")]
    public class TimestreamqueryScheduledQueryRecentlyFailedRuns : aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryRecentlyFailedRuns
    {
        private object? _errorReportLocation;

        /// <summary>error_report_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#error_report_location TimestreamqueryScheduledQuery#error_report_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "errorReportLocation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryRecentlyFailedRunsErrorReportLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ErrorReportLocation
        {
            get => _errorReportLocation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryRecentlyFailedRunsErrorReportLocation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryRecentlyFailedRunsErrorReportLocation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _errorReportLocation = value;
            }
        }

        private object? _executionStats;

        /// <summary>execution_stats block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#execution_stats TimestreamqueryScheduledQuery#execution_stats}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "executionStats", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryRecentlyFailedRunsExecutionStats\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExecutionStats
        {
            get => _executionStats;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryRecentlyFailedRunsExecutionStats[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryRecentlyFailedRunsExecutionStats).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _executionStats = value;
            }
        }

        private object? _queryInsightsResponse;

        /// <summary>query_insights_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#query_insights_response TimestreamqueryScheduledQuery#query_insights_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryInsightsResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryRecentlyFailedRunsQueryInsightsResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? QueryInsightsResponse
        {
            get => _queryInsightsResponse;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryRecentlyFailedRunsQueryInsightsResponse[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryRecentlyFailedRunsQueryInsightsResponse).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queryInsightsResponse = value;
            }
        }
    }
}
