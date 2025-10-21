namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KinesisVideoStreamState<'Name> = { assignments: ResizeArray<aws.KinesisVideoStream.KinesisVideoStreamConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_video_stream">aws_kinesis_video_stream</a>.
    /// </summary>
    type KinesisVideoStreamBuilder(logicalId: string) =
        member _.Yield(_: unit) : KinesisVideoStreamState<Missing> =
            ({ assignments = ResizeArray() } : KinesisVideoStreamState<Missing>)

        member _.Zero(()) : KinesisVideoStreamState<Missing> =
            ({ assignments = ResizeArray() } : KinesisVideoStreamState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_video_stream#name-1">KinesisVideoStream#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KinesisVideoStreamState<Missing>, value: string) : KinesisVideoStreamState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KinesisVideoStreamState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_video_stream#data_retention_in_hours-1">KinesisVideoStream#data_retention_in_hours</a>.
        /// </summary>
        [<CustomOperation "data_retention_in_hours">]
        member _.DataRetentionInHours(state: KinesisVideoStreamState<'Name>, value: double) : KinesisVideoStreamState<'Name> =
            state.assignments.Add(fun config -> config.DataRetentionInHours <- value)
            state : KinesisVideoStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_video_stream#device_name-1">KinesisVideoStream#device_name</a>.
        /// </summary>
        [<CustomOperation "device_name">]
        member _.DeviceName(state: KinesisVideoStreamState<'Name>, value: string) : KinesisVideoStreamState<'Name> =
            state.assignments.Add(fun config -> config.DeviceName <- value)
            state : KinesisVideoStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_video_stream#id-1">KinesisVideoStream#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KinesisVideoStreamState<'Name>, value: string) : KinesisVideoStreamState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KinesisVideoStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_video_stream#kms_key_id-1">KinesisVideoStream#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: KinesisVideoStreamState<'Name>, value: string) : KinesisVideoStreamState<'Name> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : KinesisVideoStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_video_stream#media_type-1">KinesisVideoStream#media_type</a>.
        /// </summary>
        [<CustomOperation "media_type">]
        member _.MediaType(state: KinesisVideoStreamState<'Name>, value: string) : KinesisVideoStreamState<'Name> =
            state.assignments.Add(fun config -> config.MediaType <- value)
            state : KinesisVideoStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_video_stream#tags-1">KinesisVideoStream#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KinesisVideoStreamState<'Name>, value: seq<string * string>) : KinesisVideoStreamState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KinesisVideoStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_video_stream#tags_all-1">KinesisVideoStream#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KinesisVideoStreamState<'Name>, value: seq<string * string>) : KinesisVideoStreamState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KinesisVideoStreamState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_video_stream#timeouts-1">KinesisVideoStream#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KinesisVideoStreamState<'Name>, value: aws.KinesisVideoStream.KinesisVideoStreamTimeouts) : KinesisVideoStreamState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KinesisVideoStreamState<'Name>

        member _.Run(state: KinesisVideoStreamState<Present>) : aws.KinesisVideoStream.KinesisVideoStream =
            let config = aws.KinesisVideoStream.KinesisVideoStreamConfig()
            for setter in state.assignments do
                setter config
            aws.KinesisVideoStream.KinesisVideoStream(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kinesisVideoStream: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: KinesisVideoStreamState<_>) : aws.KinesisVideoStream.KinesisVideoStream =
            Unchecked.defaultof<aws.KinesisVideoStream.KinesisVideoStream>
