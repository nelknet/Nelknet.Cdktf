namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMonitorScheduledQueryRulesLogState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermMonitorScheduledQueryRulesLog.DataAzurermMonitorScheduledQueryRulesLogConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_scheduled_query_rules_log">azurerm_monitor_scheduled_query_rules_log</a>.
    /// </summary>
    type DataAzurermMonitorScheduledQueryRulesLogBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMonitorScheduledQueryRulesLogState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorScheduledQueryRulesLogState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMonitorScheduledQueryRulesLogState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorScheduledQueryRulesLogState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_scheduled_query_rules_log#name-1">DataAzurermMonitorScheduledQueryRulesLog#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMonitorScheduledQueryRulesLogState<Missing, 'ResourceGroupName>, value: string) : DataAzurermMonitorScheduledQueryRulesLogState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMonitorScheduledQueryRulesLogState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_scheduled_query_rules_log#resource_group_name-1">DataAzurermMonitorScheduledQueryRulesLog#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMonitorScheduledQueryRulesLogState<'Name, Missing>, value: string) : DataAzurermMonitorScheduledQueryRulesLogState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMonitorScheduledQueryRulesLogState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_scheduled_query_rules_log#id-1">DataAzurermMonitorScheduledQueryRulesLog#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMonitorScheduledQueryRulesLogState<'Name, 'ResourceGroupName>, value: string) : DataAzurermMonitorScheduledQueryRulesLogState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMonitorScheduledQueryRulesLogState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_scheduled_query_rules_log#timeouts-1">DataAzurermMonitorScheduledQueryRulesLog#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMonitorScheduledQueryRulesLogState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermMonitorScheduledQueryRulesLog.DataAzurermMonitorScheduledQueryRulesLogTimeouts) : DataAzurermMonitorScheduledQueryRulesLogState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMonitorScheduledQueryRulesLogState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermMonitorScheduledQueryRulesLogState<Present, Present>) : azurerm.DataAzurermMonitorScheduledQueryRulesLog.DataAzurermMonitorScheduledQueryRulesLog =
            let config = azurerm.DataAzurermMonitorScheduledQueryRulesLog.DataAzurermMonitorScheduledQueryRulesLogConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMonitorScheduledQueryRulesLog.DataAzurermMonitorScheduledQueryRulesLog(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMonitorScheduledQueryRulesLog: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMonitorScheduledQueryRulesLogState<_, _>) : azurerm.DataAzurermMonitorScheduledQueryRulesLog.DataAzurermMonitorScheduledQueryRulesLog =
            Unchecked.defaultof<azurerm.DataAzurermMonitorScheduledQueryRulesLog.DataAzurermMonitorScheduledQueryRulesLog>
