namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcRouteServerVpcAssociationState<'RouteServerId, 'VpcId> = { assignments: ResizeArray<aws.VpcRouteServerVpcAssociation.VpcRouteServerVpcAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_vpc_association">aws_vpc_route_server_vpc_association</a>.
    /// </summary>
    type VpcRouteServerVpcAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcRouteServerVpcAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcRouteServerVpcAssociationState<Missing, Missing>)

        member _.Zero(()) : VpcRouteServerVpcAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcRouteServerVpcAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_vpc_association#route_server_id-1">VpcRouteServerVpcAssociation#route_server_id</a>.
        /// </summary>
        [<CustomOperation "route_server_id">]
        member _.RouteServerId(state: VpcRouteServerVpcAssociationState<Missing, 'VpcId>, value: string) : VpcRouteServerVpcAssociationState<Present, 'VpcId> =
            state.assignments.Add(fun config -> config.RouteServerId <- value)
            ({ assignments = state.assignments } : VpcRouteServerVpcAssociationState<Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_vpc_association#vpc_id-1">VpcRouteServerVpcAssociation#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: VpcRouteServerVpcAssociationState<'RouteServerId, Missing>, value: string) : VpcRouteServerVpcAssociationState<'RouteServerId, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : VpcRouteServerVpcAssociationState<'RouteServerId, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_vpc_association#timeouts-1">VpcRouteServerVpcAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcRouteServerVpcAssociationState<'RouteServerId, 'VpcId>, value: aws.VpcRouteServerVpcAssociation.VpcRouteServerVpcAssociationTimeouts) : VpcRouteServerVpcAssociationState<'RouteServerId, 'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcRouteServerVpcAssociationState<'RouteServerId, 'VpcId>

        member _.Run(state: VpcRouteServerVpcAssociationState<Present, Present>) : aws.VpcRouteServerVpcAssociation.VpcRouteServerVpcAssociation =
            let config = aws.VpcRouteServerVpcAssociation.VpcRouteServerVpcAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.VpcRouteServerVpcAssociation.VpcRouteServerVpcAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcRouteServerVpcAssociation: missing required arguments. Must call: route_server_id, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: VpcRouteServerVpcAssociationState<_, _>) : aws.VpcRouteServerVpcAssociation.VpcRouteServerVpcAssociation =
            Unchecked.defaultof<aws.VpcRouteServerVpcAssociation.VpcRouteServerVpcAssociation>
