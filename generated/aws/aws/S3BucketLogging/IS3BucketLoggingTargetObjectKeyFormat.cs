using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLogging
{
    [JsiiInterface(nativeType: typeof(IS3BucketLoggingTargetObjectKeyFormat), fullyQualifiedName: "aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormat")]
    public interface IS3BucketLoggingTargetObjectKeyFormat
    {
        /// <summary>partitioned_prefix block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#partitioned_prefix S3BucketLoggingA#partitioned_prefix}
        /// </remarks>
        [JsiiProperty(name: "partitionedPrefix", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefix\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix? PartitionedPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>simple_prefix block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#simple_prefix S3BucketLoggingA#simple_prefix}
        /// </remarks>
        [JsiiProperty(name: "simplePrefix", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatSimplePrefix\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatSimplePrefix? SimplePrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketLoggingTargetObjectKeyFormat), fullyQualifiedName: "aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormat")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>partitioned_prefix block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#partitioned_prefix S3BucketLoggingA#partitioned_prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "partitionedPrefix", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefix\"}", isOptional: true)]
            public aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix? PartitionedPrefix
            {
                get => GetInstanceProperty<aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix?>();
            }

            /// <summary>simple_prefix block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#simple_prefix S3BucketLoggingA#simple_prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "simplePrefix", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatSimplePrefix\"}", isOptional: true)]
            public aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatSimplePrefix? SimplePrefix
            {
                get => GetInstanceProperty<aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatSimplePrefix?>();
            }
        }
    }
}
