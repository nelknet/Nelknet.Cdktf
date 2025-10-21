using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestVirtualNetwork
{
    [JsiiInterface(nativeType: typeof(IDevTestVirtualNetworkSubnetSharedPublicIpAddress), fullyQualifiedName: "azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddress")]
    public interface IDevTestVirtualNetworkSubnetSharedPublicIpAddress
    {
        /// <summary>allowed_ports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#allowed_ports DevTestVirtualNetwork#allowed_ports}
        /// </remarks>
        [JsiiProperty(name: "allowedPorts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowedPorts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevTestVirtualNetworkSubnetSharedPublicIpAddress), fullyQualifiedName: "azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddress")]
        internal sealed class _Proxy : DeputyBase, azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>allowed_ports block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#allowed_ports DevTestVirtualNetwork#allowed_ports}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedPorts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AllowedPorts
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
