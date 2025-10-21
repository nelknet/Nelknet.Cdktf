using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualNetworkPanorama
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.paloAltoNextGenerationFirewallVirtualNetworkPanorama.PaloAltoNextGenerationFirewallVirtualNetworkPanoramaDestinationNatFrontendConfig")]
    public class PaloAltoNextGenerationFirewallVirtualNetworkPanoramaDestinationNatFrontendConfig : azurerm.PaloAltoNextGenerationFirewallVirtualNetworkPanorama.IPaloAltoNextGenerationFirewallVirtualNetworkPanoramaDestinationNatFrontendConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_panorama#port PaloAltoNextGenerationFirewallVirtualNetworkPanorama#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_panorama#public_ip_address_id PaloAltoNextGenerationFirewallVirtualNetworkPanorama#public_ip_address_id}.</summary>
        [JsiiProperty(name: "publicIpAddressId", typeJson: "{\"primitive\":\"string\"}")]
        public string PublicIpAddressId
        {
            get;
            set;
        }
    }
}
