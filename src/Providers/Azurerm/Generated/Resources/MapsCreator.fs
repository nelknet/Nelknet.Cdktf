namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MapsCreatorState<'Location, 'MapsAccountId, 'Name, 'StorageUnits> = { assignments: ResizeArray<azurerm.MapsCreator.MapsCreatorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_creator">azurerm_maps_creator</a>.
    /// </summary>
    type MapsCreatorBuilder(logicalId: string) =
        member _.Yield(_: unit) : MapsCreatorState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MapsCreatorState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MapsCreatorState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MapsCreatorState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_creator#location-1">MapsCreator#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MapsCreatorState<Missing, 'MapsAccountId, 'Name, 'StorageUnits>, value: string) : MapsCreatorState<Present, 'MapsAccountId, 'Name, 'StorageUnits> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MapsCreatorState<Present, 'MapsAccountId, 'Name, 'StorageUnits>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_creator#maps_account_id-1">MapsCreator#maps_account_id</a>.
        /// </summary>
        [<CustomOperation "maps_account_id">]
        member _.MapsAccountId(state: MapsCreatorState<'Location, Missing, 'Name, 'StorageUnits>, value: string) : MapsCreatorState<'Location, Present, 'Name, 'StorageUnits> =
            state.assignments.Add(fun config -> config.MapsAccountId <- value)
            ({ assignments = state.assignments } : MapsCreatorState<'Location, Present, 'Name, 'StorageUnits>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_creator#name-1">MapsCreator#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MapsCreatorState<'Location, 'MapsAccountId, Missing, 'StorageUnits>, value: string) : MapsCreatorState<'Location, 'MapsAccountId, Present, 'StorageUnits> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MapsCreatorState<'Location, 'MapsAccountId, Present, 'StorageUnits>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_creator#storage_units-1">MapsCreator#storage_units</a>.
        /// </summary>
        [<CustomOperation "storage_units">]
        member _.StorageUnits(state: MapsCreatorState<'Location, 'MapsAccountId, 'Name, Missing>, value: double) : MapsCreatorState<'Location, 'MapsAccountId, 'Name, Present> =
            state.assignments.Add(fun config -> config.StorageUnits <- value)
            ({ assignments = state.assignments } : MapsCreatorState<'Location, 'MapsAccountId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_creator#id-1">MapsCreator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MapsCreatorState<'Location, 'MapsAccountId, 'Name, 'StorageUnits>, value: string) : MapsCreatorState<'Location, 'MapsAccountId, 'Name, 'StorageUnits> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MapsCreatorState<'Location, 'MapsAccountId, 'Name, 'StorageUnits>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_creator#tags-1">MapsCreator#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MapsCreatorState<'Location, 'MapsAccountId, 'Name, 'StorageUnits>, value: seq<string * string>) : MapsCreatorState<'Location, 'MapsAccountId, 'Name, 'StorageUnits> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MapsCreatorState<'Location, 'MapsAccountId, 'Name, 'StorageUnits>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_creator#timeouts-1">MapsCreator#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MapsCreatorState<'Location, 'MapsAccountId, 'Name, 'StorageUnits>, value: azurerm.MapsCreator.MapsCreatorTimeouts) : MapsCreatorState<'Location, 'MapsAccountId, 'Name, 'StorageUnits> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MapsCreatorState<'Location, 'MapsAccountId, 'Name, 'StorageUnits>

        member _.Run(state: MapsCreatorState<Present, Present, Present, Present>) : azurerm.MapsCreator.MapsCreator =
            let config = azurerm.MapsCreator.MapsCreatorConfig()
            for setter in state.assignments do
                setter config
            azurerm.MapsCreator.MapsCreator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mapsCreator: missing required arguments. Must call: location, maps_account_id, name, storage_units.", 9999, IsError = true)>]
        member _.Run(_: MapsCreatorState<_, _, _, _>) : azurerm.MapsCreator.MapsCreator =
            Unchecked.defaultof<azurerm.MapsCreator.MapsCreator>
