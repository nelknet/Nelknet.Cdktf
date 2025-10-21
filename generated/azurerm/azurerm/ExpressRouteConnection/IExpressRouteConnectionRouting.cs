using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ExpressRouteConnection
{
    [JsiiInterface(nativeType: typeof(IExpressRouteConnectionRouting), fullyQualifiedName: "azurerm.expressRouteConnection.ExpressRouteConnectionRouting")]
    public interface IExpressRouteConnectionRouting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#associated_route_table_id ExpressRouteConnection#associated_route_table_id}.</summary>
        [JsiiProperty(name: "associatedRouteTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AssociatedRouteTableId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#inbound_route_map_id ExpressRouteConnection#inbound_route_map_id}.</summary>
        [JsiiProperty(name: "inboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InboundRouteMapId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#outbound_route_map_id ExpressRouteConnection#outbound_route_map_id}.</summary>
        [JsiiProperty(name: "outboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutboundRouteMapId
        {
            get
            {
                return null;
            }
        }

        /// <summary>propagated_route_table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#propagated_route_table ExpressRouteConnection#propagated_route_table}
        /// </remarks>
        [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.expressRouteConnection.ExpressRouteConnectionRoutingPropagatedRouteTable\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ExpressRouteConnection.IExpressRouteConnectionRoutingPropagatedRouteTable? PropagatedRouteTable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IExpressRouteConnectionRouting), fullyQualifiedName: "azurerm.expressRouteConnection.ExpressRouteConnectionRouting")]
        internal sealed class _Proxy : DeputyBase, azurerm.ExpressRouteConnection.IExpressRouteConnectionRouting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#associated_route_table_id ExpressRouteConnection#associated_route_table_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "associatedRouteTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AssociatedRouteTableId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#inbound_route_map_id ExpressRouteConnection#inbound_route_map_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InboundRouteMapId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#outbound_route_map_id ExpressRouteConnection#outbound_route_map_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutboundRouteMapId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>propagated_route_table block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_connection#propagated_route_table ExpressRouteConnection#propagated_route_table}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.expressRouteConnection.ExpressRouteConnectionRoutingPropagatedRouteTable\"}", isOptional: true)]
            public azurerm.ExpressRouteConnection.IExpressRouteConnectionRoutingPropagatedRouteTable? PropagatedRouteTable
            {
                get => GetInstanceProperty<azurerm.ExpressRouteConnection.IExpressRouteConnectionRoutingPropagatedRouteTable?>();
            }
        }
    }
}
