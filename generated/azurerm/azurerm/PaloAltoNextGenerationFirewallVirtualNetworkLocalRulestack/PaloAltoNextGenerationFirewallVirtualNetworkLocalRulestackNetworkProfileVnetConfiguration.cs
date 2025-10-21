using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfileVnetConfiguration")]
    public class PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfileVnetConfiguration : azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfileVnetConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#virtual_network_id PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#virtual_network_id}.</summary>
        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualNetworkId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#trusted_subnet_id PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#trusted_subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustedSubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#untrusted_subnet_id PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#untrusted_subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "untrustedSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UntrustedSubnetId
        {
            get;
            set;
        }
    }
}
