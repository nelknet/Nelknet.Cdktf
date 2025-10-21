namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatadogMonitorTagRuleState<'DatadogMonitorId> = { assignments: ResizeArray<azurerm.DatadogMonitorTagRule.DatadogMonitorTagRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_tag_rule">azurerm_datadog_monitor_tag_rule</a>.
    /// </summary>
    type DatadogMonitorTagRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatadogMonitorTagRuleState<Missing> =
            ({ assignments = ResizeArray() } : DatadogMonitorTagRuleState<Missing>)

        member _.Zero(()) : DatadogMonitorTagRuleState<Missing> =
            ({ assignments = ResizeArray() } : DatadogMonitorTagRuleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_tag_rule#datadog_monitor_id-1">DatadogMonitorTagRule#datadog_monitor_id</a>.
        /// </summary>
        [<CustomOperation "datadog_monitor_id">]
        member _.DatadogMonitorId(state: DatadogMonitorTagRuleState<Missing>, value: string) : DatadogMonitorTagRuleState<Present> =
            state.assignments.Add(fun config -> config.DatadogMonitorId <- value)
            ({ assignments = state.assignments } : DatadogMonitorTagRuleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_tag_rule#id-1">DatadogMonitorTagRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatadogMonitorTagRuleState<'DatadogMonitorId>, value: string) : DatadogMonitorTagRuleState<'DatadogMonitorId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatadogMonitorTagRuleState<'DatadogMonitorId>

        /// <summary>
        /// log block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_tag_rule#log-1">DatadogMonitorTagRule#log</a> Accepts: azurerm.IResolvable | azurerm.DatadogMonitorTagRule.DatadogMonitorTagRuleLog[]
        /// </summary>
        [<CustomOperation "log">]
        member _.Log(state: DatadogMonitorTagRuleState<'DatadogMonitorId>, value: HashiCorp.Cdktf.IResolvable) : DatadogMonitorTagRuleState<'DatadogMonitorId> =
            state.assignments.Add(fun config -> config.Log <- value)
            state : DatadogMonitorTagRuleState<'DatadogMonitorId>

        /// <summary>
        /// metric block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_tag_rule#metric-1">DatadogMonitorTagRule#metric</a> Accepts: azurerm.IResolvable | azurerm.DatadogMonitorTagRule.DatadogMonitorTagRuleMetric[]
        /// </summary>
        [<CustomOperation "metric">]
        member _.Metric(state: DatadogMonitorTagRuleState<'DatadogMonitorId>, value: HashiCorp.Cdktf.IResolvable) : DatadogMonitorTagRuleState<'DatadogMonitorId> =
            state.assignments.Add(fun config -> config.Metric <- value)
            state : DatadogMonitorTagRuleState<'DatadogMonitorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_tag_rule#name-1">DatadogMonitorTagRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatadogMonitorTagRuleState<'DatadogMonitorId>, value: string) : DatadogMonitorTagRuleState<'DatadogMonitorId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DatadogMonitorTagRuleState<'DatadogMonitorId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_tag_rule#timeouts-1">DatadogMonitorTagRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatadogMonitorTagRuleState<'DatadogMonitorId>, value: azurerm.DatadogMonitorTagRule.DatadogMonitorTagRuleTimeouts) : DatadogMonitorTagRuleState<'DatadogMonitorId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatadogMonitorTagRuleState<'DatadogMonitorId>

        member _.Run(state: DatadogMonitorTagRuleState<Present>) : azurerm.DatadogMonitorTagRule.DatadogMonitorTagRule =
            let config = azurerm.DatadogMonitorTagRule.DatadogMonitorTagRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DatadogMonitorTagRule.DatadogMonitorTagRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.datadogMonitorTagRule: missing required arguments. Must call: datadog_monitor_id.", 9999, IsError = true)>]
        member _.Run(_: DatadogMonitorTagRuleState<_>) : azurerm.DatadogMonitorTagRule.DatadogMonitorTagRule =
            Unchecked.defaultof<azurerm.DatadogMonitorTagRule.DatadogMonitorTagRule>
