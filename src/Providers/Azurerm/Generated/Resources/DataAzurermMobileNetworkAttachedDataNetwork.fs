namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMobileNetworkAttachedDataNetworkState<'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> = { assignments: ResizeArray<azurerm.DataAzurermMobileNetworkAttachedDataNetwork.DataAzurermMobileNetworkAttachedDataNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_attached_data_network">azurerm_mobile_network_attached_data_network</a>.
    /// </summary>
    type DataAzurermMobileNetworkAttachedDataNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMobileNetworkAttachedDataNetworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkAttachedDataNetworkState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMobileNetworkAttachedDataNetworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkAttachedDataNetworkState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_attached_data_network#mobile_network_data_network_name-1">DataAzurermMobileNetworkAttachedDataNetwork#mobile_network_data_network_name</a>.
        /// </summary>
        [<CustomOperation "mobile_network_data_network_name">]
        member _.MobileNetworkDataNetworkName(state: DataAzurermMobileNetworkAttachedDataNetworkState<Missing, 'MobileNetworkPacketCoreDataPlaneId>, value: string) : DataAzurermMobileNetworkAttachedDataNetworkState<Present, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.MobileNetworkDataNetworkName <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkAttachedDataNetworkState<Present, 'MobileNetworkPacketCoreDataPlaneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_attached_data_network#mobile_network_packet_core_data_plane_id-1">DataAzurermMobileNetworkAttachedDataNetwork#mobile_network_packet_core_data_plane_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_packet_core_data_plane_id">]
        member _.MobileNetworkPacketCoreDataPlaneId(state: DataAzurermMobileNetworkAttachedDataNetworkState<'MobileNetworkDataNetworkName, Missing>, value: string) : DataAzurermMobileNetworkAttachedDataNetworkState<'MobileNetworkDataNetworkName, Present> =
            state.assignments.Add(fun config -> config.MobileNetworkPacketCoreDataPlaneId <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkAttachedDataNetworkState<'MobileNetworkDataNetworkName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_attached_data_network#id-1">DataAzurermMobileNetworkAttachedDataNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMobileNetworkAttachedDataNetworkState<'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: string) : DataAzurermMobileNetworkAttachedDataNetworkState<'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMobileNetworkAttachedDataNetworkState<'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_attached_data_network#timeouts-1">DataAzurermMobileNetworkAttachedDataNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMobileNetworkAttachedDataNetworkState<'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: azurerm.DataAzurermMobileNetworkAttachedDataNetwork.DataAzurermMobileNetworkAttachedDataNetworkTimeouts) : DataAzurermMobileNetworkAttachedDataNetworkState<'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMobileNetworkAttachedDataNetworkState<'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>

        member _.Run(state: DataAzurermMobileNetworkAttachedDataNetworkState<Present, Present>) : azurerm.DataAzurermMobileNetworkAttachedDataNetwork.DataAzurermMobileNetworkAttachedDataNetwork =
            let config = azurerm.DataAzurermMobileNetworkAttachedDataNetwork.DataAzurermMobileNetworkAttachedDataNetworkConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMobileNetworkAttachedDataNetwork.DataAzurermMobileNetworkAttachedDataNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMobileNetworkAttachedDataNetwork: missing required arguments. Must call: mobile_network_data_network_name, mobile_network_packet_core_data_plane_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMobileNetworkAttachedDataNetworkState<_, _>) : azurerm.DataAzurermMobileNetworkAttachedDataNetwork.DataAzurermMobileNetworkAttachedDataNetwork =
            Unchecked.defaultof<azurerm.DataAzurermMobileNetworkAttachedDataNetwork.DataAzurermMobileNetworkAttachedDataNetwork>
