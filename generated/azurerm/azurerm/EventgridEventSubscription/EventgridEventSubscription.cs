using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription azurerm_eventgrid_event_subscription}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.EventgridEventSubscription.EventgridEventSubscription), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscription", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionConfig\"}}]")]
    public class EventgridEventSubscription : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription azurerm_eventgrid_event_subscription} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EventgridEventSubscription(Constructs.Construct scope, string id, azurerm.EventgridEventSubscription.IEventgridEventSubscriptionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.EventgridEventSubscription.IEventgridEventSubscriptionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EventgridEventSubscription(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EventgridEventSubscription(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a EventgridEventSubscription resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the EventgridEventSubscription to import.</param>
        /// <param name="importFromId">The id of the existing EventgridEventSubscription that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the EventgridEventSubscription to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the EventgridEventSubscription to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing EventgridEventSubscription that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the EventgridEventSubscription to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.EventgridEventSubscription.EventgridEventSubscription), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdvancedFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilter\"}}]")]
        public virtual void PutAdvancedFilter(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureFunctionEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAzureFunctionEndpoint\"}}]")]
        public virtual void PutAzureFunctionEndpoint(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAzureFunctionEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAzureFunctionEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeadLetterIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeadLetterIdentity\"}}]")]
        public virtual void PutDeadLetterIdentity(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeadLetterIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeadLetterIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeliveryIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeliveryIdentity\"}}]")]
        public virtual void PutDeliveryIdentity(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeliveryIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeliveryIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeliveryProperty", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeliveryProperty\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDeliveryProperty(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeliveryProperty[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeliveryProperty).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeliveryProperty).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetryPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionRetryPolicy\"}}]")]
        public virtual void PutRetryPolicy(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionRetryPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionRetryPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageBlobDeadLetterDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionStorageBlobDeadLetterDestination\"}}]")]
        public virtual void PutStorageBlobDeadLetterDestination(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageBlobDeadLetterDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageBlobDeadLetterDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageQueueEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionStorageQueueEndpoint\"}}]")]
        public virtual void PutStorageQueueEndpoint(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageQueueEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageQueueEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubjectFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionSubjectFilter\"}}]")]
        public virtual void PutSubjectFilter(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionSubjectFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionSubjectFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebhookEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionWebhookEndpoint\"}}]")]
        public virtual void PutWebhookEndpoint(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionWebhookEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionWebhookEndpoint)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.EventgridEventSubscription.EventgridEventSubscription))!;

        [JsiiProperty(name: "advancedFilter", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterOutputReference\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterOutputReference AdvancedFilter
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterOutputReference>()!;
        }

        [JsiiProperty(name: "azureFunctionEndpoint", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAzureFunctionEndpointOutputReference\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAzureFunctionEndpointOutputReference AzureFunctionEndpoint
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAzureFunctionEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "deadLetterIdentity", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeadLetterIdentityOutputReference\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionDeadLetterIdentityOutputReference DeadLetterIdentity
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionDeadLetterIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "deliveryIdentity", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeliveryIdentityOutputReference\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionDeliveryIdentityOutputReference DeliveryIdentity
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionDeliveryIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "deliveryProperty", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeliveryPropertyList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionDeliveryPropertyList DeliveryProperty
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionDeliveryPropertyList>()!;
        }

        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionRetryPolicyOutputReference\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionRetryPolicyOutputReference RetryPolicy
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionRetryPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "storageBlobDeadLetterDestination", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionStorageBlobDeadLetterDestinationOutputReference\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionStorageBlobDeadLetterDestinationOutputReference StorageBlobDeadLetterDestination
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionStorageBlobDeadLetterDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "storageQueueEndpoint", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionStorageQueueEndpointOutputReference\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionStorageQueueEndpointOutputReference StorageQueueEndpoint
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionStorageQueueEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "subjectFilter", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionSubjectFilterOutputReference\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionSubjectFilterOutputReference SubjectFilter
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionSubjectFilterOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionTimeoutsOutputReference\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "webhookEndpoint", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionWebhookEndpointOutputReference\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionWebhookEndpointOutputReference WebhookEndpoint
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionWebhookEndpointOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedFilteringOnArraysEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AdvancedFilteringOnArraysEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedFilterInput", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilter\"}", isOptional: true)]
        public virtual azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilter? AdvancedFilterInput
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureFunctionEndpointInput", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAzureFunctionEndpoint\"}", isOptional: true)]
        public virtual azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAzureFunctionEndpoint? AzureFunctionEndpointInput
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAzureFunctionEndpoint?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deadLetterIdentityInput", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeadLetterIdentity\"}", isOptional: true)]
        public virtual azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeadLetterIdentity? DeadLetterIdentityInput
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeadLetterIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryIdentityInput", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeliveryIdentity\"}", isOptional: true)]
        public virtual azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeliveryIdentity? DeliveryIdentityInput
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeliveryIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryPropertyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeliveryProperty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "retryPolicyInput", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionRetryPolicy\"}", isOptional: true)]
        public virtual azurerm.EventgridEventSubscription.IEventgridEventSubscriptionRetryPolicy? RetryPolicyInput
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionRetryPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScopeInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "storageBlobDeadLetterDestinationInput", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionStorageBlobDeadLetterDestination\"}", isOptional: true)]
        public virtual azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageBlobDeadLetterDestination? StorageBlobDeadLetterDestinationInput
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageBlobDeadLetterDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageQueueEndpointInput", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionStorageQueueEndpoint\"}", isOptional: true)]
        public virtual azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageQueueEndpoint? StorageQueueEndpointInput
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageQueueEndpoint?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectFilterInput", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionSubjectFilter\"}", isOptional: true)]
        public virtual azurerm.EventgridEventSubscription.IEventgridEventSubscriptionSubjectFilter? SubjectFilterInput
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionSubjectFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webhookEndpointInput", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionWebhookEndpoint\"}", isOptional: true)]
        public virtual azurerm.EventgridEventSubscription.IEventgridEventSubscriptionWebhookEndpoint? WebhookEndpointInput
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionWebhookEndpoint?>();
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

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
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
    }
}
