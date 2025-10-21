using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AcmpcaCertificateAuthority
{
    [JsiiByValue(fqn: "aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfiguration")]
    public class AcmpcaCertificateAuthorityRevocationConfiguration : aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityRevocationConfiguration
    {
        /// <summary>crl_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#crl_configuration AcmpcaCertificateAuthority#crl_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "crlConfiguration", typeJson: "{\"fqn\":\"aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"}", isOptional: true)]
        public aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration? CrlConfiguration
        {
            get;
            set;
        }

        /// <summary>ocsp_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#ocsp_configuration AcmpcaCertificateAuthority#ocsp_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ocspConfiguration", typeJson: "{\"fqn\":\"aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityRevocationConfigurationOcspConfiguration\"}", isOptional: true)]
        public aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityRevocationConfigurationOcspConfiguration? OcspConfiguration
        {
            get;
            set;
        }
    }
}
