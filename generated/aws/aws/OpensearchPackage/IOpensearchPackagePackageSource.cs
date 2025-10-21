using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchPackage
{
    [JsiiInterface(nativeType: typeof(IOpensearchPackagePackageSource), fullyQualifiedName: "aws.opensearchPackage.OpensearchPackagePackageSource")]
    public interface IOpensearchPackagePackageSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package#s3_bucket_name OpensearchPackage#s3_bucket_name}.</summary>
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        string S3BucketName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package#s3_key OpensearchPackage#s3_key}.</summary>
        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}")]
        string S3Key
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchPackagePackageSource), fullyQualifiedName: "aws.opensearchPackage.OpensearchPackagePackageSource")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchPackage.IOpensearchPackagePackageSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package#s3_bucket_name OpensearchPackage#s3_bucket_name}.</summary>
            [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string S3BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package#s3_key OpensearchPackage#s3_key}.</summary>
            [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Key
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
