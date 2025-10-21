namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.MonitorScheduledQueryRulesLog.MonitorScheduledQueryRulesLogConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_log">azurerm_monitor_scheduled_query_rules_log</a>.
    /// </summary>
    type MonitorScheduledQueryRulesLogBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorScheduledQueryRulesLogState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorScheduledQueryRulesLogState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MonitorScheduledQueryRulesLogState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorScheduledQueryRulesLogState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// criteria block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_log#criteria-1">MonitorScheduledQueryRulesLog#criteria</a>
        /// </summary>
        [<CustomOperation "criteria">]
        member _.Criteria(state: MonitorScheduledQueryRulesLogState<Missing, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.MonitorScheduledQueryRulesLog.MonitorScheduledQueryRulesLogCriteria) : MonitorScheduledQueryRulesLogState<Present, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Criteria <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesLogState<Present, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_log#data_source_id-1">MonitorScheduledQueryRulesLog#data_source_id</a>.
        /// </summary>
        [<CustomOperation "data_source_id">]
        member _.DataSourceId(state: MonitorScheduledQueryRulesLogState<'Criteria, Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : MonitorScheduledQueryRulesLogState<'Criteria, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DataSourceId <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesLogState<'Criteria, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_log#location-1">MonitorScheduledQueryRulesLog#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, Missing, 'Name, 'ResourceGroupName>, value: string) : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_log#name-1">MonitorScheduledQueryRulesLog#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, Missing, 'ResourceGroupName>, value: string) : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_log#resource_group_name-1">MonitorScheduledQueryRulesLog#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, Missing>, value: string) : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_log#authorized_resource_ids-1">MonitorScheduledQueryRulesLog#authorized_resource_ids</a>.
        /// </summary>
        [<CustomOperation "authorized_resource_ids">]
        member _.AuthorizedResourceIds(state: MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuthorizedResourceIds <- (value |> Seq.toArray))
            state : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_log#description-1">MonitorScheduledQueryRulesLog#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>, value: string) : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_log#enabled-1">MonitorScheduledQueryRulesLog#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>, value: bool) : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_log#enabled-1">MonitorScheduledQueryRulesLog#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_log#id-1">MonitorScheduledQueryRulesLog#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>, value: string) : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_log#tags-1">MonitorScheduledQueryRulesLog#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_log#timeouts-1">MonitorScheduledQueryRulesLog#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.MonitorScheduledQueryRulesLog.MonitorScheduledQueryRulesLogTimeouts) : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorScheduledQueryRulesLogState<'Criteria, 'DataSourceId, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: MonitorScheduledQueryRulesLogState<Present, Present, Present, Present, Present>) : azurerm.MonitorScheduledQueryRulesLog.MonitorScheduledQueryRulesLog =
            let config = azurerm.MonitorScheduledQueryRulesLog.MonitorScheduledQueryRulesLogConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorScheduledQueryRulesLog.MonitorScheduledQueryRulesLog(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorScheduledQueryRulesLog: missing required arguments. Must call: criteria, data_source_id, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: MonitorScheduledQueryRulesLogState<_, _, _, _, _>) : azurerm.MonitorScheduledQueryRulesLog.MonitorScheduledQueryRulesLog =
            Unchecked.defaultof<azurerm.MonitorScheduledQueryRulesLog.MonitorScheduledQueryRulesLog>
