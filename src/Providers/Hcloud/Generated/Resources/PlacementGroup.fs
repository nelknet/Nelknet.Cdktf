namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PlacementGroupState<'Name, 'Type> = { assignments: ResizeArray<hcloud.PlacementGroup.PlacementGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/placement_group">hcloud_placement_group</a>.
    /// </summary>
    type PlacementGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : PlacementGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PlacementGroupState<Missing, Missing>)

        member _.Zero(()) : PlacementGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PlacementGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/placement_group#name-1">PlacementGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PlacementGroupState<Missing, 'Type>, value: string) : PlacementGroupState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PlacementGroupState<Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/placement_group#type-1">PlacementGroup#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: PlacementGroupState<'Name, Missing>, value: string) : PlacementGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : PlacementGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/placement_group#id-1">PlacementGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PlacementGroupState<'Name, 'Type>, value: string) : PlacementGroupState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PlacementGroupState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/placement_group#labels-1">PlacementGroup#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: PlacementGroupState<'Name, 'Type>, value: seq<string * string>) : PlacementGroupState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : PlacementGroupState<'Name, 'Type>

        member _.Run(state: PlacementGroupState<Present, Present>) : hcloud.PlacementGroup.PlacementGroup =
            let config = hcloud.PlacementGroup.PlacementGroupConfig()
            for setter in state.assignments do
                setter config
            hcloud.PlacementGroup.PlacementGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.placementGroup: missing required arguments. Must call: name, type.", 9999, IsError = true)>]
        member _.Run(_: PlacementGroupState<_, _>) : hcloud.PlacementGroup.PlacementGroup =
            Unchecked.defaultof<hcloud.PlacementGroup.PlacementGroup>
