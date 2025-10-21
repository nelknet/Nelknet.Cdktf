using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnSite
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vpnSite.VpnSiteLinkBgp")]
    public class VpnSiteLinkBgp : azurerm.VpnSite.IVpnSiteLinkBgp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#asn VpnSite#asn}.</summary>
        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}")]
        public double Asn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#peering_address VpnSite#peering_address}.</summary>
        [JsiiProperty(name: "peeringAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string PeeringAddress
        {
            get;
            set;
        }
    }
}
