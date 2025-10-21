using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53DomainsRegisteredDomain
{
    [JsiiInterface(nativeType: typeof(IRoute53DomainsRegisteredDomainNameServer), fullyQualifiedName: "aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainNameServer")]
    public interface IRoute53DomainsRegisteredDomainNameServer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#name Route53DomainsRegisteredDomain#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#glue_ips Route53DomainsRegisteredDomain#glue_ips}.</summary>
        [JsiiProperty(name: "glueIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? GlueIps
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53DomainsRegisteredDomainNameServer), fullyQualifiedName: "aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainNameServer")]
        internal sealed class _Proxy : DeputyBase, aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainNameServer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#name Route53DomainsRegisteredDomain#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#glue_ips Route53DomainsRegisteredDomain#glue_ips}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "glueIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? GlueIps
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
