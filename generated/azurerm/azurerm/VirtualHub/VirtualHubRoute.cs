using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualHub
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualHub.VirtualHubRoute")]
    public class VirtualHubRoute : azurerm.VirtualHub.IVirtualHubRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#address_prefixes VirtualHub#address_prefixes}.</summary>
        [JsiiProperty(name: "addressPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AddressPrefixes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#next_hop_ip_address VirtualHub#next_hop_ip_address}.</summary>
        [JsiiProperty(name: "nextHopIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string NextHopIpAddress
        {
            get;
            set;
        }
    }
}
