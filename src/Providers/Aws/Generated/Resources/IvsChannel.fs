namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IvsChannelState = { assignments: ResizeArray<aws.IvsChannel.IvsChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_channel">aws_ivs_channel</a>.
    /// </summary>
    type IvsChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : IvsChannelState =
            { assignments = ResizeArray() }

        member _.Zero(()) : IvsChannelState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_channel#authorized-1">IvsChannel#authorized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "authorized">]
        member _.Authorized(state: IvsChannelState, value: bool) : IvsChannelState =
            state.assignments.Add(fun config -> config.Authorized <- value)
            state : IvsChannelState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_channel#authorized-1">IvsChannel#authorized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "authorized">]
        member _.Authorized(state: IvsChannelState, value: HashiCorp.Cdktf.IResolvable) : IvsChannelState =
            state.assignments.Add(fun config -> config.Authorized <- value)
            state : IvsChannelState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_channel#id-1">IvsChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IvsChannelState, value: string) : IvsChannelState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IvsChannelState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_channel#latency_mode-1">IvsChannel#latency_mode</a>.
        /// </summary>
        [<CustomOperation "latency_mode">]
        member _.LatencyMode(state: IvsChannelState, value: string) : IvsChannelState =
            state.assignments.Add(fun config -> config.LatencyMode <- value)
            state : IvsChannelState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_channel#name-1">IvsChannel#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IvsChannelState, value: string) : IvsChannelState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : IvsChannelState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_channel#recording_configuration_arn-1">IvsChannel#recording_configuration_arn</a>.
        /// </summary>
        [<CustomOperation "recording_configuration_arn">]
        member _.RecordingConfigurationArn(state: IvsChannelState, value: string) : IvsChannelState =
            state.assignments.Add(fun config -> config.RecordingConfigurationArn <- value)
            state : IvsChannelState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_channel#tags-1">IvsChannel#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IvsChannelState, value: seq<string * string>) : IvsChannelState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IvsChannelState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_channel#tags_all-1">IvsChannel#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IvsChannelState, value: seq<string * string>) : IvsChannelState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IvsChannelState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_channel#timeouts-1">IvsChannel#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IvsChannelState, value: aws.IvsChannel.IvsChannelTimeouts) : IvsChannelState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IvsChannelState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_channel#type-1">IvsChannel#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: IvsChannelState, value: string) : IvsChannelState =
            state.assignments.Add(fun config -> config.Type <- value)
            state : IvsChannelState

        member _.Run(state: IvsChannelState) : aws.IvsChannel.IvsChannel =
            let config = aws.IvsChannel.IvsChannelConfig()
            for setter in state.assignments do
                setter config
            aws.IvsChannel.IvsChannel(StackContext.get (), logicalId, config)
