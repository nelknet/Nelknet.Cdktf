using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PointToSiteVpnGateway
{
    [JsiiInterface(nativeType: typeof(IPointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable), fullyQualifiedName: "azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable")]
    public interface IPointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#ids PointToSiteVpnGateway#ids}.</summary>
        [JsiiProperty(name: "ids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Ids
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#labels PointToSiteVpnGateway#labels}.</summary>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Labels
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable), fullyQualifiedName: "azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable")]
        internal sealed class _Proxy : DeputyBase, azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#ids PointToSiteVpnGateway#ids}.</summary>
            [JsiiProperty(name: "ids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Ids
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#labels PointToSiteVpnGateway#labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Labels
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
