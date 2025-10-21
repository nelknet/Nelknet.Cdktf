namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WebAppHybridConnectionState<'Hostname, 'Port, 'RelayId, 'WebAppId> = { assignments: ResizeArray<azurerm.WebAppHybridConnection.WebAppHybridConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_hybrid_connection">azurerm_web_app_hybrid_connection</a>.
    /// </summary>
    type WebAppHybridConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : WebAppHybridConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WebAppHybridConnectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WebAppHybridConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WebAppHybridConnectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// The hostname of the endpoint. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_hybrid_connection#hostname-1">WebAppHybridConnection#hostname</a>
        /// </summary>
        [<CustomOperation "hostname">]
        member _.Hostname(state: WebAppHybridConnectionState<Missing, 'Port, 'RelayId, 'WebAppId>, value: string) : WebAppHybridConnectionState<Present, 'Port, 'RelayId, 'WebAppId> =
            state.assignments.Add(fun config -> config.Hostname <- value)
            ({ assignments = state.assignments } : WebAppHybridConnectionState<Present, 'Port, 'RelayId, 'WebAppId>)

        /// <summary>
        /// The port to use for the endpoint. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_hybrid_connection#port-1">WebAppHybridConnection#port</a>
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: WebAppHybridConnectionState<'Hostname, Missing, 'RelayId, 'WebAppId>, value: double) : WebAppHybridConnectionState<'Hostname, Present, 'RelayId, 'WebAppId> =
            state.assignments.Add(fun config -> config.Port <- value)
            ({ assignments = state.assignments } : WebAppHybridConnectionState<'Hostname, Present, 'RelayId, 'WebAppId>)

        /// <summary>
        /// The ID of the Relay Hybrid Connection to use. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_hybrid_connection#relay_id-1">WebAppHybridConnection#relay_id</a>
        /// </summary>
        [<CustomOperation "relay_id">]
        member _.RelayId(state: WebAppHybridConnectionState<'Hostname, 'Port, Missing, 'WebAppId>, value: string) : WebAppHybridConnectionState<'Hostname, 'Port, Present, 'WebAppId> =
            state.assignments.Add(fun config -> config.RelayId <- value)
            ({ assignments = state.assignments } : WebAppHybridConnectionState<'Hostname, 'Port, Present, 'WebAppId>)

        /// <summary>
        /// The ID of the Web App for this Hybrid Connection. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_hybrid_connection#web_app_id-1">WebAppHybridConnection#web_app_id</a>
        /// </summary>
        [<CustomOperation "web_app_id">]
        member _.WebAppId(state: WebAppHybridConnectionState<'Hostname, 'Port, 'RelayId, Missing>, value: string) : WebAppHybridConnectionState<'Hostname, 'Port, 'RelayId, Present> =
            state.assignments.Add(fun config -> config.WebAppId <- value)
            ({ assignments = state.assignments } : WebAppHybridConnectionState<'Hostname, 'Port, 'RelayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_hybrid_connection#id-1">WebAppHybridConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WebAppHybridConnectionState<'Hostname, 'Port, 'RelayId, 'WebAppId>, value: string) : WebAppHybridConnectionState<'Hostname, 'Port, 'RelayId, 'WebAppId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WebAppHybridConnectionState<'Hostname, 'Port, 'RelayId, 'WebAppId>

        /// <summary>
        /// The name of the Relay key with `Send` permission to use. Defaults to `RootManageSharedAccessKey`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_hybrid_connection#send_key_name-1">WebAppHybridConnection#send_key_name</a>
        /// </summary>
        [<CustomOperation "send_key_name">]
        member _.SendKeyName(state: WebAppHybridConnectionState<'Hostname, 'Port, 'RelayId, 'WebAppId>, value: string) : WebAppHybridConnectionState<'Hostname, 'Port, 'RelayId, 'WebAppId> =
            state.assignments.Add(fun config -> config.SendKeyName <- value)
            state : WebAppHybridConnectionState<'Hostname, 'Port, 'RelayId, 'WebAppId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_hybrid_connection#timeouts-1">WebAppHybridConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WebAppHybridConnectionState<'Hostname, 'Port, 'RelayId, 'WebAppId>, value: azurerm.WebAppHybridConnection.WebAppHybridConnectionTimeouts) : WebAppHybridConnectionState<'Hostname, 'Port, 'RelayId, 'WebAppId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WebAppHybridConnectionState<'Hostname, 'Port, 'RelayId, 'WebAppId>

        member _.Run(state: WebAppHybridConnectionState<Present, Present, Present, Present>) : azurerm.WebAppHybridConnection.WebAppHybridConnection =
            let config = azurerm.WebAppHybridConnection.WebAppHybridConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.WebAppHybridConnection.WebAppHybridConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.webAppHybridConnection: missing required arguments. Must call: hostname, port, relay_id, web_app_id.", 9999, IsError = true)>]
        member _.Run(_: WebAppHybridConnectionState<_, _, _, _>) : azurerm.WebAppHybridConnection.WebAppHybridConnection =
            Unchecked.defaultof<azurerm.WebAppHybridConnection.WebAppHybridConnection>
