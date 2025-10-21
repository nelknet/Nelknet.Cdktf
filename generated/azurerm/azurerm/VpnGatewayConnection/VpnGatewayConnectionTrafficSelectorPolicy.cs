using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGatewayConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vpnGatewayConnection.VpnGatewayConnectionTrafficSelectorPolicy")]
    public class VpnGatewayConnectionTrafficSelectorPolicy : azurerm.VpnGatewayConnection.IVpnGatewayConnectionTrafficSelectorPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#local_address_ranges VpnGatewayConnection#local_address_ranges}.</summary>
        [JsiiProperty(name: "localAddressRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] LocalAddressRanges
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#remote_address_ranges VpnGatewayConnection#remote_address_ranges}.</summary>
        [JsiiProperty(name: "remoteAddressRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] RemoteAddressRanges
        {
            get;
            set;
        }
    }
}
