namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PlacementGroupState<'Name, 'Strategy> = { assignments: ResizeArray<aws.PlacementGroup.PlacementGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/placement_group">aws_placement_group</a>.
    /// </summary>
    type PlacementGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : PlacementGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PlacementGroupState<Missing, Missing>)

        member _.Zero(()) : PlacementGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PlacementGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/placement_group#name-1">PlacementGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PlacementGroupState<Missing, 'Strategy>, value: string) : PlacementGroupState<Present, 'Strategy> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PlacementGroupState<Present, 'Strategy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/placement_group#strategy-1">PlacementGroup#strategy</a>.
        /// </summary>
        [<CustomOperation "strategy">]
        member _.Strategy(state: PlacementGroupState<'Name, Missing>, value: string) : PlacementGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.Strategy <- value)
            ({ assignments = state.assignments } : PlacementGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/placement_group#id-1">PlacementGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PlacementGroupState<'Name, 'Strategy>, value: string) : PlacementGroupState<'Name, 'Strategy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PlacementGroupState<'Name, 'Strategy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/placement_group#partition_count-1">PlacementGroup#partition_count</a>.
        /// </summary>
        [<CustomOperation "partition_count">]
        member _.PartitionCount(state: PlacementGroupState<'Name, 'Strategy>, value: double) : PlacementGroupState<'Name, 'Strategy> =
            state.assignments.Add(fun config -> config.PartitionCount <- value)
            state : PlacementGroupState<'Name, 'Strategy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/placement_group#spread_level-1">PlacementGroup#spread_level</a>.
        /// </summary>
        [<CustomOperation "spread_level">]
        member _.SpreadLevel(state: PlacementGroupState<'Name, 'Strategy>, value: string) : PlacementGroupState<'Name, 'Strategy> =
            state.assignments.Add(fun config -> config.SpreadLevel <- value)
            state : PlacementGroupState<'Name, 'Strategy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/placement_group#tags-1">PlacementGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PlacementGroupState<'Name, 'Strategy>, value: seq<string * string>) : PlacementGroupState<'Name, 'Strategy> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PlacementGroupState<'Name, 'Strategy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/placement_group#tags_all-1">PlacementGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: PlacementGroupState<'Name, 'Strategy>, value: seq<string * string>) : PlacementGroupState<'Name, 'Strategy> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : PlacementGroupState<'Name, 'Strategy>

        member _.Run(state: PlacementGroupState<Present, Present>) : aws.PlacementGroup.PlacementGroup =
            let config = aws.PlacementGroup.PlacementGroupConfig()
            for setter in state.assignments do
                setter config
            aws.PlacementGroup.PlacementGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.placementGroup: missing required arguments. Must call: name, strategy.", 9999, IsError = true)>]
        member _.Run(_: PlacementGroupState<_, _>) : aws.PlacementGroup.PlacementGroup =
            Unchecked.defaultof<aws.PlacementGroup.PlacementGroup>
