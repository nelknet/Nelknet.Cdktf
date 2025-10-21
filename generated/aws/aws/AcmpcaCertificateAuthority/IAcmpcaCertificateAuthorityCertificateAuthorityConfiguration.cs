using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AcmpcaCertificateAuthority
{
    [JsiiInterface(nativeType: typeof(IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration), fullyQualifiedName: "aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration")]
    public interface IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#key_algorithm AcmpcaCertificateAuthority#key_algorithm}.</summary>
        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string KeyAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#signing_algorithm AcmpcaCertificateAuthority#signing_algorithm}.</summary>
        [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string SigningAlgorithm
        {
            get;
        }

        /// <summary>subject block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#subject AcmpcaCertificateAuthority#subject}
        /// </remarks>
        [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject\"}")]
        aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject Subject
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration), fullyQualifiedName: "aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#key_algorithm AcmpcaCertificateAuthority#key_algorithm}.</summary>
            [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#signing_algorithm AcmpcaCertificateAuthority#signing_algorithm}.</summary>
            [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string SigningAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>subject block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#subject AcmpcaCertificateAuthority#subject}
            /// </remarks>
            [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject\"}")]
            public aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject Subject
            {
                get => GetInstanceProperty<aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject>()!;
            }
        }
    }
}
