namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName> = { assignments: ResizeArray<azurerm.BotConnection.BotConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_connection">azurerm_bot_connection</a>.
    /// </summary>
    type BotConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : BotConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BotConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BotConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_connection#bot_name-1">BotConnection#bot_name</a>.
        /// </summary>
        [<CustomOperation "bot_name">]
        member _.BotName(state: BotConnectionState<Missing, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>, value: string) : BotConnectionState<Present, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName> =
            state.assignments.Add(fun config -> config.BotName <- value)
            ({ assignments = state.assignments } : BotConnectionState<Present, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_connection#client_id-1">BotConnection#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: BotConnectionState<'BotName, Missing, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>, value: string) : BotConnectionState<'BotName, Present, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            ({ assignments = state.assignments } : BotConnectionState<'BotName, Present, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_connection#client_secret-1">BotConnection#client_secret</a>.
        /// </summary>
        [<CustomOperation "client_secret">]
        member _.ClientSecret(state: BotConnectionState<'BotName, 'ClientId, Missing, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>, value: string) : BotConnectionState<'BotName, 'ClientId, Present, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName> =
            state.assignments.Add(fun config -> config.ClientSecret <- value)
            ({ assignments = state.assignments } : BotConnectionState<'BotName, 'ClientId, Present, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_connection#location-1">BotConnection#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BotConnectionState<'BotName, 'ClientId, 'ClientSecret, Missing, 'Name, 'ResourceGroupName, 'ServiceProviderName>, value: string) : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, Present, 'Name, 'ResourceGroupName, 'ServiceProviderName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, Present, 'Name, 'ResourceGroupName, 'ServiceProviderName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_connection#name-1">BotConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, Missing, 'ResourceGroupName, 'ServiceProviderName>, value: string) : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, Present, 'ResourceGroupName, 'ServiceProviderName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, Present, 'ResourceGroupName, 'ServiceProviderName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_connection#resource_group_name-1">BotConnection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, Missing, 'ServiceProviderName>, value: string) : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, Present, 'ServiceProviderName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, Present, 'ServiceProviderName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_connection#service_provider_name-1">BotConnection#service_provider_name</a>.
        /// </summary>
        [<CustomOperation "service_provider_name">]
        member _.ServiceProviderName(state: BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ServiceProviderName <- value)
            ({ assignments = state.assignments } : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_connection#id-1">BotConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>, value: string) : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_connection#parameters-1">BotConnection#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>, value: seq<string * string>) : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_connection#scopes-1">BotConnection#scopes</a>.
        /// </summary>
        [<CustomOperation "scopes">]
        member _.Scopes(state: BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>, value: string) : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName> =
            state.assignments.Add(fun config -> config.Scopes <- value)
            state : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/bot_connection#timeouts-1">BotConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>, value: azurerm.BotConnection.BotConnectionTimeouts) : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BotConnectionState<'BotName, 'ClientId, 'ClientSecret, 'Location, 'Name, 'ResourceGroupName, 'ServiceProviderName>

        member _.Run(state: BotConnectionState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.BotConnection.BotConnection =
            let config = azurerm.BotConnection.BotConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.BotConnection.BotConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.botConnection: missing required arguments. Must call: bot_name, client_id, client_secret, location, name, resource_group_name, service_provider_name.", 9999, IsError = true)>]
        member _.Run(_: BotConnectionState<_, _, _, _, _, _, _>) : azurerm.BotConnection.BotConnection =
            Unchecked.defaultof<azurerm.BotConnection.BotConnection>
