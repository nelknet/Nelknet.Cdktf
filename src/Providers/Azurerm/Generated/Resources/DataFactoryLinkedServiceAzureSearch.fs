namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceAzureSearch.DataFactoryLinkedServiceAzureSearchConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_search">azurerm_data_factory_linked_service_azure_search</a>.
    /// </summary>
    type DataFactoryLinkedServiceAzureSearchBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceAzureSearchState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureSearchState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceAzureSearchState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureSearchState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_search#data_factory_id-1">DataFactoryLinkedServiceAzureSearch#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceAzureSearchState<Missing, 'Name, 'SearchServiceKey, 'Url>, value: string) : DataFactoryLinkedServiceAzureSearchState<Present, 'Name, 'SearchServiceKey, 'Url> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureSearchState<Present, 'Name, 'SearchServiceKey, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_search#name-1">DataFactoryLinkedServiceAzureSearch#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, Missing, 'SearchServiceKey, 'Url>, value: string) : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, Present, 'SearchServiceKey, 'Url> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, Present, 'SearchServiceKey, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_search#search_service_key-1">DataFactoryLinkedServiceAzureSearch#search_service_key</a>.
        /// </summary>
        [<CustomOperation "search_service_key">]
        member _.SearchServiceKey(state: DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, Missing, 'Url>, value: string) : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, Present, 'Url> =
            state.assignments.Add(fun config -> config.SearchServiceKey <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, Present, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_search#url-1">DataFactoryLinkedServiceAzureSearch#url</a>.
        /// </summary>
        [<CustomOperation "url">]
        member _.Url(state: DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, Missing>, value: string) : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, Present> =
            state.assignments.Add(fun config -> config.Url <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_search#additional_properties-1">DataFactoryLinkedServiceAzureSearch#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>, value: seq<string * string>) : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_search#annotations-1">DataFactoryLinkedServiceAzureSearch#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>, value: seq<string>) : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_search#description-1">DataFactoryLinkedServiceAzureSearch#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>, value: string) : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_search#id-1">DataFactoryLinkedServiceAzureSearch#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>, value: string) : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_search#integration_runtime_name-1">DataFactoryLinkedServiceAzureSearch#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>, value: string) : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_search#parameters-1">DataFactoryLinkedServiceAzureSearch#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>, value: seq<string * string>) : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_search#timeouts-1">DataFactoryLinkedServiceAzureSearch#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>, value: azurerm.DataFactoryLinkedServiceAzureSearch.DataFactoryLinkedServiceAzureSearchTimeouts) : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceAzureSearchState<'DataFactoryId, 'Name, 'SearchServiceKey, 'Url>

        member _.Run(state: DataFactoryLinkedServiceAzureSearchState<Present, Present, Present, Present>) : azurerm.DataFactoryLinkedServiceAzureSearch.DataFactoryLinkedServiceAzureSearch =
            let config = azurerm.DataFactoryLinkedServiceAzureSearch.DataFactoryLinkedServiceAzureSearchConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceAzureSearch.DataFactoryLinkedServiceAzureSearch(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceAzureSearch: missing required arguments. Must call: data_factory_id, name, search_service_key, url.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceAzureSearchState<_, _, _, _>) : azurerm.DataFactoryLinkedServiceAzureSearch.DataFactoryLinkedServiceAzureSearch =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceAzureSearch.DataFactoryLinkedServiceAzureSearch>
