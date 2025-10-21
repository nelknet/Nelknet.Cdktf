namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryDatasetPostgresql.DataFactoryDatasetPostgresqlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_postgresql">azurerm_data_factory_dataset_postgresql</a>.
    /// </summary>
    type DataFactoryDatasetPostgresqlBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryDatasetPostgresqlState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetPostgresqlState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryDatasetPostgresqlState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetPostgresqlState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_postgresql#data_factory_id-1">DataFactoryDatasetPostgresql#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryDatasetPostgresqlState<Missing, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetPostgresqlState<Present, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetPostgresqlState<Present, 'LinkedServiceName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_postgresql#linked_service_name-1">DataFactoryDatasetPostgresql#linked_service_name</a>.
        /// </summary>
        [<CustomOperation "linked_service_name">]
        member _.LinkedServiceName(state: DataFactoryDatasetPostgresqlState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryDatasetPostgresqlState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LinkedServiceName <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetPostgresqlState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_postgresql#name-1">DataFactoryDatasetPostgresql#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, Missing>, value: string) : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_postgresql#additional_properties-1">DataFactoryDatasetPostgresql#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_postgresql#annotations-1">DataFactoryDatasetPostgresql#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string>) : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_postgresql#description-1">DataFactoryDatasetPostgresql#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_postgresql#folder-1">DataFactoryDatasetPostgresql#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_postgresql#id-1">DataFactoryDatasetPostgresql#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_postgresql#parameters-1">DataFactoryDatasetPostgresql#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// schema_column block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_postgresql#schema_column-1">DataFactoryDatasetPostgresql#schema_column</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDatasetPostgresql.DataFactoryDatasetPostgresqlSchemaColumn[]
        /// </summary>
        [<CustomOperation "schema_column">]
        member _.SchemaColumn(state: DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.SchemaColumn <- value)
            state : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_postgresql#table_name-1">DataFactoryDatasetPostgresql#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.TableName <- value)
            state : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_postgresql#timeouts-1">DataFactoryDatasetPostgresql#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetPostgresql.DataFactoryDatasetPostgresqlTimeouts) : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryDatasetPostgresqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        member _.Run(state: DataFactoryDatasetPostgresqlState<Present, Present, Present>) : azurerm.DataFactoryDatasetPostgresql.DataFactoryDatasetPostgresql =
            let config = azurerm.DataFactoryDatasetPostgresql.DataFactoryDatasetPostgresqlConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryDatasetPostgresql.DataFactoryDatasetPostgresql(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryDatasetPostgresql: missing required arguments. Must call: data_factory_id, linked_service_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryDatasetPostgresqlState<_, _, _>) : azurerm.DataFactoryDatasetPostgresql.DataFactoryDatasetPostgresql =
            Unchecked.defaultof<azurerm.DataFactoryDatasetPostgresql.DataFactoryDatasetPostgresql>
