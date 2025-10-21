namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ProximityPlacementGroup.ProximityPlacementGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/proximity_placement_group">azurerm_proximity_placement_group</a>.
    /// </summary>
    type ProximityPlacementGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ProximityPlacementGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ProximityPlacementGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : ProximityPlacementGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ProximityPlacementGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/proximity_placement_group#location-1">ProximityPlacementGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ProximityPlacementGroupState<Missing, 'Name, 'ResourceGroupName>, value: string) : ProximityPlacementGroupState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ProximityPlacementGroupState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/proximity_placement_group#name-1">ProximityPlacementGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ProximityPlacementGroupState<'Location, Missing, 'ResourceGroupName>, value: string) : ProximityPlacementGroupState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ProximityPlacementGroupState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/proximity_placement_group#resource_group_name-1">ProximityPlacementGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ProximityPlacementGroupState<'Location, 'Name, Missing>, value: string) : ProximityPlacementGroupState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ProximityPlacementGroupState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/proximity_placement_group#allowed_vm_sizes-1">ProximityPlacementGroup#allowed_vm_sizes</a>.
        /// </summary>
        [<CustomOperation "allowed_vm_sizes">]
        member _.AllowedVmSizes(state: ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowedVmSizes <- (value |> Seq.toArray))
            state : ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/proximity_placement_group#id-1">ProximityPlacementGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName>, value: string) : ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/proximity_placement_group#tags-1">ProximityPlacementGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/proximity_placement_group#timeouts-1">ProximityPlacementGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.ProximityPlacementGroup.ProximityPlacementGroupTimeouts) : ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/proximity_placement_group#zone-1">ProximityPlacementGroup#zone</a>.
        /// </summary>
        [<CustomOperation "zone">]
        member _.Zone(state: ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName>, value: string) : ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Zone <- value)
            state : ProximityPlacementGroupState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ProximityPlacementGroupState<Present, Present, Present>) : azurerm.ProximityPlacementGroup.ProximityPlacementGroup =
            let config = azurerm.ProximityPlacementGroup.ProximityPlacementGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.ProximityPlacementGroup.ProximityPlacementGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.proximityPlacementGroup: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ProximityPlacementGroupState<_, _, _>) : azurerm.ProximityPlacementGroup.ProximityPlacementGroup =
            Unchecked.defaultof<azurerm.ProximityPlacementGroup.ProximityPlacementGroup>
