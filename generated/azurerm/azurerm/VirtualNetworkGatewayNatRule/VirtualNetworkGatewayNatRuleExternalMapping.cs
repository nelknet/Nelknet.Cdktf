using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGatewayNatRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualNetworkGatewayNatRule.VirtualNetworkGatewayNatRuleExternalMapping")]
    public class VirtualNetworkGatewayNatRuleExternalMapping : azurerm.VirtualNetworkGatewayNatRule.IVirtualNetworkGatewayNatRuleExternalMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#address_space VirtualNetworkGatewayNatRule#address_space}.</summary>
        [JsiiProperty(name: "addressSpace", typeJson: "{\"primitive\":\"string\"}")]
        public string AddressSpace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#port_range VirtualNetworkGatewayNatRule#port_range}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PortRange
        {
            get;
            set;
        }
    }
}
