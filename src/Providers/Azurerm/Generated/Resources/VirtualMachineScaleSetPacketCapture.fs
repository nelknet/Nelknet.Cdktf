namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId> = { assignments: ResizeArray<azurerm.VirtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture">azurerm_virtual_machine_scale_set_packet_capture</a>.
    /// </summary>
    type VirtualMachineScaleSetPacketCaptureBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualMachineScaleSetPacketCaptureState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineScaleSetPacketCaptureState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualMachineScaleSetPacketCaptureState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineScaleSetPacketCaptureState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#name-1">VirtualMachineScaleSetPacketCapture#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualMachineScaleSetPacketCaptureState<Missing, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>, value: string) : VirtualMachineScaleSetPacketCaptureState<Present, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetPacketCaptureState<Present, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#network_watcher_id-1">VirtualMachineScaleSetPacketCapture#network_watcher_id</a>.
        /// </summary>
        [<CustomOperation "network_watcher_id">]
        member _.NetworkWatcherId(state: VirtualMachineScaleSetPacketCaptureState<'Name, Missing, 'StorageLocation, 'VirtualMachineScaleSetId>, value: string) : VirtualMachineScaleSetPacketCaptureState<'Name, Present, 'StorageLocation, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.NetworkWatcherId <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetPacketCaptureState<'Name, Present, 'StorageLocation, 'VirtualMachineScaleSetId>)

        /// <summary>
        /// storage_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#storage_location-1">VirtualMachineScaleSetPacketCapture#storage_location</a>
        /// </summary>
        [<CustomOperation "storage_location">]
        member _.StorageLocation(state: VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, Missing, 'VirtualMachineScaleSetId>, value: azurerm.VirtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureStorageLocation) : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, Present, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.StorageLocation <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, Present, 'VirtualMachineScaleSetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#virtual_machine_scale_set_id-1">VirtualMachineScaleSetPacketCapture#virtual_machine_scale_set_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_scale_set_id">]
        member _.VirtualMachineScaleSetId(state: VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, Missing>, value: string) : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineScaleSetId <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, Present>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#filter-1">VirtualMachineScaleSetPacketCapture#filter</a> Accepts: azurerm.IResolvable | azurerm.VirtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#id-1">VirtualMachineScaleSetPacketCapture#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>, value: string) : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>

        /// <summary>
        /// machine_scope block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#machine_scope-1">VirtualMachineScaleSetPacketCapture#machine_scope</a>
        /// </summary>
        [<CustomOperation "machine_scope">]
        member _.MachineScope(state: VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>, value: azurerm.VirtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureMachineScope) : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.MachineScope <- value)
            state : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#maximum_bytes_per_packet-1">VirtualMachineScaleSetPacketCapture#maximum_bytes_per_packet</a>.
        /// </summary>
        [<CustomOperation "maximum_bytes_per_packet">]
        member _.MaximumBytesPerPacket(state: VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>, value: double) : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.MaximumBytesPerPacket <- value)
            state : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#maximum_bytes_per_session-1">VirtualMachineScaleSetPacketCapture#maximum_bytes_per_session</a>.
        /// </summary>
        [<CustomOperation "maximum_bytes_per_session">]
        member _.MaximumBytesPerSession(state: VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>, value: double) : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.MaximumBytesPerSession <- value)
            state : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#maximum_capture_duration_in_seconds-1">VirtualMachineScaleSetPacketCapture#maximum_capture_duration_in_seconds</a>.
        /// </summary>
        [<CustomOperation "maximum_capture_duration_in_seconds">]
        member _.MaximumCaptureDurationInSeconds(state: VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>, value: double) : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.MaximumCaptureDurationInSeconds <- value)
            state : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#timeouts-1">VirtualMachineScaleSetPacketCapture#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>, value: azurerm.VirtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureTimeouts) : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualMachineScaleSetPacketCaptureState<'Name, 'NetworkWatcherId, 'StorageLocation, 'VirtualMachineScaleSetId>

        member _.Run(state: VirtualMachineScaleSetPacketCaptureState<Present, Present, Present, Present>) : azurerm.VirtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCapture =
            let config = azurerm.VirtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCapture(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualMachineScaleSetPacketCapture: missing required arguments. Must call: name, network_watcher_id, storage_location, virtual_machine_scale_set_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualMachineScaleSetPacketCaptureState<_, _, _, _>) : azurerm.VirtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCapture =
            Unchecked.defaultof<azurerm.VirtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCapture>
