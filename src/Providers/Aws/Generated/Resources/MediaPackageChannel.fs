namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MediaPackageChannelState<'ChannelId> = { assignments: ResizeArray<aws.MediaPackageChannel.MediaPackageChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_package_channel">aws_media_package_channel</a>.
    /// </summary>
    type MediaPackageChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : MediaPackageChannelState<Missing> =
            ({ assignments = ResizeArray() } : MediaPackageChannelState<Missing>)

        member _.Zero(()) : MediaPackageChannelState<Missing> =
            ({ assignments = ResizeArray() } : MediaPackageChannelState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_package_channel#channel_id-1">MediaPackageChannel#channel_id</a>.
        /// </summary>
        [<CustomOperation "channel_id">]
        member _.ChannelId(state: MediaPackageChannelState<Missing>, value: string) : MediaPackageChannelState<Present> =
            state.assignments.Add(fun config -> config.ChannelId <- value)
            ({ assignments = state.assignments } : MediaPackageChannelState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_package_channel#description-1">MediaPackageChannel#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MediaPackageChannelState<'ChannelId>, value: string) : MediaPackageChannelState<'ChannelId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MediaPackageChannelState<'ChannelId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_package_channel#id-1">MediaPackageChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MediaPackageChannelState<'ChannelId>, value: string) : MediaPackageChannelState<'ChannelId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MediaPackageChannelState<'ChannelId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_package_channel#tags-1">MediaPackageChannel#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MediaPackageChannelState<'ChannelId>, value: seq<string * string>) : MediaPackageChannelState<'ChannelId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MediaPackageChannelState<'ChannelId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_package_channel#tags_all-1">MediaPackageChannel#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MediaPackageChannelState<'ChannelId>, value: seq<string * string>) : MediaPackageChannelState<'ChannelId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MediaPackageChannelState<'ChannelId>

        member _.Run(state: MediaPackageChannelState<Present>) : aws.MediaPackageChannel.MediaPackageChannel =
            let config = aws.MediaPackageChannel.MediaPackageChannelConfig()
            for setter in state.assignments do
                setter config
            aws.MediaPackageChannel.MediaPackageChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mediaPackageChannel: missing required arguments. Must call: channel_id.", 9999, IsError = true)>]
        member _.Run(_: MediaPackageChannelState<_>) : aws.MediaPackageChannel.MediaPackageChannel =
            Unchecked.defaultof<aws.MediaPackageChannel.MediaPackageChannel>
