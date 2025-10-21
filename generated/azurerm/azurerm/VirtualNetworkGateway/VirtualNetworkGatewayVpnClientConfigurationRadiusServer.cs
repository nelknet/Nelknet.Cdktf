using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRadiusServer")]
    public class VirtualNetworkGatewayVpnClientConfigurationRadiusServer : azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRadiusServer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#address VirtualNetworkGateway#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#score VirtualNetworkGateway#score}.</summary>
        [JsiiProperty(name: "score", typeJson: "{\"primitive\":\"number\"}")]
        public double Score
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#secret VirtualNetworkGateway#secret}.</summary>
        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
        public string Secret
        {
            get;
            set;
        }
    }
}
