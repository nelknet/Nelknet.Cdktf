using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGatewayConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vpnGatewayConnection.VpnGatewayConnectionRoutingPropagatedRouteTable")]
    public class VpnGatewayConnectionRoutingPropagatedRouteTable : azurerm.VpnGatewayConnection.IVpnGatewayConnectionRoutingPropagatedRouteTable
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#route_table_ids VpnGatewayConnection#route_table_ids}.</summary>
        [JsiiProperty(name: "routeTableIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] RouteTableIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#labels VpnGatewayConnection#labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Labels
        {
            get;
            set;
        }
    }
}
