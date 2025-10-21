namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RouteTableState<'VpcId> = { assignments: ResizeArray<aws.RouteTable.RouteTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table">aws_route_table</a>.
    /// </summary>
    type RouteTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : RouteTableState<Missing> =
            ({ assignments = ResizeArray() } : RouteTableState<Missing>)

        member _.Zero(()) : RouteTableState<Missing> =
            ({ assignments = ResizeArray() } : RouteTableState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#vpc_id-1">RouteTable#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: RouteTableState<Missing>, value: string) : RouteTableState<Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : RouteTableState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#id-1">RouteTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RouteTableState<'VpcId>, value: string) : RouteTableState<'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RouteTableState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#propagating_vgws-1">RouteTable#propagating_vgws</a>.
        /// </summary>
        [<CustomOperation "propagating_vgws">]
        member _.PropagatingVgws(state: RouteTableState<'VpcId>, value: seq<string>) : RouteTableState<'VpcId> =
            state.assignments.Add(fun config -> config.PropagatingVgws <- (value |> Seq.toArray))
            state : RouteTableState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#route-1">RouteTable#route</a>. Accepts: aws.IResolvable | aws.RouteTable.RouteTableRoute[]
        /// </summary>
        [<CustomOperation "route">]
        member _.Route(state: RouteTableState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : RouteTableState<'VpcId> =
            state.assignments.Add(fun config -> config.Route <- value)
            state : RouteTableState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#tags-1">RouteTable#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RouteTableState<'VpcId>, value: seq<string * string>) : RouteTableState<'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RouteTableState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#tags_all-1">RouteTable#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RouteTableState<'VpcId>, value: seq<string * string>) : RouteTableState<'VpcId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RouteTableState<'VpcId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#timeouts-1">RouteTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RouteTableState<'VpcId>, value: aws.RouteTable.RouteTableTimeouts) : RouteTableState<'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RouteTableState<'VpcId>

        member _.Run(state: RouteTableState<Present>) : aws.RouteTable.RouteTable =
            let config = aws.RouteTable.RouteTableConfig()
            for setter in state.assignments do
                setter config
            aws.RouteTable.RouteTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.routeTable: missing required arguments. Must call: vpc_id.", 9999, IsError = true)>]
        member _.Run(_: RouteTableState<_>) : aws.RouteTable.RouteTable =
            Unchecked.defaultof<aws.RouteTable.RouteTable>
