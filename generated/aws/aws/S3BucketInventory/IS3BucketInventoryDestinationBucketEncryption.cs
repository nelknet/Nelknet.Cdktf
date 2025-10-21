using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketInventory
{
    [JsiiInterface(nativeType: typeof(IS3BucketInventoryDestinationBucketEncryption), fullyQualifiedName: "aws.s3BucketInventory.S3BucketInventoryDestinationBucketEncryption")]
    public interface IS3BucketInventoryDestinationBucketEncryption
    {
        /// <summary>sse_kms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#sse_kms S3BucketInventory#sse_kms}
        /// </remarks>
        [JsiiProperty(name: "sseKms", typeJson: "{\"fqn\":\"aws.s3BucketInventory.S3BucketInventoryDestinationBucketEncryptionSseKms\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketInventory.IS3BucketInventoryDestinationBucketEncryptionSseKms? SseKms
        {
            get
            {
                return null;
            }
        }

        /// <summary>sse_s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#sse_s3 S3BucketInventory#sse_s3}
        /// </remarks>
        [JsiiProperty(name: "sseS3", typeJson: "{\"fqn\":\"aws.s3BucketInventory.S3BucketInventoryDestinationBucketEncryptionSseS3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketInventory.IS3BucketInventoryDestinationBucketEncryptionSseS3? SseS3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventoryDestinationBucketEncryption), fullyQualifiedName: "aws.s3BucketInventory.S3BucketInventoryDestinationBucketEncryption")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketInventory.IS3BucketInventoryDestinationBucketEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>sse_kms block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#sse_kms S3BucketInventory#sse_kms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sseKms", typeJson: "{\"fqn\":\"aws.s3BucketInventory.S3BucketInventoryDestinationBucketEncryptionSseKms\"}", isOptional: true)]
            public aws.S3BucketInventory.IS3BucketInventoryDestinationBucketEncryptionSseKms? SseKms
            {
                get => GetInstanceProperty<aws.S3BucketInventory.IS3BucketInventoryDestinationBucketEncryptionSseKms?>();
            }

            /// <summary>sse_s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#sse_s3 S3BucketInventory#sse_s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sseS3", typeJson: "{\"fqn\":\"aws.s3BucketInventory.S3BucketInventoryDestinationBucketEncryptionSseS3\"}", isOptional: true)]
            public aws.S3BucketInventory.IS3BucketInventoryDestinationBucketEncryptionSseS3? SseS3
            {
                get => GetInstanceProperty<aws.S3BucketInventory.IS3BucketInventoryDestinationBucketEncryptionSseS3?>();
            }
        }
    }
}
