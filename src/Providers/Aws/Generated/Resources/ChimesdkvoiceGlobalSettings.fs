namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChimesdkvoiceGlobalSettingsState<'VoiceConnector> = { assignments: ResizeArray<aws.ChimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_global_settings">aws_chimesdkvoice_global_settings</a>.
    /// </summary>
    type ChimesdkvoiceGlobalSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChimesdkvoiceGlobalSettingsState<Missing> =
            ({ assignments = ResizeArray() } : ChimesdkvoiceGlobalSettingsState<Missing>)

        member _.Zero(()) : ChimesdkvoiceGlobalSettingsState<Missing> =
            ({ assignments = ResizeArray() } : ChimesdkvoiceGlobalSettingsState<Missing>)

        /// <summary>
        /// voice_connector block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_global_settings#voice_connector-1">ChimesdkvoiceGlobalSettings#voice_connector</a>
        /// </summary>
        [<CustomOperation "voice_connector">]
        member _.VoiceConnector(state: ChimesdkvoiceGlobalSettingsState<Missing>, value: aws.ChimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsVoiceConnector) : ChimesdkvoiceGlobalSettingsState<Present> =
            state.assignments.Add(fun config -> config.VoiceConnector <- value)
            ({ assignments = state.assignments } : ChimesdkvoiceGlobalSettingsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_global_settings#id-1">ChimesdkvoiceGlobalSettings#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ChimesdkvoiceGlobalSettingsState<'VoiceConnector>, value: string) : ChimesdkvoiceGlobalSettingsState<'VoiceConnector> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ChimesdkvoiceGlobalSettingsState<'VoiceConnector>

        member _.Run(state: ChimesdkvoiceGlobalSettingsState<Present>) : aws.ChimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettings =
            let config = aws.ChimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.ChimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettings(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chimesdkvoiceGlobalSettings: missing required arguments. Must call: voice_connector.", 9999, IsError = true)>]
        member _.Run(_: ChimesdkvoiceGlobalSettingsState<_>) : aws.ChimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettings =
            Unchecked.defaultof<aws.ChimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettings>
