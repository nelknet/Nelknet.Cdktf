using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLifecycleConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload), fullyQualifiedName: "aws.s3BucketLifecycleConfiguration.S3BucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload")]
    public interface IS3BucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#days_after_initiation S3BucketLifecycleConfiguration#days_after_initiation}.</summary>
        [JsiiProperty(name: "daysAfterInitiation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DaysAfterInitiation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload), fullyQualifiedName: "aws.s3BucketLifecycleConfiguration.S3BucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketLifecycleConfiguration.IS3BucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#days_after_initiation S3BucketLifecycleConfiguration#days_after_initiation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "daysAfterInitiation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DaysAfterInitiation
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
