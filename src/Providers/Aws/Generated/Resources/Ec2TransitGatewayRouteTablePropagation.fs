namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayRouteTablePropagationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId> = { assignments: ResizeArray<aws.Ec2TransitGatewayRouteTablePropagation.Ec2TransitGatewayRouteTablePropagationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table_propagation">aws_ec2_transit_gateway_route_table_propagation</a>.
    /// </summary>
    type Ec2TransitGatewayRouteTablePropagationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayRouteTablePropagationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayRouteTablePropagationState<Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayRouteTablePropagationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayRouteTablePropagationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table_propagation#transit_gateway_attachment_id-1">Ec2TransitGatewayRouteTablePropagation#transit_gateway_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_attachment_id">]
        member _.TransitGatewayAttachmentId(state: Ec2TransitGatewayRouteTablePropagationState<Missing, 'TransitGatewayRouteTableId>, value: string) : Ec2TransitGatewayRouteTablePropagationState<Present, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.TransitGatewayAttachmentId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayRouteTablePropagationState<Present, 'TransitGatewayRouteTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table_propagation#transit_gateway_route_table_id-1">Ec2TransitGatewayRouteTablePropagation#transit_gateway_route_table_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_route_table_id">]
        member _.TransitGatewayRouteTableId(state: Ec2TransitGatewayRouteTablePropagationState<'TransitGatewayAttachmentId, Missing>, value: string) : Ec2TransitGatewayRouteTablePropagationState<'TransitGatewayAttachmentId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayRouteTableId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayRouteTablePropagationState<'TransitGatewayAttachmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table_propagation#id-1">Ec2TransitGatewayRouteTablePropagation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayRouteTablePropagationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId>, value: string) : Ec2TransitGatewayRouteTablePropagationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayRouteTablePropagationState<'TransitGatewayAttachmentId, 'TransitGatewayRouteTableId>

        member _.Run(state: Ec2TransitGatewayRouteTablePropagationState<Present, Present>) : aws.Ec2TransitGatewayRouteTablePropagation.Ec2TransitGatewayRouteTablePropagation =
            let config = aws.Ec2TransitGatewayRouteTablePropagation.Ec2TransitGatewayRouteTablePropagationConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayRouteTablePropagation.Ec2TransitGatewayRouteTablePropagation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayRouteTablePropagation: missing required arguments. Must call: transit_gateway_attachment_id, transit_gateway_route_table_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayRouteTablePropagationState<_, _>) : aws.Ec2TransitGatewayRouteTablePropagation.Ec2TransitGatewayRouteTablePropagation =
            Unchecked.defaultof<aws.Ec2TransitGatewayRouteTablePropagation.Ec2TransitGatewayRouteTablePropagation>
