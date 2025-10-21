namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsGlueCatalogTableState<'DatabaseName, 'Name> = { assignments: ResizeArray<aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_catalog_table">aws_glue_catalog_table</a>.
    /// </summary>
    type DataAwsGlueCatalogTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsGlueCatalogTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsGlueCatalogTableState<Missing, Missing>)

        member _.Zero(()) : DataAwsGlueCatalogTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsGlueCatalogTableState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_catalog_table#database_name-1">DataAwsGlueCatalogTable#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: DataAwsGlueCatalogTableState<Missing, 'Name>, value: string) : DataAwsGlueCatalogTableState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : DataAwsGlueCatalogTableState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_catalog_table#name-1">DataAwsGlueCatalogTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsGlueCatalogTableState<'DatabaseName, Missing>, value: string) : DataAwsGlueCatalogTableState<'DatabaseName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsGlueCatalogTableState<'DatabaseName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_catalog_table#catalog_id-1">DataAwsGlueCatalogTable#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: DataAwsGlueCatalogTableState<'DatabaseName, 'Name>, value: string) : DataAwsGlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : DataAwsGlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_catalog_table#id-1">DataAwsGlueCatalogTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsGlueCatalogTableState<'DatabaseName, 'Name>, value: string) : DataAwsGlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsGlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_catalog_table#query_as_of_time-1">DataAwsGlueCatalogTable#query_as_of_time</a>.
        /// </summary>
        [<CustomOperation "query_as_of_time">]
        member _.QueryAsOfTime(state: DataAwsGlueCatalogTableState<'DatabaseName, 'Name>, value: string) : DataAwsGlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.QueryAsOfTime <- value)
            state : DataAwsGlueCatalogTableState<'DatabaseName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_catalog_table#transaction_id-1">DataAwsGlueCatalogTable#transaction_id</a>.
        /// </summary>
        [<CustomOperation "transaction_id">]
        member _.TransactionId(state: DataAwsGlueCatalogTableState<'DatabaseName, 'Name>, value: double) : DataAwsGlueCatalogTableState<'DatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.TransactionId <- value)
            state : DataAwsGlueCatalogTableState<'DatabaseName, 'Name>

        member _.Run(state: DataAwsGlueCatalogTableState<Present, Present>) : aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTable =
            let config = aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTableConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsGlueCatalogTable: missing required arguments. Must call: database_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsGlueCatalogTableState<_, _>) : aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTable =
            Unchecked.defaultof<aws.DataAwsGlueCatalogTable.DataAwsGlueCatalogTable>
