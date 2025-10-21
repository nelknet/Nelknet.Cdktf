using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53DomainsRegisteredDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainNameServer")]
    public class Route53DomainsRegisteredDomainNameServer : aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainNameServer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#name Route53DomainsRegisteredDomain#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#glue_ips Route53DomainsRegisteredDomain#glue_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "glueIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GlueIps
        {
            get;
            set;
        }
    }
}
