using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.paloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNat")]
    public class PaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNat : azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.IPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNat
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#name PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#protocol PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>backend_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#backend_config PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#backend_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBackendConfig\"}", isOptional: true)]
        public azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.IPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBackendConfig? BackendConfig
        {
            get;
            set;
        }

        /// <summary>frontend_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#frontend_config PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#frontend_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "frontendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatFrontendConfig\"}", isOptional: true)]
        public azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.IPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatFrontendConfig? FrontendConfig
        {
            get;
            set;
        }
    }
}
