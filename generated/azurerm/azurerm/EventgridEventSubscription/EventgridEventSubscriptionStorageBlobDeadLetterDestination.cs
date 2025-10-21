using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionStorageBlobDeadLetterDestination")]
    public class EventgridEventSubscriptionStorageBlobDeadLetterDestination : azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageBlobDeadLetterDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#storage_account_id EventgridEventSubscription#storage_account_id}.</summary>
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#storage_blob_container_name EventgridEventSubscription#storage_blob_container_name}.</summary>
        [JsiiProperty(name: "storageBlobContainerName", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageBlobContainerName
        {
            get;
            set;
        }
    }
}
