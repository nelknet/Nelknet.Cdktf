namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMobileNetworkPacketCoreControlPlaneState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermMobileNetworkPacketCoreControlPlane.DataAzurermMobileNetworkPacketCoreControlPlaneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_packet_core_control_plane">azurerm_mobile_network_packet_core_control_plane</a>.
    /// </summary>
    type DataAzurermMobileNetworkPacketCoreControlPlaneBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMobileNetworkPacketCoreControlPlaneState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkPacketCoreControlPlaneState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMobileNetworkPacketCoreControlPlaneState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkPacketCoreControlPlaneState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_packet_core_control_plane#name-1">DataAzurermMobileNetworkPacketCoreControlPlane#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMobileNetworkPacketCoreControlPlaneState<Missing, 'ResourceGroupName>, value: string) : DataAzurermMobileNetworkPacketCoreControlPlaneState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkPacketCoreControlPlaneState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_packet_core_control_plane#resource_group_name-1">DataAzurermMobileNetworkPacketCoreControlPlane#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMobileNetworkPacketCoreControlPlaneState<'Name, Missing>, value: string) : DataAzurermMobileNetworkPacketCoreControlPlaneState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkPacketCoreControlPlaneState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_packet_core_control_plane#id-1">DataAzurermMobileNetworkPacketCoreControlPlane#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMobileNetworkPacketCoreControlPlaneState<'Name, 'ResourceGroupName>, value: string) : DataAzurermMobileNetworkPacketCoreControlPlaneState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMobileNetworkPacketCoreControlPlaneState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_packet_core_control_plane#timeouts-1">DataAzurermMobileNetworkPacketCoreControlPlane#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMobileNetworkPacketCoreControlPlaneState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermMobileNetworkPacketCoreControlPlane.DataAzurermMobileNetworkPacketCoreControlPlaneTimeouts) : DataAzurermMobileNetworkPacketCoreControlPlaneState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMobileNetworkPacketCoreControlPlaneState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermMobileNetworkPacketCoreControlPlaneState<Present, Present>) : azurerm.DataAzurermMobileNetworkPacketCoreControlPlane.DataAzurermMobileNetworkPacketCoreControlPlane =
            let config = azurerm.DataAzurermMobileNetworkPacketCoreControlPlane.DataAzurermMobileNetworkPacketCoreControlPlaneConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMobileNetworkPacketCoreControlPlane.DataAzurermMobileNetworkPacketCoreControlPlane(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMobileNetworkPacketCoreControlPlane: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMobileNetworkPacketCoreControlPlaneState<_, _>) : azurerm.DataAzurermMobileNetworkPacketCoreControlPlane.DataAzurermMobileNetworkPacketCoreControlPlane =
            Unchecked.defaultof<azurerm.DataAzurermMobileNetworkPacketCoreControlPlane.DataAzurermMobileNetworkPacketCoreControlPlane>
