namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MediaPackagev2ChannelGroupState<'Name> = { assignments: ResizeArray<aws.MediaPackagev2ChannelGroup.MediaPackagev2ChannelGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_packagev2_channel_group">aws_media_packagev2_channel_group</a>.
    /// </summary>
    type MediaPackagev2ChannelGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : MediaPackagev2ChannelGroupState<Missing> =
            ({ assignments = ResizeArray() } : MediaPackagev2ChannelGroupState<Missing>)

        member _.Zero(()) : MediaPackagev2ChannelGroupState<Missing> =
            ({ assignments = ResizeArray() } : MediaPackagev2ChannelGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_packagev2_channel_group#name-1">MediaPackagev2ChannelGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MediaPackagev2ChannelGroupState<Missing>, value: string) : MediaPackagev2ChannelGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MediaPackagev2ChannelGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_packagev2_channel_group#description-1">MediaPackagev2ChannelGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MediaPackagev2ChannelGroupState<'Name>, value: string) : MediaPackagev2ChannelGroupState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MediaPackagev2ChannelGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_packagev2_channel_group#tags-1">MediaPackagev2ChannelGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MediaPackagev2ChannelGroupState<'Name>, value: seq<string * string>) : MediaPackagev2ChannelGroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MediaPackagev2ChannelGroupState<'Name>

        member _.Run(state: MediaPackagev2ChannelGroupState<Present>) : aws.MediaPackagev2ChannelGroup.MediaPackagev2ChannelGroup =
            let config = aws.MediaPackagev2ChannelGroup.MediaPackagev2ChannelGroupConfig()
            for setter in state.assignments do
                setter config
            aws.MediaPackagev2ChannelGroup.MediaPackagev2ChannelGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mediaPackagev2ChannelGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: MediaPackagev2ChannelGroupState<_>) : aws.MediaPackagev2ChannelGroup.MediaPackagev2ChannelGroup =
            Unchecked.defaultof<aws.MediaPackagev2ChannelGroup.MediaPackagev2ChannelGroup>
