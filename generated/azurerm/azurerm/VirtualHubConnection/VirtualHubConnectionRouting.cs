using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualHubConnection
{
    [JsiiByValue(fqn: "azurerm.virtualHubConnection.VirtualHubConnectionRouting")]
    public class VirtualHubConnectionRouting : azurerm.VirtualHubConnection.IVirtualHubConnectionRouting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#associated_route_table_id VirtualHubConnection#associated_route_table_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "associatedRouteTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AssociatedRouteTableId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#inbound_route_map_id VirtualHubConnection#inbound_route_map_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InboundRouteMapId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#outbound_route_map_id VirtualHubConnection#outbound_route_map_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outboundRouteMapId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutboundRouteMapId
        {
            get;
            set;
        }

        /// <summary>propagated_route_table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#propagated_route_table VirtualHubConnection#propagated_route_table}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "propagatedRouteTable", typeJson: "{\"fqn\":\"azurerm.virtualHubConnection.VirtualHubConnectionRoutingPropagatedRouteTable\"}", isOptional: true)]
        public azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingPropagatedRouteTable? PropagatedRouteTable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#static_vnet_local_route_override_criteria VirtualHubConnection#static_vnet_local_route_override_criteria}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "staticVnetLocalRouteOverrideCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StaticVnetLocalRouteOverrideCriteria
        {
            get;
            set;
        }

        private object? _staticVnetRoute;

        /// <summary>static_vnet_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#static_vnet_route VirtualHubConnection#static_vnet_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "staticVnetRoute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualHubConnection.VirtualHubConnectionRoutingStaticVnetRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StaticVnetRoute
        {
            get => _staticVnetRoute;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingStaticVnetRoute[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingStaticVnetRoute).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _staticVnetRoute = value;
            }
        }
    }
}
