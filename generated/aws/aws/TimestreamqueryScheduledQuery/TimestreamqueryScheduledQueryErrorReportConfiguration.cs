using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamqueryScheduledQuery
{
    [JsiiByValue(fqn: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryErrorReportConfiguration")]
    public class TimestreamqueryScheduledQueryErrorReportConfiguration : aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryErrorReportConfiguration
    {
        private object? _s3Configuration;

        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#s3_configuration TimestreamqueryScheduledQuery#s3_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryErrorReportConfigurationS3Configuration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3Configuration
        {
            get => _s3Configuration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryErrorReportConfigurationS3Configuration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryErrorReportConfigurationS3Configuration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3Configuration = value;
            }
        }
    }
}
