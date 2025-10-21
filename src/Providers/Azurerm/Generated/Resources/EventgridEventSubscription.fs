namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventgridEventSubscriptionState<'Name, 'Scope> = { assignments: ResizeArray<azurerm.EventgridEventSubscription.EventgridEventSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription">azurerm_eventgrid_event_subscription</a>.
    /// </summary>
    type EventgridEventSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventgridEventSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EventgridEventSubscriptionState<Missing, Missing>)

        member _.Zero(()) : EventgridEventSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EventgridEventSubscriptionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#name-1">EventgridEventSubscription#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventgridEventSubscriptionState<Missing, 'Scope>, value: string) : EventgridEventSubscriptionState<Present, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventgridEventSubscriptionState<Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#scope-1">EventgridEventSubscription#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: EventgridEventSubscriptionState<'Name, Missing>, value: string) : EventgridEventSubscriptionState<'Name, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : EventgridEventSubscriptionState<'Name, Present>)

        /// <summary>
        /// advanced_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#advanced_filter-1">EventgridEventSubscription#advanced_filter</a>
        /// </summary>
        [<CustomOperation "advanced_filter">]
        member _.AdvancedFilter(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilter) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.AdvancedFilter <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#advanced_filtering_on_arrays_enabled-1">EventgridEventSubscription#advanced_filtering_on_arrays_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "advanced_filtering_on_arrays_enabled">]
        member _.AdvancedFilteringOnArraysEnabled(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: bool) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.AdvancedFilteringOnArraysEnabled <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#advanced_filtering_on_arrays_enabled-1">EventgridEventSubscription#advanced_filtering_on_arrays_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "advanced_filtering_on_arrays_enabled">]
        member _.AdvancedFilteringOnArraysEnabled(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: HashiCorp.Cdktf.IResolvable) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.AdvancedFilteringOnArraysEnabled <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// azure_function_endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#azure_function_endpoint-1">EventgridEventSubscription#azure_function_endpoint</a>
        /// </summary>
        [<CustomOperation "azure_function_endpoint">]
        member _.AzureFunctionEndpoint(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: azurerm.EventgridEventSubscription.EventgridEventSubscriptionAzureFunctionEndpoint) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.AzureFunctionEndpoint <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// dead_letter_identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#dead_letter_identity-1">EventgridEventSubscription#dead_letter_identity</a>
        /// </summary>
        [<CustomOperation "dead_letter_identity">]
        member _.DeadLetterIdentity(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: azurerm.EventgridEventSubscription.EventgridEventSubscriptionDeadLetterIdentity) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.DeadLetterIdentity <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// delivery_identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#delivery_identity-1">EventgridEventSubscription#delivery_identity</a>
        /// </summary>
        [<CustomOperation "delivery_identity">]
        member _.DeliveryIdentity(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: azurerm.EventgridEventSubscription.EventgridEventSubscriptionDeliveryIdentity) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.DeliveryIdentity <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// delivery_property block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#delivery_property-1">EventgridEventSubscription#delivery_property</a> Accepts: azurerm.IResolvable | azurerm.EventgridEventSubscription.EventgridEventSubscriptionDeliveryProperty[]
        /// </summary>
        [<CustomOperation "delivery_property">]
        member _.DeliveryProperty(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: HashiCorp.Cdktf.IResolvable) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.DeliveryProperty <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#event_delivery_schema-1">EventgridEventSubscription#event_delivery_schema</a>.
        /// </summary>
        [<CustomOperation "event_delivery_schema">]
        member _.EventDeliverySchema(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: string) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.EventDeliverySchema <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#eventhub_endpoint_id-1">EventgridEventSubscription#eventhub_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "eventhub_endpoint_id">]
        member _.EventhubEndpointId(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: string) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.EventhubEndpointId <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#expiration_time_utc-1">EventgridEventSubscription#expiration_time_utc</a>.
        /// </summary>
        [<CustomOperation "expiration_time_utc">]
        member _.ExpirationTimeUtc(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: string) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.ExpirationTimeUtc <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#hybrid_connection_endpoint_id-1">EventgridEventSubscription#hybrid_connection_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "hybrid_connection_endpoint_id">]
        member _.HybridConnectionEndpointId(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: string) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.HybridConnectionEndpointId <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#id-1">EventgridEventSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: string) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#included_event_types-1">EventgridEventSubscription#included_event_types</a>.
        /// </summary>
        [<CustomOperation "included_event_types">]
        member _.IncludedEventTypes(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: seq<string>) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.IncludedEventTypes <- (value |> Seq.toArray))
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#labels-1">EventgridEventSubscription#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: seq<string>) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Labels <- (value |> Seq.toArray))
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// retry_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#retry_policy-1">EventgridEventSubscription#retry_policy</a>
        /// </summary>
        [<CustomOperation "retry_policy">]
        member _.RetryPolicy(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: azurerm.EventgridEventSubscription.EventgridEventSubscriptionRetryPolicy) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.RetryPolicy <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#service_bus_queue_endpoint_id-1">EventgridEventSubscription#service_bus_queue_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "service_bus_queue_endpoint_id">]
        member _.ServiceBusQueueEndpointId(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: string) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.ServiceBusQueueEndpointId <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#service_bus_topic_endpoint_id-1">EventgridEventSubscription#service_bus_topic_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "service_bus_topic_endpoint_id">]
        member _.ServiceBusTopicEndpointId(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: string) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.ServiceBusTopicEndpointId <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// storage_blob_dead_letter_destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#storage_blob_dead_letter_destination-1">EventgridEventSubscription#storage_blob_dead_letter_destination</a>
        /// </summary>
        [<CustomOperation "storage_blob_dead_letter_destination">]
        member _.StorageBlobDeadLetterDestination(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: azurerm.EventgridEventSubscription.EventgridEventSubscriptionStorageBlobDeadLetterDestination) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.StorageBlobDeadLetterDestination <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// storage_queue_endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#storage_queue_endpoint-1">EventgridEventSubscription#storage_queue_endpoint</a>
        /// </summary>
        [<CustomOperation "storage_queue_endpoint">]
        member _.StorageQueueEndpoint(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: azurerm.EventgridEventSubscription.EventgridEventSubscriptionStorageQueueEndpoint) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.StorageQueueEndpoint <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// subject_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#subject_filter-1">EventgridEventSubscription#subject_filter</a>
        /// </summary>
        [<CustomOperation "subject_filter">]
        member _.SubjectFilter(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: azurerm.EventgridEventSubscription.EventgridEventSubscriptionSubjectFilter) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.SubjectFilter <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#timeouts-1">EventgridEventSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: azurerm.EventgridEventSubscription.EventgridEventSubscriptionTimeouts) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        /// <summary>
        /// webhook_endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_event_subscription#webhook_endpoint-1">EventgridEventSubscription#webhook_endpoint</a>
        /// </summary>
        [<CustomOperation "webhook_endpoint">]
        member _.WebhookEndpoint(state: EventgridEventSubscriptionState<'Name, 'Scope>, value: azurerm.EventgridEventSubscription.EventgridEventSubscriptionWebhookEndpoint) : EventgridEventSubscriptionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.WebhookEndpoint <- value)
            state : EventgridEventSubscriptionState<'Name, 'Scope>

        member _.Run(state: EventgridEventSubscriptionState<Present, Present>) : azurerm.EventgridEventSubscription.EventgridEventSubscription =
            let config = azurerm.EventgridEventSubscription.EventgridEventSubscriptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventgridEventSubscription.EventgridEventSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventgridEventSubscription: missing required arguments. Must call: name, scope.", 9999, IsError = true)>]
        member _.Run(_: EventgridEventSubscriptionState<_, _>) : azurerm.EventgridEventSubscription.EventgridEventSubscription =
            Unchecked.defaultof<azurerm.EventgridEventSubscription.EventgridEventSubscription>
