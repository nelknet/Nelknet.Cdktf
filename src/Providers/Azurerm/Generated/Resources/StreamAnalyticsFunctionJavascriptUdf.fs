namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName> = { assignments: ResizeArray<azurerm.StreamAnalyticsFunctionJavascriptUdf.StreamAnalyticsFunctionJavascriptUdfConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_udf">azurerm_stream_analytics_function_javascript_udf</a>.
    /// </summary>
    type StreamAnalyticsFunctionJavascriptUdfBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsFunctionJavascriptUdfState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsFunctionJavascriptUdfState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsFunctionJavascriptUdfState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsFunctionJavascriptUdfState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// input block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_udf#input-1">StreamAnalyticsFunctionJavascriptUdf#input</a> Accepts: azurerm.IResolvable | azurerm.StreamAnalyticsFunctionJavascriptUdf.StreamAnalyticsFunctionJavascriptUdfInput[]
        /// </summary>
        [<CustomOperation "input">]
        member _.Input(state: StreamAnalyticsFunctionJavascriptUdfState<Missing, 'Name, 'Output, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName>, value: HashiCorp.Cdktf.IResolvable) : StreamAnalyticsFunctionJavascriptUdfState<Present, 'Name, 'Output, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Input <- value)
            ({ assignments = state.assignments } : StreamAnalyticsFunctionJavascriptUdfState<Present, 'Name, 'Output, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_udf#name-1">StreamAnalyticsFunctionJavascriptUdf#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsFunctionJavascriptUdfState<'Input, Missing, 'Output, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsFunctionJavascriptUdfState<'Input, Present, 'Output, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsFunctionJavascriptUdfState<'Input, Present, 'Output, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName>)

        /// <summary>
        /// output block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_udf#output-1">StreamAnalyticsFunctionJavascriptUdf#output</a>
        /// </summary>
        [<CustomOperation "output">]
        member _.Output(state: StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, Missing, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName>, value: azurerm.StreamAnalyticsFunctionJavascriptUdf.StreamAnalyticsFunctionJavascriptUdfOutput) : StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, Present, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Output <- value)
            ({ assignments = state.assignments } : StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, Present, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_udf#resource_group_name-1">StreamAnalyticsFunctionJavascriptUdf#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, Missing, 'Script, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, Present, 'Script, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, Present, 'Script, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_udf#script-1">StreamAnalyticsFunctionJavascriptUdf#script</a>.
        /// </summary>
        [<CustomOperation "script">]
        member _.Script(state: StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, 'ResourceGroupName, Missing, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, 'ResourceGroupName, Present, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Script <- value)
            ({ assignments = state.assignments } : StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, 'ResourceGroupName, Present, 'StreamAnalyticsJobName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_udf#stream_analytics_job_name-1">StreamAnalyticsFunctionJavascriptUdf#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, 'ResourceGroupName, 'Script, Missing>, value: string) : StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, 'ResourceGroupName, 'Script, Present> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, 'ResourceGroupName, 'Script, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_udf#id-1">StreamAnalyticsFunctionJavascriptUdf#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName>, value: string) : StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_udf#timeouts-1">StreamAnalyticsFunctionJavascriptUdf#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName>, value: azurerm.StreamAnalyticsFunctionJavascriptUdf.StreamAnalyticsFunctionJavascriptUdfTimeouts) : StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsFunctionJavascriptUdfState<'Input, 'Name, 'Output, 'ResourceGroupName, 'Script, 'StreamAnalyticsJobName>

        member _.Run(state: StreamAnalyticsFunctionJavascriptUdfState<Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsFunctionJavascriptUdf.StreamAnalyticsFunctionJavascriptUdf =
            let config = azurerm.StreamAnalyticsFunctionJavascriptUdf.StreamAnalyticsFunctionJavascriptUdfConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsFunctionJavascriptUdf.StreamAnalyticsFunctionJavascriptUdf(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsFunctionJavascriptUdf: missing required arguments. Must call: input, name, output, resource_group_name, script, stream_analytics_job_name.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsFunctionJavascriptUdfState<_, _, _, _, _, _>) : azurerm.StreamAnalyticsFunctionJavascriptUdf.StreamAnalyticsFunctionJavascriptUdf =
            Unchecked.defaultof<azurerm.StreamAnalyticsFunctionJavascriptUdf.StreamAnalyticsFunctionJavascriptUdf>
