using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnServerConfiguration
{
    [JsiiInterface(nativeType: typeof(IVpnServerConfigurationAzureActiveDirectoryAuthentication), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationAzureActiveDirectoryAuthentication")]
    public interface IVpnServerConfigurationAzureActiveDirectoryAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#audience VpnServerConfiguration#audience}.</summary>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        string Audience
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#issuer VpnServerConfiguration#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        string Issuer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#tenant VpnServerConfiguration#tenant}.</summary>
        [JsiiProperty(name: "tenant", typeJson: "{\"primitive\":\"string\"}")]
        string Tenant
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnServerConfigurationAzureActiveDirectoryAuthentication), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationAzureActiveDirectoryAuthentication")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnServerConfiguration.IVpnServerConfigurationAzureActiveDirectoryAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#audience VpnServerConfiguration#audience}.</summary>
            [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
            public string Audience
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#issuer VpnServerConfiguration#issuer}.</summary>
            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
            public string Issuer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#tenant VpnServerConfiguration#tenant}.</summary>
            [JsiiProperty(name: "tenant", typeJson: "{\"primitive\":\"string\"}")]
            public string Tenant
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
