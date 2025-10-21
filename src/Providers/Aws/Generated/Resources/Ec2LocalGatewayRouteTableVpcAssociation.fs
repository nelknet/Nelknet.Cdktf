namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2LocalGatewayRouteTableVpcAssociationState<'LocalGatewayRouteTableId, 'VpcId> = { assignments: ResizeArray<aws.Ec2LocalGatewayRouteTableVpcAssociation.Ec2LocalGatewayRouteTableVpcAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_local_gateway_route_table_vpc_association">aws_ec2_local_gateway_route_table_vpc_association</a>.
    /// </summary>
    type Ec2LocalGatewayRouteTableVpcAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2LocalGatewayRouteTableVpcAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2LocalGatewayRouteTableVpcAssociationState<Missing, Missing>)

        member _.Zero(()) : Ec2LocalGatewayRouteTableVpcAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2LocalGatewayRouteTableVpcAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_local_gateway_route_table_vpc_association#local_gateway_route_table_id-1">Ec2LocalGatewayRouteTableVpcAssociation#local_gateway_route_table_id</a>.
        /// </summary>
        [<CustomOperation "local_gateway_route_table_id">]
        member _.LocalGatewayRouteTableId(state: Ec2LocalGatewayRouteTableVpcAssociationState<Missing, 'VpcId>, value: string) : Ec2LocalGatewayRouteTableVpcAssociationState<Present, 'VpcId> =
            state.assignments.Add(fun config -> config.LocalGatewayRouteTableId <- value)
            ({ assignments = state.assignments } : Ec2LocalGatewayRouteTableVpcAssociationState<Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_local_gateway_route_table_vpc_association#vpc_id-1">Ec2LocalGatewayRouteTableVpcAssociation#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: Ec2LocalGatewayRouteTableVpcAssociationState<'LocalGatewayRouteTableId, Missing>, value: string) : Ec2LocalGatewayRouteTableVpcAssociationState<'LocalGatewayRouteTableId, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : Ec2LocalGatewayRouteTableVpcAssociationState<'LocalGatewayRouteTableId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_local_gateway_route_table_vpc_association#id-1">Ec2LocalGatewayRouteTableVpcAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2LocalGatewayRouteTableVpcAssociationState<'LocalGatewayRouteTableId, 'VpcId>, value: string) : Ec2LocalGatewayRouteTableVpcAssociationState<'LocalGatewayRouteTableId, 'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2LocalGatewayRouteTableVpcAssociationState<'LocalGatewayRouteTableId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_local_gateway_route_table_vpc_association#tags-1">Ec2LocalGatewayRouteTableVpcAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2LocalGatewayRouteTableVpcAssociationState<'LocalGatewayRouteTableId, 'VpcId>, value: seq<string * string>) : Ec2LocalGatewayRouteTableVpcAssociationState<'LocalGatewayRouteTableId, 'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2LocalGatewayRouteTableVpcAssociationState<'LocalGatewayRouteTableId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_local_gateway_route_table_vpc_association#tags_all-1">Ec2LocalGatewayRouteTableVpcAssociation#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2LocalGatewayRouteTableVpcAssociationState<'LocalGatewayRouteTableId, 'VpcId>, value: seq<string * string>) : Ec2LocalGatewayRouteTableVpcAssociationState<'LocalGatewayRouteTableId, 'VpcId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2LocalGatewayRouteTableVpcAssociationState<'LocalGatewayRouteTableId, 'VpcId>

        member _.Run(state: Ec2LocalGatewayRouteTableVpcAssociationState<Present, Present>) : aws.Ec2LocalGatewayRouteTableVpcAssociation.Ec2LocalGatewayRouteTableVpcAssociation =
            let config = aws.Ec2LocalGatewayRouteTableVpcAssociation.Ec2LocalGatewayRouteTableVpcAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2LocalGatewayRouteTableVpcAssociation.Ec2LocalGatewayRouteTableVpcAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2LocalGatewayRouteTableVpcAssociation: missing required arguments. Must call: local_gateway_route_table_id, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2LocalGatewayRouteTableVpcAssociationState<_, _>) : aws.Ec2LocalGatewayRouteTableVpcAssociation.Ec2LocalGatewayRouteTableVpcAssociation =
            Unchecked.defaultof<aws.Ec2LocalGatewayRouteTableVpcAssociation.Ec2LocalGatewayRouteTableVpcAssociation>
