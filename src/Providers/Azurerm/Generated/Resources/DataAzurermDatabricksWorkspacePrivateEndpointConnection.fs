namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<'PrivateEndpointId, 'WorkspaceId> = { assignments: ResizeArray<azurerm.DataAzurermDatabricksWorkspacePrivateEndpointConnection.DataAzurermDatabricksWorkspacePrivateEndpointConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace_private_endpoint_connection">azurerm_databricks_workspace_private_endpoint_connection</a>.
    /// </summary>
    type DataAzurermDatabricksWorkspacePrivateEndpointConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace_private_endpoint_connection#private_endpoint_id-1">DataAzurermDatabricksWorkspacePrivateEndpointConnection#private_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "private_endpoint_id">]
        member _.PrivateEndpointId(state: DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<Missing, 'WorkspaceId>, value: string) : DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.PrivateEndpointId <- value)
            ({ assignments = state.assignments } : DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace_private_endpoint_connection#workspace_id-1">DataAzurermDatabricksWorkspacePrivateEndpointConnection#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<'PrivateEndpointId, Missing>, value: string) : DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<'PrivateEndpointId, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<'PrivateEndpointId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace_private_endpoint_connection#id-1">DataAzurermDatabricksWorkspacePrivateEndpointConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<'PrivateEndpointId, 'WorkspaceId>, value: string) : DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<'PrivateEndpointId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<'PrivateEndpointId, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace_private_endpoint_connection#timeouts-1">DataAzurermDatabricksWorkspacePrivateEndpointConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<'PrivateEndpointId, 'WorkspaceId>, value: azurerm.DataAzurermDatabricksWorkspacePrivateEndpointConnection.DataAzurermDatabricksWorkspacePrivateEndpointConnectionTimeouts) : DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<'PrivateEndpointId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<'PrivateEndpointId, 'WorkspaceId>

        member _.Run(state: DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<Present, Present>) : azurerm.DataAzurermDatabricksWorkspacePrivateEndpointConnection.DataAzurermDatabricksWorkspacePrivateEndpointConnection =
            let config = azurerm.DataAzurermDatabricksWorkspacePrivateEndpointConnection.DataAzurermDatabricksWorkspacePrivateEndpointConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDatabricksWorkspacePrivateEndpointConnection.DataAzurermDatabricksWorkspacePrivateEndpointConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDatabricksWorkspacePrivateEndpointConnection: missing required arguments. Must call: private_endpoint_id, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDatabricksWorkspacePrivateEndpointConnectionState<_, _>) : azurerm.DataAzurermDatabricksWorkspacePrivateEndpointConnection.DataAzurermDatabricksWorkspacePrivateEndpointConnection =
            Unchecked.defaultof<azurerm.DataAzurermDatabricksWorkspacePrivateEndpointConnection.DataAzurermDatabricksWorkspacePrivateEndpointConnection>
