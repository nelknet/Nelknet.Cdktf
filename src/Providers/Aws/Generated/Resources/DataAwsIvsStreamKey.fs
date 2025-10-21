namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIvsStreamKeyState<'ChannelArn> = { assignments: ResizeArray<aws.DataAwsIvsStreamKey.DataAwsIvsStreamKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ivs_stream_key">aws_ivs_stream_key</a>.
    /// </summary>
    type DataAwsIvsStreamKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIvsStreamKeyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIvsStreamKeyState<Missing>)

        member _.Zero(()) : DataAwsIvsStreamKeyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIvsStreamKeyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ivs_stream_key#channel_arn-1">DataAwsIvsStreamKey#channel_arn</a>.
        /// </summary>
        [<CustomOperation "channel_arn">]
        member _.ChannelArn(state: DataAwsIvsStreamKeyState<Missing>, value: string) : DataAwsIvsStreamKeyState<Present> =
            state.assignments.Add(fun config -> config.ChannelArn <- value)
            ({ assignments = state.assignments } : DataAwsIvsStreamKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ivs_stream_key#id-1">DataAwsIvsStreamKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIvsStreamKeyState<'ChannelArn>, value: string) : DataAwsIvsStreamKeyState<'ChannelArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIvsStreamKeyState<'ChannelArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ivs_stream_key#tags-1">DataAwsIvsStreamKey#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsIvsStreamKeyState<'ChannelArn>, value: seq<string * string>) : DataAwsIvsStreamKeyState<'ChannelArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsIvsStreamKeyState<'ChannelArn>

        member _.Run(state: DataAwsIvsStreamKeyState<Present>) : aws.DataAwsIvsStreamKey.DataAwsIvsStreamKey =
            let config = aws.DataAwsIvsStreamKey.DataAwsIvsStreamKeyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIvsStreamKey.DataAwsIvsStreamKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIvsStreamKey: missing required arguments. Must call: channel_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIvsStreamKeyState<_>) : aws.DataAwsIvsStreamKey.DataAwsIvsStreamKey =
            Unchecked.defaultof<aws.DataAwsIvsStreamKey.DataAwsIvsStreamKey>
