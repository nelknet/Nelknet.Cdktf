namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.MonitorWorkspace.MonitorWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_workspace">azurerm_monitor_workspace</a>.
    /// </summary>
    type MonitorWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorWorkspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorWorkspaceState<Missing, Missing, Missing>)

        member _.Zero(()) : MonitorWorkspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorWorkspaceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_workspace#location-1">MonitorWorkspace#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MonitorWorkspaceState<Missing, 'Name, 'ResourceGroupName>, value: string) : MonitorWorkspaceState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MonitorWorkspaceState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_workspace#name-1">MonitorWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorWorkspaceState<'Location, Missing, 'ResourceGroupName>, value: string) : MonitorWorkspaceState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorWorkspaceState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_workspace#resource_group_name-1">MonitorWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorWorkspaceState<'Location, 'Name, Missing>, value: string) : MonitorWorkspaceState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorWorkspaceState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_workspace#id-1">MonitorWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: string) : MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_workspace#public_network_access_enabled-1">MonitorWorkspace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: bool) : MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_workspace#public_network_access_enabled-1">MonitorWorkspace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_workspace#tags-1">MonitorWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_workspace#timeouts-1">MonitorWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.MonitorWorkspace.MonitorWorkspaceTimeouts) : MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: MonitorWorkspaceState<Present, Present, Present>) : azurerm.MonitorWorkspace.MonitorWorkspace =
            let config = azurerm.MonitorWorkspace.MonitorWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorWorkspace.MonitorWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorWorkspace: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: MonitorWorkspaceState<_, _, _>) : azurerm.MonitorWorkspace.MonitorWorkspace =
            Unchecked.defaultof<azurerm.MonitorWorkspace.MonitorWorkspace>
