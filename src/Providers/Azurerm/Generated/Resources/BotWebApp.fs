namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.BotWebApp.BotWebAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app">azurerm_bot_web_app</a>.
    /// </summary>
    type BotWebAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotWebAppState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotWebAppState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BotWebAppState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotWebAppState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#location-1">BotWebApp#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotWebAppState<Missing, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotWebAppState<Present, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotWebAppState<Present, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#microsoft_app_id-1">BotWebApp#microsoft_app_id</a>.
        /// </summary>
        [<CustomOperation "microsoft_app_id">]
        member _.MicrosoftAppId(state: BotWebAppState<'Location, Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotWebAppState<'Location, Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MicrosoftAppId <- value)
            ({ assignments = state.assignments } : BotWebAppState<'Location, Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#name-1">BotWebApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BotWebAppState<'Location, 'MicrosoftAppId, Missing, 'ResourceGroupName, 'Sku>, value: string) : BotWebAppState<'Location, 'MicrosoftAppId, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BotWebAppState<'Location, 'MicrosoftAppId, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#resource_group_name-1">BotWebApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotWebAppState<'Location, 'MicrosoftAppId, 'Name, Missing, 'Sku>, value: string) : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#sku-1">BotWebApp#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, Missing>, value: string) : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#developer_app_insights_api_key-1">BotWebApp#developer_app_insights_api_key</a>.
        /// </summary>
        [<CustomOperation "developer_app_insights_api_key">]
        member _.DeveloperAppInsightsApiKey(state: BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DeveloperAppInsightsApiKey <- value)
            state : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#developer_app_insights_application_id-1">BotWebApp#developer_app_insights_application_id</a>.
        /// </summary>
        [<CustomOperation "developer_app_insights_application_id">]
        member _.DeveloperAppInsightsApplicationId(state: BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DeveloperAppInsightsApplicationId <- value)
            state : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#developer_app_insights_key-1">BotWebApp#developer_app_insights_key</a>.
        /// </summary>
        [<CustomOperation "developer_app_insights_key">]
        member _.DeveloperAppInsightsKey(state: BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DeveloperAppInsightsKey <- value)
            state : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#display_name-1">BotWebApp#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#endpoint-1">BotWebApp#endpoint</a>.
        /// </summary>
        [<CustomOperation "endpoint">]
        member _.Endpoint(state: BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Endpoint <- value)
            state : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#id-1">BotWebApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#luis_app_ids-1">BotWebApp#luis_app_ids</a>.
        /// </summary>
        [<CustomOperation "luis_app_ids">]
        member _.LuisAppIds(state: BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string>) : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LuisAppIds <- (value |> Seq.toArray))
            state : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#luis_key-1">BotWebApp#luis_key</a>.
        /// </summary>
        [<CustomOperation "luis_key">]
        member _.LuisKey(state: BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LuisKey <- value)
            state : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#tags-1">BotWebApp#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_web_app#timeouts-1">BotWebApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.BotWebApp.BotWebAppTimeouts) : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotWebAppState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: BotWebAppState<Present, Present, Present, Present, Present>) : azurerm.BotWebApp.BotWebApp =
            let config = azurerm.BotWebApp.BotWebAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotWebApp.BotWebApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botWebApp: missing required arguments. Must call: location, microsoft_app_id, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: BotWebAppState<_, _, _, _, _>) : azurerm.BotWebApp.BotWebApp =
            Unchecked.defaultof<azurerm.BotWebApp.BotWebApp>
