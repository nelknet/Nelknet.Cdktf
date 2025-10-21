namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelWatchlistItemState<'Properties, 'WatchlistId> = { assignments: ResizeArray<azurerm.SentinelWatchlistItem.SentinelWatchlistItemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist_item">azurerm_sentinel_watchlist_item</a>.
    /// </summary>
    type SentinelWatchlistItemBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelWatchlistItemState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelWatchlistItemState<Missing, Missing>)

        member _.Zero(()) : SentinelWatchlistItemState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelWatchlistItemState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist_item#properties-1">SentinelWatchlistItem#properties</a>.
        /// </summary>
        [<CustomOperation "properties">]
        member _.Properties(state: SentinelWatchlistItemState<Missing, 'WatchlistId>, value: seq<string * string>) : SentinelWatchlistItemState<Present, 'WatchlistId> =
            state.assignments.Add(fun config -> config.Properties <- dict value)
            ({ assignments = state.assignments } : SentinelWatchlistItemState<Present, 'WatchlistId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist_item#watchlist_id-1">SentinelWatchlistItem#watchlist_id</a>.
        /// </summary>
        [<CustomOperation "watchlist_id">]
        member _.WatchlistId(state: SentinelWatchlistItemState<'Properties, Missing>, value: string) : SentinelWatchlistItemState<'Properties, Present> =
            state.assignments.Add(fun config -> config.WatchlistId <- value)
            ({ assignments = state.assignments } : SentinelWatchlistItemState<'Properties, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist_item#id-1">SentinelWatchlistItem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelWatchlistItemState<'Properties, 'WatchlistId>, value: string) : SentinelWatchlistItemState<'Properties, 'WatchlistId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelWatchlistItemState<'Properties, 'WatchlistId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist_item#name-1">SentinelWatchlistItem#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelWatchlistItemState<'Properties, 'WatchlistId>, value: string) : SentinelWatchlistItemState<'Properties, 'WatchlistId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SentinelWatchlistItemState<'Properties, 'WatchlistId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_watchlist_item#timeouts-1">SentinelWatchlistItem#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelWatchlistItemState<'Properties, 'WatchlistId>, value: azurerm.SentinelWatchlistItem.SentinelWatchlistItemTimeouts) : SentinelWatchlistItemState<'Properties, 'WatchlistId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelWatchlistItemState<'Properties, 'WatchlistId>

        member _.Run(state: SentinelWatchlistItemState<Present, Present>) : azurerm.SentinelWatchlistItem.SentinelWatchlistItem =
            let config = azurerm.SentinelWatchlistItem.SentinelWatchlistItemConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelWatchlistItem.SentinelWatchlistItem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelWatchlistItem: missing required arguments. Must call: properties, watchlist_id.", 9999, IsError = true)>]
        member _.Run(_: SentinelWatchlistItemState<_, _>) : azurerm.SentinelWatchlistItem.SentinelWatchlistItem =
            Unchecked.defaultof<azurerm.SentinelWatchlistItem.SentinelWatchlistItem>
