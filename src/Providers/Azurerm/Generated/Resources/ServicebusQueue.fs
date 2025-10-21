namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicebusQueueState<'Name, 'NamespaceId> = { assignments: ResizeArray<azurerm.ServicebusQueue.ServicebusQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue">azurerm_servicebus_queue</a>.
    /// </summary>
    type ServicebusQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicebusQueueState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusQueueState<Missing, Missing>)

        member _.Zero(()) : ServicebusQueueState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusQueueState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#name-1">ServicebusQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicebusQueueState<Missing, 'NamespaceId>, value: string) : ServicebusQueueState<Present, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicebusQueueState<Present, 'NamespaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#namespace_id-1">ServicebusQueue#namespace_id</a>.
        /// </summary>
        [<CustomOperation "namespace_id">]
        member _.NamespaceId(state: ServicebusQueueState<'Name, Missing>, value: string) : ServicebusQueueState<'Name, Present> =
            state.assignments.Add(fun config -> config.NamespaceId <- value)
            ({ assignments = state.assignments } : ServicebusQueueState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#auto_delete_on_idle-1">ServicebusQueue#auto_delete_on_idle</a>.
        /// </summary>
        [<CustomOperation "auto_delete_on_idle">]
        member _.AutoDeleteOnIdle(state: ServicebusQueueState<'Name, 'NamespaceId>, value: string) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.AutoDeleteOnIdle <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#batched_operations_enabled-1">ServicebusQueue#batched_operations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "batched_operations_enabled">]
        member _.BatchedOperationsEnabled(state: ServicebusQueueState<'Name, 'NamespaceId>, value: bool) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.BatchedOperationsEnabled <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#batched_operations_enabled-1">ServicebusQueue#batched_operations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "batched_operations_enabled">]
        member _.BatchedOperationsEnabled(state: ServicebusQueueState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.BatchedOperationsEnabled <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#dead_lettering_on_message_expiration-1">ServicebusQueue#dead_lettering_on_message_expiration</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dead_lettering_on_message_expiration">]
        member _.DeadLetteringOnMessageExpiration(state: ServicebusQueueState<'Name, 'NamespaceId>, value: bool) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.DeadLetteringOnMessageExpiration <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#dead_lettering_on_message_expiration-1">ServicebusQueue#dead_lettering_on_message_expiration</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dead_lettering_on_message_expiration">]
        member _.DeadLetteringOnMessageExpiration(state: ServicebusQueueState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.DeadLetteringOnMessageExpiration <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#default_message_ttl-1">ServicebusQueue#default_message_ttl</a>.
        /// </summary>
        [<CustomOperation "default_message_ttl">]
        member _.DefaultMessageTtl(state: ServicebusQueueState<'Name, 'NamespaceId>, value: string) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.DefaultMessageTtl <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#duplicate_detection_history_time_window-1">ServicebusQueue#duplicate_detection_history_time_window</a>.
        /// </summary>
        [<CustomOperation "duplicate_detection_history_time_window">]
        member _.DuplicateDetectionHistoryTimeWindow(state: ServicebusQueueState<'Name, 'NamespaceId>, value: string) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.DuplicateDetectionHistoryTimeWindow <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#express_enabled-1">ServicebusQueue#express_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "express_enabled">]
        member _.ExpressEnabled(state: ServicebusQueueState<'Name, 'NamespaceId>, value: bool) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.ExpressEnabled <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#express_enabled-1">ServicebusQueue#express_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "express_enabled">]
        member _.ExpressEnabled(state: ServicebusQueueState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.ExpressEnabled <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#forward_dead_lettered_messages_to-1">ServicebusQueue#forward_dead_lettered_messages_to</a>.
        /// </summary>
        [<CustomOperation "forward_dead_lettered_messages_to">]
        member _.ForwardDeadLetteredMessagesTo(state: ServicebusQueueState<'Name, 'NamespaceId>, value: string) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.ForwardDeadLetteredMessagesTo <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#forward_to-1">ServicebusQueue#forward_to</a>.
        /// </summary>
        [<CustomOperation "forward_to">]
        member _.ForwardTo(state: ServicebusQueueState<'Name, 'NamespaceId>, value: string) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.ForwardTo <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#id-1">ServicebusQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicebusQueueState<'Name, 'NamespaceId>, value: string) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#lock_duration-1">ServicebusQueue#lock_duration</a>.
        /// </summary>
        [<CustomOperation "lock_duration">]
        member _.LockDuration(state: ServicebusQueueState<'Name, 'NamespaceId>, value: string) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.LockDuration <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#max_delivery_count-1">ServicebusQueue#max_delivery_count</a>.
        /// </summary>
        [<CustomOperation "max_delivery_count">]
        member _.MaxDeliveryCount(state: ServicebusQueueState<'Name, 'NamespaceId>, value: double) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.MaxDeliveryCount <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#max_message_size_in_kilobytes-1">ServicebusQueue#max_message_size_in_kilobytes</a>.
        /// </summary>
        [<CustomOperation "max_message_size_in_kilobytes">]
        member _.MaxMessageSizeInKilobytes(state: ServicebusQueueState<'Name, 'NamespaceId>, value: double) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.MaxMessageSizeInKilobytes <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#max_size_in_megabytes-1">ServicebusQueue#max_size_in_megabytes</a>.
        /// </summary>
        [<CustomOperation "max_size_in_megabytes">]
        member _.MaxSizeInMegabytes(state: ServicebusQueueState<'Name, 'NamespaceId>, value: double) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.MaxSizeInMegabytes <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#partitioning_enabled-1">ServicebusQueue#partitioning_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "partitioning_enabled">]
        member _.PartitioningEnabled(state: ServicebusQueueState<'Name, 'NamespaceId>, value: bool) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.PartitioningEnabled <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#partitioning_enabled-1">ServicebusQueue#partitioning_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "partitioning_enabled">]
        member _.PartitioningEnabled(state: ServicebusQueueState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.PartitioningEnabled <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#requires_duplicate_detection-1">ServicebusQueue#requires_duplicate_detection</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "requires_duplicate_detection">]
        member _.RequiresDuplicateDetection(state: ServicebusQueueState<'Name, 'NamespaceId>, value: bool) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.RequiresDuplicateDetection <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#requires_duplicate_detection-1">ServicebusQueue#requires_duplicate_detection</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "requires_duplicate_detection">]
        member _.RequiresDuplicateDetection(state: ServicebusQueueState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.RequiresDuplicateDetection <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#requires_session-1">ServicebusQueue#requires_session</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "requires_session">]
        member _.RequiresSession(state: ServicebusQueueState<'Name, 'NamespaceId>, value: bool) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.RequiresSession <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#requires_session-1">ServicebusQueue#requires_session</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "requires_session">]
        member _.RequiresSession(state: ServicebusQueueState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.RequiresSession <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#status-1">ServicebusQueue#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: ServicebusQueueState<'Name, 'NamespaceId>, value: string) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue#timeouts-1">ServicebusQueue#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicebusQueueState<'Name, 'NamespaceId>, value: azurerm.ServicebusQueue.ServicebusQueueTimeouts) : ServicebusQueueState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicebusQueueState<'Name, 'NamespaceId>

        member _.Run(state: ServicebusQueueState<Present, Present>) : azurerm.ServicebusQueue.ServicebusQueue =
            let config = azurerm.ServicebusQueue.ServicebusQueueConfig()
            for setter in state.assignments do
                setter config
            azurerm.ServicebusQueue.ServicebusQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.servicebusQueue: missing required arguments. Must call: name, namespace_id.", 9999, IsError = true)>]
        member _.Run(_: ServicebusQueueState<_, _>) : azurerm.ServicebusQueue.ServicebusQueue =
            Unchecked.defaultof<azurerm.ServicebusQueue.ServicebusQueue>
