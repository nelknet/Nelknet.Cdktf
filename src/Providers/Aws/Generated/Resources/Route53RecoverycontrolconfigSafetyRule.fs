namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, 'WaitPeriodMs> = { assignments: ResizeArray<aws.Route53RecoverycontrolconfigSafetyRule.Route53RecoverycontrolconfigSafetyRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_safety_rule">aws_route53recoverycontrolconfig_safety_rule</a>.
    /// </summary>
    type Route53RecoverycontrolconfigSafetyRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53RecoverycontrolconfigSafetyRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53RecoverycontrolconfigSafetyRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Route53RecoverycontrolconfigSafetyRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53RecoverycontrolconfigSafetyRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_safety_rule#control_panel_arn-1">Route53RecoverycontrolconfigSafetyRule#control_panel_arn</a>.
        /// </summary>
        [<CustomOperation "control_panel_arn">]
        member _.ControlPanelArn(state: Route53RecoverycontrolconfigSafetyRuleState<Missing, 'Name, 'RuleConfig, 'WaitPeriodMs>, value: string) : Route53RecoverycontrolconfigSafetyRuleState<Present, 'Name, 'RuleConfig, 'WaitPeriodMs> =
            state.assignments.Add(fun config -> config.ControlPanelArn <- value)
            ({ assignments = state.assignments } : Route53RecoverycontrolconfigSafetyRuleState<Present, 'Name, 'RuleConfig, 'WaitPeriodMs>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_safety_rule#name-1">Route53RecoverycontrolconfigSafetyRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, Missing, 'RuleConfig, 'WaitPeriodMs>, value: string) : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, Present, 'RuleConfig, 'WaitPeriodMs> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, Present, 'RuleConfig, 'WaitPeriodMs>)

        /// <summary>
        /// rule_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_safety_rule#rule_config-1">Route53RecoverycontrolconfigSafetyRule#rule_config</a>
        /// </summary>
        [<CustomOperation "rule_config">]
        member _.RuleConfig(state: Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, Missing, 'WaitPeriodMs>, value: aws.Route53RecoverycontrolconfigSafetyRule.Route53RecoverycontrolconfigSafetyRuleRuleConfig) : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, Present, 'WaitPeriodMs> =
            state.assignments.Add(fun config -> config.RuleConfig <- value)
            ({ assignments = state.assignments } : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, Present, 'WaitPeriodMs>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_safety_rule#wait_period_ms-1">Route53RecoverycontrolconfigSafetyRule#wait_period_ms</a>.
        /// </summary>
        [<CustomOperation "wait_period_ms">]
        member _.WaitPeriodMs(state: Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, Missing>, value: double) : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, Present> =
            state.assignments.Add(fun config -> config.WaitPeriodMs <- value)
            ({ assignments = state.assignments } : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_safety_rule#asserted_controls-1">Route53RecoverycontrolconfigSafetyRule#asserted_controls</a>.
        /// </summary>
        [<CustomOperation "asserted_controls">]
        member _.AssertedControls(state: Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, 'WaitPeriodMs>, value: seq<string>) : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, 'WaitPeriodMs> =
            state.assignments.Add(fun config -> config.AssertedControls <- (value |> Seq.toArray))
            state : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, 'WaitPeriodMs>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_safety_rule#gating_controls-1">Route53RecoverycontrolconfigSafetyRule#gating_controls</a>.
        /// </summary>
        [<CustomOperation "gating_controls">]
        member _.GatingControls(state: Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, 'WaitPeriodMs>, value: seq<string>) : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, 'WaitPeriodMs> =
            state.assignments.Add(fun config -> config.GatingControls <- (value |> Seq.toArray))
            state : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, 'WaitPeriodMs>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_safety_rule#id-1">Route53RecoverycontrolconfigSafetyRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, 'WaitPeriodMs>, value: string) : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, 'WaitPeriodMs> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, 'WaitPeriodMs>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoverycontrolconfig_safety_rule#target_controls-1">Route53RecoverycontrolconfigSafetyRule#target_controls</a>.
        /// </summary>
        [<CustomOperation "target_controls">]
        member _.TargetControls(state: Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, 'WaitPeriodMs>, value: seq<string>) : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, 'WaitPeriodMs> =
            state.assignments.Add(fun config -> config.TargetControls <- (value |> Seq.toArray))
            state : Route53RecoverycontrolconfigSafetyRuleState<'ControlPanelArn, 'Name, 'RuleConfig, 'WaitPeriodMs>

        member _.Run(state: Route53RecoverycontrolconfigSafetyRuleState<Present, Present, Present, Present>) : aws.Route53RecoverycontrolconfigSafetyRule.Route53RecoverycontrolconfigSafetyRule =
            let config = aws.Route53RecoverycontrolconfigSafetyRule.Route53RecoverycontrolconfigSafetyRuleConfig()
            for setter in state.assignments do
                setter config
            aws.Route53RecoverycontrolconfigSafetyRule.Route53RecoverycontrolconfigSafetyRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53RecoverycontrolconfigSafetyRule: missing required arguments. Must call: control_panel_arn, name, rule_config, wait_period_ms.", 9999, IsError = true)>]
        member _.Run(_: Route53RecoverycontrolconfigSafetyRuleState<_, _, _, _>) : aws.Route53RecoverycontrolconfigSafetyRule.Route53RecoverycontrolconfigSafetyRule =
            Unchecked.defaultof<aws.Route53RecoverycontrolconfigSafetyRule.Route53RecoverycontrolconfigSafetyRule>
