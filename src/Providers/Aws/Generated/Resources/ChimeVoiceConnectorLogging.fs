namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChimeVoiceConnectorLoggingState<'VoiceConnectorId> = { assignments: ResizeArray<aws.ChimeVoiceConnectorLogging.ChimeVoiceConnectorLoggingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_logging">aws_chime_voice_connector_logging</a>.
    /// </summary>
    type ChimeVoiceConnectorLoggingBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChimeVoiceConnectorLoggingState<Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorLoggingState<Missing>)

        member _.Zero(()) : ChimeVoiceConnectorLoggingState<Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorLoggingState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_logging#voice_connector_id-1">ChimeVoiceConnectorLogging#voice_connector_id</a>.
        /// </summary>
        [<CustomOperation "voice_connector_id">]
        member _.VoiceConnectorId(state: ChimeVoiceConnectorLoggingState<Missing>, value: string) : ChimeVoiceConnectorLoggingState<Present> =
            state.assignments.Add(fun config -> config.VoiceConnectorId <- value)
            ({ assignments = state.assignments } : ChimeVoiceConnectorLoggingState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_logging#enable_media_metric_logs-1">ChimeVoiceConnectorLogging#enable_media_metric_logs</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_media_metric_logs">]
        member _.EnableMediaMetricLogs(state: ChimeVoiceConnectorLoggingState<'VoiceConnectorId>, value: bool) : ChimeVoiceConnectorLoggingState<'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.EnableMediaMetricLogs <- value)
            state : ChimeVoiceConnectorLoggingState<'VoiceConnectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_logging#enable_media_metric_logs-1">ChimeVoiceConnectorLogging#enable_media_metric_logs</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_media_metric_logs">]
        member _.EnableMediaMetricLogs(state: ChimeVoiceConnectorLoggingState<'VoiceConnectorId>, value: HashiCorp.Cdktf.IResolvable) : ChimeVoiceConnectorLoggingState<'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.EnableMediaMetricLogs <- value)
            state : ChimeVoiceConnectorLoggingState<'VoiceConnectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_logging#enable_sip_logs-1">ChimeVoiceConnectorLogging#enable_sip_logs</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_sip_logs">]
        member _.EnableSipLogs(state: ChimeVoiceConnectorLoggingState<'VoiceConnectorId>, value: bool) : ChimeVoiceConnectorLoggingState<'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.EnableSipLogs <- value)
            state : ChimeVoiceConnectorLoggingState<'VoiceConnectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_logging#enable_sip_logs-1">ChimeVoiceConnectorLogging#enable_sip_logs</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_sip_logs">]
        member _.EnableSipLogs(state: ChimeVoiceConnectorLoggingState<'VoiceConnectorId>, value: HashiCorp.Cdktf.IResolvable) : ChimeVoiceConnectorLoggingState<'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.EnableSipLogs <- value)
            state : ChimeVoiceConnectorLoggingState<'VoiceConnectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_logging#id-1">ChimeVoiceConnectorLogging#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ChimeVoiceConnectorLoggingState<'VoiceConnectorId>, value: string) : ChimeVoiceConnectorLoggingState<'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ChimeVoiceConnectorLoggingState<'VoiceConnectorId>

        member _.Run(state: ChimeVoiceConnectorLoggingState<Present>) : aws.ChimeVoiceConnectorLogging.ChimeVoiceConnectorLogging =
            let config = aws.ChimeVoiceConnectorLogging.ChimeVoiceConnectorLoggingConfig()
            for setter in state.assignments do
                setter config
            aws.ChimeVoiceConnectorLogging.ChimeVoiceConnectorLogging(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chimeVoiceConnectorLogging: missing required arguments. Must call: voice_connector_id.", 9999, IsError = true)>]
        member _.Run(_: ChimeVoiceConnectorLoggingState<_>) : aws.ChimeVoiceConnectorLogging.ChimeVoiceConnectorLogging =
            Unchecked.defaultof<aws.ChimeVoiceConnectorLogging.ChimeVoiceConnectorLogging>
