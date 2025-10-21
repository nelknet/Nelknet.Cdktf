namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> = { assignments: ResizeArray<azurerm.MonitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2Config -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2">azurerm_monitor_scheduled_query_rules_alert_v2</a>.
    /// </summary>
    type MonitorScheduledQueryRulesAlertV2Builder(logicalId: string) =
        member _.Yield(_: unit) : MonitorScheduledQueryRulesAlertV2State<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorScheduledQueryRulesAlertV2State<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MonitorScheduledQueryRulesAlertV2State<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorScheduledQueryRulesAlertV2State<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// criteria block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#criteria-1">MonitorScheduledQueryRulesAlertV2#criteria</a> Accepts: azurerm.IResolvable | azurerm.MonitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2Criteria[]
        /// </summary>
        [<CustomOperation "criteria">]
        member _.Criteria(state: MonitorScheduledQueryRulesAlertV2State<Missing, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: HashiCorp.Cdktf.IResolvable) : MonitorScheduledQueryRulesAlertV2State<Present, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.Criteria <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertV2State<Present, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#evaluation_frequency-1">MonitorScheduledQueryRulesAlertV2#evaluation_frequency</a>.
        /// </summary>
        [<CustomOperation "evaluation_frequency">]
        member _.EvaluationFrequency(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, Missing, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: string) : MonitorScheduledQueryRulesAlertV2State<'Criteria, Present, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.EvaluationFrequency <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertV2State<'Criteria, Present, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#location-1">MonitorScheduledQueryRulesAlertV2#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, Missing, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: string) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, Present, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, Present, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#name-1">MonitorScheduledQueryRulesAlertV2#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, Missing, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: string) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, Present, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, Present, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#resource_group_name-1">MonitorScheduledQueryRulesAlertV2#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, Missing, 'Scopes, 'Severity, 'WindowDuration>, value: string) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, Present, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, Present, 'Scopes, 'Severity, 'WindowDuration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#scopes-1">MonitorScheduledQueryRulesAlertV2#scopes</a>.
        /// </summary>
        [<CustomOperation "scopes">]
        member _.Scopes(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, Missing, 'Severity, 'WindowDuration>, value: seq<string>) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, Present, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.Scopes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, Present, 'Severity, 'WindowDuration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#severity-1">MonitorScheduledQueryRulesAlertV2#severity</a>.
        /// </summary>
        [<CustomOperation "severity">]
        member _.Severity(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, Missing, 'WindowDuration>, value: double) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, Present, 'WindowDuration> =
            state.assignments.Add(fun config -> config.Severity <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, Present, 'WindowDuration>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#window_duration-1">MonitorScheduledQueryRulesAlertV2#window_duration</a>.
        /// </summary>
        [<CustomOperation "window_duration">]
        member _.WindowDuration(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, Missing>, value: string) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, Present> =
            state.assignments.Add(fun config -> config.WindowDuration <- value)
            ({ assignments = state.assignments } : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, Present>)

        /// <summary>
        /// action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#action-1">MonitorScheduledQueryRulesAlertV2#action</a>
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: azurerm.MonitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2Action) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.Action <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#auto_mitigation_enabled-1">MonitorScheduledQueryRulesAlertV2#auto_mitigation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_mitigation_enabled">]
        member _.AutoMitigationEnabled(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: bool) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.AutoMitigationEnabled <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#auto_mitigation_enabled-1">MonitorScheduledQueryRulesAlertV2#auto_mitigation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_mitigation_enabled">]
        member _.AutoMitigationEnabled(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: HashiCorp.Cdktf.IResolvable) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.AutoMitigationEnabled <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#description-1">MonitorScheduledQueryRulesAlertV2#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: string) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#display_name-1">MonitorScheduledQueryRulesAlertV2#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: string) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#enabled-1">MonitorScheduledQueryRulesAlertV2#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: bool) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#enabled-1">MonitorScheduledQueryRulesAlertV2#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: HashiCorp.Cdktf.IResolvable) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#id-1">MonitorScheduledQueryRulesAlertV2#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: string) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#identity-1">MonitorScheduledQueryRulesAlertV2#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: azurerm.MonitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2Identity) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#mute_actions_after_alert_duration-1">MonitorScheduledQueryRulesAlertV2#mute_actions_after_alert_duration</a>.
        /// </summary>
        [<CustomOperation "mute_actions_after_alert_duration">]
        member _.MuteActionsAfterAlertDuration(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: string) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.MuteActionsAfterAlertDuration <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#query_time_range_override-1">MonitorScheduledQueryRulesAlertV2#query_time_range_override</a>.
        /// </summary>
        [<CustomOperation "query_time_range_override">]
        member _.QueryTimeRangeOverride(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: string) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.QueryTimeRangeOverride <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#skip_query_validation-1">MonitorScheduledQueryRulesAlertV2#skip_query_validation</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "skip_query_validation">]
        member _.SkipQueryValidation(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: bool) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.SkipQueryValidation <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#skip_query_validation-1">MonitorScheduledQueryRulesAlertV2#skip_query_validation</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "skip_query_validation">]
        member _.SkipQueryValidation(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: HashiCorp.Cdktf.IResolvable) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.SkipQueryValidation <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#tags-1">MonitorScheduledQueryRulesAlertV2#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: seq<string * string>) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#target_resource_types-1">MonitorScheduledQueryRulesAlertV2#target_resource_types</a>.
        /// </summary>
        [<CustomOperation "target_resource_types">]
        member _.TargetResourceTypes(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: seq<string>) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.TargetResourceTypes <- (value |> Seq.toArray))
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#timeouts-1">MonitorScheduledQueryRulesAlertV2#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: azurerm.MonitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2Timeouts) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#workspace_alerts_storage_enabled-1">MonitorScheduledQueryRulesAlertV2#workspace_alerts_storage_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "workspace_alerts_storage_enabled">]
        member _.WorkspaceAlertsStorageEnabled(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: bool) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.WorkspaceAlertsStorageEnabled <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#workspace_alerts_storage_enabled-1">MonitorScheduledQueryRulesAlertV2#workspace_alerts_storage_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "workspace_alerts_storage_enabled">]
        member _.WorkspaceAlertsStorageEnabled(state: MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>, value: HashiCorp.Cdktf.IResolvable) : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration> =
            state.assignments.Add(fun config -> config.WorkspaceAlertsStorageEnabled <- value)
            state : MonitorScheduledQueryRulesAlertV2State<'Criteria, 'EvaluationFrequency, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Severity, 'WindowDuration>

        member _.Run(state: MonitorScheduledQueryRulesAlertV2State<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.MonitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2 =
            let config = azurerm.MonitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2Config()
            for setter in state.assignments do
                setter config
            azurerm.MonitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorScheduledQueryRulesAlertV2: missing required arguments. Must call: criteria, evaluation_frequency, location, name, resource_group_name, scopes, severity, window_duration.", 9999, IsError = true)>]
        member _.Run(_: MonitorScheduledQueryRulesAlertV2State<_, _, _, _, _, _, _, _>) : azurerm.MonitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2 =
            Unchecked.defaultof<azurerm.MonitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2>
