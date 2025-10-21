using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PointToSiteVpnGateway
{
    [JsiiInterface(nativeType: typeof(IPointToSiteVpnGatewayConnectionConfiguration), fullyQualifiedName: "azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfiguration")]
    public interface IPointToSiteVpnGatewayConnectionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#name PointToSiteVpnGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>vpn_client_address_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#vpn_client_address_pool PointToSiteVpnGateway#vpn_client_address_pool}
        /// </remarks>
        [JsiiProperty(name: "vpnClientAddressPool", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool\"}")]
        azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool VpnClientAddressPool
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#internet_security_enabled PointToSiteVpnGateway#internet_security_enabled}.</summary>
        [JsiiProperty(name: "internetSecurityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InternetSecurityEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#route PointToSiteVpnGateway#route}
        /// </remarks>
        [JsiiProperty(name: "route", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoute? Route
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPointToSiteVpnGatewayConnectionConfiguration), fullyQualifiedName: "azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#name PointToSiteVpnGateway#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>vpn_client_address_pool block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#vpn_client_address_pool PointToSiteVpnGateway#vpn_client_address_pool}
            /// </remarks>
            [JsiiProperty(name: "vpnClientAddressPool", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool\"}")]
            public azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool VpnClientAddressPool
            {
                get => GetInstanceProperty<azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#internet_security_enabled PointToSiteVpnGateway#internet_security_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "internetSecurityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? InternetSecurityEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#route PointToSiteVpnGateway#route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "route", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoute\"}", isOptional: true)]
            public azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoute? Route
            {
                get => GetInstanceProperty<azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoute?>();
            }
        }
    }
}
