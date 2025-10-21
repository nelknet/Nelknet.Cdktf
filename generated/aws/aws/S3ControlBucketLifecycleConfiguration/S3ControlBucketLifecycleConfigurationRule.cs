using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlBucketLifecycleConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRule")]
    public class S3ControlBucketLifecycleConfigurationRule : aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_lifecycle_configuration#id S3ControlBucketLifecycleConfiguration#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>abort_incomplete_multipart_upload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_lifecycle_configuration#abort_incomplete_multipart_upload S3ControlBucketLifecycleConfiguration#abort_incomplete_multipart_upload}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "abortIncompleteMultipartUpload", typeJson: "{\"fqn\":\"aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload\"}", isOptional: true)]
        public aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload? AbortIncompleteMultipartUpload
        {
            get;
            set;
        }

        /// <summary>expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_lifecycle_configuration#expiration S3ControlBucketLifecycleConfiguration#expiration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleExpiration\"}", isOptional: true)]
        public aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleExpiration? Expiration
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_lifecycle_configuration#filter S3ControlBucketLifecycleConfiguration#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleFilter\"}", isOptional: true)]
        public aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleFilter? Filter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_lifecycle_configuration#status S3ControlBucketLifecycleConfiguration#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
