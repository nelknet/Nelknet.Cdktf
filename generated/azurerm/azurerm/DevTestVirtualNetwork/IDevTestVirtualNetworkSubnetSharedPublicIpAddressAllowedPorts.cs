using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestVirtualNetwork
{
    [JsiiInterface(nativeType: typeof(IDevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts), fullyQualifiedName: "azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts")]
    public interface IDevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#backend_port DevTestVirtualNetwork#backend_port}.</summary>
        [JsiiProperty(name: "backendPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackendPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#transport_protocol DevTestVirtualNetwork#transport_protocol}.</summary>
        [JsiiProperty(name: "transportProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransportProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts), fullyQualifiedName: "azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#backend_port DevTestVirtualNetwork#backend_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backendPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackendPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#transport_protocol DevTestVirtualNetwork#transport_protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transportProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransportProtocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
