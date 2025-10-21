using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AcmCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.acmCertificate.AcmCertificateValidationOption")]
    public class AcmCertificateValidationOption : aws.AcmCertificate.IAcmCertificateValidationOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#domain_name AcmCertificate#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/acm_certificate#validation_domain AcmCertificate#validation_domain}.</summary>
        [JsiiProperty(name: "validationDomain", typeJson: "{\"primitive\":\"string\"}")]
        public string ValidationDomain
        {
            get;
            set;
        }
    }
}
