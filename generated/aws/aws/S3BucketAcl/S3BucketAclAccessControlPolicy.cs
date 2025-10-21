using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketAcl.S3BucketAclAccessControlPolicy")]
    public class S3BucketAclAccessControlPolicy : aws.S3BucketAcl.IS3BucketAclAccessControlPolicy
    {
        /// <summary>owner block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#owner S3BucketAcl#owner}
        /// </remarks>
        [JsiiProperty(name: "owner", typeJson: "{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyOwner\"}")]
        public aws.S3BucketAcl.IS3BucketAclAccessControlPolicyOwner Owner
        {
            get;
            set;
        }

        private object? _grant;

        /// <summary>grant block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#grant S3BucketAcl#grant}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grant", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyGrant\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Grant
        {
            get => _grant;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.S3BucketAcl.IS3BucketAclAccessControlPolicyGrant[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3BucketAcl.IS3BucketAclAccessControlPolicyGrant).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _grant = value;
            }
        }
    }
}
