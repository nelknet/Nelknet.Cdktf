namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId> = { assignments: ResizeArray<aws.Ec2TransitGatewayConnectPeer.Ec2TransitGatewayConnectPeerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect_peer">aws_ec2_transit_gateway_connect_peer</a>.
    /// </summary>
    type Ec2TransitGatewayConnectPeerBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayConnectPeerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayConnectPeerState<Missing, Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayConnectPeerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayConnectPeerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect_peer#inside_cidr_blocks-1">Ec2TransitGatewayConnectPeer#inside_cidr_blocks</a>.
        /// </summary>
        [<CustomOperation "inside_cidr_blocks">]
        member _.InsideCidrBlocks(state: Ec2TransitGatewayConnectPeerState<Missing, 'PeerAddress, 'TransitGatewayAttachmentId>, value: seq<string>) : Ec2TransitGatewayConnectPeerState<Present, 'PeerAddress, 'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.InsideCidrBlocks <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : Ec2TransitGatewayConnectPeerState<Present, 'PeerAddress, 'TransitGatewayAttachmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect_peer#peer_address-1">Ec2TransitGatewayConnectPeer#peer_address</a>.
        /// </summary>
        [<CustomOperation "peer_address">]
        member _.PeerAddress(state: Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, Missing, 'TransitGatewayAttachmentId>, value: string) : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, Present, 'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.PeerAddress <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, Present, 'TransitGatewayAttachmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect_peer#transit_gateway_attachment_id-1">Ec2TransitGatewayConnectPeer#transit_gateway_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_attachment_id">]
        member _.TransitGatewayAttachmentId(state: Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, Missing>, value: string) : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayAttachmentId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect_peer#bgp_asn-1">Ec2TransitGatewayConnectPeer#bgp_asn</a>.
        /// </summary>
        [<CustomOperation "bgp_asn">]
        member _.BgpAsn(state: Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId>, value: string) : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.BgpAsn <- value)
            state : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect_peer#id-1">Ec2TransitGatewayConnectPeer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId>, value: string) : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect_peer#tags-1">Ec2TransitGatewayConnectPeer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId>, value: seq<string * string>) : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect_peer#tags_all-1">Ec2TransitGatewayConnectPeer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId>, value: seq<string * string>) : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect_peer#timeouts-1">Ec2TransitGatewayConnectPeer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId>, value: aws.Ec2TransitGatewayConnectPeer.Ec2TransitGatewayConnectPeerTimeouts) : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect_peer#transit_gateway_address-1">Ec2TransitGatewayConnectPeer#transit_gateway_address</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_address">]
        member _.TransitGatewayAddress(state: Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId>, value: string) : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.TransitGatewayAddress <- value)
            state : Ec2TransitGatewayConnectPeerState<'InsideCidrBlocks, 'PeerAddress, 'TransitGatewayAttachmentId>

        member _.Run(state: Ec2TransitGatewayConnectPeerState<Present, Present, Present>) : aws.Ec2TransitGatewayConnectPeer.Ec2TransitGatewayConnectPeer =
            let config = aws.Ec2TransitGatewayConnectPeer.Ec2TransitGatewayConnectPeerConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayConnectPeer.Ec2TransitGatewayConnectPeer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayConnectPeer: missing required arguments. Must call: inside_cidr_blocks, peer_address, transit_gateway_attachment_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayConnectPeerState<_, _, _>) : aws.Ec2TransitGatewayConnectPeer.Ec2TransitGatewayConnectPeer =
            Unchecked.defaultof<aws.Ec2TransitGatewayConnectPeer.Ec2TransitGatewayConnectPeer>
