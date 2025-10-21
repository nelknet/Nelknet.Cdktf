namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2LocalGatewayRouteTablesState = { assignments: ResizeArray<aws.DataAwsEc2LocalGatewayRouteTables.DataAwsEc2LocalGatewayRouteTablesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_tables">aws_ec2_local_gateway_route_tables</a>.
    /// </summary>
    type DataAwsEc2LocalGatewayRouteTablesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2LocalGatewayRouteTablesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2LocalGatewayRouteTablesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_tables#filter-1">DataAwsEc2LocalGatewayRouteTables#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2LocalGatewayRouteTables.DataAwsEc2LocalGatewayRouteTablesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2LocalGatewayRouteTablesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2LocalGatewayRouteTablesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2LocalGatewayRouteTablesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_tables#id-1">DataAwsEc2LocalGatewayRouteTables#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2LocalGatewayRouteTablesState, value: string) : DataAwsEc2LocalGatewayRouteTablesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2LocalGatewayRouteTablesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_tables#tags-1">DataAwsEc2LocalGatewayRouteTables#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2LocalGatewayRouteTablesState, value: seq<string * string>) : DataAwsEc2LocalGatewayRouteTablesState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2LocalGatewayRouteTablesState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_route_tables#timeouts-1">DataAwsEc2LocalGatewayRouteTables#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2LocalGatewayRouteTablesState, value: aws.DataAwsEc2LocalGatewayRouteTables.DataAwsEc2LocalGatewayRouteTablesTimeouts) : DataAwsEc2LocalGatewayRouteTablesState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2LocalGatewayRouteTablesState

        member _.Run(state: DataAwsEc2LocalGatewayRouteTablesState) : aws.DataAwsEc2LocalGatewayRouteTables.DataAwsEc2LocalGatewayRouteTables =
            let config = aws.DataAwsEc2LocalGatewayRouteTables.DataAwsEc2LocalGatewayRouteTablesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2LocalGatewayRouteTables.DataAwsEc2LocalGatewayRouteTables(StackContext.get (), logicalId, config)
