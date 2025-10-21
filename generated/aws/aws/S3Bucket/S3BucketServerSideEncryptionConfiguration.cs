using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3Bucket.S3BucketServerSideEncryptionConfiguration")]
    public class S3BucketServerSideEncryptionConfiguration : aws.S3Bucket.IS3BucketServerSideEncryptionConfiguration
    {
        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#rule S3Bucket#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketServerSideEncryptionConfigurationRule\"}")]
        public aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRule Rule
        {
            get;
            set;
        }
    }
}
