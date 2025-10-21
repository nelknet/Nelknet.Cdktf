namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryDatasetJson.DataFactoryDatasetJsonConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json">azurerm_data_factory_dataset_json</a>.
    /// </summary>
    type DataFactoryDatasetJsonBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryDatasetJsonState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetJsonState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryDatasetJsonState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetJsonState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#data_factory_id-1">DataFactoryDatasetJson#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryDatasetJsonState<Missing, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetJsonState<Present, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetJsonState<Present, 'LinkedServiceName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#linked_service_name-1">DataFactoryDatasetJson#linked_service_name</a>.
        /// </summary>
        [<CustomOperation "linked_service_name">]
        member _.LinkedServiceName(state: DataFactoryDatasetJsonState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryDatasetJsonState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LinkedServiceName <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetJsonState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#name-1">DataFactoryDatasetJson#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, Missing>, value: string) : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#additional_properties-1">DataFactoryDatasetJson#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#annotations-1">DataFactoryDatasetJson#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string>) : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// azure_blob_storage_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#azure_blob_storage_location-1">DataFactoryDatasetJson#azure_blob_storage_location</a>
        /// </summary>
        [<CustomOperation "azure_blob_storage_location">]
        member _.AzureBlobStorageLocation(state: DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetJson.DataFactoryDatasetJsonAzureBlobStorageLocation) : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AzureBlobStorageLocation <- value)
            state : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#description-1">DataFactoryDatasetJson#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#encoding-1">DataFactoryDatasetJson#encoding</a>.
        /// </summary>
        [<CustomOperation "encoding">]
        member _.Encoding(state: DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Encoding <- value)
            state : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#folder-1">DataFactoryDatasetJson#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// http_server_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#http_server_location-1">DataFactoryDatasetJson#http_server_location</a>
        /// </summary>
        [<CustomOperation "http_server_location">]
        member _.HttpServerLocation(state: DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetJson.DataFactoryDatasetJsonHttpServerLocation) : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.HttpServerLocation <- value)
            state : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#id-1">DataFactoryDatasetJson#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#parameters-1">DataFactoryDatasetJson#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// schema_column block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#schema_column-1">DataFactoryDatasetJson#schema_column</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDatasetJson.DataFactoryDatasetJsonSchemaColumn[]
        /// </summary>
        [<CustomOperation "schema_column">]
        member _.SchemaColumn(state: DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.SchemaColumn <- value)
            state : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_json#timeouts-1">DataFactoryDatasetJson#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetJson.DataFactoryDatasetJsonTimeouts) : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryDatasetJsonState<'DataFactoryId, 'LinkedServiceName, 'Name>

        member _.Run(state: DataFactoryDatasetJsonState<Present, Present, Present>) : azurerm.DataFactoryDatasetJson.DataFactoryDatasetJson =
            let config = azurerm.DataFactoryDatasetJson.DataFactoryDatasetJsonConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryDatasetJson.DataFactoryDatasetJson(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryDatasetJson: missing required arguments. Must call: data_factory_id, linked_service_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryDatasetJsonState<_, _, _>) : azurerm.DataFactoryDatasetJson.DataFactoryDatasetJson =
            Unchecked.defaultof<azurerm.DataFactoryDatasetJson.DataFactoryDatasetJson>
