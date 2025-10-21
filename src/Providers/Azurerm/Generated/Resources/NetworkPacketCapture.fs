namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId> = { assignments: ResizeArray<azurerm.NetworkPacketCapture.NetworkPacketCaptureConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture">azurerm_network_packet_capture</a>.
    /// </summary>
    type NetworkPacketCaptureBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkPacketCaptureState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkPacketCaptureState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkPacketCaptureState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkPacketCaptureState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#name-1">NetworkPacketCapture#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkPacketCaptureState<Missing, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>, value: string) : NetworkPacketCaptureState<Present, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkPacketCaptureState<Present, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#network_watcher_name-1">NetworkPacketCapture#network_watcher_name</a>.
        /// </summary>
        [<CustomOperation "network_watcher_name">]
        member _.NetworkWatcherName(state: NetworkPacketCaptureState<'Name, Missing, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>, value: string) : NetworkPacketCaptureState<'Name, Present, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.NetworkWatcherName <- value)
            ({ assignments = state.assignments } : NetworkPacketCaptureState<'Name, Present, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#resource_group_name-1">NetworkPacketCapture#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetworkPacketCaptureState<'Name, 'NetworkWatcherName, Missing, 'StorageLocation, 'TargetResourceId>, value: string) : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, Present, 'StorageLocation, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, Present, 'StorageLocation, 'TargetResourceId>)

        /// <summary>
        /// storage_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#storage_location-1">NetworkPacketCapture#storage_location</a>
        /// </summary>
        [<CustomOperation "storage_location">]
        member _.StorageLocation(state: NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, Missing, 'TargetResourceId>, value: azurerm.NetworkPacketCapture.NetworkPacketCaptureStorageLocation) : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.StorageLocation <- value)
            ({ assignments = state.assignments } : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#target_resource_id-1">NetworkPacketCapture#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, Missing>, value: string) : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, Present>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#filter-1">NetworkPacketCapture#filter</a> Accepts: azurerm.IResolvable | azurerm.NetworkPacketCapture.NetworkPacketCaptureFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>, value: HashiCorp.Cdktf.IResolvable) : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#id-1">NetworkPacketCapture#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>, value: string) : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#maximum_bytes_per_packet-1">NetworkPacketCapture#maximum_bytes_per_packet</a>.
        /// </summary>
        [<CustomOperation "maximum_bytes_per_packet">]
        member _.MaximumBytesPerPacket(state: NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>, value: double) : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.MaximumBytesPerPacket <- value)
            state : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#maximum_bytes_per_session-1">NetworkPacketCapture#maximum_bytes_per_session</a>.
        /// </summary>
        [<CustomOperation "maximum_bytes_per_session">]
        member _.MaximumBytesPerSession(state: NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>, value: double) : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.MaximumBytesPerSession <- value)
            state : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#maximum_capture_duration-1">NetworkPacketCapture#maximum_capture_duration</a>.
        /// </summary>
        [<CustomOperation "maximum_capture_duration">]
        member _.MaximumCaptureDuration(state: NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>, value: double) : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.MaximumCaptureDuration <- value)
            state : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#timeouts-1">NetworkPacketCapture#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>, value: azurerm.NetworkPacketCapture.NetworkPacketCaptureTimeouts) : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkPacketCaptureState<'Name, 'NetworkWatcherName, 'ResourceGroupName, 'StorageLocation, 'TargetResourceId>

        member _.Run(state: NetworkPacketCaptureState<Present, Present, Present, Present, Present>) : azurerm.NetworkPacketCapture.NetworkPacketCapture =
            let config = azurerm.NetworkPacketCapture.NetworkPacketCaptureConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkPacketCapture.NetworkPacketCapture(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkPacketCapture: missing required arguments. Must call: name, network_watcher_name, resource_group_name, storage_location, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkPacketCaptureState<_, _, _, _, _>) : azurerm.NetworkPacketCapture.NetworkPacketCapture =
            Unchecked.defaultof<azurerm.NetworkPacketCapture.NetworkPacketCapture>
