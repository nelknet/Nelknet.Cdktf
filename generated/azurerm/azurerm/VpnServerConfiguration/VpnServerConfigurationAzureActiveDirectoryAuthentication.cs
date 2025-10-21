using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnServerConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vpnServerConfiguration.VpnServerConfigurationAzureActiveDirectoryAuthentication")]
    public class VpnServerConfigurationAzureActiveDirectoryAuthentication : azurerm.VpnServerConfiguration.IVpnServerConfigurationAzureActiveDirectoryAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#audience VpnServerConfiguration#audience}.</summary>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        public string Audience
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#issuer VpnServerConfiguration#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public string Issuer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#tenant VpnServerConfiguration#tenant}.</summary>
        [JsiiProperty(name: "tenant", typeJson: "{\"primitive\":\"string\"}")]
        public string Tenant
        {
            get;
            set;
        }
    }
}
