namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId> = { assignments: ResizeArray<aws.ChimeVoiceConnectorTermination.ChimeVoiceConnectorTerminationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_termination">aws_chime_voice_connector_termination</a>.
    /// </summary>
    type ChimeVoiceConnectorTerminationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChimeVoiceConnectorTerminationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorTerminationState<Missing, Missing, Missing>)

        member _.Zero(()) : ChimeVoiceConnectorTerminationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorTerminationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_termination#calling_regions-1">ChimeVoiceConnectorTermination#calling_regions</a>.
        /// </summary>
        [<CustomOperation "calling_regions">]
        member _.CallingRegions(state: ChimeVoiceConnectorTerminationState<Missing, 'CidrAllowList, 'VoiceConnectorId>, value: seq<string>) : ChimeVoiceConnectorTerminationState<Present, 'CidrAllowList, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.CallingRegions <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ChimeVoiceConnectorTerminationState<Present, 'CidrAllowList, 'VoiceConnectorId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_termination#cidr_allow_list-1">ChimeVoiceConnectorTermination#cidr_allow_list</a>.
        /// </summary>
        [<CustomOperation "cidr_allow_list">]
        member _.CidrAllowList(state: ChimeVoiceConnectorTerminationState<'CallingRegions, Missing, 'VoiceConnectorId>, value: seq<string>) : ChimeVoiceConnectorTerminationState<'CallingRegions, Present, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.CidrAllowList <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ChimeVoiceConnectorTerminationState<'CallingRegions, Present, 'VoiceConnectorId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_termination#voice_connector_id-1">ChimeVoiceConnectorTermination#voice_connector_id</a>.
        /// </summary>
        [<CustomOperation "voice_connector_id">]
        member _.VoiceConnectorId(state: ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, Missing>, value: string) : ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, Present> =
            state.assignments.Add(fun config -> config.VoiceConnectorId <- value)
            ({ assignments = state.assignments } : ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_termination#cps_limit-1">ChimeVoiceConnectorTermination#cps_limit</a>.
        /// </summary>
        [<CustomOperation "cps_limit">]
        member _.CpsLimit(state: ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId>, value: double) : ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.CpsLimit <- value)
            state : ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_termination#default_phone_number-1">ChimeVoiceConnectorTermination#default_phone_number</a>.
        /// </summary>
        [<CustomOperation "default_phone_number">]
        member _.DefaultPhoneNumber(state: ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId>, value: string) : ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.DefaultPhoneNumber <- value)
            state : ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_termination#disabled-1">ChimeVoiceConnectorTermination#disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disabled">]
        member _.Disabled(state: ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId>, value: bool) : ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.Disabled <- value)
            state : ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_termination#disabled-1">ChimeVoiceConnectorTermination#disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disabled">]
        member _.Disabled(state: ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId>, value: HashiCorp.Cdktf.IResolvable) : ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.Disabled <- value)
            state : ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_termination#id-1">ChimeVoiceConnectorTermination#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId>, value: string) : ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ChimeVoiceConnectorTerminationState<'CallingRegions, 'CidrAllowList, 'VoiceConnectorId>

        member _.Run(state: ChimeVoiceConnectorTerminationState<Present, Present, Present>) : aws.ChimeVoiceConnectorTermination.ChimeVoiceConnectorTermination =
            let config = aws.ChimeVoiceConnectorTermination.ChimeVoiceConnectorTerminationConfig()
            for setter in state.assignments do
                setter config
            aws.ChimeVoiceConnectorTermination.ChimeVoiceConnectorTermination(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chimeVoiceConnectorTermination: missing required arguments. Must call: calling_regions, cidr_allow_list, voice_connector_id.", 9999, IsError = true)>]
        member _.Run(_: ChimeVoiceConnectorTerminationState<_, _, _>) : aws.ChimeVoiceConnectorTermination.ChimeVoiceConnectorTermination =
            Unchecked.defaultof<aws.ChimeVoiceConnectorTermination.ChimeVoiceConnectorTermination>
