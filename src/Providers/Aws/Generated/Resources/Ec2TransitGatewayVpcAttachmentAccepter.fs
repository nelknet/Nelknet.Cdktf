namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId> = { assignments: ResizeArray<aws.Ec2TransitGatewayVpcAttachmentAccepter.Ec2TransitGatewayVpcAttachmentAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment_accepter">aws_ec2_transit_gateway_vpc_attachment_accepter</a>.
    /// </summary>
    type Ec2TransitGatewayVpcAttachmentAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayVpcAttachmentAccepterState<Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayVpcAttachmentAccepterState<Missing>)

        member _.Zero(()) : Ec2TransitGatewayVpcAttachmentAccepterState<Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayVpcAttachmentAccepterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment_accepter#transit_gateway_attachment_id-1">Ec2TransitGatewayVpcAttachmentAccepter#transit_gateway_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_attachment_id">]
        member _.TransitGatewayAttachmentId(state: Ec2TransitGatewayVpcAttachmentAccepterState<Missing>, value: string) : Ec2TransitGatewayVpcAttachmentAccepterState<Present> =
            state.assignments.Add(fun config -> config.TransitGatewayAttachmentId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayVpcAttachmentAccepterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment_accepter#id-1">Ec2TransitGatewayVpcAttachmentAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>, value: string) : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment_accepter#tags-1">Ec2TransitGatewayVpcAttachmentAccepter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>, value: seq<string * string>) : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment_accepter#tags_all-1">Ec2TransitGatewayVpcAttachmentAccepter#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>, value: seq<string * string>) : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment_accepter#transit_gateway_default_route_table_association-1">Ec2TransitGatewayVpcAttachmentAccepter#transit_gateway_default_route_table_association</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_gateway_default_route_table_association">]
        member _.TransitGatewayDefaultRouteTableAssociation(state: Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>, value: bool) : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.TransitGatewayDefaultRouteTableAssociation <- value)
            state : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment_accepter#transit_gateway_default_route_table_association-1">Ec2TransitGatewayVpcAttachmentAccepter#transit_gateway_default_route_table_association</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_gateway_default_route_table_association">]
        member _.TransitGatewayDefaultRouteTableAssociation(state: Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>, value: HashiCorp.Cdktf.IResolvable) : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.TransitGatewayDefaultRouteTableAssociation <- value)
            state : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment_accepter#transit_gateway_default_route_table_propagation-1">Ec2TransitGatewayVpcAttachmentAccepter#transit_gateway_default_route_table_propagation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_gateway_default_route_table_propagation">]
        member _.TransitGatewayDefaultRouteTablePropagation(state: Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>, value: bool) : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.TransitGatewayDefaultRouteTablePropagation <- value)
            state : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment_accepter#transit_gateway_default_route_table_propagation-1">Ec2TransitGatewayVpcAttachmentAccepter#transit_gateway_default_route_table_propagation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_gateway_default_route_table_propagation">]
        member _.TransitGatewayDefaultRouteTablePropagation(state: Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>, value: HashiCorp.Cdktf.IResolvable) : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId> =
            state.assignments.Add(fun config -> config.TransitGatewayDefaultRouteTablePropagation <- value)
            state : Ec2TransitGatewayVpcAttachmentAccepterState<'TransitGatewayAttachmentId>

        member _.Run(state: Ec2TransitGatewayVpcAttachmentAccepterState<Present>) : aws.Ec2TransitGatewayVpcAttachmentAccepter.Ec2TransitGatewayVpcAttachmentAccepter =
            let config = aws.Ec2TransitGatewayVpcAttachmentAccepter.Ec2TransitGatewayVpcAttachmentAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayVpcAttachmentAccepter.Ec2TransitGatewayVpcAttachmentAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayVpcAttachmentAccepter: missing required arguments. Must call: transit_gateway_attachment_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayVpcAttachmentAccepterState<_>) : aws.Ec2TransitGatewayVpcAttachmentAccepter.Ec2TransitGatewayVpcAttachmentAccepter =
            Unchecked.defaultof<aws.Ec2TransitGatewayVpcAttachmentAccepter.Ec2TransitGatewayVpcAttachmentAccepter>
