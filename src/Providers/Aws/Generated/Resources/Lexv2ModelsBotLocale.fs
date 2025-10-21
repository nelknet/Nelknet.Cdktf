namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold> = { assignments: ResizeArray<aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocaleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale">aws_lexv2models_bot_locale</a>.
    /// </summary>
    type Lexv2ModelsBotLocaleBuilder(logicalId: string) =
        member _.Yield(_: unit) : Lexv2ModelsBotLocaleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Lexv2ModelsBotLocaleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Lexv2ModelsBotLocaleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Lexv2ModelsBotLocaleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#bot_id-1">Lexv2ModelsBotLocale#bot_id</a>.
        /// </summary>
        [<CustomOperation "bot_id">]
        member _.BotId(state: Lexv2ModelsBotLocaleState<Missing, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold>, value: string) : Lexv2ModelsBotLocaleState<Present, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold> =
            state.assignments.Add(fun config -> config.BotId <- value)
            ({ assignments = state.assignments } : Lexv2ModelsBotLocaleState<Present, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#bot_version-1">Lexv2ModelsBotLocale#bot_version</a>.
        /// </summary>
        [<CustomOperation "bot_version">]
        member _.BotVersion(state: Lexv2ModelsBotLocaleState<'BotId, Missing, 'LocaleId, 'NLuIntentConfidenceThreshold>, value: string) : Lexv2ModelsBotLocaleState<'BotId, Present, 'LocaleId, 'NLuIntentConfidenceThreshold> =
            state.assignments.Add(fun config -> config.BotVersion <- value)
            ({ assignments = state.assignments } : Lexv2ModelsBotLocaleState<'BotId, Present, 'LocaleId, 'NLuIntentConfidenceThreshold>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#locale_id-1">Lexv2ModelsBotLocale#locale_id</a>.
        /// </summary>
        [<CustomOperation "locale_id">]
        member _.LocaleId(state: Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, Missing, 'NLuIntentConfidenceThreshold>, value: string) : Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, Present, 'NLuIntentConfidenceThreshold> =
            state.assignments.Add(fun config -> config.LocaleId <- value)
            ({ assignments = state.assignments } : Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, Present, 'NLuIntentConfidenceThreshold>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#n_lu_intent_confidence_threshold-1">Lexv2ModelsBotLocale#n_lu_intent_confidence_threshold</a>.
        /// </summary>
        [<CustomOperation "n_lu_intent_confidence_threshold">]
        member _.NLuIntentConfidenceThreshold(state: Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, Missing>, value: double) : Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, Present> =
            state.assignments.Add(fun config -> config.NLuIntentConfidenceThreshold <- value)
            ({ assignments = state.assignments } : Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#description-1">Lexv2ModelsBotLocale#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold>, value: string) : Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#name-1">Lexv2ModelsBotLocale#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold>, value: string) : Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#timeouts-1">Lexv2ModelsBotLocale#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold>, value: aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocaleTimeouts) : Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold>

        /// <summary>
        /// voice_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#voice_settings-1">Lexv2ModelsBotLocale#voice_settings</a> Accepts: aws.IResolvable | aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocaleVoiceSettings[]
        /// </summary>
        [<CustomOperation "voice_settings">]
        member _.VoiceSettings(state: Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold> =
            state.assignments.Add(fun config -> config.VoiceSettings <- value)
            state : Lexv2ModelsBotLocaleState<'BotId, 'BotVersion, 'LocaleId, 'NLuIntentConfidenceThreshold>

        member _.Run(state: Lexv2ModelsBotLocaleState<Present, Present, Present, Present>) : aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocale =
            let config = aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocaleConfig()
            for setter in state.assignments do
                setter config
            aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocale(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lexv2ModelsBotLocale: missing required arguments. Must call: bot_id, bot_version, locale_id, n_lu_intent_confidence_threshold.", 9999, IsError = true)>]
        member _.Run(_: Lexv2ModelsBotLocaleState<_, _, _, _>) : aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocale =
            Unchecked.defaultof<aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocale>
