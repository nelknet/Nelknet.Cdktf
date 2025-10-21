using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SesDomainIdentityVerification
{
    [JsiiByValue(fqn: "aws.sesDomainIdentityVerification.SesDomainIdentityVerificationTimeouts")]
    public class SesDomainIdentityVerificationTimeouts : aws.SesDomainIdentityVerification.ISesDomainIdentityVerificationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_identity_verification#create SesDomainIdentityVerification#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
