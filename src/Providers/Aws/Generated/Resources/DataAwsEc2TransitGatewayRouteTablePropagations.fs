namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayRouteTablePropagationsState<'TransitGatewayRouteTableId> = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayRouteTablePropagations.DataAwsEc2TransitGatewayRouteTablePropagationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_propagations">aws_ec2_transit_gateway_route_table_propagations</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayRouteTablePropagationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayRouteTablePropagationsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEc2TransitGatewayRouteTablePropagationsState<Missing>)

        member _.Zero(()) : DataAwsEc2TransitGatewayRouteTablePropagationsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEc2TransitGatewayRouteTablePropagationsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_propagations#transit_gateway_route_table_id-1">DataAwsEc2TransitGatewayRouteTablePropagations#transit_gateway_route_table_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_route_table_id">]
        member _.TransitGatewayRouteTableId(state: DataAwsEc2TransitGatewayRouteTablePropagationsState<Missing>, value: string) : DataAwsEc2TransitGatewayRouteTablePropagationsState<Present> =
            state.assignments.Add(fun config -> config.TransitGatewayRouteTableId <- value)
            ({ assignments = state.assignments } : DataAwsEc2TransitGatewayRouteTablePropagationsState<Present>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_propagations#filter-1">DataAwsEc2TransitGatewayRouteTablePropagations#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayRouteTablePropagations.DataAwsEc2TransitGatewayRouteTablePropagationsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayRouteTablePropagationsState<'TransitGatewayRouteTableId>, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayRouteTablePropagationsState<'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayRouteTablePropagationsState<'TransitGatewayRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_propagations#id-1">DataAwsEc2TransitGatewayRouteTablePropagations#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayRouteTablePropagationsState<'TransitGatewayRouteTableId>, value: string) : DataAwsEc2TransitGatewayRouteTablePropagationsState<'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayRouteTablePropagationsState<'TransitGatewayRouteTableId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_propagations#timeouts-1">DataAwsEc2TransitGatewayRouteTablePropagations#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayRouteTablePropagationsState<'TransitGatewayRouteTableId>, value: aws.DataAwsEc2TransitGatewayRouteTablePropagations.DataAwsEc2TransitGatewayRouteTablePropagationsTimeouts) : DataAwsEc2TransitGatewayRouteTablePropagationsState<'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayRouteTablePropagationsState<'TransitGatewayRouteTableId>

        member _.Run(state: DataAwsEc2TransitGatewayRouteTablePropagationsState<Present>) : aws.DataAwsEc2TransitGatewayRouteTablePropagations.DataAwsEc2TransitGatewayRouteTablePropagations =
            let config = aws.DataAwsEc2TransitGatewayRouteTablePropagations.DataAwsEc2TransitGatewayRouteTablePropagationsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayRouteTablePropagations.DataAwsEc2TransitGatewayRouteTablePropagations(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEc2TransitGatewayRouteTablePropagations: missing required arguments. Must call: transit_gateway_route_table_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEc2TransitGatewayRouteTablePropagationsState<_>) : aws.DataAwsEc2TransitGatewayRouteTablePropagations.DataAwsEc2TransitGatewayRouteTablePropagations =
            Unchecked.defaultof<aws.DataAwsEc2TransitGatewayRouteTablePropagations.DataAwsEc2TransitGatewayRouteTablePropagations>
