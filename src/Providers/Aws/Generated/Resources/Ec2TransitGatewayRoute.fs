namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayRouteState<'DestinationCidrBlock, 'TransitGatewayRouteTableId> = { assignments: ResizeArray<aws.Ec2TransitGatewayRoute.Ec2TransitGatewayRouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route">aws_ec2_transit_gateway_route</a>.
    /// </summary>
    type Ec2TransitGatewayRouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayRouteState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayRouteState<Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayRouteState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayRouteState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route#destination_cidr_block-1">Ec2TransitGatewayRoute#destination_cidr_block</a>.
        /// </summary>
        [<CustomOperation "destination_cidr_block">]
        member _.DestinationCidrBlock(state: Ec2TransitGatewayRouteState<Missing, 'TransitGatewayRouteTableId>, value: string) : Ec2TransitGatewayRouteState<Present, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.DestinationCidrBlock <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayRouteState<Present, 'TransitGatewayRouteTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route#transit_gateway_route_table_id-1">Ec2TransitGatewayRoute#transit_gateway_route_table_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_route_table_id">]
        member _.TransitGatewayRouteTableId(state: Ec2TransitGatewayRouteState<'DestinationCidrBlock, Missing>, value: string) : Ec2TransitGatewayRouteState<'DestinationCidrBlock, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayRouteTableId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayRouteState<'DestinationCidrBlock, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route#blackhole-1">Ec2TransitGatewayRoute#blackhole</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "blackhole">]
        member _.Blackhole(state: Ec2TransitGatewayRouteState<'DestinationCidrBlock, 'TransitGatewayRouteTableId>, value: bool) : Ec2TransitGatewayRouteState<'DestinationCidrBlock, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Blackhole <- value)
            state : Ec2TransitGatewayRouteState<'DestinationCidrBlock, 'TransitGatewayRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route#blackhole-1">Ec2TransitGatewayRoute#blackhole</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "blackhole">]
        member _.Blackhole(state: Ec2TransitGatewayRouteState<'DestinationCidrBlock, 'TransitGatewayRouteTableId>, value: HashiCorp.Cdktf.IResolvable) : Ec2TransitGatewayRouteState<'DestinationCidrBlock, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Blackhole <- value)
            state : Ec2TransitGatewayRouteState<'DestinationCidrBlock, 'TransitGatewayRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route#id-1">Ec2TransitGatewayRoute#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayRouteState<'DestinationCidrBlock, 'TransitGatewayRouteTableId>, value: string) : Ec2TransitGatewayRouteState<'DestinationCidrBlock, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayRouteState<'DestinationCidrBlock, 'TransitGatewayRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route#transit_gateway_attachment_id-1">Ec2TransitGatewayRoute#transit_gateway_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_attachment_id">]
        member _.TransitGatewayAttachmentId(state: Ec2TransitGatewayRouteState<'DestinationCidrBlock, 'TransitGatewayRouteTableId>, value: string) : Ec2TransitGatewayRouteState<'DestinationCidrBlock, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.TransitGatewayAttachmentId <- value)
            state : Ec2TransitGatewayRouteState<'DestinationCidrBlock, 'TransitGatewayRouteTableId>

        member _.Run(state: Ec2TransitGatewayRouteState<Present, Present>) : aws.Ec2TransitGatewayRoute.Ec2TransitGatewayRoute =
            let config = aws.Ec2TransitGatewayRoute.Ec2TransitGatewayRouteConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayRoute.Ec2TransitGatewayRoute(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayRoute: missing required arguments. Must call: destination_cidr_block, transit_gateway_route_table_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayRouteState<_, _>) : aws.Ec2TransitGatewayRoute.Ec2TransitGatewayRoute =
            Unchecked.defaultof<aws.Ec2TransitGatewayRoute.Ec2TransitGatewayRoute>
