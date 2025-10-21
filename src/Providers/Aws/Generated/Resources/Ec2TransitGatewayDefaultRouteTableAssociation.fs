namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayDefaultRouteTableAssociationState<'TransitGatewayId, 'TransitGatewayRouteTableId> = { assignments: ResizeArray<aws.Ec2TransitGatewayDefaultRouteTableAssociation.Ec2TransitGatewayDefaultRouteTableAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_default_route_table_association">aws_ec2_transit_gateway_default_route_table_association</a>.
    /// </summary>
    type Ec2TransitGatewayDefaultRouteTableAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayDefaultRouteTableAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayDefaultRouteTableAssociationState<Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayDefaultRouteTableAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayDefaultRouteTableAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_default_route_table_association#transit_gateway_id-1">Ec2TransitGatewayDefaultRouteTableAssociation#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: Ec2TransitGatewayDefaultRouteTableAssociationState<Missing, 'TransitGatewayRouteTableId>, value: string) : Ec2TransitGatewayDefaultRouteTableAssociationState<Present, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayDefaultRouteTableAssociationState<Present, 'TransitGatewayRouteTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_default_route_table_association#transit_gateway_route_table_id-1">Ec2TransitGatewayDefaultRouteTableAssociation#transit_gateway_route_table_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_route_table_id">]
        member _.TransitGatewayRouteTableId(state: Ec2TransitGatewayDefaultRouteTableAssociationState<'TransitGatewayId, Missing>, value: string) : Ec2TransitGatewayDefaultRouteTableAssociationState<'TransitGatewayId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayRouteTableId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayDefaultRouteTableAssociationState<'TransitGatewayId, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_default_route_table_association#timeouts-1">Ec2TransitGatewayDefaultRouteTableAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2TransitGatewayDefaultRouteTableAssociationState<'TransitGatewayId, 'TransitGatewayRouteTableId>, value: aws.Ec2TransitGatewayDefaultRouteTableAssociation.Ec2TransitGatewayDefaultRouteTableAssociationTimeouts) : Ec2TransitGatewayDefaultRouteTableAssociationState<'TransitGatewayId, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2TransitGatewayDefaultRouteTableAssociationState<'TransitGatewayId, 'TransitGatewayRouteTableId>

        member _.Run(state: Ec2TransitGatewayDefaultRouteTableAssociationState<Present, Present>) : aws.Ec2TransitGatewayDefaultRouteTableAssociation.Ec2TransitGatewayDefaultRouteTableAssociation =
            let config = aws.Ec2TransitGatewayDefaultRouteTableAssociation.Ec2TransitGatewayDefaultRouteTableAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayDefaultRouteTableAssociation.Ec2TransitGatewayDefaultRouteTableAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayDefaultRouteTableAssociation: missing required arguments. Must call: transit_gateway_id, transit_gateway_route_table_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayDefaultRouteTableAssociationState<_, _>) : aws.Ec2TransitGatewayDefaultRouteTableAssociation.Ec2TransitGatewayDefaultRouteTableAssociation =
            Unchecked.defaultof<aws.Ec2TransitGatewayDefaultRouteTableAssociation.Ec2TransitGatewayDefaultRouteTableAssociation>
