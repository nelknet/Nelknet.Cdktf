namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryDatasetCosmosdbSqlapi.DataFactoryDatasetCosmosdbSqlapiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_cosmosdb_sqlapi">azurerm_data_factory_dataset_cosmosdb_sqlapi</a>.
    /// </summary>
    type DataFactoryDatasetCosmosdbSqlapiBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryDatasetCosmosdbSqlapiState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetCosmosdbSqlapiState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryDatasetCosmosdbSqlapiState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetCosmosdbSqlapiState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_cosmosdb_sqlapi#data_factory_id-1">DataFactoryDatasetCosmosdbSqlapi#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryDatasetCosmosdbSqlapiState<Missing, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetCosmosdbSqlapiState<Present, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetCosmosdbSqlapiState<Present, 'LinkedServiceName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_cosmosdb_sqlapi#linked_service_name-1">DataFactoryDatasetCosmosdbSqlapi#linked_service_name</a>.
        /// </summary>
        [<CustomOperation "linked_service_name">]
        member _.LinkedServiceName(state: DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LinkedServiceName <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_cosmosdb_sqlapi#name-1">DataFactoryDatasetCosmosdbSqlapi#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, Missing>, value: string) : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_cosmosdb_sqlapi#additional_properties-1">DataFactoryDatasetCosmosdbSqlapi#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_cosmosdb_sqlapi#annotations-1">DataFactoryDatasetCosmosdbSqlapi#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string>) : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_cosmosdb_sqlapi#collection_name-1">DataFactoryDatasetCosmosdbSqlapi#collection_name</a>.
        /// </summary>
        [<CustomOperation "collection_name">]
        member _.CollectionName(state: DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.CollectionName <- value)
            state : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_cosmosdb_sqlapi#description-1">DataFactoryDatasetCosmosdbSqlapi#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_cosmosdb_sqlapi#folder-1">DataFactoryDatasetCosmosdbSqlapi#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_cosmosdb_sqlapi#id-1">DataFactoryDatasetCosmosdbSqlapi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_cosmosdb_sqlapi#parameters-1">DataFactoryDatasetCosmosdbSqlapi#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// schema_column block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_cosmosdb_sqlapi#schema_column-1">DataFactoryDatasetCosmosdbSqlapi#schema_column</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDatasetCosmosdbSqlapi.DataFactoryDatasetCosmosdbSqlapiSchemaColumn[]
        /// </summary>
        [<CustomOperation "schema_column">]
        member _.SchemaColumn(state: DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.SchemaColumn <- value)
            state : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_cosmosdb_sqlapi#timeouts-1">DataFactoryDatasetCosmosdbSqlapi#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetCosmosdbSqlapi.DataFactoryDatasetCosmosdbSqlapiTimeouts) : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryDatasetCosmosdbSqlapiState<'DataFactoryId, 'LinkedServiceName, 'Name>

        member _.Run(state: DataFactoryDatasetCosmosdbSqlapiState<Present, Present, Present>) : azurerm.DataFactoryDatasetCosmosdbSqlapi.DataFactoryDatasetCosmosdbSqlapi =
            let config = azurerm.DataFactoryDatasetCosmosdbSqlapi.DataFactoryDatasetCosmosdbSqlapiConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryDatasetCosmosdbSqlapi.DataFactoryDatasetCosmosdbSqlapi(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryDatasetCosmosdbSqlapi: missing required arguments. Must call: data_factory_id, linked_service_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryDatasetCosmosdbSqlapiState<_, _, _>) : azurerm.DataFactoryDatasetCosmosdbSqlapi.DataFactoryDatasetCosmosdbSqlapi =
            Unchecked.defaultof<azurerm.DataFactoryDatasetCosmosdbSqlapi.DataFactoryDatasetCosmosdbSqlapi>
