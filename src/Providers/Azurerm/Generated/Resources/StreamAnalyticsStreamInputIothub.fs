namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName> = { assignments: ResizeArray<azurerm.StreamAnalyticsStreamInputIothub.StreamAnalyticsStreamInputIothubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_iothub">azurerm_stream_analytics_stream_input_iothub</a>.
    /// </summary>
    type StreamAnalyticsStreamInputIothubBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsStreamInputIothubState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsStreamInputIothubState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsStreamInputIothubState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsStreamInputIothubState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_iothub#endpoint-1">StreamAnalyticsStreamInputIothub#endpoint</a>.
        /// </summary>
        [<CustomOperation "endpoint">]
        member _.Endpoint(state: StreamAnalyticsStreamInputIothubState<Missing, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputIothubState<Present, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Endpoint <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputIothubState<Present, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_iothub#eventhub_consumer_group_name-1">StreamAnalyticsStreamInputIothub#eventhub_consumer_group_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_consumer_group_name">]
        member _.EventhubConsumerGroupName(state: StreamAnalyticsStreamInputIothubState<'Endpoint, Missing, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputIothubState<'Endpoint, Present, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.EventhubConsumerGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputIothubState<'Endpoint, Present, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_iothub#iothub_namespace-1">StreamAnalyticsStreamInputIothub#iothub_namespace</a>.
        /// </summary>
        [<CustomOperation "iothub_namespace">]
        member _.IothubNamespace(state: StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, Missing, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, Present, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.IothubNamespace <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, Present, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_iothub#name-1">StreamAnalyticsStreamInputIothub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, Missing, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, Present, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, Present, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_iothub#resource_group_name-1">StreamAnalyticsStreamInputIothub#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, Missing, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, Present, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, Present, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>)

        /// <summary>
        /// serialization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_iothub#serialization-1">StreamAnalyticsStreamInputIothub#serialization</a>
        /// </summary>
        [<CustomOperation "serialization">]
        member _.Serialization(state: StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, Missing, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>, value: azurerm.StreamAnalyticsStreamInputIothub.StreamAnalyticsStreamInputIothubSerialization) : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, Present, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Serialization <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, Present, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_iothub#shared_access_policy_key-1">StreamAnalyticsStreamInputIothub#shared_access_policy_key</a>.
        /// </summary>
        [<CustomOperation "shared_access_policy_key">]
        member _.SharedAccessPolicyKey(state: StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, Missing, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, Present, 'SharedAccessPolicyName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.SharedAccessPolicyKey <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, Present, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_iothub#shared_access_policy_name-1">StreamAnalyticsStreamInputIothub#shared_access_policy_name</a>.
        /// </summary>
        [<CustomOperation "shared_access_policy_name">]
        member _.SharedAccessPolicyName(state: StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, Missing, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, Present, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.SharedAccessPolicyName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, Present, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_iothub#stream_analytics_job_name-1">StreamAnalyticsStreamInputIothub#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, Missing>, value: string) : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, Present> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_iothub#id-1">StreamAnalyticsStreamInputIothub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_iothub#timeouts-1">StreamAnalyticsStreamInputIothub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>, value: azurerm.StreamAnalyticsStreamInputIothub.StreamAnalyticsStreamInputIothubTimeouts) : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsStreamInputIothubState<'Endpoint, 'EventhubConsumerGroupName, 'IothubNamespace, 'Name, 'ResourceGroupName, 'Serialization, 'SharedAccessPolicyKey, 'SharedAccessPolicyName, 'StreamAnalyticsJobName>

        member _.Run(state: StreamAnalyticsStreamInputIothubState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsStreamInputIothub.StreamAnalyticsStreamInputIothub =
            let config = azurerm.StreamAnalyticsStreamInputIothub.StreamAnalyticsStreamInputIothubConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsStreamInputIothub.StreamAnalyticsStreamInputIothub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsStreamInputIothub: missing required arguments. Must call: endpoint, eventhub_consumer_group_name, iothub_namespace, name, resource_group_name, serialization, shared_access_policy_key, shared_access_policy_name, stream_analytics_job_name.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsStreamInputIothubState<_, _, _, _, _, _, _, _, _>) : azurerm.StreamAnalyticsStreamInputIothub.StreamAnalyticsStreamInputIothub =
            Unchecked.defaultof<azurerm.StreamAnalyticsStreamInputIothub.StreamAnalyticsStreamInputIothub>
