using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketVersioning
{
    [JsiiInterface(nativeType: typeof(IS3BucketVersioningVersioningConfiguration), fullyQualifiedName: "aws.s3BucketVersioning.S3BucketVersioningVersioningConfiguration")]
    public interface IS3BucketVersioningVersioningConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning#status S3BucketVersioningA#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning#mfa_delete S3BucketVersioningA#mfa_delete}.</summary>
        [JsiiProperty(name: "mfaDelete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MfaDelete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketVersioningVersioningConfiguration), fullyQualifiedName: "aws.s3BucketVersioning.S3BucketVersioningVersioningConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketVersioning.IS3BucketVersioningVersioningConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning#status S3BucketVersioningA#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning#mfa_delete S3BucketVersioningA#mfa_delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mfaDelete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MfaDelete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
