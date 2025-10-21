using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketAnalyticsConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination), fullyQualifiedName: "aws.s3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination")]
    public interface IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination
    {
        /// <summary>s3_bucket_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration#s3_bucket_destination S3BucketAnalyticsConfiguration#s3_bucket_destination}
        /// </remarks>
        [JsiiProperty(name: "s3BucketDestination", typeJson: "{\"fqn\":\"aws.s3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination\"}")]
        aws.S3BucketAnalyticsConfiguration.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination S3BucketDestination
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination), fullyQualifiedName: "aws.s3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketAnalyticsConfiguration.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_bucket_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration#s3_bucket_destination S3BucketAnalyticsConfiguration#s3_bucket_destination}
            /// </remarks>
            [JsiiProperty(name: "s3BucketDestination", typeJson: "{\"fqn\":\"aws.s3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination\"}")]
            public aws.S3BucketAnalyticsConfiguration.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination S3BucketDestination
            {
                get => GetInstanceProperty<aws.S3BucketAnalyticsConfiguration.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination>()!;
            }
        }
    }
}
