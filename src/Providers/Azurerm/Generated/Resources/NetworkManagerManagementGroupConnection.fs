namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkManagerManagementGroupConnectionState<'ManagementGroupId, 'Name, 'NetworkManagerId> = { assignments: ResizeArray<azurerm.NetworkManagerManagementGroupConnection.NetworkManagerManagementGroupConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_management_group_connection">azurerm_network_manager_management_group_connection</a>.
    /// </summary>
    type NetworkManagerManagementGroupConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkManagerManagementGroupConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerManagementGroupConnectionState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkManagerManagementGroupConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerManagementGroupConnectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_management_group_connection#management_group_id-1">NetworkManagerManagementGroupConnection#management_group_id</a>.
        /// </summary>
        [<CustomOperation "management_group_id">]
        member _.ManagementGroupId(state: NetworkManagerManagementGroupConnectionState<Missing, 'Name, 'NetworkManagerId>, value: string) : NetworkManagerManagementGroupConnectionState<Present, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.ManagementGroupId <- value)
            ({ assignments = state.assignments } : NetworkManagerManagementGroupConnectionState<Present, 'Name, 'NetworkManagerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_management_group_connection#name-1">NetworkManagerManagementGroupConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkManagerManagementGroupConnectionState<'ManagementGroupId, Missing, 'NetworkManagerId>, value: string) : NetworkManagerManagementGroupConnectionState<'ManagementGroupId, Present, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkManagerManagementGroupConnectionState<'ManagementGroupId, Present, 'NetworkManagerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_management_group_connection#network_manager_id-1">NetworkManagerManagementGroupConnection#network_manager_id</a>.
        /// </summary>
        [<CustomOperation "network_manager_id">]
        member _.NetworkManagerId(state: NetworkManagerManagementGroupConnectionState<'ManagementGroupId, 'Name, Missing>, value: string) : NetworkManagerManagementGroupConnectionState<'ManagementGroupId, 'Name, Present> =
            state.assignments.Add(fun config -> config.NetworkManagerId <- value)
            ({ assignments = state.assignments } : NetworkManagerManagementGroupConnectionState<'ManagementGroupId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_management_group_connection#description-1">NetworkManagerManagementGroupConnection#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkManagerManagementGroupConnectionState<'ManagementGroupId, 'Name, 'NetworkManagerId>, value: string) : NetworkManagerManagementGroupConnectionState<'ManagementGroupId, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkManagerManagementGroupConnectionState<'ManagementGroupId, 'Name, 'NetworkManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_management_group_connection#id-1">NetworkManagerManagementGroupConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkManagerManagementGroupConnectionState<'ManagementGroupId, 'Name, 'NetworkManagerId>, value: string) : NetworkManagerManagementGroupConnectionState<'ManagementGroupId, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkManagerManagementGroupConnectionState<'ManagementGroupId, 'Name, 'NetworkManagerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_management_group_connection#timeouts-1">NetworkManagerManagementGroupConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkManagerManagementGroupConnectionState<'ManagementGroupId, 'Name, 'NetworkManagerId>, value: azurerm.NetworkManagerManagementGroupConnection.NetworkManagerManagementGroupConnectionTimeouts) : NetworkManagerManagementGroupConnectionState<'ManagementGroupId, 'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkManagerManagementGroupConnectionState<'ManagementGroupId, 'Name, 'NetworkManagerId>

        member _.Run(state: NetworkManagerManagementGroupConnectionState<Present, Present, Present>) : azurerm.NetworkManagerManagementGroupConnection.NetworkManagerManagementGroupConnection =
            let config = azurerm.NetworkManagerManagementGroupConnection.NetworkManagerManagementGroupConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkManagerManagementGroupConnection.NetworkManagerManagementGroupConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkManagerManagementGroupConnection: missing required arguments. Must call: management_group_id, name, network_manager_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkManagerManagementGroupConnectionState<_, _, _>) : azurerm.NetworkManagerManagementGroupConnection.NetworkManagerManagementGroupConnection =
            Unchecked.defaultof<azurerm.NetworkManagerManagementGroupConnection.NetworkManagerManagementGroupConnection>
