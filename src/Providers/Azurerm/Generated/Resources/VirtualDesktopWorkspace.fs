namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.VirtualDesktopWorkspace.VirtualDesktopWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace">azurerm_virtual_desktop_workspace</a>.
    /// </summary>
    type VirtualDesktopWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualDesktopWorkspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopWorkspaceState<Missing, Missing, Missing>)

        member _.Zero(()) : VirtualDesktopWorkspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopWorkspaceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace#location-1">VirtualDesktopWorkspace#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualDesktopWorkspaceState<Missing, 'Name, 'ResourceGroupName>, value: string) : VirtualDesktopWorkspaceState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualDesktopWorkspaceState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace#name-1">VirtualDesktopWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualDesktopWorkspaceState<'Location, Missing, 'ResourceGroupName>, value: string) : VirtualDesktopWorkspaceState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualDesktopWorkspaceState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace#resource_group_name-1">VirtualDesktopWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualDesktopWorkspaceState<'Location, 'Name, Missing>, value: string) : VirtualDesktopWorkspaceState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualDesktopWorkspaceState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace#description-1">VirtualDesktopWorkspace#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace#friendly_name-1">VirtualDesktopWorkspace#friendly_name</a>.
        /// </summary>
        [<CustomOperation "friendly_name">]
        member _.FriendlyName(state: VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FriendlyName <- value)
            state : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace#id-1">VirtualDesktopWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace#public_network_access_enabled-1">VirtualDesktopWorkspace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: bool) : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace#public_network_access_enabled-1">VirtualDesktopWorkspace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace#tags-1">VirtualDesktopWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace#timeouts-1">VirtualDesktopWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.VirtualDesktopWorkspace.VirtualDesktopWorkspaceTimeouts) : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualDesktopWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: VirtualDesktopWorkspaceState<Present, Present, Present>) : azurerm.VirtualDesktopWorkspace.VirtualDesktopWorkspace =
            let config = azurerm.VirtualDesktopWorkspace.VirtualDesktopWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualDesktopWorkspace.VirtualDesktopWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualDesktopWorkspace: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: VirtualDesktopWorkspaceState<_, _, _>) : azurerm.VirtualDesktopWorkspace.VirtualDesktopWorkspace =
            Unchecked.defaultof<azurerm.VirtualDesktopWorkspace.VirtualDesktopWorkspace>
