namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDatabricksWorkspaceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDatabricksWorkspace.DataAzurermDatabricksWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace">azurerm_databricks_workspace</a>.
    /// </summary>
    type DataAzurermDatabricksWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDatabricksWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDatabricksWorkspaceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDatabricksWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDatabricksWorkspaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace#name-1">DataAzurermDatabricksWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDatabricksWorkspaceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermDatabricksWorkspaceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDatabricksWorkspaceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace#resource_group_name-1">DataAzurermDatabricksWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDatabricksWorkspaceState<'Name, Missing>, value: string) : DataAzurermDatabricksWorkspaceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDatabricksWorkspaceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace#id-1">DataAzurermDatabricksWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDatabricksWorkspaceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermDatabricksWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDatabricksWorkspaceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace#tags-1">DataAzurermDatabricksWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermDatabricksWorkspaceState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermDatabricksWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermDatabricksWorkspaceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_workspace#timeouts-1">DataAzurermDatabricksWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDatabricksWorkspaceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDatabricksWorkspace.DataAzurermDatabricksWorkspaceTimeouts) : DataAzurermDatabricksWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDatabricksWorkspaceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDatabricksWorkspaceState<Present, Present>) : azurerm.DataAzurermDatabricksWorkspace.DataAzurermDatabricksWorkspace =
            let config = azurerm.DataAzurermDatabricksWorkspace.DataAzurermDatabricksWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDatabricksWorkspace.DataAzurermDatabricksWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDatabricksWorkspace: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDatabricksWorkspaceState<_, _>) : azurerm.DataAzurermDatabricksWorkspace.DataAzurermDatabricksWorkspace =
            Unchecked.defaultof<azurerm.DataAzurermDatabricksWorkspace.DataAzurermDatabricksWorkspace>
