namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermProximityPlacementGroupState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermProximityPlacementGroup.DataAzurermProximityPlacementGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/proximity_placement_group">azurerm_proximity_placement_group</a>.
    /// </summary>
    type DataAzurermProximityPlacementGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermProximityPlacementGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermProximityPlacementGroupState<Missing, Missing>)

        member _.Zero(()) : DataAzurermProximityPlacementGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermProximityPlacementGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/proximity_placement_group#name-1">DataAzurermProximityPlacementGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermProximityPlacementGroupState<Missing, 'ResourceGroupName>, value: string) : DataAzurermProximityPlacementGroupState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermProximityPlacementGroupState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/proximity_placement_group#resource_group_name-1">DataAzurermProximityPlacementGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermProximityPlacementGroupState<'Name, Missing>, value: string) : DataAzurermProximityPlacementGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermProximityPlacementGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/proximity_placement_group#id-1">DataAzurermProximityPlacementGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermProximityPlacementGroupState<'Name, 'ResourceGroupName>, value: string) : DataAzurermProximityPlacementGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermProximityPlacementGroupState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/proximity_placement_group#timeouts-1">DataAzurermProximityPlacementGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermProximityPlacementGroupState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermProximityPlacementGroup.DataAzurermProximityPlacementGroupTimeouts) : DataAzurermProximityPlacementGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermProximityPlacementGroupState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermProximityPlacementGroupState<Present, Present>) : azurerm.DataAzurermProximityPlacementGroup.DataAzurermProximityPlacementGroup =
            let config = azurerm.DataAzurermProximityPlacementGroup.DataAzurermProximityPlacementGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermProximityPlacementGroup.DataAzurermProximityPlacementGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermProximityPlacementGroup: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermProximityPlacementGroupState<_, _>) : azurerm.DataAzurermProximityPlacementGroup.DataAzurermProximityPlacementGroup =
            Unchecked.defaultof<azurerm.DataAzurermProximityPlacementGroup.DataAzurermProximityPlacementGroup>
