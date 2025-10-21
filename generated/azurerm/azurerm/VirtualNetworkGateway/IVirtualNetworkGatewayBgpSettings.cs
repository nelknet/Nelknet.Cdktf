using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGateway
{
    [JsiiInterface(nativeType: typeof(IVirtualNetworkGatewayBgpSettings), fullyQualifiedName: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayBgpSettings")]
    public interface IVirtualNetworkGatewayBgpSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#asn VirtualNetworkGateway#asn}.</summary>
        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Asn
        {
            get
            {
                return null;
            }
        }

        /// <summary>peering_addresses block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#peering_addresses VirtualNetworkGateway#peering_addresses}
        /// </remarks>
        [JsiiProperty(name: "peeringAddresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualNetworkGateway.VirtualNetworkGatewayBgpSettingsPeeringAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PeeringAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#peer_weight VirtualNetworkGateway#peer_weight}.</summary>
        [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PeerWeight
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualNetworkGatewayBgpSettings), fullyQualifiedName: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayBgpSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#asn VirtualNetworkGateway#asn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Asn
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>peering_addresses block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#peering_addresses VirtualNetworkGateway#peering_addresses}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "peeringAddresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualNetworkGateway.VirtualNetworkGatewayBgpSettingsPeeringAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PeeringAddresses
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#peer_weight VirtualNetworkGateway#peer_weight}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PeerWeight
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
