using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiInterface(nativeType: typeof(IS3BucketObjectLockConfigurationRule), fullyQualifiedName: "aws.s3Bucket.S3BucketObjectLockConfigurationRule")]
    public interface IS3BucketObjectLockConfigurationRule
    {
        /// <summary>default_retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#default_retention S3Bucket#default_retention}
        /// </remarks>
        [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketObjectLockConfigurationRuleDefaultRetention\"}")]
        aws.S3Bucket.IS3BucketObjectLockConfigurationRuleDefaultRetention DefaultRetention
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketObjectLockConfigurationRule), fullyQualifiedName: "aws.s3Bucket.S3BucketObjectLockConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, aws.S3Bucket.IS3BucketObjectLockConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_retention block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#default_retention S3Bucket#default_retention}
            /// </remarks>
            [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketObjectLockConfigurationRuleDefaultRetention\"}")]
            public aws.S3Bucket.IS3BucketObjectLockConfigurationRuleDefaultRetention DefaultRetention
            {
                get => GetInstanceProperty<aws.S3Bucket.IS3BucketObjectLockConfigurationRuleDefaultRetention>()!;
            }
        }
    }
}
