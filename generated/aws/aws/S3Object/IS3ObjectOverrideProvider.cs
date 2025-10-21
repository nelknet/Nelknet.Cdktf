using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Object
{
    [JsiiInterface(nativeType: typeof(IS3ObjectOverrideProvider), fullyQualifiedName: "aws.s3Object.S3ObjectOverrideProvider")]
    public interface IS3ObjectOverrideProvider
    {
        /// <summary>default_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#default_tags S3Object#default_tags}
        /// </remarks>
        [JsiiProperty(name: "defaultTags", typeJson: "{\"fqn\":\"aws.s3Object.S3ObjectOverrideProviderDefaultTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3Object.IS3ObjectOverrideProviderDefaultTags? DefaultTags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ObjectOverrideProvider), fullyQualifiedName: "aws.s3Object.S3ObjectOverrideProvider")]
        internal sealed class _Proxy : DeputyBase, aws.S3Object.IS3ObjectOverrideProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#default_tags S3Object#default_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultTags", typeJson: "{\"fqn\":\"aws.s3Object.S3ObjectOverrideProviderDefaultTags\"}", isOptional: true)]
            public aws.S3Object.IS3ObjectOverrideProviderDefaultTags? DefaultTags
            {
                get => GetInstanceProperty<aws.S3Object.IS3ObjectOverrideProviderDefaultTags?>();
            }
        }
    }
}
