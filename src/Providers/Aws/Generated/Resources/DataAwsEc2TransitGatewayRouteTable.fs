namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayRouteTableState = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayRouteTable.DataAwsEc2TransitGatewayRouteTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table">aws_ec2_transit_gateway_route_table</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayRouteTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayRouteTableState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayRouteTableState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table#filter-1">DataAwsEc2TransitGatewayRouteTable#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayRouteTable.DataAwsEc2TransitGatewayRouteTableFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayRouteTableState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayRouteTableState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table#id-1">DataAwsEc2TransitGatewayRouteTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayRouteTableState, value: string) : DataAwsEc2TransitGatewayRouteTableState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table#tags-1">DataAwsEc2TransitGatewayRouteTable#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2TransitGatewayRouteTableState, value: seq<string * string>) : DataAwsEc2TransitGatewayRouteTableState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2TransitGatewayRouteTableState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table#timeouts-1">DataAwsEc2TransitGatewayRouteTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayRouteTableState, value: aws.DataAwsEc2TransitGatewayRouteTable.DataAwsEc2TransitGatewayRouteTableTimeouts) : DataAwsEc2TransitGatewayRouteTableState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayRouteTableState

        member _.Run(state: DataAwsEc2TransitGatewayRouteTableState) : aws.DataAwsEc2TransitGatewayRouteTable.DataAwsEc2TransitGatewayRouteTable =
            let config = aws.DataAwsEc2TransitGatewayRouteTable.DataAwsEc2TransitGatewayRouteTableConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayRouteTable.DataAwsEc2TransitGatewayRouteTable(StackContext.get (), logicalId, config)
