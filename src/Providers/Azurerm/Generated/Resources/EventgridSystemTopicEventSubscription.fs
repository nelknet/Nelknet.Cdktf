namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> = { assignments: ResizeArray<azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription">azurerm_eventgrid_system_topic_event_subscription</a>.
    /// </summary>
    type EventgridSystemTopicEventSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventgridSystemTopicEventSubscriptionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventgridSystemTopicEventSubscriptionState<Missing, Missing, Missing>)

        member _.Zero(()) : EventgridSystemTopicEventSubscriptionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventgridSystemTopicEventSubscriptionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#name-1">EventgridSystemTopicEventSubscription#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventgridSystemTopicEventSubscriptionState<Missing, 'ResourceGroupName, 'SystemTopic>, value: string) : EventgridSystemTopicEventSubscriptionState<Present, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventgridSystemTopicEventSubscriptionState<Present, 'ResourceGroupName, 'SystemTopic>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#resource_group_name-1">EventgridSystemTopicEventSubscription#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: EventgridSystemTopicEventSubscriptionState<'Name, Missing, 'SystemTopic>, value: string) : EventgridSystemTopicEventSubscriptionState<'Name, Present, 'SystemTopic> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : EventgridSystemTopicEventSubscriptionState<'Name, Present, 'SystemTopic>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#system_topic-1">EventgridSystemTopicEventSubscription#system_topic</a>.
        /// </summary>
        [<CustomOperation "system_topic">]
        member _.SystemTopic(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, Missing>, value: string) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SystemTopic <- value)
            ({ assignments = state.assignments } : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// advanced_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#advanced_filter-1">EventgridSystemTopicEventSubscription#advanced_filter</a>
        /// </summary>
        [<CustomOperation "advanced_filter">]
        member _.AdvancedFilter(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAdvancedFilter) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.AdvancedFilter <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#advanced_filtering_on_arrays_enabled-1">EventgridSystemTopicEventSubscription#advanced_filtering_on_arrays_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "advanced_filtering_on_arrays_enabled">]
        member _.AdvancedFilteringOnArraysEnabled(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: bool) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.AdvancedFilteringOnArraysEnabled <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#advanced_filtering_on_arrays_enabled-1">EventgridSystemTopicEventSubscription#advanced_filtering_on_arrays_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "advanced_filtering_on_arrays_enabled">]
        member _.AdvancedFilteringOnArraysEnabled(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: HashiCorp.Cdktf.IResolvable) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.AdvancedFilteringOnArraysEnabled <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// azure_function_endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#azure_function_endpoint-1">EventgridSystemTopicEventSubscription#azure_function_endpoint</a>
        /// </summary>
        [<CustomOperation "azure_function_endpoint">]
        member _.AzureFunctionEndpoint(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionAzureFunctionEndpoint) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.AzureFunctionEndpoint <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// dead_letter_identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#dead_letter_identity-1">EventgridSystemTopicEventSubscription#dead_letter_identity</a>
        /// </summary>
        [<CustomOperation "dead_letter_identity">]
        member _.DeadLetterIdentity(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeadLetterIdentity) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.DeadLetterIdentity <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// delivery_identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#delivery_identity-1">EventgridSystemTopicEventSubscription#delivery_identity</a>
        /// </summary>
        [<CustomOperation "delivery_identity">]
        member _.DeliveryIdentity(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeliveryIdentity) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.DeliveryIdentity <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// delivery_property block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#delivery_property-1">EventgridSystemTopicEventSubscription#delivery_property</a> Accepts: azurerm.IResolvable | azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionDeliveryProperty[]
        /// </summary>
        [<CustomOperation "delivery_property">]
        member _.DeliveryProperty(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: HashiCorp.Cdktf.IResolvable) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.DeliveryProperty <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#event_delivery_schema-1">EventgridSystemTopicEventSubscription#event_delivery_schema</a>.
        /// </summary>
        [<CustomOperation "event_delivery_schema">]
        member _.EventDeliverySchema(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: string) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.EventDeliverySchema <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#eventhub_endpoint_id-1">EventgridSystemTopicEventSubscription#eventhub_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "eventhub_endpoint_id">]
        member _.EventhubEndpointId(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: string) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.EventhubEndpointId <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#expiration_time_utc-1">EventgridSystemTopicEventSubscription#expiration_time_utc</a>.
        /// </summary>
        [<CustomOperation "expiration_time_utc">]
        member _.ExpirationTimeUtc(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: string) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.ExpirationTimeUtc <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#hybrid_connection_endpoint_id-1">EventgridSystemTopicEventSubscription#hybrid_connection_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "hybrid_connection_endpoint_id">]
        member _.HybridConnectionEndpointId(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: string) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.HybridConnectionEndpointId <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#id-1">EventgridSystemTopicEventSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: string) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#included_event_types-1">EventgridSystemTopicEventSubscription#included_event_types</a>.
        /// </summary>
        [<CustomOperation "included_event_types">]
        member _.IncludedEventTypes(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: seq<string>) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.IncludedEventTypes <- (value |> Seq.toArray))
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#labels-1">EventgridSystemTopicEventSubscription#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: seq<string>) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.Labels <- (value |> Seq.toArray))
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// retry_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#retry_policy-1">EventgridSystemTopicEventSubscription#retry_policy</a>
        /// </summary>
        [<CustomOperation "retry_policy">]
        member _.RetryPolicy(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionRetryPolicy) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.RetryPolicy <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#service_bus_queue_endpoint_id-1">EventgridSystemTopicEventSubscription#service_bus_queue_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "service_bus_queue_endpoint_id">]
        member _.ServiceBusQueueEndpointId(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: string) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.ServiceBusQueueEndpointId <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#service_bus_topic_endpoint_id-1">EventgridSystemTopicEventSubscription#service_bus_topic_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "service_bus_topic_endpoint_id">]
        member _.ServiceBusTopicEndpointId(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: string) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.ServiceBusTopicEndpointId <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// storage_blob_dead_letter_destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#storage_blob_dead_letter_destination-1">EventgridSystemTopicEventSubscription#storage_blob_dead_letter_destination</a>
        /// </summary>
        [<CustomOperation "storage_blob_dead_letter_destination">]
        member _.StorageBlobDeadLetterDestination(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionStorageBlobDeadLetterDestination) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.StorageBlobDeadLetterDestination <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// storage_queue_endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#storage_queue_endpoint-1">EventgridSystemTopicEventSubscription#storage_queue_endpoint</a>
        /// </summary>
        [<CustomOperation "storage_queue_endpoint">]
        member _.StorageQueueEndpoint(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionStorageQueueEndpoint) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.StorageQueueEndpoint <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// subject_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#subject_filter-1">EventgridSystemTopicEventSubscription#subject_filter</a>
        /// </summary>
        [<CustomOperation "subject_filter">]
        member _.SubjectFilter(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionSubjectFilter) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.SubjectFilter <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#timeouts-1">EventgridSystemTopicEventSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionTimeouts) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        /// <summary>
        /// webhook_endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_system_topic_event_subscription#webhook_endpoint-1">EventgridSystemTopicEventSubscription#webhook_endpoint</a>
        /// </summary>
        [<CustomOperation "webhook_endpoint">]
        member _.WebhookEndpoint(state: EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>, value: azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionWebhookEndpoint) : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic> =
            state.assignments.Add(fun config -> config.WebhookEndpoint <- value)
            state : EventgridSystemTopicEventSubscriptionState<'Name, 'ResourceGroupName, 'SystemTopic>

        member _.Run(state: EventgridSystemTopicEventSubscriptionState<Present, Present, Present>) : azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscription =
            let config = azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscriptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventgridSystemTopicEventSubscription: missing required arguments. Must call: name, resource_group_name, system_topic.", 9999, IsError = true)>]
        member _.Run(_: EventgridSystemTopicEventSubscriptionState<_, _, _>) : azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscription =
            Unchecked.defaultof<azurerm.EventgridSystemTopicEventSubscription.EventgridSystemTopicEventSubscription>
