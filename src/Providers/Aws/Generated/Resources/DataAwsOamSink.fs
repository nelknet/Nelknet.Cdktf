namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOamSinkState<'SinkIdentifier> = { assignments: ResizeArray<aws.DataAwsOamSink.DataAwsOamSinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/oam_sink">aws_oam_sink</a>.
    /// </summary>
    type DataAwsOamSinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOamSinkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOamSinkState<Missing>)

        member _.Zero(()) : DataAwsOamSinkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOamSinkState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/oam_sink#sink_identifier-1">DataAwsOamSink#sink_identifier</a>.
        /// </summary>
        [<CustomOperation "sink_identifier">]
        member _.SinkIdentifier(state: DataAwsOamSinkState<Missing>, value: string) : DataAwsOamSinkState<Present> =
            state.assignments.Add(fun config -> config.SinkIdentifier <- value)
            ({ assignments = state.assignments } : DataAwsOamSinkState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/oam_sink#id-1">DataAwsOamSink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOamSinkState<'SinkIdentifier>, value: string) : DataAwsOamSinkState<'SinkIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOamSinkState<'SinkIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/oam_sink#tags-1">DataAwsOamSink#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsOamSinkState<'SinkIdentifier>, value: seq<string * string>) : DataAwsOamSinkState<'SinkIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsOamSinkState<'SinkIdentifier>

        member _.Run(state: DataAwsOamSinkState<Present>) : aws.DataAwsOamSink.DataAwsOamSink =
            let config = aws.DataAwsOamSink.DataAwsOamSinkConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOamSink.DataAwsOamSink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOamSink: missing required arguments. Must call: sink_identifier.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOamSinkState<_>) : aws.DataAwsOamSink.DataAwsOamSink =
            Unchecked.defaultof<aws.DataAwsOamSink.DataAwsOamSink>
