using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualHubConnection
{
    [JsiiInterface(nativeType: typeof(IVirtualHubConnectionRouting), fullyQualifiedName: "azurerm.virtualHubConnection.VirtualHubConnectionRouting")]
    public interface IVirtualHubConnectionRouting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#associated_route_table_id VirtualHubConnection#associated_route_table_id}.</summary>
        [JsiiProperty(name: "associatedRouteTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AssociatedRouteTableId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#inbound_route_map_id VirtualHubConnection#inbound_route_map_id}.</summary>
        [JsiiProperty(name: "inboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InboundRouteMapId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#outbound_route_map_id VirtualHubConnection#outbound_route_map_id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#propagated_route_table VirtualHubConnection#propagated_route_table}
        /// </remarks>
        [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.virtualHubConnection.VirtualHubConnectionRoutingPropagatedRouteTable\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingPropagatedRouteTable? PropagatedRouteTable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#static_vnet_local_route_override_criteria VirtualHubConnection#static_vnet_local_route_override_criteria}.</summary>
        [JsiiProperty(name: "staticVnetLocalRouteOverrideCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StaticVnetLocalRouteOverrideCriteria
        {
            get
            {
                return null;
            }
        }

        /// <summary>static_vnet_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#static_vnet_route VirtualHubConnection#static_vnet_route}
        /// </remarks>
        [JsiiProperty(name: "staticVnetRoute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualHubConnection.VirtualHubConnectionRoutingStaticVnetRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StaticVnetRoute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualHubConnectionRouting), fullyQualifiedName: "azurerm.virtualHubConnection.VirtualHubConnectionRouting")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualHubConnection.IVirtualHubConnectionRouting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#associated_route_table_id VirtualHubConnection#associated_route_table_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "associatedRouteTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AssociatedRouteTableId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#inbound_route_map_id VirtualHubConnection#inbound_route_map_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InboundRouteMapId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#outbound_route_map_id VirtualHubConnection#outbound_route_map_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutboundRouteMapId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>propagated_route_table block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#propagated_route_table VirtualHubConnection#propagated_route_table}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.virtualHubConnection.VirtualHubConnectionRoutingPropagatedRouteTable\"}", isOptional: true)]
            public azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingPropagatedRouteTable? PropagatedRouteTable
            {
                get => GetInstanceProperty<azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingPropagatedRouteTable?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#static_vnet_local_route_override_criteria VirtualHubConnection#static_vnet_local_route_override_criteria}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "staticVnetLocalRouteOverrideCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StaticVnetLocalRouteOverrideCriteria
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>static_vnet_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#static_vnet_route VirtualHubConnection#static_vnet_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "staticVnetRoute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualHubConnection.VirtualHubConnectionRoutingStaticVnetRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StaticVnetRoute
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
