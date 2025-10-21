namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkManagerSubscriptionConnectionState<'Name, 'NetworkManagerId, 'SubscriptionId> = { assignments: ResizeArray<azurerm.NetworkManagerSubscriptionConnection.NetworkManagerSubscriptionConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_subscription_connection">azurerm_network_manager_subscription_connection</a>.
    /// </summary>
    type NetworkManagerSubscriptionConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkManagerSubscriptionConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerSubscriptionConnectionState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkManagerSubscriptionConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerSubscriptionConnectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_subscription_connection#name-1">NetworkManagerSubscriptionConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkManagerSubscriptionConnectionState<Missing, 'NetworkManagerId, 'SubscriptionId>, value: string) : NetworkManagerSubscriptionConnectionState<Present, 'NetworkManagerId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkManagerSubscriptionConnectionState<Present, 'NetworkManagerId, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_subscription_connection#network_manager_id-1">NetworkManagerSubscriptionConnection#network_manager_id</a>.
        /// </summary>
        [<CustomOperation "network_manager_id">]
        member _.NetworkManagerId(state: NetworkManagerSubscriptionConnectionState<'Name, Missing, 'SubscriptionId>, value: string) : NetworkManagerSubscriptionConnectionState<'Name, Present, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.NetworkManagerId <- value)
            ({ assignments = state.assignments } : NetworkManagerSubscriptionConnectionState<'Name, Present, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_subscription_connection#subscription_id-1">NetworkManagerSubscriptionConnection#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: NetworkManagerSubscriptionConnectionState<'Name, 'NetworkManagerId, Missing>, value: string) : NetworkManagerSubscriptionConnectionState<'Name, 'NetworkManagerId, Present> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            ({ assignments = state.assignments } : NetworkManagerSubscriptionConnectionState<'Name, 'NetworkManagerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_subscription_connection#description-1">NetworkManagerSubscriptionConnection#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkManagerSubscriptionConnectionState<'Name, 'NetworkManagerId, 'SubscriptionId>, value: string) : NetworkManagerSubscriptionConnectionState<'Name, 'NetworkManagerId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkManagerSubscriptionConnectionState<'Name, 'NetworkManagerId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_subscription_connection#id-1">NetworkManagerSubscriptionConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkManagerSubscriptionConnectionState<'Name, 'NetworkManagerId, 'SubscriptionId>, value: string) : NetworkManagerSubscriptionConnectionState<'Name, 'NetworkManagerId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkManagerSubscriptionConnectionState<'Name, 'NetworkManagerId, 'SubscriptionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_subscription_connection#timeouts-1">NetworkManagerSubscriptionConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkManagerSubscriptionConnectionState<'Name, 'NetworkManagerId, 'SubscriptionId>, value: azurerm.NetworkManagerSubscriptionConnection.NetworkManagerSubscriptionConnectionTimeouts) : NetworkManagerSubscriptionConnectionState<'Name, 'NetworkManagerId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkManagerSubscriptionConnectionState<'Name, 'NetworkManagerId, 'SubscriptionId>

        member _.Run(state: NetworkManagerSubscriptionConnectionState<Present, Present, Present>) : azurerm.NetworkManagerSubscriptionConnection.NetworkManagerSubscriptionConnection =
            let config = azurerm.NetworkManagerSubscriptionConnection.NetworkManagerSubscriptionConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkManagerSubscriptionConnection.NetworkManagerSubscriptionConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkManagerSubscriptionConnection: missing required arguments. Must call: name, network_manager_id, subscription_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkManagerSubscriptionConnectionState<_, _, _>) : azurerm.NetworkManagerSubscriptionConnection.NetworkManagerSubscriptionConnection =
            Unchecked.defaultof<azurerm.NetworkManagerSubscriptionConnection.NetworkManagerSubscriptionConnection>
