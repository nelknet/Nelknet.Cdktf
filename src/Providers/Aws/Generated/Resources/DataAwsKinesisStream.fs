namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKinesisStreamState<'Name> = { assignments: ResizeArray<aws.DataAwsKinesisStream.DataAwsKinesisStreamConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kinesis_stream">aws_kinesis_stream</a>.
    /// </summary>
    type DataAwsKinesisStreamBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKinesisStreamState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKinesisStreamState<Missing>)

        member _.Zero(()) : DataAwsKinesisStreamState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKinesisStreamState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kinesis_stream#name-1">DataAwsKinesisStream#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsKinesisStreamState<Missing>, value: string) : DataAwsKinesisStreamState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsKinesisStreamState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kinesis_stream#id-1">DataAwsKinesisStream#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKinesisStreamState<'Name>, value: string) : DataAwsKinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKinesisStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kinesis_stream#tags-1">DataAwsKinesisStream#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsKinesisStreamState<'Name>, value: seq<string * string>) : DataAwsKinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsKinesisStreamState<'Name>

        member _.Run(state: DataAwsKinesisStreamState<Present>) : aws.DataAwsKinesisStream.DataAwsKinesisStream =
            let config = aws.DataAwsKinesisStream.DataAwsKinesisStreamConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKinesisStream.DataAwsKinesisStream(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKinesisStream: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKinesisStreamState<_>) : aws.DataAwsKinesisStream.DataAwsKinesisStream =
            Unchecked.defaultof<aws.DataAwsKinesisStream.DataAwsKinesisStream>
