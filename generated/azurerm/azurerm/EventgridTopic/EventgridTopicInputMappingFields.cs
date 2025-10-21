using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridTopic
{
    [JsiiByValue(fqn: "azurerm.eventgridTopic.EventgridTopicInputMappingFields")]
    public class EventgridTopicInputMappingFields : azurerm.EventgridTopic.IEventgridTopicInputMappingFields
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#data_version EventgridTopic#data_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#event_time EventgridTopic#event_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventTime
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#id EventgridTopic#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_topic#topic EventgridTopic#topic}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Topic
        {
            get;
            set;
        }
    }
}
