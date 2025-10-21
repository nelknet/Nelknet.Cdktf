namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId> = { assignments: ResizeArray<azurerm.LogAnalyticsWorkspaceTable.LogAnalyticsWorkspaceTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace_table">azurerm_log_analytics_workspace_table</a>.
    /// </summary>
    type LogAnalyticsWorkspaceTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsWorkspaceTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsWorkspaceTableState<Missing, Missing>)

        member _.Zero(()) : LogAnalyticsWorkspaceTableState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsWorkspaceTableState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace_table#name-1">LogAnalyticsWorkspaceTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogAnalyticsWorkspaceTableState<Missing, 'WorkspaceId>, value: string) : LogAnalyticsWorkspaceTableState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogAnalyticsWorkspaceTableState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace_table#workspace_id-1">LogAnalyticsWorkspaceTable#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: LogAnalyticsWorkspaceTableState<'Name, Missing>, value: string) : LogAnalyticsWorkspaceTableState<'Name, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : LogAnalyticsWorkspaceTableState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace_table#id-1">LogAnalyticsWorkspaceTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId>, value: string) : LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace_table#plan-1">LogAnalyticsWorkspaceTable#plan</a>.
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId>, value: string) : LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Plan <- value)
            state : LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace_table#retention_in_days-1">LogAnalyticsWorkspaceTable#retention_in_days</a>.
        /// </summary>
        [<CustomOperation "retention_in_days">]
        member _.RetentionInDays(state: LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId>, value: double) : LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.RetentionInDays <- value)
            state : LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace_table#timeouts-1">LogAnalyticsWorkspaceTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId>, value: azurerm.LogAnalyticsWorkspaceTable.LogAnalyticsWorkspaceTableTimeouts) : LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace_table#total_retention_in_days-1">LogAnalyticsWorkspaceTable#total_retention_in_days</a>.
        /// </summary>
        [<CustomOperation "total_retention_in_days">]
        member _.TotalRetentionInDays(state: LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId>, value: double) : LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.TotalRetentionInDays <- value)
            state : LogAnalyticsWorkspaceTableState<'Name, 'WorkspaceId>

        member _.Run(state: LogAnalyticsWorkspaceTableState<Present, Present>) : azurerm.LogAnalyticsWorkspaceTable.LogAnalyticsWorkspaceTable =
            let config = azurerm.LogAnalyticsWorkspaceTable.LogAnalyticsWorkspaceTableConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsWorkspaceTable.LogAnalyticsWorkspaceTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsWorkspaceTable: missing required arguments. Must call: name, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsWorkspaceTableState<_, _>) : azurerm.LogAnalyticsWorkspaceTable.LogAnalyticsWorkspaceTable =
            Unchecked.defaultof<azurerm.LogAnalyticsWorkspaceTable.LogAnalyticsWorkspaceTable>
