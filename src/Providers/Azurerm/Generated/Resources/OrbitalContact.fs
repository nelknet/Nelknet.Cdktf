namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId> = { assignments: ResizeArray<azurerm.OrbitalContact.OrbitalContactConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact">azurerm_orbital_contact</a>.
    /// </summary>
    type OrbitalContactBuilder(logicalId: string) =
        member _.Yield(_: unit) : OrbitalContactState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OrbitalContactState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : OrbitalContactState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OrbitalContactState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact#contact_profile_id-1">OrbitalContact#contact_profile_id</a>.
        /// </summary>
        [<CustomOperation "contact_profile_id">]
        member _.ContactProfileId(state: OrbitalContactState<Missing, 'GroundStationName, 'Name, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId>, value: string) : OrbitalContactState<Present, 'GroundStationName, 'Name, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId> =
            state.assignments.Add(fun config -> config.ContactProfileId <- value)
            ({ assignments = state.assignments } : OrbitalContactState<Present, 'GroundStationName, 'Name, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact#ground_station_name-1">OrbitalContact#ground_station_name</a>.
        /// </summary>
        [<CustomOperation "ground_station_name">]
        member _.GroundStationName(state: OrbitalContactState<'ContactProfileId, Missing, 'Name, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId>, value: string) : OrbitalContactState<'ContactProfileId, Present, 'Name, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId> =
            state.assignments.Add(fun config -> config.GroundStationName <- value)
            ({ assignments = state.assignments } : OrbitalContactState<'ContactProfileId, Present, 'Name, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact#name-1">OrbitalContact#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OrbitalContactState<'ContactProfileId, 'GroundStationName, Missing, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId>, value: string) : OrbitalContactState<'ContactProfileId, 'GroundStationName, Present, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OrbitalContactState<'ContactProfileId, 'GroundStationName, Present, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact#reservation_end_time-1">OrbitalContact#reservation_end_time</a>.
        /// </summary>
        [<CustomOperation "reservation_end_time">]
        member _.ReservationEndTime(state: OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, Missing, 'ReservationStartTime, 'SpacecraftId>, value: string) : OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, Present, 'ReservationStartTime, 'SpacecraftId> =
            state.assignments.Add(fun config -> config.ReservationEndTime <- value)
            ({ assignments = state.assignments } : OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, Present, 'ReservationStartTime, 'SpacecraftId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact#reservation_start_time-1">OrbitalContact#reservation_start_time</a>.
        /// </summary>
        [<CustomOperation "reservation_start_time">]
        member _.ReservationStartTime(state: OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, 'ReservationEndTime, Missing, 'SpacecraftId>, value: string) : OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, 'ReservationEndTime, Present, 'SpacecraftId> =
            state.assignments.Add(fun config -> config.ReservationStartTime <- value)
            ({ assignments = state.assignments } : OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, 'ReservationEndTime, Present, 'SpacecraftId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact#spacecraft_id-1">OrbitalContact#spacecraft_id</a>.
        /// </summary>
        [<CustomOperation "spacecraft_id">]
        member _.SpacecraftId(state: OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, 'ReservationEndTime, 'ReservationStartTime, Missing>, value: string) : OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, 'ReservationEndTime, 'ReservationStartTime, Present> =
            state.assignments.Add(fun config -> config.SpacecraftId <- value)
            ({ assignments = state.assignments } : OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, 'ReservationEndTime, 'ReservationStartTime, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact#id-1">OrbitalContact#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId>, value: string) : OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact#timeouts-1">OrbitalContact#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId>, value: azurerm.OrbitalContact.OrbitalContactTimeouts) : OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OrbitalContactState<'ContactProfileId, 'GroundStationName, 'Name, 'ReservationEndTime, 'ReservationStartTime, 'SpacecraftId>

        member _.Run(state: OrbitalContactState<Present, Present, Present, Present, Present, Present>) : azurerm.OrbitalContact.OrbitalContact =
            let config = azurerm.OrbitalContact.OrbitalContactConfig()
            for setter in state.assignments do
                setter config
            azurerm.OrbitalContact.OrbitalContact(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.orbitalContact: missing required arguments. Must call: contact_profile_id, ground_station_name, name, reservation_end_time, reservation_start_time, spacecraft_id.", 9999, IsError = true)>]
        member _.Run(_: OrbitalContactState<_, _, _, _, _, _>) : azurerm.OrbitalContact.OrbitalContact =
            Unchecked.defaultof<azurerm.OrbitalContact.OrbitalContact>
