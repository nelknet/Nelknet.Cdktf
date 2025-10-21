using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualHubConnection
{
    [JsiiByValue(fqn: "azurerm.virtualHubConnection.VirtualHubConnectionRoutingStaticVnetRoute")]
    public class VirtualHubConnectionRoutingStaticVnetRoute : azurerm.VirtualHubConnection.IVirtualHubConnectionRoutingStaticVnetRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#address_prefixes VirtualHubConnection#address_prefixes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addressPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AddressPrefixes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#name VirtualHubConnection#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#next_hop_ip_address VirtualHubConnection#next_hop_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nextHopIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NextHopIpAddress
        {
            get;
            set;
        }
    }
}
