using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRootCertificate")]
    public class VirtualNetworkGatewayVpnClientConfigurationRootCertificate : azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#name VirtualNetworkGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#public_cert_data VirtualNetworkGateway#public_cert_data}.</summary>
        [JsiiProperty(name: "publicCertData", typeJson: "{\"primitive\":\"string\"}")]
        public string PublicCertData
        {
            get;
            set;
        }
    }
}
