using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PointToSiteVpnGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool")]
    public class PointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool : azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationVpnClientAddressPool
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#address_prefixes PointToSiteVpnGateway#address_prefixes}.</summary>
        [JsiiProperty(name: "addressPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AddressPrefixes
        {
            get;
            set;
        }
    }
}
