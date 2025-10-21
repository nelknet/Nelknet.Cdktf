using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridTopic
{
    [JsiiByValue(fqn: "azurerm.eventgridTopic.EventgridTopicInputMappingDefaultValues")]
    public class EventgridTopicInputMappingDefaultValues : azurerm.EventgridTopic.IEventgridTopicInputMappingDefaultValues
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#data_version EventgridTopic#data_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#event_type EventgridTopic#event_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#subject EventgridTopic#subject}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Subject
        {
            get;
            set;
        }
    }
}
