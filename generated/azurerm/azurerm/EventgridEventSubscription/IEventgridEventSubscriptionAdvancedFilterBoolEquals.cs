using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    [JsiiInterface(nativeType: typeof(IEventgridEventSubscriptionAdvancedFilterBoolEquals), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterBoolEquals")]
    public interface IEventgridEventSubscriptionAdvancedFilterBoolEquals
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#key EventgridEventSubscription#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#value EventgridEventSubscription#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridEventSubscriptionAdvancedFilterBoolEquals), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterBoolEquals")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterBoolEquals
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#value EventgridEventSubscription#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Value
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
