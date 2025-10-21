namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri> = { assignments: ResizeArray<azurerm.LogicAppActionHttp.LogicAppActionHttpConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http">azurerm_logic_app_action_http</a>.
    /// </summary>
    type LogicAppActionHttpBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppActionHttpState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppActionHttpState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppActionHttpState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppActionHttpState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#logic_app_id-1">LogicAppActionHttp#logic_app_id</a>.
        /// </summary>
        [<CustomOperation "logic_app_id">]
        member _.LogicAppId(state: LogicAppActionHttpState<Missing, 'Method, 'Name, 'Uri>, value: string) : LogicAppActionHttpState<Present, 'Method, 'Name, 'Uri> =
            state.assignments.Add(fun config -> config.LogicAppId <- value)
            ({ assignments = state.assignments } : LogicAppActionHttpState<Present, 'Method, 'Name, 'Uri>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#method-1">LogicAppActionHttp#method</a>.
        /// </summary>
        [<CustomOperation "method">]
        member _.Method(state: LogicAppActionHttpState<'LogicAppId, Missing, 'Name, 'Uri>, value: string) : LogicAppActionHttpState<'LogicAppId, Present, 'Name, 'Uri> =
            state.assignments.Add(fun config -> config.Method <- value)
            ({ assignments = state.assignments } : LogicAppActionHttpState<'LogicAppId, Present, 'Name, 'Uri>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#name-1">LogicAppActionHttp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppActionHttpState<'LogicAppId, 'Method, Missing, 'Uri>, value: string) : LogicAppActionHttpState<'LogicAppId, 'Method, Present, 'Uri> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppActionHttpState<'LogicAppId, 'Method, Present, 'Uri>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#uri-1">LogicAppActionHttp#uri</a>.
        /// </summary>
        [<CustomOperation "uri">]
        member _.Uri(state: LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, Missing>, value: string) : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, Present> =
            state.assignments.Add(fun config -> config.Uri <- value)
            ({ assignments = state.assignments } : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#body-1">LogicAppActionHttp#body</a>.
        /// </summary>
        [<CustomOperation "body">]
        member _.Body(state: LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri>, value: string) : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri> =
            state.assignments.Add(fun config -> config.Body <- value)
            state : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#headers-1">LogicAppActionHttp#headers</a>.
        /// </summary>
        [<CustomOperation "headers">]
        member _.Headers(state: LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri>, value: seq<string * string>) : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri> =
            state.assignments.Add(fun config -> config.Headers <- dict value)
            state : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#id-1">LogicAppActionHttp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri>, value: string) : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#queries-1">LogicAppActionHttp#queries</a>.
        /// </summary>
        [<CustomOperation "queries">]
        member _.Queries(state: LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri>, value: seq<string * string>) : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri> =
            state.assignments.Add(fun config -> config.Queries <- dict value)
            state : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri>

        /// <summary>
        /// run_after block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#run_after-1">LogicAppActionHttp#run_after</a> Accepts: azurerm.IResolvable | azurerm.LogicAppActionHttp.LogicAppActionHttpRunAfter[]
        /// </summary>
        [<CustomOperation "run_after">]
        member _.RunAfter(state: LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri>, value: HashiCorp.Cdktf.IResolvable) : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri> =
            state.assignments.Add(fun config -> config.RunAfter <- value)
            state : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_action_http#timeouts-1">LogicAppActionHttp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri>, value: azurerm.LogicAppActionHttp.LogicAppActionHttpTimeouts) : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppActionHttpState<'LogicAppId, 'Method, 'Name, 'Uri>

        member _.Run(state: LogicAppActionHttpState<Present, Present, Present, Present>) : azurerm.LogicAppActionHttp.LogicAppActionHttp =
            let config = azurerm.LogicAppActionHttp.LogicAppActionHttpConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppActionHttp.LogicAppActionHttp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppActionHttp: missing required arguments. Must call: logic_app_id, method, name, uri.", 9999, IsError = true)>]
        member _.Run(_: LogicAppActionHttpState<_, _, _, _>) : azurerm.LogicAppActionHttp.LogicAppActionHttp =
            Unchecked.defaultof<azurerm.LogicAppActionHttp.LogicAppActionHttp>
