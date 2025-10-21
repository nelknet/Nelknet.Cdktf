using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketInventory
{
    [JsiiInterface(nativeType: typeof(IS3BucketInventorySchedule), fullyQualifiedName: "aws.s3BucketInventory.S3BucketInventorySchedule")]
    public interface IS3BucketInventorySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#frequency S3BucketInventory#frequency}.</summary>
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
        string Frequency
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventorySchedule), fullyQualifiedName: "aws.s3BucketInventory.S3BucketInventorySchedule")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketInventory.IS3BucketInventorySchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#frequency S3BucketInventory#frequency}.</summary>
            [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
            public string Frequency
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
