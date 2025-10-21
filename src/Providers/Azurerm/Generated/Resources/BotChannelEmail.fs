namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotChannelEmailState<'BotName, 'EmailAddress, 'Location, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.BotChannelEmail.BotChannelEmailConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_email">azurerm_bot_channel_email</a>.
    /// </summary>
    type BotChannelEmailBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotChannelEmailState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelEmailState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BotChannelEmailState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelEmailState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_email#bot_name-1">BotChannelEmail#bot_name</a>.
        /// </summary>
        [<CustomOperation "bot_name">]
        member _.BotName(state: BotChannelEmailState<Missing, 'EmailAddress, 'Location, 'ResourceGroupName>, value: string) : BotChannelEmailState<Present, 'EmailAddress, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BotName <- value)
            ({ assignments = state.assignments } : BotChannelEmailState<Present, 'EmailAddress, 'Location, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_email#email_address-1">BotChannelEmail#email_address</a>.
        /// </summary>
        [<CustomOperation "email_address">]
        member _.EmailAddress(state: BotChannelEmailState<'BotName, Missing, 'Location, 'ResourceGroupName>, value: string) : BotChannelEmailState<'BotName, Present, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EmailAddress <- value)
            ({ assignments = state.assignments } : BotChannelEmailState<'BotName, Present, 'Location, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_email#location-1">BotChannelEmail#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotChannelEmailState<'BotName, 'EmailAddress, Missing, 'ResourceGroupName>, value: string) : BotChannelEmailState<'BotName, 'EmailAddress, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotChannelEmailState<'BotName, 'EmailAddress, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_email#resource_group_name-1">BotChannelEmail#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotChannelEmailState<'BotName, 'EmailAddress, 'Location, Missing>, value: string) : BotChannelEmailState<'BotName, 'EmailAddress, 'Location, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotChannelEmailState<'BotName, 'EmailAddress, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_email#email_password-1">BotChannelEmail#email_password</a>.
        /// </summary>
        [<CustomOperation "email_password">]
        member _.EmailPassword(state: BotChannelEmailState<'BotName, 'EmailAddress, 'Location, 'ResourceGroupName>, value: string) : BotChannelEmailState<'BotName, 'EmailAddress, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EmailPassword <- value)
            state : BotChannelEmailState<'BotName, 'EmailAddress, 'Location, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_email#id-1">BotChannelEmail#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotChannelEmailState<'BotName, 'EmailAddress, 'Location, 'ResourceGroupName>, value: string) : BotChannelEmailState<'BotName, 'EmailAddress, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotChannelEmailState<'BotName, 'EmailAddress, 'Location, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_email#magic_code-1">BotChannelEmail#magic_code</a>.
        /// </summary>
        [<CustomOperation "magic_code">]
        member _.MagicCode(state: BotChannelEmailState<'BotName, 'EmailAddress, 'Location, 'ResourceGroupName>, value: string) : BotChannelEmailState<'BotName, 'EmailAddress, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MagicCode <- value)
            state : BotChannelEmailState<'BotName, 'EmailAddress, 'Location, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_email#timeouts-1">BotChannelEmail#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotChannelEmailState<'BotName, 'EmailAddress, 'Location, 'ResourceGroupName>, value: azurerm.BotChannelEmail.BotChannelEmailTimeouts) : BotChannelEmailState<'BotName, 'EmailAddress, 'Location, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotChannelEmailState<'BotName, 'EmailAddress, 'Location, 'ResourceGroupName>

        member _.Run(state: BotChannelEmailState<Present, Present, Present, Present>) : azurerm.BotChannelEmail.BotChannelEmail =
            let config = azurerm.BotChannelEmail.BotChannelEmailConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotChannelEmail.BotChannelEmail(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botChannelEmail: missing required arguments. Must call: bot_name, email_address, location, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: BotChannelEmailState<_, _, _, _>) : azurerm.BotChannelEmail.BotChannelEmail =
            Unchecked.defaultof<azurerm.BotChannelEmail.BotChannelEmail>
