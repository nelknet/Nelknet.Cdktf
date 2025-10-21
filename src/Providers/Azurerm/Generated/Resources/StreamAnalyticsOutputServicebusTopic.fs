namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName> = { assignments: ResizeArray<azurerm.StreamAnalyticsOutputServicebusTopic.StreamAnalyticsOutputServicebusTopicConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic">azurerm_stream_analytics_output_servicebus_topic</a>.
    /// </summary>
    type StreamAnalyticsOutputServicebusTopicBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsOutputServicebusTopicState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputServicebusTopicState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsOutputServicebusTopicState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputServicebusTopicState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic#name-1">StreamAnalyticsOutputServicebusTopic#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsOutputServicebusTopicState<Missing, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>, value: string) : StreamAnalyticsOutputServicebusTopicState<Present, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputServicebusTopicState<Present, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic#resource_group_name-1">StreamAnalyticsOutputServicebusTopic#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsOutputServicebusTopicState<'Name, Missing, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>, value: string) : StreamAnalyticsOutputServicebusTopicState<'Name, Present, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputServicebusTopicState<'Name, Present, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>)

        /// <summary>
        /// serialization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic#serialization-1">StreamAnalyticsOutputServicebusTopic#serialization</a>
        /// </summary>
        [<CustomOperation "serialization">]
        member _.Serialization(state: StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, Missing, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>, value: azurerm.StreamAnalyticsOutputServicebusTopic.StreamAnalyticsOutputServicebusTopicSerialization) : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, Present, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName> =
            state.assignments.Add(fun config -> config.Serialization <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, Present, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic#servicebus_namespace-1">StreamAnalyticsOutputServicebusTopic#servicebus_namespace</a>.
        /// </summary>
        [<CustomOperation "servicebus_namespace">]
        member _.ServicebusNamespace(state: StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, Missing, 'StreamAnalyticsJobName, 'TopicName>, value: string) : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, Present, 'StreamAnalyticsJobName, 'TopicName> =
            state.assignments.Add(fun config -> config.ServicebusNamespace <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, Present, 'StreamAnalyticsJobName, 'TopicName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic#stream_analytics_job_name-1">StreamAnalyticsOutputServicebusTopic#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, Missing, 'TopicName>, value: string) : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, Present, 'TopicName> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, Present, 'TopicName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic#topic_name-1">StreamAnalyticsOutputServicebusTopic#topic_name</a>.
        /// </summary>
        [<CustomOperation "topic_name">]
        member _.TopicName(state: StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, Missing>, value: string) : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, Present> =
            state.assignments.Add(fun config -> config.TopicName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic#authentication_mode-1">StreamAnalyticsOutputServicebusTopic#authentication_mode</a>.
        /// </summary>
        [<CustomOperation "authentication_mode">]
        member _.AuthenticationMode(state: StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>, value: string) : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName> =
            state.assignments.Add(fun config -> config.AuthenticationMode <- value)
            state : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic#id-1">StreamAnalyticsOutputServicebusTopic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>, value: string) : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic#property_columns-1">StreamAnalyticsOutputServicebusTopic#property_columns</a>.
        /// </summary>
        [<CustomOperation "property_columns">]
        member _.PropertyColumns(state: StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>, value: seq<string>) : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName> =
            state.assignments.Add(fun config -> config.PropertyColumns <- (value |> Seq.toArray))
            state : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic#shared_access_policy_key-1">StreamAnalyticsOutputServicebusTopic#shared_access_policy_key</a>.
        /// </summary>
        [<CustomOperation "shared_access_policy_key">]
        member _.SharedAccessPolicyKey(state: StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>, value: string) : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName> =
            state.assignments.Add(fun config -> config.SharedAccessPolicyKey <- value)
            state : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic#shared_access_policy_name-1">StreamAnalyticsOutputServicebusTopic#shared_access_policy_name</a>.
        /// </summary>
        [<CustomOperation "shared_access_policy_name">]
        member _.SharedAccessPolicyName(state: StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>, value: string) : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName> =
            state.assignments.Add(fun config -> config.SharedAccessPolicyName <- value)
            state : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic#system_property_columns-1">StreamAnalyticsOutputServicebusTopic#system_property_columns</a>.
        /// </summary>
        [<CustomOperation "system_property_columns">]
        member _.SystemPropertyColumns(state: StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>, value: seq<string * string>) : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName> =
            state.assignments.Add(fun config -> config.SystemPropertyColumns <- dict value)
            state : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_servicebus_topic#timeouts-1">StreamAnalyticsOutputServicebusTopic#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>, value: azurerm.StreamAnalyticsOutputServicebusTopic.StreamAnalyticsOutputServicebusTopicTimeouts) : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsOutputServicebusTopicState<'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName, 'TopicName>

        member _.Run(state: StreamAnalyticsOutputServicebusTopicState<Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsOutputServicebusTopic.StreamAnalyticsOutputServicebusTopic =
            let config = azurerm.StreamAnalyticsOutputServicebusTopic.StreamAnalyticsOutputServicebusTopicConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsOutputServicebusTopic.StreamAnalyticsOutputServicebusTopic(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsOutputServicebusTopic: missing required arguments. Must call: name, resource_group_name, serialization, servicebus_namespace, stream_analytics_job_name, topic_name.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsOutputServicebusTopicState<_, _, _, _, _, _>) : azurerm.StreamAnalyticsOutputServicebusTopic.StreamAnalyticsOutputServicebusTopic =
            Unchecked.defaultof<azurerm.StreamAnalyticsOutputServicebusTopic.StreamAnalyticsOutputServicebusTopic>
