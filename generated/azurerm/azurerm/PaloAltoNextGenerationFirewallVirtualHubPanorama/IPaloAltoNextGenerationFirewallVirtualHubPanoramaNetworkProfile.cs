using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama
{
    [JsiiInterface(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfile), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfile")]
    public interface IPaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#network_virtual_appliance_id PaloAltoNextGenerationFirewallVirtualHubPanorama#network_virtual_appliance_id}.</summary>
        [JsiiProperty(name: "networkVirtualApplianceId", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkVirtualApplianceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#public_ip_address_ids PaloAltoNextGenerationFirewallVirtualHubPanorama#public_ip_address_ids}.</summary>
        [JsiiProperty(name: "publicIpAddressIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] PublicIpAddressIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#virtual_hub_id PaloAltoNextGenerationFirewallVirtualHubPanorama#virtual_hub_id}.</summary>
        [JsiiProperty(name: "virtualHubId", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualHubId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#egress_nat_ip_address_ids PaloAltoNextGenerationFirewallVirtualHubPanorama#egress_nat_ip_address_ids}.</summary>
        [JsiiProperty(name: "egressNatIpAddressIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EgressNatIpAddressIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#trusted_address_ranges PaloAltoNextGenerationFirewallVirtualHubPanorama#trusted_address_ranges}.</summary>
        [JsiiProperty(name: "trustedAddressRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TrustedAddressRanges
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfile), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.IPaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#network_virtual_appliance_id PaloAltoNextGenerationFirewallVirtualHubPanorama#network_virtual_appliance_id}.</summary>
            [JsiiProperty(name: "networkVirtualApplianceId", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkVirtualApplianceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#public_ip_address_ids PaloAltoNextGenerationFirewallVirtualHubPanorama#public_ip_address_ids}.</summary>
            [JsiiProperty(name: "publicIpAddressIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] PublicIpAddressIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#virtual_hub_id PaloAltoNextGenerationFirewallVirtualHubPanorama#virtual_hub_id}.</summary>
            [JsiiProperty(name: "virtualHubId", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualHubId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#egress_nat_ip_address_ids PaloAltoNextGenerationFirewallVirtualHubPanorama#egress_nat_ip_address_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "egressNatIpAddressIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EgressNatIpAddressIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#trusted_address_ranges PaloAltoNextGenerationFirewallVirtualHubPanorama#trusted_address_ranges}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedAddressRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TrustedAddressRanges
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
