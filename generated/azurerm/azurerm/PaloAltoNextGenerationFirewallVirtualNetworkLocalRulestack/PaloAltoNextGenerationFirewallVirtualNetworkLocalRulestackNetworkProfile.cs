using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfile")]
    public class PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfile : azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#public_ip_address_ids PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#public_ip_address_ids}.</summary>
        [JsiiProperty(name: "publicIpAddressIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] PublicIpAddressIds
        {
            get;
            set;
        }

        /// <summary>vnet_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#vnet_configuration PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#vnet_configuration}
        /// </remarks>
        [JsiiProperty(name: "vnetConfiguration", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfileVnetConfiguration\"}")]
        public azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfileVnetConfiguration VnetConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#egress_nat_ip_address_ids PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#egress_nat_ip_address_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "egressNatIpAddressIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EgressNatIpAddressIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#trusted_address_ranges PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#trusted_address_ranges}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedAddressRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TrustedAddressRanges
        {
            get;
            set;
        }
    }
}
