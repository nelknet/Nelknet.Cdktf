namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryDatasetSqlServerTable.DataFactoryDatasetSqlServerTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_sql_server_table">azurerm_data_factory_dataset_sql_server_table</a>.
    /// </summary>
    type DataFactoryDatasetSqlServerTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryDatasetSqlServerTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetSqlServerTableState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryDatasetSqlServerTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetSqlServerTableState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_sql_server_table#data_factory_id-1">DataFactoryDatasetSqlServerTable#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryDatasetSqlServerTableState<Missing, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetSqlServerTableState<Present, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetSqlServerTableState<Present, 'LinkedServiceName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_sql_server_table#linked_service_name-1">DataFactoryDatasetSqlServerTable#linked_service_name</a>.
        /// </summary>
        [<CustomOperation "linked_service_name">]
        member _.LinkedServiceName(state: DataFactoryDatasetSqlServerTableState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryDatasetSqlServerTableState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LinkedServiceName <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetSqlServerTableState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_sql_server_table#name-1">DataFactoryDatasetSqlServerTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, Missing>, value: string) : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_sql_server_table#additional_properties-1">DataFactoryDatasetSqlServerTable#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_sql_server_table#annotations-1">DataFactoryDatasetSqlServerTable#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string>) : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_sql_server_table#description-1">DataFactoryDatasetSqlServerTable#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_sql_server_table#folder-1">DataFactoryDatasetSqlServerTable#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_sql_server_table#id-1">DataFactoryDatasetSqlServerTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_sql_server_table#parameters-1">DataFactoryDatasetSqlServerTable#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// schema_column block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_sql_server_table#schema_column-1">DataFactoryDatasetSqlServerTable#schema_column</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDatasetSqlServerTable.DataFactoryDatasetSqlServerTableSchemaColumn[]
        /// </summary>
        [<CustomOperation "schema_column">]
        member _.SchemaColumn(state: DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.SchemaColumn <- value)
            state : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_sql_server_table#table_name-1">DataFactoryDatasetSqlServerTable#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.TableName <- value)
            state : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_sql_server_table#timeouts-1">DataFactoryDatasetSqlServerTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetSqlServerTable.DataFactoryDatasetSqlServerTableTimeouts) : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryDatasetSqlServerTableState<'DataFactoryId, 'LinkedServiceName, 'Name>

        member _.Run(state: DataFactoryDatasetSqlServerTableState<Present, Present, Present>) : azurerm.DataFactoryDatasetSqlServerTable.DataFactoryDatasetSqlServerTable =
            let config = azurerm.DataFactoryDatasetSqlServerTable.DataFactoryDatasetSqlServerTableConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryDatasetSqlServerTable.DataFactoryDatasetSqlServerTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryDatasetSqlServerTable: missing required arguments. Must call: data_factory_id, linked_service_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryDatasetSqlServerTableState<_, _, _>) : azurerm.DataFactoryDatasetSqlServerTable.DataFactoryDatasetSqlServerTable =
            Unchecked.defaultof<azurerm.DataFactoryDatasetSqlServerTable.DataFactoryDatasetSqlServerTable>
