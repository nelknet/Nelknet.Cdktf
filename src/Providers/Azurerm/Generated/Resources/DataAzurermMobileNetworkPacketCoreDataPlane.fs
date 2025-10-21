namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMobileNetworkPacketCoreDataPlaneState<'MobileNetworkPacketCoreControlPlaneId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermMobileNetworkPacketCoreDataPlane.DataAzurermMobileNetworkPacketCoreDataPlaneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_packet_core_data_plane">azurerm_mobile_network_packet_core_data_plane</a>.
    /// </summary>
    type DataAzurermMobileNetworkPacketCoreDataPlaneBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMobileNetworkPacketCoreDataPlaneState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkPacketCoreDataPlaneState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMobileNetworkPacketCoreDataPlaneState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkPacketCoreDataPlaneState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_packet_core_data_plane#mobile_network_packet_core_control_plane_id-1">DataAzurermMobileNetworkPacketCoreDataPlane#mobile_network_packet_core_control_plane_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_packet_core_control_plane_id">]
        member _.MobileNetworkPacketCoreControlPlaneId(state: DataAzurermMobileNetworkPacketCoreDataPlaneState<Missing, 'Name>, value: string) : DataAzurermMobileNetworkPacketCoreDataPlaneState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MobileNetworkPacketCoreControlPlaneId <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkPacketCoreDataPlaneState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_packet_core_data_plane#name-1">DataAzurermMobileNetworkPacketCoreDataPlane#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMobileNetworkPacketCoreDataPlaneState<'MobileNetworkPacketCoreControlPlaneId, Missing>, value: string) : DataAzurermMobileNetworkPacketCoreDataPlaneState<'MobileNetworkPacketCoreControlPlaneId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkPacketCoreDataPlaneState<'MobileNetworkPacketCoreControlPlaneId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_packet_core_data_plane#id-1">DataAzurermMobileNetworkPacketCoreDataPlane#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMobileNetworkPacketCoreDataPlaneState<'MobileNetworkPacketCoreControlPlaneId, 'Name>, value: string) : DataAzurermMobileNetworkPacketCoreDataPlaneState<'MobileNetworkPacketCoreControlPlaneId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMobileNetworkPacketCoreDataPlaneState<'MobileNetworkPacketCoreControlPlaneId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_packet_core_data_plane#timeouts-1">DataAzurermMobileNetworkPacketCoreDataPlane#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMobileNetworkPacketCoreDataPlaneState<'MobileNetworkPacketCoreControlPlaneId, 'Name>, value: azurerm.DataAzurermMobileNetworkPacketCoreDataPlane.DataAzurermMobileNetworkPacketCoreDataPlaneTimeouts) : DataAzurermMobileNetworkPacketCoreDataPlaneState<'MobileNetworkPacketCoreControlPlaneId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMobileNetworkPacketCoreDataPlaneState<'MobileNetworkPacketCoreControlPlaneId, 'Name>

        member _.Run(state: DataAzurermMobileNetworkPacketCoreDataPlaneState<Present, Present>) : azurerm.DataAzurermMobileNetworkPacketCoreDataPlane.DataAzurermMobileNetworkPacketCoreDataPlane =
            let config = azurerm.DataAzurermMobileNetworkPacketCoreDataPlane.DataAzurermMobileNetworkPacketCoreDataPlaneConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMobileNetworkPacketCoreDataPlane.DataAzurermMobileNetworkPacketCoreDataPlane(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMobileNetworkPacketCoreDataPlane: missing required arguments. Must call: mobile_network_packet_core_control_plane_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMobileNetworkPacketCoreDataPlaneState<_, _>) : azurerm.DataAzurermMobileNetworkPacketCoreDataPlane.DataAzurermMobileNetworkPacketCoreDataPlane =
            Unchecked.defaultof<azurerm.DataAzurermMobileNetworkPacketCoreDataPlane.DataAzurermMobileNetworkPacketCoreDataPlane>
