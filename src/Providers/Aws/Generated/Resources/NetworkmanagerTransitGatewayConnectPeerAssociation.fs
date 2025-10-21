namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, 'GlobalNetworkId, 'TransitGatewayConnectPeerArn> = { assignments: ResizeArray<aws.NetworkmanagerTransitGatewayConnectPeerAssociation.NetworkmanagerTransitGatewayConnectPeerAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_connect_peer_association">aws_networkmanager_transit_gateway_connect_peer_association</a>.
    /// </summary>
    type NetworkmanagerTransitGatewayConnectPeerAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerTransitGatewayConnectPeerAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerTransitGatewayConnectPeerAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkmanagerTransitGatewayConnectPeerAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerTransitGatewayConnectPeerAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#device_id-1">NetworkmanagerTransitGatewayConnectPeerAssociation#device_id</a>.
        /// </summary>
        [<CustomOperation "device_id">]
        member _.DeviceId(state: NetworkmanagerTransitGatewayConnectPeerAssociationState<Missing, 'GlobalNetworkId, 'TransitGatewayConnectPeerArn>, value: string) : NetworkmanagerTransitGatewayConnectPeerAssociationState<Present, 'GlobalNetworkId, 'TransitGatewayConnectPeerArn> =
            state.assignments.Add(fun config -> config.DeviceId <- value)
            ({ assignments = state.assignments } : NetworkmanagerTransitGatewayConnectPeerAssociationState<Present, 'GlobalNetworkId, 'TransitGatewayConnectPeerArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#global_network_id-1">NetworkmanagerTransitGatewayConnectPeerAssociation#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, Missing, 'TransitGatewayConnectPeerArn>, value: string) : NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, Present, 'TransitGatewayConnectPeerArn> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, Present, 'TransitGatewayConnectPeerArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#transit_gateway_connect_peer_arn-1">NetworkmanagerTransitGatewayConnectPeerAssociation#transit_gateway_connect_peer_arn</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_connect_peer_arn">]
        member _.TransitGatewayConnectPeerArn(state: NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, 'GlobalNetworkId, Missing>, value: string) : NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, 'GlobalNetworkId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayConnectPeerArn <- value)
            ({ assignments = state.assignments } : NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, 'GlobalNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#id-1">NetworkmanagerTransitGatewayConnectPeerAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, 'GlobalNetworkId, 'TransitGatewayConnectPeerArn>, value: string) : NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, 'GlobalNetworkId, 'TransitGatewayConnectPeerArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, 'GlobalNetworkId, 'TransitGatewayConnectPeerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#link_id-1">NetworkmanagerTransitGatewayConnectPeerAssociation#link_id</a>.
        /// </summary>
        [<CustomOperation "link_id">]
        member _.LinkId(state: NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, 'GlobalNetworkId, 'TransitGatewayConnectPeerArn>, value: string) : NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, 'GlobalNetworkId, 'TransitGatewayConnectPeerArn> =
            state.assignments.Add(fun config -> config.LinkId <- value)
            state : NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, 'GlobalNetworkId, 'TransitGatewayConnectPeerArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#timeouts-1">NetworkmanagerTransitGatewayConnectPeerAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, 'GlobalNetworkId, 'TransitGatewayConnectPeerArn>, value: aws.NetworkmanagerTransitGatewayConnectPeerAssociation.NetworkmanagerTransitGatewayConnectPeerAssociationTimeouts) : NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, 'GlobalNetworkId, 'TransitGatewayConnectPeerArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerTransitGatewayConnectPeerAssociationState<'DeviceId, 'GlobalNetworkId, 'TransitGatewayConnectPeerArn>

        member _.Run(state: NetworkmanagerTransitGatewayConnectPeerAssociationState<Present, Present, Present>) : aws.NetworkmanagerTransitGatewayConnectPeerAssociation.NetworkmanagerTransitGatewayConnectPeerAssociation =
            let config = aws.NetworkmanagerTransitGatewayConnectPeerAssociation.NetworkmanagerTransitGatewayConnectPeerAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerTransitGatewayConnectPeerAssociation.NetworkmanagerTransitGatewayConnectPeerAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerTransitGatewayConnectPeerAssociation: missing required arguments. Must call: device_id, global_network_id, transit_gateway_connect_peer_arn.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerTransitGatewayConnectPeerAssociationState<_, _, _>) : aws.NetworkmanagerTransitGatewayConnectPeerAssociation.NetworkmanagerTransitGatewayConnectPeerAssociation =
            Unchecked.defaultof<aws.NetworkmanagerTransitGatewayConnectPeerAssociation.NetworkmanagerTransitGatewayConnectPeerAssociation>
