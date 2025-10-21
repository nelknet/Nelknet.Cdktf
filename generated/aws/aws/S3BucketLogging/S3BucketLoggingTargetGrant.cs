using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLogging
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketLogging.S3BucketLoggingTargetGrant")]
    public class S3BucketLoggingTargetGrant : aws.S3BucketLogging.IS3BucketLoggingTargetGrant
    {
        /// <summary>grantee block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#grantee S3BucketLoggingA#grantee}
        /// </remarks>
        [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetGrantGrantee\"}")]
        public aws.S3BucketLogging.IS3BucketLoggingTargetGrantGrantee Grantee
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#permission S3BucketLoggingA#permission}.</summary>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        public string Permission
        {
            get;
            set;
        }
    }
}
