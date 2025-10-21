namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRouteTablesState = { assignments: ResizeArray<aws.DataAwsRouteTables.DataAwsRouteTablesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_tables">aws_route_tables</a>.
    /// </summary>
    type DataAwsRouteTablesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRouteTablesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRouteTablesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_tables#filter-1">DataAwsRouteTables#filter</a> Accepts: aws.IResolvable | aws.DataAwsRouteTables.DataAwsRouteTablesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsRouteTablesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsRouteTablesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsRouteTablesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_tables#id-1">DataAwsRouteTables#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRouteTablesState, value: string) : DataAwsRouteTablesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRouteTablesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_tables#tags-1">DataAwsRouteTables#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsRouteTablesState, value: seq<string * string>) : DataAwsRouteTablesState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsRouteTablesState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_tables#timeouts-1">DataAwsRouteTables#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsRouteTablesState, value: aws.DataAwsRouteTables.DataAwsRouteTablesTimeouts) : DataAwsRouteTablesState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsRouteTablesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_tables#vpc_id-1">DataAwsRouteTables#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: DataAwsRouteTablesState, value: string) : DataAwsRouteTablesState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : DataAwsRouteTablesState

        member _.Run(state: DataAwsRouteTablesState) : aws.DataAwsRouteTables.DataAwsRouteTables =
            let config = aws.DataAwsRouteTables.DataAwsRouteTablesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRouteTables.DataAwsRouteTables(StackContext.get (), logicalId, config)
