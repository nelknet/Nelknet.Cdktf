namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name> = { assignments: ResizeArray<aws.Lexv2ModelsSlotType.Lexv2ModelsSlotTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type">aws_lexv2models_slot_type</a>.
    /// </summary>
    type Lexv2ModelsSlotTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : Lexv2ModelsSlotTypeState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Lexv2ModelsSlotTypeState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Lexv2ModelsSlotTypeState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Lexv2ModelsSlotTypeState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#bot_id-1">Lexv2ModelsSlotType#bot_id</a>.
        /// </summary>
        [<CustomOperation "bot_id">]
        member _.BotId(state: Lexv2ModelsSlotTypeState<Missing, 'BotVersion, 'LocaleId, 'Name>, value: string) : Lexv2ModelsSlotTypeState<Present, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.BotId <- value)
            ({ assignments = state.assignments } : Lexv2ModelsSlotTypeState<Present, 'BotVersion, 'LocaleId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#bot_version-1">Lexv2ModelsSlotType#bot_version</a>.
        /// </summary>
        [<CustomOperation "bot_version">]
        member _.BotVersion(state: Lexv2ModelsSlotTypeState<'BotId, Missing, 'LocaleId, 'Name>, value: string) : Lexv2ModelsSlotTypeState<'BotId, Present, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.BotVersion <- value)
            ({ assignments = state.assignments } : Lexv2ModelsSlotTypeState<'BotId, Present, 'LocaleId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#locale_id-1">Lexv2ModelsSlotType#locale_id</a>.
        /// </summary>
        [<CustomOperation "locale_id">]
        member _.LocaleId(state: Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, Missing, 'Name>, value: string) : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, Present, 'Name> =
            state.assignments.Add(fun config -> config.LocaleId <- value)
            ({ assignments = state.assignments } : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#name-1">Lexv2ModelsSlotType#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, Missing>, value: string) : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, Present>)

        /// <summary>
        /// composite_slot_type_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#composite_slot_type_setting-1">Lexv2ModelsSlotType#composite_slot_type_setting</a> Accepts: aws.IResolvable | aws.Lexv2ModelsSlotType.Lexv2ModelsSlotTypeCompositeSlotTypeSetting[]
        /// </summary>
        [<CustomOperation "composite_slot_type_setting">]
        member _.CompositeSlotTypeSetting(state: Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.CompositeSlotTypeSetting <- value)
            state : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#description-1">Lexv2ModelsSlotType#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: string) : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// external_source_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#external_source_setting-1">Lexv2ModelsSlotType#external_source_setting</a> Accepts: aws.IResolvable | aws.Lexv2ModelsSlotType.Lexv2ModelsSlotTypeExternalSourceSetting[]
        /// </summary>
        [<CustomOperation "external_source_setting">]
        member _.ExternalSourceSetting(state: Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.ExternalSourceSetting <- value)
            state : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#parent_slot_type_signature-1">Lexv2ModelsSlotType#parent_slot_type_signature</a>.
        /// </summary>
        [<CustomOperation "parent_slot_type_signature">]
        member _.ParentSlotTypeSignature(state: Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: string) : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.ParentSlotTypeSignature <- value)
            state : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// slot_type_values block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#slot_type_values-1">Lexv2ModelsSlotType#slot_type_values</a> Accepts: aws.IResolvable | aws.Lexv2ModelsSlotType.Lexv2ModelsSlotTypeSlotTypeValues[]
        /// </summary>
        [<CustomOperation "slot_type_values">]
        member _.SlotTypeValues(state: Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.SlotTypeValues <- value)
            state : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#timeouts-1">Lexv2ModelsSlotType#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: aws.Lexv2ModelsSlotType.Lexv2ModelsSlotTypeTimeouts) : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        /// <summary>
        /// value_selection_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#value_selection_setting-1">Lexv2ModelsSlotType#value_selection_setting</a> Accepts: aws.IResolvable | aws.Lexv2ModelsSlotType.Lexv2ModelsSlotTypeValueSelectionSetting[]
        /// </summary>
        [<CustomOperation "value_selection_setting">]
        member _.ValueSelectionSetting(state: Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name> =
            state.assignments.Add(fun config -> config.ValueSelectionSetting <- value)
            state : Lexv2ModelsSlotTypeState<'BotId, 'BotVersion, 'LocaleId, 'Name>

        member _.Run(state: Lexv2ModelsSlotTypeState<Present, Present, Present, Present>) : aws.Lexv2ModelsSlotType.Lexv2ModelsSlotType =
            let config = aws.Lexv2ModelsSlotType.Lexv2ModelsSlotTypeConfig()
            for setter in state.assignments do
                setter config
            aws.Lexv2ModelsSlotType.Lexv2ModelsSlotType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lexv2ModelsSlotType: missing required arguments. Must call: bot_id, bot_version, locale_id, name.", 9999, IsError = true)>]
        member _.Run(_: Lexv2ModelsSlotTypeState<_, _, _, _>) : aws.Lexv2ModelsSlotType.Lexv2ModelsSlotType =
            Unchecked.defaultof<aws.Lexv2ModelsSlotType.Lexv2ModelsSlotType>
