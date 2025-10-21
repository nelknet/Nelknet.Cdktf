namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet">azurerm_data_factory_dataset_parquet</a>.
    /// </summary>
    type DataFactoryDatasetParquetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryDatasetParquetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetParquetState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryDatasetParquetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetParquetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#data_factory_id-1">DataFactoryDatasetParquet#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryDatasetParquetState<Missing, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetParquetState<Present, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetParquetState<Present, 'LinkedServiceName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#linked_service_name-1">DataFactoryDatasetParquet#linked_service_name</a>.
        /// </summary>
        [<CustomOperation "linked_service_name">]
        member _.LinkedServiceName(state: DataFactoryDatasetParquetState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryDatasetParquetState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LinkedServiceName <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetParquetState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#name-1">DataFactoryDatasetParquet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, Missing>, value: string) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#additional_properties-1">DataFactoryDatasetParquet#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#annotations-1">DataFactoryDatasetParquet#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string>) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// azure_blob_fs_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#azure_blob_fs_location-1">DataFactoryDatasetParquet#azure_blob_fs_location</a>
        /// </summary>
        [<CustomOperation "azure_blob_fs_location">]
        member _.AzureBlobFsLocation(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetAzureBlobFsLocation) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AzureBlobFsLocation <- value)
            state : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// azure_blob_storage_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#azure_blob_storage_location-1">DataFactoryDatasetParquet#azure_blob_storage_location</a>
        /// </summary>
        [<CustomOperation "azure_blob_storage_location">]
        member _.AzureBlobStorageLocation(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetAzureBlobStorageLocation) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AzureBlobStorageLocation <- value)
            state : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#compression_codec-1">DataFactoryDatasetParquet#compression_codec</a>.
        /// </summary>
        [<CustomOperation "compression_codec">]
        member _.CompressionCodec(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.CompressionCodec <- value)
            state : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#compression_level-1">DataFactoryDatasetParquet#compression_level</a>.
        /// </summary>
        [<CustomOperation "compression_level">]
        member _.CompressionLevel(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.CompressionLevel <- value)
            state : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#description-1">DataFactoryDatasetParquet#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#folder-1">DataFactoryDatasetParquet#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// http_server_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#http_server_location-1">DataFactoryDatasetParquet#http_server_location</a>
        /// </summary>
        [<CustomOperation "http_server_location">]
        member _.HttpServerLocation(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetHttpServerLocation) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.HttpServerLocation <- value)
            state : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#id-1">DataFactoryDatasetParquet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#parameters-1">DataFactoryDatasetParquet#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// schema_column block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#schema_column-1">DataFactoryDatasetParquet#schema_column</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetSchemaColumn[]
        /// </summary>
        [<CustomOperation "schema_column">]
        member _.SchemaColumn(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.SchemaColumn <- value)
            state : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#timeouts-1">DataFactoryDatasetParquet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetTimeouts) : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryDatasetParquetState<'DataFactoryId, 'LinkedServiceName, 'Name>

        member _.Run(state: DataFactoryDatasetParquetState<Present, Present, Present>) : azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquet =
            let config = azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryDatasetParquet: missing required arguments. Must call: data_factory_id, linked_service_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryDatasetParquetState<_, _, _>) : azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquet =
            Unchecked.defaultof<azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquet>
