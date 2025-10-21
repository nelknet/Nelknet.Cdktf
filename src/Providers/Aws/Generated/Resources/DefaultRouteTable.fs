namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DefaultRouteTableState<'DefaultRouteTableId> = { assignments: ResizeArray<aws.DefaultRouteTable.DefaultRouteTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_route_table">aws_default_route_table</a>.
    /// </summary>
    type DefaultRouteTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DefaultRouteTableState<Missing> =
            ({ assignments = ResizeArray() } : DefaultRouteTableState<Missing>)

        member _.Zero(()) : DefaultRouteTableState<Missing> =
            ({ assignments = ResizeArray() } : DefaultRouteTableState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_route_table#default_route_table_id-1">DefaultRouteTable#default_route_table_id</a>.
        /// </summary>
        [<CustomOperation "default_route_table_id">]
        member _.DefaultRouteTableId(state: DefaultRouteTableState<Missing>, value: string) : DefaultRouteTableState<Present> =
            state.assignments.Add(fun config -> config.DefaultRouteTableId <- value)
            ({ assignments = state.assignments } : DefaultRouteTableState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_route_table#id-1">DefaultRouteTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DefaultRouteTableState<'DefaultRouteTableId>, value: string) : DefaultRouteTableState<'DefaultRouteTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DefaultRouteTableState<'DefaultRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_route_table#propagating_vgws-1">DefaultRouteTable#propagating_vgws</a>.
        /// </summary>
        [<CustomOperation "propagating_vgws">]
        member _.PropagatingVgws(state: DefaultRouteTableState<'DefaultRouteTableId>, value: seq<string>) : DefaultRouteTableState<'DefaultRouteTableId> =
            state.assignments.Add(fun config -> config.PropagatingVgws <- (value |> Seq.toArray))
            state : DefaultRouteTableState<'DefaultRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_route_table#route-1">DefaultRouteTable#route</a>. Accepts: aws.IResolvable | aws.DefaultRouteTable.DefaultRouteTableRoute[]
        /// </summary>
        [<CustomOperation "route">]
        member _.Route(state: DefaultRouteTableState<'DefaultRouteTableId>, value: HashiCorp.Cdktf.IResolvable) : DefaultRouteTableState<'DefaultRouteTableId> =
            state.assignments.Add(fun config -> config.Route <- value)
            state : DefaultRouteTableState<'DefaultRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_route_table#tags-1">DefaultRouteTable#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DefaultRouteTableState<'DefaultRouteTableId>, value: seq<string * string>) : DefaultRouteTableState<'DefaultRouteTableId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DefaultRouteTableState<'DefaultRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_route_table#tags_all-1">DefaultRouteTable#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DefaultRouteTableState<'DefaultRouteTableId>, value: seq<string * string>) : DefaultRouteTableState<'DefaultRouteTableId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DefaultRouteTableState<'DefaultRouteTableId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_route_table#timeouts-1">DefaultRouteTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DefaultRouteTableState<'DefaultRouteTableId>, value: aws.DefaultRouteTable.DefaultRouteTableTimeouts) : DefaultRouteTableState<'DefaultRouteTableId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DefaultRouteTableState<'DefaultRouteTableId>

        member _.Run(state: DefaultRouteTableState<Present>) : aws.DefaultRouteTable.DefaultRouteTable =
            let config = aws.DefaultRouteTable.DefaultRouteTableConfig()
            for setter in state.assignments do
                setter config
            aws.DefaultRouteTable.DefaultRouteTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.defaultRouteTable: missing required arguments. Must call: default_route_table_id.", 9999, IsError = true)>]
        member _.Run(_: DefaultRouteTableState<_>) : aws.DefaultRouteTable.DefaultRouteTable =
            Unchecked.defaultof<aws.DefaultRouteTable.DefaultRouteTable>
