using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnServerConfiguration
{
    [JsiiInterface(nativeType: typeof(IVpnServerConfigurationRadius), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationRadius")]
    public interface IVpnServerConfigurationRadius
    {
        /// <summary>client_root_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#client_root_certificate VpnServerConfiguration#client_root_certificate}
        /// </remarks>
        [JsiiProperty(name: "clientRootCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusClientRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClientRootCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#server VpnServerConfiguration#server}
        /// </remarks>
        [JsiiProperty(name: "server", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Server
        {
            get
            {
                return null;
            }
        }

        /// <summary>server_root_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#server_root_certificate VpnServerConfiguration#server_root_certificate}
        /// </remarks>
        [JsiiProperty(name: "serverRootCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServerRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ServerRootCertificate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnServerConfigurationRadius), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationRadius")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnServerConfiguration.IVpnServerConfigurationRadius
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>client_root_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#client_root_certificate VpnServerConfiguration#client_root_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientRootCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusClientRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ClientRootCertificate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>server block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#server VpnServerConfiguration#server}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "server", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Server
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>server_root_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#server_root_certificate VpnServerConfiguration#server_root_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverRootCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServerRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ServerRootCertificate
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
