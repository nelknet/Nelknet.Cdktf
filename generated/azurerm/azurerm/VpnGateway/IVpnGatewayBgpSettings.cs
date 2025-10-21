using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGateway
{
    [JsiiInterface(nativeType: typeof(IVpnGatewayBgpSettings), fullyQualifiedName: "azurerm.vpnGateway.VpnGatewayBgpSettings")]
    public interface IVpnGatewayBgpSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#asn VpnGateway#asn}.</summary>
        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}")]
        double Asn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#peer_weight VpnGateway#peer_weight}.</summary>
        [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}")]
        double PeerWeight
        {
            get;
        }

        /// <summary>instance_0_bgp_peering_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#instance_0_bgp_peering_address VpnGateway#instance_0_bgp_peering_address}
        /// </remarks>
        [JsiiProperty(name: "instance0BgpPeeringAddress", typeJson: "{\"fqn\":\"azurerm.vpnGateway.VpnGatewayBgpSettingsInstance0BgpPeeringAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance0BgpPeeringAddress? Instance0BgpPeeringAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_1_bgp_peering_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#instance_1_bgp_peering_address VpnGateway#instance_1_bgp_peering_address}
        /// </remarks>
        [JsiiProperty(name: "instance1BgpPeeringAddress", typeJson: "{\"fqn\":\"azurerm.vpnGateway.VpnGatewayBgpSettingsInstance1BgpPeeringAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance1BgpPeeringAddress? Instance1BgpPeeringAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnGatewayBgpSettings), fullyQualifiedName: "azurerm.vpnGateway.VpnGatewayBgpSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnGateway.IVpnGatewayBgpSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#asn VpnGateway#asn}.</summary>
            [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}")]
            public double Asn
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#peer_weight VpnGateway#peer_weight}.</summary>
            [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}")]
            public double PeerWeight
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>instance_0_bgp_peering_address block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#instance_0_bgp_peering_address VpnGateway#instance_0_bgp_peering_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instance0BgpPeeringAddress", typeJson: "{\"fqn\":\"azurerm.vpnGateway.VpnGatewayBgpSettingsInstance0BgpPeeringAddress\"}", isOptional: true)]
            public azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance0BgpPeeringAddress? Instance0BgpPeeringAddress
            {
                get => GetInstanceProperty<azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance0BgpPeeringAddress?>();
            }

            /// <summary>instance_1_bgp_peering_address block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#instance_1_bgp_peering_address VpnGateway#instance_1_bgp_peering_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instance1BgpPeeringAddress", typeJson: "{\"fqn\":\"azurerm.vpnGateway.VpnGatewayBgpSettingsInstance1BgpPeeringAddress\"}", isOptional: true)]
            public azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance1BgpPeeringAddress? Instance1BgpPeeringAddress
            {
                get => GetInstanceProperty<azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance1BgpPeeringAddress?>();
            }
        }
    }
}
