using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridSystemTopicEventSubscription
{
    [JsiiInterface(nativeType: typeof(IEventgridSystemTopicEventSubscriptionAdvancedFilterIsNullOrUndefined), fullyQualifiedName: "azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterIsNullOrUndefined")]
    public interface IEventgridSystemTopicEventSubscriptionAdvancedFilterIsNullOrUndefined
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#key EventgridSystemTopicEventSubscription#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridSystemTopicEventSubscriptionAdvancedFilterIsNullOrUndefined), fullyQualifiedName: "azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterIsNullOrUndefined")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilterIsNullOrUndefined
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#key EventgridSystemTopicEventSubscription#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
