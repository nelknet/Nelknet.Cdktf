namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchContributorManagedInsightRuleState<'ResourceArn, 'TemplateName> = { assignments: ResizeArray<aws.CloudwatchContributorManagedInsightRule.CloudwatchContributorManagedInsightRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_contributor_managed_insight_rule">aws_cloudwatch_contributor_managed_insight_rule</a>.
    /// </summary>
    type CloudwatchContributorManagedInsightRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchContributorManagedInsightRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchContributorManagedInsightRuleState<Missing, Missing>)

        member _.Zero(()) : CloudwatchContributorManagedInsightRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchContributorManagedInsightRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_contributor_managed_insight_rule#resource_arn-1">CloudwatchContributorManagedInsightRule#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: CloudwatchContributorManagedInsightRuleState<Missing, 'TemplateName>, value: string) : CloudwatchContributorManagedInsightRuleState<Present, 'TemplateName> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : CloudwatchContributorManagedInsightRuleState<Present, 'TemplateName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_contributor_managed_insight_rule#template_name-1">CloudwatchContributorManagedInsightRule#template_name</a>.
        /// </summary>
        [<CustomOperation "template_name">]
        member _.TemplateName(state: CloudwatchContributorManagedInsightRuleState<'ResourceArn, Missing>, value: string) : CloudwatchContributorManagedInsightRuleState<'ResourceArn, Present> =
            state.assignments.Add(fun config -> config.TemplateName <- value)
            ({ assignments = state.assignments } : CloudwatchContributorManagedInsightRuleState<'ResourceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_contributor_managed_insight_rule#state-1">CloudwatchContributorManagedInsightRule#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: CloudwatchContributorManagedInsightRuleState<'ResourceArn, 'TemplateName>, value: string) : CloudwatchContributorManagedInsightRuleState<'ResourceArn, 'TemplateName> =
            state.assignments.Add(fun config -> config.State <- value)
            state : CloudwatchContributorManagedInsightRuleState<'ResourceArn, 'TemplateName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_contributor_managed_insight_rule#tags-1">CloudwatchContributorManagedInsightRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudwatchContributorManagedInsightRuleState<'ResourceArn, 'TemplateName>, value: seq<string * string>) : CloudwatchContributorManagedInsightRuleState<'ResourceArn, 'TemplateName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudwatchContributorManagedInsightRuleState<'ResourceArn, 'TemplateName>

        member _.Run(state: CloudwatchContributorManagedInsightRuleState<Present, Present>) : aws.CloudwatchContributorManagedInsightRule.CloudwatchContributorManagedInsightRule =
            let config = aws.CloudwatchContributorManagedInsightRule.CloudwatchContributorManagedInsightRuleConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchContributorManagedInsightRule.CloudwatchContributorManagedInsightRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchContributorManagedInsightRule: missing required arguments. Must call: resource_arn, template_name.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchContributorManagedInsightRuleState<_, _>) : aws.CloudwatchContributorManagedInsightRule.CloudwatchContributorManagedInsightRule =
            Unchecked.defaultof<aws.CloudwatchContributorManagedInsightRule.CloudwatchContributorManagedInsightRule>
