namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayDefaultRouteTablePropagationState<'TransitGatewayId, 'TransitGatewayRouteTableId> = { assignments: ResizeArray<aws.Ec2TransitGatewayDefaultRouteTablePropagation.Ec2TransitGatewayDefaultRouteTablePropagationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_default_route_table_propagation">aws_ec2_transit_gateway_default_route_table_propagation</a>.
    /// </summary>
    type Ec2TransitGatewayDefaultRouteTablePropagationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayDefaultRouteTablePropagationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayDefaultRouteTablePropagationState<Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayDefaultRouteTablePropagationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayDefaultRouteTablePropagationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_default_route_table_propagation#transit_gateway_id-1">Ec2TransitGatewayDefaultRouteTablePropagation#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: Ec2TransitGatewayDefaultRouteTablePropagationState<Missing, 'TransitGatewayRouteTableId>, value: string) : Ec2TransitGatewayDefaultRouteTablePropagationState<Present, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayDefaultRouteTablePropagationState<Present, 'TransitGatewayRouteTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_default_route_table_propagation#transit_gateway_route_table_id-1">Ec2TransitGatewayDefaultRouteTablePropagation#transit_gateway_route_table_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_route_table_id">]
        member _.TransitGatewayRouteTableId(state: Ec2TransitGatewayDefaultRouteTablePropagationState<'TransitGatewayId, Missing>, value: string) : Ec2TransitGatewayDefaultRouteTablePropagationState<'TransitGatewayId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayRouteTableId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayDefaultRouteTablePropagationState<'TransitGatewayId, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_default_route_table_propagation#timeouts-1">Ec2TransitGatewayDefaultRouteTablePropagation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2TransitGatewayDefaultRouteTablePropagationState<'TransitGatewayId, 'TransitGatewayRouteTableId>, value: aws.Ec2TransitGatewayDefaultRouteTablePropagation.Ec2TransitGatewayDefaultRouteTablePropagationTimeouts) : Ec2TransitGatewayDefaultRouteTablePropagationState<'TransitGatewayId, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2TransitGatewayDefaultRouteTablePropagationState<'TransitGatewayId, 'TransitGatewayRouteTableId>

        member _.Run(state: Ec2TransitGatewayDefaultRouteTablePropagationState<Present, Present>) : aws.Ec2TransitGatewayDefaultRouteTablePropagation.Ec2TransitGatewayDefaultRouteTablePropagation =
            let config = aws.Ec2TransitGatewayDefaultRouteTablePropagation.Ec2TransitGatewayDefaultRouteTablePropagationConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayDefaultRouteTablePropagation.Ec2TransitGatewayDefaultRouteTablePropagation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayDefaultRouteTablePropagation: missing required arguments. Must call: transit_gateway_id, transit_gateway_route_table_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayDefaultRouteTablePropagationState<_, _>) : aws.Ec2TransitGatewayDefaultRouteTablePropagation.Ec2TransitGatewayDefaultRouteTablePropagation =
            Unchecked.defaultof<aws.Ec2TransitGatewayDefaultRouteTablePropagation.Ec2TransitGatewayDefaultRouteTablePropagation>
