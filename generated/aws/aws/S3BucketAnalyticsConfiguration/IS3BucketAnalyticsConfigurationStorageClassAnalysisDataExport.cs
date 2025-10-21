using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketAnalyticsConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport), fullyQualifiedName: "aws.s3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport")]
    public interface IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration#destination S3BucketAnalyticsConfiguration#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination\"}")]
        aws.S3BucketAnalyticsConfiguration.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration#output_schema_version S3BucketAnalyticsConfiguration#output_schema_version}.</summary>
        [JsiiProperty(name: "outputSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputSchemaVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport), fullyQualifiedName: "aws.s3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketAnalyticsConfiguration.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration#destination S3BucketAnalyticsConfiguration#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination\"}")]
            public aws.S3BucketAnalyticsConfiguration.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination Destination
            {
                get => GetInstanceProperty<aws.S3BucketAnalyticsConfiguration.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration#output_schema_version S3BucketAnalyticsConfiguration#output_schema_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputSchemaVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
