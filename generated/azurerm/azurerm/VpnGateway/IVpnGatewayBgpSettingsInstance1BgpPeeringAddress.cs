using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGateway
{
    [JsiiInterface(nativeType: typeof(IVpnGatewayBgpSettingsInstance1BgpPeeringAddress), fullyQualifiedName: "azurerm.vpnGateway.VpnGatewayBgpSettingsInstance1BgpPeeringAddress")]
    public interface IVpnGatewayBgpSettingsInstance1BgpPeeringAddress
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#custom_ips VpnGateway#custom_ips}.</summary>
        [JsiiProperty(name: "customIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CustomIps
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnGatewayBgpSettingsInstance1BgpPeeringAddress), fullyQualifiedName: "azurerm.vpnGateway.VpnGatewayBgpSettingsInstance1BgpPeeringAddress")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance1BgpPeeringAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#custom_ips VpnGateway#custom_ips}.</summary>
            [JsiiProperty(name: "customIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CustomIps
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
