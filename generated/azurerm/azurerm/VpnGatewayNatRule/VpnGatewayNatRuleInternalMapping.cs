using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGatewayNatRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vpnGatewayNatRule.VpnGatewayNatRuleInternalMapping")]
    public class VpnGatewayNatRuleInternalMapping : azurerm.VpnGatewayNatRule.IVpnGatewayNatRuleInternalMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#address_space VpnGatewayNatRule#address_space}.</summary>
        [JsiiProperty(name: "addressSpace", typeJson: "{\"primitive\":\"string\"}")]
        public string AddressSpace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#port_range VpnGatewayNatRule#port_range}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PortRange
        {
            get;
            set;
        }
    }
}
