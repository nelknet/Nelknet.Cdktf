using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsResolverDnsForwardingRuleset
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPrivateDnsResolverDnsForwardingRuleset.DataAzurermPrivateDnsResolverDnsForwardingRulesetTimeouts")]
    public class DataAzurermPrivateDnsResolverDnsForwardingRulesetTimeouts : azurerm.DataAzurermPrivateDnsResolverDnsForwardingRuleset.IDataAzurermPrivateDnsResolverDnsForwardingRulesetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_dns_forwarding_ruleset#read DataAzurermPrivateDnsResolverDnsForwardingRuleset#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
