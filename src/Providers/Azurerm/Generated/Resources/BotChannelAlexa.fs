namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotChannelAlexaState<'BotName, 'Location, 'ResourceGroupName, 'SkillId> = { assignments: ResizeArray<azurerm.BotChannelAlexa.BotChannelAlexaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_alexa">azurerm_bot_channel_alexa</a>.
    /// </summary>
    type BotChannelAlexaBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotChannelAlexaState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelAlexaState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BotChannelAlexaState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelAlexaState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_alexa#bot_name-1">BotChannelAlexa#bot_name</a>.
        /// </summary>
        [<CustomOperation "bot_name">]
        member _.BotName(state: BotChannelAlexaState<Missing, 'Location, 'ResourceGroupName, 'SkillId>, value: string) : BotChannelAlexaState<Present, 'Location, 'ResourceGroupName, 'SkillId> =
            state.assignments.Add(fun config -> config.BotName <- value)
            ({ assignments = state.assignments } : BotChannelAlexaState<Present, 'Location, 'ResourceGroupName, 'SkillId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_alexa#location-1">BotChannelAlexa#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotChannelAlexaState<'BotName, Missing, 'ResourceGroupName, 'SkillId>, value: string) : BotChannelAlexaState<'BotName, Present, 'ResourceGroupName, 'SkillId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotChannelAlexaState<'BotName, Present, 'ResourceGroupName, 'SkillId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_alexa#resource_group_name-1">BotChannelAlexa#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotChannelAlexaState<'BotName, 'Location, Missing, 'SkillId>, value: string) : BotChannelAlexaState<'BotName, 'Location, Present, 'SkillId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotChannelAlexaState<'BotName, 'Location, Present, 'SkillId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_alexa#skill_id-1">BotChannelAlexa#skill_id</a>.
        /// </summary>
        [<CustomOperation "skill_id">]
        member _.SkillId(state: BotChannelAlexaState<'BotName, 'Location, 'ResourceGroupName, Missing>, value: string) : BotChannelAlexaState<'BotName, 'Location, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkillId <- value)
            ({ assignments = state.assignments } : BotChannelAlexaState<'BotName, 'Location, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_alexa#id-1">BotChannelAlexa#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotChannelAlexaState<'BotName, 'Location, 'ResourceGroupName, 'SkillId>, value: string) : BotChannelAlexaState<'BotName, 'Location, 'ResourceGroupName, 'SkillId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotChannelAlexaState<'BotName, 'Location, 'ResourceGroupName, 'SkillId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_alexa#timeouts-1">BotChannelAlexa#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotChannelAlexaState<'BotName, 'Location, 'ResourceGroupName, 'SkillId>, value: azurerm.BotChannelAlexa.BotChannelAlexaTimeouts) : BotChannelAlexaState<'BotName, 'Location, 'ResourceGroupName, 'SkillId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotChannelAlexaState<'BotName, 'Location, 'ResourceGroupName, 'SkillId>

        member _.Run(state: BotChannelAlexaState<Present, Present, Present, Present>) : azurerm.BotChannelAlexa.BotChannelAlexa =
            let config = azurerm.BotChannelAlexa.BotChannelAlexaConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotChannelAlexa.BotChannelAlexa(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botChannelAlexa: missing required arguments. Must call: bot_name, location, resource_group_name, skill_id.", 9999, IsError = true)>]
        member _.Run(_: BotChannelAlexaState<_, _, _, _>) : azurerm.BotChannelAlexa.BotChannelAlexa =
            Unchecked.defaultof<azurerm.BotChannelAlexa.BotChannelAlexa>
