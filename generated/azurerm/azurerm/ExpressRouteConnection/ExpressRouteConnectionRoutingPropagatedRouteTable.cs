using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ExpressRouteConnection
{
    [JsiiByValue(fqn: "azurerm.expressRouteConnection.ExpressRouteConnectionRoutingPropagatedRouteTable")]
    public class ExpressRouteConnectionRoutingPropagatedRouteTable : azurerm.ExpressRouteConnection.IExpressRouteConnectionRoutingPropagatedRouteTable
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#labels ExpressRouteConnection#labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Labels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#route_table_ids ExpressRouteConnection#route_table_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routeTableIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RouteTableIds
        {
            get;
            set;
        }
    }
}
