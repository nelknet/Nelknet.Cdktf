namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicebusTopicState<'Name, 'NamespaceId> = { assignments: ResizeArray<azurerm.ServicebusTopic.ServicebusTopicConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic">azurerm_servicebus_topic</a>.
    /// </summary>
    type ServicebusTopicBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicebusTopicState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusTopicState<Missing, Missing>)

        member _.Zero(()) : ServicebusTopicState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusTopicState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#name-1">ServicebusTopic#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicebusTopicState<Missing, 'NamespaceId>, value: string) : ServicebusTopicState<Present, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicebusTopicState<Present, 'NamespaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#namespace_id-1">ServicebusTopic#namespace_id</a>.
        /// </summary>
        [<CustomOperation "namespace_id">]
        member _.NamespaceId(state: ServicebusTopicState<'Name, Missing>, value: string) : ServicebusTopicState<'Name, Present> =
            state.assignments.Add(fun config -> config.NamespaceId <- value)
            ({ assignments = state.assignments } : ServicebusTopicState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#auto_delete_on_idle-1">ServicebusTopic#auto_delete_on_idle</a>.
        /// </summary>
        [<CustomOperation "auto_delete_on_idle">]
        member _.AutoDeleteOnIdle(state: ServicebusTopicState<'Name, 'NamespaceId>, value: string) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.AutoDeleteOnIdle <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#batched_operations_enabled-1">ServicebusTopic#batched_operations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "batched_operations_enabled">]
        member _.BatchedOperationsEnabled(state: ServicebusTopicState<'Name, 'NamespaceId>, value: bool) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.BatchedOperationsEnabled <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#batched_operations_enabled-1">ServicebusTopic#batched_operations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "batched_operations_enabled">]
        member _.BatchedOperationsEnabled(state: ServicebusTopicState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.BatchedOperationsEnabled <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#default_message_ttl-1">ServicebusTopic#default_message_ttl</a>.
        /// </summary>
        [<CustomOperation "default_message_ttl">]
        member _.DefaultMessageTtl(state: ServicebusTopicState<'Name, 'NamespaceId>, value: string) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.DefaultMessageTtl <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#duplicate_detection_history_time_window-1">ServicebusTopic#duplicate_detection_history_time_window</a>.
        /// </summary>
        [<CustomOperation "duplicate_detection_history_time_window">]
        member _.DuplicateDetectionHistoryTimeWindow(state: ServicebusTopicState<'Name, 'NamespaceId>, value: string) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.DuplicateDetectionHistoryTimeWindow <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#express_enabled-1">ServicebusTopic#express_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "express_enabled">]
        member _.ExpressEnabled(state: ServicebusTopicState<'Name, 'NamespaceId>, value: bool) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.ExpressEnabled <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#express_enabled-1">ServicebusTopic#express_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "express_enabled">]
        member _.ExpressEnabled(state: ServicebusTopicState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.ExpressEnabled <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#id-1">ServicebusTopic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicebusTopicState<'Name, 'NamespaceId>, value: string) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#max_message_size_in_kilobytes-1">ServicebusTopic#max_message_size_in_kilobytes</a>.
        /// </summary>
        [<CustomOperation "max_message_size_in_kilobytes">]
        member _.MaxMessageSizeInKilobytes(state: ServicebusTopicState<'Name, 'NamespaceId>, value: double) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.MaxMessageSizeInKilobytes <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#max_size_in_megabytes-1">ServicebusTopic#max_size_in_megabytes</a>.
        /// </summary>
        [<CustomOperation "max_size_in_megabytes">]
        member _.MaxSizeInMegabytes(state: ServicebusTopicState<'Name, 'NamespaceId>, value: double) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.MaxSizeInMegabytes <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#partitioning_enabled-1">ServicebusTopic#partitioning_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "partitioning_enabled">]
        member _.PartitioningEnabled(state: ServicebusTopicState<'Name, 'NamespaceId>, value: bool) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.PartitioningEnabled <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#partitioning_enabled-1">ServicebusTopic#partitioning_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "partitioning_enabled">]
        member _.PartitioningEnabled(state: ServicebusTopicState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.PartitioningEnabled <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#requires_duplicate_detection-1">ServicebusTopic#requires_duplicate_detection</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "requires_duplicate_detection">]
        member _.RequiresDuplicateDetection(state: ServicebusTopicState<'Name, 'NamespaceId>, value: bool) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.RequiresDuplicateDetection <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#requires_duplicate_detection-1">ServicebusTopic#requires_duplicate_detection</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "requires_duplicate_detection">]
        member _.RequiresDuplicateDetection(state: ServicebusTopicState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.RequiresDuplicateDetection <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#status-1">ServicebusTopic#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: ServicebusTopicState<'Name, 'NamespaceId>, value: string) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#support_ordering-1">ServicebusTopic#support_ordering</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "support_ordering">]
        member _.SupportOrdering(state: ServicebusTopicState<'Name, 'NamespaceId>, value: bool) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.SupportOrdering <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#support_ordering-1">ServicebusTopic#support_ordering</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "support_ordering">]
        member _.SupportOrdering(state: ServicebusTopicState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.SupportOrdering <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic#timeouts-1">ServicebusTopic#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicebusTopicState<'Name, 'NamespaceId>, value: azurerm.ServicebusTopic.ServicebusTopicTimeouts) : ServicebusTopicState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicebusTopicState<'Name, 'NamespaceId>

        member _.Run(state: ServicebusTopicState<Present, Present>) : azurerm.ServicebusTopic.ServicebusTopic =
            let config = azurerm.ServicebusTopic.ServicebusTopicConfig()
            for setter in state.assignments do
                setter config
            azurerm.ServicebusTopic.ServicebusTopic(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.servicebusTopic: missing required arguments. Must call: name, namespace_id.", 9999, IsError = true)>]
        member _.Run(_: ServicebusTopicState<_, _>) : azurerm.ServicebusTopic.ServicebusTopic =
            Unchecked.defaultof<azurerm.ServicebusTopic.ServicebusTopic>
