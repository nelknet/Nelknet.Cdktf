namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary">azurerm_data_factory_dataset_binary</a>.
    /// </summary>
    type DataFactoryDatasetBinaryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryDatasetBinaryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetBinaryState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryDatasetBinaryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetBinaryState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#data_factory_id-1">DataFactoryDatasetBinary#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryDatasetBinaryState<Missing, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetBinaryState<Present, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetBinaryState<Present, 'LinkedServiceName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#linked_service_name-1">DataFactoryDatasetBinary#linked_service_name</a>.
        /// </summary>
        [<CustomOperation "linked_service_name">]
        member _.LinkedServiceName(state: DataFactoryDatasetBinaryState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryDatasetBinaryState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LinkedServiceName <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetBinaryState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#name-1">DataFactoryDatasetBinary#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, Missing>, value: string) : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#additional_properties-1">DataFactoryDatasetBinary#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#annotations-1">DataFactoryDatasetBinary#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string>) : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// azure_blob_storage_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#azure_blob_storage_location-1">DataFactoryDatasetBinary#azure_blob_storage_location</a>
        /// </summary>
        [<CustomOperation "azure_blob_storage_location">]
        member _.AzureBlobStorageLocation(state: DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryAzureBlobStorageLocation) : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AzureBlobStorageLocation <- value)
            state : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// compression block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#compression-1">DataFactoryDatasetBinary#compression</a>
        /// </summary>
        [<CustomOperation "compression">]
        member _.Compression(state: DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryCompression) : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Compression <- value)
            state : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#description-1">DataFactoryDatasetBinary#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#folder-1">DataFactoryDatasetBinary#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// http_server_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#http_server_location-1">DataFactoryDatasetBinary#http_server_location</a>
        /// </summary>
        [<CustomOperation "http_server_location">]
        member _.HttpServerLocation(state: DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryHttpServerLocation) : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.HttpServerLocation <- value)
            state : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#id-1">DataFactoryDatasetBinary#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#parameters-1">DataFactoryDatasetBinary#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// sftp_server_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#sftp_server_location-1">DataFactoryDatasetBinary#sftp_server_location</a>
        /// </summary>
        [<CustomOperation "sftp_server_location">]
        member _.SftpServerLocation(state: DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinarySftpServerLocation) : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.SftpServerLocation <- value)
            state : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#timeouts-1">DataFactoryDatasetBinary#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryTimeouts) : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryDatasetBinaryState<'DataFactoryId, 'LinkedServiceName, 'Name>

        member _.Run(state: DataFactoryDatasetBinaryState<Present, Present, Present>) : azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinary =
            let config = azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinary(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryDatasetBinary: missing required arguments. Must call: data_factory_id, linked_service_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryDatasetBinaryState<_, _, _>) : azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinary =
            Unchecked.defaultof<azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinary>
