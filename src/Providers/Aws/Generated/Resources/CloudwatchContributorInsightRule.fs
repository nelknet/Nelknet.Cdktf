namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchContributorInsightRuleState<'RuleDefinition, 'RuleName> = { assignments: ResizeArray<aws.CloudwatchContributorInsightRule.CloudwatchContributorInsightRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_contributor_insight_rule">aws_cloudwatch_contributor_insight_rule</a>.
    /// </summary>
    type CloudwatchContributorInsightRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchContributorInsightRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchContributorInsightRuleState<Missing, Missing>)

        member _.Zero(()) : CloudwatchContributorInsightRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchContributorInsightRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_contributor_insight_rule#rule_definition-1">CloudwatchContributorInsightRule#rule_definition</a>.
        /// </summary>
        [<CustomOperation "rule_definition">]
        member _.RuleDefinition(state: CloudwatchContributorInsightRuleState<Missing, 'RuleName>, value: string) : CloudwatchContributorInsightRuleState<Present, 'RuleName> =
            state.assignments.Add(fun config -> config.RuleDefinition <- value)
            ({ assignments = state.assignments } : CloudwatchContributorInsightRuleState<Present, 'RuleName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_contributor_insight_rule#rule_name-1">CloudwatchContributorInsightRule#rule_name</a>.
        /// </summary>
        [<CustomOperation "rule_name">]
        member _.RuleName(state: CloudwatchContributorInsightRuleState<'RuleDefinition, Missing>, value: string) : CloudwatchContributorInsightRuleState<'RuleDefinition, Present> =
            state.assignments.Add(fun config -> config.RuleName <- value)
            ({ assignments = state.assignments } : CloudwatchContributorInsightRuleState<'RuleDefinition, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_contributor_insight_rule#rule_state-1">CloudwatchContributorInsightRule#rule_state</a>.
        /// </summary>
        [<CustomOperation "rule_state">]
        member _.RuleState(state: CloudwatchContributorInsightRuleState<'RuleDefinition, 'RuleName>, value: string) : CloudwatchContributorInsightRuleState<'RuleDefinition, 'RuleName> =
            state.assignments.Add(fun config -> config.RuleState <- value)
            state : CloudwatchContributorInsightRuleState<'RuleDefinition, 'RuleName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_contributor_insight_rule#tags-1">CloudwatchContributorInsightRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudwatchContributorInsightRuleState<'RuleDefinition, 'RuleName>, value: seq<string * string>) : CloudwatchContributorInsightRuleState<'RuleDefinition, 'RuleName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudwatchContributorInsightRuleState<'RuleDefinition, 'RuleName>

        member _.Run(state: CloudwatchContributorInsightRuleState<Present, Present>) : aws.CloudwatchContributorInsightRule.CloudwatchContributorInsightRule =
            let config = aws.CloudwatchContributorInsightRule.CloudwatchContributorInsightRuleConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchContributorInsightRule.CloudwatchContributorInsightRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchContributorInsightRule: missing required arguments. Must call: rule_definition, rule_name.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchContributorInsightRuleState<_, _>) : aws.CloudwatchContributorInsightRule.CloudwatchContributorInsightRule =
            Unchecked.defaultof<aws.CloudwatchContributorInsightRule.CloudwatchContributorInsightRule>
