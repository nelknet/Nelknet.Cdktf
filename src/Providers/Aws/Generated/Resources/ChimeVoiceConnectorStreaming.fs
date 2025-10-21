namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId> = { assignments: ResizeArray<aws.ChimeVoiceConnectorStreaming.ChimeVoiceConnectorStreamingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_streaming">aws_chime_voice_connector_streaming</a>.
    /// </summary>
    type ChimeVoiceConnectorStreamingBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChimeVoiceConnectorStreamingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorStreamingState<Missing, Missing>)

        member _.Zero(()) : ChimeVoiceConnectorStreamingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorStreamingState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_streaming#data_retention-1">ChimeVoiceConnectorStreaming#data_retention</a>.
        /// </summary>
        [<CustomOperation "data_retention">]
        member _.DataRetention(state: ChimeVoiceConnectorStreamingState<Missing, 'VoiceConnectorId>, value: double) : ChimeVoiceConnectorStreamingState<Present, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.DataRetention <- value)
            ({ assignments = state.assignments } : ChimeVoiceConnectorStreamingState<Present, 'VoiceConnectorId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_streaming#voice_connector_id-1">ChimeVoiceConnectorStreaming#voice_connector_id</a>.
        /// </summary>
        [<CustomOperation "voice_connector_id">]
        member _.VoiceConnectorId(state: ChimeVoiceConnectorStreamingState<'DataRetention, Missing>, value: string) : ChimeVoiceConnectorStreamingState<'DataRetention, Present> =
            state.assignments.Add(fun config -> config.VoiceConnectorId <- value)
            ({ assignments = state.assignments } : ChimeVoiceConnectorStreamingState<'DataRetention, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_streaming#disabled-1">ChimeVoiceConnectorStreaming#disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disabled">]
        member _.Disabled(state: ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId>, value: bool) : ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.Disabled <- value)
            state : ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_streaming#disabled-1">ChimeVoiceConnectorStreaming#disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disabled">]
        member _.Disabled(state: ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId>, value: HashiCorp.Cdktf.IResolvable) : ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.Disabled <- value)
            state : ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_streaming#id-1">ChimeVoiceConnectorStreaming#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId>, value: string) : ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId>

        /// <summary>
        /// media_insights_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_streaming#media_insights_configuration-1">ChimeVoiceConnectorStreaming#media_insights_configuration</a>
        /// </summary>
        [<CustomOperation "media_insights_configuration">]
        member _.MediaInsightsConfiguration(state: ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId>, value: aws.ChimeVoiceConnectorStreaming.ChimeVoiceConnectorStreamingMediaInsightsConfiguration) : ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.MediaInsightsConfiguration <- value)
            state : ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_streaming#streaming_notification_targets-1">ChimeVoiceConnectorStreaming#streaming_notification_targets</a>.
        /// </summary>
        [<CustomOperation "streaming_notification_targets">]
        member _.StreamingNotificationTargets(state: ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId>, value: seq<string>) : ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.StreamingNotificationTargets <- (value |> Seq.toArray))
            state : ChimeVoiceConnectorStreamingState<'DataRetention, 'VoiceConnectorId>

        member _.Run(state: ChimeVoiceConnectorStreamingState<Present, Present>) : aws.ChimeVoiceConnectorStreaming.ChimeVoiceConnectorStreaming =
            let config = aws.ChimeVoiceConnectorStreaming.ChimeVoiceConnectorStreamingConfig()
            for setter in state.assignments do
                setter config
            aws.ChimeVoiceConnectorStreaming.ChimeVoiceConnectorStreaming(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chimeVoiceConnectorStreaming: missing required arguments. Must call: data_retention, voice_connector_id.", 9999, IsError = true)>]
        member _.Run(_: ChimeVoiceConnectorStreamingState<_, _>) : aws.ChimeVoiceConnectorStreaming.ChimeVoiceConnectorStreaming =
            Unchecked.defaultof<aws.ChimeVoiceConnectorStreaming.ChimeVoiceConnectorStreaming>
