using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamqueryScheduledQuery
{
    [JsiiInterface(nativeType: typeof(ITimestreamqueryScheduledQueryErrorReportConfiguration), fullyQualifiedName: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryErrorReportConfiguration")]
    public interface ITimestreamqueryScheduledQueryErrorReportConfiguration
    {
        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#s3_configuration TimestreamqueryScheduledQuery#s3_configuration}
        /// </remarks>
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryErrorReportConfigurationS3Configuration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3Configuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITimestreamqueryScheduledQueryErrorReportConfiguration), fullyQualifiedName: "aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryErrorReportConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.TimestreamqueryScheduledQuery.ITimestreamqueryScheduledQueryErrorReportConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamquery_scheduled_query#s3_configuration TimestreamqueryScheduledQuery#s3_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreamqueryScheduledQuery.TimestreamqueryScheduledQueryErrorReportConfigurationS3Configuration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3Configuration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
