using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ObjectCopy
{
    [JsiiInterface(nativeType: typeof(IS3ObjectCopyOverrideProviderDefaultTags), fullyQualifiedName: "aws.s3ObjectCopy.S3ObjectCopyOverrideProviderDefaultTags")]
    public interface IS3ObjectCopyOverrideProviderDefaultTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#tags S3ObjectCopy#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ObjectCopyOverrideProviderDefaultTags), fullyQualifiedName: "aws.s3ObjectCopy.S3ObjectCopyOverrideProviderDefaultTags")]
        internal sealed class _Proxy : DeputyBase, aws.S3ObjectCopy.IS3ObjectCopyOverrideProviderDefaultTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#tags S3ObjectCopy#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
