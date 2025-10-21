namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KinesisStreamConsumerState<'Name, 'StreamArn> = { assignments: ResizeArray<aws.KinesisStreamConsumer.KinesisStreamConsumerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream_consumer">aws_kinesis_stream_consumer</a>.
    /// </summary>
    type KinesisStreamConsumerBuilder(logicalId: string) =
        member _.Yield(_: unit) : KinesisStreamConsumerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KinesisStreamConsumerState<Missing, Missing>)

        member _.Zero(()) : KinesisStreamConsumerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KinesisStreamConsumerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream_consumer#name-1">KinesisStreamConsumer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KinesisStreamConsumerState<Missing, 'StreamArn>, value: string) : KinesisStreamConsumerState<Present, 'StreamArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KinesisStreamConsumerState<Present, 'StreamArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream_consumer#stream_arn-1">KinesisStreamConsumer#stream_arn</a>.
        /// </summary>
        [<CustomOperation "stream_arn">]
        member _.StreamArn(state: KinesisStreamConsumerState<'Name, Missing>, value: string) : KinesisStreamConsumerState<'Name, Present> =
            state.assignments.Add(fun config -> config.StreamArn <- value)
            ({ assignments = state.assignments } : KinesisStreamConsumerState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream_consumer#id-1">KinesisStreamConsumer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KinesisStreamConsumerState<'Name, 'StreamArn>, value: string) : KinesisStreamConsumerState<'Name, 'StreamArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KinesisStreamConsumerState<'Name, 'StreamArn>

        member _.Run(state: KinesisStreamConsumerState<Present, Present>) : aws.KinesisStreamConsumer.KinesisStreamConsumer =
            let config = aws.KinesisStreamConsumer.KinesisStreamConsumerConfig()
            for setter in state.assignments do
                setter config
            aws.KinesisStreamConsumer.KinesisStreamConsumer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kinesisStreamConsumer: missing required arguments. Must call: name, stream_arn.", 9999, IsError = true)>]
        member _.Run(_: KinesisStreamConsumerState<_, _>) : aws.KinesisStreamConsumer.KinesisStreamConsumer =
            Unchecked.defaultof<aws.KinesisStreamConsumer.KinesisStreamConsumer>
