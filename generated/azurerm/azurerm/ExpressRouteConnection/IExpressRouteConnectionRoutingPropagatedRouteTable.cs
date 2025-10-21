using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ExpressRouteConnection
{
    [JsiiInterface(nativeType: typeof(IExpressRouteConnectionRoutingPropagatedRouteTable), fullyQualifiedName: "azurerm.expressRouteConnection.ExpressRouteConnectionRoutingPropagatedRouteTable")]
    public interface IExpressRouteConnectionRoutingPropagatedRouteTable
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#labels ExpressRouteConnection#labels}.</summary>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Labels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#route_table_ids ExpressRouteConnection#route_table_ids}.</summary>
        [JsiiProperty(name: "routeTableIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RouteTableIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IExpressRouteConnectionRoutingPropagatedRouteTable), fullyQualifiedName: "azurerm.expressRouteConnection.ExpressRouteConnectionRoutingPropagatedRouteTable")]
        internal sealed class _Proxy : DeputyBase, azurerm.ExpressRouteConnection.IExpressRouteConnectionRoutingPropagatedRouteTable
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#labels ExpressRouteConnection#labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Labels
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#route_table_ids ExpressRouteConnection#route_table_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routeTableIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RouteTableIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
