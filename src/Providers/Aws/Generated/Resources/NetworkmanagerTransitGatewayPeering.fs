namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, 'TransitGatewayArn> = { assignments: ResizeArray<aws.NetworkmanagerTransitGatewayPeering.NetworkmanagerTransitGatewayPeeringConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_peering">aws_networkmanager_transit_gateway_peering</a>.
    /// </summary>
    type NetworkmanagerTransitGatewayPeeringBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerTransitGatewayPeeringState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerTransitGatewayPeeringState<Missing, Missing>)

        member _.Zero(()) : NetworkmanagerTransitGatewayPeeringState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerTransitGatewayPeeringState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_peering#core_network_id-1">NetworkmanagerTransitGatewayPeering#core_network_id</a>.
        /// </summary>
        [<CustomOperation "core_network_id">]
        member _.CoreNetworkId(state: NetworkmanagerTransitGatewayPeeringState<Missing, 'TransitGatewayArn>, value: string) : NetworkmanagerTransitGatewayPeeringState<Present, 'TransitGatewayArn> =
            state.assignments.Add(fun config -> config.CoreNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerTransitGatewayPeeringState<Present, 'TransitGatewayArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_peering#transit_gateway_arn-1">NetworkmanagerTransitGatewayPeering#transit_gateway_arn</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_arn">]
        member _.TransitGatewayArn(state: NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, Missing>, value: string) : NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayArn <- value)
            ({ assignments = state.assignments } : NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_peering#id-1">NetworkmanagerTransitGatewayPeering#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, 'TransitGatewayArn>, value: string) : NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, 'TransitGatewayArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, 'TransitGatewayArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_peering#tags-1">NetworkmanagerTransitGatewayPeering#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, 'TransitGatewayArn>, value: seq<string * string>) : NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, 'TransitGatewayArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, 'TransitGatewayArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_peering#tags_all-1">NetworkmanagerTransitGatewayPeering#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, 'TransitGatewayArn>, value: seq<string * string>) : NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, 'TransitGatewayArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, 'TransitGatewayArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_peering#timeouts-1">NetworkmanagerTransitGatewayPeering#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, 'TransitGatewayArn>, value: aws.NetworkmanagerTransitGatewayPeering.NetworkmanagerTransitGatewayPeeringTimeouts) : NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, 'TransitGatewayArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerTransitGatewayPeeringState<'CoreNetworkId, 'TransitGatewayArn>

        member _.Run(state: NetworkmanagerTransitGatewayPeeringState<Present, Present>) : aws.NetworkmanagerTransitGatewayPeering.NetworkmanagerTransitGatewayPeering =
            let config = aws.NetworkmanagerTransitGatewayPeering.NetworkmanagerTransitGatewayPeeringConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerTransitGatewayPeering.NetworkmanagerTransitGatewayPeering(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerTransitGatewayPeering: missing required arguments. Must call: core_network_id, transit_gateway_arn.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerTransitGatewayPeeringState<_, _>) : aws.NetworkmanagerTransitGatewayPeering.NetworkmanagerTransitGatewayPeering =
            Unchecked.defaultof<aws.NetworkmanagerTransitGatewayPeering.NetworkmanagerTransitGatewayPeering>
