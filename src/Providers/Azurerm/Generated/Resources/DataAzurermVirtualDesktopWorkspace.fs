namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVirtualDesktopWorkspaceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermVirtualDesktopWorkspace.DataAzurermVirtualDesktopWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_workspace">azurerm_virtual_desktop_workspace</a>.
    /// </summary>
    type DataAzurermVirtualDesktopWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVirtualDesktopWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualDesktopWorkspaceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermVirtualDesktopWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualDesktopWorkspaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_workspace#name-1">DataAzurermVirtualDesktopWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVirtualDesktopWorkspaceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermVirtualDesktopWorkspaceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualDesktopWorkspaceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_workspace#resource_group_name-1">DataAzurermVirtualDesktopWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVirtualDesktopWorkspaceState<'Name, Missing>, value: string) : DataAzurermVirtualDesktopWorkspaceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualDesktopWorkspaceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_workspace#id-1">DataAzurermVirtualDesktopWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVirtualDesktopWorkspaceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermVirtualDesktopWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVirtualDesktopWorkspaceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_workspace#timeouts-1">DataAzurermVirtualDesktopWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVirtualDesktopWorkspaceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermVirtualDesktopWorkspace.DataAzurermVirtualDesktopWorkspaceTimeouts) : DataAzurermVirtualDesktopWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVirtualDesktopWorkspaceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermVirtualDesktopWorkspaceState<Present, Present>) : azurerm.DataAzurermVirtualDesktopWorkspace.DataAzurermVirtualDesktopWorkspace =
            let config = azurerm.DataAzurermVirtualDesktopWorkspace.DataAzurermVirtualDesktopWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVirtualDesktopWorkspace.DataAzurermVirtualDesktopWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVirtualDesktopWorkspace: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVirtualDesktopWorkspaceState<_, _>) : azurerm.DataAzurermVirtualDesktopWorkspace.DataAzurermVirtualDesktopWorkspace =
            Unchecked.defaultof<azurerm.DataAzurermVirtualDesktopWorkspace.DataAzurermVirtualDesktopWorkspace>
