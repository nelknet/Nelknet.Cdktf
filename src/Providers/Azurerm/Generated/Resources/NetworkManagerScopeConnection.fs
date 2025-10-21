namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, 'TargetScopeId, 'TenantId> = { assignments: ResizeArray<azurerm.NetworkManagerScopeConnection.NetworkManagerScopeConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_scope_connection">azurerm_network_manager_scope_connection</a>.
    /// </summary>
    type NetworkManagerScopeConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkManagerScopeConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerScopeConnectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkManagerScopeConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerScopeConnectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_scope_connection#name-1">NetworkManagerScopeConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkManagerScopeConnectionState<Missing, 'NetworkManagerId, 'TargetScopeId, 'TenantId>, value: string) : NetworkManagerScopeConnectionState<Present, 'NetworkManagerId, 'TargetScopeId, 'TenantId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkManagerScopeConnectionState<Present, 'NetworkManagerId, 'TargetScopeId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_scope_connection#network_manager_id-1">NetworkManagerScopeConnection#network_manager_id</a>.
        /// </summary>
        [<CustomOperation "network_manager_id">]
        member _.NetworkManagerId(state: NetworkManagerScopeConnectionState<'Name, Missing, 'TargetScopeId, 'TenantId>, value: string) : NetworkManagerScopeConnectionState<'Name, Present, 'TargetScopeId, 'TenantId> =
            state.assignments.Add(fun config -> config.NetworkManagerId <- value)
            ({ assignments = state.assignments } : NetworkManagerScopeConnectionState<'Name, Present, 'TargetScopeId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_scope_connection#target_scope_id-1">NetworkManagerScopeConnection#target_scope_id</a>.
        /// </summary>
        [<CustomOperation "target_scope_id">]
        member _.TargetScopeId(state: NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, Missing, 'TenantId>, value: string) : NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.TargetScopeId <- value)
            ({ assignments = state.assignments } : NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_scope_connection#tenant_id-1">NetworkManagerScopeConnection#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, 'TargetScopeId, Missing>, value: string) : NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, 'TargetScopeId, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, 'TargetScopeId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_scope_connection#description-1">NetworkManagerScopeConnection#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, 'TargetScopeId, 'TenantId>, value: string) : NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, 'TargetScopeId, 'TenantId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, 'TargetScopeId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_scope_connection#id-1">NetworkManagerScopeConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, 'TargetScopeId, 'TenantId>, value: string) : NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, 'TargetScopeId, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, 'TargetScopeId, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_scope_connection#timeouts-1">NetworkManagerScopeConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, 'TargetScopeId, 'TenantId>, value: azurerm.NetworkManagerScopeConnection.NetworkManagerScopeConnectionTimeouts) : NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, 'TargetScopeId, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkManagerScopeConnectionState<'Name, 'NetworkManagerId, 'TargetScopeId, 'TenantId>

        member _.Run(state: NetworkManagerScopeConnectionState<Present, Present, Present, Present>) : azurerm.NetworkManagerScopeConnection.NetworkManagerScopeConnection =
            let config = azurerm.NetworkManagerScopeConnection.NetworkManagerScopeConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkManagerScopeConnection.NetworkManagerScopeConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkManagerScopeConnection: missing required arguments. Must call: name, network_manager_id, target_scope_id, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkManagerScopeConnectionState<_, _, _, _>) : azurerm.NetworkManagerScopeConnection.NetworkManagerScopeConnection =
            Unchecked.defaultof<azurerm.NetworkManagerScopeConnection.NetworkManagerScopeConnection>
