namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedTextConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text">azurerm_data_factory_dataset_delimited_text</a>.
    /// </summary>
    type DataFactoryDatasetDelimitedTextBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryDatasetDelimitedTextState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetDelimitedTextState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryDatasetDelimitedTextState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetDelimitedTextState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#data_factory_id-1">DataFactoryDatasetDelimitedText#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryDatasetDelimitedTextState<Missing, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetDelimitedTextState<Present, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetDelimitedTextState<Present, 'LinkedServiceName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#linked_service_name-1">DataFactoryDatasetDelimitedText#linked_service_name</a>.
        /// </summary>
        [<CustomOperation "linked_service_name">]
        member _.LinkedServiceName(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LinkedServiceName <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetDelimitedTextState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#name-1">DataFactoryDatasetDelimitedText#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, Missing>, value: string) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#additional_properties-1">DataFactoryDatasetDelimitedText#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#annotations-1">DataFactoryDatasetDelimitedText#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string>) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// azure_blob_fs_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#azure_blob_fs_location-1">DataFactoryDatasetDelimitedText#azure_blob_fs_location</a>
        /// </summary>
        [<CustomOperation "azure_blob_fs_location">]
        member _.AzureBlobFsLocation(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedTextAzureBlobFsLocation) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AzureBlobFsLocation <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// azure_blob_storage_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#azure_blob_storage_location-1">DataFactoryDatasetDelimitedText#azure_blob_storage_location</a>
        /// </summary>
        [<CustomOperation "azure_blob_storage_location">]
        member _.AzureBlobStorageLocation(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedTextAzureBlobStorageLocation) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AzureBlobStorageLocation <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#column_delimiter-1">DataFactoryDatasetDelimitedText#column_delimiter</a>.
        /// </summary>
        [<CustomOperation "column_delimiter">]
        member _.ColumnDelimiter(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.ColumnDelimiter <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#compression_codec-1">DataFactoryDatasetDelimitedText#compression_codec</a>.
        /// </summary>
        [<CustomOperation "compression_codec">]
        member _.CompressionCodec(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.CompressionCodec <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#compression_level-1">DataFactoryDatasetDelimitedText#compression_level</a>.
        /// </summary>
        [<CustomOperation "compression_level">]
        member _.CompressionLevel(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.CompressionLevel <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#description-1">DataFactoryDatasetDelimitedText#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#encoding-1">DataFactoryDatasetDelimitedText#encoding</a>.
        /// </summary>
        [<CustomOperation "encoding">]
        member _.Encoding(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Encoding <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#escape_character-1">DataFactoryDatasetDelimitedText#escape_character</a>.
        /// </summary>
        [<CustomOperation "escape_character">]
        member _.EscapeCharacter(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.EscapeCharacter <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#first_row_as_header-1">DataFactoryDatasetDelimitedText#first_row_as_header</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "first_row_as_header">]
        member _.FirstRowAsHeader(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: bool) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.FirstRowAsHeader <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#first_row_as_header-1">DataFactoryDatasetDelimitedText#first_row_as_header</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "first_row_as_header">]
        member _.FirstRowAsHeader(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.FirstRowAsHeader <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#folder-1">DataFactoryDatasetDelimitedText#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// http_server_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#http_server_location-1">DataFactoryDatasetDelimitedText#http_server_location</a>
        /// </summary>
        [<CustomOperation "http_server_location">]
        member _.HttpServerLocation(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedTextHttpServerLocation) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.HttpServerLocation <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#id-1">DataFactoryDatasetDelimitedText#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#null_value-1">DataFactoryDatasetDelimitedText#null_value</a>.
        /// </summary>
        [<CustomOperation "null_value">]
        member _.NullValue(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.NullValue <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#parameters-1">DataFactoryDatasetDelimitedText#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#quote_character-1">DataFactoryDatasetDelimitedText#quote_character</a>.
        /// </summary>
        [<CustomOperation "quote_character">]
        member _.QuoteCharacter(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.QuoteCharacter <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#row_delimiter-1">DataFactoryDatasetDelimitedText#row_delimiter</a>.
        /// </summary>
        [<CustomOperation "row_delimiter">]
        member _.RowDelimiter(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.RowDelimiter <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// schema_column block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#schema_column-1">DataFactoryDatasetDelimitedText#schema_column</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedTextSchemaColumn[]
        /// </summary>
        [<CustomOperation "schema_column">]
        member _.SchemaColumn(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.SchemaColumn <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_delimited_text#timeouts-1">DataFactoryDatasetDelimitedText#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedTextTimeouts) : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryDatasetDelimitedTextState<'DataFactoryId, 'LinkedServiceName, 'Name>

        member _.Run(state: DataFactoryDatasetDelimitedTextState<Present, Present, Present>) : azurerm.DataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedText =
            let config = azurerm.DataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedTextConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedText(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryDatasetDelimitedText: missing required arguments. Must call: data_factory_id, linked_service_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryDatasetDelimitedTextState<_, _, _>) : azurerm.DataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedText =
            Unchecked.defaultof<azurerm.DataFactoryDatasetDelimitedText.DataFactoryDatasetDelimitedText>
