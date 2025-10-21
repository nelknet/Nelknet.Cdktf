using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RolesanywhereTrustAnchor
{
    [JsiiByValue(fqn: "aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceSourceData")]
    public class RolesanywhereTrustAnchorSourceSourceData : aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSourceSourceData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#acm_pca_arn RolesanywhereTrustAnchor#acm_pca_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acmPcaArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AcmPcaArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#x509_certificate_data RolesanywhereTrustAnchor#x509_certificate_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "x509CertificateData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? X509CertificateData
        {
            get;
            set;
        }
    }
}
