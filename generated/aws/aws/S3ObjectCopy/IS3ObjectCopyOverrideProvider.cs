using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ObjectCopy
{
    [JsiiInterface(nativeType: typeof(IS3ObjectCopyOverrideProvider), fullyQualifiedName: "aws.s3ObjectCopy.S3ObjectCopyOverrideProvider")]
    public interface IS3ObjectCopyOverrideProvider
    {
        /// <summary>default_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#default_tags S3ObjectCopy#default_tags}
        /// </remarks>
        [JsiiProperty(name: "defaultTags", typeJson: "{\"fqn\":\"aws.s3ObjectCopy.S3ObjectCopyOverrideProviderDefaultTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3ObjectCopy.IS3ObjectCopyOverrideProviderDefaultTags? DefaultTags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ObjectCopyOverrideProvider), fullyQualifiedName: "aws.s3ObjectCopy.S3ObjectCopyOverrideProvider")]
        internal sealed class _Proxy : DeputyBase, aws.S3ObjectCopy.IS3ObjectCopyOverrideProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#default_tags S3ObjectCopy#default_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultTags", typeJson: "{\"fqn\":\"aws.s3ObjectCopy.S3ObjectCopyOverrideProviderDefaultTags\"}", isOptional: true)]
            public aws.S3ObjectCopy.IS3ObjectCopyOverrideProviderDefaultTags? DefaultTags
            {
                get => GetInstanceProperty<aws.S3ObjectCopy.IS3ObjectCopyOverrideProviderDefaultTags?>();
            }
        }
    }
}
