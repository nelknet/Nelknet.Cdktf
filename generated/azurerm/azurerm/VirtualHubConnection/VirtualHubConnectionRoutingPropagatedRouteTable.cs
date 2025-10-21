using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualHubConnection
{
    [JsiiByValue(fqn: "azurerm.virtualHubConnection.VirtualHubConnectionRoutingPropagatedRouteTable")]
    public class VirtualHubConnectionRoutingPropagatedRouteTable : azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingPropagatedRouteTable
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#labels VirtualHubConnection#labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Labels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#route_table_ids VirtualHubConnection#route_table_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routeTableIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RouteTableIds
        {
            get;
            set;
        }
    }
}
