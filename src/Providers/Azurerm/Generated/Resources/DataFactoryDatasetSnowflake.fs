namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryDatasetSnowflake.DataFactoryDatasetSnowflakeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake">azurerm_data_factory_dataset_snowflake</a>.
    /// </summary>
    type DataFactoryDatasetSnowflakeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryDatasetSnowflakeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetSnowflakeState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryDatasetSnowflakeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDatasetSnowflakeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#data_factory_id-1">DataFactoryDatasetSnowflake#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryDatasetSnowflakeState<Missing, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetSnowflakeState<Present, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetSnowflakeState<Present, 'LinkedServiceName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#linked_service_name-1">DataFactoryDatasetSnowflake#linked_service_name</a>.
        /// </summary>
        [<CustomOperation "linked_service_name">]
        member _.LinkedServiceName(state: DataFactoryDatasetSnowflakeState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryDatasetSnowflakeState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LinkedServiceName <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetSnowflakeState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#name-1">DataFactoryDatasetSnowflake#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, Missing>, value: string) : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#additional_properties-1">DataFactoryDatasetSnowflake#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#annotations-1">DataFactoryDatasetSnowflake#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string>) : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#description-1">DataFactoryDatasetSnowflake#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#folder-1">DataFactoryDatasetSnowflake#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#id-1">DataFactoryDatasetSnowflake#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#parameters-1">DataFactoryDatasetSnowflake#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: seq<string * string>) : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// schema_column block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#schema_column-1">DataFactoryDatasetSnowflake#schema_column</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDatasetSnowflake.DataFactoryDatasetSnowflakeSchemaColumn[]
        /// </summary>
        [<CustomOperation "schema_column">]
        member _.SchemaColumn(state: DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.SchemaColumn <- value)
            state : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#schema_name-1">DataFactoryDatasetSnowflake#schema_name</a>.
        /// </summary>
        [<CustomOperation "schema_name">]
        member _.SchemaName(state: DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.SchemaName <- value)
            state : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#table_name-1">DataFactoryDatasetSnowflake#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: string) : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.TableName <- value)
            state : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#timeouts-1">DataFactoryDatasetSnowflake#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>, value: azurerm.DataFactoryDatasetSnowflake.DataFactoryDatasetSnowflakeTimeouts) : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryDatasetSnowflakeState<'DataFactoryId, 'LinkedServiceName, 'Name>

        member _.Run(state: DataFactoryDatasetSnowflakeState<Present, Present, Present>) : azurerm.DataFactoryDatasetSnowflake.DataFactoryDatasetSnowflake =
            let config = azurerm.DataFactoryDatasetSnowflake.DataFactoryDatasetSnowflakeConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryDatasetSnowflake.DataFactoryDatasetSnowflake(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryDatasetSnowflake: missing required arguments. Must call: data_factory_id, linked_service_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryDatasetSnowflakeState<_, _, _>) : azurerm.DataFactoryDatasetSnowflake.DataFactoryDatasetSnowflake =
            Unchecked.defaultof<azurerm.DataFactoryDatasetSnowflake.DataFactoryDatasetSnowflake>
