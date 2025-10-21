namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKinesisStreamConsumerState<'StreamArn> = { assignments: ResizeArray<aws.DataAwsKinesisStreamConsumer.DataAwsKinesisStreamConsumerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kinesis_stream_consumer">aws_kinesis_stream_consumer</a>.
    /// </summary>
    type DataAwsKinesisStreamConsumerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKinesisStreamConsumerState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKinesisStreamConsumerState<Missing>)

        member _.Zero(()) : DataAwsKinesisStreamConsumerState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKinesisStreamConsumerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kinesis_stream_consumer#stream_arn-1">DataAwsKinesisStreamConsumer#stream_arn</a>.
        /// </summary>
        [<CustomOperation "stream_arn">]
        member _.StreamArn(state: DataAwsKinesisStreamConsumerState<Missing>, value: string) : DataAwsKinesisStreamConsumerState<Present> =
            state.assignments.Add(fun config -> config.StreamArn <- value)
            ({ assignments = state.assignments } : DataAwsKinesisStreamConsumerState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kinesis_stream_consumer#arn-1">DataAwsKinesisStreamConsumer#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsKinesisStreamConsumerState<'StreamArn>, value: string) : DataAwsKinesisStreamConsumerState<'StreamArn> =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsKinesisStreamConsumerState<'StreamArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kinesis_stream_consumer#id-1">DataAwsKinesisStreamConsumer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKinesisStreamConsumerState<'StreamArn>, value: string) : DataAwsKinesisStreamConsumerState<'StreamArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKinesisStreamConsumerState<'StreamArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kinesis_stream_consumer#name-1">DataAwsKinesisStreamConsumer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsKinesisStreamConsumerState<'StreamArn>, value: string) : DataAwsKinesisStreamConsumerState<'StreamArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsKinesisStreamConsumerState<'StreamArn>

        member _.Run(state: DataAwsKinesisStreamConsumerState<Present>) : aws.DataAwsKinesisStreamConsumer.DataAwsKinesisStreamConsumer =
            let config = aws.DataAwsKinesisStreamConsumer.DataAwsKinesisStreamConsumerConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKinesisStreamConsumer.DataAwsKinesisStreamConsumer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKinesisStreamConsumer: missing required arguments. Must call: stream_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKinesisStreamConsumerState<_>) : aws.DataAwsKinesisStreamConsumer.DataAwsKinesisStreamConsumer =
            Unchecked.defaultof<aws.DataAwsKinesisStreamConsumer.DataAwsKinesisStreamConsumer>
