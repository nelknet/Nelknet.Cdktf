using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    [JsiiInterface(nativeType: typeof(IEventgridEventSubscriptionAdvancedFilterIsNullOrUndefined), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNullOrUndefined")]
    public interface IEventgridEventSubscriptionAdvancedFilterIsNullOrUndefined
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#key EventgridEventSubscription#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridEventSubscriptionAdvancedFilterIsNullOrUndefined), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNullOrUndefined")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterIsNullOrUndefined
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#key EventgridEventSubscription#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
