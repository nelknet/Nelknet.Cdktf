namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermManagedApiState<'Location, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermManagedApi.DataAzurermManagedApiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_api">azurerm_managed_api</a>.
    /// </summary>
    type DataAzurermManagedApiBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermManagedApiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermManagedApiState<Missing, Missing>)

        member _.Zero(()) : DataAzurermManagedApiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermManagedApiState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_api#location-1">DataAzurermManagedApi#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataAzurermManagedApiState<Missing, 'Name>, value: string) : DataAzurermManagedApiState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataAzurermManagedApiState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_api#name-1">DataAzurermManagedApi#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermManagedApiState<'Location, Missing>, value: string) : DataAzurermManagedApiState<'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermManagedApiState<'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_api#id-1">DataAzurermManagedApi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermManagedApiState<'Location, 'Name>, value: string) : DataAzurermManagedApiState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermManagedApiState<'Location, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_api#timeouts-1">DataAzurermManagedApi#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermManagedApiState<'Location, 'Name>, value: azurerm.DataAzurermManagedApi.DataAzurermManagedApiTimeouts) : DataAzurermManagedApiState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermManagedApiState<'Location, 'Name>

        member _.Run(state: DataAzurermManagedApiState<Present, Present>) : azurerm.DataAzurermManagedApi.DataAzurermManagedApi =
            let config = azurerm.DataAzurermManagedApi.DataAzurermManagedApiConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermManagedApi.DataAzurermManagedApi(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermManagedApi: missing required arguments. Must call: location, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermManagedApiState<_, _>) : azurerm.DataAzurermManagedApi.DataAzurermManagedApi =
            Unchecked.defaultof<azurerm.DataAzurermManagedApi.DataAzurermManagedApi>
