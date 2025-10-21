using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketObjectLockConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleA")]
    public class S3BucketObjectLockConfigurationRuleA : aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleA
    {
        /// <summary>default_retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object_lock_configuration#default_retention S3BucketObjectLockConfigurationA#default_retention}
        /// </remarks>
        [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionA\"}")]
        public aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionA DefaultRetention
        {
            get;
            set;
        }
    }
}
