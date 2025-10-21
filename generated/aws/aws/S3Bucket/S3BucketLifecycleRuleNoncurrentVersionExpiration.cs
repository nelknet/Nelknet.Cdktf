using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiByValue(fqn: "aws.s3Bucket.S3BucketLifecycleRuleNoncurrentVersionExpiration")]
    public class S3BucketLifecycleRuleNoncurrentVersionExpiration : aws.S3Bucket.IS3BucketLifecycleRuleNoncurrentVersionExpiration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#days S3Bucket#days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Days
        {
            get;
            set;
        }
    }
}
