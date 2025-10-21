using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnServerConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServer")]
    public class VpnServerConfigurationRadiusServer : azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#address VpnServerConfiguration#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#score VpnServerConfiguration#score}.</summary>
        [JsiiProperty(name: "score", typeJson: "{\"primitive\":\"number\"}")]
        public double Score
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#secret VpnServerConfiguration#secret}.</summary>
        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
        public string Secret
        {
            get;
            set;
        }
    }
}
