namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.SentinelWatchlist.SentinelWatchlistConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist">azurerm_sentinel_watchlist</a>.
    /// </summary>
    type SentinelWatchlistBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelWatchlistState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelWatchlistState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SentinelWatchlistState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelWatchlistState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist#display_name-1">SentinelWatchlist#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SentinelWatchlistState<Missing, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelWatchlistState<Present, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : SentinelWatchlistState<Present, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist#item_search_key-1">SentinelWatchlist#item_search_key</a>.
        /// </summary>
        [<CustomOperation "item_search_key">]
        member _.ItemSearchKey(state: SentinelWatchlistState<'DisplayName, Missing, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelWatchlistState<'DisplayName, Present, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.ItemSearchKey <- value)
            ({ assignments = state.assignments } : SentinelWatchlistState<'DisplayName, Present, 'LogAnalyticsWorkspaceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist#log_analytics_workspace_id-1">SentinelWatchlist#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: SentinelWatchlistState<'DisplayName, 'ItemSearchKey, Missing, 'Name>, value: string) : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, Present, 'Name> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist#name-1">SentinelWatchlist#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, Missing>, value: string) : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist#default_duration-1">SentinelWatchlist#default_duration</a>.
        /// </summary>
        [<CustomOperation "default_duration">]
        member _.DefaultDuration(state: SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.DefaultDuration <- value)
            state : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist#description-1">SentinelWatchlist#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist#id-1">SentinelWatchlist#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name>, value: string) : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist#labels-1">SentinelWatchlist#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name>, value: seq<string>) : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Labels <- (value |> Seq.toArray))
            state : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist#timeouts-1">SentinelWatchlist#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name>, value: azurerm.SentinelWatchlist.SentinelWatchlistTimeouts) : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelWatchlistState<'DisplayName, 'ItemSearchKey, 'LogAnalyticsWorkspaceId, 'Name>

        member _.Run(state: SentinelWatchlistState<Present, Present, Present, Present>) : azurerm.SentinelWatchlist.SentinelWatchlist =
            let config = azurerm.SentinelWatchlist.SentinelWatchlistConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelWatchlist.SentinelWatchlist(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelWatchlist: missing required arguments. Must call: display_name, item_search_key, log_analytics_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: SentinelWatchlistState<_, _, _, _>) : azurerm.SentinelWatchlist.SentinelWatchlist =
            Unchecked.defaultof<azurerm.SentinelWatchlist.SentinelWatchlist>
