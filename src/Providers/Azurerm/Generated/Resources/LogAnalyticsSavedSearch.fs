namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query> = { assignments: ResizeArray<azurerm.LogAnalyticsSavedSearch.LogAnalyticsSavedSearchConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_saved_search">azurerm_log_analytics_saved_search</a>.
    /// </summary>
    type LogAnalyticsSavedSearchBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsSavedSearchState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsSavedSearchState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogAnalyticsSavedSearchState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsSavedSearchState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_saved_search#category-1">LogAnalyticsSavedSearch#category</a>.
        /// </summary>
        [<CustomOperation "category">]
        member _.Category(state: LogAnalyticsSavedSearchState<Missing, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query>, value: string) : LogAnalyticsSavedSearchState<Present, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query> =
            state.assignments.Add(fun config -> config.Category <- value)
            ({ assignments = state.assignments } : LogAnalyticsSavedSearchState<Present, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_saved_search#display_name-1">LogAnalyticsSavedSearch#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: LogAnalyticsSavedSearchState<'Category, Missing, 'LogAnalyticsWorkspaceId, 'Name, 'Query>, value: string) : LogAnalyticsSavedSearchState<'Category, Present, 'LogAnalyticsWorkspaceId, 'Name, 'Query> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : LogAnalyticsSavedSearchState<'Category, Present, 'LogAnalyticsWorkspaceId, 'Name, 'Query>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_saved_search#log_analytics_workspace_id-1">LogAnalyticsSavedSearch#log_analytics_workspace_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: LogAnalyticsSavedSearchState<'Category, 'DisplayName, Missing, 'Name, 'Query>, value: string) : LogAnalyticsSavedSearchState<'Category, 'DisplayName, Present, 'Name, 'Query> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            ({ assignments = state.assignments } : LogAnalyticsSavedSearchState<'Category, 'DisplayName, Present, 'Name, 'Query>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_saved_search#name-1">LogAnalyticsSavedSearch#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, Missing, 'Query>, value: string) : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, Present, 'Query> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, Present, 'Query>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_saved_search#query-1">LogAnalyticsSavedSearch#query</a>.
        /// </summary>
        [<CustomOperation "query">]
        member _.Query(state: LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, Missing>, value: string) : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Query <- value)
            ({ assignments = state.assignments } : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_saved_search#function_alias-1">LogAnalyticsSavedSearch#function_alias</a>.
        /// </summary>
        [<CustomOperation "function_alias">]
        member _.FunctionAlias(state: LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query>, value: string) : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query> =
            state.assignments.Add(fun config -> config.FunctionAlias <- value)
            state : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_saved_search#function_parameters-1">LogAnalyticsSavedSearch#function_parameters</a>.
        /// </summary>
        [<CustomOperation "function_parameters">]
        member _.FunctionParameters(state: LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query>, value: seq<string>) : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query> =
            state.assignments.Add(fun config -> config.FunctionParameters <- (value |> Seq.toArray))
            state : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_saved_search#id-1">LogAnalyticsSavedSearch#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query>, value: string) : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_saved_search#tags-1">LogAnalyticsSavedSearch#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query>, value: seq<string * string>) : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_saved_search#timeouts-1">LogAnalyticsSavedSearch#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query>, value: azurerm.LogAnalyticsSavedSearch.LogAnalyticsSavedSearchTimeouts) : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsSavedSearchState<'Category, 'DisplayName, 'LogAnalyticsWorkspaceId, 'Name, 'Query>

        member _.Run(state: LogAnalyticsSavedSearchState<Present, Present, Present, Present, Present>) : azurerm.LogAnalyticsSavedSearch.LogAnalyticsSavedSearch =
            let config = azurerm.LogAnalyticsSavedSearch.LogAnalyticsSavedSearchConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsSavedSearch.LogAnalyticsSavedSearch(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsSavedSearch: missing required arguments. Must call: category, display_name, log_analytics_workspace_id, name, query.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsSavedSearchState<_, _, _, _, _>) : azurerm.LogAnalyticsSavedSearch.LogAnalyticsSavedSearch =
            Unchecked.defaultof<azurerm.LogAnalyticsSavedSearch.LogAnalyticsSavedSearch>
