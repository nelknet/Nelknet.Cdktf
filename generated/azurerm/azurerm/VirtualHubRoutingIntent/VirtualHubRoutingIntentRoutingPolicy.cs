using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualHubRoutingIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualHubRoutingIntent.VirtualHubRoutingIntentRoutingPolicy")]
    public class VirtualHubRoutingIntentRoutingPolicy : azurerm.VirtualHubRoutingIntent.IVirtualHubRoutingIntentRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#destinations VirtualHubRoutingIntent#destinations}.</summary>
        [JsiiProperty(name: "destinations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Destinations
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#name VirtualHubRoutingIntent#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#next_hop VirtualHubRoutingIntent#next_hop}.</summary>
        [JsiiProperty(name: "nextHop", typeJson: "{\"primitive\":\"string\"}")]
        public string NextHop
        {
            get;
            set;
        }
    }
}
