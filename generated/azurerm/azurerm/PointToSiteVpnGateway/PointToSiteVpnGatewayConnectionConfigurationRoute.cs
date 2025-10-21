using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PointToSiteVpnGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoute")]
    public class PointToSiteVpnGatewayConnectionConfigurationRoute : azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#associated_route_table_id PointToSiteVpnGateway#associated_route_table_id}.</summary>
        [JsiiProperty(name: "associatedRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
        public string AssociatedRouteTableId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#inbound_route_map_id PointToSiteVpnGateway#inbound_route_map_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InboundRouteMapId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#outbound_route_map_id PointToSiteVpnGateway#outbound_route_map_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutboundRouteMapId
        {
            get;
            set;
        }

        /// <summary>propagated_route_table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#propagated_route_table PointToSiteVpnGateway#propagated_route_table}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.pointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable\"}", isOptional: true)]
        public azurerm.PointToSiteVpnGateway.IPointToSiteVpnGatewayConnectionConfigurationRoutePropagatedRouteTable? PropagatedRouteTable
        {
            get;
            set;
        }
    }
}
