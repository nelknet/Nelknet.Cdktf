using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLifecycleConfiguration
{
    [JsiiByValue(fqn: "aws.s3BucketLifecycleConfiguration.S3BucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload")]
    public class S3BucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload : aws.S3BucketLifecycleConfiguration.IS3BucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#days_after_initiation S3BucketLifecycleConfiguration#days_after_initiation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "daysAfterInitiation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DaysAfterInitiation
        {
            get;
            set;
        }
    }
}
