using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53DomainsDelegationSignerRecord
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordSigningAttributes")]
    public class Route53DomainsDelegationSignerRecordSigningAttributes : aws.Route53DomainsDelegationSignerRecord.IRoute53DomainsDelegationSignerRecordSigningAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record#algorithm Route53DomainsDelegationSignerRecord#algorithm}.</summary>
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"number\"}")]
        public double Algorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record#flags Route53DomainsDelegationSignerRecord#flags}.</summary>
        [JsiiProperty(name: "flags", typeJson: "{\"primitive\":\"number\"}")]
        public double Flags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record#public_key Route53DomainsDelegationSignerRecord#public_key}.</summary>
        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
        public string PublicKey
        {
            get;
            set;
        }
    }
}
