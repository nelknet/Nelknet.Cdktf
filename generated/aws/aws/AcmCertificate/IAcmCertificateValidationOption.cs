using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AcmCertificate
{
    [JsiiInterface(nativeType: typeof(IAcmCertificateValidationOption), fullyQualifiedName: "aws.acmCertificate.AcmCertificateValidationOption")]
    public interface IAcmCertificateValidationOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#domain_name AcmCertificate#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#validation_domain AcmCertificate#validation_domain}.</summary>
        [JsiiProperty(name: "validationDomain", typeJson: "{\"primitive\":\"string\"}")]
        string ValidationDomain
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAcmCertificateValidationOption), fullyQualifiedName: "aws.acmCertificate.AcmCertificateValidationOption")]
        internal sealed class _Proxy : DeputyBase, aws.AcmCertificate.IAcmCertificateValidationOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#domain_name AcmCertificate#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#validation_domain AcmCertificate#validation_domain}.</summary>
            [JsiiProperty(name: "validationDomain", typeJson: "{\"primitive\":\"string\"}")]
            public string ValidationDomain
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
