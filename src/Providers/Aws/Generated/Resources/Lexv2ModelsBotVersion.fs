namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Lexv2ModelsBotVersionState<'BotId, 'LocaleSpecification> = { assignments: ResizeArray<aws.Lexv2ModelsBotVersion.Lexv2ModelsBotVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_version">aws_lexv2models_bot_version</a>.
    /// </summary>
    type Lexv2ModelsBotVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : Lexv2ModelsBotVersionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Lexv2ModelsBotVersionState<Missing, Missing>)

        member _.Zero(()) : Lexv2ModelsBotVersionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Lexv2ModelsBotVersionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_version#bot_id-1">Lexv2ModelsBotVersion#bot_id</a>.
        /// </summary>
        [<CustomOperation "bot_id">]
        member _.BotId(state: Lexv2ModelsBotVersionState<Missing, 'LocaleSpecification>, value: string) : Lexv2ModelsBotVersionState<Present, 'LocaleSpecification> =
            state.assignments.Add(fun config -> config.BotId <- value)
            ({ assignments = state.assignments } : Lexv2ModelsBotVersionState<Present, 'LocaleSpecification>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_version#locale_specification-1">Lexv2ModelsBotVersion#locale_specification</a>. Accepts: aws.IResolvable | IDictionary<string, aws.Lexv2ModelsBotVersion.Lexv2ModelsBotVersionLocaleSpecification>
        /// </summary>
        [<CustomOperation "locale_specification">]
        member _.LocaleSpecification(state: Lexv2ModelsBotVersionState<'BotId, Missing>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsBotVersionState<'BotId, Present> =
            state.assignments.Add(fun config -> config.LocaleSpecification <- value)
            ({ assignments = state.assignments } : Lexv2ModelsBotVersionState<'BotId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_version#bot_version-1">Lexv2ModelsBotVersion#bot_version</a>.
        /// </summary>
        [<CustomOperation "bot_version">]
        member _.BotVersion(state: Lexv2ModelsBotVersionState<'BotId, 'LocaleSpecification>, value: string) : Lexv2ModelsBotVersionState<'BotId, 'LocaleSpecification> =
            state.assignments.Add(fun config -> config.BotVersion <- value)
            state : Lexv2ModelsBotVersionState<'BotId, 'LocaleSpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_version#description-1">Lexv2ModelsBotVersion#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Lexv2ModelsBotVersionState<'BotId, 'LocaleSpecification>, value: string) : Lexv2ModelsBotVersionState<'BotId, 'LocaleSpecification> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Lexv2ModelsBotVersionState<'BotId, 'LocaleSpecification>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_version#timeouts-1">Lexv2ModelsBotVersion#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Lexv2ModelsBotVersionState<'BotId, 'LocaleSpecification>, value: aws.Lexv2ModelsBotVersion.Lexv2ModelsBotVersionTimeouts) : Lexv2ModelsBotVersionState<'BotId, 'LocaleSpecification> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Lexv2ModelsBotVersionState<'BotId, 'LocaleSpecification>

        member _.Run(state: Lexv2ModelsBotVersionState<Present, Present>) : aws.Lexv2ModelsBotVersion.Lexv2ModelsBotVersion =
            let config = aws.Lexv2ModelsBotVersion.Lexv2ModelsBotVersionConfig()
            for setter in state.assignments do
                setter config
            aws.Lexv2ModelsBotVersion.Lexv2ModelsBotVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lexv2ModelsBotVersion: missing required arguments. Must call: bot_id, locale_specification.", 9999, IsError = true)>]
        member _.Run(_: Lexv2ModelsBotVersionState<_, _>) : aws.Lexv2ModelsBotVersion.Lexv2ModelsBotVersion =
            Unchecked.defaultof<aws.Lexv2ModelsBotVersion.Lexv2ModelsBotVersion>
