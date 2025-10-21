namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId> = { assignments: ResizeArray<aws.Ec2TransitGatewayPeeringAttachment.Ec2TransitGatewayPeeringAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment">aws_ec2_transit_gateway_peering_attachment</a>.
    /// </summary>
    type Ec2TransitGatewayPeeringAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayPeeringAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayPeeringAttachmentState<Missing, Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayPeeringAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayPeeringAttachmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment#peer_region-1">Ec2TransitGatewayPeeringAttachment#peer_region</a>.
        /// </summary>
        [<CustomOperation "peer_region">]
        member _.PeerRegion(state: Ec2TransitGatewayPeeringAttachmentState<Missing, 'PeerTransitGatewayId, 'TransitGatewayId>, value: string) : Ec2TransitGatewayPeeringAttachmentState<Present, 'PeerTransitGatewayId, 'TransitGatewayId> =
            state.assignments.Add(fun config -> config.PeerRegion <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayPeeringAttachmentState<Present, 'PeerTransitGatewayId, 'TransitGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment#peer_transit_gateway_id-1">Ec2TransitGatewayPeeringAttachment#peer_transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "peer_transit_gateway_id">]
        member _.PeerTransitGatewayId(state: Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, Missing, 'TransitGatewayId>, value: string) : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, Present, 'TransitGatewayId> =
            state.assignments.Add(fun config -> config.PeerTransitGatewayId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, Present, 'TransitGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment#transit_gateway_id-1">Ec2TransitGatewayPeeringAttachment#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, Missing>, value: string) : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment#id-1">Ec2TransitGatewayPeeringAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId>, value: string) : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId>

        /// <summary>
        /// options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment#options-1">Ec2TransitGatewayPeeringAttachment#options</a>
        /// </summary>
        [<CustomOperation "options">]
        member _.Options(state: Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId>, value: aws.Ec2TransitGatewayPeeringAttachment.Ec2TransitGatewayPeeringAttachmentOptions) : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId> =
            state.assignments.Add(fun config -> config.Options <- value)
            state : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment#peer_account_id-1">Ec2TransitGatewayPeeringAttachment#peer_account_id</a>.
        /// </summary>
        [<CustomOperation "peer_account_id">]
        member _.PeerAccountId(state: Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId>, value: string) : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId> =
            state.assignments.Add(fun config -> config.PeerAccountId <- value)
            state : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment#tags-1">Ec2TransitGatewayPeeringAttachment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId>, value: seq<string * string>) : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment#tags_all-1">Ec2TransitGatewayPeeringAttachment#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId>, value: seq<string * string>) : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2TransitGatewayPeeringAttachmentState<'PeerRegion, 'PeerTransitGatewayId, 'TransitGatewayId>

        member _.Run(state: Ec2TransitGatewayPeeringAttachmentState<Present, Present, Present>) : aws.Ec2TransitGatewayPeeringAttachment.Ec2TransitGatewayPeeringAttachment =
            let config = aws.Ec2TransitGatewayPeeringAttachment.Ec2TransitGatewayPeeringAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayPeeringAttachment.Ec2TransitGatewayPeeringAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayPeeringAttachment: missing required arguments. Must call: peer_region, peer_transit_gateway_id, transit_gateway_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayPeeringAttachmentState<_, _, _>) : aws.Ec2TransitGatewayPeeringAttachment.Ec2TransitGatewayPeeringAttachment =
            Unchecked.defaultof<aws.Ec2TransitGatewayPeeringAttachment.Ec2TransitGatewayPeeringAttachment>
