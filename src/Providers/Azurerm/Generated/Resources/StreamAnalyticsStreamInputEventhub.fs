namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> = { assignments: ResizeArray<azurerm.StreamAnalyticsStreamInputEventhub.StreamAnalyticsStreamInputEventhubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub">azurerm_stream_analytics_stream_input_eventhub</a>.
    /// </summary>
    type StreamAnalyticsStreamInputEventhubBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsStreamInputEventhubState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsStreamInputEventhubState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsStreamInputEventhubState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsStreamInputEventhubState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub#eventhub_name-1">StreamAnalyticsStreamInputEventhub#eventhub_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_name">]
        member _.EventhubName(state: StreamAnalyticsStreamInputEventhubState<Missing, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputEventhubState<Present, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.EventhubName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputEventhubState<Present, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub#name-1">StreamAnalyticsStreamInputEventhub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsStreamInputEventhubState<'EventhubName, Missing, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputEventhubState<'EventhubName, Present, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputEventhubState<'EventhubName, Present, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub#resource_group_name-1">StreamAnalyticsStreamInputEventhub#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, Missing, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, Present, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, Present, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>)

        /// <summary>
        /// serialization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub#serialization-1">StreamAnalyticsStreamInputEventhub#serialization</a>
        /// </summary>
        [<CustomOperation "serialization">]
        member _.Serialization(state: StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, Missing, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: azurerm.StreamAnalyticsStreamInputEventhub.StreamAnalyticsStreamInputEventhubSerialization) : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, Present, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Serialization <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, Present, 'ServicebusNamespace, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub#servicebus_namespace-1">StreamAnalyticsStreamInputEventhub#servicebus_namespace</a>.
        /// </summary>
        [<CustomOperation "servicebus_namespace">]
        member _.ServicebusNamespace(state: StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, Missing, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, Present, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.ServicebusNamespace <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, Present, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub#stream_analytics_job_name-1">StreamAnalyticsStreamInputEventhub#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, Missing>, value: string) : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, Present> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub#authentication_mode-1">StreamAnalyticsStreamInputEventhub#authentication_mode</a>.
        /// </summary>
        [<CustomOperation "authentication_mode">]
        member _.AuthenticationMode(state: StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.AuthenticationMode <- value)
            state : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub#eventhub_consumer_group_name-1">StreamAnalyticsStreamInputEventhub#eventhub_consumer_group_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_consumer_group_name">]
        member _.EventhubConsumerGroupName(state: StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.EventhubConsumerGroupName <- value)
            state : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub#id-1">StreamAnalyticsStreamInputEventhub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub#partition_key-1">StreamAnalyticsStreamInputEventhub#partition_key</a>.
        /// </summary>
        [<CustomOperation "partition_key">]
        member _.PartitionKey(state: StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.PartitionKey <- value)
            state : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub#shared_access_policy_key-1">StreamAnalyticsStreamInputEventhub#shared_access_policy_key</a>.
        /// </summary>
        [<CustomOperation "shared_access_policy_key">]
        member _.SharedAccessPolicyKey(state: StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.SharedAccessPolicyKey <- value)
            state : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub#shared_access_policy_name-1">StreamAnalyticsStreamInputEventhub#shared_access_policy_name</a>.
        /// </summary>
        [<CustomOperation "shared_access_policy_name">]
        member _.SharedAccessPolicyName(state: StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.SharedAccessPolicyName <- value)
            state : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub#timeouts-1">StreamAnalyticsStreamInputEventhub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: azurerm.StreamAnalyticsStreamInputEventhub.StreamAnalyticsStreamInputEventhubTimeouts) : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsStreamInputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        member _.Run(state: StreamAnalyticsStreamInputEventhubState<Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsStreamInputEventhub.StreamAnalyticsStreamInputEventhub =
            let config = azurerm.StreamAnalyticsStreamInputEventhub.StreamAnalyticsStreamInputEventhubConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsStreamInputEventhub.StreamAnalyticsStreamInputEventhub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsStreamInputEventhub: missing required arguments. Must call: eventhub_name, name, resource_group_name, serialization, servicebus_namespace, stream_analytics_job_name.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsStreamInputEventhubState<_, _, _, _, _, _>) : azurerm.StreamAnalyticsStreamInputEventhub.StreamAnalyticsStreamInputEventhub =
            Unchecked.defaultof<azurerm.StreamAnalyticsStreamInputEventhub.StreamAnalyticsStreamInputEventhub>
