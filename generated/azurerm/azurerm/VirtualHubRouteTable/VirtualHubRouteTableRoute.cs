using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualHubRouteTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualHubRouteTable.VirtualHubRouteTableRoute")]
    public class VirtualHubRouteTableRoute : azurerm.VirtualHubRouteTable.IVirtualHubRouteTableRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table#destinations VirtualHubRouteTable#destinations}.</summary>
        [JsiiProperty(name: "destinations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Destinations
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table#destinations_type VirtualHubRouteTable#destinations_type}.</summary>
        [JsiiProperty(name: "destinationsType", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationsType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table#name VirtualHubRouteTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table#next_hop VirtualHubRouteTable#next_hop}.</summary>
        [JsiiProperty(name: "nextHop", typeJson: "{\"primitive\":\"string\"}")]
        public string NextHop
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_route_table#next_hop_type VirtualHubRouteTable#next_hop_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nextHopType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NextHopType
        {
            get;
            set;
        }
    }
}
