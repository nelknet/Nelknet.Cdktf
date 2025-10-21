using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridSystemTopicEventSubscription
{
    [JsiiClass(nativeType: typeof(azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionWebhookEndpointOutputReference), fullyQualifiedName: "azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionWebhookEndpointOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EventgridSystemTopicEventSubscriptionWebhookEndpointOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EventgridSystemTopicEventSubscriptionWebhookEndpointOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EventgridSystemTopicEventSubscriptionWebhookEndpointOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EventgridSystemTopicEventSubscriptionWebhookEndpointOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetActiveDirectoryAppIdOrUri")]
        public virtual void ResetActiveDirectoryAppIdOrUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetActiveDirectoryTenantId")]
        public virtual void ResetActiveDirectoryTenantId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxEventsPerBatch")]
        public virtual void ResetMaxEventsPerBatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferredBatchSizeInKilobytes")]
        public virtual void ResetPreferredBatchSizeInKilobytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "baseUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryAppIdOrUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActiveDirectoryAppIdOrUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryTenantIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActiveDirectoryTenantIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxEventsPerBatchInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxEventsPerBatchInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredBatchSizeInKilobytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PreferredBatchSizeInKilobytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "activeDirectoryAppIdOrUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActiveDirectoryAppIdOrUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "activeDirectoryTenantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActiveDirectoryTenantId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxEventsPerBatch", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxEventsPerBatch
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preferredBatchSizeInKilobytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PreferredBatchSizeInKilobytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionWebhookEndpoint\"}", isOptional: true)]
        public virtual azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionWebhookEndpoint? InternalValue
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionWebhookEndpoint?>();
            set => SetInstanceProperty(value);
        }
    }
}
