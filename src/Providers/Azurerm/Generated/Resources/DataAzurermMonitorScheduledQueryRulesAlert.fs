namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMonitorScheduledQueryRulesAlertState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermMonitorScheduledQueryRulesAlert.DataAzurermMonitorScheduledQueryRulesAlertConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_scheduled_query_rules_alert">azurerm_monitor_scheduled_query_rules_alert</a>.
    /// </summary>
    type DataAzurermMonitorScheduledQueryRulesAlertBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMonitorScheduledQueryRulesAlertState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorScheduledQueryRulesAlertState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMonitorScheduledQueryRulesAlertState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorScheduledQueryRulesAlertState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_scheduled_query_rules_alert#name-1">DataAzurermMonitorScheduledQueryRulesAlert#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMonitorScheduledQueryRulesAlertState<Missing, 'ResourceGroupName>, value: string) : DataAzurermMonitorScheduledQueryRulesAlertState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMonitorScheduledQueryRulesAlertState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_scheduled_query_rules_alert#resource_group_name-1">DataAzurermMonitorScheduledQueryRulesAlert#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMonitorScheduledQueryRulesAlertState<'Name, Missing>, value: string) : DataAzurermMonitorScheduledQueryRulesAlertState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMonitorScheduledQueryRulesAlertState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_scheduled_query_rules_alert#id-1">DataAzurermMonitorScheduledQueryRulesAlert#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMonitorScheduledQueryRulesAlertState<'Name, 'ResourceGroupName>, value: string) : DataAzurermMonitorScheduledQueryRulesAlertState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMonitorScheduledQueryRulesAlertState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_scheduled_query_rules_alert#timeouts-1">DataAzurermMonitorScheduledQueryRulesAlert#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMonitorScheduledQueryRulesAlertState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermMonitorScheduledQueryRulesAlert.DataAzurermMonitorScheduledQueryRulesAlertTimeouts) : DataAzurermMonitorScheduledQueryRulesAlertState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMonitorScheduledQueryRulesAlertState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermMonitorScheduledQueryRulesAlertState<Present, Present>) : azurerm.DataAzurermMonitorScheduledQueryRulesAlert.DataAzurermMonitorScheduledQueryRulesAlert =
            let config = azurerm.DataAzurermMonitorScheduledQueryRulesAlert.DataAzurermMonitorScheduledQueryRulesAlertConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMonitorScheduledQueryRulesAlert.DataAzurermMonitorScheduledQueryRulesAlert(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMonitorScheduledQueryRulesAlert: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMonitorScheduledQueryRulesAlertState<_, _>) : azurerm.DataAzurermMonitorScheduledQueryRulesAlert.DataAzurermMonitorScheduledQueryRulesAlert =
            Unchecked.defaultof<azurerm.DataAzurermMonitorScheduledQueryRulesAlert.DataAzurermMonitorScheduledQueryRulesAlert>
