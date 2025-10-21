using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGateway
{
    [JsiiByValue(fqn: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayCustomRoute")]
    public class VirtualNetworkGatewayCustomRoute : azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayCustomRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#address_prefixes VirtualNetworkGateway#address_prefixes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addressPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AddressPrefixes
        {
            get;
            set;
        }
    }
}
