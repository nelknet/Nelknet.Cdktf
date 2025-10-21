using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGateway
{
    [JsiiInterface(nativeType: typeof(IVirtualNetworkGatewayCustomRoute), fullyQualifiedName: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayCustomRoute")]
    public interface IVirtualNetworkGatewayCustomRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#address_prefixes VirtualNetworkGateway#address_prefixes}.</summary>
        [JsiiProperty(name: "addressPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AddressPrefixes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualNetworkGatewayCustomRoute), fullyQualifiedName: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayCustomRoute")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayCustomRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#address_prefixes VirtualNetworkGateway#address_prefixes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "addressPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AddressPrefixes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
