using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGateway
{
    [JsiiInterface(nativeType: typeof(IVirtualNetworkGatewayVpnClientConfigurationRootCertificate), fullyQualifiedName: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRootCertificate")]
    public interface IVirtualNetworkGatewayVpnClientConfigurationRootCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#name VirtualNetworkGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#public_cert_data VirtualNetworkGateway#public_cert_data}.</summary>
        [JsiiProperty(name: "publicCertData", typeJson: "{\"primitive\":\"string\"}")]
        string PublicCertData
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualNetworkGatewayVpnClientConfigurationRootCertificate), fullyQualifiedName: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRootCertificate")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#name VirtualNetworkGateway#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#public_cert_data VirtualNetworkGateway#public_cert_data}.</summary>
            [JsiiProperty(name: "publicCertData", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicCertData
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
