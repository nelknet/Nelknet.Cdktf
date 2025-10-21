using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLogging
{
    [JsiiInterface(nativeType: typeof(IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix), fullyQualifiedName: "aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefix")]
    public interface IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#partition_date_source S3BucketLoggingA#partition_date_source}.</summary>
        [JsiiProperty(name: "partitionDateSource", typeJson: "{\"primitive\":\"string\"}")]
        string PartitionDateSource
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix), fullyQualifiedName: "aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefix")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#partition_date_source S3BucketLoggingA#partition_date_source}.</summary>
            [JsiiProperty(name: "partitionDateSource", typeJson: "{\"primitive\":\"string\"}")]
            public string PartitionDateSource
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
