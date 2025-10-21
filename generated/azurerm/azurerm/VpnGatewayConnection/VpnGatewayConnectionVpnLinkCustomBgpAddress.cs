using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGatewayConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vpnGatewayConnection.VpnGatewayConnectionVpnLinkCustomBgpAddress")]
    public class VpnGatewayConnectionVpnLinkCustomBgpAddress : azurerm.VpnGatewayConnection.IVpnGatewayConnectionVpnLinkCustomBgpAddress
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#ip_address VpnGatewayConnection#ip_address}.</summary>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string IpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#ip_configuration_id VpnGatewayConnection#ip_configuration_id}.</summary>
        [JsiiProperty(name: "ipConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public string IpConfigurationId
        {
            get;
            set;
        }
    }
}
