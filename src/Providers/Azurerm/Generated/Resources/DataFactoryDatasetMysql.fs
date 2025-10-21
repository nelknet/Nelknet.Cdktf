namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryDatasetMysql.DataFactoryDatasetMysqlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_mysql">azurerm_data_factory_dataset_mysql</a>.
    /// </summary>
    type DataFactoryDatasetMysqlBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryDatasetMysqlState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetMysqlState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryDatasetMysqlState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetMysqlState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_mysql#data_factory_id-1">DataFactoryDatasetMysql#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryDatasetMysqlState<Missing, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetMysqlState<Present, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetMysqlState<Present, 'LinkedServiceName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_mysql#linked_service_name-1">DataFactoryDatasetMysql#linked_service_name</a>.
        /// </summary>
        [<CustomOperation "linked_service_name">]
        member _.LinkedServiceName(state: DataFactoryDatasetMysqlState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryDatasetMysqlState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LinkedServiceName <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetMysqlState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_mysql#name-1">DataFactoryDatasetMysql#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, Missing>, value: string) : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_mysql#additional_properties-1">DataFactoryDatasetMysql#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_mysql#annotations-1">DataFactoryDatasetMysql#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string>) : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_mysql#description-1">DataFactoryDatasetMysql#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_mysql#folder-1">DataFactoryDatasetMysql#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_mysql#id-1">DataFactoryDatasetMysql#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_mysql#parameters-1">DataFactoryDatasetMysql#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// schema_column block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_mysql#schema_column-1">DataFactoryDatasetMysql#schema_column</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDatasetMysql.DataFactoryDatasetMysqlSchemaColumn[]
        /// </summary>
        [<CustomOperation "schema_column">]
        member _.SchemaColumn(state: DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.SchemaColumn <- value)
            state : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_mysql#table_name-1">DataFactoryDatasetMysql#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.TableName <- value)
            state : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_mysql#timeouts-1">DataFactoryDatasetMysql#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetMysql.DataFactoryDatasetMysqlTimeouts) : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryDatasetMysqlState<'DataFactoryId, 'LinkedServiceName, 'Name>

        member _.Run(state: DataFactoryDatasetMysqlState<Present, Present, Present>) : azurerm.DataFactoryDatasetMysql.DataFactoryDatasetMysql =
            let config = azurerm.DataFactoryDatasetMysql.DataFactoryDatasetMysqlConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryDatasetMysql.DataFactoryDatasetMysql(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryDatasetMysql: missing required arguments. Must call: data_factory_id, linked_service_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryDatasetMysqlState<_, _, _>) : azurerm.DataFactoryDatasetMysql.DataFactoryDatasetMysql =
            Unchecked.defaultof<azurerm.DataFactoryDatasetMysql.DataFactoryDatasetMysql>
