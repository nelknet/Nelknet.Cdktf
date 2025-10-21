using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AmplifyDomainAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.amplifyDomainAssociation.AmplifyDomainAssociationCertificateSettings")]
    public class AmplifyDomainAssociationCertificateSettings : aws.AmplifyDomainAssociation.IAmplifyDomainAssociationCertificateSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#type AmplifyDomainAssociation#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#custom_certificate_arn AmplifyDomainAssociation#custom_certificate_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customCertificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomCertificateArn
        {
            get;
            set;
        }
    }
}
