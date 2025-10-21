namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes> = { assignments: ResizeArray<azurerm.MonitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group">azurerm_monitor_alert_processing_rule_action_group</a>.
    /// </summary>
    type MonitorAlertProcessingRuleActionGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorAlertProcessingRuleActionGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorAlertProcessingRuleActionGroupState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MonitorAlertProcessingRuleActionGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorAlertProcessingRuleActionGroupState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#add_action_group_ids-1">MonitorAlertProcessingRuleActionGroup#add_action_group_ids</a>.
        /// </summary>
        [<CustomOperation "add_action_group_ids">]
        member _.AddActionGroupIds(state: MonitorAlertProcessingRuleActionGroupState<Missing, 'Name, 'ResourceGroupName, 'Scopes>, value: seq<string>) : MonitorAlertProcessingRuleActionGroupState<Present, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.AddActionGroupIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MonitorAlertProcessingRuleActionGroupState<Present, 'Name, 'ResourceGroupName, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#name-1">MonitorAlertProcessingRuleActionGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, Missing, 'ResourceGroupName, 'Scopes>, value: string) : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, Present, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, Present, 'ResourceGroupName, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#resource_group_name-1">MonitorAlertProcessingRuleActionGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, Missing, 'Scopes>, value: string) : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, Present, 'Scopes> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, Present, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#scopes-1">MonitorAlertProcessingRuleActionGroup#scopes</a>.
        /// </summary>
        [<CustomOperation "scopes">]
        member _.Scopes(state: MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, Missing>, value: seq<string>) : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Scopes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// condition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#condition-1">MonitorAlertProcessingRuleActionGroup#condition</a>
        /// </summary>
        [<CustomOperation "condition">]
        member _.Condition(state: MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>, value: azurerm.MonitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupCondition) : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Condition <- value)
            state : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#description-1">MonitorAlertProcessingRuleActionGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>, value: string) : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#enabled-1">MonitorAlertProcessingRuleActionGroup#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>, value: bool) : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#enabled-1">MonitorAlertProcessingRuleActionGroup#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>, value: HashiCorp.Cdktf.IResolvable) : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#id-1">MonitorAlertProcessingRuleActionGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>, value: string) : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#schedule-1">MonitorAlertProcessingRuleActionGroup#schedule</a>
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>, value: azurerm.MonitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupSchedule) : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            state : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#tags-1">MonitorAlertProcessingRuleActionGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>, value: seq<string * string>) : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#timeouts-1">MonitorAlertProcessingRuleActionGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>, value: azurerm.MonitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupTimeouts) : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorAlertProcessingRuleActionGroupState<'AddActionGroupIds, 'Name, 'ResourceGroupName, 'Scopes>

        member _.Run(state: MonitorAlertProcessingRuleActionGroupState<Present, Present, Present, Present>) : azurerm.MonitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroup =
            let config = azurerm.MonitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorAlertProcessingRuleActionGroup: missing required arguments. Must call: add_action_group_ids, name, resource_group_name, scopes.", 9999, IsError = true)>]
        member _.Run(_: MonitorAlertProcessingRuleActionGroupState<_, _, _, _>) : azurerm.MonitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroup =
            Unchecked.defaultof<azurerm.MonitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroup>
