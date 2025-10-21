using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamqueryScheduledQuery
{
    [JsiiByValue(fqn: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryRecentlyFailedRunsQueryInsightsResponse")]
    public class TimestreamqueryScheduledQueryRecentlyFailedRunsQueryInsightsResponse : aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryRecentlyFailedRunsQueryInsightsResponse
    {
        private object? _querySpatialCoverage;

        /// <summary>query_spatial_coverage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#query_spatial_coverage TimestreamqueryScheduledQuery#query_spatial_coverage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "querySpatialCoverage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryRecentlyFailedRunsQueryInsightsResponseQuerySpatialCoverage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? QuerySpatialCoverage
        {
            get => _querySpatialCoverage;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryRecentlyFailedRunsQueryInsightsResponseQuerySpatialCoverage[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryRecentlyFailedRunsQueryInsightsResponseQuerySpatialCoverage).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _querySpatialCoverage = value;
            }
        }

        private object? _queryTemporalRange;

        /// <summary>query_temporal_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#query_temporal_range TimestreamqueryScheduledQuery#query_temporal_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryTemporalRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryRecentlyFailedRunsQueryInsightsResponseQueryTemporalRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? QueryTemporalRange
        {
            get => _queryTemporalRange;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryRecentlyFailedRunsQueryInsightsResponseQueryTemporalRange[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryRecentlyFailedRunsQueryInsightsResponseQueryTemporalRange).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queryTemporalRange = value;
            }
        }
    }
}
