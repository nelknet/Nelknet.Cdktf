using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamqueryScheduledQuery
{
    [JsiiByValue(fqn: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryLastRunSummaryErrorReportLocation")]
    public class TimestreamqueryScheduledQueryLastRunSummaryErrorReportLocation : aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryLastRunSummaryErrorReportLocation
    {
        private object? _s3ReportLocation;

        /// <summary>s3_report_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#s3_report_location TimestreamqueryScheduledQuery#s3_report_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3ReportLocation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryLastRunSummaryErrorReportLocationS3ReportLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3ReportLocation
        {
            get => _s3ReportLocation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryLastRunSummaryErrorReportLocationS3ReportLocation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryLastRunSummaryErrorReportLocationS3ReportLocation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3ReportLocation = value;
            }
        }
    }
}
