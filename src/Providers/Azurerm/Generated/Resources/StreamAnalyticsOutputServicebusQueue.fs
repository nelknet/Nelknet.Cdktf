namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> = { assignments: ResizeArray<azurerm.StreamAnalyticsOutputServicebusQueue.StreamAnalyticsOutputServicebusQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue">azurerm_stream_analytics_output_servicebus_queue</a>.
    /// </summary>
    type StreamAnalyticsOutputServicebusQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsOutputServicebusQueueState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputServicebusQueueState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsOutputServicebusQueueState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputServicebusQueueState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue#name-1">StreamAnalyticsOutputServicebusQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsOutputServicebusQueueState<Missing, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputServicebusQueueState<Present, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputServicebusQueueState<Present, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue#queue_name-1">StreamAnalyticsOutputServicebusQueue#queue_name</a>.
        /// </summary>
        [<CustomOperation "queue_name">]
        member _.QueueName(state: StreamAnalyticsOutputServicebusQueueState<'Name, Missing, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputServicebusQueueState<'Name, Present, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.QueueName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputServicebusQueueState<'Name, Present, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue#resource_group_name-1">StreamAnalyticsOutputServicebusQueue#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, Missing, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, Present, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, Present, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>)

        /// <summary>
        /// serialization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue#serialization-1">StreamAnalyticsOutputServicebusQueue#serialization</a>
        /// </summary>
        [<CustomOperation "serialization">]
        member _.Serialization(state: StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, Missing, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: azurerm.StreamAnalyticsOutputServicebusQueue.StreamAnalyticsOutputServicebusQueueSerialization) : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, Present, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Serialization <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, Present, 'ServicebusNamespace, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue#servicebus_namespace-1">StreamAnalyticsOutputServicebusQueue#servicebus_namespace</a>.
        /// </summary>
        [<CustomOperation "servicebus_namespace">]
        member _.ServicebusNamespace(state: StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, Missing, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, Present, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.ServicebusNamespace <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, Present, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue#stream_analytics_job_name-1">StreamAnalyticsOutputServicebusQueue#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, Missing>, value: string) : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, Present> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue#authentication_mode-1">StreamAnalyticsOutputServicebusQueue#authentication_mode</a>.
        /// </summary>
        [<CustomOperation "authentication_mode">]
        member _.AuthenticationMode(state: StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.AuthenticationMode <- value)
            state : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue#id-1">StreamAnalyticsOutputServicebusQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue#property_columns-1">StreamAnalyticsOutputServicebusQueue#property_columns</a>.
        /// </summary>
        [<CustomOperation "property_columns">]
        member _.PropertyColumns(state: StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: seq<string>) : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.PropertyColumns <- (value |> Seq.toArray))
            state : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue#shared_access_policy_key-1">StreamAnalyticsOutputServicebusQueue#shared_access_policy_key</a>.
        /// </summary>
        [<CustomOperation "shared_access_policy_key">]
        member _.SharedAccessPolicyKey(state: StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.SharedAccessPolicyKey <- value)
            state : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue#shared_access_policy_name-1">StreamAnalyticsOutputServicebusQueue#shared_access_policy_name</a>.
        /// </summary>
        [<CustomOperation "shared_access_policy_name">]
        member _.SharedAccessPolicyName(state: StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.SharedAccessPolicyName <- value)
            state : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue#system_property_columns-1">StreamAnalyticsOutputServicebusQueue#system_property_columns</a>.
        /// </summary>
        [<CustomOperation "system_property_columns">]
        member _.SystemPropertyColumns(state: StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: seq<string * string>) : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.SystemPropertyColumns <- dict value)
            state : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_queue#timeouts-1">StreamAnalyticsOutputServicebusQueue#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: azurerm.StreamAnalyticsOutputServicebusQueue.StreamAnalyticsOutputServicebusQueueTimeouts) : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsOutputServicebusQueueState<'Name, 'QueueName, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        member _.Run(state: StreamAnalyticsOutputServicebusQueueState<Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsOutputServicebusQueue.StreamAnalyticsOutputServicebusQueue =
            let config = azurerm.StreamAnalyticsOutputServicebusQueue.StreamAnalyticsOutputServicebusQueueConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsOutputServicebusQueue.StreamAnalyticsOutputServicebusQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsOutputServicebusQueue: missing required arguments. Must call: name, queue_name, resource_group_name, serialization, servicebus_namespace, stream_analytics_job_name.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsOutputServicebusQueueState<_, _, _, _, _, _>) : azurerm.StreamAnalyticsOutputServicebusQueue.StreamAnalyticsOutputServicebusQueue =
            Unchecked.defaultof<azurerm.StreamAnalyticsOutputServicebusQueue.StreamAnalyticsOutputServicebusQueue>
