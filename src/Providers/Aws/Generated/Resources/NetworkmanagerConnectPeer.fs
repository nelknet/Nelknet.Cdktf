namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress> = { assignments: ResizeArray<aws.NetworkmanagerConnectPeer.NetworkmanagerConnectPeerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer">aws_networkmanager_connect_peer</a>.
    /// </summary>
    type NetworkmanagerConnectPeerBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerConnectPeerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerConnectPeerState<Missing, Missing>)

        member _.Zero(()) : NetworkmanagerConnectPeerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerConnectPeerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer#connect_attachment_id-1">NetworkmanagerConnectPeer#connect_attachment_id</a>.
        /// </summary>
        [<CustomOperation "connect_attachment_id">]
        member _.ConnectAttachmentId(state: NetworkmanagerConnectPeerState<Missing, 'PeerAddress>, value: string) : NetworkmanagerConnectPeerState<Present, 'PeerAddress> =
            state.assignments.Add(fun config -> config.ConnectAttachmentId <- value)
            ({ assignments = state.assignments } : NetworkmanagerConnectPeerState<Present, 'PeerAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer#peer_address-1">NetworkmanagerConnectPeer#peer_address</a>.
        /// </summary>
        [<CustomOperation "peer_address">]
        member _.PeerAddress(state: NetworkmanagerConnectPeerState<'ConnectAttachmentId, Missing>, value: string) : NetworkmanagerConnectPeerState<'ConnectAttachmentId, Present> =
            state.assignments.Add(fun config -> config.PeerAddress <- value)
            ({ assignments = state.assignments } : NetworkmanagerConnectPeerState<'ConnectAttachmentId, Present>)

        /// <summary>
        /// bgp_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer#bgp_options-1">NetworkmanagerConnectPeer#bgp_options</a>
        /// </summary>
        [<CustomOperation "bgp_options">]
        member _.BgpOptions(state: NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>, value: aws.NetworkmanagerConnectPeer.NetworkmanagerConnectPeerBgpOptions) : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress> =
            state.assignments.Add(fun config -> config.BgpOptions <- value)
            state : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer#core_network_address-1">NetworkmanagerConnectPeer#core_network_address</a>.
        /// </summary>
        [<CustomOperation "core_network_address">]
        member _.CoreNetworkAddress(state: NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>, value: string) : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress> =
            state.assignments.Add(fun config -> config.CoreNetworkAddress <- value)
            state : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer#id-1">NetworkmanagerConnectPeer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>, value: string) : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer#inside_cidr_blocks-1">NetworkmanagerConnectPeer#inside_cidr_blocks</a>.
        /// </summary>
        [<CustomOperation "inside_cidr_blocks">]
        member _.InsideCidrBlocks(state: NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>, value: seq<string>) : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress> =
            state.assignments.Add(fun config -> config.InsideCidrBlocks <- (value |> Seq.toArray))
            state : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer#subnet_arn-1">NetworkmanagerConnectPeer#subnet_arn</a>.
        /// </summary>
        [<CustomOperation "subnet_arn">]
        member _.SubnetArn(state: NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>, value: string) : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress> =
            state.assignments.Add(fun config -> config.SubnetArn <- value)
            state : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer#tags-1">NetworkmanagerConnectPeer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>, value: seq<string * string>) : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer#tags_all-1">NetworkmanagerConnectPeer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>, value: seq<string * string>) : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer#timeouts-1">NetworkmanagerConnectPeer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>, value: aws.NetworkmanagerConnectPeer.NetworkmanagerConnectPeerTimeouts) : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerConnectPeerState<'ConnectAttachmentId, 'PeerAddress>

        member _.Run(state: NetworkmanagerConnectPeerState<Present, Present>) : aws.NetworkmanagerConnectPeer.NetworkmanagerConnectPeer =
            let config = aws.NetworkmanagerConnectPeer.NetworkmanagerConnectPeerConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerConnectPeer.NetworkmanagerConnectPeer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerConnectPeer: missing required arguments. Must call: connect_attachment_id, peer_address.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerConnectPeerState<_, _>) : aws.NetworkmanagerConnectPeer.NetworkmanagerConnectPeer =
            Unchecked.defaultof<aws.NetworkmanagerConnectPeer.NetworkmanagerConnectPeer>
