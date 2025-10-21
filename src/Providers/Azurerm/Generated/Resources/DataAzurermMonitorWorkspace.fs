namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMonitorWorkspaceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermMonitorWorkspace.DataAzurermMonitorWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_workspace">azurerm_monitor_workspace</a>.
    /// </summary>
    type DataAzurermMonitorWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMonitorWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorWorkspaceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMonitorWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorWorkspaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_workspace#name-1">DataAzurermMonitorWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMonitorWorkspaceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermMonitorWorkspaceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMonitorWorkspaceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_workspace#resource_group_name-1">DataAzurermMonitorWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMonitorWorkspaceState<'Name, Missing>, value: string) : DataAzurermMonitorWorkspaceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMonitorWorkspaceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_workspace#id-1">DataAzurermMonitorWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMonitorWorkspaceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermMonitorWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMonitorWorkspaceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_workspace#timeouts-1">DataAzurermMonitorWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMonitorWorkspaceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermMonitorWorkspace.DataAzurermMonitorWorkspaceTimeouts) : DataAzurermMonitorWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMonitorWorkspaceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermMonitorWorkspaceState<Present, Present>) : azurerm.DataAzurermMonitorWorkspace.DataAzurermMonitorWorkspace =
            let config = azurerm.DataAzurermMonitorWorkspace.DataAzurermMonitorWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMonitorWorkspace.DataAzurermMonitorWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMonitorWorkspace: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMonitorWorkspaceState<_, _>) : azurerm.DataAzurermMonitorWorkspace.DataAzurermMonitorWorkspace =
            Unchecked.defaultof<azurerm.DataAzurermMonitorWorkspace.DataAzurermMonitorWorkspace>
