namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DynamodbTagState<'Key, 'ResourceArn, 'Value> = { assignments: ResizeArray<aws.DynamodbTag.DynamodbTagConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_tag">aws_dynamodb_tag</a>.
    /// </summary>
    type DynamodbTagBuilder(logicalId: string) =
        member _.Yield(_: unit) : DynamodbTagState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DynamodbTagState<Missing, Missing, Missing>)

        member _.Zero(()) : DynamodbTagState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DynamodbTagState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_tag#key-1">DynamodbTag#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: DynamodbTagState<Missing, 'ResourceArn, 'Value>, value: string) : DynamodbTagState<Present, 'ResourceArn, 'Value> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : DynamodbTagState<Present, 'ResourceArn, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_tag#resource_arn-1">DynamodbTag#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: DynamodbTagState<'Key, Missing, 'Value>, value: string) : DynamodbTagState<'Key, Present, 'Value> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : DynamodbTagState<'Key, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_tag#value-1">DynamodbTag#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: DynamodbTagState<'Key, 'ResourceArn, Missing>, value: string) : DynamodbTagState<'Key, 'ResourceArn, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : DynamodbTagState<'Key, 'ResourceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_tag#id-1">DynamodbTag#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DynamodbTagState<'Key, 'ResourceArn, 'Value>, value: string) : DynamodbTagState<'Key, 'ResourceArn, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DynamodbTagState<'Key, 'ResourceArn, 'Value>

        member _.Run(state: DynamodbTagState<Present, Present, Present>) : aws.DynamodbTag.DynamodbTag =
            let config = aws.DynamodbTag.DynamodbTagConfig()
            for setter in state.assignments do
                setter config
            aws.DynamodbTag.DynamodbTag(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dynamodbTag: missing required arguments. Must call: key, resource_arn, value.", 9999, IsError = true)>]
        member _.Run(_: DynamodbTagState<_, _, _>) : aws.DynamodbTag.DynamodbTag =
            Unchecked.defaultof<aws.DynamodbTag.DynamodbTag>
