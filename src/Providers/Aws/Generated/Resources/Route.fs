namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RouteState<'RouteTableId> = { assignments: ResizeArray<aws.Route.RouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route">aws_route</a>.
    /// </summary>
    type RouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : RouteState<Missing> =
            ({ assignments = ResizeArray() } : RouteState<Missing>)

        member _.Zero(()) : RouteState<Missing> =
            ({ assignments = ResizeArray() } : RouteState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#route_table_id-1">Route#route_table_id</a>.
        /// </summary>
        [<CustomOperation "route_table_id">]
        member _.RouteTableId(state: RouteState<Missing>, value: string) : RouteState<Present> =
            state.assignments.Add(fun config -> config.RouteTableId <- value)
            ({ assignments = state.assignments } : RouteState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#carrier_gateway_id-1">Route#carrier_gateway_id</a>.
        /// </summary>
        [<CustomOperation "carrier_gateway_id">]
        member _.CarrierGatewayId(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.CarrierGatewayId <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#core_network_arn-1">Route#core_network_arn</a>.
        /// </summary>
        [<CustomOperation "core_network_arn">]
        member _.CoreNetworkArn(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.CoreNetworkArn <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#destination_cidr_block-1">Route#destination_cidr_block</a>.
        /// </summary>
        [<CustomOperation "destination_cidr_block">]
        member _.DestinationCidrBlock(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.DestinationCidrBlock <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#destination_ipv6_cidr_block-1">Route#destination_ipv6_cidr_block</a>.
        /// </summary>
        [<CustomOperation "destination_ipv6_cidr_block">]
        member _.DestinationIpv6CidrBlock(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.DestinationIpv6CidrBlock <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#destination_prefix_list_id-1">Route#destination_prefix_list_id</a>.
        /// </summary>
        [<CustomOperation "destination_prefix_list_id">]
        member _.DestinationPrefixListId(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.DestinationPrefixListId <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#egress_only_gateway_id-1">Route#egress_only_gateway_id</a>.
        /// </summary>
        [<CustomOperation "egress_only_gateway_id">]
        member _.EgressOnlyGatewayId(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.EgressOnlyGatewayId <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#gateway_id-1">Route#gateway_id</a>.
        /// </summary>
        [<CustomOperation "gateway_id">]
        member _.GatewayId(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.GatewayId <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#id-1">Route#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#local_gateway_id-1">Route#local_gateway_id</a>.
        /// </summary>
        [<CustomOperation "local_gateway_id">]
        member _.LocalGatewayId(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.LocalGatewayId <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#nat_gateway_id-1">Route#nat_gateway_id</a>.
        /// </summary>
        [<CustomOperation "nat_gateway_id">]
        member _.NatGatewayId(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.NatGatewayId <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#network_interface_id-1">Route#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#timeouts-1">Route#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RouteState<'RouteTableId>, value: aws.Route.RouteTimeouts) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#transit_gateway_id-1">Route#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#vpc_endpoint_id-1">Route#vpc_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_id">]
        member _.VpcEndpointId(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.VpcEndpointId <- value)
            state : RouteState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route#vpc_peering_connection_id-1">Route#vpc_peering_connection_id</a>.
        /// </summary>
        [<CustomOperation "vpc_peering_connection_id">]
        member _.VpcPeeringConnectionId(state: RouteState<'RouteTableId>, value: string) : RouteState<'RouteTableId> =
            state.assignments.Add(fun config -> config.VpcPeeringConnectionId <- value)
            state : RouteState<'RouteTableId>

        member _.Run(state: RouteState<Present>) : aws.Route.Route =
            let config = aws.Route.RouteConfig()
            for setter in state.assignments do
                setter config
            aws.Route.Route(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route: missing required arguments. Must call: route_table_id.", 9999, IsError = true)>]
        member _.Run(_: RouteState<_>) : aws.Route.Route =
            Unchecked.defaultof<aws.Route.Route>
