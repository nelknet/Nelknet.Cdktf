using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridSystemTopicEventSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAzureFunctionEndpoint")]
    public class EventgridSystemTopicEventSubscriptionAzureFunctionEndpoint : azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAzureFunctionEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#function_id EventgridSystemTopicEventSubscription#function_id}.</summary>
        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}")]
        public string FunctionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#max_events_per_batch EventgridSystemTopicEventSubscription#max_events_per_batch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxEventsPerBatch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxEventsPerBatch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#preferred_batch_size_in_kilobytes EventgridSystemTopicEventSubscription#preferred_batch_size_in_kilobytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredBatchSizeInKilobytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PreferredBatchSizeInKilobytes
        {
            get;
            set;
        }
    }
}
