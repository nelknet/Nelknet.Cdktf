using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfiguration")]
    public class VirtualNetworkGatewayVpnClientConfiguration : azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#address_space VirtualNetworkGateway#address_space}.</summary>
        [JsiiProperty(name: "addressSpace", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AddressSpace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#aad_audience VirtualNetworkGateway#aad_audience}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aadAudience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AadAudience
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#aad_issuer VirtualNetworkGateway#aad_issuer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aadIssuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AadIssuer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#aad_tenant VirtualNetworkGateway#aad_tenant}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aadTenant", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AadTenant
        {
            get;
            set;
        }

        /// <summary>ipsec_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#ipsec_policy VirtualNetworkGateway#ipsec_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipsecPolicy", typeJson: "{\"fqn\":\"azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationIpsecPolicy\"}", isOptional: true)]
        public azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationIpsecPolicy? IpsecPolicy
        {
            get;
            set;
        }

        private object? _radiusServer;

        /// <summary>radius_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#radius_server VirtualNetworkGateway#radius_server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "radiusServer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRadiusServer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RadiusServer
        {
            get => _radiusServer;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRadiusServer[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRadiusServer).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _radiusServer = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#radius_server_address VirtualNetworkGateway#radius_server_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "radiusServerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RadiusServerAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#radius_server_secret VirtualNetworkGateway#radius_server_secret}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "radiusServerSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RadiusServerSecret
        {
            get;
            set;
        }

        private object? _revokedCertificate;

        /// <summary>revoked_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#revoked_certificate VirtualNetworkGateway#revoked_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "revokedCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRevokedCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RevokedCertificate
        {
            get => _revokedCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _revokedCertificate = value;
            }
        }

        private object? _rootCertificate;

        /// <summary>root_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#root_certificate VirtualNetworkGateway#root_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rootCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RootCertificate
        {
            get => _rootCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rootCertificate = value;
            }
        }

        private object? _virtualNetworkGatewayClientConnection;

        /// <summary>virtual_network_gateway_client_connection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#virtual_network_gateway_client_connection VirtualNetworkGateway#virtual_network_gateway_client_connection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkGatewayClientConnection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationVirtualNetworkGatewayClientConnection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VirtualNetworkGatewayClientConnection
        {
            get => _virtualNetworkGatewayClientConnection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationVirtualNetworkGatewayClientConnection[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationVirtualNetworkGatewayClientConnection).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _virtualNetworkGatewayClientConnection = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#vpn_auth_types VirtualNetworkGateway#vpn_auth_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpnAuthTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VpnAuthTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#vpn_client_protocols VirtualNetworkGateway#vpn_client_protocols}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpnClientProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VpnClientProtocols
        {
            get;
            set;
        }
    }
}
