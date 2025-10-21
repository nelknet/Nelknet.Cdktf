using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    [JsiiInterface(nativeType: typeof(IEventgridEventSubscriptionRetryPolicy), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionRetryPolicy")]
    public interface IEventgridEventSubscriptionRetryPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#event_time_to_live EventgridEventSubscription#event_time_to_live}.</summary>
        [JsiiProperty(name: "eventTimeToLive", typeJson: "{\"primitive\":\"number\"}")]
        double EventTimeToLive
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#max_delivery_attempts EventgridEventSubscription#max_delivery_attempts}.</summary>
        [JsiiProperty(name: "maxDeliveryAttempts", typeJson: "{\"primitive\":\"number\"}")]
        double MaxDeliveryAttempts
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridEventSubscriptionRetryPolicy), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionRetryPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridEventSubscription.IEventgridEventSubscriptionRetryPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#event_time_to_live EventgridEventSubscription#event_time_to_live}.</summary>
            [JsiiProperty(name: "eventTimeToLive", typeJson: "{\"primitive\":\"number\"}")]
            public double EventTimeToLive
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#max_delivery_attempts EventgridEventSubscription#max_delivery_attempts}.</summary>
            [JsiiProperty(name: "maxDeliveryAttempts", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxDeliveryAttempts
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
