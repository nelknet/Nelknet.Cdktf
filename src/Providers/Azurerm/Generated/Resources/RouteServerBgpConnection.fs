namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RouteServerBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'RouteServerId> = { assignments: ResizeArray<azurerm.RouteServerBgpConnection.RouteServerBgpConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server_bgp_connection">azurerm_route_server_bgp_connection</a>.
    /// </summary>
    type RouteServerBgpConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : RouteServerBgpConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RouteServerBgpConnectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RouteServerBgpConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RouteServerBgpConnectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server_bgp_connection#name-1">RouteServerBgpConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RouteServerBgpConnectionState<Missing, 'PeerAsn, 'PeerIp, 'RouteServerId>, value: string) : RouteServerBgpConnectionState<Present, 'PeerAsn, 'PeerIp, 'RouteServerId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RouteServerBgpConnectionState<Present, 'PeerAsn, 'PeerIp, 'RouteServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server_bgp_connection#peer_asn-1">RouteServerBgpConnection#peer_asn</a>.
        /// </summary>
        [<CustomOperation "peer_asn">]
        member _.PeerAsn(state: RouteServerBgpConnectionState<'Name, Missing, 'PeerIp, 'RouteServerId>, value: double) : RouteServerBgpConnectionState<'Name, Present, 'PeerIp, 'RouteServerId> =
            state.assignments.Add(fun config -> config.PeerAsn <- value)
            ({ assignments = state.assignments } : RouteServerBgpConnectionState<'Name, Present, 'PeerIp, 'RouteServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server_bgp_connection#peer_ip-1">RouteServerBgpConnection#peer_ip</a>.
        /// </summary>
        [<CustomOperation "peer_ip">]
        member _.PeerIp(state: RouteServerBgpConnectionState<'Name, 'PeerAsn, Missing, 'RouteServerId>, value: string) : RouteServerBgpConnectionState<'Name, 'PeerAsn, Present, 'RouteServerId> =
            state.assignments.Add(fun config -> config.PeerIp <- value)
            ({ assignments = state.assignments } : RouteServerBgpConnectionState<'Name, 'PeerAsn, Present, 'RouteServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server_bgp_connection#route_server_id-1">RouteServerBgpConnection#route_server_id</a>.
        /// </summary>
        [<CustomOperation "route_server_id">]
        member _.RouteServerId(state: RouteServerBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, Missing>, value: string) : RouteServerBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, Present> =
            state.assignments.Add(fun config -> config.RouteServerId <- value)
            ({ assignments = state.assignments } : RouteServerBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server_bgp_connection#id-1">RouteServerBgpConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RouteServerBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'RouteServerId>, value: string) : RouteServerBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'RouteServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RouteServerBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'RouteServerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server_bgp_connection#timeouts-1">RouteServerBgpConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RouteServerBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'RouteServerId>, value: azurerm.RouteServerBgpConnection.RouteServerBgpConnectionTimeouts) : RouteServerBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'RouteServerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RouteServerBgpConnectionState<'Name, 'PeerAsn, 'PeerIp, 'RouteServerId>

        member _.Run(state: RouteServerBgpConnectionState<Present, Present, Present, Present>) : azurerm.RouteServerBgpConnection.RouteServerBgpConnection =
            let config = azurerm.RouteServerBgpConnection.RouteServerBgpConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.RouteServerBgpConnection.RouteServerBgpConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.routeServerBgpConnection: missing required arguments. Must call: name, peer_asn, peer_ip, route_server_id.", 9999, IsError = true)>]
        member _.Run(_: RouteServerBgpConnectionState<_, _, _, _>) : azurerm.RouteServerBgpConnection.RouteServerBgpConnection =
            Unchecked.defaultof<azurerm.RouteServerBgpConnection.RouteServerBgpConnection>
