namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name> = { assignments: ResizeArray<aws.Lexv2ModelsSlot.Lexv2ModelsSlotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot">aws_lexv2models_slot</a>.
    /// </summary>
    type Lexv2ModelsSlotBuilder(logicalId: string) =
        member _.Yield(_: unit) : Lexv2ModelsSlotState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Lexv2ModelsSlotState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Lexv2ModelsSlotState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Lexv2ModelsSlotState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#bot_id-1">Lexv2ModelsSlot#bot_id</a>.
        /// </summary>
        [<CustomOperation "bot_id">]
        member _.BotId(state: Lexv2ModelsSlotState<Missing, 'BotVersion, 'IntentId, 'LocaleId, 'Name>, value: string) : Lexv2ModelsSlotState<Present, 'BotVersion, 'IntentId, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.BotId <- value)
            ({ assignments = state.assignments } : Lexv2ModelsSlotState<Present, 'BotVersion, 'IntentId, 'LocaleId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#bot_version-1">Lexv2ModelsSlot#bot_version</a>.
        /// </summary>
        [<CustomOperation "bot_version">]
        member _.BotVersion(state: Lexv2ModelsSlotState<'BotId, Missing, 'IntentId, 'LocaleId, 'Name>, value: string) : Lexv2ModelsSlotState<'BotId, Present, 'IntentId, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.BotVersion <- value)
            ({ assignments = state.assignments } : Lexv2ModelsSlotState<'BotId, Present, 'IntentId, 'LocaleId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#intent_id-1">Lexv2ModelsSlot#intent_id</a>.
        /// </summary>
        [<CustomOperation "intent_id">]
        member _.IntentId(state: Lexv2ModelsSlotState<'BotId, 'BotVersion, Missing, 'LocaleId, 'Name>, value: string) : Lexv2ModelsSlotState<'BotId, 'BotVersion, Present, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.IntentId <- value)
            ({ assignments = state.assignments } : Lexv2ModelsSlotState<'BotId, 'BotVersion, Present, 'LocaleId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#locale_id-1">Lexv2ModelsSlot#locale_id</a>.
        /// </summary>
        [<CustomOperation "locale_id">]
        member _.LocaleId(state: Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, Missing, 'Name>, value: string) : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LocaleId <- value)
            ({ assignments = state.assignments } : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#name-1">Lexv2ModelsSlot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, Missing>, value: string) : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#description-1">Lexv2ModelsSlot#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>, value: string) : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>

        /// <summary>
        /// multiple_values_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#multiple_values_setting-1">Lexv2ModelsSlot#multiple_values_setting</a> Accepts: aws.IResolvable | aws.Lexv2ModelsSlot.Lexv2ModelsSlotMultipleValuesSetting[]
        /// </summary>
        [<CustomOperation "multiple_values_setting">]
        member _.MultipleValuesSetting(state: Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.MultipleValuesSetting <- value)
            state : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>

        /// <summary>
        /// obfuscation_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#obfuscation_setting-1">Lexv2ModelsSlot#obfuscation_setting</a> Accepts: aws.IResolvable | aws.Lexv2ModelsSlot.Lexv2ModelsSlotObfuscationSetting[]
        /// </summary>
        [<CustomOperation "obfuscation_setting">]
        member _.ObfuscationSetting(state: Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.ObfuscationSetting <- value)
            state : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#slot_type_id-1">Lexv2ModelsSlot#slot_type_id</a>.
        /// </summary>
        [<CustomOperation "slot_type_id">]
        member _.SlotTypeId(state: Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>, value: string) : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.SlotTypeId <- value)
            state : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>

        /// <summary>
        /// sub_slot_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#sub_slot_setting-1">Lexv2ModelsSlot#sub_slot_setting</a> Accepts: aws.IResolvable | aws.Lexv2ModelsSlot.Lexv2ModelsSlotSubSlotSetting[]
        /// </summary>
        [<CustomOperation "sub_slot_setting">]
        member _.SubSlotSetting(state: Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.SubSlotSetting <- value)
            state : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#timeouts-1">Lexv2ModelsSlot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>, value: aws.Lexv2ModelsSlot.Lexv2ModelsSlotTimeouts) : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>

        /// <summary>
        /// value_elicitation_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#value_elicitation_setting-1">Lexv2ModelsSlot#value_elicitation_setting</a> Accepts: aws.IResolvable | aws.Lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSetting[]
        /// </summary>
        [<CustomOperation "value_elicitation_setting">]
        member _.ValueElicitationSetting(state: Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.ValueElicitationSetting <- value)
            state : Lexv2ModelsSlotState<'BotId, 'BotVersion, 'IntentId, 'LocaleId, 'Name>

        member _.Run(state: Lexv2ModelsSlotState<Present, Present, Present, Present, Present>) : aws.Lexv2ModelsSlot.Lexv2ModelsSlot =
            let config = aws.Lexv2ModelsSlot.Lexv2ModelsSlotConfig()
            for setter in state.assignments do
                setter config
            aws.Lexv2ModelsSlot.Lexv2ModelsSlot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lexv2ModelsSlot: missing required arguments. Must call: bot_id, bot_version, intent_id, locale_id, name.", 9999, IsError = true)>]
        member _.Run(_: Lexv2ModelsSlotState<_, _, _, _, _>) : aws.Lexv2ModelsSlot.Lexv2ModelsSlot =
            Unchecked.defaultof<aws.Lexv2ModelsSlot.Lexv2ModelsSlot>
