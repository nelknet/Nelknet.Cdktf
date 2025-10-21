using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    [JsiiInterface(nativeType: typeof(IEventgridEventSubscriptionConfig), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionConfig")]
    public interface IEventgridEventSubscriptionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#name EventgridEventSubscription#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#scope EventgridEventSubscription#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        /// <summary>advanced_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#advanced_filter EventgridEventSubscription#advanced_filter}
        /// </remarks>
        [JsiiProperty(name: "advancedFilter", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilter? AdvancedFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#advanced_filtering_on_arrays_enabled EventgridEventSubscription#advanced_filtering_on_arrays_enabled}.</summary>
        [JsiiProperty(name: "advancedFilteringOnArraysEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdvancedFilteringOnArraysEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>azure_function_endpoint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#azure_function_endpoint EventgridEventSubscription#azure_function_endpoint}
        /// </remarks>
        [JsiiProperty(name: "azureFunctionEndpoint", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAzureFunctionEndpoint\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAzureFunctionEndpoint? AzureFunctionEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>dead_letter_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#dead_letter_identity EventgridEventSubscription#dead_letter_identity}
        /// </remarks>
        [JsiiProperty(name: "deadLetterIdentity", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeadLetterIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeadLetterIdentity? DeadLetterIdentity
        {
            get
            {
                return null;
            }
        }

        /// <summary>delivery_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#delivery_identity EventgridEventSubscription#delivery_identity}
        /// </remarks>
        [JsiiProperty(name: "deliveryIdentity", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeliveryIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeliveryIdentity? DeliveryIdentity
        {
            get
            {
                return null;
            }
        }

        /// <summary>delivery_property block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#delivery_property EventgridEventSubscription#delivery_property}
        /// </remarks>
        [JsiiProperty(name: "deliveryProperty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeliveryProperty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeliveryProperty
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#event_delivery_schema EventgridEventSubscription#event_delivery_schema}.</summary>
        [JsiiProperty(name: "eventDeliverySchema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventDeliverySchema
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#eventhub_endpoint_id EventgridEventSubscription#eventhub_endpoint_id}.</summary>
        [JsiiProperty(name: "eventhubEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventhubEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#expiration_time_utc EventgridEventSubscription#expiration_time_utc}.</summary>
        [JsiiProperty(name: "expirationTimeUtc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpirationTimeUtc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#hybrid_connection_endpoint_id EventgridEventSubscription#hybrid_connection_endpoint_id}.</summary>
        [JsiiProperty(name: "hybridConnectionEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HybridConnectionEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#id EventgridEventSubscription#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#included_event_types EventgridEventSubscription#included_event_types}.</summary>
        [JsiiProperty(name: "includedEventTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludedEventTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#labels EventgridEventSubscription#labels}.</summary>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Labels
        {
            get
            {
                return null;
            }
        }

        /// <summary>retry_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#retry_policy EventgridEventSubscription#retry_policy}
        /// </remarks>
        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionRetryPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.EventgridEventSubscription.IEventgridEventSubscriptionRetryPolicy? RetryPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#service_bus_queue_endpoint_id EventgridEventSubscription#service_bus_queue_endpoint_id}.</summary>
        [JsiiProperty(name: "serviceBusQueueEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceBusQueueEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#service_bus_topic_endpoint_id EventgridEventSubscription#service_bus_topic_endpoint_id}.</summary>
        [JsiiProperty(name: "serviceBusTopicEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceBusTopicEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_blob_dead_letter_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#storage_blob_dead_letter_destination EventgridEventSubscription#storage_blob_dead_letter_destination}
        /// </remarks>
        [JsiiProperty(name: "storageBlobDeadLetterDestination", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionStorageBlobDeadLetterDestination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageBlobDeadLetterDestination? StorageBlobDeadLetterDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_queue_endpoint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#storage_queue_endpoint EventgridEventSubscription#storage_queue_endpoint}
        /// </remarks>
        [JsiiProperty(name: "storageQueueEndpoint", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionStorageQueueEndpoint\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageQueueEndpoint? StorageQueueEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>subject_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#subject_filter EventgridEventSubscription#subject_filter}
        /// </remarks>
        [JsiiProperty(name: "subjectFilter", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionSubjectFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.EventgridEventSubscription.IEventgridEventSubscriptionSubjectFilter? SubjectFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#timeouts EventgridEventSubscription#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.EventgridEventSubscription.IEventgridEventSubscriptionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>webhook_endpoint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#webhook_endpoint EventgridEventSubscription#webhook_endpoint}
        /// </remarks>
        [JsiiProperty(name: "webhookEndpoint", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionWebhookEndpoint\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.EventgridEventSubscription.IEventgridEventSubscriptionWebhookEndpoint? WebhookEndpoint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridEventSubscriptionConfig), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridEventSubscription.IEventgridEventSubscriptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#name EventgridEventSubscription#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#scope EventgridEventSubscription#scope}.</summary>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>advanced_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#advanced_filter EventgridEventSubscription#advanced_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "advancedFilter", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilter\"}", isOptional: true)]
            public azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilter? AdvancedFilter
            {
                get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilter?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#advanced_filtering_on_arrays_enabled EventgridEventSubscription#advanced_filtering_on_arrays_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "advancedFilteringOnArraysEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AdvancedFilteringOnArraysEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>azure_function_endpoint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#azure_function_endpoint EventgridEventSubscription#azure_function_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureFunctionEndpoint", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAzureFunctionEndpoint\"}", isOptional: true)]
            public azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAzureFunctionEndpoint? AzureFunctionEndpoint
            {
                get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAzureFunctionEndpoint?>();
            }

            /// <summary>dead_letter_identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#dead_letter_identity EventgridEventSubscription#dead_letter_identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deadLetterIdentity", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeadLetterIdentity\"}", isOptional: true)]
            public azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeadLetterIdentity? DeadLetterIdentity
            {
                get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeadLetterIdentity?>();
            }

            /// <summary>delivery_identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#delivery_identity EventgridEventSubscription#delivery_identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryIdentity", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeliveryIdentity\"}", isOptional: true)]
            public azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeliveryIdentity? DeliveryIdentity
            {
                get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionDeliveryIdentity?>();
            }

            /// <summary>delivery_property block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#delivery_property EventgridEventSubscription#delivery_property}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryProperty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionDeliveryProperty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DeliveryProperty
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#event_delivery_schema EventgridEventSubscription#event_delivery_schema}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventDeliverySchema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventDeliverySchema
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#eventhub_endpoint_id EventgridEventSubscription#eventhub_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventhubEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventhubEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#expiration_time_utc EventgridEventSubscription#expiration_time_utc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expirationTimeUtc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpirationTimeUtc
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#hybrid_connection_endpoint_id EventgridEventSubscription#hybrid_connection_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hybridConnectionEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HybridConnectionEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#id EventgridEventSubscription#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#included_event_types EventgridEventSubscription#included_event_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includedEventTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludedEventTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#labels EventgridEventSubscription#labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Labels
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>retry_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#retry_policy EventgridEventSubscription#retry_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionRetryPolicy\"}", isOptional: true)]
            public azurerm.EventgridEventSubscription.IEventgridEventSubscriptionRetryPolicy? RetryPolicy
            {
                get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionRetryPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#service_bus_queue_endpoint_id EventgridEventSubscription#service_bus_queue_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceBusQueueEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceBusQueueEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#service_bus_topic_endpoint_id EventgridEventSubscription#service_bus_topic_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceBusTopicEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceBusTopicEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>storage_blob_dead_letter_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#storage_blob_dead_letter_destination EventgridEventSubscription#storage_blob_dead_letter_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageBlobDeadLetterDestination", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionStorageBlobDeadLetterDestination\"}", isOptional: true)]
            public azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageBlobDeadLetterDestination? StorageBlobDeadLetterDestination
            {
                get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageBlobDeadLetterDestination?>();
            }

            /// <summary>storage_queue_endpoint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#storage_queue_endpoint EventgridEventSubscription#storage_queue_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageQueueEndpoint", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionStorageQueueEndpoint\"}", isOptional: true)]
            public azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageQueueEndpoint? StorageQueueEndpoint
            {
                get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionStorageQueueEndpoint?>();
            }

            /// <summary>subject_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#subject_filter EventgridEventSubscription#subject_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subjectFilter", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionSubjectFilter\"}", isOptional: true)]
            public azurerm.EventgridEventSubscription.IEventgridEventSubscriptionSubjectFilter? SubjectFilter
            {
                get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionSubjectFilter?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#timeouts EventgridEventSubscription#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionTimeouts\"}", isOptional: true)]
            public azurerm.EventgridEventSubscription.IEventgridEventSubscriptionTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionTimeouts?>();
            }

            /// <summary>webhook_endpoint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#webhook_endpoint EventgridEventSubscription#webhook_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webhookEndpoint", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionWebhookEndpoint\"}", isOptional: true)]
            public azurerm.EventgridEventSubscription.IEventgridEventSubscriptionWebhookEndpoint? WebhookEndpoint
            {
                get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionWebhookEndpoint?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
