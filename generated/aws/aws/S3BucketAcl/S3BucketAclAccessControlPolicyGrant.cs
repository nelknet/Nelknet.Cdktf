using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketAcl.S3BucketAclAccessControlPolicyGrant")]
    public class S3BucketAclAccessControlPolicyGrant : aws.S3BucketAcl.IS3BucketAclAccessControlPolicyGrant
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#permission S3BucketAcl#permission}.</summary>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        public string Permission
        {
            get;
            set;
        }

        /// <summary>grantee block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#grantee S3BucketAcl#grantee}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyGrantGrantee\"}", isOptional: true)]
        public aws.S3BucketAcl.IS3BucketAclAccessControlPolicyGrantGrantee? Grantee
        {
            get;
            set;
        }
    }
}
