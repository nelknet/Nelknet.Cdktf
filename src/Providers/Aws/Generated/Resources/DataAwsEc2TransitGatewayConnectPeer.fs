namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayConnectPeerState = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayConnectPeer.DataAwsEc2TransitGatewayConnectPeerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_connect_peer">aws_ec2_transit_gateway_connect_peer</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayConnectPeerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayConnectPeerState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayConnectPeerState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_connect_peer#filter-1">DataAwsEc2TransitGatewayConnectPeer#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayConnectPeer.DataAwsEc2TransitGatewayConnectPeerFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayConnectPeerState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayConnectPeerState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayConnectPeerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_connect_peer#id-1">DataAwsEc2TransitGatewayConnectPeer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayConnectPeerState, value: string) : DataAwsEc2TransitGatewayConnectPeerState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayConnectPeerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_connect_peer#tags-1">DataAwsEc2TransitGatewayConnectPeer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2TransitGatewayConnectPeerState, value: seq<string * string>) : DataAwsEc2TransitGatewayConnectPeerState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2TransitGatewayConnectPeerState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_connect_peer#timeouts-1">DataAwsEc2TransitGatewayConnectPeer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayConnectPeerState, value: aws.DataAwsEc2TransitGatewayConnectPeer.DataAwsEc2TransitGatewayConnectPeerTimeouts) : DataAwsEc2TransitGatewayConnectPeerState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayConnectPeerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_connect_peer#transit_gateway_connect_peer_id-1">DataAwsEc2TransitGatewayConnectPeer#transit_gateway_connect_peer_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_connect_peer_id">]
        member _.TransitGatewayConnectPeerId(state: DataAwsEc2TransitGatewayConnectPeerState, value: string) : DataAwsEc2TransitGatewayConnectPeerState =
            state.assignments.Add(fun config -> config.TransitGatewayConnectPeerId <- value)
            state : DataAwsEc2TransitGatewayConnectPeerState

        member _.Run(state: DataAwsEc2TransitGatewayConnectPeerState) : aws.DataAwsEc2TransitGatewayConnectPeer.DataAwsEc2TransitGatewayConnectPeer =
            let config = aws.DataAwsEc2TransitGatewayConnectPeer.DataAwsEc2TransitGatewayConnectPeerConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayConnectPeer.DataAwsEc2TransitGatewayConnectPeer(StackContext.get (), logicalId, config)
