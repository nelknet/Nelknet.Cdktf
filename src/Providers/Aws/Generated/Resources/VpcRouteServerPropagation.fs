namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcRouteServerPropagationState<'RouteServerId, 'RouteTableId> = { assignments: ResizeArray<aws.VpcRouteServerPropagation.VpcRouteServerPropagationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_propagation">aws_vpc_route_server_propagation</a>.
    /// </summary>
    type VpcRouteServerPropagationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcRouteServerPropagationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcRouteServerPropagationState<Missing, Missing>)

        member _.Zero(()) : VpcRouteServerPropagationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcRouteServerPropagationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_propagation#route_server_id-1">VpcRouteServerPropagation#route_server_id</a>.
        /// </summary>
        [<CustomOperation "route_server_id">]
        member _.RouteServerId(state: VpcRouteServerPropagationState<Missing, 'RouteTableId>, value: string) : VpcRouteServerPropagationState<Present, 'RouteTableId> =
            state.assignments.Add(fun config -> config.RouteServerId <- value)
            ({ assignments = state.assignments } : VpcRouteServerPropagationState<Present, 'RouteTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_propagation#route_table_id-1">VpcRouteServerPropagation#route_table_id</a>.
        /// </summary>
        [<CustomOperation "route_table_id">]
        member _.RouteTableId(state: VpcRouteServerPropagationState<'RouteServerId, Missing>, value: string) : VpcRouteServerPropagationState<'RouteServerId, Present> =
            state.assignments.Add(fun config -> config.RouteTableId <- value)
            ({ assignments = state.assignments } : VpcRouteServerPropagationState<'RouteServerId, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_propagation#timeouts-1">VpcRouteServerPropagation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcRouteServerPropagationState<'RouteServerId, 'RouteTableId>, value: aws.VpcRouteServerPropagation.VpcRouteServerPropagationTimeouts) : VpcRouteServerPropagationState<'RouteServerId, 'RouteTableId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcRouteServerPropagationState<'RouteServerId, 'RouteTableId>

        member _.Run(state: VpcRouteServerPropagationState<Present, Present>) : aws.VpcRouteServerPropagation.VpcRouteServerPropagation =
            let config = aws.VpcRouteServerPropagation.VpcRouteServerPropagationConfig()
            for setter in state.assignments do
                setter config
            aws.VpcRouteServerPropagation.VpcRouteServerPropagation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcRouteServerPropagation: missing required arguments. Must call: route_server_id, route_table_id.", 9999, IsError = true)>]
        member _.Run(_: VpcRouteServerPropagationState<_, _>) : aws.VpcRouteServerPropagation.VpcRouteServerPropagation =
            Unchecked.defaultof<aws.VpcRouteServerPropagation.VpcRouteServerPropagation>
