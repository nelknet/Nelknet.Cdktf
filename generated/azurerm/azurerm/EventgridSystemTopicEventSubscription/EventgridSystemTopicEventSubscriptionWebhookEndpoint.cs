using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridSystemTopicEventSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionWebhookEndpoint")]
    public class EventgridSystemTopicEventSubscriptionWebhookEndpoint : azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionWebhookEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#url EventgridSystemTopicEventSubscription#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#active_directory_app_id_or_uri EventgridSystemTopicEventSubscription#active_directory_app_id_or_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryAppIdOrUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActiveDirectoryAppIdOrUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#active_directory_tenant_id EventgridSystemTopicEventSubscription#active_directory_tenant_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryTenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActiveDirectoryTenantId
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
