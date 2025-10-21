using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketInventory
{
    [JsiiInterface(nativeType: typeof(IS3BucketInventoryDestination), fullyQualifiedName: "aws.s3BucketInventory.S3BucketInventoryDestination")]
    public interface IS3BucketInventoryDestination
    {
        /// <summary>bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#bucket S3BucketInventory#bucket}
        /// </remarks>
        [JsiiProperty(name: "bucket", typeJson: "{\"fqn\":\"aws.s3BucketInventory.S3BucketInventoryDestinationBucket\"}")]
        aws.S3BucketInventory.IS3BucketInventoryDestinationBucket Bucket
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventoryDestination), fullyQualifiedName: "aws.s3BucketInventory.S3BucketInventoryDestination")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketInventory.IS3BucketInventoryDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bucket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#bucket S3BucketInventory#bucket}
            /// </remarks>
            [JsiiProperty(name: "bucket", typeJson: "{\"fqn\":\"aws.s3BucketInventory.S3BucketInventoryDestinationBucket\"}")]
            public aws.S3BucketInventory.IS3BucketInventoryDestinationBucket Bucket
            {
                get => GetInstanceProperty<aws.S3BucketInventory.IS3BucketInventoryDestinationBucket>()!;
            }
        }
    }
}
