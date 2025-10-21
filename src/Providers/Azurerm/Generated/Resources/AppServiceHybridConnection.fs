namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, 'RelayId, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AppServiceHybridConnection.AppServiceHybridConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_hybrid_connection">azurerm_app_service_hybrid_connection</a>.
    /// </summary>
    type AppServiceHybridConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceHybridConnectionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceHybridConnectionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppServiceHybridConnectionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceHybridConnectionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_hybrid_connection#app_service_name-1">AppServiceHybridConnection#app_service_name</a>.
        /// </summary>
        [<CustomOperation "app_service_name">]
        member _.AppServiceName(state: AppServiceHybridConnectionState<Missing, 'Hostname, 'Port, 'RelayId, 'ResourceGroupName>, value: string) : AppServiceHybridConnectionState<Present, 'Hostname, 'Port, 'RelayId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppServiceName <- value)
            ({ assignments = state.assignments } : AppServiceHybridConnectionState<Present, 'Hostname, 'Port, 'RelayId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_hybrid_connection#hostname-1">AppServiceHybridConnection#hostname</a>.
        /// </summary>
        [<CustomOperation "hostname">]
        member _.Hostname(state: AppServiceHybridConnectionState<'AppServiceName, Missing, 'Port, 'RelayId, 'ResourceGroupName>, value: string) : AppServiceHybridConnectionState<'AppServiceName, Present, 'Port, 'RelayId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Hostname <- value)
            ({ assignments = state.assignments } : AppServiceHybridConnectionState<'AppServiceName, Present, 'Port, 'RelayId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_hybrid_connection#port-1">AppServiceHybridConnection#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: AppServiceHybridConnectionState<'AppServiceName, 'Hostname, Missing, 'RelayId, 'ResourceGroupName>, value: double) : AppServiceHybridConnectionState<'AppServiceName, 'Hostname, Present, 'RelayId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Port <- value)
            ({ assignments = state.assignments } : AppServiceHybridConnectionState<'AppServiceName, 'Hostname, Present, 'RelayId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_hybrid_connection#relay_id-1">AppServiceHybridConnection#relay_id</a>.
        /// </summary>
        [<CustomOperation "relay_id">]
        member _.RelayId(state: AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, Missing, 'ResourceGroupName>, value: string) : AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RelayId <- value)
            ({ assignments = state.assignments } : AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_hybrid_connection#resource_group_name-1">AppServiceHybridConnection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, 'RelayId, Missing>, value: string) : AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, 'RelayId, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, 'RelayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_hybrid_connection#id-1">AppServiceHybridConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, 'RelayId, 'ResourceGroupName>, value: string) : AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, 'RelayId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, 'RelayId, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_hybrid_connection#send_key_name-1">AppServiceHybridConnection#send_key_name</a>.
        /// </summary>
        [<CustomOperation "send_key_name">]
        member _.SendKeyName(state: AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, 'RelayId, 'ResourceGroupName>, value: string) : AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, 'RelayId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SendKeyName <- value)
            state : AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, 'RelayId, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_hybrid_connection#timeouts-1">AppServiceHybridConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, 'RelayId, 'ResourceGroupName>, value: azurerm.AppServiceHybridConnection.AppServiceHybridConnectionTimeouts) : AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, 'RelayId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceHybridConnectionState<'AppServiceName, 'Hostname, 'Port, 'RelayId, 'ResourceGroupName>

        member _.Run(state: AppServiceHybridConnectionState<Present, Present, Present, Present, Present>) : azurerm.AppServiceHybridConnection.AppServiceHybridConnection =
            let config = azurerm.AppServiceHybridConnection.AppServiceHybridConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceHybridConnection.AppServiceHybridConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceHybridConnection: missing required arguments. Must call: app_service_name, hostname, port, relay_id, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AppServiceHybridConnectionState<_, _, _, _, _>) : azurerm.AppServiceHybridConnection.AppServiceHybridConnection =
            Unchecked.defaultof<azurerm.AppServiceHybridConnection.AppServiceHybridConnection>
