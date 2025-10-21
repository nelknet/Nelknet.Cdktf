namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup> = { assignments: ResizeArray<azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor">azurerm_network_connection_monitor</a>.
    /// </summary>
    type NetworkConnectionMonitorBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkConnectionMonitorState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkConnectionMonitorState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkConnectionMonitorState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkConnectionMonitorState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#endpoint-1">NetworkConnectionMonitor#endpoint</a> Accepts: azurerm.IResolvable | azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorEndpoint[]
        /// </summary>
        [<CustomOperation "endpoint">]
        member _.Endpoint(state: NetworkConnectionMonitorState<Missing, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>, value: HashiCorp.Cdktf.IResolvable) : NetworkConnectionMonitorState<Present, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup> =
            state.assignments.Add(fun config -> config.Endpoint <- value)
            ({ assignments = state.assignments } : NetworkConnectionMonitorState<Present, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#location-1">NetworkConnectionMonitor#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetworkConnectionMonitorState<'Endpoint, Missing, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>, value: string) : NetworkConnectionMonitorState<'Endpoint, Present, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetworkConnectionMonitorState<'Endpoint, Present, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#name-1">NetworkConnectionMonitor#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkConnectionMonitorState<'Endpoint, 'Location, Missing, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>, value: string) : NetworkConnectionMonitorState<'Endpoint, 'Location, Present, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkConnectionMonitorState<'Endpoint, 'Location, Present, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#network_watcher_id-1">NetworkConnectionMonitor#network_watcher_id</a>.
        /// </summary>
        [<CustomOperation "network_watcher_id">]
        member _.NetworkWatcherId(state: NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, Missing, 'TestConfiguration, 'TestGroup>, value: string) : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, Present, 'TestConfiguration, 'TestGroup> =
            state.assignments.Add(fun config -> config.NetworkWatcherId <- value)
            ({ assignments = state.assignments } : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, Present, 'TestConfiguration, 'TestGroup>)

        /// <summary>
        /// test_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#test_configuration-1">NetworkConnectionMonitor#test_configuration</a> Accepts: azurerm.IResolvable | azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorTestConfiguration[]
        /// </summary>
        [<CustomOperation "test_configuration">]
        member _.TestConfiguration(state: NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, Missing, 'TestGroup>, value: HashiCorp.Cdktf.IResolvable) : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, Present, 'TestGroup> =
            state.assignments.Add(fun config -> config.TestConfiguration <- value)
            ({ assignments = state.assignments } : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, Present, 'TestGroup>)

        /// <summary>
        /// test_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#test_group-1">NetworkConnectionMonitor#test_group</a> Accepts: azurerm.IResolvable | azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorTestGroup[]
        /// </summary>
        [<CustomOperation "test_group">]
        member _.TestGroup(state: NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, Missing>, value: HashiCorp.Cdktf.IResolvable) : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, Present> =
            state.assignments.Add(fun config -> config.TestGroup <- value)
            ({ assignments = state.assignments } : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#id-1">NetworkConnectionMonitor#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>, value: string) : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#notes-1">NetworkConnectionMonitor#notes</a>.
        /// </summary>
        [<CustomOperation "notes">]
        member _.Notes(state: NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>, value: string) : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup> =
            state.assignments.Add(fun config -> config.Notes <- value)
            state : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#output_workspace_resource_ids-1">NetworkConnectionMonitor#output_workspace_resource_ids</a>.
        /// </summary>
        [<CustomOperation "output_workspace_resource_ids">]
        member _.OutputWorkspaceResourceIds(state: NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>, value: seq<string>) : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup> =
            state.assignments.Add(fun config -> config.OutputWorkspaceResourceIds <- (value |> Seq.toArray))
            state : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#tags-1">NetworkConnectionMonitor#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>, value: seq<string * string>) : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_connection_monitor#timeouts-1">NetworkConnectionMonitor#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>, value: azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorTimeouts) : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkConnectionMonitorState<'Endpoint, 'Location, 'Name, 'NetworkWatcherId, 'TestConfiguration, 'TestGroup>

        member _.Run(state: NetworkConnectionMonitorState<Present, Present, Present, Present, Present, Present>) : azurerm.NetworkConnectionMonitor.NetworkConnectionMonitor =
            let config = azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkConnectionMonitor.NetworkConnectionMonitor(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkConnectionMonitor: missing required arguments. Must call: endpoint, location, name, network_watcher_id, test_configuration, test_group.", 9999, IsError = true)>]
        member _.Run(_: NetworkConnectionMonitorState<_, _, _, _, _, _>) : azurerm.NetworkConnectionMonitor.NetworkConnectionMonitor =
            Unchecked.defaultof<azurerm.NetworkConnectionMonitor.NetworkConnectionMonitor>
