namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRouteTableState = { assignments: ResizeArray<aws.DataAwsRouteTable.DataAwsRouteTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_table">aws_route_table</a>.
    /// </summary>
    type DataAwsRouteTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRouteTableState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRouteTableState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_table#filter-1">DataAwsRouteTable#filter</a> Accepts: aws.IResolvable | aws.DataAwsRouteTable.DataAwsRouteTableFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsRouteTableState, value: HashiCorp.Cdktf.IResolvable) : DataAwsRouteTableState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_table#gateway_id-1">DataAwsRouteTable#gateway_id</a>.
        /// </summary>
        [<CustomOperation "gateway_id">]
        member _.GatewayId(state: DataAwsRouteTableState, value: string) : DataAwsRouteTableState =
            state.assignments.Add(fun config -> config.GatewayId <- value)
            state : DataAwsRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_table#id-1">DataAwsRouteTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRouteTableState, value: string) : DataAwsRouteTableState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_table#route_table_id-1">DataAwsRouteTable#route_table_id</a>.
        /// </summary>
        [<CustomOperation "route_table_id">]
        member _.RouteTableId(state: DataAwsRouteTableState, value: string) : DataAwsRouteTableState =
            state.assignments.Add(fun config -> config.RouteTableId <- value)
            state : DataAwsRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_table#subnet_id-1">DataAwsRouteTable#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: DataAwsRouteTableState, value: string) : DataAwsRouteTableState =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : DataAwsRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_table#tags-1">DataAwsRouteTable#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsRouteTableState, value: seq<string * string>) : DataAwsRouteTableState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsRouteTableState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_table#timeouts-1">DataAwsRouteTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsRouteTableState, value: aws.DataAwsRouteTable.DataAwsRouteTableTimeouts) : DataAwsRouteTableState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsRouteTableState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_table#vpc_id-1">DataAwsRouteTable#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: DataAwsRouteTableState, value: string) : DataAwsRouteTableState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : DataAwsRouteTableState

        member _.Run(state: DataAwsRouteTableState) : aws.DataAwsRouteTable.DataAwsRouteTable =
            let config = aws.DataAwsRouteTable.DataAwsRouteTableConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRouteTable.DataAwsRouteTable(StackContext.get (), logicalId, config)
