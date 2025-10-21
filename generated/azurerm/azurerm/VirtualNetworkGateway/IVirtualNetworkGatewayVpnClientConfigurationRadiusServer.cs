using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGateway
{
    [JsiiInterface(nativeType: typeof(IVirtualNetworkGatewayVpnClientConfigurationRadiusServer), fullyQualifiedName: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRadiusServer")]
    public interface IVirtualNetworkGatewayVpnClientConfigurationRadiusServer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#address VirtualNetworkGateway#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#score VirtualNetworkGateway#score}.</summary>
        [JsiiProperty(name: "score", typeJson: "{\"primitive\":\"number\"}")]
        double Score
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#secret VirtualNetworkGateway#secret}.</summary>
        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
        string Secret
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualNetworkGatewayVpnClientConfigurationRadiusServer), fullyQualifiedName: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRadiusServer")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRadiusServer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#address VirtualNetworkGateway#address}.</summary>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#score VirtualNetworkGateway#score}.</summary>
            [JsiiProperty(name: "score", typeJson: "{\"primitive\":\"number\"}")]
            public double Score
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#secret VirtualNetworkGateway#secret}.</summary>
            [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
            public string Secret
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
