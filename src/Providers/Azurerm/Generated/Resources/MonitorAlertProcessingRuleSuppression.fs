namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes> = { assignments: ResizeArray<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression">azurerm_monitor_alert_processing_rule_suppression</a>.
    /// </summary>
    type MonitorAlertProcessingRuleSuppressionBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorAlertProcessingRuleSuppressionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorAlertProcessingRuleSuppressionState<Missing, Missing, Missing>)

        member _.Zero(()) : MonitorAlertProcessingRuleSuppressionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorAlertProcessingRuleSuppressionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#name-1">MonitorAlertProcessingRuleSuppression#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorAlertProcessingRuleSuppressionState<Missing, 'ResourceGroupName, 'Scopes>, value: string) : MonitorAlertProcessingRuleSuppressionState<Present, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorAlertProcessingRuleSuppressionState<Present, 'ResourceGroupName, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#resource_group_name-1">MonitorAlertProcessingRuleSuppression#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorAlertProcessingRuleSuppressionState<'Name, Missing, 'Scopes>, value: string) : MonitorAlertProcessingRuleSuppressionState<'Name, Present, 'Scopes> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorAlertProcessingRuleSuppressionState<'Name, Present, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#scopes-1">MonitorAlertProcessingRuleSuppression#scopes</a>.
        /// </summary>
        [<CustomOperation "scopes">]
        member _.Scopes(state: MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, Missing>, value: seq<string>) : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Scopes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// condition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#condition-1">MonitorAlertProcessingRuleSuppression#condition</a>
        /// </summary>
        [<CustomOperation "condition">]
        member _.Condition(state: MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>, value: azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionCondition) : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Condition <- value)
            state : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#description-1">MonitorAlertProcessingRuleSuppression#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>, value: string) : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#enabled-1">MonitorAlertProcessingRuleSuppression#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>, value: bool) : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#enabled-1">MonitorAlertProcessingRuleSuppression#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>, value: HashiCorp.Cdktf.IResolvable) : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#id-1">MonitorAlertProcessingRuleSuppression#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>, value: string) : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#schedule-1">MonitorAlertProcessingRuleSuppression#schedule</a>
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>, value: azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionSchedule) : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            state : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#tags-1">MonitorAlertProcessingRuleSuppression#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>, value: seq<string * string>) : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#timeouts-1">MonitorAlertProcessingRuleSuppression#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>, value: azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionTimeouts) : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorAlertProcessingRuleSuppressionState<'Name, 'ResourceGroupName, 'Scopes>

        member _.Run(state: MonitorAlertProcessingRuleSuppressionState<Present, Present, Present>) : azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppression =
            let config = azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppression(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorAlertProcessingRuleSuppression: missing required arguments. Must call: name, resource_group_name, scopes.", 9999, IsError = true)>]
        member _.Run(_: MonitorAlertProcessingRuleSuppressionState<_, _, _>) : azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppression =
            Unchecked.defaultof<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppression>
