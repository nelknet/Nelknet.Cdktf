using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlAccessGrant
{
    [JsiiByValue(fqn: "aws.s3ControlAccessGrant.S3ControlAccessGrantAccessGrantsLocationConfiguration")]
    public class S3ControlAccessGrantAccessGrantsLocationConfiguration : aws.S3ControlAccessGrant.IS3ControlAccessGrantAccessGrantsLocationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#s3_sub_prefix S3ControlAccessGrant#s3_sub_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3SubPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3SubPrefix
        {
            get;
            set;
        }
    }
}
