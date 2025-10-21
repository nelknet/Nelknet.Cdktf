namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.BotChannelsRegistration.BotChannelsRegistrationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration">azurerm_bot_channels_registration</a>.
    /// </summary>
    type BotChannelsRegistrationBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotChannelsRegistrationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelsRegistrationState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BotChannelsRegistrationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotChannelsRegistrationState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#location-1">BotChannelsRegistration#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotChannelsRegistrationState<Missing, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotChannelsRegistrationState<Present, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotChannelsRegistrationState<Present, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#microsoft_app_id-1">BotChannelsRegistration#microsoft_app_id</a>.
        /// </summary>
        [<CustomOperation "microsoft_app_id">]
        member _.MicrosoftAppId(state: BotChannelsRegistrationState<'Location, Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotChannelsRegistrationState<'Location, Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MicrosoftAppId <- value)
            ({ assignments = state.assignments } : BotChannelsRegistrationState<'Location, Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#name-1">BotChannelsRegistration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, Missing, 'ResourceGroupName, 'Sku>, value: string) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#resource_group_name-1">BotChannelsRegistration#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, Missing, 'Sku>, value: string) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#sku-1">BotChannelsRegistration#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, Missing>, value: string) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#cmk_key_vault_url-1">BotChannelsRegistration#cmk_key_vault_url</a>.
        /// </summary>
        [<CustomOperation "cmk_key_vault_url">]
        member _.CmkKeyVaultUrl(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CmkKeyVaultUrl <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#description-1">BotChannelsRegistration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#developer_app_insights_api_key-1">BotChannelsRegistration#developer_app_insights_api_key</a>.
        /// </summary>
        [<CustomOperation "developer_app_insights_api_key">]
        member _.DeveloperAppInsightsApiKey(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DeveloperAppInsightsApiKey <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#developer_app_insights_application_id-1">BotChannelsRegistration#developer_app_insights_application_id</a>.
        /// </summary>
        [<CustomOperation "developer_app_insights_application_id">]
        member _.DeveloperAppInsightsApplicationId(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DeveloperAppInsightsApplicationId <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#developer_app_insights_key-1">BotChannelsRegistration#developer_app_insights_key</a>.
        /// </summary>
        [<CustomOperation "developer_app_insights_key">]
        member _.DeveloperAppInsightsKey(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DeveloperAppInsightsKey <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#display_name-1">BotChannelsRegistration#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#endpoint-1">BotChannelsRegistration#endpoint</a>.
        /// </summary>
        [<CustomOperation "endpoint">]
        member _.Endpoint(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Endpoint <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#icon_url-1">BotChannelsRegistration#icon_url</a>.
        /// </summary>
        [<CustomOperation "icon_url">]
        member _.IconUrl(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.IconUrl <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#id-1">BotChannelsRegistration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: string) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#public_network_access_enabled-1">BotChannelsRegistration#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#public_network_access_enabled-1">BotChannelsRegistration#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#streaming_endpoint_enabled-1">BotChannelsRegistration#streaming_endpoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "streaming_endpoint_enabled">]
        member _.StreamingEndpointEnabled(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.StreamingEndpointEnabled <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#streaming_endpoint_enabled-1">BotChannelsRegistration#streaming_endpoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "streaming_endpoint_enabled">]
        member _.StreamingEndpointEnabled(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.StreamingEndpointEnabled <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#tags-1">BotChannelsRegistration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_channels_registration#timeouts-1">BotChannelsRegistration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.BotChannelsRegistration.BotChannelsRegistrationTimeouts) : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotChannelsRegistrationState<'Location, 'MicrosoftAppId, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: BotChannelsRegistrationState<Present, Present, Present, Present, Present>) : azurerm.BotChannelsRegistration.BotChannelsRegistration =
            let config = azurerm.BotChannelsRegistration.BotChannelsRegistrationConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotChannelsRegistration.BotChannelsRegistration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botChannelsRegistration: missing required arguments. Must call: location, microsoft_app_id, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: BotChannelsRegistrationState<_, _, _, _, _>) : azurerm.BotChannelsRegistration.BotChannelsRegistration =
            Unchecked.defaultof<azurerm.BotChannelsRegistration.BotChannelsRegistration>
