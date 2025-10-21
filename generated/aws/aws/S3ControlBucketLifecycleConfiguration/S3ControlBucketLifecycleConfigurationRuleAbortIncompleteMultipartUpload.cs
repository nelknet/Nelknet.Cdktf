using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlBucketLifecycleConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload")]
    public class S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload : aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_lifecycle_configuration#days_after_initiation S3ControlBucketLifecycleConfiguration#days_after_initiation}.</summary>
        [JsiiProperty(name: "daysAfterInitiation", typeJson: "{\"primitive\":\"number\"}")]
        public double DaysAfterInitiation
        {
            get;
            set;
        }
    }
}
