namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2LocalGatewayRouteState<'DestinationCidrBlock, 'LocalGatewayRouteTableId, 'LocalGatewayVirtualInterfaceGroupId> = { assignments: ResizeArray<aws.Ec2LocalGatewayRoute.Ec2LocalGatewayRouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_local_gateway_route">aws_ec2_local_gateway_route</a>.
    /// </summary>
    type Ec2LocalGatewayRouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2LocalGatewayRouteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2LocalGatewayRouteState<Missing, Missing, Missing>)

        member _.Zero(()) : Ec2LocalGatewayRouteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2LocalGatewayRouteState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_local_gateway_route#destination_cidr_block-1">Ec2LocalGatewayRoute#destination_cidr_block</a>.
        /// </summary>
        [<CustomOperation "destination_cidr_block">]
        member _.DestinationCidrBlock(state: Ec2LocalGatewayRouteState<Missing, 'LocalGatewayRouteTableId, 'LocalGatewayVirtualInterfaceGroupId>, value: string) : Ec2LocalGatewayRouteState<Present, 'LocalGatewayRouteTableId, 'LocalGatewayVirtualInterfaceGroupId> =
            state.assignments.Add(fun config -> config.DestinationCidrBlock <- value)
            ({ assignments = state.assignments } : Ec2LocalGatewayRouteState<Present, 'LocalGatewayRouteTableId, 'LocalGatewayVirtualInterfaceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_local_gateway_route#local_gateway_route_table_id-1">Ec2LocalGatewayRoute#local_gateway_route_table_id</a>.
        /// </summary>
        [<CustomOperation "local_gateway_route_table_id">]
        member _.LocalGatewayRouteTableId(state: Ec2LocalGatewayRouteState<'DestinationCidrBlock, Missing, 'LocalGatewayVirtualInterfaceGroupId>, value: string) : Ec2LocalGatewayRouteState<'DestinationCidrBlock, Present, 'LocalGatewayVirtualInterfaceGroupId> =
            state.assignments.Add(fun config -> config.LocalGatewayRouteTableId <- value)
            ({ assignments = state.assignments } : Ec2LocalGatewayRouteState<'DestinationCidrBlock, Present, 'LocalGatewayVirtualInterfaceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_local_gateway_route#local_gateway_virtual_interface_group_id-1">Ec2LocalGatewayRoute#local_gateway_virtual_interface_group_id</a>.
        /// </summary>
        [<CustomOperation "local_gateway_virtual_interface_group_id">]
        member _.LocalGatewayVirtualInterfaceGroupId(state: Ec2LocalGatewayRouteState<'DestinationCidrBlock, 'LocalGatewayRouteTableId, Missing>, value: string) : Ec2LocalGatewayRouteState<'DestinationCidrBlock, 'LocalGatewayRouteTableId, Present> =
            state.assignments.Add(fun config -> config.LocalGatewayVirtualInterfaceGroupId <- value)
            ({ assignments = state.assignments } : Ec2LocalGatewayRouteState<'DestinationCidrBlock, 'LocalGatewayRouteTableId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_local_gateway_route#id-1">Ec2LocalGatewayRoute#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2LocalGatewayRouteState<'DestinationCidrBlock, 'LocalGatewayRouteTableId, 'LocalGatewayVirtualInterfaceGroupId>, value: string) : Ec2LocalGatewayRouteState<'DestinationCidrBlock, 'LocalGatewayRouteTableId, 'LocalGatewayVirtualInterfaceGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2LocalGatewayRouteState<'DestinationCidrBlock, 'LocalGatewayRouteTableId, 'LocalGatewayVirtualInterfaceGroupId>

        member _.Run(state: Ec2LocalGatewayRouteState<Present, Present, Present>) : aws.Ec2LocalGatewayRoute.Ec2LocalGatewayRoute =
            let config = aws.Ec2LocalGatewayRoute.Ec2LocalGatewayRouteConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2LocalGatewayRoute.Ec2LocalGatewayRoute(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2LocalGatewayRoute: missing required arguments. Must call: destination_cidr_block, local_gateway_route_table_id, local_gateway_virtual_interface_group_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2LocalGatewayRouteState<_, _, _>) : aws.Ec2LocalGatewayRoute.Ec2LocalGatewayRoute =
            Unchecked.defaultof<aws.Ec2LocalGatewayRoute.Ec2LocalGatewayRoute>
