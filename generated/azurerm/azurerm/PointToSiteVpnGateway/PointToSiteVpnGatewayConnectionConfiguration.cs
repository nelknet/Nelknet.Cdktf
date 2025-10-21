using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PointToSiteVpnGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfiguration")]
    public class PointToSiteVpnGatewayConnectionConfiguration : azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#name PointToSiteVpnGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>vpn_client_address_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#vpn_client_address_pool PointToSiteVpnGateway#vpn_client_address_pool}
        /// </remarks>
        [JsiiProperty(name: "vpnClientAddressPool", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool\"}")]
        public azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool VpnClientAddressPool
        {
            get;
            set;
        }

        private object? _internetSecurityEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#internet_security_enabled PointToSiteVpnGateway#internet_security_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "internetSecurityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? InternetSecurityEnabled
        {
            get => _internetSecurityEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _internetSecurityEnabled = value;
            }
        }

        /// <summary>route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#route PointToSiteVpnGateway#route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "route", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoute\"}", isOptional: true)]
        public azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoute? Route
        {
            get;
            set;
        }
    }
}
