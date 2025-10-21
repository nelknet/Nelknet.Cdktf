using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FirewallPolicy
{
    [JsiiByValue(fqn: "azurerm.firewallPolicy.FirewallPolicyThreatIntelligenceAllowlistStruct")]
    public class FirewallPolicyThreatIntelligenceAllowlistStruct : azurerm.FirewallPolicy.IFirewallPolicyThreatIntelligenceAllowlistStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#fqdns FirewallPolicy#fqdns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fqdns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Fqdns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#ip_addresses FirewallPolicy#ip_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpAddresses
        {
            get;
            set;
        }
    }
}
