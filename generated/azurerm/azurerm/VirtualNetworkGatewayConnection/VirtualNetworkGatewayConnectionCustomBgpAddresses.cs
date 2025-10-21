using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGatewayConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionCustomBgpAddresses")]
    public class VirtualNetworkGatewayConnectionCustomBgpAddresses : azurerm.VirtualNetworkGatewayConnection.IVirtualNetworkGatewayConnectionCustomBgpAddresses
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#primary VirtualNetworkGatewayConnection#primary}.</summary>
        [JsiiProperty(name: "primary", typeJson: "{\"primitive\":\"string\"}")]
        public string Primary
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#secondary VirtualNetworkGatewayConnection#secondary}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secondary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Secondary
        {
            get;
            set;
        }
    }
}
