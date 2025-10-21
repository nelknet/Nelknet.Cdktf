using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnSite
{
    [JsiiInterface(nativeType: typeof(IVpnSiteO365Policy), fullyQualifiedName: "azurerm.vpnSite.VpnSiteO365Policy")]
    public interface IVpnSiteO365Policy
    {
        /// <summary>traffic_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#traffic_category VpnSite#traffic_category}
        /// </remarks>
        [JsiiProperty(name: "trafficCategory", typeJson: "{\"fqn\":\"azurerm.vpnSite.VpnSiteO365PolicyTrafficCategory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VpnSite.IVpnSiteO365PolicyTrafficCategory? TrafficCategory
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnSiteO365Policy), fullyQualifiedName: "azurerm.vpnSite.VpnSiteO365Policy")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnSite.IVpnSiteO365Policy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>traffic_category block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#traffic_category VpnSite#traffic_category}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trafficCategory", typeJson: "{\"fqn\":\"azurerm.vpnSite.VpnSiteO365PolicyTrafficCategory\"}", isOptional: true)]
            public azurerm.VpnSite.IVpnSiteO365PolicyTrafficCategory? TrafficCategory
            {
                get => GetInstanceProperty<azurerm.VpnSite.IVpnSiteO365PolicyTrafficCategory?>();
            }
        }
    }
}
