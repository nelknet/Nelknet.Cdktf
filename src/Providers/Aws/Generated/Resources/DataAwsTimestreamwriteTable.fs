namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsTimestreamwriteTableState<'DatabaseName, 'Name> = { assignments: ResizeArray<aws.DataAwsTimestreamwriteTable.DataAwsTimestreamwriteTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/timestreamwrite_table">aws_timestreamwrite_table</a>.
    /// </summary>
    type DataAwsTimestreamwriteTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsTimestreamwriteTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsTimestreamwriteTableState<Missing, Missing>)

        member _.Zero(()) : DataAwsTimestreamwriteTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsTimestreamwriteTableState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/timestreamwrite_table#database_name-1">DataAwsTimestreamwriteTable#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: DataAwsTimestreamwriteTableState<Missing, 'Name>, value: string) : DataAwsTimestreamwriteTableState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : DataAwsTimestreamwriteTableState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/timestreamwrite_table#name-1">DataAwsTimestreamwriteTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsTimestreamwriteTableState<'DatabaseName, Missing>, value: string) : DataAwsTimestreamwriteTableState<'DatabaseName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsTimestreamwriteTableState<'DatabaseName, Present>)

        member _.Run(state: DataAwsTimestreamwriteTableState<Present, Present>) : aws.DataAwsTimestreamwriteTable.DataAwsTimestreamwriteTable =
            let config = aws.DataAwsTimestreamwriteTable.DataAwsTimestreamwriteTableConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsTimestreamwriteTable.DataAwsTimestreamwriteTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsTimestreamwriteTable: missing required arguments. Must call: database_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsTimestreamwriteTableState<_, _>) : aws.DataAwsTimestreamwriteTable.DataAwsTimestreamwriteTable =
            Unchecked.defaultof<aws.DataAwsTimestreamwriteTable.DataAwsTimestreamwriteTable>
