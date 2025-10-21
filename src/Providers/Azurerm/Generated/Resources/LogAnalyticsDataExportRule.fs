namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId> = { assignments: ResizeArray<azurerm.LogAnalyticsDataExportRule.LogAnalyticsDataExportRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_data_export_rule">azurerm_log_analytics_data_export_rule</a>.
    /// </summary>
    type LogAnalyticsDataExportRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsDataExportRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsDataExportRuleState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogAnalyticsDataExportRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsDataExportRuleState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_data_export_rule#destination_resource_id-1">LogAnalyticsDataExportRule#destination_resource_id</a>.
        /// </summary>
        [<CustomOperation "destination_resource_id">]
        member _.DestinationResourceId(state: LogAnalyticsDataExportRuleState<Missing, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId>, value: string) : LogAnalyticsDataExportRuleState<Present, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.DestinationResourceId <- value)
            ({ assignments = state.assignments } : LogAnalyticsDataExportRuleState<Present, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_data_export_rule#name-1">LogAnalyticsDataExportRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogAnalyticsDataExportRuleState<'DestinationResourceId, Missing, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId>, value: string) : LogAnalyticsDataExportRuleState<'DestinationResourceId, Present, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogAnalyticsDataExportRuleState<'DestinationResourceId, Present, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_data_export_rule#resource_group_name-1">LogAnalyticsDataExportRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, Missing, 'TableNames, 'WorkspaceResourceId>, value: string) : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, Present, 'TableNames, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, Present, 'TableNames, 'WorkspaceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_data_export_rule#table_names-1">LogAnalyticsDataExportRule#table_names</a>.
        /// </summary>
        [<CustomOperation "table_names">]
        member _.TableNames(state: LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, Missing, 'WorkspaceResourceId>, value: seq<string>) : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, Present, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.TableNames <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, Present, 'WorkspaceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_data_export_rule#workspace_resource_id-1">LogAnalyticsDataExportRule#workspace_resource_id</a>.
        /// </summary>
        [<CustomOperation "workspace_resource_id">]
        member _.WorkspaceResourceId(state: LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, Missing>, value: string) : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, Present> =
            state.assignments.Add(fun config -> config.WorkspaceResourceId <- value)
            ({ assignments = state.assignments } : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_data_export_rule#enabled-1">LogAnalyticsDataExportRule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId>, value: bool) : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_data_export_rule#enabled-1">LogAnalyticsDataExportRule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId>, value: HashiCorp.Cdktf.IResolvable) : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_data_export_rule#id-1">LogAnalyticsDataExportRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId>, value: string) : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_data_export_rule#timeouts-1">LogAnalyticsDataExportRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId>, value: azurerm.LogAnalyticsDataExportRule.LogAnalyticsDataExportRuleTimeouts) : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsDataExportRuleState<'DestinationResourceId, 'Name, 'ResourceGroupName, 'TableNames, 'WorkspaceResourceId>

        member _.Run(state: LogAnalyticsDataExportRuleState<Present, Present, Present, Present, Present>) : azurerm.LogAnalyticsDataExportRule.LogAnalyticsDataExportRule =
            let config = azurerm.LogAnalyticsDataExportRule.LogAnalyticsDataExportRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsDataExportRule.LogAnalyticsDataExportRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsDataExportRule: missing required arguments. Must call: destination_resource_id, name, resource_group_name, table_names, workspace_resource_id.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsDataExportRuleState<_, _, _, _, _>) : azurerm.LogAnalyticsDataExportRule.LogAnalyticsDataExportRule =
            Unchecked.defaultof<azurerm.LogAnalyticsDataExportRule.LogAnalyticsDataExportRule>
