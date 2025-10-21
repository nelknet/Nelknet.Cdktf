namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RouteTableAssociationState<'RouteTableId> = { assignments: ResizeArray<aws.RouteTableAssociation.RouteTableAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table_association">aws_route_table_association</a>.
    /// </summary>
    type RouteTableAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RouteTableAssociationState<Missing> =
            ({ assignments = ResizeArray() } : RouteTableAssociationState<Missing>)

        member _.Zero(()) : RouteTableAssociationState<Missing> =
            ({ assignments = ResizeArray() } : RouteTableAssociationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table_association#route_table_id-1">RouteTableAssociation#route_table_id</a>.
        /// </summary>
        [<CustomOperation "route_table_id">]
        member _.RouteTableId(state: RouteTableAssociationState<Missing>, value: string) : RouteTableAssociationState<Present> =
            state.assignments.Add(fun config -> config.RouteTableId <- value)
            ({ assignments = state.assignments } : RouteTableAssociationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table_association#gateway_id-1">RouteTableAssociation#gateway_id</a>.
        /// </summary>
        [<CustomOperation "gateway_id">]
        member _.GatewayId(state: RouteTableAssociationState<'RouteTableId>, value: string) : RouteTableAssociationState<'RouteTableId> =
            state.assignments.Add(fun config -> config.GatewayId <- value)
            state : RouteTableAssociationState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table_association#id-1">RouteTableAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RouteTableAssociationState<'RouteTableId>, value: string) : RouteTableAssociationState<'RouteTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RouteTableAssociationState<'RouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table_association#subnet_id-1">RouteTableAssociation#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: RouteTableAssociationState<'RouteTableId>, value: string) : RouteTableAssociationState<'RouteTableId> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : RouteTableAssociationState<'RouteTableId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table_association#timeouts-1">RouteTableAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RouteTableAssociationState<'RouteTableId>, value: aws.RouteTableAssociation.RouteTableAssociationTimeouts) : RouteTableAssociationState<'RouteTableId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RouteTableAssociationState<'RouteTableId>

        member _.Run(state: RouteTableAssociationState<Present>) : aws.RouteTableAssociation.RouteTableAssociation =
            let config = aws.RouteTableAssociation.RouteTableAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.RouteTableAssociation.RouteTableAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.routeTableAssociation: missing required arguments. Must call: route_table_id.", 9999, IsError = true)>]
        member _.Run(_: RouteTableAssociationState<_>) : aws.RouteTableAssociation.RouteTableAssociation =
            Unchecked.defaultof<aws.RouteTableAssociation.RouteTableAssociation>
