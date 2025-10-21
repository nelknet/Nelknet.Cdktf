namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MainRouteTableAssociationState<'RouteTableId, 'VpcId> = { assignments: ResizeArray<aws.MainRouteTableAssociation.MainRouteTableAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/main_route_table_association">aws_main_route_table_association</a>.
    /// </summary>
    type MainRouteTableAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : MainRouteTableAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MainRouteTableAssociationState<Missing, Missing>)

        member _.Zero(()) : MainRouteTableAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MainRouteTableAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/main_route_table_association#route_table_id-1">MainRouteTableAssociation#route_table_id</a>.
        /// </summary>
        [<CustomOperation "route_table_id">]
        member _.RouteTableId(state: MainRouteTableAssociationState<Missing, 'VpcId>, value: string) : MainRouteTableAssociationState<Present, 'VpcId> =
            state.assignments.Add(fun config -> config.RouteTableId <- value)
            ({ assignments = state.assignments } : MainRouteTableAssociationState<Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/main_route_table_association#vpc_id-1">MainRouteTableAssociation#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: MainRouteTableAssociationState<'RouteTableId, Missing>, value: string) : MainRouteTableAssociationState<'RouteTableId, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : MainRouteTableAssociationState<'RouteTableId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/main_route_table_association#id-1">MainRouteTableAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MainRouteTableAssociationState<'RouteTableId, 'VpcId>, value: string) : MainRouteTableAssociationState<'RouteTableId, 'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MainRouteTableAssociationState<'RouteTableId, 'VpcId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/main_route_table_association#timeouts-1">MainRouteTableAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MainRouteTableAssociationState<'RouteTableId, 'VpcId>, value: aws.MainRouteTableAssociation.MainRouteTableAssociationTimeouts) : MainRouteTableAssociationState<'RouteTableId, 'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MainRouteTableAssociationState<'RouteTableId, 'VpcId>

        member _.Run(state: MainRouteTableAssociationState<Present, Present>) : aws.MainRouteTableAssociation.MainRouteTableAssociation =
            let config = aws.MainRouteTableAssociation.MainRouteTableAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.MainRouteTableAssociation.MainRouteTableAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mainRouteTableAssociation: missing required arguments. Must call: route_table_id, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: MainRouteTableAssociationState<_, _>) : aws.MainRouteTableAssociation.MainRouteTableAssociation =
            Unchecked.defaultof<aws.MainRouteTableAssociation.MainRouteTableAssociation>
