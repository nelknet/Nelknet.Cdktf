namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken> = { assignments: ResizeArray<azurerm.BotChannelSms.BotChannelSmsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_sms">azurerm_bot_channel_sms</a>.
    /// </summary>
    type BotChannelSmsBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotChannelSmsState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelSmsState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BotChannelSmsState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelSmsState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_sms#bot_name-1">BotChannelSms#bot_name</a>.
        /// </summary>
        [<CustomOperation "bot_name">]
        member _.BotName(state: BotChannelSmsState<Missing, 'Location, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken>, value: string) : BotChannelSmsState<Present, 'Location, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken> =
            state.assignments.Add(fun config -> config.BotName <- value)
            ({ assignments = state.assignments } : BotChannelSmsState<Present, 'Location, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_sms#location-1">BotChannelSms#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotChannelSmsState<'BotName, Missing, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken>, value: string) : BotChannelSmsState<'BotName, Present, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotChannelSmsState<'BotName, Present, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_sms#phone_number-1">BotChannelSms#phone_number</a>.
        /// </summary>
        [<CustomOperation "phone_number">]
        member _.PhoneNumber(state: BotChannelSmsState<'BotName, 'Location, Missing, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken>, value: string) : BotChannelSmsState<'BotName, 'Location, Present, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken> =
            state.assignments.Add(fun config -> config.PhoneNumber <- value)
            ({ assignments = state.assignments } : BotChannelSmsState<'BotName, 'Location, Present, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_sms#resource_group_name-1">BotChannelSms#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, Missing, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken>, value: string) : BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, Present, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, Present, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_sms#sms_channel_account_security_id-1">BotChannelSms#sms_channel_account_security_id</a>.
        /// </summary>
        [<CustomOperation "sms_channel_account_security_id">]
        member _.SmsChannelAccountSecurityId(state: BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, 'ResourceGroupName, Missing, 'SmsChannelAuthToken>, value: string) : BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, 'ResourceGroupName, Present, 'SmsChannelAuthToken> =
            state.assignments.Add(fun config -> config.SmsChannelAccountSecurityId <- value)
            ({ assignments = state.assignments } : BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, 'ResourceGroupName, Present, 'SmsChannelAuthToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_sms#sms_channel_auth_token-1">BotChannelSms#sms_channel_auth_token</a>.
        /// </summary>
        [<CustomOperation "sms_channel_auth_token">]
        member _.SmsChannelAuthToken(state: BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, Missing>, value: string) : BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, Present> =
            state.assignments.Add(fun config -> config.SmsChannelAuthToken <- value)
            ({ assignments = state.assignments } : BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_sms#id-1">BotChannelSms#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken>, value: string) : BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_sms#timeouts-1">BotChannelSms#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken>, value: azurerm.BotChannelSms.BotChannelSmsTimeouts) : BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotChannelSmsState<'BotName, 'Location, 'PhoneNumber, 'ResourceGroupName, 'SmsChannelAccountSecurityId, 'SmsChannelAuthToken>

        member _.Run(state: BotChannelSmsState<Present, Present, Present, Present, Present, Present>) : azurerm.BotChannelSms.BotChannelSms =
            let config = azurerm.BotChannelSms.BotChannelSmsConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotChannelSms.BotChannelSms(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botChannelSms: missing required arguments. Must call: bot_name, location, phone_number, resource_group_name, sms_channel_account_security_id, sms_channel_auth_token.", 9999, IsError = true)>]
        member _.Run(_: BotChannelSmsState<_, _, _, _, _, _>) : azurerm.BotChannelSms.BotChannelSms =
            Unchecked.defaultof<azurerm.BotChannelSms.BotChannelSms>
