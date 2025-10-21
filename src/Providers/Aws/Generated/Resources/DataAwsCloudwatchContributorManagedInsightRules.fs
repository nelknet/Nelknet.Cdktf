namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudwatchContributorManagedInsightRulesState<'ResourceArn> = { assignments: ResizeArray<aws.DataAwsCloudwatchContributorManagedInsightRules.DataAwsCloudwatchContributorManagedInsightRulesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_contributor_managed_insight_rules">aws_cloudwatch_contributor_managed_insight_rules</a>.
    /// </summary>
    type DataAwsCloudwatchContributorManagedInsightRulesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudwatchContributorManagedInsightRulesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudwatchContributorManagedInsightRulesState<Missing>)

        member _.Zero(()) : DataAwsCloudwatchContributorManagedInsightRulesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudwatchContributorManagedInsightRulesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_contributor_managed_insight_rules#resource_arn-1">DataAwsCloudwatchContributorManagedInsightRules#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: DataAwsCloudwatchContributorManagedInsightRulesState<Missing>, value: string) : DataAwsCloudwatchContributorManagedInsightRulesState<Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : DataAwsCloudwatchContributorManagedInsightRulesState<Present>)

        member _.Run(state: DataAwsCloudwatchContributorManagedInsightRulesState<Present>) : aws.DataAwsCloudwatchContributorManagedInsightRules.DataAwsCloudwatchContributorManagedInsightRules =
            let config = aws.DataAwsCloudwatchContributorManagedInsightRules.DataAwsCloudwatchContributorManagedInsightRulesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudwatchContributorManagedInsightRules.DataAwsCloudwatchContributorManagedInsightRules(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCloudwatchContributorManagedInsightRules: missing required arguments. Must call: resource_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCloudwatchContributorManagedInsightRulesState<_>) : aws.DataAwsCloudwatchContributorManagedInsightRules.DataAwsCloudwatchContributorManagedInsightRules =
            Unchecked.defaultof<aws.DataAwsCloudwatchContributorManagedInsightRules.DataAwsCloudwatchContributorManagedInsightRules>
