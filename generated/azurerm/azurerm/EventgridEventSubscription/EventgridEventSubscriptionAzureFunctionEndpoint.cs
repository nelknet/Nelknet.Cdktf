using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionAzureFunctionEndpoint")]
    public class EventgridEventSubscriptionAzureFunctionEndpoint : azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAzureFunctionEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#function_id EventgridEventSubscription#function_id}.</summary>
        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}")]
        public string FunctionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#max_events_per_batch EventgridEventSubscription#max_events_per_batch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxEventsPerBatch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxEventsPerBatch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#preferred_batch_size_in_kilobytes EventgridEventSubscription#preferred_batch_size_in_kilobytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredBatchSizeInKilobytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PreferredBatchSizeInKilobytes
        {
            get;
            set;
        }
    }
}
