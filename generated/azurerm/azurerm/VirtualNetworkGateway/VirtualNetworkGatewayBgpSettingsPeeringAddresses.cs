using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGateway
{
    [JsiiByValue(fqn: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayBgpSettingsPeeringAddresses")]
    public class VirtualNetworkGatewayBgpSettingsPeeringAddresses : azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettingsPeeringAddresses
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#apipa_addresses VirtualNetworkGateway#apipa_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "apipaAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ApipaAddresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#ip_configuration_name VirtualNetworkGateway#ip_configuration_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipConfigurationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpConfigurationName
        {
            get;
            set;
        }
    }
}
