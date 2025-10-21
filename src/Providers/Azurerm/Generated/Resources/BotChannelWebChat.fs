namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotChannelWebChatState<'BotName, 'Location, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.BotChannelWebChat.BotChannelWebChatConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_web_chat">azurerm_bot_channel_web_chat</a>.
    /// </summary>
    type BotChannelWebChatBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotChannelWebChatState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelWebChatState<Missing, Missing, Missing>)

        member _.Zero(()) : BotChannelWebChatState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelWebChatState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_web_chat#bot_name-1">BotChannelWebChat#bot_name</a>.
        /// </summary>
        [<CustomOperation "bot_name">]
        member _.BotName(state: BotChannelWebChatState<Missing, 'Location, 'ResourceGroupName>, value: string) : BotChannelWebChatState<Present, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BotName <- value)
            ({ assignments = state.assignments } : BotChannelWebChatState<Present, 'Location, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_web_chat#location-1">BotChannelWebChat#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotChannelWebChatState<'BotName, Missing, 'ResourceGroupName>, value: string) : BotChannelWebChatState<'BotName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotChannelWebChatState<'BotName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_web_chat#resource_group_name-1">BotChannelWebChat#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotChannelWebChatState<'BotName, 'Location, Missing>, value: string) : BotChannelWebChatState<'BotName, 'Location, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotChannelWebChatState<'BotName, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_web_chat#id-1">BotChannelWebChat#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotChannelWebChatState<'BotName, 'Location, 'ResourceGroupName>, value: string) : BotChannelWebChatState<'BotName, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotChannelWebChatState<'BotName, 'Location, 'ResourceGroupName>

        /// <summary>
        /// site block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_web_chat#site-1">BotChannelWebChat#site</a> Accepts: azurerm.IResolvable | azurerm.BotChannelWebChat.BotChannelWebChatSite[]
        /// </summary>
        [<CustomOperation "site">]
        member _.Site(state: BotChannelWebChatState<'BotName, 'Location, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : BotChannelWebChatState<'BotName, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Site <- value)
            state : BotChannelWebChatState<'BotName, 'Location, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_web_chat#timeouts-1">BotChannelWebChat#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotChannelWebChatState<'BotName, 'Location, 'ResourceGroupName>, value: azurerm.BotChannelWebChat.BotChannelWebChatTimeouts) : BotChannelWebChatState<'BotName, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotChannelWebChatState<'BotName, 'Location, 'ResourceGroupName>

        member _.Run(state: BotChannelWebChatState<Present, Present, Present>) : azurerm.BotChannelWebChat.BotChannelWebChat =
            let config = azurerm.BotChannelWebChat.BotChannelWebChatConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotChannelWebChat.BotChannelWebChat(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botChannelWebChat: missing required arguments. Must call: bot_name, location, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: BotChannelWebChatState<_, _, _>) : azurerm.BotChannelWebChat.BotChannelWebChat =
            Unchecked.defaultof<azurerm.BotChannelWebChat.BotChannelWebChat>
