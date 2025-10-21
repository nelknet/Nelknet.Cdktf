using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AcmpcaCertificateAuthority
{
    [JsiiInterface(nativeType: typeof(IAcmpcaCertificateAuthorityTimeouts), fullyQualifiedName: "aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityTimeouts")]
    public interface IAcmpcaCertificateAuthorityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#create AcmpcaCertificateAuthority#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmpcaCertificateAuthorityTimeouts), fullyQualifiedName: "aws.acmpcaCertificateAuthority.AcmpcaCertificateAuthorityTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.AcmpcaCertificateAuthority.IAcmpcaCertificateAuthorityTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acmpca_certificate_authority#create AcmpcaCertificateAuthority#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
