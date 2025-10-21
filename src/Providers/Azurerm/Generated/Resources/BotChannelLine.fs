namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotChannelLineState<'BotName, 'LineChannel, 'Location, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.BotChannelLine.BotChannelLineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_line">azurerm_bot_channel_line</a>.
    /// </summary>
    type BotChannelLineBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotChannelLineState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelLineState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BotChannelLineState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelLineState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_line#bot_name-1">BotChannelLine#bot_name</a>.
        /// </summary>
        [<CustomOperation "bot_name">]
        member _.BotName(state: BotChannelLineState<Missing, 'LineChannel, 'Location, 'ResourceGroupName>, value: string) : BotChannelLineState<Present, 'LineChannel, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BotName <- value)
            ({ assignments = state.assignments } : BotChannelLineState<Present, 'LineChannel, 'Location, 'ResourceGroupName>)

        /// <summary>
        /// line_channel block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_line#line_channel-1">BotChannelLine#line_channel</a> Accepts: azurerm.IResolvable | azurerm.BotChannelLine.BotChannelLineLineChannel[]
        /// </summary>
        [<CustomOperation "line_channel">]
        member _.LineChannel(state: BotChannelLineState<'BotName, Missing, 'Location, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : BotChannelLineState<'BotName, Present, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LineChannel <- value)
            ({ assignments = state.assignments } : BotChannelLineState<'BotName, Present, 'Location, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_line#location-1">BotChannelLine#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotChannelLineState<'BotName, 'LineChannel, Missing, 'ResourceGroupName>, value: string) : BotChannelLineState<'BotName, 'LineChannel, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotChannelLineState<'BotName, 'LineChannel, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_line#resource_group_name-1">BotChannelLine#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotChannelLineState<'BotName, 'LineChannel, 'Location, Missing>, value: string) : BotChannelLineState<'BotName, 'LineChannel, 'Location, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotChannelLineState<'BotName, 'LineChannel, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_line#id-1">BotChannelLine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotChannelLineState<'BotName, 'LineChannel, 'Location, 'ResourceGroupName>, value: string) : BotChannelLineState<'BotName, 'LineChannel, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotChannelLineState<'BotName, 'LineChannel, 'Location, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_line#timeouts-1">BotChannelLine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotChannelLineState<'BotName, 'LineChannel, 'Location, 'ResourceGroupName>, value: azurerm.BotChannelLine.BotChannelLineTimeouts) : BotChannelLineState<'BotName, 'LineChannel, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotChannelLineState<'BotName, 'LineChannel, 'Location, 'ResourceGroupName>

        member _.Run(state: BotChannelLineState<Present, Present, Present, Present>) : azurerm.BotChannelLine.BotChannelLine =
            let config = azurerm.BotChannelLine.BotChannelLineConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotChannelLine.BotChannelLine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botChannelLine: missing required arguments. Must call: bot_name, line_channel, location, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: BotChannelLineState<_, _, _, _>) : azurerm.BotChannelLine.BotChannelLine =
            Unchecked.defaultof<azurerm.BotChannelLine.BotChannelLine>
