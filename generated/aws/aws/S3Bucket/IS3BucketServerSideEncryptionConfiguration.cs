using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiInterface(nativeType: typeof(IS3BucketServerSideEncryptionConfiguration), fullyQualifiedName: "aws.s3Bucket.S3BucketServerSideEncryptionConfiguration")]
    public interface IS3BucketServerSideEncryptionConfiguration
    {
        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#rule S3Bucket#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketServerSideEncryptionConfigurationRule\"}")]
        aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRule Rule
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketServerSideEncryptionConfiguration), fullyQualifiedName: "aws.s3Bucket.S3BucketServerSideEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3Bucket.IS3BucketServerSideEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#rule S3Bucket#rule}
            /// </remarks>
            [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketServerSideEncryptionConfigurationRule\"}")]
            public aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRule Rule
            {
                get => GetInstanceProperty<aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRule>()!;
            }
        }
    }
}
