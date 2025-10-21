namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> = { assignments: ResizeArray<azurerm.StreamAnalyticsOutputEventhub.StreamAnalyticsOutputEventhubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub">azurerm_stream_analytics_output_eventhub</a>.
    /// </summary>
    type StreamAnalyticsOutputEventhubBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsOutputEventhubState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputEventhubState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsOutputEventhubState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputEventhubState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub#eventhub_name-1">StreamAnalyticsOutputEventhub#eventhub_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_name">]
        member _.EventhubName(state: StreamAnalyticsOutputEventhubState<Missing, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputEventhubState<Present, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.EventhubName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputEventhubState<Present, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub#name-1">StreamAnalyticsOutputEventhub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsOutputEventhubState<'EventhubName, Missing, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputEventhubState<'EventhubName, Present, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputEventhubState<'EventhubName, Present, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub#resource_group_name-1">StreamAnalyticsOutputEventhub#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, Missing, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, Present, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, Present, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>)

        /// <summary>
        /// serialization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub#serialization-1">StreamAnalyticsOutputEventhub#serialization</a>
        /// </summary>
        [<CustomOperation "serialization">]
        member _.Serialization(state: StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, Missing, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: azurerm.StreamAnalyticsOutputEventhub.StreamAnalyticsOutputEventhubSerialization) : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, Present, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Serialization <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, Present, 'ServicebusNamespace, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub#servicebus_namespace-1">StreamAnalyticsOutputEventhub#servicebus_namespace</a>.
        /// </summary>
        [<CustomOperation "servicebus_namespace">]
        member _.ServicebusNamespace(state: StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, Missing, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, Present, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.ServicebusNamespace <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, Present, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub#stream_analytics_job_name-1">StreamAnalyticsOutputEventhub#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, Missing>, value: string) : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, Present> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub#authentication_mode-1">StreamAnalyticsOutputEventhub#authentication_mode</a>.
        /// </summary>
        [<CustomOperation "authentication_mode">]
        member _.AuthenticationMode(state: StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.AuthenticationMode <- value)
            state : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub#id-1">StreamAnalyticsOutputEventhub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub#partition_key-1">StreamAnalyticsOutputEventhub#partition_key</a>.
        /// </summary>
        [<CustomOperation "partition_key">]
        member _.PartitionKey(state: StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.PartitionKey <- value)
            state : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub#property_columns-1">StreamAnalyticsOutputEventhub#property_columns</a>.
        /// </summary>
        [<CustomOperation "property_columns">]
        member _.PropertyColumns(state: StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: seq<string>) : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.PropertyColumns <- (value |> Seq.toArray))
            state : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub#shared_access_policy_key-1">StreamAnalyticsOutputEventhub#shared_access_policy_key</a>.
        /// </summary>
        [<CustomOperation "shared_access_policy_key">]
        member _.SharedAccessPolicyKey(state: StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.SharedAccessPolicyKey <- value)
            state : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub#shared_access_policy_name-1">StreamAnalyticsOutputEventhub#shared_access_policy_name</a>.
        /// </summary>
        [<CustomOperation "shared_access_policy_name">]
        member _.SharedAccessPolicyName(state: StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.SharedAccessPolicyName <- value)
            state : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_eventhub#timeouts-1">StreamAnalyticsOutputEventhub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>, value: azurerm.StreamAnalyticsOutputEventhub.StreamAnalyticsOutputEventhubTimeouts) : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsOutputEventhubState<'EventhubName, 'Name, 'ResourceGroupName, 'Serialization, 'ServicebusNamespace, 'StreamAnalyticsJobName>

        member _.Run(state: StreamAnalyticsOutputEventhubState<Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsOutputEventhub.StreamAnalyticsOutputEventhub =
            let config = azurerm.StreamAnalyticsOutputEventhub.StreamAnalyticsOutputEventhubConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsOutputEventhub.StreamAnalyticsOutputEventhub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsOutputEventhub: missing required arguments. Must call: eventhub_name, name, resource_group_name, serialization, servicebus_namespace, stream_analytics_job_name.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsOutputEventhubState<_, _, _, _, _, _>) : azurerm.StreamAnalyticsOutputEventhub.StreamAnalyticsOutputEventhub =
            Unchecked.defaultof<azurerm.StreamAnalyticsOutputEventhub.StreamAnalyticsOutputEventhub>
