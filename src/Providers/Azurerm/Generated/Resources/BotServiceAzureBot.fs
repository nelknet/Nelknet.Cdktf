namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.BotServiceAzureBot.BotServiceAzureBotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot">azurerm_bot_service_azure_bot</a>.
    /// </summary>
    type BotServiceAzureBotBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotServiceAzureBotState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotServiceAzureBotState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BotServiceAzureBotState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotServiceAzureBotState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#location-1">BotServiceAzureBot#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotServiceAzureBotState<Missing, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<Present, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotServiceAzureBotState<Present, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#microsoft_app_id-1">BotServiceAzureBot#microsoft_app_id</a>.
        /// </summary>
        [<CustomOperation "microsoft_app_id">]
        member _.MicrosoftAppId(state: BotServiceAzureBotState<'Location, Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MicrosoftAppId <- value)
            ({ assignments = state.assignments } : BotServiceAzureBotState<'Location, Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#name-1">BotServiceAzureBot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, Missing, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BotServiceAzureBotState<'Location, 'MicrosoftAppId, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#resource_group_name-1">BotServiceAzureBot#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, Missing, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#sku-1">BotServiceAzureBot#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, Missing>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#cmk_key_vault_key_url-1">BotServiceAzureBot#cmk_key_vault_key_url</a>.
        /// </summary>
        [<CustomOperation "cmk_key_vault_key_url">]
        member _.CmkKeyVaultKeyUrl(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CmkKeyVaultKeyUrl <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#developer_app_insights_api_key-1">BotServiceAzureBot#developer_app_insights_api_key</a>.
        /// </summary>
        [<CustomOperation "developer_app_insights_api_key">]
        member _.DeveloperAppInsightsApiKey(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DeveloperAppInsightsApiKey <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#developer_app_insights_application_id-1">BotServiceAzureBot#developer_app_insights_application_id</a>.
        /// </summary>
        [<CustomOperation "developer_app_insights_application_id">]
        member _.DeveloperAppInsightsApplicationId(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DeveloperAppInsightsApplicationId <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#developer_app_insights_key-1">BotServiceAzureBot#developer_app_insights_key</a>.
        /// </summary>
        [<CustomOperation "developer_app_insights_key">]
        member _.DeveloperAppInsightsKey(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DeveloperAppInsightsKey <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#display_name-1">BotServiceAzureBot#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#endpoint-1">BotServiceAzureBot#endpoint</a>.
        /// </summary>
        [<CustomOperation "endpoint">]
        member _.Endpoint(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Endpoint <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#icon_url-1">BotServiceAzureBot#icon_url</a>.
        /// </summary>
        [<CustomOperation "icon_url">]
        member _.IconUrl(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.IconUrl <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#id-1">BotServiceAzureBot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#local_authentication_enabled-1">BotServiceAzureBot#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#local_authentication_enabled-1">BotServiceAzureBot#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#luis_app_ids-1">BotServiceAzureBot#luis_app_ids</a>.
        /// </summary>
        [<CustomOperation "luis_app_ids">]
        member _.LuisAppIds(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string>) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LuisAppIds <- (value |> Seq.toArray))
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#luis_key-1">BotServiceAzureBot#luis_key</a>.
        /// </summary>
        [<CustomOperation "luis_key">]
        member _.LuisKey(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LuisKey <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#microsoft_app_msi_id-1">BotServiceAzureBot#microsoft_app_msi_id</a>.
        /// </summary>
        [<CustomOperation "microsoft_app_msi_id">]
        member _.MicrosoftAppMsiId(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MicrosoftAppMsiId <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#microsoft_app_tenant_id-1">BotServiceAzureBot#microsoft_app_tenant_id</a>.
        /// </summary>
        [<CustomOperation "microsoft_app_tenant_id">]
        member _.MicrosoftAppTenantId(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MicrosoftAppTenantId <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#microsoft_app_type-1">BotServiceAzureBot#microsoft_app_type</a>.
        /// </summary>
        [<CustomOperation "microsoft_app_type">]
        member _.MicrosoftAppType(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MicrosoftAppType <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#public_network_access_enabled-1">BotServiceAzureBot#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#public_network_access_enabled-1">BotServiceAzureBot#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#streaming_endpoint_enabled-1">BotServiceAzureBot#streaming_endpoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "streaming_endpoint_enabled">]
        member _.StreamingEndpointEnabled(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.StreamingEndpointEnabled <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#streaming_endpoint_enabled-1">BotServiceAzureBot#streaming_endpoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "streaming_endpoint_enabled">]
        member _.StreamingEndpointEnabled(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.StreamingEndpointEnabled <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#tags-1">BotServiceAzureBot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_service_azure_bot#timeouts-1">BotServiceAzureBot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.BotServiceAzureBot.BotServiceAzureBotTimeouts) : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotServiceAzureBotState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: BotServiceAzureBotState<Present, Present, Present, Present, Present>) : azurerm.BotServiceAzureBot.BotServiceAzureBot =
            let config = azurerm.BotServiceAzureBot.BotServiceAzureBotConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotServiceAzureBot.BotServiceAzureBot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botServiceAzureBot: missing required arguments. Must call: location, microsoft_app_id, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: BotServiceAzureBotState<_, _, _, _, _>) : azurerm.BotServiceAzureBot.BotServiceAzureBot =
            Unchecked.defaultof<azurerm.BotServiceAzureBot.BotServiceAzureBot>
