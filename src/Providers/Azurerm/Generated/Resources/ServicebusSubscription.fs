namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> = { assignments: ResizeArray<azurerm.ServicebusSubscription.ServicebusSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription">azurerm_servicebus_subscription</a>.
    /// </summary>
    type ServicebusSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicebusSubscriptionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusSubscriptionState<Missing, Missing, Missing>)

        member _.Zero(()) : ServicebusSubscriptionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusSubscriptionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#max_delivery_count-1">ServicebusSubscription#max_delivery_count</a>.
        /// </summary>
        [<CustomOperation "max_delivery_count">]
        member _.MaxDeliveryCount(state: ServicebusSubscriptionState<Missing, 'Name, 'TopicId>, value: double) : ServicebusSubscriptionState<Present, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.MaxDeliveryCount <- value)
            ({ assignments = state.assignments } : ServicebusSubscriptionState<Present, 'Name, 'TopicId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#name-1">ServicebusSubscription#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicebusSubscriptionState<'MaxDeliveryCount, Missing, 'TopicId>, value: string) : ServicebusSubscriptionState<'MaxDeliveryCount, Present, 'TopicId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicebusSubscriptionState<'MaxDeliveryCount, Present, 'TopicId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#topic_id-1">ServicebusSubscription#topic_id</a>.
        /// </summary>
        [<CustomOperation "topic_id">]
        member _.TopicId(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, Missing>, value: string) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, Present> =
            state.assignments.Add(fun config -> config.TopicId <- value)
            ({ assignments = state.assignments } : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#auto_delete_on_idle-1">ServicebusSubscription#auto_delete_on_idle</a>.
        /// </summary>
        [<CustomOperation "auto_delete_on_idle">]
        member _.AutoDeleteOnIdle(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: string) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.AutoDeleteOnIdle <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#batched_operations_enabled-1">ServicebusSubscription#batched_operations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "batched_operations_enabled">]
        member _.BatchedOperationsEnabled(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: bool) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.BatchedOperationsEnabled <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#batched_operations_enabled-1">ServicebusSubscription#batched_operations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "batched_operations_enabled">]
        member _.BatchedOperationsEnabled(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.BatchedOperationsEnabled <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// client_scoped_subscription block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#client_scoped_subscription-1">ServicebusSubscription#client_scoped_subscription</a>
        /// </summary>
        [<CustomOperation "client_scoped_subscription">]
        member _.ClientScopedSubscription(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: azurerm.ServicebusSubscription.ServicebusSubscriptionClientScopedSubscription) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.ClientScopedSubscription <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#client_scoped_subscription_enabled-1">ServicebusSubscription#client_scoped_subscription_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_scoped_subscription_enabled">]
        member _.ClientScopedSubscriptionEnabled(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: bool) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.ClientScopedSubscriptionEnabled <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#client_scoped_subscription_enabled-1">ServicebusSubscription#client_scoped_subscription_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_scoped_subscription_enabled">]
        member _.ClientScopedSubscriptionEnabled(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.ClientScopedSubscriptionEnabled <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#dead_lettering_on_filter_evaluation_error-1">ServicebusSubscription#dead_lettering_on_filter_evaluation_error</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dead_lettering_on_filter_evaluation_error">]
        member _.DeadLetteringOnFilterEvaluationError(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: bool) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.DeadLetteringOnFilterEvaluationError <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#dead_lettering_on_filter_evaluation_error-1">ServicebusSubscription#dead_lettering_on_filter_evaluation_error</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dead_lettering_on_filter_evaluation_error">]
        member _.DeadLetteringOnFilterEvaluationError(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.DeadLetteringOnFilterEvaluationError <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#dead_lettering_on_message_expiration-1">ServicebusSubscription#dead_lettering_on_message_expiration</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dead_lettering_on_message_expiration">]
        member _.DeadLetteringOnMessageExpiration(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: bool) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.DeadLetteringOnMessageExpiration <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#dead_lettering_on_message_expiration-1">ServicebusSubscription#dead_lettering_on_message_expiration</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dead_lettering_on_message_expiration">]
        member _.DeadLetteringOnMessageExpiration(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.DeadLetteringOnMessageExpiration <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#default_message_ttl-1">ServicebusSubscription#default_message_ttl</a>.
        /// </summary>
        [<CustomOperation "default_message_ttl">]
        member _.DefaultMessageTtl(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: string) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.DefaultMessageTtl <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#forward_dead_lettered_messages_to-1">ServicebusSubscription#forward_dead_lettered_messages_to</a>.
        /// </summary>
        [<CustomOperation "forward_dead_lettered_messages_to">]
        member _.ForwardDeadLetteredMessagesTo(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: string) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.ForwardDeadLetteredMessagesTo <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#forward_to-1">ServicebusSubscription#forward_to</a>.
        /// </summary>
        [<CustomOperation "forward_to">]
        member _.ForwardTo(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: string) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.ForwardTo <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#id-1">ServicebusSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: string) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#lock_duration-1">ServicebusSubscription#lock_duration</a>.
        /// </summary>
        [<CustomOperation "lock_duration">]
        member _.LockDuration(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: string) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.LockDuration <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#requires_session-1">ServicebusSubscription#requires_session</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "requires_session">]
        member _.RequiresSession(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: bool) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.RequiresSession <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#requires_session-1">ServicebusSubscription#requires_session</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "requires_session">]
        member _.RequiresSession(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.RequiresSession <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#status-1">ServicebusSubscription#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: string) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription#timeouts-1">ServicebusSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>, value: azurerm.ServicebusSubscription.ServicebusSubscriptionTimeouts) : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicebusSubscriptionState<'MaxDeliveryCount, 'Name, 'TopicId>

        member _.Run(state: ServicebusSubscriptionState<Present, Present, Present>) : azurerm.ServicebusSubscription.ServicebusSubscription =
            let config = azurerm.ServicebusSubscription.ServicebusSubscriptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.ServicebusSubscription.ServicebusSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.servicebusSubscription: missing required arguments. Must call: max_delivery_count, name, topic_id.", 9999, IsError = true)>]
        member _.Run(_: ServicebusSubscriptionState<_, _, _>) : azurerm.ServicebusSubscription.ServicebusSubscription =
            Unchecked.defaultof<azurerm.ServicebusSubscription.ServicebusSubscription>
