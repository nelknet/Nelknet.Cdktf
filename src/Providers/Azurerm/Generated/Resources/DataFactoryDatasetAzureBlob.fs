namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryDatasetAzureBlob.DataFactoryDatasetAzureBlobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob">azurerm_data_factory_dataset_azure_blob</a>.
    /// </summary>
    type DataFactoryDatasetAzureBlobBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryDatasetAzureBlobState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetAzureBlobState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryDatasetAzureBlobState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetAzureBlobState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#data_factory_id-1">DataFactoryDatasetAzureBlob#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryDatasetAzureBlobState<Missing, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetAzureBlobState<Present, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetAzureBlobState<Present, 'LinkedServiceName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#linked_service_name-1">DataFactoryDatasetAzureBlob#linked_service_name</a>.
        /// </summary>
        [<CustomOperation "linked_service_name">]
        member _.LinkedServiceName(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryDatasetAzureBlobState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LinkedServiceName <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetAzureBlobState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#name-1">DataFactoryDatasetAzureBlob#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, Missing>, value: string) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#additional_properties-1">DataFactoryDatasetAzureBlob#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#annotations-1">DataFactoryDatasetAzureBlob#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string>) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#description-1">DataFactoryDatasetAzureBlob#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#dynamic_filename_enabled-1">DataFactoryDatasetAzureBlob#dynamic_filename_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dynamic_filename_enabled">]
        member _.DynamicFilenameEnabled(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: bool) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DynamicFilenameEnabled <- value)
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#dynamic_filename_enabled-1">DataFactoryDatasetAzureBlob#dynamic_filename_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dynamic_filename_enabled">]
        member _.DynamicFilenameEnabled(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DynamicFilenameEnabled <- value)
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#dynamic_path_enabled-1">DataFactoryDatasetAzureBlob#dynamic_path_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dynamic_path_enabled">]
        member _.DynamicPathEnabled(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: bool) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DynamicPathEnabled <- value)
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#dynamic_path_enabled-1">DataFactoryDatasetAzureBlob#dynamic_path_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dynamic_path_enabled">]
        member _.DynamicPathEnabled(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DynamicPathEnabled <- value)
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#filename-1">DataFactoryDatasetAzureBlob#filename</a>.
        /// </summary>
        [<CustomOperation "filename">]
        member _.Filename(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Filename <- value)
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#folder-1">DataFactoryDatasetAzureBlob#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#id-1">DataFactoryDatasetAzureBlob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#parameters-1">DataFactoryDatasetAzureBlob#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#path-1">DataFactoryDatasetAzureBlob#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Path <- value)
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// schema_column block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#schema_column-1">DataFactoryDatasetAzureBlob#schema_column</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDatasetAzureBlob.DataFactoryDatasetAzureBlobSchemaColumn[]
        /// </summary>
        [<CustomOperation "schema_column">]
        member _.SchemaColumn(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.SchemaColumn <- value)
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_blob#timeouts-1">DataFactoryDatasetAzureBlob#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetAzureBlob.DataFactoryDatasetAzureBlobTimeouts) : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryDatasetAzureBlobState<'DataFactoryId, 'LinkedServiceName, 'Name>

        member _.Run(state: DataFactoryDatasetAzureBlobState<Present, Present, Present>) : azurerm.DataFactoryDatasetAzureBlob.DataFactoryDatasetAzureBlob =
            let config = azurerm.DataFactoryDatasetAzureBlob.DataFactoryDatasetAzureBlobConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryDatasetAzureBlob.DataFactoryDatasetAzureBlob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryDatasetAzureBlob: missing required arguments. Must call: data_factory_id, linked_service_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryDatasetAzureBlobState<_, _, _>) : azurerm.DataFactoryDatasetAzureBlob.DataFactoryDatasetAzureBlob =
            Unchecked.defaultof<azurerm.DataFactoryDatasetAzureBlob.DataFactoryDatasetAzureBlob>
