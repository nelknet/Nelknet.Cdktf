namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table">azurerm_data_factory_dataset_azure_sql_table</a>.
    /// </summary>
    type DataFactoryDatasetAzureSqlTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryDatasetAzureSqlTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetAzureSqlTableState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryDatasetAzureSqlTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetAzureSqlTableState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table#data_factory_id-1">DataFactoryDatasetAzureSqlTable#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryDatasetAzureSqlTableState<Missing, 'LinkedServiceId, 'Name>, value: string) : DataFactoryDatasetAzureSqlTableState<Present, 'LinkedServiceId, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetAzureSqlTableState<Present, 'LinkedServiceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table#linked_service_id-1">DataFactoryDatasetAzureSqlTable#linked_service_id</a>.
        /// </summary>
        [<CustomOperation "linked_service_id">]
        member _.LinkedServiceId(state: DataFactoryDatasetAzureSqlTableState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LinkedServiceId <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table#name-1">DataFactoryDatasetAzureSqlTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, Missing>, value: string) : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table#additional_properties-1">DataFactoryDatasetAzureSqlTable#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>, value: seq<string * string>) : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table#annotations-1">DataFactoryDatasetAzureSqlTable#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>, value: seq<string>) : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table#description-1">DataFactoryDatasetAzureSqlTable#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>, value: string) : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table#folder-1">DataFactoryDatasetAzureSqlTable#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>, value: string) : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table#id-1">DataFactoryDatasetAzureSqlTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>, value: string) : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table#parameters-1">DataFactoryDatasetAzureSqlTable#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>, value: seq<string * string>) : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table#schema-1">DataFactoryDatasetAzureSqlTable#schema</a>.
        /// </summary>
        [<CustomOperation "schema">]
        member _.Schema(state: DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>, value: string) : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Schema <- value)
            state : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>

        /// <summary>
        /// schema_column block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table#schema_column-1">DataFactoryDatasetAzureSqlTable#schema_column</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTableSchemaColumn[]
        /// </summary>
        [<CustomOperation "schema_column">]
        member _.SchemaColumn(state: DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name> =
            state.assignments.Add(fun config -> config.SchemaColumn <- value)
            state : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table#table-1">DataFactoryDatasetAzureSqlTable#table</a>.
        /// </summary>
        [<CustomOperation "table">]
        member _.Table(state: DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>, value: string) : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Table <- value)
            state : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_azure_sql_table#timeouts-1">DataFactoryDatasetAzureSqlTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>, value: azurerm.DataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTableTimeouts) : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryDatasetAzureSqlTableState<'DataFactoryId, 'LinkedServiceId, 'Name>

        member _.Run(state: DataFactoryDatasetAzureSqlTableState<Present, Present, Present>) : azurerm.DataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTable =
            let config = azurerm.DataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTableConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryDatasetAzureSqlTable: missing required arguments. Must call: data_factory_id, linked_service_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryDatasetAzureSqlTableState<_, _, _>) : azurerm.DataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTable =
            Unchecked.defaultof<azurerm.DataFactoryDatasetAzureSqlTable.DataFactoryDatasetAzureSqlTable>
