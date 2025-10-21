namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayRouteTablesState = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayRouteTables.DataAwsEc2TransitGatewayRouteTablesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_tables">aws_ec2_transit_gateway_route_tables</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayRouteTablesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayRouteTablesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayRouteTablesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_tables#filter-1">DataAwsEc2TransitGatewayRouteTables#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayRouteTables.DataAwsEc2TransitGatewayRouteTablesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayRouteTablesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayRouteTablesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayRouteTablesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_tables#id-1">DataAwsEc2TransitGatewayRouteTables#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayRouteTablesState, value: string) : DataAwsEc2TransitGatewayRouteTablesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayRouteTablesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_tables#tags-1">DataAwsEc2TransitGatewayRouteTables#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2TransitGatewayRouteTablesState, value: seq<string * string>) : DataAwsEc2TransitGatewayRouteTablesState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2TransitGatewayRouteTablesState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_tables#timeouts-1">DataAwsEc2TransitGatewayRouteTables#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayRouteTablesState, value: aws.DataAwsEc2TransitGatewayRouteTables.DataAwsEc2TransitGatewayRouteTablesTimeouts) : DataAwsEc2TransitGatewayRouteTablesState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayRouteTablesState

        member _.Run(state: DataAwsEc2TransitGatewayRouteTablesState) : aws.DataAwsEc2TransitGatewayRouteTables.DataAwsEc2TransitGatewayRouteTables =
            let config = aws.DataAwsEc2TransitGatewayRouteTables.DataAwsEc2TransitGatewayRouteTablesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayRouteTables.DataAwsEc2TransitGatewayRouteTables(StackContext.get (), logicalId, config)
