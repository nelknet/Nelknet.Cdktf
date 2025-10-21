namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcEndpointRouteTableAssociationState<'RouteTableId, 'VpcEndpointId> = { assignments: ResizeArray<aws.VpcEndpointRouteTableAssociation.VpcEndpointRouteTableAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_route_table_association">aws_vpc_endpoint_route_table_association</a>.
    /// </summary>
    type VpcEndpointRouteTableAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcEndpointRouteTableAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointRouteTableAssociationState<Missing, Missing>)

        member _.Zero(()) : VpcEndpointRouteTableAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointRouteTableAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_route_table_association#route_table_id-1">VpcEndpointRouteTableAssociation#route_table_id</a>.
        /// </summary>
        [<CustomOperation "route_table_id">]
        member _.RouteTableId(state: VpcEndpointRouteTableAssociationState<Missing, 'VpcEndpointId>, value: string) : VpcEndpointRouteTableAssociationState<Present, 'VpcEndpointId> =
            state.assignments.Add(fun config -> config.RouteTableId <- value)
            ({ assignments = state.assignments } : VpcEndpointRouteTableAssociationState<Present, 'VpcEndpointId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_route_table_association#vpc_endpoint_id-1">VpcEndpointRouteTableAssociation#vpc_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_id">]
        member _.VpcEndpointId(state: VpcEndpointRouteTableAssociationState<'RouteTableId, Missing>, value: string) : VpcEndpointRouteTableAssociationState<'RouteTableId, Present> =
            state.assignments.Add(fun config -> config.VpcEndpointId <- value)
            ({ assignments = state.assignments } : VpcEndpointRouteTableAssociationState<'RouteTableId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_route_table_association#id-1">VpcEndpointRouteTableAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcEndpointRouteTableAssociationState<'RouteTableId, 'VpcEndpointId>, value: string) : VpcEndpointRouteTableAssociationState<'RouteTableId, 'VpcEndpointId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcEndpointRouteTableAssociationState<'RouteTableId, 'VpcEndpointId>

        member _.Run(state: VpcEndpointRouteTableAssociationState<Present, Present>) : aws.VpcEndpointRouteTableAssociation.VpcEndpointRouteTableAssociation =
            let config = aws.VpcEndpointRouteTableAssociation.VpcEndpointRouteTableAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.VpcEndpointRouteTableAssociation.VpcEndpointRouteTableAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcEndpointRouteTableAssociation: missing required arguments. Must call: route_table_id, vpc_endpoint_id.", 9999, IsError = true)>]
        member _.Run(_: VpcEndpointRouteTableAssociationState<_, _>) : aws.VpcEndpointRouteTableAssociation.VpcEndpointRouteTableAssociation =
            Unchecked.defaultof<aws.VpcEndpointRouteTableAssociation.VpcEndpointRouteTableAssociation>
