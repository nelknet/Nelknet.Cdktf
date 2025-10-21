namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WebPubsubHubState<'Name, 'WebPubsubId> = { assignments: ResizeArray<azurerm.WebPubsubHub.WebPubsubHubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub">azurerm_web_pubsub_hub</a>.
    /// </summary>
    type WebPubsubHubBuilder(logicalId: string) =
        member _.Yield(_: unit) : WebPubsubHubState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WebPubsubHubState<Missing, Missing>)

        member _.Zero(()) : WebPubsubHubState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WebPubsubHubState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#name-1">WebPubsubHub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WebPubsubHubState<Missing, 'WebPubsubId>, value: string) : WebPubsubHubState<Present, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WebPubsubHubState<Present, 'WebPubsubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#web_pubsub_id-1">WebPubsubHub#web_pubsub_id</a>.
        /// </summary>
        [<CustomOperation "web_pubsub_id">]
        member _.WebPubsubId(state: WebPubsubHubState<'Name, Missing>, value: string) : WebPubsubHubState<'Name, Present> =
            state.assignments.Add(fun config -> config.WebPubsubId <- value)
            ({ assignments = state.assignments } : WebPubsubHubState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#anonymous_connections_enabled-1">WebPubsubHub#anonymous_connections_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "anonymous_connections_enabled">]
        member _.AnonymousConnectionsEnabled(state: WebPubsubHubState<'Name, 'WebPubsubId>, value: bool) : WebPubsubHubState<'Name, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.AnonymousConnectionsEnabled <- value)
            state : WebPubsubHubState<'Name, 'WebPubsubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#anonymous_connections_enabled-1">WebPubsubHub#anonymous_connections_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "anonymous_connections_enabled">]
        member _.AnonymousConnectionsEnabled(state: WebPubsubHubState<'Name, 'WebPubsubId>, value: HashiCorp.Cdktf.IResolvable) : WebPubsubHubState<'Name, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.AnonymousConnectionsEnabled <- value)
            state : WebPubsubHubState<'Name, 'WebPubsubId>

        /// <summary>
        /// event_handler block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#event_handler-1">WebPubsubHub#event_handler</a> Accepts: azurerm.IResolvable | azurerm.WebPubsubHub.WebPubsubHubEventHandler[]
        /// </summary>
        [<CustomOperation "event_handler">]
        member _.EventHandler(state: WebPubsubHubState<'Name, 'WebPubsubId>, value: HashiCorp.Cdktf.IResolvable) : WebPubsubHubState<'Name, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.EventHandler <- value)
            state : WebPubsubHubState<'Name, 'WebPubsubId>

        /// <summary>
        /// event_listener block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#event_listener-1">WebPubsubHub#event_listener</a> Accepts: azurerm.IResolvable | azurerm.WebPubsubHub.WebPubsubHubEventListener[]
        /// </summary>
        [<CustomOperation "event_listener">]
        member _.EventListener(state: WebPubsubHubState<'Name, 'WebPubsubId>, value: HashiCorp.Cdktf.IResolvable) : WebPubsubHubState<'Name, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.EventListener <- value)
            state : WebPubsubHubState<'Name, 'WebPubsubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#id-1">WebPubsubHub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WebPubsubHubState<'Name, 'WebPubsubId>, value: string) : WebPubsubHubState<'Name, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WebPubsubHubState<'Name, 'WebPubsubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#timeouts-1">WebPubsubHub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WebPubsubHubState<'Name, 'WebPubsubId>, value: azurerm.WebPubsubHub.WebPubsubHubTimeouts) : WebPubsubHubState<'Name, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WebPubsubHubState<'Name, 'WebPubsubId>

        member _.Run(state: WebPubsubHubState<Present, Present>) : azurerm.WebPubsubHub.WebPubsubHub =
            let config = azurerm.WebPubsubHub.WebPubsubHubConfig()
            for setter in state.assignments do
                setter config
            azurerm.WebPubsubHub.WebPubsubHub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.webPubsubHub: missing required arguments. Must call: name, web_pubsub_id.", 9999, IsError = true)>]
        member _.Run(_: WebPubsubHubState<_, _>) : azurerm.WebPubsubHub.WebPubsubHub =
            Unchecked.defaultof<azurerm.WebPubsubHub.WebPubsubHub>
