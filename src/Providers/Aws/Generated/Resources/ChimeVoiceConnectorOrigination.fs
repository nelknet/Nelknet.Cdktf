namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChimeVoiceConnectorOriginationState<'Route, 'VoiceConnectorId> = { assignments: ResizeArray<aws.ChimeVoiceConnectorOrigination.ChimeVoiceConnectorOriginationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_origination">aws_chime_voice_connector_origination</a>.
    /// </summary>
    type ChimeVoiceConnectorOriginationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChimeVoiceConnectorOriginationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorOriginationState<Missing, Missing>)

        member _.Zero(()) : ChimeVoiceConnectorOriginationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorOriginationState<Missing, Missing>)

        /// <summary>
        /// route block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_origination#route-1">ChimeVoiceConnectorOrigination#route</a> Accepts: aws.IResolvable | aws.ChimeVoiceConnectorOrigination.ChimeVoiceConnectorOriginationRoute[]
        /// </summary>
        [<CustomOperation "route">]
        member _.Route(state: ChimeVoiceConnectorOriginationState<Missing, 'VoiceConnectorId>, value: HashiCorp.Cdktf.IResolvable) : ChimeVoiceConnectorOriginationState<Present, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.Route <- value)
            ({ assignments = state.assignments } : ChimeVoiceConnectorOriginationState<Present, 'VoiceConnectorId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_origination#voice_connector_id-1">ChimeVoiceConnectorOrigination#voice_connector_id</a>.
        /// </summary>
        [<CustomOperation "voice_connector_id">]
        member _.VoiceConnectorId(state: ChimeVoiceConnectorOriginationState<'Route, Missing>, value: string) : ChimeVoiceConnectorOriginationState<'Route, Present> =
            state.assignments.Add(fun config -> config.VoiceConnectorId <- value)
            ({ assignments = state.assignments } : ChimeVoiceConnectorOriginationState<'Route, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_origination#disabled-1">ChimeVoiceConnectorOrigination#disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disabled">]
        member _.Disabled(state: ChimeVoiceConnectorOriginationState<'Route, 'VoiceConnectorId>, value: bool) : ChimeVoiceConnectorOriginationState<'Route, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.Disabled <- value)
            state : ChimeVoiceConnectorOriginationState<'Route, 'VoiceConnectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_origination#disabled-1">ChimeVoiceConnectorOrigination#disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disabled">]
        member _.Disabled(state: ChimeVoiceConnectorOriginationState<'Route, 'VoiceConnectorId>, value: HashiCorp.Cdktf.IResolvable) : ChimeVoiceConnectorOriginationState<'Route, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.Disabled <- value)
            state : ChimeVoiceConnectorOriginationState<'Route, 'VoiceConnectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_origination#id-1">ChimeVoiceConnectorOrigination#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ChimeVoiceConnectorOriginationState<'Route, 'VoiceConnectorId>, value: string) : ChimeVoiceConnectorOriginationState<'Route, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ChimeVoiceConnectorOriginationState<'Route, 'VoiceConnectorId>

        member _.Run(state: ChimeVoiceConnectorOriginationState<Present, Present>) : aws.ChimeVoiceConnectorOrigination.ChimeVoiceConnectorOrigination =
            let config = aws.ChimeVoiceConnectorOrigination.ChimeVoiceConnectorOriginationConfig()
            for setter in state.assignments do
                setter config
            aws.ChimeVoiceConnectorOrigination.ChimeVoiceConnectorOrigination(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chimeVoiceConnectorOrigination: missing required arguments. Must call: route, voice_connector_id.", 9999, IsError = true)>]
        member _.Run(_: ChimeVoiceConnectorOriginationState<_, _>) : aws.ChimeVoiceConnectorOrigination.ChimeVoiceConnectorOrigination =
            Unchecked.defaultof<aws.ChimeVoiceConnectorOrigination.ChimeVoiceConnectorOrigination>
