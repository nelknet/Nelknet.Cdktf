using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlAccessGrant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3ControlAccessGrant.S3ControlAccessGrantGrantee")]
    public class S3ControlAccessGrantGrantee : aws.S3ControlAccessGrant.IS3ControlAccessGrantGrantee
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#grantee_identifier S3ControlAccessGrant#grantee_identifier}.</summary>
        [JsiiProperty(name: "granteeIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string GranteeIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#grantee_type S3ControlAccessGrant#grantee_type}.</summary>
        [JsiiProperty(name: "granteeType", typeJson: "{\"primitive\":\"string\"}")]
        public string GranteeType
        {
            get;
            set;
        }
    }
}
