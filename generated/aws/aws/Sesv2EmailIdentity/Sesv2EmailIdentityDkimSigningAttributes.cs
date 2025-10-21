using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2EmailIdentity
{
    [JsiiByValue(fqn: "aws.sesv2EmailIdentity.Sesv2EmailIdentityDkimSigningAttributes")]
    public class Sesv2EmailIdentityDkimSigningAttributes : aws.Sesv2EmailIdentity.ISesv2EmailIdentityDkimSigningAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#domain_signing_private_key Sesv2EmailIdentity#domain_signing_private_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainSigningPrivateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DomainSigningPrivateKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#domain_signing_selector Sesv2EmailIdentity#domain_signing_selector}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainSigningSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DomainSigningSelector
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#next_signing_key_length Sesv2EmailIdentity#next_signing_key_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nextSigningKeyLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NextSigningKeyLength
        {
            get;
            set;
        }
    }
}
