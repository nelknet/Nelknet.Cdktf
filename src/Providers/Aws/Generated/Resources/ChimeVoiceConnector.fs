namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChimeVoiceConnectorState<'Name, 'RequireEncryption> = { assignments: ResizeArray<aws.ChimeVoiceConnector.ChimeVoiceConnectorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector">aws_chime_voice_connector</a>.
    /// </summary>
    type ChimeVoiceConnectorBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChimeVoiceConnectorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorState<Missing, Missing>)

        member _.Zero(()) : ChimeVoiceConnectorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimeVoiceConnectorState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector#name-1">ChimeVoiceConnector#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ChimeVoiceConnectorState<Missing, 'RequireEncryption>, value: string) : ChimeVoiceConnectorState<Present, 'RequireEncryption> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ChimeVoiceConnectorState<Present, 'RequireEncryption>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector#require_encryption-1">ChimeVoiceConnector#require_encryption</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_encryption">]
        member _.RequireEncryption(state: ChimeVoiceConnectorState<'Name, Missing>, value: bool) : ChimeVoiceConnectorState<'Name, Present> =
            state.assignments.Add(fun config -> config.RequireEncryption <- value)
            ({ assignments = state.assignments } : ChimeVoiceConnectorState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector#require_encryption-1">ChimeVoiceConnector#require_encryption</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "require_encryption">]
        member _.RequireEncryption(state: ChimeVoiceConnectorState<'Name, Missing>, value: HashiCorp.Cdktf.IResolvable) : ChimeVoiceConnectorState<'Name, Present> =
            state.assignments.Add(fun config -> config.RequireEncryption <- value)
            ({ assignments = state.assignments } : ChimeVoiceConnectorState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector#aws_region-1">ChimeVoiceConnector#aws_region</a>.
        /// </summary>
        [<CustomOperation "aws_region">]
        member _.AwsRegion(state: ChimeVoiceConnectorState<'Name, 'RequireEncryption>, value: string) : ChimeVoiceConnectorState<'Name, 'RequireEncryption> =
            state.assignments.Add(fun config -> config.AwsRegion <- value)
            state : ChimeVoiceConnectorState<'Name, 'RequireEncryption>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector#id-1">ChimeVoiceConnector#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ChimeVoiceConnectorState<'Name, 'RequireEncryption>, value: string) : ChimeVoiceConnectorState<'Name, 'RequireEncryption> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ChimeVoiceConnectorState<'Name, 'RequireEncryption>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector#tags-1">ChimeVoiceConnector#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ChimeVoiceConnectorState<'Name, 'RequireEncryption>, value: seq<string * string>) : ChimeVoiceConnectorState<'Name, 'RequireEncryption> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ChimeVoiceConnectorState<'Name, 'RequireEncryption>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector#tags_all-1">ChimeVoiceConnector#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ChimeVoiceConnectorState<'Name, 'RequireEncryption>, value: seq<string * string>) : ChimeVoiceConnectorState<'Name, 'RequireEncryption> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ChimeVoiceConnectorState<'Name, 'RequireEncryption>

        member _.Run(state: ChimeVoiceConnectorState<Present, Present>) : aws.ChimeVoiceConnector.ChimeVoiceConnector =
            let config = aws.ChimeVoiceConnector.ChimeVoiceConnectorConfig()
            for setter in state.assignments do
                setter config
            aws.ChimeVoiceConnector.ChimeVoiceConnector(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chimeVoiceConnector: missing required arguments. Must call: name, require_encryption.", 9999, IsError = true)>]
        member _.Run(_: ChimeVoiceConnectorState<_, _>) : aws.ChimeVoiceConnector.ChimeVoiceConnector =
            Unchecked.defaultof<aws.ChimeVoiceConnector.ChimeVoiceConnector>
