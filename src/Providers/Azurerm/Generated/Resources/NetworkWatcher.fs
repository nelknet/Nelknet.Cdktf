namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkWatcherState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.NetworkWatcher.NetworkWatcherConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher">azurerm_network_watcher</a>.
    /// </summary>
    type NetworkWatcherBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkWatcherState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkWatcherState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkWatcherState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkWatcherState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher#location-1">NetworkWatcher#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetworkWatcherState<Missing, 'Name, 'ResourceGroupName>, value: string) : NetworkWatcherState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetworkWatcherState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher#name-1">NetworkWatcher#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkWatcherState<'Location, Missing, 'ResourceGroupName>, value: string) : NetworkWatcherState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkWatcherState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher#resource_group_name-1">NetworkWatcher#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetworkWatcherState<'Location, 'Name, Missing>, value: string) : NetworkWatcherState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetworkWatcherState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher#id-1">NetworkWatcher#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkWatcherState<'Location, 'Name, 'ResourceGroupName>, value: string) : NetworkWatcherState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkWatcherState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher#tags-1">NetworkWatcher#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkWatcherState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : NetworkWatcherState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkWatcherState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher#timeouts-1">NetworkWatcher#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkWatcherState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetworkWatcher.NetworkWatcherTimeouts) : NetworkWatcherState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkWatcherState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: NetworkWatcherState<Present, Present, Present>) : azurerm.NetworkWatcher.NetworkWatcher =
            let config = azurerm.NetworkWatcher.NetworkWatcherConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkWatcher.NetworkWatcher(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkWatcher: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: NetworkWatcherState<_, _, _>) : azurerm.NetworkWatcher.NetworkWatcher =
            Unchecked.defaultof<azurerm.NetworkWatcher.NetworkWatcher>
