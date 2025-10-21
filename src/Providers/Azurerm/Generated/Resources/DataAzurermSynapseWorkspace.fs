namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSynapseWorkspaceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermSynapseWorkspace.DataAzurermSynapseWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/synapse_workspace">azurerm_synapse_workspace</a>.
    /// </summary>
    type DataAzurermSynapseWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSynapseWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSynapseWorkspaceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermSynapseWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSynapseWorkspaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/synapse_workspace#name-1">DataAzurermSynapseWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSynapseWorkspaceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermSynapseWorkspaceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSynapseWorkspaceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/synapse_workspace#resource_group_name-1">DataAzurermSynapseWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSynapseWorkspaceState<'Name, Missing>, value: string) : DataAzurermSynapseWorkspaceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSynapseWorkspaceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/synapse_workspace#id-1">DataAzurermSynapseWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSynapseWorkspaceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermSynapseWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSynapseWorkspaceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/synapse_workspace#timeouts-1">DataAzurermSynapseWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSynapseWorkspaceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermSynapseWorkspace.DataAzurermSynapseWorkspaceTimeouts) : DataAzurermSynapseWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSynapseWorkspaceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermSynapseWorkspaceState<Present, Present>) : azurerm.DataAzurermSynapseWorkspace.DataAzurermSynapseWorkspace =
            let config = azurerm.DataAzurermSynapseWorkspace.DataAzurermSynapseWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSynapseWorkspace.DataAzurermSynapseWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSynapseWorkspace: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSynapseWorkspaceState<_, _>) : azurerm.DataAzurermSynapseWorkspace.DataAzurermSynapseWorkspace =
            Unchecked.defaultof<azurerm.DataAzurermSynapseWorkspace.DataAzurermSynapseWorkspace>
