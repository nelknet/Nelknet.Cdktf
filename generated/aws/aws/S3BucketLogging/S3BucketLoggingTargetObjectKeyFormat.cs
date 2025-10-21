using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLogging
{
    [JsiiByValue(fqn: "aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormat")]
    public class S3BucketLoggingTargetObjectKeyFormat : aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormat
    {
        /// <summary>partitioned_prefix block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#partitioned_prefix S3BucketLoggingA#partitioned_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "partitionedPrefix", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefix\"}", isOptional: true)]
        public aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix? PartitionedPrefix
        {
            get;
            set;
        }

        /// <summary>simple_prefix block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#simple_prefix S3BucketLoggingA#simple_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "simplePrefix", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatSimplePrefix\"}", isOptional: true)]
        public aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatSimplePrefix? SimplePrefix
        {
            get;
            set;
        }
    }
}
