using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridTopic
{
    [JsiiByValue(fqn: "azurerm.eventgridTopic.EventgridTopicInboundIpRule")]
    public class EventgridTopicInboundIpRule : azurerm.EventgridTopic.IEventgridTopicInboundIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#action EventgridTopic#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#ip_mask EventgridTopic#ip_mask}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipMask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpMask
        {
            get;
            set;
        }
    }
}
