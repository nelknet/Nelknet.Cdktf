namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId> = { assignments: ResizeArray<azurerm.LogAnalyticsQueryPackQuery.LogAnalyticsQueryPackQueryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack_query">azurerm_log_analytics_query_pack_query</a>.
    /// </summary>
    type LogAnalyticsQueryPackQueryBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsQueryPackQueryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsQueryPackQueryState<Missing, Missing, Missing>)

        member _.Zero(()) : LogAnalyticsQueryPackQueryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsQueryPackQueryState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack_query#body-1">LogAnalyticsQueryPackQuery#body</a>.
        /// </summary>
        [<CustomOperation "body">]
        member _.Body(state: LogAnalyticsQueryPackQueryState<Missing, 'DisplayName, 'QueryPackId>, value: string) : LogAnalyticsQueryPackQueryState<Present, 'DisplayName, 'QueryPackId> =
            state.assignments.Add(fun config -> config.Body <- value)
            ({ assignments = state.assignments } : LogAnalyticsQueryPackQueryState<Present, 'DisplayName, 'QueryPackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack_query#display_name-1">LogAnalyticsQueryPackQuery#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: LogAnalyticsQueryPackQueryState<'Body, Missing, 'QueryPackId>, value: string) : LogAnalyticsQueryPackQueryState<'Body, Present, 'QueryPackId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : LogAnalyticsQueryPackQueryState<'Body, Present, 'QueryPackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack_query#query_pack_id-1">LogAnalyticsQueryPackQuery#query_pack_id</a>.
        /// </summary>
        [<CustomOperation "query_pack_id">]
        member _.QueryPackId(state: LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, Missing>, value: string) : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, Present> =
            state.assignments.Add(fun config -> config.QueryPackId <- value)
            ({ assignments = state.assignments } : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack_query#additional_settings_json-1">LogAnalyticsQueryPackQuery#additional_settings_json</a>.
        /// </summary>
        [<CustomOperation "additional_settings_json">]
        member _.AdditionalSettingsJson(state: LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>, value: string) : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId> =
            state.assignments.Add(fun config -> config.AdditionalSettingsJson <- value)
            state : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack_query#categories-1">LogAnalyticsQueryPackQuery#categories</a>.
        /// </summary>
        [<CustomOperation "categories">]
        member _.Categories(state: LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>, value: seq<string>) : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId> =
            state.assignments.Add(fun config -> config.Categories <- (value |> Seq.toArray))
            state : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack_query#description-1">LogAnalyticsQueryPackQuery#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>, value: string) : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack_query#id-1">LogAnalyticsQueryPackQuery#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>, value: string) : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack_query#name-1">LogAnalyticsQueryPackQuery#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>, value: string) : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack_query#resource_types-1">LogAnalyticsQueryPackQuery#resource_types</a>.
        /// </summary>
        [<CustomOperation "resource_types">]
        member _.ResourceTypes(state: LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>, value: seq<string>) : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId> =
            state.assignments.Add(fun config -> config.ResourceTypes <- (value |> Seq.toArray))
            state : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack_query#solutions-1">LogAnalyticsQueryPackQuery#solutions</a>.
        /// </summary>
        [<CustomOperation "solutions">]
        member _.Solutions(state: LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>, value: seq<string>) : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId> =
            state.assignments.Add(fun config -> config.Solutions <- (value |> Seq.toArray))
            state : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack_query#tags-1">LogAnalyticsQueryPackQuery#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>, value: seq<string * string>) : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack_query#timeouts-1">LogAnalyticsQueryPackQuery#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>, value: azurerm.LogAnalyticsQueryPackQuery.LogAnalyticsQueryPackQueryTimeouts) : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsQueryPackQueryState<'Body, 'DisplayName, 'QueryPackId>

        member _.Run(state: LogAnalyticsQueryPackQueryState<Present, Present, Present>) : azurerm.LogAnalyticsQueryPackQuery.LogAnalyticsQueryPackQuery =
            let config = azurerm.LogAnalyticsQueryPackQuery.LogAnalyticsQueryPackQueryConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsQueryPackQuery.LogAnalyticsQueryPackQuery(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsQueryPackQuery: missing required arguments. Must call: body, display_name, query_pack_id.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsQueryPackQueryState<_, _, _>) : azurerm.LogAnalyticsQueryPackQuery.LogAnalyticsQueryPackQuery =
            Unchecked.defaultof<azurerm.LogAnalyticsQueryPackQuery.LogAnalyticsQueryPackQuery>
