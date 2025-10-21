using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamqueryScheduledQuery
{
    [JsiiInterface(nativeType: typeof(ITimestreamqueryScheduledQueryLastRunSummary), fullyQualifiedName: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryLastRunSummary")]
    public interface ITimestreamqueryScheduledQueryLastRunSummary
    {
        /// <summary>error_report_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#error_report_location TimestreamqueryScheduledQuery#error_report_location}
        /// </remarks>
        [JsiiProperty(name: "errorReportLocation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryLastRunSummaryErrorReportLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ErrorReportLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>execution_stats block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#execution_stats TimestreamqueryScheduledQuery#execution_stats}
        /// </remarks>
        [JsiiProperty(name: "executionStats", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryLastRunSummaryExecutionStats\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExecutionStats
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_insights_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#query_insights_response TimestreamqueryScheduledQuery#query_insights_response}
        /// </remarks>
        [JsiiProperty(name: "queryInsightsResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryLastRunSummaryQueryInsightsResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryInsightsResponse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITimestreamqueryScheduledQueryLastRunSummary), fullyQualifiedName: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryLastRunSummary")]
        internal sealed class _Proxy : DeputyBase, aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryLastRunSummary
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>error_report_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#error_report_location TimestreamqueryScheduledQuery#error_report_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "errorReportLocation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryLastRunSummaryErrorReportLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ErrorReportLocation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>execution_stats block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#execution_stats TimestreamqueryScheduledQuery#execution_stats}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executionStats", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryLastRunSummaryExecutionStats\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExecutionStats
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query_insights_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#query_insights_response TimestreamqueryScheduledQuery#query_insights_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryInsightsResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryLastRunSummaryQueryInsightsResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryInsightsResponse
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
