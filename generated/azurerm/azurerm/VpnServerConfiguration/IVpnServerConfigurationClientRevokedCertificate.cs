using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnServerConfiguration
{
    [JsiiInterface(nativeType: typeof(IVpnServerConfigurationClientRevokedCertificate), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationClientRevokedCertificate")]
    public interface IVpnServerConfigurationClientRevokedCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#name VpnServerConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#thumbprint VpnServerConfiguration#thumbprint}.</summary>
        [JsiiProperty(name: "thumbprint", typeJson: "{\"primitive\":\"string\"}")]
        string Thumbprint
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnServerConfigurationClientRevokedCertificate), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationClientRevokedCertificate")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnServerConfiguration.IVpnServerConfigurationClientRevokedCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#name VpnServerConfiguration#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#thumbprint VpnServerConfiguration#thumbprint}.</summary>
            [JsiiProperty(name: "thumbprint", typeJson: "{\"primitive\":\"string\"}")]
            public string Thumbprint
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
