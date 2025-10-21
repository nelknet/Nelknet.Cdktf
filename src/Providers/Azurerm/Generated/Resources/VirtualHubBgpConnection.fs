namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualHubBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'VirtualHubId> = { assignments: ResizeArray<azurerm.VirtualHubBgpConnection.VirtualHubBgpConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_bgp_connection">azurerm_virtual_hub_bgp_connection</a>.
    /// </summary>
    type VirtualHubBgpConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualHubBgpConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubBgpConnectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualHubBgpConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubBgpConnectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_bgp_connection#name-1">VirtualHubBgpConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualHubBgpConnectionState<Missing, 'PeerAsn, 'PeerIp, 'VirtualHubId>, value: string) : VirtualHubBgpConnectionState<Present, 'PeerAsn, 'PeerIp, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualHubBgpConnectionState<Present, 'PeerAsn, 'PeerIp, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_bgp_connection#peer_asn-1">VirtualHubBgpConnection#peer_asn</a>.
        /// </summary>
        [<CustomOperation "peer_asn">]
        member _.PeerAsn(state: VirtualHubBgpConnectionState<'Name, Missing, 'PeerIp, 'VirtualHubId>, value: double) : VirtualHubBgpConnectionState<'Name, Present, 'PeerIp, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.PeerAsn <- value)
            ({ assignments = state.assignments } : VirtualHubBgpConnectionState<'Name, Present, 'PeerIp, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_bgp_connection#peer_ip-1">VirtualHubBgpConnection#peer_ip</a>.
        /// </summary>
        [<CustomOperation "peer_ip">]
        member _.PeerIp(state: VirtualHubBgpConnectionState<'Name, 'PeerAsn, Missing, 'VirtualHubId>, value: string) : VirtualHubBgpConnectionState<'Name, 'PeerAsn, Present, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.PeerIp <- value)
            ({ assignments = state.assignments } : VirtualHubBgpConnectionState<'Name, 'PeerAsn, Present, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_bgp_connection#virtual_hub_id-1">VirtualHubBgpConnection#virtual_hub_id</a>.
        /// </summary>
        [<CustomOperation "virtual_hub_id">]
        member _.VirtualHubId(state: VirtualHubBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, Missing>, value: string) : VirtualHubBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, Present> =
            state.assignments.Add(fun config -> config.VirtualHubId <- value)
            ({ assignments = state.assignments } : VirtualHubBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_bgp_connection#id-1">VirtualHubBgpConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualHubBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'VirtualHubId>, value: string) : VirtualHubBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualHubBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'VirtualHubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_bgp_connection#timeouts-1">VirtualHubBgpConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualHubBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'VirtualHubId>, value: azurerm.VirtualHubBgpConnection.VirtualHubBgpConnectionTimeouts) : VirtualHubBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualHubBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_bgp_connection#virtual_network_connection_id-1">VirtualHubBgpConnection#virtual_network_connection_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_connection_id">]
        member _.VirtualNetworkConnectionId(state: VirtualHubBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'VirtualHubId>, value: string) : VirtualHubBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.VirtualNetworkConnectionId <- value)
            state : VirtualHubBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'VirtualHubId>

        member _.Run(state: VirtualHubBgpConnectionState<Present, Present, Present, Present>) : azurerm.VirtualHubBgpConnection.VirtualHubBgpConnection =
            let config = azurerm.VirtualHubBgpConnection.VirtualHubBgpConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualHubBgpConnection.VirtualHubBgpConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualHubBgpConnection: missing required arguments. Must call: name, peer_asn, peer_ip, virtual_hub_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualHubBgpConnectionState<_, _, _, _>) : azurerm.VirtualHubBgpConnection.VirtualHubBgpConnection =
            Unchecked.defaultof<azurerm.VirtualHubBgpConnection.VirtualHubBgpConnection>
