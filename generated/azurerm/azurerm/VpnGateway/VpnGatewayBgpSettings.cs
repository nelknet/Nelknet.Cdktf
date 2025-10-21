using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vpnGateway.VpnGatewayBgpSettings")]
    public class VpnGatewayBgpSettings : azurerm.VpnGateway.IVpnGatewayBgpSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#asn VpnGateway#asn}.</summary>
        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}")]
        public double Asn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#peer_weight VpnGateway#peer_weight}.</summary>
        [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}")]
        public double PeerWeight
        {
            get;
            set;
        }

        /// <summary>instance_0_bgp_peering_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#instance_0_bgp_peering_address VpnGateway#instance_0_bgp_peering_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instance0BgpPeeringAddress", typeJson: "{\"fqn\":\"azurerm.vpnGateway.VpnGatewayBgpSettingsInstance0BgpPeeringAddress\"}", isOptional: true)]
        public azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance0BgpPeeringAddress? Instance0BgpPeeringAddress
        {
            get;
            set;
        }

        /// <summary>instance_1_bgp_peering_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#instance_1_bgp_peering_address VpnGateway#instance_1_bgp_peering_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instance1BgpPeeringAddress", typeJson: "{\"fqn\":\"azurerm.vpnGateway.VpnGatewayBgpSettingsInstance1BgpPeeringAddress\"}", isOptional: true)]
        public azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance1BgpPeeringAddress? Instance1BgpPeeringAddress
        {
            get;
            set;
        }
    }
}
