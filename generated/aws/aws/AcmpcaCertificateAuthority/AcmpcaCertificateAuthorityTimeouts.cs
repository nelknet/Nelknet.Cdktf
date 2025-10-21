using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AcmpcaCertificateAuthority
{
    [JsiiByValue(fqn: "aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityTimeouts")]
    public class AcmpcaCertificateAuthorityTimeouts : aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#create AcmpcaCertificateAuthority#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
