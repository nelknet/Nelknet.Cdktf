namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDynamodbTableItemState<'Key, 'TableName> = { assignments: ResizeArray<aws.DataAwsDynamodbTableItem.DataAwsDynamodbTableItemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table_item">aws_dynamodb_table_item</a>.
    /// </summary>
    type DataAwsDynamodbTableItemBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDynamodbTableItemState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsDynamodbTableItemState<Missing, Missing>)

        member _.Zero(()) : DataAwsDynamodbTableItemState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsDynamodbTableItemState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table_item#key-1">DataAwsDynamodbTableItem#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: DataAwsDynamodbTableItemState<Missing, 'TableName>, value: string) : DataAwsDynamodbTableItemState<Present, 'TableName> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : DataAwsDynamodbTableItemState<Present, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table_item#table_name-1">DataAwsDynamodbTableItem#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: DataAwsDynamodbTableItemState<'Key, Missing>, value: string) : DataAwsDynamodbTableItemState<'Key, Present> =
            state.assignments.Add(fun config -> config.TableName <- value)
            ({ assignments = state.assignments } : DataAwsDynamodbTableItemState<'Key, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table_item#expression_attribute_names-1">DataAwsDynamodbTableItem#expression_attribute_names</a>.
        /// </summary>
        [<CustomOperation "expression_attribute_names">]
        member _.ExpressionAttributeNames(state: DataAwsDynamodbTableItemState<'Key, 'TableName>, value: seq<string * string>) : DataAwsDynamodbTableItemState<'Key, 'TableName> =
            state.assignments.Add(fun config -> config.ExpressionAttributeNames <- dict value)
            state : DataAwsDynamodbTableItemState<'Key, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table_item#id-1">DataAwsDynamodbTableItem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDynamodbTableItemState<'Key, 'TableName>, value: string) : DataAwsDynamodbTableItemState<'Key, 'TableName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDynamodbTableItemState<'Key, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dynamodb_table_item#projection_expression-1">DataAwsDynamodbTableItem#projection_expression</a>.
        /// </summary>
        [<CustomOperation "projection_expression">]
        member _.ProjectionExpression(state: DataAwsDynamodbTableItemState<'Key, 'TableName>, value: string) : DataAwsDynamodbTableItemState<'Key, 'TableName> =
            state.assignments.Add(fun config -> config.ProjectionExpression <- value)
            state : DataAwsDynamodbTableItemState<'Key, 'TableName>

        member _.Run(state: DataAwsDynamodbTableItemState<Present, Present>) : aws.DataAwsDynamodbTableItem.DataAwsDynamodbTableItem =
            let config = aws.DataAwsDynamodbTableItem.DataAwsDynamodbTableItemConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDynamodbTableItem.DataAwsDynamodbTableItem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDynamodbTableItem: missing required arguments. Must call: key, table_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDynamodbTableItemState<_, _>) : aws.DataAwsDynamodbTableItem.DataAwsDynamodbTableItem =
            Unchecked.defaultof<aws.DataAwsDynamodbTableItem.DataAwsDynamodbTableItem>
