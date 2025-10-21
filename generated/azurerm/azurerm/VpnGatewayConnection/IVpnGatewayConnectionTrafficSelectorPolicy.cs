using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGatewayConnection
{
    [JsiiInterface(nativeType: typeof(IVpnGatewayConnectionTrafficSelectorPolicy), fullyQualifiedName: "azurerm.vpnGatewayConnection.VpnGatewayConnectionTrafficSelectorPolicy")]
    public interface IVpnGatewayConnectionTrafficSelectorPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#local_address_ranges VpnGatewayConnection#local_address_ranges}.</summary>
        [JsiiProperty(name: "localAddressRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] LocalAddressRanges
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#remote_address_ranges VpnGatewayConnection#remote_address_ranges}.</summary>
        [JsiiProperty(name: "remoteAddressRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] RemoteAddressRanges
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnGatewayConnectionTrafficSelectorPolicy), fullyQualifiedName: "azurerm.vpnGatewayConnection.VpnGatewayConnectionTrafficSelectorPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnGatewayConnection.IVpnGatewayConnectionTrafficSelectorPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#local_address_ranges VpnGatewayConnection#local_address_ranges}.</summary>
            [JsiiProperty(name: "localAddressRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] LocalAddressRanges
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#remote_address_ranges VpnGatewayConnection#remote_address_ranges}.</summary>
            [JsiiProperty(name: "remoteAddressRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] RemoteAddressRanges
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
