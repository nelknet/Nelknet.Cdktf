namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, 'Port, 'RelayId> = { assignments: ResizeArray<azurerm.FunctionAppHybridConnection.FunctionAppHybridConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_hybrid_connection">azurerm_function_app_hybrid_connection</a>.
    /// </summary>
    type FunctionAppHybridConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : FunctionAppHybridConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FunctionAppHybridConnectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FunctionAppHybridConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FunctionAppHybridConnectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// The ID of the Function App for this Hybrid Connection. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_hybrid_connection#function_app_id-1">FunctionAppHybridConnection#function_app_id</a>
        /// </summary>
        [<CustomOperation "function_app_id">]
        member _.FunctionAppId(state: FunctionAppHybridConnectionState<Missing, 'Hostname, 'Port, 'RelayId>, value: string) : FunctionAppHybridConnectionState<Present, 'Hostname, 'Port, 'RelayId> =
            state.assignments.Add(fun config -> config.FunctionAppId <- value)
            ({ assignments = state.assignments } : FunctionAppHybridConnectionState<Present, 'Hostname, 'Port, 'RelayId>)

        /// <summary>
        /// The hostname of the endpoint. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_hybrid_connection#hostname-1">FunctionAppHybridConnection#hostname</a>
        /// </summary>
        [<CustomOperation "hostname">]
        member _.Hostname(state: FunctionAppHybridConnectionState<'FunctionAppId, Missing, 'Port, 'RelayId>, value: string) : FunctionAppHybridConnectionState<'FunctionAppId, Present, 'Port, 'RelayId> =
            state.assignments.Add(fun config -> config.Hostname <- value)
            ({ assignments = state.assignments } : FunctionAppHybridConnectionState<'FunctionAppId, Present, 'Port, 'RelayId>)

        /// <summary>
        /// The port to use for the endpoint. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_hybrid_connection#port-1">FunctionAppHybridConnection#port</a>
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, Missing, 'RelayId>, value: double) : FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, Present, 'RelayId> =
            state.assignments.Add(fun config -> config.Port <- value)
            ({ assignments = state.assignments } : FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, Present, 'RelayId>)

        /// <summary>
        /// The ID of the Relay Hybrid Connection to use. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_hybrid_connection#relay_id-1">FunctionAppHybridConnection#relay_id</a>
        /// </summary>
        [<CustomOperation "relay_id">]
        member _.RelayId(state: FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, 'Port, Missing>, value: string) : FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, 'Port, Present> =
            state.assignments.Add(fun config -> config.RelayId <- value)
            ({ assignments = state.assignments } : FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, 'Port, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_hybrid_connection#id-1">FunctionAppHybridConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, 'Port, 'RelayId>, value: string) : FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, 'Port, 'RelayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, 'Port, 'RelayId>

        /// <summary>
        /// The name of the Relay key with `Send` permission to use. Defaults to `RootManageSharedAccessKey`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_hybrid_connection#send_key_name-1">FunctionAppHybridConnection#send_key_name</a>
        /// </summary>
        [<CustomOperation "send_key_name">]
        member _.SendKeyName(state: FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, 'Port, 'RelayId>, value: string) : FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, 'Port, 'RelayId> =
            state.assignments.Add(fun config -> config.SendKeyName <- value)
            state : FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, 'Port, 'RelayId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_hybrid_connection#timeouts-1">FunctionAppHybridConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, 'Port, 'RelayId>, value: azurerm.FunctionAppHybridConnection.FunctionAppHybridConnectionTimeouts) : FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, 'Port, 'RelayId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FunctionAppHybridConnectionState<'FunctionAppId, 'Hostname, 'Port, 'RelayId>

        member _.Run(state: FunctionAppHybridConnectionState<Present, Present, Present, Present>) : azurerm.FunctionAppHybridConnection.FunctionAppHybridConnection =
            let config = azurerm.FunctionAppHybridConnection.FunctionAppHybridConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.FunctionAppHybridConnection.FunctionAppHybridConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.functionAppHybridConnection: missing required arguments. Must call: function_app_id, hostname, port, relay_id.", 9999, IsError = true)>]
        member _.Run(_: FunctionAppHybridConnectionState<_, _, _, _>) : azurerm.FunctionAppHybridConnection.FunctionAppHybridConnection =
            Unchecked.defaultof<azurerm.FunctionAppHybridConnection.FunctionAppHybridConnection>
