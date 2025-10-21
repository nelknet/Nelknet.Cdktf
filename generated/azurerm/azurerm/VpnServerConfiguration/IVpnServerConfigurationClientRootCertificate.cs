using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnServerConfiguration
{
    [JsiiInterface(nativeType: typeof(IVpnServerConfigurationClientRootCertificate), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationClientRootCertificate")]
    public interface IVpnServerConfigurationClientRootCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#name VpnServerConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#public_cert_data VpnServerConfiguration#public_cert_data}.</summary>
        [JsiiProperty(name: "publicCertData", typeJson: "{\"primitive\":\"string\"}")]
        string PublicCertData
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnServerConfigurationClientRootCertificate), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationClientRootCertificate")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnServerConfiguration.IVpnServerConfigurationClientRootCertificate
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#public_cert_data VpnServerConfiguration#public_cert_data}.</summary>
            [JsiiProperty(name: "publicCertData", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicCertData
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
