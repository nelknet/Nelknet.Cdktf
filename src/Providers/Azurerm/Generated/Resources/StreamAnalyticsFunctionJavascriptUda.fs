namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, 'Output, 'Script, 'StreamAnalyticsJobId> = { assignments: ResizeArray<azurerm.StreamAnalyticsFunctionJavascriptUda.StreamAnalyticsFunctionJavascriptUdaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_uda">azurerm_stream_analytics_function_javascript_uda</a>.
    /// </summary>
    type StreamAnalyticsFunctionJavascriptUdaBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsFunctionJavascriptUdaState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsFunctionJavascriptUdaState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsFunctionJavascriptUdaState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsFunctionJavascriptUdaState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// input block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_uda#input-1">StreamAnalyticsFunctionJavascriptUda#input</a> Accepts: azurerm.IResolvable | azurerm.StreamAnalyticsFunctionJavascriptUda.StreamAnalyticsFunctionJavascriptUdaInput[]
        /// </summary>
        [<CustomOperation "input">]
        member _.Input(state: StreamAnalyticsFunctionJavascriptUdaState<Missing, 'Name, 'Output, 'Script, 'StreamAnalyticsJobId>, value: HashiCorp.Cdktf.IResolvable) : StreamAnalyticsFunctionJavascriptUdaState<Present, 'Name, 'Output, 'Script, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Input <- value)
            ({ assignments = state.assignments } : StreamAnalyticsFunctionJavascriptUdaState<Present, 'Name, 'Output, 'Script, 'StreamAnalyticsJobId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_uda#name-1">StreamAnalyticsFunctionJavascriptUda#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsFunctionJavascriptUdaState<'Input, Missing, 'Output, 'Script, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsFunctionJavascriptUdaState<'Input, Present, 'Output, 'Script, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsFunctionJavascriptUdaState<'Input, Present, 'Output, 'Script, 'StreamAnalyticsJobId>)

        /// <summary>
        /// output block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_uda#output-1">StreamAnalyticsFunctionJavascriptUda#output</a>
        /// </summary>
        [<CustomOperation "output">]
        member _.Output(state: StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, Missing, 'Script, 'StreamAnalyticsJobId>, value: azurerm.StreamAnalyticsFunctionJavascriptUda.StreamAnalyticsFunctionJavascriptUdaOutput) : StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, Present, 'Script, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Output <- value)
            ({ assignments = state.assignments } : StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, Present, 'Script, 'StreamAnalyticsJobId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_uda#script-1">StreamAnalyticsFunctionJavascriptUda#script</a>.
        /// </summary>
        [<CustomOperation "script">]
        member _.Script(state: StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, 'Output, Missing, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, 'Output, Present, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Script <- value)
            ({ assignments = state.assignments } : StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, 'Output, Present, 'StreamAnalyticsJobId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_uda#stream_analytics_job_id-1">StreamAnalyticsFunctionJavascriptUda#stream_analytics_job_id</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_id">]
        member _.StreamAnalyticsJobId(state: StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, 'Output, 'Script, Missing>, value: string) : StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, 'Output, 'Script, Present> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobId <- value)
            ({ assignments = state.assignments } : StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, 'Output, 'Script, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_uda#id-1">StreamAnalyticsFunctionJavascriptUda#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, 'Output, 'Script, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, 'Output, 'Script, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, 'Output, 'Script, 'StreamAnalyticsJobId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_function_javascript_uda#timeouts-1">StreamAnalyticsFunctionJavascriptUda#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, 'Output, 'Script, 'StreamAnalyticsJobId>, value: azurerm.StreamAnalyticsFunctionJavascriptUda.StreamAnalyticsFunctionJavascriptUdaTimeouts) : StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, 'Output, 'Script, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsFunctionJavascriptUdaState<'Input, 'Name, 'Output, 'Script, 'StreamAnalyticsJobId>

        member _.Run(state: StreamAnalyticsFunctionJavascriptUdaState<Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsFunctionJavascriptUda.StreamAnalyticsFunctionJavascriptUda =
            let config = azurerm.StreamAnalyticsFunctionJavascriptUda.StreamAnalyticsFunctionJavascriptUdaConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsFunctionJavascriptUda.StreamAnalyticsFunctionJavascriptUda(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsFunctionJavascriptUda: missing required arguments. Must call: input, name, output, script, stream_analytics_job_id.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsFunctionJavascriptUdaState<_, _, _, _, _>) : azurerm.StreamAnalyticsFunctionJavascriptUda.StreamAnalyticsFunctionJavascriptUda =
            Unchecked.defaultof<azurerm.StreamAnalyticsFunctionJavascriptUda.StreamAnalyticsFunctionJavascriptUda>
