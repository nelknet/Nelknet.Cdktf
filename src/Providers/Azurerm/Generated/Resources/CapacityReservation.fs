namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CapacityReservationState<'CapacityReservationGroupId, 'Name, 'Sku> = { assignments: ResizeArray<azurerm.CapacityReservation.CapacityReservationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation">azurerm_capacity_reservation</a>.
    /// </summary>
    type CapacityReservationBuilder(logicalId: string) =
        member _.Yield(_: unit) : CapacityReservationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CapacityReservationState<Missing, Missing, Missing>)

        member _.Zero(()) : CapacityReservationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CapacityReservationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation#capacity_reservation_group_id-1">CapacityReservation#capacity_reservation_group_id</a>.
        /// </summary>
        [<CustomOperation "capacity_reservation_group_id">]
        member _.CapacityReservationGroupId(state: CapacityReservationState<Missing, 'Name, 'Sku>, value: string) : CapacityReservationState<Present, 'Name, 'Sku> =
            state.assignments.Add(fun config -> config.CapacityReservationGroupId <- value)
            ({ assignments = state.assignments } : CapacityReservationState<Present, 'Name, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation#name-1">CapacityReservation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CapacityReservationState<'CapacityReservationGroupId, Missing, 'Sku>, value: string) : CapacityReservationState<'CapacityReservationGroupId, Present, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CapacityReservationState<'CapacityReservationGroupId, Present, 'Sku>)

        /// <summary>
        /// sku block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation#sku-1">CapacityReservation#sku</a>
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: CapacityReservationState<'CapacityReservationGroupId, 'Name, Missing>, value: azurerm.CapacityReservation.CapacityReservationSku) : CapacityReservationState<'CapacityReservationGroupId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : CapacityReservationState<'CapacityReservationGroupId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation#id-1">CapacityReservation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CapacityReservationState<'CapacityReservationGroupId, 'Name, 'Sku>, value: string) : CapacityReservationState<'CapacityReservationGroupId, 'Name, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CapacityReservationState<'CapacityReservationGroupId, 'Name, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation#tags-1">CapacityReservation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CapacityReservationState<'CapacityReservationGroupId, 'Name, 'Sku>, value: seq<string * string>) : CapacityReservationState<'CapacityReservationGroupId, 'Name, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CapacityReservationState<'CapacityReservationGroupId, 'Name, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation#timeouts-1">CapacityReservation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CapacityReservationState<'CapacityReservationGroupId, 'Name, 'Sku>, value: azurerm.CapacityReservation.CapacityReservationTimeouts) : CapacityReservationState<'CapacityReservationGroupId, 'Name, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CapacityReservationState<'CapacityReservationGroupId, 'Name, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/capacity_reservation#zone-1">CapacityReservation#zone</a>.
        /// </summary>
        [<CustomOperation "zone">]
        member _.Zone(state: CapacityReservationState<'CapacityReservationGroupId, 'Name, 'Sku>, value: string) : CapacityReservationState<'CapacityReservationGroupId, 'Name, 'Sku> =
            state.assignments.Add(fun config -> config.Zone <- value)
            state : CapacityReservationState<'CapacityReservationGroupId, 'Name, 'Sku>

        member _.Run(state: CapacityReservationState<Present, Present, Present>) : azurerm.CapacityReservation.CapacityReservation =
            let config = azurerm.CapacityReservation.CapacityReservationConfig()
            for setter in state.assignments do
                setter config
            azurerm.CapacityReservation.CapacityReservation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.capacityReservation: missing required arguments. Must call: capacity_reservation_group_id, name, sku.", 9999, IsError = true)>]
        member _.Run(_: CapacityReservationState<_, _, _>) : azurerm.CapacityReservation.CapacityReservation =
            Unchecked.defaultof<azurerm.CapacityReservation.CapacityReservation>
