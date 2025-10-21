using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeliveryIdentity")]
    public class EventgridEventSubscriptionDeliveryIdentity : azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeliveryIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#type EventgridEventSubscription#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#user_assigned_identity EventgridEventSubscription#user_assigned_identity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userAssignedIdentity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAssignedIdentity
        {
            get;
            set;
        }
    }
}
