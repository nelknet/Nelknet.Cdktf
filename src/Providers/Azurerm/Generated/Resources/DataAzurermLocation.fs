namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermLocationState<'Location> = { assignments: ResizeArray<azurerm.DataAzurermLocation.DataAzurermLocationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/location">azurerm_location</a>.
    /// </summary>
    type DataAzurermLocationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermLocationState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLocationState<Missing>)

        member _.Zero(()) : DataAzurermLocationState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLocationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/location#location-1">DataAzurermLocation#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataAzurermLocationState<Missing>, value: string) : DataAzurermLocationState<Present> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataAzurermLocationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/location#id-1">DataAzurermLocation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermLocationState<'Location>, value: string) : DataAzurermLocationState<'Location> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermLocationState<'Location>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/location#timeouts-1">DataAzurermLocation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermLocationState<'Location>, value: azurerm.DataAzurermLocation.DataAzurermLocationTimeouts) : DataAzurermLocationState<'Location> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermLocationState<'Location>

        member _.Run(state: DataAzurermLocationState<Present>) : azurerm.DataAzurermLocation.DataAzurermLocation =
            let config = azurerm.DataAzurermLocation.DataAzurermLocationConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermLocation.DataAzurermLocation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermLocation: missing required arguments. Must call: location.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermLocationState<_>) : azurerm.DataAzurermLocation.DataAzurermLocation =
            Unchecked.defaultof<azurerm.DataAzurermLocation.DataAzurermLocation>
