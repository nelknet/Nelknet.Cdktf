using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketObjectLockConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketObjectLockConfigurationRuleA), fullyQualifiedName: "aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleA")]
    public interface IS3BucketObjectLockConfigurationRuleA
    {
        /// <summary>default_retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object_lock_configuration#default_retention S3BucketObjectLockConfigurationA#default_retention}
        /// </remarks>
        [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionA\"}")]
        aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionA DefaultRetention
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketObjectLockConfigurationRuleA), fullyQualifiedName: "aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleA")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_retention block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object_lock_configuration#default_retention S3BucketObjectLockConfigurationA#default_retention}
            /// </remarks>
            [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionA\"}")]
            public aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionA DefaultRetention
            {
                get => GetInstanceProperty<aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionA>()!;
            }
        }
    }
}
