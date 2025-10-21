namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotChannelDirectlineState<'BotName, 'Location, 'ResourceGroupName, 'Site> = { assignments: ResizeArray<azurerm.BotChannelDirectline.BotChannelDirectlineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_directline">azurerm_bot_channel_directline</a>.
    /// </summary>
    type BotChannelDirectlineBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotChannelDirectlineState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelDirectlineState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BotChannelDirectlineState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelDirectlineState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_directline#bot_name-1">BotChannelDirectline#bot_name</a>.
        /// </summary>
        [<CustomOperation "bot_name">]
        member _.BotName(state: BotChannelDirectlineState<Missing, 'Location, 'ResourceGroupName, 'Site>, value: string) : BotChannelDirectlineState<Present, 'Location, 'ResourceGroupName, 'Site> =
            state.assignments.Add(fun config -> config.BotName <- value)
            ({ assignments = state.assignments } : BotChannelDirectlineState<Present, 'Location, 'ResourceGroupName, 'Site>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_directline#location-1">BotChannelDirectline#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotChannelDirectlineState<'BotName, Missing, 'ResourceGroupName, 'Site>, value: string) : BotChannelDirectlineState<'BotName, Present, 'ResourceGroupName, 'Site> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotChannelDirectlineState<'BotName, Present, 'ResourceGroupName, 'Site>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_directline#resource_group_name-1">BotChannelDirectline#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotChannelDirectlineState<'BotName, 'Location, Missing, 'Site>, value: string) : BotChannelDirectlineState<'BotName, 'Location, Present, 'Site> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotChannelDirectlineState<'BotName, 'Location, Present, 'Site>)

        /// <summary>
        /// site block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_directline#site-1">BotChannelDirectline#site</a> Accepts: azurerm.IResolvable | azurerm.BotChannelDirectline.BotChannelDirectlineSite[]
        /// </summary>
        [<CustomOperation "site">]
        member _.Site(state: BotChannelDirectlineState<'BotName, 'Location, 'ResourceGroupName, Missing>, value: HashiCorp.Cdktf.IResolvable) : BotChannelDirectlineState<'BotName, 'Location, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Site <- value)
            ({ assignments = state.assignments } : BotChannelDirectlineState<'BotName, 'Location, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_directline#id-1">BotChannelDirectline#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotChannelDirectlineState<'BotName, 'Location, 'ResourceGroupName, 'Site>, value: string) : BotChannelDirectlineState<'BotName, 'Location, 'ResourceGroupName, 'Site> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotChannelDirectlineState<'BotName, 'Location, 'ResourceGroupName, 'Site>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_directline#timeouts-1">BotChannelDirectline#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotChannelDirectlineState<'BotName, 'Location, 'ResourceGroupName, 'Site>, value: azurerm.BotChannelDirectline.BotChannelDirectlineTimeouts) : BotChannelDirectlineState<'BotName, 'Location, 'ResourceGroupName, 'Site> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotChannelDirectlineState<'BotName, 'Location, 'ResourceGroupName, 'Site>

        member _.Run(state: BotChannelDirectlineState<Present, Present, Present, Present>) : azurerm.BotChannelDirectline.BotChannelDirectline =
            let config = azurerm.BotChannelDirectline.BotChannelDirectlineConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotChannelDirectline.BotChannelDirectline(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botChannelDirectline: missing required arguments. Must call: bot_name, location, resource_group_name, site.", 9999, IsError = true)>]
        member _.Run(_: BotChannelDirectlineState<_, _, _, _>) : azurerm.BotChannelDirectline.BotChannelDirectline =
            Unchecked.defaultof<azurerm.BotChannelDirectline.BotChannelDirectline>
