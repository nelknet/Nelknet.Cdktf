using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketAcl
{
    [JsiiInterface(nativeType: typeof(IS3BucketAclAccessControlPolicyGrant), fullyQualifiedName: "aws.s3BucketAcl.S3BucketAclAccessControlPolicyGrant")]
    public interface IS3BucketAclAccessControlPolicyGrant
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#permission S3BucketAcl#permission}.</summary>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        string Permission
        {
            get;
        }

        /// <summary>grantee block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#grantee S3BucketAcl#grantee}
        /// </remarks>
        [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyGrantGrantee\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketAcl.IS3BucketAclAccessControlPolicyGrantGrantee? Grantee
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAclAccessControlPolicyGrant), fullyQualifiedName: "aws.s3BucketAcl.S3BucketAclAccessControlPolicyGrant")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketAcl.IS3BucketAclAccessControlPolicyGrant
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#permission S3BucketAcl#permission}.</summary>
            [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
            public string Permission
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>grantee block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#grantee S3BucketAcl#grantee}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyGrantGrantee\"}", isOptional: true)]
            public aws.S3BucketAcl.IS3BucketAclAccessControlPolicyGrantGrantee? Grantee
            {
                get => GetInstanceProperty<aws.S3BucketAcl.IS3BucketAclAccessControlPolicyGrantGrantee?>();
            }
        }
    }
}
