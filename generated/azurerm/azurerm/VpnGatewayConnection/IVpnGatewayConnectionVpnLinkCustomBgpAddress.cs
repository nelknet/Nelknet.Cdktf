using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGatewayConnection
{
    [JsiiInterface(nativeType: typeof(IVpnGatewayConnectionVpnLinkCustomBgpAddress), fullyQualifiedName: "azurerm.vpnGatewayConnection.VpnGatewayConnectionVpnLinkCustomBgpAddress")]
    public interface IVpnGatewayConnectionVpnLinkCustomBgpAddress
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#ip_address VpnGatewayConnection#ip_address}.</summary>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        string IpAddress
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#ip_configuration_id VpnGatewayConnection#ip_configuration_id}.</summary>
        [JsiiProperty(name: "ipConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        string IpConfigurationId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnGatewayConnectionVpnLinkCustomBgpAddress), fullyQualifiedName: "azurerm.vpnGatewayConnection.VpnGatewayConnectionVpnLinkCustomBgpAddress")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnGatewayConnection.IVpnGatewayConnectionVpnLinkCustomBgpAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#ip_address VpnGatewayConnection#ip_address}.</summary>
            [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string IpAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#ip_configuration_id VpnGatewayConnection#ip_configuration_id}.</summary>
            [JsiiProperty(name: "ipConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
            public string IpConfigurationId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
