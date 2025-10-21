using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketVersioning
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketVersioning.S3BucketVersioningVersioningConfiguration")]
    public class S3BucketVersioningVersioningConfiguration : aws.S3BucketVersioning.IS3BucketVersioningVersioningConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning#status S3BucketVersioningA#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning#mfa_delete S3BucketVersioningA#mfa_delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mfaDelete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MfaDelete
        {
            get;
            set;
        }
    }
}
