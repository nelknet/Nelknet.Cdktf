namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> = { assignments: ResizeArray<azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane">azurerm_mobile_network_packet_core_control_plane</a>.
    /// </summary>
    type MobileNetworkPacketCoreControlPlaneBuilder(logicalId: string) =
        member _.Yield(_: unit) : MobileNetworkPacketCoreControlPlaneState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkPacketCoreControlPlaneState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MobileNetworkPacketCoreControlPlaneState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkPacketCoreControlPlaneState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// local_diagnostics_access block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#local_diagnostics_access-1">MobileNetworkPacketCoreControlPlane#local_diagnostics_access</a>
        /// </summary>
        [<CustomOperation "local_diagnostics_access">]
        member _.LocalDiagnosticsAccess(state: MobileNetworkPacketCoreControlPlaneState<Missing, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccess) : MobileNetworkPacketCoreControlPlaneState<Present, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.LocalDiagnosticsAccess <- value)
            ({ assignments = state.assignments } : MobileNetworkPacketCoreControlPlaneState<Present, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#location-1">MobileNetworkPacketCoreControlPlane#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, Missing, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: string) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, Present, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, Present, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#name-1">MobileNetworkPacketCoreControlPlane#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, Missing, 'ResourceGroupName, 'SiteIds, 'Sku>, value: string) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, Present, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, Present, 'ResourceGroupName, 'SiteIds, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#resource_group_name-1">MobileNetworkPacketCoreControlPlane#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, Missing, 'SiteIds, 'Sku>, value: string) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, Present, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, Present, 'SiteIds, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#site_ids-1">MobileNetworkPacketCoreControlPlane#site_ids</a>.
        /// </summary>
        [<CustomOperation "site_ids">]
        member _.SiteIds(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, Missing, 'Sku>, value: seq<string>) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, Present, 'Sku> =
            state.assignments.Add(fun config -> config.SiteIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#sku-1">MobileNetworkPacketCoreControlPlane#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, Missing>, value: string) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#control_plane_access_ipv4_address-1">MobileNetworkPacketCoreControlPlane#control_plane_access_ipv4_address</a>.
        /// </summary>
        [<CustomOperation "control_plane_access_ipv4_address">]
        member _.ControlPlaneAccessIpv4Address(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: string) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.ControlPlaneAccessIpv4Address <- value)
            state : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#control_plane_access_ipv4_gateway-1">MobileNetworkPacketCoreControlPlane#control_plane_access_ipv4_gateway</a>.
        /// </summary>
        [<CustomOperation "control_plane_access_ipv4_gateway">]
        member _.ControlPlaneAccessIpv4Gateway(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: string) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.ControlPlaneAccessIpv4Gateway <- value)
            state : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#control_plane_access_ipv4_subnet-1">MobileNetworkPacketCoreControlPlane#control_plane_access_ipv4_subnet</a>.
        /// </summary>
        [<CustomOperation "control_plane_access_ipv4_subnet">]
        member _.ControlPlaneAccessIpv4Subnet(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: string) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.ControlPlaneAccessIpv4Subnet <- value)
            state : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#control_plane_access_name-1">MobileNetworkPacketCoreControlPlane#control_plane_access_name</a>.
        /// </summary>
        [<CustomOperation "control_plane_access_name">]
        member _.ControlPlaneAccessName(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: string) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.ControlPlaneAccessName <- value)
            state : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#core_network_technology-1">MobileNetworkPacketCoreControlPlane#core_network_technology</a>.
        /// </summary>
        [<CustomOperation "core_network_technology">]
        member _.CoreNetworkTechnology(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: string) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.CoreNetworkTechnology <- value)
            state : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#id-1">MobileNetworkPacketCoreControlPlane#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: string) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#identity-1">MobileNetworkPacketCoreControlPlane#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneIdentity) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#interoperability_settings_json-1">MobileNetworkPacketCoreControlPlane#interoperability_settings_json</a>.
        /// </summary>
        [<CustomOperation "interoperability_settings_json">]
        member _.InteroperabilitySettingsJson(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: string) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.InteroperabilitySettingsJson <- value)
            state : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>

        /// <summary>
        /// platform block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#platform-1">MobileNetworkPacketCoreControlPlane#platform</a>
        /// </summary>
        [<CustomOperation "platform">]
        member _.Platform(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlanePlatform) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.Platform <- value)
            state : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#software_version-1">MobileNetworkPacketCoreControlPlane#software_version</a>.
        /// </summary>
        [<CustomOperation "software_version">]
        member _.SoftwareVersion(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: string) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.SoftwareVersion <- value)
            state : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#tags-1">MobileNetworkPacketCoreControlPlane#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: seq<string * string>) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#timeouts-1">MobileNetworkPacketCoreControlPlane#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneTimeouts) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#user_equipment_mtu_in_bytes-1">MobileNetworkPacketCoreControlPlane#user_equipment_mtu_in_bytes</a>.
        /// </summary>
        [<CustomOperation "user_equipment_mtu_in_bytes">]
        member _.UserEquipmentMtuInBytes(state: MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>, value: double) : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku> =
            state.assignments.Add(fun config -> config.UserEquipmentMtuInBytes <- value)
            state : MobileNetworkPacketCoreControlPlaneState<'LocalDiagnosticsAccess, 'Location, 'Name, 'ResourceGroupName, 'SiteIds, 'Sku>

        member _.Run(state: MobileNetworkPacketCoreControlPlaneState<Present, Present, Present, Present, Present, Present>) : azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlane =
            let config = azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneConfig()
            for setter in state.assignments do
                setter config
            azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlane(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mobileNetworkPacketCoreControlPlane: missing required arguments. Must call: local_diagnostics_access, location, name, resource_group_name, site_ids, sku.", 9999, IsError = true)>]
        member _.Run(_: MobileNetworkPacketCoreControlPlaneState<_, _, _, _, _, _>) : azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlane =
            Unchecked.defaultof<azurerm.MobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlane>
