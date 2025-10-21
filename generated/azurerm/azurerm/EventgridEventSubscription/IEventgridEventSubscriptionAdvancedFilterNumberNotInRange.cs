using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    [JsiiInterface(nativeType: typeof(IEventgridEventSubscriptionAdvancedFilterNumberNotInRange), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotInRange")]
    public interface IEventgridEventSubscriptionAdvancedFilterNumberNotInRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#key EventgridEventSubscription#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#values EventgridEventSubscription#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}},\"kind\":\"array\"}}]}}")]
        object Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridEventSubscriptionAdvancedFilterNumberNotInRange), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotInRange")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberNotInRange
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#values EventgridEventSubscription#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}},\"kind\":\"array\"}}]}}")]
            public object Values
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
