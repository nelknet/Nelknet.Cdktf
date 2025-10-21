namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayPeeringAttachmentAccepterState<'TransitGatewayAttachmentId> = { assignments: ResizeArray<aws.Ec2TransitGatewayPeeringAttachmentAccepter.Ec2TransitGatewayPeeringAttachmentAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment_accepter">aws_ec2_transit_gateway_peering_attachment_accepter</a>.
    /// </summary>
    type Ec2TransitGatewayPeeringAttachmentAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayPeeringAttachmentAccepterState<Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayPeeringAttachmentAccepterState<Missing>)

        member _.Zero(()) : Ec2TransitGatewayPeeringAttachmentAccepterState<Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayPeeringAttachmentAccepterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment_accepter#transit_gateway_attachment_id-1">Ec2TransitGatewayPeeringAttachmentAccepter#transit_gateway_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_attachment_id">]
        member _.TransitGatewayAttachmentId(state: Ec2TransitGatewayPeeringAttachmentAccepterState<Missing>, value: string) : Ec2TransitGatewayPeeringAttachmentAccepterState<Present> =
            state.assignments.Add(fun config -> config.TransitGatewayAttachmentId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayPeeringAttachmentAccepterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment_accepter#id-1">Ec2TransitGatewayPeeringAttachmentAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayPeeringAttachmentAccepterState<'TransitGatewayAttachmentId>, value: string) : Ec2TransitGatewayPeeringAttachmentAccepterState<'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayPeeringAttachmentAccepterState<'TransitGatewayAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment_accepter#tags-1">Ec2TransitGatewayPeeringAttachmentAccepter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2TransitGatewayPeeringAttachmentAccepterState<'TransitGatewayAttachmentId>, value: seq<string * string>) : Ec2TransitGatewayPeeringAttachmentAccepterState<'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2TransitGatewayPeeringAttachmentAccepterState<'TransitGatewayAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment_accepter#tags_all-1">Ec2TransitGatewayPeeringAttachmentAccepter#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2TransitGatewayPeeringAttachmentAccepterState<'TransitGatewayAttachmentId>, value: seq<string * string>) : Ec2TransitGatewayPeeringAttachmentAccepterState<'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2TransitGatewayPeeringAttachmentAccepterState<'TransitGatewayAttachmentId>

        member _.Run(state: Ec2TransitGatewayPeeringAttachmentAccepterState<Present>) : aws.Ec2TransitGatewayPeeringAttachmentAccepter.Ec2TransitGatewayPeeringAttachmentAccepter =
            let config = aws.Ec2TransitGatewayPeeringAttachmentAccepter.Ec2TransitGatewayPeeringAttachmentAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayPeeringAttachmentAccepter.Ec2TransitGatewayPeeringAttachmentAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayPeeringAttachmentAccepter: missing required arguments. Must call: transit_gateway_attachment_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayPeeringAttachmentAccepterState<_>) : aws.Ec2TransitGatewayPeeringAttachmentAccepter.Ec2TransitGatewayPeeringAttachmentAccepter =
            Unchecked.defaultof<aws.Ec2TransitGatewayPeeringAttachmentAccepter.Ec2TransitGatewayPeeringAttachmentAccepter>
