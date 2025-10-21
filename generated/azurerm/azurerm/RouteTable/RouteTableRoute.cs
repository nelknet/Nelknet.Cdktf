using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RouteTable
{
    [JsiiByValue(fqn: "azurerm.routeTable.RouteTableRoute")]
    public class RouteTableRoute : azurerm.RouteTable.IRouteTableRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table#address_prefix RouteTable#address_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addressPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AddressPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table#name RouteTable#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table#next_hop_in_ip_address RouteTable#next_hop_in_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nextHopInIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NextHopInIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_table#next_hop_type RouteTable#next_hop_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nextHopType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NextHopType
        {
            get;
            set;
        }
    }
}
