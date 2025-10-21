namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> = { assignments: ResizeArray<azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network">azurerm_mobile_network_attached_data_network</a>.
    /// </summary>
    type MobileNetworkAttachedDataNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : MobileNetworkAttachedDataNetworkState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkAttachedDataNetworkState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MobileNetworkAttachedDataNetworkState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkAttachedDataNetworkState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#dns_addresses-1">MobileNetworkAttachedDataNetwork#dns_addresses</a>.
        /// </summary>
        [<CustomOperation "dns_addresses">]
        member _.DnsAddresses(state: MobileNetworkAttachedDataNetworkState<Missing, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: seq<string>) : MobileNetworkAttachedDataNetworkState<Present, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.DnsAddresses <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MobileNetworkAttachedDataNetworkState<Present, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#location-1">MobileNetworkAttachedDataNetwork#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MobileNetworkAttachedDataNetworkState<'DnsAddresses, Missing, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: string) : MobileNetworkAttachedDataNetworkState<'DnsAddresses, Present, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MobileNetworkAttachedDataNetworkState<'DnsAddresses, Present, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#mobile_network_data_network_name-1">MobileNetworkAttachedDataNetwork#mobile_network_data_network_name</a>.
        /// </summary>
        [<CustomOperation "mobile_network_data_network_name">]
        member _.MobileNetworkDataNetworkName(state: MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, Missing, 'MobileNetworkPacketCoreDataPlaneId>, value: string) : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, Present, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.MobileNetworkDataNetworkName <- value)
            ({ assignments = state.assignments } : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, Present, 'MobileNetworkPacketCoreDataPlaneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#mobile_network_packet_core_data_plane_id-1">MobileNetworkAttachedDataNetwork#mobile_network_packet_core_data_plane_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_packet_core_data_plane_id">]
        member _.MobileNetworkPacketCoreDataPlaneId(state: MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, Missing>, value: string) : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, Present> =
            state.assignments.Add(fun config -> config.MobileNetworkPacketCoreDataPlaneId <- value)
            ({ assignments = state.assignments } : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#id-1">MobileNetworkAttachedDataNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: string) : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>

        /// <summary>
        /// network_address_port_translation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#network_address_port_translation-1">MobileNetworkAttachedDataNetwork#network_address_port_translation</a>
        /// </summary>
        [<CustomOperation "network_address_port_translation">]
        member _.NetworkAddressPortTranslation(state: MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslation) : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.NetworkAddressPortTranslation <- value)
            state : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#tags-1">MobileNetworkAttachedDataNetwork#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: seq<string * string>) : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#timeouts-1">MobileNetworkAttachedDataNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkTimeouts) : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#user_equipment_address_pool_prefixes-1">MobileNetworkAttachedDataNetwork#user_equipment_address_pool_prefixes</a>.
        /// </summary>
        [<CustomOperation "user_equipment_address_pool_prefixes">]
        member _.UserEquipmentAddressPoolPrefixes(state: MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: seq<string>) : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.UserEquipmentAddressPoolPrefixes <- (value |> Seq.toArray))
            state : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#user_equipment_static_address_pool_prefixes-1">MobileNetworkAttachedDataNetwork#user_equipment_static_address_pool_prefixes</a>.
        /// </summary>
        [<CustomOperation "user_equipment_static_address_pool_prefixes">]
        member _.UserEquipmentStaticAddressPoolPrefixes(state: MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: seq<string>) : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.UserEquipmentStaticAddressPoolPrefixes <- (value |> Seq.toArray))
            state : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#user_plane_access_ipv4_address-1">MobileNetworkAttachedDataNetwork#user_plane_access_ipv4_address</a>.
        /// </summary>
        [<CustomOperation "user_plane_access_ipv4_address">]
        member _.UserPlaneAccessIpv4Address(state: MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: string) : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.UserPlaneAccessIpv4Address <- value)
            state : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#user_plane_access_ipv4_gateway-1">MobileNetworkAttachedDataNetwork#user_plane_access_ipv4_gateway</a>.
        /// </summary>
        [<CustomOperation "user_plane_access_ipv4_gateway">]
        member _.UserPlaneAccessIpv4Gateway(state: MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: string) : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.UserPlaneAccessIpv4Gateway <- value)
            state : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#user_plane_access_ipv4_subnet-1">MobileNetworkAttachedDataNetwork#user_plane_access_ipv4_subnet</a>.
        /// </summary>
        [<CustomOperation "user_plane_access_ipv4_subnet">]
        member _.UserPlaneAccessIpv4Subnet(state: MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: string) : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.UserPlaneAccessIpv4Subnet <- value)
            state : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_attached_data_network#user_plane_access_name-1">MobileNetworkAttachedDataNetwork#user_plane_access_name</a>.
        /// </summary>
        [<CustomOperation "user_plane_access_name">]
        member _.UserPlaneAccessName(state: MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>, value: string) : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId> =
            state.assignments.Add(fun config -> config.UserPlaneAccessName <- value)
            state : MobileNetworkAttachedDataNetworkState<'DnsAddresses, 'Location, 'MobileNetworkDataNetworkName, 'MobileNetworkPacketCoreDataPlaneId>

        member _.Run(state: MobileNetworkAttachedDataNetworkState<Present, Present, Present, Present>) : azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetwork =
            let config = azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkConfig()
            for setter in state.assignments do
                setter config
            azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mobileNetworkAttachedDataNetwork: missing required arguments. Must call: dns_addresses, location, mobile_network_data_network_name, mobile_network_packet_core_data_plane_id.", 9999, IsError = true)>]
        member _.Run(_: MobileNetworkAttachedDataNetworkState<_, _, _, _>) : azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetwork =
            Unchecked.defaultof<azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetwork>
