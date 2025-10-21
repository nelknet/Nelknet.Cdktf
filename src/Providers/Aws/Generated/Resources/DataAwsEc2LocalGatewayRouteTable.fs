namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2LocalGatewayRouteTableState = { assignments: ResizeArray<aws.DataAwsEc2LocalGatewayRouteTable.DataAwsEc2LocalGatewayRouteTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_table">aws_ec2_local_gateway_route_table</a>.
    /// </summary>
    type DataAwsEc2LocalGatewayRouteTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2LocalGatewayRouteTableState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2LocalGatewayRouteTableState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_table#filter-1">DataAwsEc2LocalGatewayRouteTable#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2LocalGatewayRouteTable.DataAwsEc2LocalGatewayRouteTableFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2LocalGatewayRouteTableState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2LocalGatewayRouteTableState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2LocalGatewayRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_table#id-1">DataAwsEc2LocalGatewayRouteTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2LocalGatewayRouteTableState, value: string) : DataAwsEc2LocalGatewayRouteTableState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2LocalGatewayRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_table#local_gateway_id-1">DataAwsEc2LocalGatewayRouteTable#local_gateway_id</a>.
        /// </summary>
        [<CustomOperation "local_gateway_id">]
        member _.LocalGatewayId(state: DataAwsEc2LocalGatewayRouteTableState, value: string) : DataAwsEc2LocalGatewayRouteTableState =
            state.assignments.Add(fun config -> config.LocalGatewayId <- value)
            state : DataAwsEc2LocalGatewayRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_table#local_gateway_route_table_id-1">DataAwsEc2LocalGatewayRouteTable#local_gateway_route_table_id</a>.
        /// </summary>
        [<CustomOperation "local_gateway_route_table_id">]
        member _.LocalGatewayRouteTableId(state: DataAwsEc2LocalGatewayRouteTableState, value: string) : DataAwsEc2LocalGatewayRouteTableState =
            state.assignments.Add(fun config -> config.LocalGatewayRouteTableId <- value)
            state : DataAwsEc2LocalGatewayRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_table#outpost_arn-1">DataAwsEc2LocalGatewayRouteTable#outpost_arn</a>.
        /// </summary>
        [<CustomOperation "outpost_arn">]
        member _.OutpostArn(state: DataAwsEc2LocalGatewayRouteTableState, value: string) : DataAwsEc2LocalGatewayRouteTableState =
            state.assignments.Add(fun config -> config.OutpostArn <- value)
            state : DataAwsEc2LocalGatewayRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_table#state-1">DataAwsEc2LocalGatewayRouteTable#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: DataAwsEc2LocalGatewayRouteTableState, value: string) : DataAwsEc2LocalGatewayRouteTableState =
            state.assignments.Add(fun config -> config.State <- value)
            state : DataAwsEc2LocalGatewayRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_table#tags-1">DataAwsEc2LocalGatewayRouteTable#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2LocalGatewayRouteTableState, value: seq<string * string>) : DataAwsEc2LocalGatewayRouteTableState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2LocalGatewayRouteTableState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_table#timeouts-1">DataAwsEc2LocalGatewayRouteTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2LocalGatewayRouteTableState, value: aws.DataAwsEc2LocalGatewayRouteTable.DataAwsEc2LocalGatewayRouteTableTimeouts) : DataAwsEc2LocalGatewayRouteTableState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2LocalGatewayRouteTableState

        member _.Run(state: DataAwsEc2LocalGatewayRouteTableState) : aws.DataAwsEc2LocalGatewayRouteTable.DataAwsEc2LocalGatewayRouteTable =
            let config = aws.DataAwsEc2LocalGatewayRouteTable.DataAwsEc2LocalGatewayRouteTableConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2LocalGatewayRouteTable.DataAwsEc2LocalGatewayRouteTable(StackContext.get (), logicalId, config)
