using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AcmpcaCertificateAuthority
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration")]
    public class AcmpcaCertificateAuthorityCertificateAuthorityConfiguration : aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#key_algorithm AcmpcaCertificateAuthority#key_algorithm}.</summary>
        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#signing_algorithm AcmpcaCertificateAuthority#signing_algorithm}.</summary>
        [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string SigningAlgorithm
        {
            get;
            set;
        }

        /// <summary>subject block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#subject AcmpcaCertificateAuthority#subject}
        /// </remarks>
        [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject\"}")]
        public aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject Subject
        {
            get;
            set;
        }
    }
}
