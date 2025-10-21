namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudPlacementGroupState = { assignments: ResizeArray<hcloud.DataHcloudPlacementGroup.DataHcloudPlacementGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group">hcloud_placement_group</a>.
    /// </summary>
    type DataHcloudPlacementGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudPlacementGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudPlacementGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#id-1">DataHcloudPlacementGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudPlacementGroupState, value: double) : DataHcloudPlacementGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudPlacementGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#labels-1">DataHcloudPlacementGroup#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: DataHcloudPlacementGroupState, value: seq<string * string>) : DataHcloudPlacementGroupState =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : DataHcloudPlacementGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#most_recent-1">DataHcloudPlacementGroup#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudPlacementGroupState, value: bool) : DataHcloudPlacementGroupState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudPlacementGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#most_recent-1">DataHcloudPlacementGroup#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudPlacementGroupState, value: HashiCorp.Cdktf.IResolvable) : DataHcloudPlacementGroupState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudPlacementGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#name-1">DataHcloudPlacementGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudPlacementGroupState, value: string) : DataHcloudPlacementGroupState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudPlacementGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#type-1">DataHcloudPlacementGroup#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataHcloudPlacementGroupState, value: string) : DataHcloudPlacementGroupState =
            state.assignments.Add(fun config -> config.Type <- value)
            state : DataHcloudPlacementGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#with_selector-1">DataHcloudPlacementGroup#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudPlacementGroupState, value: string) : DataHcloudPlacementGroupState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudPlacementGroupState

        member _.Run(state: DataHcloudPlacementGroupState) : hcloud.DataHcloudPlacementGroup.DataHcloudPlacementGroup =
            let config = hcloud.DataHcloudPlacementGroup.DataHcloudPlacementGroupConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudPlacementGroup.DataHcloudPlacementGroup(StackContext.get (), logicalId, config)
