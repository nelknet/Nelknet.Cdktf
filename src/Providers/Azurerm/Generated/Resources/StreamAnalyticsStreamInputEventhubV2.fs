namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId> = { assignments: ResizeArray<azurerm.StreamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2Config -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub_v2">azurerm_stream_analytics_stream_input_eventhub_v2</a>.
    /// </summary>
    type StreamAnalyticsStreamInputEventhubV2Builder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsStreamInputEventhubV2State<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsStreamInputEventhubV2State<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsStreamInputEventhubV2State<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsStreamInputEventhubV2State<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub_v2#eventhub_name-1">StreamAnalyticsStreamInputEventhubV2#eventhub_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_name">]
        member _.EventhubName(state: StreamAnalyticsStreamInputEventhubV2State<Missing, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsStreamInputEventhubV2State<Present, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.EventhubName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputEventhubV2State<Present, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub_v2#name-1">StreamAnalyticsStreamInputEventhubV2#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsStreamInputEventhubV2State<'EventhubName, Missing, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, Present, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, Present, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>)

        /// <summary>
        /// serialization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub_v2#serialization-1">StreamAnalyticsStreamInputEventhubV2#serialization</a>
        /// </summary>
        [<CustomOperation "serialization">]
        member _.Serialization(state: StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, Missing, 'ServicebusNamespace, 'StreamAnalyticsJobId>, value: azurerm.StreamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2Serialization) : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, Present, 'ServicebusNamespace, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Serialization <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, Present, 'ServicebusNamespace, 'StreamAnalyticsJobId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub_v2#servicebus_namespace-1">StreamAnalyticsStreamInputEventhubV2#servicebus_namespace</a>.
        /// </summary>
        [<CustomOperation "servicebus_namespace">]
        member _.ServicebusNamespace(state: StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, Missing, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, Present, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.ServicebusNamespace <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, Present, 'StreamAnalyticsJobId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub_v2#stream_analytics_job_id-1">StreamAnalyticsStreamInputEventhubV2#stream_analytics_job_id</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_id">]
        member _.StreamAnalyticsJobId(state: StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, Missing>, value: string) : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, Present> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobId <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub_v2#authentication_mode-1">StreamAnalyticsStreamInputEventhubV2#authentication_mode</a>.
        /// </summary>
        [<CustomOperation "authentication_mode">]
        member _.AuthenticationMode(state: StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.AuthenticationMode <- value)
            state : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub_v2#eventhub_consumer_group_name-1">StreamAnalyticsStreamInputEventhubV2#eventhub_consumer_group_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_consumer_group_name">]
        member _.EventhubConsumerGroupName(state: StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.EventhubConsumerGroupName <- value)
            state : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub_v2#id-1">StreamAnalyticsStreamInputEventhubV2#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub_v2#partition_key-1">StreamAnalyticsStreamInputEventhubV2#partition_key</a>.
        /// </summary>
        [<CustomOperation "partition_key">]
        member _.PartitionKey(state: StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.PartitionKey <- value)
            state : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub_v2#shared_access_policy_key-1">StreamAnalyticsStreamInputEventhubV2#shared_access_policy_key</a>.
        /// </summary>
        [<CustomOperation "shared_access_policy_key">]
        member _.SharedAccessPolicyKey(state: StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.SharedAccessPolicyKey <- value)
            state : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub_v2#shared_access_policy_name-1">StreamAnalyticsStreamInputEventhubV2#shared_access_policy_name</a>.
        /// </summary>
        [<CustomOperation "shared_access_policy_name">]
        member _.SharedAccessPolicyName(state: StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.SharedAccessPolicyName <- value)
            state : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_eventhub_v2#timeouts-1">StreamAnalyticsStreamInputEventhubV2#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>, value: azurerm.StreamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2Timeouts) : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsStreamInputEventhubV2State<'EventhubName, 'Name, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobId>

        member _.Run(state: StreamAnalyticsStreamInputEventhubV2State<Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2 =
            let config = azurerm.StreamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2Config()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsStreamInputEventhubV2: missing required arguments. Must call: eventhub_name, name, serialization, servicebus_namespace, stream_analytics_job_id.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsStreamInputEventhubV2State<_, _, _, _, _>) : azurerm.StreamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2 =
            Unchecked.defaultof<azurerm.StreamAnalyticsStreamInputEventhubV2.StreamAnalyticsStreamInputEventhubV2>
