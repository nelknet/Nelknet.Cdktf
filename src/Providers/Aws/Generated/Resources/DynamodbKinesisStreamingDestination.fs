namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DynamodbKinesisStreamingDestinationState<'StreamArn, 'TableName> = { assignments: ResizeArray<aws.DynamodbKinesisStreamingDestination.DynamodbKinesisStreamingDestinationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_kinesis_streaming_destination">aws_dynamodb_kinesis_streaming_destination</a>.
    /// </summary>
    type DynamodbKinesisStreamingDestinationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DynamodbKinesisStreamingDestinationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DynamodbKinesisStreamingDestinationState<Missing, Missing>)

        member _.Zero(()) : DynamodbKinesisStreamingDestinationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DynamodbKinesisStreamingDestinationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_kinesis_streaming_destination#stream_arn-1">DynamodbKinesisStreamingDestination#stream_arn</a>.
        /// </summary>
        [<CustomOperation "stream_arn">]
        member _.StreamArn(state: DynamodbKinesisStreamingDestinationState<Missing, 'TableName>, value: string) : DynamodbKinesisStreamingDestinationState<Present, 'TableName> =
            state.assignments.Add(fun config -> config.StreamArn <- value)
            ({ assignments = state.assignments } : DynamodbKinesisStreamingDestinationState<Present, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_kinesis_streaming_destination#table_name-1">DynamodbKinesisStreamingDestination#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: DynamodbKinesisStreamingDestinationState<'StreamArn, Missing>, value: string) : DynamodbKinesisStreamingDestinationState<'StreamArn, Present> =
            state.assignments.Add(fun config -> config.TableName <- value)
            ({ assignments = state.assignments } : DynamodbKinesisStreamingDestinationState<'StreamArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_kinesis_streaming_destination#approximate_creation_date_time_precision-1">DynamodbKinesisStreamingDestination#approximate_creation_date_time_precision</a>.
        /// </summary>
        [<CustomOperation "approximate_creation_date_time_precision">]
        member _.ApproximateCreationDateTimePrecision(state: DynamodbKinesisStreamingDestinationState<'StreamArn, 'TableName>, value: string) : DynamodbKinesisStreamingDestinationState<'StreamArn, 'TableName> =
            state.assignments.Add(fun config -> config.ApproximateCreationDateTimePrecision <- value)
            state : DynamodbKinesisStreamingDestinationState<'StreamArn, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_kinesis_streaming_destination#id-1">DynamodbKinesisStreamingDestination#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DynamodbKinesisStreamingDestinationState<'StreamArn, 'TableName>, value: string) : DynamodbKinesisStreamingDestinationState<'StreamArn, 'TableName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DynamodbKinesisStreamingDestinationState<'StreamArn, 'TableName>

        member _.Run(state: DynamodbKinesisStreamingDestinationState<Present, Present>) : aws.DynamodbKinesisStreamingDestination.DynamodbKinesisStreamingDestination =
            let config = aws.DynamodbKinesisStreamingDestination.DynamodbKinesisStreamingDestinationConfig()
            for setter in state.assignments do
                setter config
            aws.DynamodbKinesisStreamingDestination.DynamodbKinesisStreamingDestination(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dynamodbKinesisStreamingDestination: missing required arguments. Must call: stream_arn, table_name.", 9999, IsError = true)>]
        member _.Run(_: DynamodbKinesisStreamingDestinationState<_, _>) : aws.DynamodbKinesisStreamingDestination.DynamodbKinesisStreamingDestination =
            Unchecked.defaultof<aws.DynamodbKinesisStreamingDestination.DynamodbKinesisStreamingDestination>
