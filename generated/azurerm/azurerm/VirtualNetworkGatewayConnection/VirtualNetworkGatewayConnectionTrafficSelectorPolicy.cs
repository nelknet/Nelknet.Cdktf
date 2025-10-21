using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGatewayConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionTrafficSelectorPolicy")]
    public class VirtualNetworkGatewayConnectionTrafficSelectorPolicy : azurerm.VirtualNetworkGatewayConnection.IVirtualNetworkGatewayConnectionTrafficSelectorPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#local_address_cidrs VirtualNetworkGatewayConnection#local_address_cidrs}.</summary>
        [JsiiProperty(name: "localAddressCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] LocalAddressCidrs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#remote_address_cidrs VirtualNetworkGatewayConnection#remote_address_cidrs}.</summary>
        [JsiiProperty(name: "remoteAddressCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] RemoteAddressCidrs
        {
            get;
            set;
        }
    }
}
