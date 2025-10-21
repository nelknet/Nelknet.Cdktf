namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayRouteTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId> = { assignments: ResizeArray<aws.Ec2TransitGatewayRouteTableAssociation.Ec2TransitGatewayRouteTableAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table_association">aws_ec2_transit_gateway_route_table_association</a>.
    /// </summary>
    type Ec2TransitGatewayRouteTableAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayRouteTableAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayRouteTableAssociationState<Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayRouteTableAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayRouteTableAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table_association#transit_gateway_attachment_id-1">Ec2TransitGatewayRouteTableAssociation#transit_gateway_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_attachment_id">]
        member _.TransitGatewayAttachmentId(state: Ec2TransitGatewayRouteTableAssociationState<Missing, 'TransitGatewayRouteTableId>, value: string) : Ec2TransitGatewayRouteTableAssociationState<Present, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.TransitGatewayAttachmentId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayRouteTableAssociationState<Present, 'TransitGatewayRouteTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table_association#transit_gateway_route_table_id-1">Ec2TransitGatewayRouteTableAssociation#transit_gateway_route_table_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_route_table_id">]
        member _.TransitGatewayRouteTableId(state: Ec2TransitGatewayRouteTableAssociationState<'TransitGatewayAttachmentId, Missing>, value: string) : Ec2TransitGatewayRouteTableAssociationState<'TransitGatewayAttachmentId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayRouteTableId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayRouteTableAssociationState<'TransitGatewayAttachmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table_association#id-1">Ec2TransitGatewayRouteTableAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayRouteTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId>, value: string) : Ec2TransitGatewayRouteTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayRouteTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table_association#replace_existing_association-1">Ec2TransitGatewayRouteTableAssociation#replace_existing_association</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "replace_existing_association">]
        member _.ReplaceExistingAssociation(state: Ec2TransitGatewayRouteTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId>, value: bool) : Ec2TransitGatewayRouteTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.ReplaceExistingAssociation <- value)
            state : Ec2TransitGatewayRouteTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table_association#replace_existing_association-1">Ec2TransitGatewayRouteTableAssociation#replace_existing_association</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "replace_existing_association">]
        member _.ReplaceExistingAssociation(state: Ec2TransitGatewayRouteTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId>, value: HashiCorp.Cdktf.IResolvable) : Ec2TransitGatewayRouteTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.ReplaceExistingAssociation <- value)
            state : Ec2TransitGatewayRouteTableAssociationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId>

        member _.Run(state: Ec2TransitGatewayRouteTableAssociationState<Present, Present>) : aws.Ec2TransitGatewayRouteTableAssociation.Ec2TransitGatewayRouteTableAssociation =
            let config = aws.Ec2TransitGatewayRouteTableAssociation.Ec2TransitGatewayRouteTableAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayRouteTableAssociation.Ec2TransitGatewayRouteTableAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayRouteTableAssociation: missing required arguments. Must call: transit_gateway_attachment_id, transit_gateway_route_table_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayRouteTableAssociationState<_, _>) : aws.Ec2TransitGatewayRouteTableAssociation.Ec2TransitGatewayRouteTableAssociation =
            Unchecked.defaultof<aws.Ec2TransitGatewayRouteTableAssociation.Ec2TransitGatewayRouteTableAssociation>
