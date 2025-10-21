using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3Bucket.S3BucketLogging")]
    public class S3BucketLogging : aws.S3Bucket.IS3BucketLogging
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#target_bucket S3Bucket#target_bucket}.</summary>
        [JsiiProperty(name: "targetBucket", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetBucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#target_prefix S3Bucket#target_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetPrefix
        {
            get;
            set;
        }
    }
}
