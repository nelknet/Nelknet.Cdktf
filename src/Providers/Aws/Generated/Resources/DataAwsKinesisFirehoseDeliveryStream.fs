namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKinesisFirehoseDeliveryStreamState<'Name> = { assignments: ResizeArray<aws.DataAwsKinesisFirehoseDeliveryStream.DataAwsKinesisFirehoseDeliveryStreamConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kinesis_firehose_delivery_stream">aws_kinesis_firehose_delivery_stream</a>.
    /// </summary>
    type DataAwsKinesisFirehoseDeliveryStreamBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKinesisFirehoseDeliveryStreamState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKinesisFirehoseDeliveryStreamState<Missing>)

        member _.Zero(()) : DataAwsKinesisFirehoseDeliveryStreamState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKinesisFirehoseDeliveryStreamState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kinesis_firehose_delivery_stream#name-1">DataAwsKinesisFirehoseDeliveryStream#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsKinesisFirehoseDeliveryStreamState<Missing>, value: string) : DataAwsKinesisFirehoseDeliveryStreamState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsKinesisFirehoseDeliveryStreamState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kinesis_firehose_delivery_stream#id-1">DataAwsKinesisFirehoseDeliveryStream#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKinesisFirehoseDeliveryStreamState<'Name>, value: string) : DataAwsKinesisFirehoseDeliveryStreamState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKinesisFirehoseDeliveryStreamState<'Name>

        member _.Run(state: DataAwsKinesisFirehoseDeliveryStreamState<Present>) : aws.DataAwsKinesisFirehoseDeliveryStream.DataAwsKinesisFirehoseDeliveryStream =
            let config = aws.DataAwsKinesisFirehoseDeliveryStream.DataAwsKinesisFirehoseDeliveryStreamConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKinesisFirehoseDeliveryStream.DataAwsKinesisFirehoseDeliveryStream(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKinesisFirehoseDeliveryStream: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKinesisFirehoseDeliveryStreamState<_>) : aws.DataAwsKinesisFirehoseDeliveryStream.DataAwsKinesisFirehoseDeliveryStream =
            Unchecked.defaultof<aws.DataAwsKinesisFirehoseDeliveryStream.DataAwsKinesisFirehoseDeliveryStream>
