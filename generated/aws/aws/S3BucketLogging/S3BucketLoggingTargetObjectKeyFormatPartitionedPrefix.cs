using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLogging
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefix")]
    public class S3BucketLoggingTargetObjectKeyFormatPartitionedPrefix : aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#partition_date_source S3BucketLoggingA#partition_date_source}.</summary>
        [JsiiProperty(name: "partitionDateSource", typeJson: "{\"primitive\":\"string\"}")]
        public string PartitionDateSource
        {
            get;
            set;
        }
    }
}
