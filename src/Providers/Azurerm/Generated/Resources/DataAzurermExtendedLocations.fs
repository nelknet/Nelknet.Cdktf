namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermExtendedLocationsState<'Location> = { assignments: ResizeArray<azurerm.DataAzurermExtendedLocations.DataAzurermExtendedLocationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/extended_locations">azurerm_extended_locations</a>.
    /// </summary>
    type DataAzurermExtendedLocationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermExtendedLocationsState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermExtendedLocationsState<Missing>)

        member _.Zero(()) : DataAzurermExtendedLocationsState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermExtendedLocationsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/extended_locations#location-1">DataAzurermExtendedLocations#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataAzurermExtendedLocationsState<Missing>, value: string) : DataAzurermExtendedLocationsState<Present> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataAzurermExtendedLocationsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/extended_locations#id-1">DataAzurermExtendedLocations#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermExtendedLocationsState<'Location>, value: string) : DataAzurermExtendedLocationsState<'Location> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermExtendedLocationsState<'Location>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/extended_locations#timeouts-1">DataAzurermExtendedLocations#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermExtendedLocationsState<'Location>, value: azurerm.DataAzurermExtendedLocations.DataAzurermExtendedLocationsTimeouts) : DataAzurermExtendedLocationsState<'Location> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermExtendedLocationsState<'Location>

        member _.Run(state: DataAzurermExtendedLocationsState<Present>) : azurerm.DataAzurermExtendedLocations.DataAzurermExtendedLocations =
            let config = azurerm.DataAzurermExtendedLocations.DataAzurermExtendedLocationsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermExtendedLocations.DataAzurermExtendedLocations(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermExtendedLocations: missing required arguments. Must call: location.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermExtendedLocationsState<_>) : azurerm.DataAzurermExtendedLocations.DataAzurermExtendedLocations =
            Unchecked.defaultof<azurerm.DataAzurermExtendedLocations.DataAzurermExtendedLocations>
