using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiInterface(nativeType: typeof(IS3BucketObjectLockConfiguration), fullyQualifiedName: "aws.s3Bucket.S3BucketObjectLockConfiguration")]
    public interface IS3BucketObjectLockConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#object_lock_enabled S3Bucket#object_lock_enabled}.</summary>
        [JsiiProperty(name: "objectLockEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectLockEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#rule S3Bucket#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketObjectLockConfigurationRule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3Bucket.IS3BucketObjectLockConfigurationRule? Rule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketObjectLockConfiguration), fullyQualifiedName: "aws.s3Bucket.S3BucketObjectLockConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3Bucket.IS3BucketObjectLockConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#object_lock_enabled S3Bucket#object_lock_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectLockEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectLockEnabled
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#rule S3Bucket#rule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketObjectLockConfigurationRule\"}", isOptional: true)]
            public aws.S3Bucket.IS3BucketObjectLockConfigurationRule? Rule
            {
                get => GetInstanceProperty<aws.S3Bucket.IS3BucketObjectLockConfigurationRule?>();
            }
        }
    }
}
