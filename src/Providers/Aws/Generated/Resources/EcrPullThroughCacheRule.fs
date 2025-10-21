namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, 'UpstreamRegistryUrl> = { assignments: ResizeArray<aws.EcrPullThroughCacheRule.EcrPullThroughCacheRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_pull_through_cache_rule">aws_ecr_pull_through_cache_rule</a>.
    /// </summary>
    type EcrPullThroughCacheRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcrPullThroughCacheRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcrPullThroughCacheRuleState<Missing, Missing>)

        member _.Zero(()) : EcrPullThroughCacheRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcrPullThroughCacheRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_pull_through_cache_rule#ecr_repository_prefix-1">EcrPullThroughCacheRule#ecr_repository_prefix</a>.
        /// </summary>
        [<CustomOperation "ecr_repository_prefix">]
        member _.EcrRepositoryPrefix(state: EcrPullThroughCacheRuleState<Missing, 'UpstreamRegistryUrl>, value: string) : EcrPullThroughCacheRuleState<Present, 'UpstreamRegistryUrl> =
            state.assignments.Add(fun config -> config.EcrRepositoryPrefix <- value)
            ({ assignments = state.assignments } : EcrPullThroughCacheRuleState<Present, 'UpstreamRegistryUrl>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_pull_through_cache_rule#upstream_registry_url-1">EcrPullThroughCacheRule#upstream_registry_url</a>.
        /// </summary>
        [<CustomOperation "upstream_registry_url">]
        member _.UpstreamRegistryUrl(state: EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, Missing>, value: string) : EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, Present> =
            state.assignments.Add(fun config -> config.UpstreamRegistryUrl <- value)
            ({ assignments = state.assignments } : EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_pull_through_cache_rule#credential_arn-1">EcrPullThroughCacheRule#credential_arn</a>.
        /// </summary>
        [<CustomOperation "credential_arn">]
        member _.CredentialArn(state: EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, 'UpstreamRegistryUrl>, value: string) : EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, 'UpstreamRegistryUrl> =
            state.assignments.Add(fun config -> config.CredentialArn <- value)
            state : EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, 'UpstreamRegistryUrl>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_pull_through_cache_rule#custom_role_arn-1">EcrPullThroughCacheRule#custom_role_arn</a>.
        /// </summary>
        [<CustomOperation "custom_role_arn">]
        member _.CustomRoleArn(state: EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, 'UpstreamRegistryUrl>, value: string) : EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, 'UpstreamRegistryUrl> =
            state.assignments.Add(fun config -> config.CustomRoleArn <- value)
            state : EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, 'UpstreamRegistryUrl>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_pull_through_cache_rule#id-1">EcrPullThroughCacheRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, 'UpstreamRegistryUrl>, value: string) : EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, 'UpstreamRegistryUrl> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, 'UpstreamRegistryUrl>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_pull_through_cache_rule#upstream_repository_prefix-1">EcrPullThroughCacheRule#upstream_repository_prefix</a>.
        /// </summary>
        [<CustomOperation "upstream_repository_prefix">]
        member _.UpstreamRepositoryPrefix(state: EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, 'UpstreamRegistryUrl>, value: string) : EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, 'UpstreamRegistryUrl> =
            state.assignments.Add(fun config -> config.UpstreamRepositoryPrefix <- value)
            state : EcrPullThroughCacheRuleState<'EcrRepositoryPrefix, 'UpstreamRegistryUrl>

        member _.Run(state: EcrPullThroughCacheRuleState<Present, Present>) : aws.EcrPullThroughCacheRule.EcrPullThroughCacheRule =
            let config = aws.EcrPullThroughCacheRule.EcrPullThroughCacheRuleConfig()
            for setter in state.assignments do
                setter config
            aws.EcrPullThroughCacheRule.EcrPullThroughCacheRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecrPullThroughCacheRule: missing required arguments. Must call: ecr_repository_prefix, upstream_registry_url.", 9999, IsError = true)>]
        member _.Run(_: EcrPullThroughCacheRuleState<_, _>) : aws.EcrPullThroughCacheRule.EcrPullThroughCacheRule =
            Unchecked.defaultof<aws.EcrPullThroughCacheRule.EcrPullThroughCacheRule>
