using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketAcl
{
    [JsiiInterface(nativeType: typeof(IS3BucketAclAccessControlPolicy), fullyQualifiedName: "aws.s3BucketAcl.S3BucketAclAccessControlPolicy")]
    public interface IS3BucketAclAccessControlPolicy
    {
        /// <summary>owner block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#owner S3BucketAcl#owner}
        /// </remarks>
        [JsiiProperty(name: "owner", typeJson: "{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyOwner\"}")]
        aws.S3BucketAcl.IS3BucketAclAccessControlPolicyOwner Owner
        {
            get;
        }

        /// <summary>grant block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#grant S3BucketAcl#grant}
        /// </remarks>
        [JsiiProperty(name: "grant", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyGrant\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Grant
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAclAccessControlPolicy), fullyQualifiedName: "aws.s3BucketAcl.S3BucketAclAccessControlPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketAcl.IS3BucketAclAccessControlPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>owner block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#owner S3BucketAcl#owner}
            /// </remarks>
            [JsiiProperty(name: "owner", typeJson: "{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyOwner\"}")]
            public aws.S3BucketAcl.IS3BucketAclAccessControlPolicyOwner Owner
            {
                get => GetInstanceProperty<aws.S3BucketAcl.IS3BucketAclAccessControlPolicyOwner>()!;
            }

            /// <summary>grant block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#grant S3BucketAcl#grant}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grant", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyGrant\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Grant
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
