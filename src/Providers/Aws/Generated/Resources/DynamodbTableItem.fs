namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DynamodbTableItemState<'HashKey, 'Item, 'TableName> = { assignments: ResizeArray<aws.DynamodbTableItem.DynamodbTableItemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_item">aws_dynamodb_table_item</a>.
    /// </summary>
    type DynamodbTableItemBuilder(logicalId: string) =
        member _.Yield(_: unit) : DynamodbTableItemState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DynamodbTableItemState<Missing, Missing, Missing>)

        member _.Zero(()) : DynamodbTableItemState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DynamodbTableItemState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_item#hash_key-1">DynamodbTableItem#hash_key</a>.
        /// </summary>
        [<CustomOperation "hash_key">]
        member _.HashKey(state: DynamodbTableItemState<Missing, 'Item, 'TableName>, value: string) : DynamodbTableItemState<Present, 'Item, 'TableName> =
            state.assignments.Add(fun config -> config.HashKey <- value)
            ({ assignments = state.assignments } : DynamodbTableItemState<Present, 'Item, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_item#item-1">DynamodbTableItem#item</a>.
        /// </summary>
        [<CustomOperation "item">]
        member _.Item(state: DynamodbTableItemState<'HashKey, Missing, 'TableName>, value: string) : DynamodbTableItemState<'HashKey, Present, 'TableName> =
            state.assignments.Add(fun config -> config.Item <- value)
            ({ assignments = state.assignments } : DynamodbTableItemState<'HashKey, Present, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_item#table_name-1">DynamodbTableItem#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: DynamodbTableItemState<'HashKey, 'Item, Missing>, value: string) : DynamodbTableItemState<'HashKey, 'Item, Present> =
            state.assignments.Add(fun config -> config.TableName <- value)
            ({ assignments = state.assignments } : DynamodbTableItemState<'HashKey, 'Item, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_item#id-1">DynamodbTableItem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DynamodbTableItemState<'HashKey, 'Item, 'TableName>, value: string) : DynamodbTableItemState<'HashKey, 'Item, 'TableName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DynamodbTableItemState<'HashKey, 'Item, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_item#range_key-1">DynamodbTableItem#range_key</a>.
        /// </summary>
        [<CustomOperation "range_key">]
        member _.RangeKey(state: DynamodbTableItemState<'HashKey, 'Item, 'TableName>, value: string) : DynamodbTableItemState<'HashKey, 'Item, 'TableName> =
            state.assignments.Add(fun config -> config.RangeKey <- value)
            state : DynamodbTableItemState<'HashKey, 'Item, 'TableName>

        member _.Run(state: DynamodbTableItemState<Present, Present, Present>) : aws.DynamodbTableItem.DynamodbTableItem =
            let config = aws.DynamodbTableItem.DynamodbTableItemConfig()
            for setter in state.assignments do
                setter config
            aws.DynamodbTableItem.DynamodbTableItem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dynamodbTableItem: missing required arguments. Must call: hash_key, item, table_name.", 9999, IsError = true)>]
        member _.Run(_: DynamodbTableItemState<_, _, _>) : aws.DynamodbTableItem.DynamodbTableItem =
            Unchecked.defaultof<aws.DynamodbTableItem.DynamodbTableItem>
