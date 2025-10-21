namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, 'Name, 'ResourceGroupName, 'WorkspaceName> = { assignments: ResizeArray<azurerm.LogAnalyticsDatasourceWindowsEvent.LogAnalyticsDatasourceWindowsEventConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_event">azurerm_log_analytics_datasource_windows_event</a>.
    /// </summary>
    type LogAnalyticsDatasourceWindowsEventBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsDatasourceWindowsEventState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsDatasourceWindowsEventState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogAnalyticsDatasourceWindowsEventState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsDatasourceWindowsEventState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_event#event_log_name-1">LogAnalyticsDatasourceWindowsEvent#event_log_name</a>.
        /// </summary>
        [<CustomOperation "event_log_name">]
        member _.EventLogName(state: LogAnalyticsDatasourceWindowsEventState<Missing, 'EventTypes, 'Name, 'ResourceGroupName, 'WorkspaceName>, value: string) : LogAnalyticsDatasourceWindowsEventState<Present, 'EventTypes, 'Name, 'ResourceGroupName, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.EventLogName <- value)
            ({ assignments = state.assignments } : LogAnalyticsDatasourceWindowsEventState<Present, 'EventTypes, 'Name, 'ResourceGroupName, 'WorkspaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_event#event_types-1">LogAnalyticsDatasourceWindowsEvent#event_types</a>.
        /// </summary>
        [<CustomOperation "event_types">]
        member _.EventTypes(state: LogAnalyticsDatasourceWindowsEventState<'EventLogName, Missing, 'Name, 'ResourceGroupName, 'WorkspaceName>, value: seq<string>) : LogAnalyticsDatasourceWindowsEventState<'EventLogName, Present, 'Name, 'ResourceGroupName, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.EventTypes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : LogAnalyticsDatasourceWindowsEventState<'EventLogName, Present, 'Name, 'ResourceGroupName, 'WorkspaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_event#name-1">LogAnalyticsDatasourceWindowsEvent#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, Missing, 'ResourceGroupName, 'WorkspaceName>, value: string) : LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, Present, 'ResourceGroupName, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, Present, 'ResourceGroupName, 'WorkspaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_event#resource_group_name-1">LogAnalyticsDatasourceWindowsEvent#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, 'Name, Missing, 'WorkspaceName>, value: string) : LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, 'Name, Present, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, 'Name, Present, 'WorkspaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_event#workspace_name-1">LogAnalyticsDatasourceWindowsEvent#workspace_name</a>.
        /// </summary>
        [<CustomOperation "workspace_name">]
        member _.WorkspaceName(state: LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, 'Name, 'ResourceGroupName, Missing>, value: string) : LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.WorkspaceName <- value)
            ({ assignments = state.assignments } : LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_event#id-1">LogAnalyticsDatasourceWindowsEvent#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, 'Name, 'ResourceGroupName, 'WorkspaceName>, value: string) : LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, 'Name, 'ResourceGroupName, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, 'Name, 'ResourceGroupName, 'WorkspaceName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_datasource_windows_event#timeouts-1">LogAnalyticsDatasourceWindowsEvent#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, 'Name, 'ResourceGroupName, 'WorkspaceName>, value: azurerm.LogAnalyticsDatasourceWindowsEvent.LogAnalyticsDatasourceWindowsEventTimeouts) : LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, 'Name, 'ResourceGroupName, 'WorkspaceName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsDatasourceWindowsEventState<'EventLogName, 'EventTypes, 'Name, 'ResourceGroupName, 'WorkspaceName>

        member _.Run(state: LogAnalyticsDatasourceWindowsEventState<Present, Present, Present, Present, Present>) : azurerm.LogAnalyticsDatasourceWindowsEvent.LogAnalyticsDatasourceWindowsEvent =
            let config = azurerm.LogAnalyticsDatasourceWindowsEvent.LogAnalyticsDatasourceWindowsEventConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsDatasourceWindowsEvent.LogAnalyticsDatasourceWindowsEvent(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsDatasourceWindowsEvent: missing required arguments. Must call: event_log_name, event_types, name, resource_group_name, workspace_name.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsDatasourceWindowsEventState<_, _, _, _, _>) : azurerm.LogAnalyticsDatasourceWindowsEvent.LogAnalyticsDatasourceWindowsEvent =
            Unchecked.defaultof<azurerm.LogAnalyticsDatasourceWindowsEvent.LogAnalyticsDatasourceWindowsEvent>
