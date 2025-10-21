using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnServerConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vpnServerConfiguration.VpnServerConfigurationClientRootCertificate")]
    public class VpnServerConfigurationClientRootCertificate : azurerm.VpnServerConfiguration.IVpnServerConfigurationClientRootCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#name VpnServerConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#public_cert_data VpnServerConfiguration#public_cert_data}.</summary>
        [JsiiProperty(name: "publicCertData", typeJson: "{\"primitive\":\"string\"}")]
        public string PublicCertData
        {
            get;
            set;
        }
    }
}
