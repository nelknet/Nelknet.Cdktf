namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken> = { assignments: ResizeArray<azurerm.BotChannelSlack.BotChannelSlackConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_slack">azurerm_bot_channel_slack</a>.
    /// </summary>
    type BotChannelSlackBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotChannelSlackState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelSlackState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BotChannelSlackState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelSlackState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_slack#bot_name-1">BotChannelSlack#bot_name</a>.
        /// </summary>
        [<CustomOperation "bot_name">]
        member _.BotName(state: BotChannelSlackState<Missing, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken>, value: string) : BotChannelSlackState<Present, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken> =
            state.assignments.Add(fun config -> config.BotName <- value)
            ({ assignments = state.assignments } : BotChannelSlackState<Present, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_slack#client_id-1">BotChannelSlack#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: BotChannelSlackState<'BotName, Missing, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken>, value: string) : BotChannelSlackState<'BotName, Present, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            ({ assignments = state.assignments } : BotChannelSlackState<'BotName, Present, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_slack#client_secret-1">BotChannelSlack#client_secret</a>.
        /// </summary>
        [<CustomOperation "client_secret">]
        member _.ClientSecret(state: BotChannelSlackState<'BotName, 'ClientId, Missing, 'Location, 'ResourceGroupName, 'VerificationToken>, value: string) : BotChannelSlackState<'BotName, 'ClientId, Present, 'Location, 'ResourceGroupName, 'VerificationToken> =
            state.assignments.Add(fun config -> config.ClientSecret <- value)
            ({ assignments = state.assignments } : BotChannelSlackState<'BotName, 'ClientId, Present, 'Location, 'ResourceGroupName, 'VerificationToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_slack#location-1">BotChannelSlack#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, Missing, 'ResourceGroupName, 'VerificationToken>, value: string) : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, Present, 'ResourceGroupName, 'VerificationToken> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, Present, 'ResourceGroupName, 'VerificationToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_slack#resource_group_name-1">BotChannelSlack#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, Missing, 'VerificationToken>, value: string) : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, Present, 'VerificationToken> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, Present, 'VerificationToken>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_slack#verification_token-1">BotChannelSlack#verification_token</a>.
        /// </summary>
        [<CustomOperation "verification_token">]
        member _.VerificationToken(state: BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, Missing>, value: string) : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VerificationToken <- value)
            ({ assignments = state.assignments } : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_slack#id-1">BotChannelSlack#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken>, value: string) : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_slack#landing_page_url-1">BotChannelSlack#landing_page_url</a>.
        /// </summary>
        [<CustomOperation "landing_page_url">]
        member _.LandingPageUrl(state: BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken>, value: string) : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken> =
            state.assignments.Add(fun config -> config.LandingPageUrl <- value)
            state : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_slack#signing_secret-1">BotChannelSlack#signing_secret</a>.
        /// </summary>
        [<CustomOperation "signing_secret">]
        member _.SigningSecret(state: BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken>, value: string) : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken> =
            state.assignments.Add(fun config -> config.SigningSecret <- value)
            state : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_slack#timeouts-1">BotChannelSlack#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken>, value: azurerm.BotChannelSlack.BotChannelSlackTimeouts) : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotChannelSlackState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'ResourceGroupName, 'VerificationToken>

        member _.Run(state: BotChannelSlackState<Present, Present, Present, Present, Present, Present>) : azurerm.BotChannelSlack.BotChannelSlack =
            let config = azurerm.BotChannelSlack.BotChannelSlackConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotChannelSlack.BotChannelSlack(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botChannelSlack: missing required arguments. Must call: bot_name, client_id, client_secret, location, resource_group_name, verification_token.", 9999, IsError = true)>]
        member _.Run(_: BotChannelSlackState<_, _, _, _, _, _>) : azurerm.BotChannelSlack.BotChannelSlack =
            Unchecked.defaultof<azurerm.BotChannelSlack.BotChannelSlack>
