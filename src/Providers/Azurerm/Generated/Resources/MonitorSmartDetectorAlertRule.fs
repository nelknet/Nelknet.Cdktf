namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity> = { assignments: ResizeArray<azurerm.MonitorSmartDetectorAlertRule.MonitorSmartDetectorAlertRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule">azurerm_monitor_smart_detector_alert_rule</a>.
    /// </summary>
    type MonitorSmartDetectorAlertRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorSmartDetectorAlertRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorSmartDetectorAlertRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MonitorSmartDetectorAlertRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorSmartDetectorAlertRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// action_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#action_group-1">MonitorSmartDetectorAlertRule#action_group</a>
        /// </summary>
        [<CustomOperation "action_group">]
        member _.ActionGroup(state: MonitorSmartDetectorAlertRuleState<Missing, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>, value: azurerm.MonitorSmartDetectorAlertRule.MonitorSmartDetectorAlertRuleActionGroup) : MonitorSmartDetectorAlertRuleState<Present, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity> =
            state.assignments.Add(fun config -> config.ActionGroup <- value)
            ({ assignments = state.assignments } : MonitorSmartDetectorAlertRuleState<Present, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#detector_type-1">MonitorSmartDetectorAlertRule#detector_type</a>.
        /// </summary>
        [<CustomOperation "detector_type">]
        member _.DetectorType(state: MonitorSmartDetectorAlertRuleState<'ActionGroup, Missing, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>, value: string) : MonitorSmartDetectorAlertRuleState<'ActionGroup, Present, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity> =
            state.assignments.Add(fun config -> config.DetectorType <- value)
            ({ assignments = state.assignments } : MonitorSmartDetectorAlertRuleState<'ActionGroup, Present, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#frequency-1">MonitorSmartDetectorAlertRule#frequency</a>.
        /// </summary>
        [<CustomOperation "frequency">]
        member _.Frequency(state: MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, Missing, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>, value: string) : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, Present, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity> =
            state.assignments.Add(fun config -> config.Frequency <- value)
            ({ assignments = state.assignments } : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, Present, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#name-1">MonitorSmartDetectorAlertRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, Missing, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>, value: string) : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, Present, 'ResourceGroupName, 'ScopeResourceIds, 'Severity> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, Present, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#resource_group_name-1">MonitorSmartDetectorAlertRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, Missing, 'ScopeResourceIds, 'Severity>, value: string) : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, Present, 'ScopeResourceIds, 'Severity> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, Present, 'ScopeResourceIds, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#scope_resource_ids-1">MonitorSmartDetectorAlertRule#scope_resource_ids</a>.
        /// </summary>
        [<CustomOperation "scope_resource_ids">]
        member _.ScopeResourceIds(state: MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, Missing, 'Severity>, value: seq<string>) : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, Present, 'Severity> =
            state.assignments.Add(fun config -> config.ScopeResourceIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, Present, 'Severity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#severity-1">MonitorSmartDetectorAlertRule#severity</a>.
        /// </summary>
        [<CustomOperation "severity">]
        member _.Severity(state: MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, Missing>, value: string) : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, Present> =
            state.assignments.Add(fun config -> config.Severity <- value)
            ({ assignments = state.assignments } : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#description-1">MonitorSmartDetectorAlertRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>, value: string) : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#enabled-1">MonitorSmartDetectorAlertRule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>, value: bool) : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#enabled-1">MonitorSmartDetectorAlertRule#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>, value: HashiCorp.Cdktf.IResolvable) : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#id-1">MonitorSmartDetectorAlertRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>, value: string) : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#tags-1">MonitorSmartDetectorAlertRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>, value: seq<string * string>) : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#throttling_duration-1">MonitorSmartDetectorAlertRule#throttling_duration</a>.
        /// </summary>
        [<CustomOperation "throttling_duration">]
        member _.ThrottlingDuration(state: MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>, value: string) : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity> =
            state.assignments.Add(fun config -> config.ThrottlingDuration <- value)
            state : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#timeouts-1">MonitorSmartDetectorAlertRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>, value: azurerm.MonitorSmartDetectorAlertRule.MonitorSmartDetectorAlertRuleTimeouts) : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorSmartDetectorAlertRuleState<'ActionGroup, 'DetectorType, 'Frequency, 'Name, 'ResourceGroupName, 'ScopeResourceIds, 'Severity>

        member _.Run(state: MonitorSmartDetectorAlertRuleState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.MonitorSmartDetectorAlertRule.MonitorSmartDetectorAlertRule =
            let config = azurerm.MonitorSmartDetectorAlertRule.MonitorSmartDetectorAlertRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorSmartDetectorAlertRule.MonitorSmartDetectorAlertRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorSmartDetectorAlertRule: missing required arguments. Must call: action_group, detector_type, frequency, name, resource_group_name, scope_resource_ids, severity.", 9999, IsError = true)>]
        member _.Run(_: MonitorSmartDetectorAlertRuleState<_, _, _, _, _, _, _>) : azurerm.MonitorSmartDetectorAlertRule.MonitorSmartDetectorAlertRule =
            Unchecked.defaultof<azurerm.MonitorSmartDetectorAlertRule.MonitorSmartDetectorAlertRule>
