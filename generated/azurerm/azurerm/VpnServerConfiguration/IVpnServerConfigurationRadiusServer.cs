using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnServerConfiguration
{
    [JsiiInterface(nativeType: typeof(IVpnServerConfigurationRadiusServer), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServer")]
    public interface IVpnServerConfigurationRadiusServer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#address VpnServerConfiguration#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#score VpnServerConfiguration#score}.</summary>
        [JsiiProperty(name: "score", typeJson: "{\"primitive\":\"number\"}")]
        double Score
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#secret VpnServerConfiguration#secret}.</summary>
        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
        string Secret
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnServerConfigurationRadiusServer), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServer")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#address VpnServerConfiguration#address}.</summary>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#score VpnServerConfiguration#score}.</summary>
            [JsiiProperty(name: "score", typeJson: "{\"primitive\":\"number\"}")]
            public double Score
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#secret VpnServerConfiguration#secret}.</summary>
            [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
            public string Secret
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
