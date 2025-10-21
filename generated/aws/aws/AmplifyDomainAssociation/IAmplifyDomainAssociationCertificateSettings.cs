using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AmplifyDomainAssociation
{
    [JsiiInterface(nativeType: typeof(IAmplifyDomainAssociationCertificateSettings), fullyQualifiedName: "aws.amplifyDomainAssociation.AmplifyDomainAssociationCertificateSettings")]
    public interface IAmplifyDomainAssociationCertificateSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#type AmplifyDomainAssociation#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#custom_certificate_arn AmplifyDomainAssociation#custom_certificate_arn}.</summary>
        [JsiiProperty(name: "customCertificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomCertificateArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAmplifyDomainAssociationCertificateSettings), fullyQualifiedName: "aws.amplifyDomainAssociation.AmplifyDomainAssociationCertificateSettings")]
        internal sealed class _Proxy : DeputyBase, aws.AmplifyDomainAssociation.IAmplifyDomainAssociationCertificateSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#type AmplifyDomainAssociation#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#custom_certificate_arn AmplifyDomainAssociation#custom_certificate_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customCertificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomCertificateArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
