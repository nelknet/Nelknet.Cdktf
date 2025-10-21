namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcRouteServerEndpointState<'RouteServerId, 'SubnetId> = { assignments: ResizeArray<aws.VpcRouteServerEndpoint.VpcRouteServerEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_endpoint">aws_vpc_route_server_endpoint</a>.
    /// </summary>
    type VpcRouteServerEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcRouteServerEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcRouteServerEndpointState<Missing, Missing>)

        member _.Zero(()) : VpcRouteServerEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcRouteServerEndpointState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_endpoint#route_server_id-1">VpcRouteServerEndpoint#route_server_id</a>.
        /// </summary>
        [<CustomOperation "route_server_id">]
        member _.RouteServerId(state: VpcRouteServerEndpointState<Missing, 'SubnetId>, value: string) : VpcRouteServerEndpointState<Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.RouteServerId <- value)
            ({ assignments = state.assignments } : VpcRouteServerEndpointState<Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_endpoint#subnet_id-1">VpcRouteServerEndpoint#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: VpcRouteServerEndpointState<'RouteServerId, Missing>, value: string) : VpcRouteServerEndpointState<'RouteServerId, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : VpcRouteServerEndpointState<'RouteServerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_endpoint#tags-1">VpcRouteServerEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcRouteServerEndpointState<'RouteServerId, 'SubnetId>, value: seq<string * string>) : VpcRouteServerEndpointState<'RouteServerId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcRouteServerEndpointState<'RouteServerId, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_endpoint#timeouts-1">VpcRouteServerEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcRouteServerEndpointState<'RouteServerId, 'SubnetId>, value: aws.VpcRouteServerEndpoint.VpcRouteServerEndpointTimeouts) : VpcRouteServerEndpointState<'RouteServerId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcRouteServerEndpointState<'RouteServerId, 'SubnetId>

        member _.Run(state: VpcRouteServerEndpointState<Present, Present>) : aws.VpcRouteServerEndpoint.VpcRouteServerEndpoint =
            let config = aws.VpcRouteServerEndpoint.VpcRouteServerEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.VpcRouteServerEndpoint.VpcRouteServerEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcRouteServerEndpoint: missing required arguments. Must call: route_server_id, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: VpcRouteServerEndpointState<_, _>) : aws.VpcRouteServerEndpoint.VpcRouteServerEndpoint =
            Unchecked.defaultof<aws.VpcRouteServerEndpoint.VpcRouteServerEndpoint>
