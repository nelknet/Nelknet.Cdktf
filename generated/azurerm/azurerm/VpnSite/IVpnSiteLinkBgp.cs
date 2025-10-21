using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnSite
{
    [JsiiInterface(nativeType: typeof(IVpnSiteLinkBgp), fullyQualifiedName: "azurerm.vpnSite.VpnSiteLinkBgp")]
    public interface IVpnSiteLinkBgp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#asn VpnSite#asn}.</summary>
        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}")]
        double Asn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#peering_address VpnSite#peering_address}.</summary>
        [JsiiProperty(name: "peeringAddress", typeJson: "{\"primitive\":\"string\"}")]
        string PeeringAddress
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnSiteLinkBgp), fullyQualifiedName: "azurerm.vpnSite.VpnSiteLinkBgp")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnSite.IVpnSiteLinkBgp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#asn VpnSite#asn}.</summary>
            [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}")]
            public double Asn
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#peering_address VpnSite#peering_address}.</summary>
            [JsiiProperty(name: "peeringAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string PeeringAddress
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
