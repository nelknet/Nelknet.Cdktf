using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGatewayNatRule
{
    [JsiiInterface(nativeType: typeof(IVpnGatewayNatRuleInternalMapping), fullyQualifiedName: "azurerm.vpnGatewayNatRule.VpnGatewayNatRuleInternalMapping")]
    public interface IVpnGatewayNatRuleInternalMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#address_space VpnGatewayNatRule#address_space}.</summary>
        [JsiiProperty(name: "addressSpace", typeJson: "{\"primitive\":\"string\"}")]
        string AddressSpace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#port_range VpnGatewayNatRule#port_range}.</summary>
        [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PortRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnGatewayNatRuleInternalMapping), fullyQualifiedName: "azurerm.vpnGatewayNatRule.VpnGatewayNatRuleInternalMapping")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnGatewayNatRule.IVpnGatewayNatRuleInternalMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#address_space VpnGatewayNatRule#address_space}.</summary>
            [JsiiProperty(name: "addressSpace", typeJson: "{\"primitive\":\"string\"}")]
            public string AddressSpace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_nat_rule#port_range VpnGatewayNatRule#port_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PortRange
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
