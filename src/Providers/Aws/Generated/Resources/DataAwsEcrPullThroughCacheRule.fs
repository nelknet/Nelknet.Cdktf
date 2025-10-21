namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcrPullThroughCacheRuleState<'EcrRepositoryPrefix> = { assignments: ResizeArray<aws.DataAwsEcrPullThroughCacheRule.DataAwsEcrPullThroughCacheRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_pull_through_cache_rule">aws_ecr_pull_through_cache_rule</a>.
    /// </summary>
    type DataAwsEcrPullThroughCacheRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcrPullThroughCacheRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcrPullThroughCacheRuleState<Missing>)

        member _.Zero(()) : DataAwsEcrPullThroughCacheRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcrPullThroughCacheRuleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_pull_through_cache_rule#ecr_repository_prefix-1">DataAwsEcrPullThroughCacheRule#ecr_repository_prefix</a>.
        /// </summary>
        [<CustomOperation "ecr_repository_prefix">]
        member _.EcrRepositoryPrefix(state: DataAwsEcrPullThroughCacheRuleState<Missing>, value: string) : DataAwsEcrPullThroughCacheRuleState<Present> =
            state.assignments.Add(fun config -> config.EcrRepositoryPrefix <- value)
            ({ assignments = state.assignments } : DataAwsEcrPullThroughCacheRuleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_pull_through_cache_rule#id-1">DataAwsEcrPullThroughCacheRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEcrPullThroughCacheRuleState<'EcrRepositoryPrefix>, value: string) : DataAwsEcrPullThroughCacheRuleState<'EcrRepositoryPrefix> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEcrPullThroughCacheRuleState<'EcrRepositoryPrefix>

        member _.Run(state: DataAwsEcrPullThroughCacheRuleState<Present>) : aws.DataAwsEcrPullThroughCacheRule.DataAwsEcrPullThroughCacheRule =
            let config = aws.DataAwsEcrPullThroughCacheRule.DataAwsEcrPullThroughCacheRuleConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcrPullThroughCacheRule.DataAwsEcrPullThroughCacheRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEcrPullThroughCacheRule: missing required arguments. Must call: ecr_repository_prefix.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEcrPullThroughCacheRuleState<_>) : aws.DataAwsEcrPullThroughCacheRule.DataAwsEcrPullThroughCacheRule =
            Unchecked.defaultof<aws.DataAwsEcrPullThroughCacheRule.DataAwsEcrPullThroughCacheRule>
