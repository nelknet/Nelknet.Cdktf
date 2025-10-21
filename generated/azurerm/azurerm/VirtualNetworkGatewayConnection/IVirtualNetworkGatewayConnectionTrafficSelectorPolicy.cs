using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGatewayConnection
{
    [JsiiInterface(nativeType: typeof(IVirtualNetworkGatewayConnectionTrafficSelectorPolicy), fullyQualifiedName: "azurerm.virtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionTrafficSelectorPolicy")]
    public interface IVirtualNetworkGatewayConnectionTrafficSelectorPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#local_address_cidrs VirtualNetworkGatewayConnection#local_address_cidrs}.</summary>
        [JsiiProperty(name: "localAddressCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] LocalAddressCidrs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#remote_address_cidrs VirtualNetworkGatewayConnection#remote_address_cidrs}.</summary>
        [JsiiProperty(name: "remoteAddressCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] RemoteAddressCidrs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualNetworkGatewayConnectionTrafficSelectorPolicy), fullyQualifiedName: "azurerm.virtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionTrafficSelectorPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualNetworkGatewayConnection.IVirtualNetworkGatewayConnectionTrafficSelectorPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#local_address_cidrs VirtualNetworkGatewayConnection#local_address_cidrs}.</summary>
            [JsiiProperty(name: "localAddressCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] LocalAddressCidrs
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway_connection#remote_address_cidrs VirtualNetworkGatewayConnection#remote_address_cidrs}.</summary>
            [JsiiProperty(name: "remoteAddressCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] RemoteAddressCidrs
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
