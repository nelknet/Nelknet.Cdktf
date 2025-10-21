using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnSite
{
    [JsiiByValue(fqn: "azurerm.vpnSite.VpnSiteO365Policy")]
    public class VpnSiteO365Policy : azurerm.VpnSite.IVpnSiteO365Policy
    {
        /// <summary>traffic_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#traffic_category VpnSite#traffic_category}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trafficCategory", typeJson: "{\"fqn\":\"azurerm.vpnSite.VpnSiteO365PolicyTrafficCategory\"}", isOptional: true)]
        public azurerm.VpnSite.IVpnSiteO365PolicyTrafficCategory? TrafficCategory
        {
            get;
            set;
        }
    }
}
