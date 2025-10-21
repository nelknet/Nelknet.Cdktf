namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcRouteServerPeerState<'PeerAddress, 'RouteServerEndpointId> = { assignments: ResizeArray<aws.VpcRouteServerPeer.VpcRouteServerPeerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_peer">aws_vpc_route_server_peer</a>.
    /// </summary>
    type VpcRouteServerPeerBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcRouteServerPeerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcRouteServerPeerState<Missing, Missing>)

        member _.Zero(()) : VpcRouteServerPeerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcRouteServerPeerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_peer#peer_address-1">VpcRouteServerPeer#peer_address</a>.
        /// </summary>
        [<CustomOperation "peer_address">]
        member _.PeerAddress(state: VpcRouteServerPeerState<Missing, 'RouteServerEndpointId>, value: string) : VpcRouteServerPeerState<Present, 'RouteServerEndpointId> =
            state.assignments.Add(fun config -> config.PeerAddress <- value)
            ({ assignments = state.assignments } : VpcRouteServerPeerState<Present, 'RouteServerEndpointId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_peer#route_server_endpoint_id-1">VpcRouteServerPeer#route_server_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "route_server_endpoint_id">]
        member _.RouteServerEndpointId(state: VpcRouteServerPeerState<'PeerAddress, Missing>, value: string) : VpcRouteServerPeerState<'PeerAddress, Present> =
            state.assignments.Add(fun config -> config.RouteServerEndpointId <- value)
            ({ assignments = state.assignments } : VpcRouteServerPeerState<'PeerAddress, Present>)

        /// <summary>
        /// bgp_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_peer#bgp_options-1">VpcRouteServerPeer#bgp_options</a> Accepts: aws.IResolvable | aws.VpcRouteServerPeer.VpcRouteServerPeerBgpOptions[]
        /// </summary>
        [<CustomOperation "bgp_options">]
        member _.BgpOptions(state: VpcRouteServerPeerState<'PeerAddress, 'RouteServerEndpointId>, value: HashiCorp.Cdktf.IResolvable) : VpcRouteServerPeerState<'PeerAddress, 'RouteServerEndpointId> =
            state.assignments.Add(fun config -> config.BgpOptions <- value)
            state : VpcRouteServerPeerState<'PeerAddress, 'RouteServerEndpointId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_peer#tags-1">VpcRouteServerPeer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcRouteServerPeerState<'PeerAddress, 'RouteServerEndpointId>, value: seq<string * string>) : VpcRouteServerPeerState<'PeerAddress, 'RouteServerEndpointId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcRouteServerPeerState<'PeerAddress, 'RouteServerEndpointId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_peer#timeouts-1">VpcRouteServerPeer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcRouteServerPeerState<'PeerAddress, 'RouteServerEndpointId>, value: aws.VpcRouteServerPeer.VpcRouteServerPeerTimeouts) : VpcRouteServerPeerState<'PeerAddress, 'RouteServerEndpointId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcRouteServerPeerState<'PeerAddress, 'RouteServerEndpointId>

        member _.Run(state: VpcRouteServerPeerState<Present, Present>) : aws.VpcRouteServerPeer.VpcRouteServerPeer =
            let config = aws.VpcRouteServerPeer.VpcRouteServerPeerConfig()
            for setter in state.assignments do
                setter config
            aws.VpcRouteServerPeer.VpcRouteServerPeer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcRouteServerPeer: missing required arguments. Must call: peer_address, route_server_endpoint_id.", 9999, IsError = true)>]
        member _.Run(_: VpcRouteServerPeerState<_, _>) : aws.VpcRouteServerPeer.VpcRouteServerPeer =
            Unchecked.defaultof<aws.VpcRouteServerPeer.VpcRouteServerPeer>
