using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGatewayConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vpnGatewayConnection.VpnGatewayConnectionRouting")]
    public class VpnGatewayConnectionRouting : azurerm.VpnGatewayConnection.IVpnGatewayConnectionRouting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#associated_route_table VpnGatewayConnection#associated_route_table}.</summary>
        [JsiiProperty(name: "associatedRouteTable", typeJson: "{\"primitive\":\"string\"}")]
        public string AssociatedRouteTable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#inbound_route_map_id VpnGatewayConnection#inbound_route_map_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InboundRouteMapId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#outbound_route_map_id VpnGatewayConnection#outbound_route_map_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutboundRouteMapId
        {
            get;
            set;
        }

        /// <summary>propagated_route_table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#propagated_route_table VpnGatewayConnection#propagated_route_table}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.vpnGatewayConnection.VpnGatewayConnectionRoutingPropagatedRouteTable\"}", isOptional: true)]
        public azurerm.VpnGatewayConnection.IVpnGatewayConnectionRoutingPropagatedRouteTable? PropagatedRouteTable
        {
            get;
            set;
        }
    }
}
