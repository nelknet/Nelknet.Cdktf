using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack
{
    [JsiiInterface(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatBackendConfig), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatBackendConfig")]
    public interface IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatBackendConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#port PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#public_ip_address PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#public_ip_address}.</summary>
        [JsiiProperty(name: "publicIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        string PublicIpAddress
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatBackendConfig), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatBackendConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.IPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatBackendConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#port PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#public_ip_address PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#public_ip_address}.</summary>
            [JsiiProperty(name: "publicIpAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicIpAddress
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
