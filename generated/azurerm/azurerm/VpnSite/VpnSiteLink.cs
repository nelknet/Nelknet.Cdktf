using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnSite
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vpnSite.VpnSiteLink")]
    public class VpnSiteLink : azurerm.VpnSite.IVpnSiteLink
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#name VpnSite#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>bgp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#bgp VpnSite#bgp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bgp", typeJson: "{\"fqn\":\"azurerm.vpnSite.VpnSiteLinkBgp\"}", isOptional: true)]
        public azurerm.VpnSite.IVpnSiteLinkBgp? Bgp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#fqdn VpnSite#fqdn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Fqdn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#ip_address VpnSite#ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#provider_name VpnSite#provider_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProviderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#speed_in_mbps VpnSite#speed_in_mbps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "speedInMbps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SpeedInMbps
        {
            get;
            set;
        }
    }
}
