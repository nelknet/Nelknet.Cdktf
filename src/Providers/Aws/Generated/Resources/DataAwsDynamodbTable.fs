namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDynamodbTableState<'Name> = { assignments: ResizeArray<aws.DataAwsDynamodbTable.DataAwsDynamodbTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table">aws_dynamodb_table</a>.
    /// </summary>
    type DataAwsDynamodbTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDynamodbTableState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDynamodbTableState<Missing>)

        member _.Zero(()) : DataAwsDynamodbTableState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDynamodbTableState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table#name-1">DataAwsDynamodbTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsDynamodbTableState<Missing>, value: string) : DataAwsDynamodbTableState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsDynamodbTableState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table#id-1">DataAwsDynamodbTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDynamodbTableState<'Name>, value: string) : DataAwsDynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDynamodbTableState<'Name>

        /// <summary>
        /// server_side_encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table#server_side_encryption-1">DataAwsDynamodbTable#server_side_encryption</a>
        /// </summary>
        [<CustomOperation "server_side_encryption">]
        member _.ServerSideEncryption(state: DataAwsDynamodbTableState<'Name>, value: aws.DataAwsDynamodbTable.DataAwsDynamodbTableServerSideEncryption) : DataAwsDynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.ServerSideEncryption <- value)
            state : DataAwsDynamodbTableState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table#tags-1">DataAwsDynamodbTable#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDynamodbTableState<'Name>, value: seq<string * string>) : DataAwsDynamodbTableState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsDynamodbTableState<'Name>

        member _.Run(state: DataAwsDynamodbTableState<Present>) : aws.DataAwsDynamodbTable.DataAwsDynamodbTable =
            let config = aws.DataAwsDynamodbTable.DataAwsDynamodbTableConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDynamodbTable.DataAwsDynamodbTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDynamodbTable: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDynamodbTableState<_>) : aws.DataAwsDynamodbTable.DataAwsDynamodbTable =
            Unchecked.defaultof<aws.DataAwsDynamodbTable.DataAwsDynamodbTable>
