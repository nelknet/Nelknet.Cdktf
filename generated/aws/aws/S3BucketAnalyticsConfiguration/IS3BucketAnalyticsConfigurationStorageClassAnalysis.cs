using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketAnalyticsConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysis), fullyQualifiedName: "aws.s3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationStorageClassAnalysis")]
    public interface IS3BucketAnalyticsConfigurationStorageClassAnalysis
    {
        /// <summary>data_export block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration#data_export S3BucketAnalyticsConfiguration#data_export}
        /// </remarks>
        [JsiiProperty(name: "dataExport", typeJson: "{\"fqn\":\"aws.s3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport\"}")]
        aws.S3BucketAnalyticsConfiguration.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport DataExport
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysis), fullyQualifiedName: "aws.s3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationStorageClassAnalysis")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketAnalyticsConfiguration.IS3BucketAnalyticsConfigurationStorageClassAnalysis
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>data_export block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration#data_export S3BucketAnalyticsConfiguration#data_export}
            /// </remarks>
            [JsiiProperty(name: "dataExport", typeJson: "{\"fqn\":\"aws.s3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport\"}")]
            public aws.S3BucketAnalyticsConfiguration.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport DataExport
            {
                get => GetInstanceProperty<aws.S3BucketAnalyticsConfiguration.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport>()!;
            }
        }
    }
}
