namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, 'Page, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.BotChannelFacebook.BotChannelFacebookConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_facebook">azurerm_bot_channel_facebook</a>.
    /// </summary>
    type BotChannelFacebookBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotChannelFacebookState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelFacebookState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BotChannelFacebookState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelFacebookState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_facebook#bot_name-1">BotChannelFacebook#bot_name</a>.
        /// </summary>
        [<CustomOperation "bot_name">]
        member _.BotName(state: BotChannelFacebookState<Missing, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, 'Page, 'ResourceGroupName>, value: string) : BotChannelFacebookState<Present, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, 'Page, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BotName <- value)
            ({ assignments = state.assignments } : BotChannelFacebookState<Present, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, 'Page, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_facebook#facebook_application_id-1">BotChannelFacebook#facebook_application_id</a>.
        /// </summary>
        [<CustomOperation "facebook_application_id">]
        member _.FacebookApplicationId(state: BotChannelFacebookState<'BotName, Missing, 'FacebookApplicationSecret, 'Location, 'Page, 'ResourceGroupName>, value: string) : BotChannelFacebookState<'BotName, Present, 'FacebookApplicationSecret, 'Location, 'Page, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FacebookApplicationId <- value)
            ({ assignments = state.assignments } : BotChannelFacebookState<'BotName, Present, 'FacebookApplicationSecret, 'Location, 'Page, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_facebook#facebook_application_secret-1">BotChannelFacebook#facebook_application_secret</a>.
        /// </summary>
        [<CustomOperation "facebook_application_secret">]
        member _.FacebookApplicationSecret(state: BotChannelFacebookState<'BotName, 'FacebookApplicationId, Missing, 'Location, 'Page, 'ResourceGroupName>, value: string) : BotChannelFacebookState<'BotName, 'FacebookApplicationId, Present, 'Location, 'Page, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FacebookApplicationSecret <- value)
            ({ assignments = state.assignments } : BotChannelFacebookState<'BotName, 'FacebookApplicationId, Present, 'Location, 'Page, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_facebook#location-1">BotChannelFacebook#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, Missing, 'Page, 'ResourceGroupName>, value: string) : BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, Present, 'Page, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, Present, 'Page, 'ResourceGroupName>)

        /// <summary>
        /// page block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_facebook#page-1">BotChannelFacebook#page</a> Accepts: azurerm.IResolvable | azurerm.BotChannelFacebook.BotChannelFacebookPage[]
        /// </summary>
        [<CustomOperation "page">]
        member _.Page(state: BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, Missing, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Page <- value)
            ({ assignments = state.assignments } : BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_facebook#resource_group_name-1">BotChannelFacebook#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, 'Page, Missing>, value: string) : BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, 'Page, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, 'Page, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_facebook#id-1">BotChannelFacebook#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, 'Page, 'ResourceGroupName>, value: string) : BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, 'Page, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, 'Page, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channel_facebook#timeouts-1">BotChannelFacebook#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, 'Page, 'ResourceGroupName>, value: azurerm.BotChannelFacebook.BotChannelFacebookTimeouts) : BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, 'Page, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotChannelFacebookState<'BotName, 'FacebookApplicationId, 'FacebookApplicationSecret, 'Location, 'Page, 'ResourceGroupName>

        member _.Run(state: BotChannelFacebookState<Present, Present, Present, Present, Present, Present>) : azurerm.BotChannelFacebook.BotChannelFacebook =
            let config = azurerm.BotChannelFacebook.BotChannelFacebookConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotChannelFacebook.BotChannelFacebook(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botChannelFacebook: missing required arguments. Must call: bot_name, facebook_application_id, facebook_application_secret, location, page, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: BotChannelFacebookState<_, _, _, _, _, _>) : azurerm.BotChannelFacebook.BotChannelFacebook =
            Unchecked.defaultof<azurerm.BotChannelFacebook.BotChannelFacebook>
