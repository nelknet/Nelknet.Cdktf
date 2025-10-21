namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CapacityReservationGroupState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CapacityReservationGroup.CapacityReservationGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation_group">azurerm_capacity_reservation_group</a>.
    /// </summary>
    type CapacityReservationGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : CapacityReservationGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CapacityReservationGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : CapacityReservationGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CapacityReservationGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation_group#location-1">CapacityReservationGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: CapacityReservationGroupState<Missing, 'Name, 'ResourceGroupName>, value: string) : CapacityReservationGroupState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : CapacityReservationGroupState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation_group#name-1">CapacityReservationGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CapacityReservationGroupState<'Location, Missing, 'ResourceGroupName>, value: string) : CapacityReservationGroupState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CapacityReservationGroupState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation_group#resource_group_name-1">CapacityReservationGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CapacityReservationGroupState<'Location, 'Name, Missing>, value: string) : CapacityReservationGroupState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CapacityReservationGroupState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation_group#id-1">CapacityReservationGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CapacityReservationGroupState<'Location, 'Name, 'ResourceGroupName>, value: string) : CapacityReservationGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CapacityReservationGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation_group#tags-1">CapacityReservationGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CapacityReservationGroupState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : CapacityReservationGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CapacityReservationGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation_group#timeouts-1">CapacityReservationGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CapacityReservationGroupState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.CapacityReservationGroup.CapacityReservationGroupTimeouts) : CapacityReservationGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CapacityReservationGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation_group#zones-1">CapacityReservationGroup#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: CapacityReservationGroupState<'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : CapacityReservationGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : CapacityReservationGroupState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: CapacityReservationGroupState<Present, Present, Present>) : azurerm.CapacityReservationGroup.CapacityReservationGroup =
            let config = azurerm.CapacityReservationGroup.CapacityReservationGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.CapacityReservationGroup.CapacityReservationGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.capacityReservationGroup: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CapacityReservationGroupState<_, _, _>) : azurerm.CapacityReservationGroup.CapacityReservationGroup =
            Unchecked.defaultof<azurerm.CapacityReservationGroup.CapacityReservationGroup>
