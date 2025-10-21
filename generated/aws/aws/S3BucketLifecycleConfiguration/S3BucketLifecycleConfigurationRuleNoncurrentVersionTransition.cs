using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLifecycleConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketLifecycleConfiguration.S3BucketLifecycleConfigurationRuleNoncurrentVersionTransition")]
    public class S3BucketLifecycleConfigurationRuleNoncurrentVersionTransition : aws.S3BucketLifecycleConfiguration.IS3BucketLifecycleConfigurationRuleNoncurrentVersionTransition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#noncurrent_days S3BucketLifecycleConfiguration#noncurrent_days}.</summary>
        [JsiiProperty(name: "noncurrentDays", typeJson: "{\"primitive\":\"number\"}")]
        public double NoncurrentDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#storage_class S3BucketLifecycleConfiguration#storage_class}.</summary>
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageClass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#newer_noncurrent_versions S3BucketLifecycleConfiguration#newer_noncurrent_versions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "newerNoncurrentVersions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NewerNoncurrentVersions
        {
            get;
            set;
        }
    }
}
