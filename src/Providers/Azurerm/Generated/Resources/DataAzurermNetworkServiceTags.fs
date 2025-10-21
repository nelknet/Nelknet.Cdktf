namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetworkServiceTagsState<'Location, 'Service> = { assignments: ResizeArray<azurerm.DataAzurermNetworkServiceTags.DataAzurermNetworkServiceTagsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_service_tags">azurerm_network_service_tags</a>.
    /// </summary>
    type DataAzurermNetworkServiceTagsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetworkServiceTagsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkServiceTagsState<Missing, Missing>)

        member _.Zero(()) : DataAzurermNetworkServiceTagsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkServiceTagsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_service_tags#location-1">DataAzurermNetworkServiceTags#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataAzurermNetworkServiceTagsState<Missing, 'Service>, value: string) : DataAzurermNetworkServiceTagsState<Present, 'Service> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkServiceTagsState<Present, 'Service>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_service_tags#service-1">DataAzurermNetworkServiceTags#service</a>.
        /// </summary>
        [<CustomOperation "service">]
        member _.Service(state: DataAzurermNetworkServiceTagsState<'Location, Missing>, value: string) : DataAzurermNetworkServiceTagsState<'Location, Present> =
            state.assignments.Add(fun config -> config.Service <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkServiceTagsState<'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_service_tags#id-1">DataAzurermNetworkServiceTags#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetworkServiceTagsState<'Location, 'Service>, value: string) : DataAzurermNetworkServiceTagsState<'Location, 'Service> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetworkServiceTagsState<'Location, 'Service>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_service_tags#location_filter-1">DataAzurermNetworkServiceTags#location_filter</a>.
        /// </summary>
        [<CustomOperation "location_filter">]
        member _.LocationFilter(state: DataAzurermNetworkServiceTagsState<'Location, 'Service>, value: string) : DataAzurermNetworkServiceTagsState<'Location, 'Service> =
            state.assignments.Add(fun config -> config.LocationFilter <- value)
            state : DataAzurermNetworkServiceTagsState<'Location, 'Service>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_service_tags#timeouts-1">DataAzurermNetworkServiceTags#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetworkServiceTagsState<'Location, 'Service>, value: azurerm.DataAzurermNetworkServiceTags.DataAzurermNetworkServiceTagsTimeouts) : DataAzurermNetworkServiceTagsState<'Location, 'Service> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetworkServiceTagsState<'Location, 'Service>

        member _.Run(state: DataAzurermNetworkServiceTagsState<Present, Present>) : azurerm.DataAzurermNetworkServiceTags.DataAzurermNetworkServiceTags =
            let config = azurerm.DataAzurermNetworkServiceTags.DataAzurermNetworkServiceTagsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetworkServiceTags.DataAzurermNetworkServiceTags(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetworkServiceTags: missing required arguments. Must call: location, service.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetworkServiceTagsState<_, _>) : azurerm.DataAzurermNetworkServiceTags.DataAzurermNetworkServiceTags =
            Unchecked.defaultof<azurerm.DataAzurermNetworkServiceTags.DataAzurermNetworkServiceTags>
