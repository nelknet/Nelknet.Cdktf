using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGatewayConnection
{
    [JsiiInterface(nativeType: typeof(IVirtualNetworkGatewayConnectionCustomBgpAddresses), fullyQualifiedName: "azurerm.virtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionCustomBgpAddresses")]
    public interface IVirtualNetworkGatewayConnectionCustomBgpAddresses
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#primary VirtualNetworkGatewayConnection#primary}.</summary>
        [JsiiProperty(name: "primary", typeJson: "{\"primitive\":\"string\"}")]
        string Primary
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#secondary VirtualNetworkGatewayConnection#secondary}.</summary>
        [JsiiProperty(name: "secondary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Secondary
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualNetworkGatewayConnectionCustomBgpAddresses), fullyQualifiedName: "azurerm.virtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionCustomBgpAddresses")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualNetworkGatewayConnection.IVirtualNetworkGatewayConnectionCustomBgpAddresses
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#primary VirtualNetworkGatewayConnection#primary}.</summary>
            [JsiiProperty(name: "primary", typeJson: "{\"primitive\":\"string\"}")]
            public string Primary
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#secondary VirtualNetworkGatewayConnection#secondary}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Secondary
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
