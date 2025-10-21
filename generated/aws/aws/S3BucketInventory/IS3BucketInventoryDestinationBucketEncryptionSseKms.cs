using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketInventory
{
    [JsiiInterface(nativeType: typeof(IS3BucketInventoryDestinationBucketEncryptionSseKms), fullyQualifiedName: "aws.s3BucketInventory.S3BucketInventoryDestinationBucketEncryptionSseKms")]
    public interface IS3BucketInventoryDestinationBucketEncryptionSseKms
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#key_id S3BucketInventory#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventoryDestinationBucketEncryptionSseKms), fullyQualifiedName: "aws.s3BucketInventory.S3BucketInventoryDestinationBucketEncryptionSseKms")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketInventory.IS3BucketInventoryDestinationBucketEncryptionSseKms
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#key_id S3BucketInventory#key_id}.</summary>
            [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
