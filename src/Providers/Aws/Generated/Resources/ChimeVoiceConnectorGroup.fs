namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChimeVoiceConnectorGroupState<'Name> = { assignments: ResizeArray<aws.ChimeVoiceConnectorGroup.ChimeVoiceConnectorGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_group">aws_chime_voice_connector_group</a>.
    /// </summary>
    type ChimeVoiceConnectorGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChimeVoiceConnectorGroupState<Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorGroupState<Missing>)

        member _.Zero(()) : ChimeVoiceConnectorGroupState<Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_group#name-1">ChimeVoiceConnectorGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ChimeVoiceConnectorGroupState<Missing>, value: string) : ChimeVoiceConnectorGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ChimeVoiceConnectorGroupState<Present>)

        /// <summary>
        /// connector block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_group#connector-1">ChimeVoiceConnectorGroup#connector</a> Accepts: aws.IResolvable | aws.ChimeVoiceConnectorGroup.ChimeVoiceConnectorGroupConnector[]
        /// </summary>
        [<CustomOperation "connector">]
        member _.Connector(state: ChimeVoiceConnectorGroupState<'Name>, value: HashiCorp.Cdktf.IResolvable) : ChimeVoiceConnectorGroupState<'Name> =
            state.assignments.Add(fun config -> config.Connector <- value)
            state : ChimeVoiceConnectorGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_group#id-1">ChimeVoiceConnectorGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ChimeVoiceConnectorGroupState<'Name>, value: string) : ChimeVoiceConnectorGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ChimeVoiceConnectorGroupState<'Name>

        member _.Run(state: ChimeVoiceConnectorGroupState<Present>) : aws.ChimeVoiceConnectorGroup.ChimeVoiceConnectorGroup =
            let config = aws.ChimeVoiceConnectorGroup.ChimeVoiceConnectorGroupConfig()
            for setter in state.assignments do
                setter config
            aws.ChimeVoiceConnectorGroup.ChimeVoiceConnectorGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chimeVoiceConnectorGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ChimeVoiceConnectorGroupState<_>) : aws.ChimeVoiceConnectorGroup.ChimeVoiceConnectorGroup =
            Unchecked.defaultof<aws.ChimeVoiceConnectorGroup.ChimeVoiceConnectorGroup>
