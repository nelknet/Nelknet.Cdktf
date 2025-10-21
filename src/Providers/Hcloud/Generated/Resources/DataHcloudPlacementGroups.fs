namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudPlacementGroupsState = { assignments: ResizeArray<hcloud.DataHcloudPlacementGroups.DataHcloudPlacementGroupsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_groups">hcloud_placement_groups</a>.
    /// </summary>
    type DataHcloudPlacementGroupsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudPlacementGroupsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudPlacementGroupsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_groups#id-1">DataHcloudPlacementGroups#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudPlacementGroupsState, value: string) : DataHcloudPlacementGroupsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudPlacementGroupsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_groups#most_recent-1">DataHcloudPlacementGroups#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudPlacementGroupsState, value: bool) : DataHcloudPlacementGroupsState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudPlacementGroupsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_groups#most_recent-1">DataHcloudPlacementGroups#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudPlacementGroupsState, value: HashiCorp.Cdktf.IResolvable) : DataHcloudPlacementGroupsState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudPlacementGroupsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_groups#with_selector-1">DataHcloudPlacementGroups#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudPlacementGroupsState, value: string) : DataHcloudPlacementGroupsState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudPlacementGroupsState

        member _.Run(state: DataHcloudPlacementGroupsState) : hcloud.DataHcloudPlacementGroups.DataHcloudPlacementGroups =
            let config = hcloud.DataHcloudPlacementGroups.DataHcloudPlacementGroupsConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudPlacementGroups.DataHcloudPlacementGroups(StackContext.get (), logicalId, config)
