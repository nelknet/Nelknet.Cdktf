namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsQueryPackState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LogAnalyticsQueryPack.LogAnalyticsQueryPackConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack">azurerm_log_analytics_query_pack</a>.
    /// </summary>
    type LogAnalyticsQueryPackBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsQueryPackState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsQueryPackState<Missing, Missing, Missing>)

        member _.Zero(()) : LogAnalyticsQueryPackState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsQueryPackState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack#location-1">LogAnalyticsQueryPack#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LogAnalyticsQueryPackState<Missing, 'Name, 'ResourceGroupName>, value: string) : LogAnalyticsQueryPackState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : LogAnalyticsQueryPackState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack#name-1">LogAnalyticsQueryPack#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogAnalyticsQueryPackState<'Location, Missing, 'ResourceGroupName>, value: string) : LogAnalyticsQueryPackState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogAnalyticsQueryPackState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack#resource_group_name-1">LogAnalyticsQueryPack#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogAnalyticsQueryPackState<'Location, 'Name, Missing>, value: string) : LogAnalyticsQueryPackState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogAnalyticsQueryPackState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack#id-1">LogAnalyticsQueryPack#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsQueryPackState<'Location, 'Name, 'ResourceGroupName>, value: string) : LogAnalyticsQueryPackState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsQueryPackState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack#tags-1">LogAnalyticsQueryPack#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LogAnalyticsQueryPackState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : LogAnalyticsQueryPackState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LogAnalyticsQueryPackState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_query_pack#timeouts-1">LogAnalyticsQueryPack#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsQueryPackState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.LogAnalyticsQueryPack.LogAnalyticsQueryPackTimeouts) : LogAnalyticsQueryPackState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsQueryPackState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: LogAnalyticsQueryPackState<Present, Present, Present>) : azurerm.LogAnalyticsQueryPack.LogAnalyticsQueryPack =
            let config = azurerm.LogAnalyticsQueryPack.LogAnalyticsQueryPackConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsQueryPack.LogAnalyticsQueryPack(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsQueryPack: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsQueryPackState<_, _, _>) : azurerm.LogAnalyticsQueryPack.LogAnalyticsQueryPack =
            Unchecked.defaultof<azurerm.LogAnalyticsQueryPack.LogAnalyticsQueryPack>
