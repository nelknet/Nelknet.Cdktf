using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridSystemTopicEventSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionRetryPolicy")]
    public class EventgridSystemTopicEventSubscriptionRetryPolicy : azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionRetryPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#event_time_to_live EventgridSystemTopicEventSubscription#event_time_to_live}.</summary>
        [JsiiProperty(name: "eventTimeToLive", typeJson: "{\"primitive\":\"number\"}")]
        public double EventTimeToLive
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#max_delivery_attempts EventgridSystemTopicEventSubscription#max_delivery_attempts}.</summary>
        [JsiiProperty(name: "maxDeliveryAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxDeliveryAttempts
        {
            get;
            set;
        }
    }
}
