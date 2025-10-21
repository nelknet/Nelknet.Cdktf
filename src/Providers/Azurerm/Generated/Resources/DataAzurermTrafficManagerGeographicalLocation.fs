namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermTrafficManagerGeographicalLocationState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermTrafficManagerGeographicalLocation.DataAzurermTrafficManagerGeographicalLocationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_geographical_location">azurerm_traffic_manager_geographical_location</a>.
    /// </summary>
    type DataAzurermTrafficManagerGeographicalLocationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermTrafficManagerGeographicalLocationState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermTrafficManagerGeographicalLocationState<Missing>)

        member _.Zero(()) : DataAzurermTrafficManagerGeographicalLocationState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermTrafficManagerGeographicalLocationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_geographical_location#name-1">DataAzurermTrafficManagerGeographicalLocation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermTrafficManagerGeographicalLocationState<Missing>, value: string) : DataAzurermTrafficManagerGeographicalLocationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermTrafficManagerGeographicalLocationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_geographical_location#id-1">DataAzurermTrafficManagerGeographicalLocation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermTrafficManagerGeographicalLocationState<'Name>, value: string) : DataAzurermTrafficManagerGeographicalLocationState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermTrafficManagerGeographicalLocationState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_geographical_location#timeouts-1">DataAzurermTrafficManagerGeographicalLocation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermTrafficManagerGeographicalLocationState<'Name>, value: azurerm.DataAzurermTrafficManagerGeographicalLocation.DataAzurermTrafficManagerGeographicalLocationTimeouts) : DataAzurermTrafficManagerGeographicalLocationState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermTrafficManagerGeographicalLocationState<'Name>

        member _.Run(state: DataAzurermTrafficManagerGeographicalLocationState<Present>) : azurerm.DataAzurermTrafficManagerGeographicalLocation.DataAzurermTrafficManagerGeographicalLocation =
            let config = azurerm.DataAzurermTrafficManagerGeographicalLocation.DataAzurermTrafficManagerGeographicalLocationConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermTrafficManagerGeographicalLocation.DataAzurermTrafficManagerGeographicalLocation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermTrafficManagerGeographicalLocation: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermTrafficManagerGeographicalLocationState<_>) : azurerm.DataAzurermTrafficManagerGeographicalLocation.DataAzurermTrafficManagerGeographicalLocation =
            Unchecked.defaultof<azurerm.DataAzurermTrafficManagerGeographicalLocation.DataAzurermTrafficManagerGeographicalLocation>
