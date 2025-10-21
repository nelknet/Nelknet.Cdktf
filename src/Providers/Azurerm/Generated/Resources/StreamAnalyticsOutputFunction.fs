namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName> = { assignments: ResizeArray<azurerm.StreamAnalyticsOutputFunction.StreamAnalyticsOutputFunctionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_function">azurerm_stream_analytics_output_function</a>.
    /// </summary>
    type StreamAnalyticsOutputFunctionBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsOutputFunctionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputFunctionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsOutputFunctionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputFunctionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_function#api_key-1">StreamAnalyticsOutputFunction#api_key</a>.
        /// </summary>
        [<CustomOperation "api_key">]
        member _.ApiKey(state: StreamAnalyticsOutputFunctionState<Missing, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputFunctionState<Present, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.ApiKey <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputFunctionState<Present, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_function#function_app-1">StreamAnalyticsOutputFunction#function_app</a>.
        /// </summary>
        [<CustomOperation "function_app">]
        member _.FunctionApp(state: StreamAnalyticsOutputFunctionState<'ApiKey, Missing, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputFunctionState<'ApiKey, Present, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.FunctionApp <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputFunctionState<'ApiKey, Present, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_function#function_name-1">StreamAnalyticsOutputFunction#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, Missing, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, Present, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, Present, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_function#name-1">StreamAnalyticsOutputFunction#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, Missing, 'ResourceGroupName, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, Present, 'ResourceGroupName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, Present, 'ResourceGroupName, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_function#resource_group_name-1">StreamAnalyticsOutputFunction#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, Missing, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, Present, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, Present, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_function#stream_analytics_job_name-1">StreamAnalyticsOutputFunction#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, Missing>, value: string) : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_function#batch_max_count-1">StreamAnalyticsOutputFunction#batch_max_count</a>.
        /// </summary>
        [<CustomOperation "batch_max_count">]
        member _.BatchMaxCount(state: StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>, value: double) : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.BatchMaxCount <- value)
            state : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_function#batch_max_in_bytes-1">StreamAnalyticsOutputFunction#batch_max_in_bytes</a>.
        /// </summary>
        [<CustomOperation "batch_max_in_bytes">]
        member _.BatchMaxInBytes(state: StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>, value: double) : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.BatchMaxInBytes <- value)
            state : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_function#id-1">StreamAnalyticsOutputFunction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_function#timeouts-1">StreamAnalyticsOutputFunction#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>, value: azurerm.StreamAnalyticsOutputFunction.StreamAnalyticsOutputFunctionTimeouts) : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsOutputFunctionState<'ApiKey, 'FunctionApp, 'FunctionName, 'Name, 'ResourceGroupName, 'StreamAnalyticsJobName>

        member _.Run(state: StreamAnalyticsOutputFunctionState<Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsOutputFunction.StreamAnalyticsOutputFunction =
            let config = azurerm.StreamAnalyticsOutputFunction.StreamAnalyticsOutputFunctionConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsOutputFunction.StreamAnalyticsOutputFunction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsOutputFunction: missing required arguments. Must call: api_key, function_app, function_name, name, resource_group_name, stream_analytics_job_name.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsOutputFunctionState<_, _, _, _, _, _>) : azurerm.StreamAnalyticsOutputFunction.StreamAnalyticsOutputFunction =
            Unchecked.defaultof<azurerm.StreamAnalyticsOutputFunction.StreamAnalyticsOutputFunction>
