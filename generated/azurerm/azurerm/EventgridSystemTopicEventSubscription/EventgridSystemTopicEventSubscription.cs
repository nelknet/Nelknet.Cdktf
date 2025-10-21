using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridSystemTopicEventSubscription
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription azurerm_eventgrid_system_topic_event_subscription}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscription), fullyQualifiedName: "azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscription", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionConfig\"}}]")]
    public class EventgridSystemTopicEventSubscription : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription azurerm_eventgrid_system_topic_event_subscription} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EventgridSystemTopicEventSubscription(Constructs.Construct scope, string id, azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EventgridSystemTopicEventSubscription(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EventgridSystemTopicEventSubscription(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a EventgridSystemTopicEventSubscription resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the EventgridSystemTopicEventSubscription to import.</param>
        /// <param name="importFromId">The id of the existing EventgridSystemTopicEventSubscription that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the EventgridSystemTopicEventSubscription to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the EventgridSystemTopicEventSubscription to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing EventgridSystemTopicEventSubscription that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the EventgridSystemTopicEventSubscription to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscription), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdvancedFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilter\"}}]")]
        public virtual void PutAdvancedFilter(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureFunctionEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAzureFunctionEndpoint\"}}]")]
        public virtual void PutAzureFunctionEndpoint(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAzureFunctionEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAzureFunctionEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeadLetterIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeadLetterIdentity\"}}]")]
        public virtual void PutDeadLetterIdentity(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionDeadLetterIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionDeadLetterIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeliveryIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeliveryIdentity\"}}]")]
        public virtual void PutDeliveryIdentity(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionDeliveryIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionDeliveryIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeliveryProperty", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeliveryProperty\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDeliveryProperty(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionDeliveryProperty[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionDeliveryProperty).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionDeliveryProperty).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetryPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionRetryPolicy\"}}]")]
        public virtual void PutRetryPolicy(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionRetryPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionRetryPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageBlobDeadLetterDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestination\"}}]")]
        public virtual void PutStorageBlobDeadLetterDestination(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageQueueEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionStorageQueueEndpoint\"}}]")]
        public virtual void PutStorageQueueEndpoint(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionStorageQueueEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionStorageQueueEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubjectFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionSubjectFilter\"}}]")]
        public virtual void PutSubjectFilter(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionSubjectFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionSubjectFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebhookEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionWebhookEndpoint\"}}]")]
        public virtual void PutWebhookEndpoint(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionWebhookEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionWebhookEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdvancedFilter")]
        public virtual void ResetAdvancedFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdvancedFilteringOnArraysEnabled")]
        public virtual void ResetAdvancedFilteringOnArraysEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureFunctionEndpoint")]
        public virtual void ResetAzureFunctionEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeadLetterIdentity")]
        public virtual void ResetDeadLetterIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeliveryIdentity")]
        public virtual void ResetDeliveryIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeliveryProperty")]
        public virtual void ResetDeliveryProperty()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventDeliverySchema")]
        public virtual void ResetEventDeliverySchema()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventhubEndpointId")]
        public virtual void ResetEventhubEndpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpirationTimeUtc")]
        public virtual void ResetExpirationTimeUtc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHybridConnectionEndpointId")]
        public virtual void ResetHybridConnectionEndpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludedEventTypes")]
        public virtual void ResetIncludedEventTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabels")]
        public virtual void ResetLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryPolicy")]
        public virtual void ResetRetryPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceBusQueueEndpointId")]
        public virtual void ResetServiceBusQueueEndpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceBusTopicEndpointId")]
        public virtual void ResetServiceBusTopicEndpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageBlobDeadLetterDestination")]
        public virtual void ResetStorageBlobDeadLetterDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageQueueEndpoint")]
        public virtual void ResetStorageQueueEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubjectFilter")]
        public virtual void ResetSubjectFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebhookEndpoint")]
        public virtual void ResetWebhookEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscription))!;

        [JsiiProperty(name: "advancedFilter", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterOutputReference\"}")]
        public virtual azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterOutputReference AdvancedFilter
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilterOutputReference>()!;
        }

        [JsiiProperty(name: "azureFunctionEndpoint", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAzureFunctionEndpointOutputReference\"}")]
        public virtual azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAzureFunctionEndpointOutputReference AzureFunctionEndpoint
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAzureFunctionEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "deadLetterIdentity", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeadLetterIdentityOutputReference\"}")]
        public virtual azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeadLetterIdentityOutputReference DeadLetterIdentity
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeadLetterIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "deliveryIdentity", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeliveryIdentityOutputReference\"}")]
        public virtual azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeliveryIdentityOutputReference DeliveryIdentity
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeliveryIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "deliveryProperty", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeliveryPropertyList\"}")]
        public virtual azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeliveryPropertyList DeliveryProperty
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeliveryPropertyList>()!;
        }

        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionRetryPolicyOutputReference\"}")]
        public virtual azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionRetryPolicyOutputReference RetryPolicy
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionRetryPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "storageBlobDeadLetterDestination", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestinationOutputReference\"}")]
        public virtual azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestinationOutputReference StorageBlobDeadLetterDestination
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "storageQueueEndpoint", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionStorageQueueEndpointOutputReference\"}")]
        public virtual azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionStorageQueueEndpointOutputReference StorageQueueEndpoint
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionStorageQueueEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "subjectFilter", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionSubjectFilterOutputReference\"}")]
        public virtual azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionSubjectFilterOutputReference SubjectFilter
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionSubjectFilterOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionTimeoutsOutputReference\"}")]
        public virtual azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "webhookEndpoint", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionWebhookEndpointOutputReference\"}")]
        public virtual azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionWebhookEndpointOutputReference WebhookEndpoint
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionWebhookEndpointOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedFilteringOnArraysEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AdvancedFilteringOnArraysEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedFilterInput", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilter\"}", isOptional: true)]
        public virtual azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilter? AdvancedFilterInput
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAdvancedFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureFunctionEndpointInput", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAzureFunctionEndpoint\"}", isOptional: true)]
        public virtual azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAzureFunctionEndpoint? AzureFunctionEndpointInput
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionAzureFunctionEndpoint?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deadLetterIdentityInput", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeadLetterIdentity\"}", isOptional: true)]
        public virtual azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionDeadLetterIdentity? DeadLetterIdentityInput
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionDeadLetterIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryIdentityInput", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeliveryIdentity\"}", isOptional: true)]
        public virtual azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionDeliveryIdentity? DeliveryIdentityInput
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionDeliveryIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryPropertyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeliveryProperty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DeliveryPropertyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventDeliverySchemaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventDeliverySchemaInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventhubEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventhubEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expirationTimeUtcInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExpirationTimeUtcInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hybridConnectionEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HybridConnectionEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includedEventTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IncludedEventTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LabelsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryPolicyInput", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionRetryPolicy\"}", isOptional: true)]
        public virtual azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionRetryPolicy? RetryPolicyInput
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionRetryPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceBusQueueEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceBusQueueEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceBusTopicEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceBusTopicEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageBlobDeadLetterDestinationInput", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestination\"}", isOptional: true)]
        public virtual azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestination? StorageBlobDeadLetterDestinationInput
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageQueueEndpointInput", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionStorageQueueEndpoint\"}", isOptional: true)]
        public virtual azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionStorageQueueEndpoint? StorageQueueEndpointInput
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionStorageQueueEndpoint?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectFilterInput", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionSubjectFilter\"}", isOptional: true)]
        public virtual azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionSubjectFilter? SubjectFilterInput
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionSubjectFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemTopicInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SystemTopicInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webhookEndpointInput", typeJson: "{\"fqn\":\"azurerm.eventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionWebhookEndpoint\"}", isOptional: true)]
        public virtual azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionWebhookEndpoint? WebhookEndpointInput
        {
            get => GetInstanceProperty<azurerm.EventgridSystemTopicEventSubscription.IEventgridSystemTopicEventSubscriptionWebhookEndpoint?>();
        }

        [JsiiProperty(name: "advancedFilteringOnArraysEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AdvancedFilteringOnArraysEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "eventDeliverySchema", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventDeliverySchema
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventhubEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventhubEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expirationTimeUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpirationTimeUtc
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hybridConnectionEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HybridConnectionEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includedEventTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IncludedEventTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Labels
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceBusQueueEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceBusQueueEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceBusTopicEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceBusTopicEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "systemTopic", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemTopic
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
