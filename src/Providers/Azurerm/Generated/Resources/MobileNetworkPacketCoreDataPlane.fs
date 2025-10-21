namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name> = { assignments: ResizeArray<azurerm.MobileNetworkPacketCoreDataPlane.MobileNetworkPacketCoreDataPlaneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_data_plane">azurerm_mobile_network_packet_core_data_plane</a>.
    /// </summary>
    type MobileNetworkPacketCoreDataPlaneBuilder(logicalId: string) =
        member _.Yield(_: unit) : MobileNetworkPacketCoreDataPlaneState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkPacketCoreDataPlaneState<Missing, Missing, Missing>)

        member _.Zero(()) : MobileNetworkPacketCoreDataPlaneState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkPacketCoreDataPlaneState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_data_plane#location-1">MobileNetworkPacketCoreDataPlane#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MobileNetworkPacketCoreDataPlaneState<Missing, 'MobileNetworkPacketCoreControlPlaneId, 'Name>, value: string) : MobileNetworkPacketCoreDataPlaneState<Present, 'MobileNetworkPacketCoreControlPlaneId, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MobileNetworkPacketCoreDataPlaneState<Present, 'MobileNetworkPacketCoreControlPlaneId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_data_plane#mobile_network_packet_core_control_plane_id-1">MobileNetworkPacketCoreDataPlane#mobile_network_packet_core_control_plane_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_packet_core_control_plane_id">]
        member _.MobileNetworkPacketCoreControlPlaneId(state: MobileNetworkPacketCoreDataPlaneState<'Location, Missing, 'Name>, value: string) : MobileNetworkPacketCoreDataPlaneState<'Location, Present, 'Name> =
            state.assignments.Add(fun config -> config.MobileNetworkPacketCoreControlPlaneId <- value)
            ({ assignments = state.assignments } : MobileNetworkPacketCoreDataPlaneState<'Location, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_data_plane#name-1">MobileNetworkPacketCoreDataPlane#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, Missing>, value: string) : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_data_plane#id-1">MobileNetworkPacketCoreDataPlane#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>, value: string) : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_data_plane#tags-1">MobileNetworkPacketCoreDataPlane#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>, value: seq<string * string>) : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_data_plane#timeouts-1">MobileNetworkPacketCoreDataPlane#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>, value: azurerm.MobileNetworkPacketCoreDataPlane.MobileNetworkPacketCoreDataPlaneTimeouts) : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_data_plane#user_plane_access_ipv4_address-1">MobileNetworkPacketCoreDataPlane#user_plane_access_ipv4_address</a>.
        /// </summary>
        [<CustomOperation "user_plane_access_ipv4_address">]
        member _.UserPlaneAccessIpv4Address(state: MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>, value: string) : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name> =
            state.assignments.Add(fun config -> config.UserPlaneAccessIpv4Address <- value)
            state : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_data_plane#user_plane_access_ipv4_gateway-1">MobileNetworkPacketCoreDataPlane#user_plane_access_ipv4_gateway</a>.
        /// </summary>
        [<CustomOperation "user_plane_access_ipv4_gateway">]
        member _.UserPlaneAccessIpv4Gateway(state: MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>, value: string) : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name> =
            state.assignments.Add(fun config -> config.UserPlaneAccessIpv4Gateway <- value)
            state : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_data_plane#user_plane_access_ipv4_subnet-1">MobileNetworkPacketCoreDataPlane#user_plane_access_ipv4_subnet</a>.
        /// </summary>
        [<CustomOperation "user_plane_access_ipv4_subnet">]
        member _.UserPlaneAccessIpv4Subnet(state: MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>, value: string) : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name> =
            state.assignments.Add(fun config -> config.UserPlaneAccessIpv4Subnet <- value)
            state : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_data_plane#user_plane_access_name-1">MobileNetworkPacketCoreDataPlane#user_plane_access_name</a>.
        /// </summary>
        [<CustomOperation "user_plane_access_name">]
        member _.UserPlaneAccessName(state: MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>, value: string) : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name> =
            state.assignments.Add(fun config -> config.UserPlaneAccessName <- value)
            state : MobileNetworkPacketCoreDataPlaneState<'Location, 'MobileNetworkPacketCoreControlPlaneId, 'Name>

        member _.Run(state: MobileNetworkPacketCoreDataPlaneState<Present, Present, Present>) : azurerm.MobileNetworkPacketCoreDataPlane.MobileNetworkPacketCoreDataPlane =
            let config = azurerm.MobileNetworkPacketCoreDataPlane.MobileNetworkPacketCoreDataPlaneConfig()
            for setter in state.assignments do
                setter config
            azurerm.MobileNetworkPacketCoreDataPlane.MobileNetworkPacketCoreDataPlane(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mobileNetworkPacketCoreDataPlane: missing required arguments. Must call: location, mobile_network_packet_core_control_plane_id, name.", 9999, IsError = true)>]
        member _.Run(_: MobileNetworkPacketCoreDataPlaneState<_, _, _>) : azurerm.MobileNetworkPacketCoreDataPlane.MobileNetworkPacketCoreDataPlane =
            Unchecked.defaultof<azurerm.MobileNetworkPacketCoreDataPlane.MobileNetworkPacketCoreDataPlane>
