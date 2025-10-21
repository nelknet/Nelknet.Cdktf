namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NewRelicTagRuleState<'MonitorId> = { assignments: ResizeArray<azurerm.NewRelicTagRule.NewRelicTagRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule">azurerm_new_relic_tag_rule</a>.
    /// </summary>
    type NewRelicTagRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : NewRelicTagRuleState<Missing> =
            ({ assignments = ResizeArray() } : NewRelicTagRuleState<Missing>)

        member _.Zero(()) : NewRelicTagRuleState<Missing> =
            ({ assignments = ResizeArray() } : NewRelicTagRuleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule#monitor_id-1">NewRelicTagRule#monitor_id</a>.
        /// </summary>
        [<CustomOperation "monitor_id">]
        member _.MonitorId(state: NewRelicTagRuleState<Missing>, value: string) : NewRelicTagRuleState<Present> =
            state.assignments.Add(fun config -> config.MonitorId <- value)
            ({ assignments = state.assignments } : NewRelicTagRuleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule#activity_log_enabled-1">NewRelicTagRule#activity_log_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "activity_log_enabled">]
        member _.ActivityLogEnabled(state: NewRelicTagRuleState<'MonitorId>, value: bool) : NewRelicTagRuleState<'MonitorId> =
            state.assignments.Add(fun config -> config.ActivityLogEnabled <- value)
            state : NewRelicTagRuleState<'MonitorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule#activity_log_enabled-1">NewRelicTagRule#activity_log_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "activity_log_enabled">]
        member _.ActivityLogEnabled(state: NewRelicTagRuleState<'MonitorId>, value: HashiCorp.Cdktf.IResolvable) : NewRelicTagRuleState<'MonitorId> =
            state.assignments.Add(fun config -> config.ActivityLogEnabled <- value)
            state : NewRelicTagRuleState<'MonitorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule#azure_active_directory_log_enabled-1">NewRelicTagRule#azure_active_directory_log_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "azure_active_directory_log_enabled">]
        member _.AzureActiveDirectoryLogEnabled(state: NewRelicTagRuleState<'MonitorId>, value: bool) : NewRelicTagRuleState<'MonitorId> =
            state.assignments.Add(fun config -> config.AzureActiveDirectoryLogEnabled <- value)
            state : NewRelicTagRuleState<'MonitorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule#azure_active_directory_log_enabled-1">NewRelicTagRule#azure_active_directory_log_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "azure_active_directory_log_enabled">]
        member _.AzureActiveDirectoryLogEnabled(state: NewRelicTagRuleState<'MonitorId>, value: HashiCorp.Cdktf.IResolvable) : NewRelicTagRuleState<'MonitorId> =
            state.assignments.Add(fun config -> config.AzureActiveDirectoryLogEnabled <- value)
            state : NewRelicTagRuleState<'MonitorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule#id-1">NewRelicTagRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NewRelicTagRuleState<'MonitorId>, value: string) : NewRelicTagRuleState<'MonitorId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NewRelicTagRuleState<'MonitorId>

        /// <summary>
        /// log_tag_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule#log_tag_filter-1">NewRelicTagRule#log_tag_filter</a> Accepts: azurerm.IResolvable | azurerm.NewRelicTagRule.NewRelicTagRuleLogTagFilter[]
        /// </summary>
        [<CustomOperation "log_tag_filter">]
        member _.LogTagFilter(state: NewRelicTagRuleState<'MonitorId>, value: HashiCorp.Cdktf.IResolvable) : NewRelicTagRuleState<'MonitorId> =
            state.assignments.Add(fun config -> config.LogTagFilter <- value)
            state : NewRelicTagRuleState<'MonitorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule#metric_enabled-1">NewRelicTagRule#metric_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "metric_enabled">]
        member _.MetricEnabled(state: NewRelicTagRuleState<'MonitorId>, value: bool) : NewRelicTagRuleState<'MonitorId> =
            state.assignments.Add(fun config -> config.MetricEnabled <- value)
            state : NewRelicTagRuleState<'MonitorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule#metric_enabled-1">NewRelicTagRule#metric_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "metric_enabled">]
        member _.MetricEnabled(state: NewRelicTagRuleState<'MonitorId>, value: HashiCorp.Cdktf.IResolvable) : NewRelicTagRuleState<'MonitorId> =
            state.assignments.Add(fun config -> config.MetricEnabled <- value)
            state : NewRelicTagRuleState<'MonitorId>

        /// <summary>
        /// metric_tag_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule#metric_tag_filter-1">NewRelicTagRule#metric_tag_filter</a> Accepts: azurerm.IResolvable | azurerm.NewRelicTagRule.NewRelicTagRuleMetricTagFilter[]
        /// </summary>
        [<CustomOperation "metric_tag_filter">]
        member _.MetricTagFilter(state: NewRelicTagRuleState<'MonitorId>, value: HashiCorp.Cdktf.IResolvable) : NewRelicTagRuleState<'MonitorId> =
            state.assignments.Add(fun config -> config.MetricTagFilter <- value)
            state : NewRelicTagRuleState<'MonitorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule#subscription_log_enabled-1">NewRelicTagRule#subscription_log_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "subscription_log_enabled">]
        member _.SubscriptionLogEnabled(state: NewRelicTagRuleState<'MonitorId>, value: bool) : NewRelicTagRuleState<'MonitorId> =
            state.assignments.Add(fun config -> config.SubscriptionLogEnabled <- value)
            state : NewRelicTagRuleState<'MonitorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule#subscription_log_enabled-1">NewRelicTagRule#subscription_log_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "subscription_log_enabled">]
        member _.SubscriptionLogEnabled(state: NewRelicTagRuleState<'MonitorId>, value: HashiCorp.Cdktf.IResolvable) : NewRelicTagRuleState<'MonitorId> =
            state.assignments.Add(fun config -> config.SubscriptionLogEnabled <- value)
            state : NewRelicTagRuleState<'MonitorId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_tag_rule#timeouts-1">NewRelicTagRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NewRelicTagRuleState<'MonitorId>, value: azurerm.NewRelicTagRule.NewRelicTagRuleTimeouts) : NewRelicTagRuleState<'MonitorId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NewRelicTagRuleState<'MonitorId>

        member _.Run(state: NewRelicTagRuleState<Present>) : azurerm.NewRelicTagRule.NewRelicTagRule =
            let config = azurerm.NewRelicTagRule.NewRelicTagRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.NewRelicTagRule.NewRelicTagRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.newRelicTagRule: missing required arguments. Must call: monitor_id.", 9999, IsError = true)>]
        member _.Run(_: NewRelicTagRuleState<_>) : azurerm.NewRelicTagRule.NewRelicTagRule =
            Unchecked.defaultof<azurerm.NewRelicTagRule.NewRelicTagRule>
