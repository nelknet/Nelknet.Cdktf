namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseManagedPrivateEndpointState<'Name, 'SubresourceName, 'SynapseWorkspaceId, 'TargetResourceId> = { assignments: ResizeArray<azurerm.SynapseManagedPrivateEndpoint.SynapseManagedPrivateEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_managed_private_endpoint">azurerm_synapse_managed_private_endpoint</a>.
    /// </summary>
    type SynapseManagedPrivateEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseManagedPrivateEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseManagedPrivateEndpointState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SynapseManagedPrivateEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseManagedPrivateEndpointState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_managed_private_endpoint#name-1">SynapseManagedPrivateEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SynapseManagedPrivateEndpointState<Missing, 'SubresourceName, 'SynapseWorkspaceId, 'TargetResourceId>, value: string) : SynapseManagedPrivateEndpointState<Present, 'SubresourceName, 'SynapseWorkspaceId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SynapseManagedPrivateEndpointState<Present, 'SubresourceName, 'SynapseWorkspaceId, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_managed_private_endpoint#subresource_name-1">SynapseManagedPrivateEndpoint#subresource_name</a>.
        /// </summary>
        [<CustomOperation "subresource_name">]
        member _.SubresourceName(state: SynapseManagedPrivateEndpointState<'Name, Missing, 'SynapseWorkspaceId, 'TargetResourceId>, value: string) : SynapseManagedPrivateEndpointState<'Name, Present, 'SynapseWorkspaceId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.SubresourceName <- value)
            ({ assignments = state.assignments } : SynapseManagedPrivateEndpointState<'Name, Present, 'SynapseWorkspaceId, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_managed_private_endpoint#synapse_workspace_id-1">SynapseManagedPrivateEndpoint#synapse_workspace_id</a>.
        /// </summary>
        [<CustomOperation "synapse_workspace_id">]
        member _.SynapseWorkspaceId(state: SynapseManagedPrivateEndpointState<'Name, 'SubresourceName, Missing, 'TargetResourceId>, value: string) : SynapseManagedPrivateEndpointState<'Name, 'SubresourceName, Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.SynapseWorkspaceId <- value)
            ({ assignments = state.assignments } : SynapseManagedPrivateEndpointState<'Name, 'SubresourceName, Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_managed_private_endpoint#target_resource_id-1">SynapseManagedPrivateEndpoint#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: SynapseManagedPrivateEndpointState<'Name, 'SubresourceName, 'SynapseWorkspaceId, Missing>, value: string) : SynapseManagedPrivateEndpointState<'Name, 'SubresourceName, 'SynapseWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : SynapseManagedPrivateEndpointState<'Name, 'SubresourceName, 'SynapseWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_managed_private_endpoint#id-1">SynapseManagedPrivateEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseManagedPrivateEndpointState<'Name, 'SubresourceName, 'SynapseWorkspaceId, 'TargetResourceId>, value: string) : SynapseManagedPrivateEndpointState<'Name, 'SubresourceName, 'SynapseWorkspaceId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseManagedPrivateEndpointState<'Name, 'SubresourceName, 'SynapseWorkspaceId, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_managed_private_endpoint#timeouts-1">SynapseManagedPrivateEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseManagedPrivateEndpointState<'Name, 'SubresourceName, 'SynapseWorkspaceId, 'TargetResourceId>, value: azurerm.SynapseManagedPrivateEndpoint.SynapseManagedPrivateEndpointTimeouts) : SynapseManagedPrivateEndpointState<'Name, 'SubresourceName, 'SynapseWorkspaceId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseManagedPrivateEndpointState<'Name, 'SubresourceName, 'SynapseWorkspaceId, 'TargetResourceId>

        member _.Run(state: SynapseManagedPrivateEndpointState<Present, Present, Present, Present>) : azurerm.SynapseManagedPrivateEndpoint.SynapseManagedPrivateEndpoint =
            let config = azurerm.SynapseManagedPrivateEndpoint.SynapseManagedPrivateEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseManagedPrivateEndpoint.SynapseManagedPrivateEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseManagedPrivateEndpoint: missing required arguments. Must call: name, subresource_name, synapse_workspace_id, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseManagedPrivateEndpointState<_, _, _, _>) : azurerm.SynapseManagedPrivateEndpoint.SynapseManagedPrivateEndpoint =
            Unchecked.defaultof<azurerm.SynapseManagedPrivateEndpoint.SynapseManagedPrivateEndpoint>
