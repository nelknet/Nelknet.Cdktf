namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRouteState<'RouteTableId> = { assignments: ResizeArray<aws.DataAwsRoute.DataAwsRouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route">aws_route</a>.
    /// </summary>
    type DataAwsRouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRouteState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRouteState<Missing>)

        member _.Zero(()) : DataAwsRouteState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRouteState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#route_table_id-1">DataAwsRoute#route_table_id</a>.
        /// </summary>
        [<CustomOperation "route_table_id">]
        member _.RouteTableId(state: DataAwsRouteState<Missing>, value: string) : DataAwsRouteState<Present> =
            state.assignments.Add(fun config -> config.RouteTableId <- value)
            ({ assignments = state.assignments } : DataAwsRouteState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#carrier_gateway_id-1">DataAwsRoute#carrier_gateway_id</a>.
        /// </summary>
        [<CustomOperation "carrier_gateway_id">]
        member _.CarrierGatewayId(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.CarrierGatewayId <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#core_network_arn-1">DataAwsRoute#core_network_arn</a>.
        /// </summary>
        [<CustomOperation "core_network_arn">]
        member _.CoreNetworkArn(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.CoreNetworkArn <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#destination_cidr_block-1">DataAwsRoute#destination_cidr_block</a>.
        /// </summary>
        [<CustomOperation "destination_cidr_block">]
        member _.DestinationCidrBlock(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.DestinationCidrBlock <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#destination_ipv6_cidr_block-1">DataAwsRoute#destination_ipv6_cidr_block</a>.
        /// </summary>
        [<CustomOperation "destination_ipv6_cidr_block">]
        member _.DestinationIpv6CidrBlock(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.DestinationIpv6CidrBlock <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#destination_prefix_list_id-1">DataAwsRoute#destination_prefix_list_id</a>.
        /// </summary>
        [<CustomOperation "destination_prefix_list_id">]
        member _.DestinationPrefixListId(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.DestinationPrefixListId <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#egress_only_gateway_id-1">DataAwsRoute#egress_only_gateway_id</a>.
        /// </summary>
        [<CustomOperation "egress_only_gateway_id">]
        member _.EgressOnlyGatewayId(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.EgressOnlyGatewayId <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#gateway_id-1">DataAwsRoute#gateway_id</a>.
        /// </summary>
        [<CustomOperation "gateway_id">]
        member _.GatewayId(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.GatewayId <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#id-1">DataAwsRoute#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#instance_id-1">DataAwsRoute#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#local_gateway_id-1">DataAwsRoute#local_gateway_id</a>.
        /// </summary>
        [<CustomOperation "local_gateway_id">]
        member _.LocalGatewayId(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.LocalGatewayId <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#nat_gateway_id-1">DataAwsRoute#nat_gateway_id</a>.
        /// </summary>
        [<CustomOperation "nat_gateway_id">]
        member _.NatGatewayId(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.NatGatewayId <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#network_interface_id-1">DataAwsRoute#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#timeouts-1">DataAwsRoute#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsRouteState<'RouteTableId>, value: aws.DataAwsRoute.DataAwsRouteTimeouts) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#transit_gateway_id-1">DataAwsRoute#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            state : DataAwsRouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route#vpc_peering_connection_id-1">DataAwsRoute#vpc_peering_connection_id</a>.
        /// </summary>
        [<CustomOperation "vpc_peering_connection_id">]
        member _.VpcPeeringConnectionId(state: DataAwsRouteState<'RouteTableId>, value: string) : DataAwsRouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.VpcPeeringConnectionId <- value)
            state : DataAwsRouteState<'RouteTableId>

        member _.Run(state: DataAwsRouteState<Present>) : aws.DataAwsRoute.DataAwsRoute =
            let config = aws.DataAwsRoute.DataAwsRouteConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute.DataAwsRoute(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRoute: missing required arguments. Must call: route_table_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRouteState<_>) : aws.DataAwsRoute.DataAwsRoute =
            Unchecked.defaultof<aws.DataAwsRoute.DataAwsRoute>
