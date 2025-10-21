using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiByValue(fqn: "aws.s3Bucket.S3BucketObjectLockConfiguration")]
    public class S3BucketObjectLockConfiguration : aws.S3Bucket.IS3BucketObjectLockConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#object_lock_enabled S3Bucket#object_lock_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectLockEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectLockEnabled
        {
            get;
            set;
        }

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#rule S3Bucket#rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketObjectLockConfigurationRule\"}", isOptional: true)]
        public aws.S3Bucket.IS3BucketObjectLockConfigurationRule? Rule
        {
            get;
            set;
        }
    }
}
