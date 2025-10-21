using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RolesanywhereTrustAnchor
{
    [JsiiInterface(nativeType: typeof(IRolesanywhereTrustAnchorSourceSourceData), fullyQualifiedName: "aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceSourceData")]
    public interface IRolesanywhereTrustAnchorSourceSourceData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#acm_pca_arn RolesanywhereTrustAnchor#acm_pca_arn}.</summary>
        [JsiiProperty(name: "acmPcaArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AcmPcaArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#x509_certificate_data RolesanywhereTrustAnchor#x509_certificate_data}.</summary>
        [JsiiProperty(name: "x509CertificateData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? X509CertificateData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRolesanywhereTrustAnchorSourceSourceData), fullyQualifiedName: "aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceSourceData")]
        internal sealed class _Proxy : DeputyBase, aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSourceSourceData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#acm_pca_arn RolesanywhereTrustAnchor#acm_pca_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acmPcaArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AcmPcaArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#x509_certificate_data RolesanywhereTrustAnchor#x509_certificate_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "x509CertificateData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? X509CertificateData
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
