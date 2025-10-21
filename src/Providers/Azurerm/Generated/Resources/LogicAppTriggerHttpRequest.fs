namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, 'Schema> = { assignments: ResizeArray<azurerm.LogicAppTriggerHttpRequest.LogicAppTriggerHttpRequestConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_http_request">azurerm_logic_app_trigger_http_request</a>.
    /// </summary>
    type LogicAppTriggerHttpRequestBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppTriggerHttpRequestState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppTriggerHttpRequestState<Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppTriggerHttpRequestState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppTriggerHttpRequestState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_http_request#logic_app_id-1">LogicAppTriggerHttpRequest#logic_app_id</a>.
        /// </summary>
        [<CustomOperation "logic_app_id">]
        member _.LogicAppId(state: LogicAppTriggerHttpRequestState<Missing, 'Name, 'Schema>, value: string) : LogicAppTriggerHttpRequestState<Present, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.LogicAppId <- value)
            ({ assignments = state.assignments } : LogicAppTriggerHttpRequestState<Present, 'Name, 'Schema>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_http_request#name-1">LogicAppTriggerHttpRequest#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppTriggerHttpRequestState<'LogicAppId, Missing, 'Schema>, value: string) : LogicAppTriggerHttpRequestState<'LogicAppId, Present, 'Schema> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppTriggerHttpRequestState<'LogicAppId, Present, 'Schema>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_http_request#schema-1">LogicAppTriggerHttpRequest#schema</a>.
        /// </summary>
        [<CustomOperation "schema">]
        member _.Schema(state: LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, Missing>, value: string) : LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Schema <- value)
            ({ assignments = state.assignments } : LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_http_request#id-1">LogicAppTriggerHttpRequest#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, 'Schema>, value: string) : LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, 'Schema>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_http_request#method-1">LogicAppTriggerHttpRequest#method</a>.
        /// </summary>
        [<CustomOperation "method">]
        member _.Method(state: LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, 'Schema>, value: string) : LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.Method <- value)
            state : LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, 'Schema>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_http_request#relative_path-1">LogicAppTriggerHttpRequest#relative_path</a>.
        /// </summary>
        [<CustomOperation "relative_path">]
        member _.RelativePath(state: LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, 'Schema>, value: string) : LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.RelativePath <- value)
            state : LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, 'Schema>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_trigger_http_request#timeouts-1">LogicAppTriggerHttpRequest#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, 'Schema>, value: azurerm.LogicAppTriggerHttpRequest.LogicAppTriggerHttpRequestTimeouts) : LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppTriggerHttpRequestState<'LogicAppId, 'Name, 'Schema>

        member _.Run(state: LogicAppTriggerHttpRequestState<Present, Present, Present>) : azurerm.LogicAppTriggerHttpRequest.LogicAppTriggerHttpRequest =
            let config = azurerm.LogicAppTriggerHttpRequest.LogicAppTriggerHttpRequestConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppTriggerHttpRequest.LogicAppTriggerHttpRequest(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppTriggerHttpRequest: missing required arguments. Must call: logic_app_id, name, schema.", 9999, IsError = true)>]
        member _.Run(_: LogicAppTriggerHttpRequestState<_, _, _>) : azurerm.LogicAppTriggerHttpRequest.LogicAppTriggerHttpRequest =
            Unchecked.defaultof<azurerm.LogicAppTriggerHttpRequest.LogicAppTriggerHttpRequest>
