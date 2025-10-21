namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryDatasetHttp.DataFactoryDatasetHttpConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http">azurerm_data_factory_dataset_http</a>.
    /// </summary>
    type DataFactoryDatasetHttpBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryDatasetHttpState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetHttpState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryDatasetHttpState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetHttpState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#data_factory_id-1">DataFactoryDatasetHttp#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryDatasetHttpState<Missing, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetHttpState<Present, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetHttpState<Present, 'LinkedServiceName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#linked_service_name-1">DataFactoryDatasetHttp#linked_service_name</a>.
        /// </summary>
        [<CustomOperation "linked_service_name">]
        member _.LinkedServiceName(state: DataFactoryDatasetHttpState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryDatasetHttpState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LinkedServiceName <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetHttpState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#name-1">DataFactoryDatasetHttp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, Missing>, value: string) : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#additional_properties-1">DataFactoryDatasetHttp#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#annotations-1">DataFactoryDatasetHttp#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string>) : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#description-1">DataFactoryDatasetHttp#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#folder-1">DataFactoryDatasetHttp#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#id-1">DataFactoryDatasetHttp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#parameters-1">DataFactoryDatasetHttp#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#relative_url-1">DataFactoryDatasetHttp#relative_url</a>.
        /// </summary>
        [<CustomOperation "relative_url">]
        member _.RelativeUrl(state: DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.RelativeUrl <- value)
            state : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#request_body-1">DataFactoryDatasetHttp#request_body</a>.
        /// </summary>
        [<CustomOperation "request_body">]
        member _.RequestBody(state: DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.RequestBody <- value)
            state : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#request_method-1">DataFactoryDatasetHttp#request_method</a>.
        /// </summary>
        [<CustomOperation "request_method">]
        member _.RequestMethod(state: DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.RequestMethod <- value)
            state : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// schema_column block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#schema_column-1">DataFactoryDatasetHttp#schema_column</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDatasetHttp.DataFactoryDatasetHttpSchemaColumn[]
        /// </summary>
        [<CustomOperation "schema_column">]
        member _.SchemaColumn(state: DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.SchemaColumn <- value)
            state : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_http#timeouts-1">DataFactoryDatasetHttp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetHttp.DataFactoryDatasetHttpTimeouts) : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryDatasetHttpState<'DataFactoryId, 'LinkedServiceName, 'Name>

        member _.Run(state: DataFactoryDatasetHttpState<Present, Present, Present>) : azurerm.DataFactoryDatasetHttp.DataFactoryDatasetHttp =
            let config = azurerm.DataFactoryDatasetHttp.DataFactoryDatasetHttpConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryDatasetHttp.DataFactoryDatasetHttp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryDatasetHttp: missing required arguments. Must call: data_factory_id, linked_service_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryDatasetHttpState<_, _, _>) : azurerm.DataFactoryDatasetHttp.DataFactoryDatasetHttp =
            Unchecked.defaultof<azurerm.DataFactoryDatasetHttp.DataFactoryDatasetHttp>
