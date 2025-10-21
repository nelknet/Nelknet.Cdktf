using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    [JsiiInterface(nativeType: typeof(IEventgridEventSubscriptionStorageBlobDeadLetterDestination), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionStorageBlobDeadLetterDestination")]
    public interface IEventgridEventSubscriptionStorageBlobDeadLetterDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#storage_account_id EventgridEventSubscription#storage_account_id}.</summary>
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#storage_blob_container_name EventgridEventSubscription#storage_blob_container_name}.</summary>
        [JsiiProperty(name: "storageBlobContainerName", typeJson: "{\"primitive\":\"string\"}")]
        string StorageBlobContainerName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridEventSubscriptionStorageBlobDeadLetterDestination), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionStorageBlobDeadLetterDestination")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageBlobDeadLetterDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#storage_account_id EventgridEventSubscription#storage_account_id}.</summary>
            [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#storage_blob_container_name EventgridEventSubscription#storage_blob_container_name}.</summary>
            [JsiiProperty(name: "storageBlobContainerName", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageBlobContainerName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
