namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpnGatewayRoutePropagationState<'RouteTableId, 'VpnGatewayId> = { assignments: ResizeArray<aws.VpnGatewayRoutePropagation.VpnGatewayRoutePropagationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway_route_propagation">aws_vpn_gateway_route_propagation</a>.
    /// </summary>
    type VpnGatewayRoutePropagationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpnGatewayRoutePropagationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnGatewayRoutePropagationState<Missing, Missing>)

        member _.Zero(()) : VpnGatewayRoutePropagationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnGatewayRoutePropagationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway_route_propagation#route_table_id-1">VpnGatewayRoutePropagation#route_table_id</a>.
        /// </summary>
        [<CustomOperation "route_table_id">]
        member _.RouteTableId(state: VpnGatewayRoutePropagationState<Missing, 'VpnGatewayId>, value: string) : VpnGatewayRoutePropagationState<Present, 'VpnGatewayId> =
            state.assignments.Add(fun config -> config.RouteTableId <- value)
            ({ assignments = state.assignments } : VpnGatewayRoutePropagationState<Present, 'VpnGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway_route_propagation#vpn_gateway_id-1">VpnGatewayRoutePropagation#vpn_gateway_id</a>.
        /// </summary>
        [<CustomOperation "vpn_gateway_id">]
        member _.VpnGatewayId(state: VpnGatewayRoutePropagationState<'RouteTableId, Missing>, value: string) : VpnGatewayRoutePropagationState<'RouteTableId, Present> =
            state.assignments.Add(fun config -> config.VpnGatewayId <- value)
            ({ assignments = state.assignments } : VpnGatewayRoutePropagationState<'RouteTableId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway_route_propagation#id-1">VpnGatewayRoutePropagation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpnGatewayRoutePropagationState<'RouteTableId, 'VpnGatewayId>, value: string) : VpnGatewayRoutePropagationState<'RouteTableId, 'VpnGatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpnGatewayRoutePropagationState<'RouteTableId, 'VpnGatewayId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway_route_propagation#timeouts-1">VpnGatewayRoutePropagation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpnGatewayRoutePropagationState<'RouteTableId, 'VpnGatewayId>, value: aws.VpnGatewayRoutePropagation.VpnGatewayRoutePropagationTimeouts) : VpnGatewayRoutePropagationState<'RouteTableId, 'VpnGatewayId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpnGatewayRoutePropagationState<'RouteTableId, 'VpnGatewayId>

        member _.Run(state: VpnGatewayRoutePropagationState<Present, Present>) : aws.VpnGatewayRoutePropagation.VpnGatewayRoutePropagation =
            let config = aws.VpnGatewayRoutePropagation.VpnGatewayRoutePropagationConfig()
            for setter in state.assignments do
                setter config
            aws.VpnGatewayRoutePropagation.VpnGatewayRoutePropagation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpnGatewayRoutePropagation: missing required arguments. Must call: route_table_id, vpn_gateway_id.", 9999, IsError = true)>]
        member _.Run(_: VpnGatewayRoutePropagationState<_, _>) : aws.VpnGatewayRoutePropagation.VpnGatewayRoutePropagation =
            Unchecked.defaultof<aws.VpnGatewayRoutePropagation.VpnGatewayRoutePropagation>
