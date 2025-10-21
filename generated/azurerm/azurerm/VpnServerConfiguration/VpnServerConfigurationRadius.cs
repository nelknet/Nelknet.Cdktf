using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnServerConfiguration
{
    [JsiiByValue(fqn: "azurerm.vpnServerConfiguration.VpnServerConfigurationRadius")]
    public class VpnServerConfigurationRadius : azurerm.VpnServerConfiguration.IVpnServerConfigurationRadius
    {
        private object? _clientRootCertificate;

        /// <summary>client_root_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#client_root_certificate VpnServerConfiguration#client_root_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientRootCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusClientRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ClientRootCertificate
        {
            get => _clientRootCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusClientRootCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusClientRootCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _clientRootCertificate = value;
            }
        }

        private object? _server;

        /// <summary>server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#server VpnServerConfiguration#server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "server", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Server
        {
            get => _server;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServer[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServer).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _server = value;
            }
        }

        private object? _serverRootCertificate;

        /// <summary>server_root_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#server_root_certificate VpnServerConfiguration#server_root_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverRootCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationRadiusServerRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ServerRootCertificate
        {
            get => _serverRootCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServerRootCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VpnServerConfiguration.IVpnServerConfigurationRadiusServerRootCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serverRootCertificate = value;
            }
        }
    }
}
