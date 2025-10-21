namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayRouteTableRoutesState<'Filter, 'TransitGatewayRouteTableId> = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayRouteTableRoutes.DataAwsEc2TransitGatewayRouteTableRoutesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_routes">aws_ec2_transit_gateway_route_table_routes</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayRouteTableRoutesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayRouteTableRoutesState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEc2TransitGatewayRouteTableRoutesState<Missing, Missing>)

        member _.Zero(()) : DataAwsEc2TransitGatewayRouteTableRoutesState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEc2TransitGatewayRouteTableRoutesState<Missing, Missing>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_routes#filter-1">DataAwsEc2TransitGatewayRouteTableRoutes#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayRouteTableRoutes.DataAwsEc2TransitGatewayRouteTableRoutesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayRouteTableRoutesState<Missing, 'TransitGatewayRouteTableId>, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayRouteTableRoutesState<Present, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Filter <- value)
            ({ assignments = state.assignments } : DataAwsEc2TransitGatewayRouteTableRoutesState<Present, 'TransitGatewayRouteTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_routes#transit_gateway_route_table_id-1">DataAwsEc2TransitGatewayRouteTableRoutes#transit_gateway_route_table_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_route_table_id">]
        member _.TransitGatewayRouteTableId(state: DataAwsEc2TransitGatewayRouteTableRoutesState<'Filter, Missing>, value: string) : DataAwsEc2TransitGatewayRouteTableRoutesState<'Filter, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayRouteTableId <- value)
            ({ assignments = state.assignments } : DataAwsEc2TransitGatewayRouteTableRoutesState<'Filter, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_routes#id-1">DataAwsEc2TransitGatewayRouteTableRoutes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayRouteTableRoutesState<'Filter, 'TransitGatewayRouteTableId>, value: string) : DataAwsEc2TransitGatewayRouteTableRoutesState<'Filter, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayRouteTableRoutesState<'Filter, 'TransitGatewayRouteTableId>

        member _.Run(state: DataAwsEc2TransitGatewayRouteTableRoutesState<Present, Present>) : aws.DataAwsEc2TransitGatewayRouteTableRoutes.DataAwsEc2TransitGatewayRouteTableRoutes =
            let config = aws.DataAwsEc2TransitGatewayRouteTableRoutes.DataAwsEc2TransitGatewayRouteTableRoutesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayRouteTableRoutes.DataAwsEc2TransitGatewayRouteTableRoutes(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEc2TransitGatewayRouteTableRoutes: missing required arguments. Must call: filter, transit_gateway_route_table_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEc2TransitGatewayRouteTableRoutesState<_, _>) : aws.DataAwsEc2TransitGatewayRouteTableRoutes.DataAwsEc2TransitGatewayRouteTableRoutes =
            Unchecked.defaultof<aws.DataAwsEc2TransitGatewayRouteTableRoutes.DataAwsEc2TransitGatewayRouteTableRoutes>
