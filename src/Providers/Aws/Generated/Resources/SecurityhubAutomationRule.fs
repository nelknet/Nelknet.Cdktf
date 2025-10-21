namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder> = { assignments: ResizeArray<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule">aws_securityhub_automation_rule</a>.
    /// </summary>
    type SecurityhubAutomationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubAutomationRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubAutomationRuleState<Missing, Missing, Missing>)

        member _.Zero(()) : SecurityhubAutomationRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubAutomationRuleState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#description-1">SecurityhubAutomationRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SecurityhubAutomationRuleState<Missing, 'RuleName, 'RuleOrder>, value: string) : SecurityhubAutomationRuleState<Present, 'RuleName, 'RuleOrder> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : SecurityhubAutomationRuleState<Present, 'RuleName, 'RuleOrder>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#rule_name-1">SecurityhubAutomationRule#rule_name</a>.
        /// </summary>
        [<CustomOperation "rule_name">]
        member _.RuleName(state: SecurityhubAutomationRuleState<'Description, Missing, 'RuleOrder>, value: string) : SecurityhubAutomationRuleState<'Description, Present, 'RuleOrder> =
            state.assignments.Add(fun config -> config.RuleName <- value)
            ({ assignments = state.assignments } : SecurityhubAutomationRuleState<'Description, Present, 'RuleOrder>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#rule_order-1">SecurityhubAutomationRule#rule_order</a>.
        /// </summary>
        [<CustomOperation "rule_order">]
        member _.RuleOrder(state: SecurityhubAutomationRuleState<'Description, 'RuleName, Missing>, value: double) : SecurityhubAutomationRuleState<'Description, 'RuleName, Present> =
            state.assignments.Add(fun config -> config.RuleOrder <- value)
            ({ assignments = state.assignments } : SecurityhubAutomationRuleState<'Description, 'RuleName, Present>)

        /// <summary>
        /// actions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#actions-1">SecurityhubAutomationRule#actions</a> Accepts: aws.IResolvable | aws.SecurityhubAutomationRule.SecurityhubAutomationRuleActions[]
        /// </summary>
        [<CustomOperation "actions">]
        member _.Actions(state: SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder>, value: HashiCorp.Cdktf.IResolvable) : SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder> =
            state.assignments.Add(fun config -> config.Actions <- value)
            state : SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder>

        /// <summary>
        /// criteria block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#criteria-1">SecurityhubAutomationRule#criteria</a> Accepts: aws.IResolvable | aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteria[]
        /// </summary>
        [<CustomOperation "criteria">]
        member _.Criteria(state: SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder>, value: HashiCorp.Cdktf.IResolvable) : SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder> =
            state.assignments.Add(fun config -> config.Criteria <- value)
            state : SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#is_terminal-1">SecurityhubAutomationRule#is_terminal</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_terminal">]
        member _.IsTerminal(state: SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder>, value: bool) : SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder> =
            state.assignments.Add(fun config -> config.IsTerminal <- value)
            state : SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#is_terminal-1">SecurityhubAutomationRule#is_terminal</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_terminal">]
        member _.IsTerminal(state: SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder>, value: HashiCorp.Cdktf.IResolvable) : SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder> =
            state.assignments.Add(fun config -> config.IsTerminal <- value)
            state : SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#rule_status-1">SecurityhubAutomationRule#rule_status</a>.
        /// </summary>
        [<CustomOperation "rule_status">]
        member _.RuleStatus(state: SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder>, value: string) : SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder> =
            state.assignments.Add(fun config -> config.RuleStatus <- value)
            state : SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#tags-1">SecurityhubAutomationRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder>, value: seq<string * string>) : SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SecurityhubAutomationRuleState<'Description, 'RuleName, 'RuleOrder>

        member _.Run(state: SecurityhubAutomationRuleState<Present, Present, Present>) : aws.SecurityhubAutomationRule.SecurityhubAutomationRule =
            let config = aws.SecurityhubAutomationRule.SecurityhubAutomationRuleConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubAutomationRule.SecurityhubAutomationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubAutomationRule: missing required arguments. Must call: description, rule_name, rule_order.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubAutomationRuleState<_, _, _>) : aws.SecurityhubAutomationRule.SecurityhubAutomationRule =
            Unchecked.defaultof<aws.SecurityhubAutomationRule.SecurityhubAutomationRule>
