namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TimestreamwriteTableState<'DatabaseName, 'TableName> = { assignments: ResizeArray<aws.TimestreamwriteTable.TimestreamwriteTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table">aws_timestreamwrite_table</a>.
    /// </summary>
    type TimestreamwriteTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : TimestreamwriteTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TimestreamwriteTableState<Missing, Missing>)

        member _.Zero(()) : TimestreamwriteTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TimestreamwriteTableState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#database_name-1">TimestreamwriteTable#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: TimestreamwriteTableState<Missing, 'TableName>, value: string) : TimestreamwriteTableState<Present, 'TableName> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : TimestreamwriteTableState<Present, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#table_name-1">TimestreamwriteTable#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: TimestreamwriteTableState<'DatabaseName, Missing>, value: string) : TimestreamwriteTableState<'DatabaseName, Present> =
            state.assignments.Add(fun config -> config.TableName <- value)
            ({ assignments = state.assignments } : TimestreamwriteTableState<'DatabaseName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#id-1">TimestreamwriteTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TimestreamwriteTableState<'DatabaseName, 'TableName>, value: string) : TimestreamwriteTableState<'DatabaseName, 'TableName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TimestreamwriteTableState<'DatabaseName, 'TableName>

        /// <summary>
        /// magnetic_store_write_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#magnetic_store_write_properties-1">TimestreamwriteTable#magnetic_store_write_properties</a>
        /// </summary>
        [<CustomOperation "magnetic_store_write_properties">]
        member _.MagneticStoreWriteProperties(state: TimestreamwriteTableState<'DatabaseName, 'TableName>, value: aws.TimestreamwriteTable.TimestreamwriteTableMagneticStoreWriteProperties) : TimestreamwriteTableState<'DatabaseName, 'TableName> =
            state.assignments.Add(fun config -> config.MagneticStoreWriteProperties <- value)
            state : TimestreamwriteTableState<'DatabaseName, 'TableName>

        /// <summary>
        /// retention_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#retention_properties-1">TimestreamwriteTable#retention_properties</a>
        /// </summary>
        [<CustomOperation "retention_properties">]
        member _.RetentionProperties(state: TimestreamwriteTableState<'DatabaseName, 'TableName>, value: aws.TimestreamwriteTable.TimestreamwriteTableRetentionProperties) : TimestreamwriteTableState<'DatabaseName, 'TableName> =
            state.assignments.Add(fun config -> config.RetentionProperties <- value)
            state : TimestreamwriteTableState<'DatabaseName, 'TableName>

        /// <summary>
        /// schema block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#schema-1">TimestreamwriteTable#schema</a>
        /// </summary>
        [<CustomOperation "schema">]
        member _.Schema(state: TimestreamwriteTableState<'DatabaseName, 'TableName>, value: aws.TimestreamwriteTable.TimestreamwriteTableSchema) : TimestreamwriteTableState<'DatabaseName, 'TableName> =
            state.assignments.Add(fun config -> config.Schema <- value)
            state : TimestreamwriteTableState<'DatabaseName, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#tags-1">TimestreamwriteTable#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TimestreamwriteTableState<'DatabaseName, 'TableName>, value: seq<string * string>) : TimestreamwriteTableState<'DatabaseName, 'TableName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TimestreamwriteTableState<'DatabaseName, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#tags_all-1">TimestreamwriteTable#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: TimestreamwriteTableState<'DatabaseName, 'TableName>, value: seq<string * string>) : TimestreamwriteTableState<'DatabaseName, 'TableName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : TimestreamwriteTableState<'DatabaseName, 'TableName>

        member _.Run(state: TimestreamwriteTableState<Present, Present>) : aws.TimestreamwriteTable.TimestreamwriteTable =
            let config = aws.TimestreamwriteTable.TimestreamwriteTableConfig()
            for setter in state.assignments do
                setter config
            aws.TimestreamwriteTable.TimestreamwriteTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.timestreamwriteTable: missing required arguments. Must call: database_name, table_name.", 9999, IsError = true)>]
        member _.Run(_: TimestreamwriteTableState<_, _>) : aws.TimestreamwriteTable.TimestreamwriteTable =
            Unchecked.defaultof<aws.TimestreamwriteTable.TimestreamwriteTable>
