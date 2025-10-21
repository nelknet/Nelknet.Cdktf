namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId> = { assignments: ResizeArray<azurerm.VirtualMachinePacketCapture.VirtualMachinePacketCaptureConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture">azurerm_virtual_machine_packet_capture</a>.
    /// </summary>
    type VirtualMachinePacketCaptureBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualMachinePacketCaptureState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachinePacketCaptureState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualMachinePacketCaptureState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachinePacketCaptureState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#name-1">VirtualMachinePacketCapture#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualMachinePacketCaptureState<Missing, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>, value: string) : VirtualMachinePacketCaptureState<Present, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualMachinePacketCaptureState<Present, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#network_watcher_id-1">VirtualMachinePacketCapture#network_watcher_id</a>.
        /// </summary>
        [<CustomOperation "network_watcher_id">]
        member _.NetworkWatcherId(state: VirtualMachinePacketCaptureState<'Name, Missing, 'StorageLocation, 'VirtualMachineId>, value: string) : VirtualMachinePacketCaptureState<'Name, Present, 'StorageLocation, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.NetworkWatcherId <- value)
            ({ assignments = state.assignments } : VirtualMachinePacketCaptureState<'Name, Present, 'StorageLocation, 'VirtualMachineId>)

        /// <summary>
        /// storage_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#storage_location-1">VirtualMachinePacketCapture#storage_location</a>
        /// </summary>
        [<CustomOperation "storage_location">]
        member _.StorageLocation(state: VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, Missing, 'VirtualMachineId>, value: azurerm.VirtualMachinePacketCapture.VirtualMachinePacketCaptureStorageLocation) : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, Present, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.StorageLocation <- value)
            ({ assignments = state.assignments } : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, Present, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#virtual_machine_id-1">VirtualMachinePacketCapture#virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_id">]
        member _.VirtualMachineId(state: VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, Missing>, value: string) : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineId <- value)
            ({ assignments = state.assignments } : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, Present>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#filter-1">VirtualMachinePacketCapture#filter</a> Accepts: azurerm.IResolvable | azurerm.VirtualMachinePacketCapture.VirtualMachinePacketCaptureFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#id-1">VirtualMachinePacketCapture#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>, value: string) : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#maximum_bytes_per_packet-1">VirtualMachinePacketCapture#maximum_bytes_per_packet</a>.
        /// </summary>
        [<CustomOperation "maximum_bytes_per_packet">]
        member _.MaximumBytesPerPacket(state: VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>, value: double) : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.MaximumBytesPerPacket <- value)
            state : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#maximum_bytes_per_session-1">VirtualMachinePacketCapture#maximum_bytes_per_session</a>.
        /// </summary>
        [<CustomOperation "maximum_bytes_per_session">]
        member _.MaximumBytesPerSession(state: VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>, value: double) : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.MaximumBytesPerSession <- value)
            state : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#maximum_capture_duration_in_seconds-1">VirtualMachinePacketCapture#maximum_capture_duration_in_seconds</a>.
        /// </summary>
        [<CustomOperation "maximum_capture_duration_in_seconds">]
        member _.MaximumCaptureDurationInSeconds(state: VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>, value: double) : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.MaximumCaptureDurationInSeconds <- value)
            state : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#timeouts-1">VirtualMachinePacketCapture#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>, value: azurerm.VirtualMachinePacketCapture.VirtualMachinePacketCaptureTimeouts) : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualMachinePacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineId>

        member _.Run(state: VirtualMachinePacketCaptureState<Present, Present, Present, Present>) : azurerm.VirtualMachinePacketCapture.VirtualMachinePacketCapture =
            let config = azurerm.VirtualMachinePacketCapture.VirtualMachinePacketCaptureConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualMachinePacketCapture.VirtualMachinePacketCapture(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualMachinePacketCapture: missing required arguments. Must call: name, network_watcher_id, storage_location, virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualMachinePacketCaptureState<_, _, _, _>) : azurerm.VirtualMachinePacketCapture.VirtualMachinePacketCapture =
            Unchecked.defaultof<azurerm.VirtualMachinePacketCapture.VirtualMachinePacketCapture>
