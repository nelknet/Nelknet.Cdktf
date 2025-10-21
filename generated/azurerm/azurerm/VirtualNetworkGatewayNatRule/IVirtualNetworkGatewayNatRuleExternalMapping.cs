using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGatewayNatRule
{
    [JsiiInterface(nativeType: typeof(IVirtualNetworkGatewayNatRuleExternalMapping), fullyQualifiedName: "azurerm.virtualNetworkGatewayNatRule.VirtualNetworkGatewayNatRuleExternalMapping")]
    public interface IVirtualNetworkGatewayNatRuleExternalMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#address_space VirtualNetworkGatewayNatRule#address_space}.</summary>
        [JsiiProperty(name: "addressSpace", typeJson: "{\"primitive\":\"string\"}")]
        string AddressSpace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#port_range VirtualNetworkGatewayNatRule#port_range}.</summary>
        [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PortRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualNetworkGatewayNatRuleExternalMapping), fullyQualifiedName: "azurerm.virtualNetworkGatewayNatRule.VirtualNetworkGatewayNatRuleExternalMapping")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualNetworkGatewayNatRule.IVirtualNetworkGatewayNatRuleExternalMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#address_space VirtualNetworkGatewayNatRule#address_space}.</summary>
            [JsiiProperty(name: "addressSpace", typeJson: "{\"primitive\":\"string\"}")]
            public string AddressSpace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_nat_rule#port_range VirtualNetworkGatewayNatRule#port_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PortRange
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
