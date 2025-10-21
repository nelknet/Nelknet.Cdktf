namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> = { assignments: ResizeArray<aws.Lexv2ModelsIntent.Lexv2ModelsIntentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent">aws_lexv2models_intent</a>.
    /// </summary>
    type Lexv2ModelsIntentBuilder(logicalId: string) =
        member _.Yield(_: unit) : Lexv2ModelsIntentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Lexv2ModelsIntentState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Lexv2ModelsIntentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Lexv2ModelsIntentState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#bot_id-1">Lexv2ModelsIntent#bot_id</a>.
        /// </summary>
        [<CustomOperation "bot_id">]
        member _.BotId(state: Lexv2ModelsIntentState<Missing, 'BotVersion, 'LocaleId, 'Name>, value: string) : Lexv2ModelsIntentState<Present, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.BotId <- value)
            ({ assignments = state.assignments } : Lexv2ModelsIntentState<Present, 'BotVersion, 'LocaleId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#bot_version-1">Lexv2ModelsIntent#bot_version</a>.
        /// </summary>
        [<CustomOperation "bot_version">]
        member _.BotVersion(state: Lexv2ModelsIntentState<'BotId, Missing, 'LocaleId, 'Name>, value: string) : Lexv2ModelsIntentState<'BotId, Present, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.BotVersion <- value)
            ({ assignments = state.assignments } : Lexv2ModelsIntentState<'BotId, Present, 'LocaleId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#locale_id-1">Lexv2ModelsIntent#locale_id</a>.
        /// </summary>
        [<CustomOperation "locale_id">]
        member _.LocaleId(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, Missing, 'Name>, value: string) : Lexv2ModelsIntentState<'BotId, 'BotVersion, Present, 'Name> =
            state.assignments.Add(fun config -> config.LocaleId <- value)
            ({ assignments = state.assignments } : Lexv2ModelsIntentState<'BotId, 'BotVersion, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#name-1">Lexv2ModelsIntent#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, Missing>, value: string) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, Present>)

        /// <summary>
        /// closing_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#closing_setting-1">Lexv2ModelsIntent#closing_setting</a> Accepts: aws.IResolvable | aws.Lexv2ModelsIntent.Lexv2ModelsIntentClosingSetting[]
        /// </summary>
        [<CustomOperation "closing_setting">]
        member _.ClosingSetting(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.ClosingSetting <- value)
            state : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// confirmation_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#confirmation_setting-1">Lexv2ModelsIntent#confirmation_setting</a> Accepts: aws.IResolvable | aws.Lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSetting[]
        /// </summary>
        [<CustomOperation "confirmation_setting">]
        member _.ConfirmationSetting(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.ConfirmationSetting <- value)
            state : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#description-1">Lexv2ModelsIntent#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: string) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// dialog_code_hook block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#dialog_code_hook-1">Lexv2ModelsIntent#dialog_code_hook</a> Accepts: aws.IResolvable | aws.Lexv2ModelsIntent.Lexv2ModelsIntentDialogCodeHook[]
        /// </summary>
        [<CustomOperation "dialog_code_hook">]
        member _.DialogCodeHook(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.DialogCodeHook <- value)
            state : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// fulfillment_code_hook block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#fulfillment_code_hook-1">Lexv2ModelsIntent#fulfillment_code_hook</a> Accepts: aws.IResolvable | aws.Lexv2ModelsIntent.Lexv2ModelsIntentFulfillmentCodeHook[]
        /// </summary>
        [<CustomOperation "fulfillment_code_hook">]
        member _.FulfillmentCodeHook(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.FulfillmentCodeHook <- value)
            state : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// initial_response_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#initial_response_setting-1">Lexv2ModelsIntent#initial_response_setting</a> Accepts: aws.IResolvable | aws.Lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSetting[]
        /// </summary>
        [<CustomOperation "initial_response_setting">]
        member _.InitialResponseSetting(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.InitialResponseSetting <- value)
            state : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// input_context block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#input_context-1">Lexv2ModelsIntent#input_context</a> Accepts: aws.IResolvable | aws.Lexv2ModelsIntent.Lexv2ModelsIntentInputContext[]
        /// </summary>
        [<CustomOperation "input_context">]
        member _.InputContext(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.InputContext <- value)
            state : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// kendra_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#kendra_configuration-1">Lexv2ModelsIntent#kendra_configuration</a> Accepts: aws.IResolvable | aws.Lexv2ModelsIntent.Lexv2ModelsIntentKendraConfiguration[]
        /// </summary>
        [<CustomOperation "kendra_configuration">]
        member _.KendraConfiguration(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.KendraConfiguration <- value)
            state : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// output_context block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#output_context-1">Lexv2ModelsIntent#output_context</a> Accepts: aws.IResolvable | aws.Lexv2ModelsIntent.Lexv2ModelsIntentOutputContext[]
        /// </summary>
        [<CustomOperation "output_context">]
        member _.OutputContext(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.OutputContext <- value)
            state : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#parent_intent_signature-1">Lexv2ModelsIntent#parent_intent_signature</a>.
        /// </summary>
        [<CustomOperation "parent_intent_signature">]
        member _.ParentIntentSignature(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: string) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.ParentIntentSignature <- value)
            state : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// sample_utterance block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#sample_utterance-1">Lexv2ModelsIntent#sample_utterance</a> Accepts: aws.IResolvable | aws.Lexv2ModelsIntent.Lexv2ModelsIntentSampleUtterance[]
        /// </summary>
        [<CustomOperation "sample_utterance">]
        member _.SampleUtterance(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.SampleUtterance <- value)
            state : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// slot_priority block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#slot_priority-1">Lexv2ModelsIntent#slot_priority</a> Accepts: aws.IResolvable | aws.Lexv2ModelsIntent.Lexv2ModelsIntentSlotPriority[]
        /// </summary>
        [<CustomOperation "slot_priority">]
        member _.SlotPriority(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.SlotPriority <- value)
            state : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#timeouts-1">Lexv2ModelsIntent#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: aws.Lexv2ModelsIntent.Lexv2ModelsIntentTimeouts) : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Lexv2ModelsIntentState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        member _.Run(state: Lexv2ModelsIntentState<Present, Present, Present, Present>) : aws.Lexv2ModelsIntent.Lexv2ModelsIntent =
            let config = aws.Lexv2ModelsIntent.Lexv2ModelsIntentConfig()
            for setter in state.assignments do
                setter config
            aws.Lexv2ModelsIntent.Lexv2ModelsIntent(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lexv2ModelsIntent: missing required arguments. Must call: bot_id, bot_version, locale_id, name.", 9999, IsError = true)>]
        member _.Run(_: Lexv2ModelsIntentState<_, _, _, _>) : aws.Lexv2ModelsIntent.Lexv2ModelsIntent =
            Unchecked.defaultof<aws.Lexv2ModelsIntent.Lexv2ModelsIntent>
