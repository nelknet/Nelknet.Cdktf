namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChimeVoiceConnectorTerminationCredentialsState<'Credentials, 'VoiceConnectorId> = { assignments: ResizeArray<aws.ChimeVoiceConnectorTerminationCredentials.ChimeVoiceConnectorTerminationCredentialsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_termination_credentials">aws_chime_voice_connector_termination_credentials</a>.
    /// </summary>
    type ChimeVoiceConnectorTerminationCredentialsBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChimeVoiceConnectorTerminationCredentialsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorTerminationCredentialsState<Missing, Missing>)

        member _.Zero(()) : ChimeVoiceConnectorTerminationCredentialsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorTerminationCredentialsState<Missing, Missing>)

        /// <summary>
        /// credentials block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_termination_credentials#credentials-1">ChimeVoiceConnectorTerminationCredentials#credentials</a> Accepts: aws.IResolvable | aws.ChimeVoiceConnectorTerminationCredentials.ChimeVoiceConnectorTerminationCredentialsCredentials[]
        /// </summary>
        [<CustomOperation "credentials">]
        member _.Credentials(state: ChimeVoiceConnectorTerminationCredentialsState<Missing, 'VoiceConnectorId>, value: HashiCorp.Cdktf.IResolvable) : ChimeVoiceConnectorTerminationCredentialsState<Present, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.Credentials <- value)
            ({ assignments = state.assignments } : ChimeVoiceConnectorTerminationCredentialsState<Present, 'VoiceConnectorId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_termination_credentials#voice_connector_id-1">ChimeVoiceConnectorTerminationCredentials#voice_connector_id</a>.
        /// </summary>
        [<CustomOperation "voice_connector_id">]
        member _.VoiceConnectorId(state: ChimeVoiceConnectorTerminationCredentialsState<'Credentials, Missing>, value: string) : ChimeVoiceConnectorTerminationCredentialsState<'Credentials, Present> =
            state.assignments.Add(fun config -> config.VoiceConnectorId <- value)
            ({ assignments = state.assignments } : ChimeVoiceConnectorTerminationCredentialsState<'Credentials, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_termination_credentials#id-1">ChimeVoiceConnectorTerminationCredentials#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ChimeVoiceConnectorTerminationCredentialsState<'Credentials, 'VoiceConnectorId>, value: string) : ChimeVoiceConnectorTerminationCredentialsState<'Credentials, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ChimeVoiceConnectorTerminationCredentialsState<'Credentials, 'VoiceConnectorId>

        member _.Run(state: ChimeVoiceConnectorTerminationCredentialsState<Present, Present>) : aws.ChimeVoiceConnectorTerminationCredentials.ChimeVoiceConnectorTerminationCredentials =
            let config = aws.ChimeVoiceConnectorTerminationCredentials.ChimeVoiceConnectorTerminationCredentialsConfig()
            for setter in state.assignments do
                setter config
            aws.ChimeVoiceConnectorTerminationCredentials.ChimeVoiceConnectorTerminationCredentials(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chimeVoiceConnectorTerminationCredentials: missing required arguments. Must call: credentials, voice_connector_id.", 9999, IsError = true)>]
        member _.Run(_: ChimeVoiceConnectorTerminationCredentialsState<_, _>) : aws.ChimeVoiceConnectorTerminationCredentials.ChimeVoiceConnectorTerminationCredentials =
            Unchecked.defaultof<aws.ChimeVoiceConnectorTerminationCredentials.ChimeVoiceConnectorTerminationCredentials>
