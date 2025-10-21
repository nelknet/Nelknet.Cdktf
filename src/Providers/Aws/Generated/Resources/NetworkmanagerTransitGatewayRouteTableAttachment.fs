namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, 'TransitGatewayRouteTableArn> = { assignments: ResizeArray<aws.NetworkmanagerTransitGatewayRouteTableAttachment.NetworkmanagerTransitGatewayRouteTableAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_route_table_attachment">aws_networkmanager_transit_gateway_route_table_attachment</a>.
    /// </summary>
    type NetworkmanagerTransitGatewayRouteTableAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerTransitGatewayRouteTableAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerTransitGatewayRouteTableAttachmentState<Missing, Missing>)

        member _.Zero(()) : NetworkmanagerTransitGatewayRouteTableAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerTransitGatewayRouteTableAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#peering_id-1">NetworkmanagerTransitGatewayRouteTableAttachment#peering_id</a>.
        /// </summary>
        [<CustomOperation "peering_id">]
        member _.PeeringId(state: NetworkmanagerTransitGatewayRouteTableAttachmentState<Missing, 'TransitGatewayRouteTableArn>, value: string) : NetworkmanagerTransitGatewayRouteTableAttachmentState<Present, 'TransitGatewayRouteTableArn> =
            state.assignments.Add(fun config -> config.PeeringId <- value)
            ({ assignments = state.assignments } : NetworkmanagerTransitGatewayRouteTableAttachmentState<Present, 'TransitGatewayRouteTableArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#transit_gateway_route_table_arn-1">NetworkmanagerTransitGatewayRouteTableAttachment#transit_gateway_route_table_arn</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_route_table_arn">]
        member _.TransitGatewayRouteTableArn(state: NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, Missing>, value: string) : NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayRouteTableArn <- value)
            ({ assignments = state.assignments } : NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#id-1">NetworkmanagerTransitGatewayRouteTableAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, 'TransitGatewayRouteTableArn>, value: string) : NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, 'TransitGatewayRouteTableArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, 'TransitGatewayRouteTableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#tags-1">NetworkmanagerTransitGatewayRouteTableAttachment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, 'TransitGatewayRouteTableArn>, value: seq<string * string>) : NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, 'TransitGatewayRouteTableArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, 'TransitGatewayRouteTableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#tags_all-1">NetworkmanagerTransitGatewayRouteTableAttachment#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, 'TransitGatewayRouteTableArn>, value: seq<string * string>) : NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, 'TransitGatewayRouteTableArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, 'TransitGatewayRouteTableArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#timeouts-1">NetworkmanagerTransitGatewayRouteTableAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, 'TransitGatewayRouteTableArn>, value: aws.NetworkmanagerTransitGatewayRouteTableAttachment.NetworkmanagerTransitGatewayRouteTableAttachmentTimeouts) : NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, 'TransitGatewayRouteTableArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerTransitGatewayRouteTableAttachmentState<'PeeringId, 'TransitGatewayRouteTableArn>

        member _.Run(state: NetworkmanagerTransitGatewayRouteTableAttachmentState<Present, Present>) : aws.NetworkmanagerTransitGatewayRouteTableAttachment.NetworkmanagerTransitGatewayRouteTableAttachment =
            let config = aws.NetworkmanagerTransitGatewayRouteTableAttachment.NetworkmanagerTransitGatewayRouteTableAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerTransitGatewayRouteTableAttachment.NetworkmanagerTransitGatewayRouteTableAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerTransitGatewayRouteTableAttachment: missing required arguments. Must call: peering_id, transit_gateway_route_table_arn.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerTransitGatewayRouteTableAttachmentState<_, _>) : aws.NetworkmanagerTransitGatewayRouteTableAttachment.NetworkmanagerTransitGatewayRouteTableAttachment =
            Unchecked.defaultof<aws.NetworkmanagerTransitGatewayRouteTableAttachment.NetworkmanagerTransitGatewayRouteTableAttachment>
