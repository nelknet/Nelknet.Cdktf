namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> = { assignments: ResizeArray<azurerm.MonitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlertConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert">azurerm_monitor_scheduled_query_rules_alert</a>.
    /// </summary>
    type MonitorScheduledQueryRulesAlertBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorScheduledQueryRulesAlertState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorScheduledQueryRulesAlertState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MonitorScheduledQueryRulesAlertState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorScheduledQueryRulesAlertState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#action-1">MonitorScheduledQueryRulesAlert#action</a>
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: MonitorScheduledQueryRulesAlertState<Missing, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: azurerm.MonitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlertAction) : MonitorScheduledQueryRulesAlertState<Present, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertState<Present, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#data_source_id-1">MonitorScheduledQueryRulesAlert#data_source_id</a>.
        /// </summary>
        [<CustomOperation "data_source_id">]
        member _.DataSourceId(state: MonitorScheduledQueryRulesAlertState<'Action, Missing, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: string) : MonitorScheduledQueryRulesAlertState<'Action, Present, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.DataSourceId <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertState<'Action, Present, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#frequency-1">MonitorScheduledQueryRulesAlert#frequency</a>.
        /// </summary>
        [<CustomOperation "frequency">]
        member _.Frequency(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, Missing, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: double) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, Present, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.Frequency <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, Present, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#location-1">MonitorScheduledQueryRulesAlert#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, Missing, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: string) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, Present, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, Present, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#name-1">MonitorScheduledQueryRulesAlert#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, Missing, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: string) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, Present, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, Present, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#query-1">MonitorScheduledQueryRulesAlert#query</a>.
        /// </summary>
        [<CustomOperation "query">]
        member _.Query(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, Missing, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: string) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, Present, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.Query <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, Present, 'ResourceGroupName, 'TimeWindow, 'Trigger>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#resource_group_name-1">MonitorScheduledQueryRulesAlert#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, Missing, 'TimeWindow, 'Trigger>, value: string) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, Present, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, Present, 'TimeWindow, 'Trigger>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#time_window-1">MonitorScheduledQueryRulesAlert#time_window</a>.
        /// </summary>
        [<CustomOperation "time_window">]
        member _.TimeWindow(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, Missing, 'Trigger>, value: double) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, Present, 'Trigger> =
            state.assignments.Add(fun config -> config.TimeWindow <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, Present, 'Trigger>)

        /// <summary>
        /// trigger block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#trigger-1">MonitorScheduledQueryRulesAlert#trigger</a>
        /// </summary>
        [<CustomOperation "trigger">]
        member _.Trigger(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, Missing>, value: azurerm.MonitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlertTrigger) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, Present> =
            state.assignments.Add(fun config -> config.Trigger <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#authorized_resource_ids-1">MonitorScheduledQueryRulesAlert#authorized_resource_ids</a>.
        /// </summary>
        [<CustomOperation "authorized_resource_ids">]
        member _.AuthorizedResourceIds(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: seq<string>) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.AuthorizedResourceIds <- (value |> Seq.toArray))
            state : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#auto_mitigation_enabled-1">MonitorScheduledQueryRulesAlert#auto_mitigation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_mitigation_enabled">]
        member _.AutoMitigationEnabled(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: bool) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.AutoMitigationEnabled <- value)
            state : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#auto_mitigation_enabled-1">MonitorScheduledQueryRulesAlert#auto_mitigation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_mitigation_enabled">]
        member _.AutoMitigationEnabled(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: HashiCorp.Cdktf.IResolvable) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.AutoMitigationEnabled <- value)
            state : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#description-1">MonitorScheduledQueryRulesAlert#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: string) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#enabled-1">MonitorScheduledQueryRulesAlert#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: bool) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#enabled-1">MonitorScheduledQueryRulesAlert#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: HashiCorp.Cdktf.IResolvable) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#id-1">MonitorScheduledQueryRulesAlert#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: string) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#query_type-1">MonitorScheduledQueryRulesAlert#query_type</a>.
        /// </summary>
        [<CustomOperation "query_type">]
        member _.QueryType(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: string) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.QueryType <- value)
            state : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#severity-1">MonitorScheduledQueryRulesAlert#severity</a>.
        /// </summary>
        [<CustomOperation "severity">]
        member _.Severity(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: double) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.Severity <- value)
            state : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#tags-1">MonitorScheduledQueryRulesAlert#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: seq<string * string>) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#throttling-1">MonitorScheduledQueryRulesAlert#throttling</a>.
        /// </summary>
        [<CustomOperation "throttling">]
        member _.Throttling(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: double) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.Throttling <- value)
            state : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#timeouts-1">MonitorScheduledQueryRulesAlert#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>, value: azurerm.MonitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlertTimeouts) : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorScheduledQueryRulesAlertState<'Action, 'DataSourceId, 'Frequency, 'Location, 'Name, 'Query, 'ResourceGroupName, 'TimeWindow, 'Trigger>

        member _.Run(state: MonitorScheduledQueryRulesAlertState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.MonitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlert =
            let config = azurerm.MonitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlertConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlert(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorScheduledQueryRulesAlert: missing required arguments. Must call: action, data_source_id, frequency, location, name, query, resource_group_name, time_window, trigger.", 9999, IsError = true)>]
        member _.Run(_: MonitorScheduledQueryRulesAlertState<_, _, _, _, _, _, _, _, _>) : azurerm.MonitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlert =
            Unchecked.defaultof<azurerm.MonitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlert>
