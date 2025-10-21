using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGatewayConnection
{
    [JsiiInterface(nativeType: typeof(IVpnGatewayConnectionRouting), fullyQualifiedName: "azurerm.vpnGatewayConnection.VpnGatewayConnectionRouting")]
    public interface IVpnGatewayConnectionRouting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#associated_route_table VpnGatewayConnection#associated_route_table}.</summary>
        [JsiiProperty(name: "associatedRouteTable", typeJson: "{\"primitive\":\"string\"}")]
        string AssociatedRouteTable
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#inbound_route_map_id VpnGatewayConnection#inbound_route_map_id}.</summary>
        [JsiiProperty(name: "inboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InboundRouteMapId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#outbound_route_map_id VpnGatewayConnection#outbound_route_map_id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#propagated_route_table VpnGatewayConnection#propagated_route_table}
        /// </remarks>
        [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.vpnGatewayConnection.VpnGatewayConnectionRoutingPropagatedRouteTable\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VpnGatewayConnection.IVpnGatewayConnectionRoutingPropagatedRouteTable? PropagatedRouteTable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnGatewayConnectionRouting), fullyQualifiedName: "azurerm.vpnGatewayConnection.VpnGatewayConnectionRouting")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnGatewayConnection.IVpnGatewayConnectionRouting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#associated_route_table VpnGatewayConnection#associated_route_table}.</summary>
            [JsiiProperty(name: "associatedRouteTable", typeJson: "{\"primitive\":\"string\"}")]
            public string AssociatedRouteTable
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#inbound_route_map_id VpnGatewayConnection#inbound_route_map_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InboundRouteMapId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#outbound_route_map_id VpnGatewayConnection#outbound_route_map_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutboundRouteMapId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>propagated_route_table block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#propagated_route_table VpnGatewayConnection#propagated_route_table}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.vpnGatewayConnection.VpnGatewayConnectionRoutingPropagatedRouteTable\"}", isOptional: true)]
            public azurerm.VpnGatewayConnection.IVpnGatewayConnectionRoutingPropagatedRouteTable? PropagatedRouteTable
            {
                get => GetInstanceProperty<azurerm.VpnGatewayConnection.IVpnGatewayConnectionRoutingPropagatedRouteTable?>();
            }
        }
    }
}
