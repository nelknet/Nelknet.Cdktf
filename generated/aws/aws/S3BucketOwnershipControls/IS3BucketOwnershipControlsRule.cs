using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketOwnershipControls
{
    [JsiiInterface(nativeType: typeof(IS3BucketOwnershipControlsRule), fullyQualifiedName: "aws.s3BucketOwnershipControls.S3BucketOwnershipControlsRule")]
    public interface IS3BucketOwnershipControlsRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_ownership_controls#object_ownership S3BucketOwnershipControls#object_ownership}.</summary>
        [JsiiProperty(name: "objectOwnership", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectOwnership
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketOwnershipControlsRule), fullyQualifiedName: "aws.s3BucketOwnershipControls.S3BucketOwnershipControlsRule")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketOwnershipControls.IS3BucketOwnershipControlsRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_ownership_controls#object_ownership S3BucketOwnershipControls#object_ownership}.</summary>
            [JsiiProperty(name: "objectOwnership", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectOwnership
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
