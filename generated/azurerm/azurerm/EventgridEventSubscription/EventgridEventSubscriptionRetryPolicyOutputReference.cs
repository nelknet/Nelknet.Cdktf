using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    [JsiiClass(nativeType: typeof(azurerm.EventgridEventSubscription.EventgridEventSubscriptionRetryPolicyOutputReference), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionRetryPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EventgridEventSubscriptionRetryPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EventgridEventSubscriptionRetryPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EventgridEventSubscriptionRetryPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EventgridEventSubscriptionRetryPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventTimeToLiveInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EventTimeToLiveInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxDeliveryAttemptsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxDeliveryAttemptsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "eventTimeToLive", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EventTimeToLive
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxDeliveryAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxDeliveryAttempts
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionRetryPolicy\"}", isOptional: true)]
        public virtual azurerm.EventgridEventSubscription.IEventgridEventSubscriptionRetryPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionRetryPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
