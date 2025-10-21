using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AcmCertificateValidation
{
    [JsiiInterface(nativeType: typeof(IAcmCertificateValidationTimeouts), fullyQualifiedName: "aws.acmCertificateValidation.AcmCertificateValidationTimeouts")]
    public interface IAcmCertificateValidationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate_validation#create AcmCertificateValidation#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmCertificateValidationTimeouts), fullyQualifiedName: "aws.acmCertificateValidation.AcmCertificateValidationTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.AcmCertificateValidation.IAcmCertificateValidationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate_validation#create AcmCertificateValidation#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
