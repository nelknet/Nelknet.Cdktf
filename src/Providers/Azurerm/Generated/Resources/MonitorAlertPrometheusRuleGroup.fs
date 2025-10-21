namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes> = { assignments: ResizeArray<azurerm.MonitorAlertPrometheusRuleGroup.MonitorAlertPrometheusRuleGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group">azurerm_monitor_alert_prometheus_rule_group</a>.
    /// </summary>
    type MonitorAlertPrometheusRuleGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorAlertPrometheusRuleGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorAlertPrometheusRuleGroupState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MonitorAlertPrometheusRuleGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorAlertPrometheusRuleGroupState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#location-1">MonitorAlertPrometheusRuleGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MonitorAlertPrometheusRuleGroupState<Missing, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>, value: string) : MonitorAlertPrometheusRuleGroupState<Present, 'Name, 'ResourceGroupName, 'Rule, 'Scopes> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MonitorAlertPrometheusRuleGroupState<Present, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#name-1">MonitorAlertPrometheusRuleGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorAlertPrometheusRuleGroupState<'Location, Missing, 'ResourceGroupName, 'Rule, 'Scopes>, value: string) : MonitorAlertPrometheusRuleGroupState<'Location, Present, 'ResourceGroupName, 'Rule, 'Scopes> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorAlertPrometheusRuleGroupState<'Location, Present, 'ResourceGroupName, 'Rule, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#resource_group_name-1">MonitorAlertPrometheusRuleGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorAlertPrometheusRuleGroupState<'Location, 'Name, Missing, 'Rule, 'Scopes>, value: string) : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, Present, 'Rule, 'Scopes> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, Present, 'Rule, 'Scopes>)

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#rule-1">MonitorAlertPrometheusRuleGroup#rule</a> Accepts: azurerm.IResolvable | azurerm.MonitorAlertPrometheusRuleGroup.MonitorAlertPrometheusRuleGroupRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, Missing, 'Scopes>, value: HashiCorp.Cdktf.IResolvable) : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, Present, 'Scopes> =
            state.assignments.Add(fun config -> config.Rule <- value)
            ({ assignments = state.assignments } : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, Present, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#scopes-1">MonitorAlertPrometheusRuleGroup#scopes</a>.
        /// </summary>
        [<CustomOperation "scopes">]
        member _.Scopes(state: MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, Missing>, value: seq<string>) : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, Present> =
            state.assignments.Add(fun config -> config.Scopes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#cluster_name-1">MonitorAlertPrometheusRuleGroup#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>, value: string) : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            state : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#description-1">MonitorAlertPrometheusRuleGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>, value: string) : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#id-1">MonitorAlertPrometheusRuleGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>, value: string) : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#interval-1">MonitorAlertPrometheusRuleGroup#interval</a>.
        /// </summary>
        [<CustomOperation "interval">]
        member _.Interval(state: MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>, value: string) : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes> =
            state.assignments.Add(fun config -> config.Interval <- value)
            state : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#rule_group_enabled-1">MonitorAlertPrometheusRuleGroup#rule_group_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "rule_group_enabled">]
        member _.RuleGroupEnabled(state: MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>, value: bool) : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes> =
            state.assignments.Add(fun config -> config.RuleGroupEnabled <- value)
            state : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#rule_group_enabled-1">MonitorAlertPrometheusRuleGroup#rule_group_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "rule_group_enabled">]
        member _.RuleGroupEnabled(state: MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>, value: HashiCorp.Cdktf.IResolvable) : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes> =
            state.assignments.Add(fun config -> config.RuleGroupEnabled <- value)
            state : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#tags-1">MonitorAlertPrometheusRuleGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>, value: seq<string * string>) : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#timeouts-1">MonitorAlertPrometheusRuleGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>, value: azurerm.MonitorAlertPrometheusRuleGroup.MonitorAlertPrometheusRuleGroupTimeouts) : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorAlertPrometheusRuleGroupState<'Location, 'Name, 'ResourceGroupName, 'Rule, 'Scopes>

        member _.Run(state: MonitorAlertPrometheusRuleGroupState<Present, Present, Present, Present, Present>) : azurerm.MonitorAlertPrometheusRuleGroup.MonitorAlertPrometheusRuleGroup =
            let config = azurerm.MonitorAlertPrometheusRuleGroup.MonitorAlertPrometheusRuleGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorAlertPrometheusRuleGroup.MonitorAlertPrometheusRuleGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorAlertPrometheusRuleGroup: missing required arguments. Must call: location, name, resource_group_name, rule, scopes.", 9999, IsError = true)>]
        member _.Run(_: MonitorAlertPrometheusRuleGroupState<_, _, _, _, _>) : azurerm.MonitorAlertPrometheusRuleGroup.MonitorAlertPrometheusRuleGroup =
            Unchecked.defaultof<azurerm.MonitorAlertPrometheusRuleGroup.MonitorAlertPrometheusRuleGroup>
