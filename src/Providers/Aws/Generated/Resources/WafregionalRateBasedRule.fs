namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit> = { assignments: ResizeArray<aws.WafregionalRateBasedRule.WafregionalRateBasedRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rate_based_rule">aws_wafregional_rate_based_rule</a>.
    /// </summary>
    type WafregionalRateBasedRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafregionalRateBasedRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WafregionalRateBasedRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WafregionalRateBasedRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WafregionalRateBasedRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rate_based_rule#metric_name-1">WafregionalRateBasedRule#metric_name</a>.
        /// </summary>
        [<CustomOperation "metric_name">]
        member _.MetricName(state: WafregionalRateBasedRuleState<Missing, 'Name, 'RateKey, 'RateLimit>, value: string) : WafregionalRateBasedRuleState<Present, 'Name, 'RateKey, 'RateLimit> =
            state.assignments.Add(fun config -> config.MetricName <- value)
            ({ assignments = state.assignments } : WafregionalRateBasedRuleState<Present, 'Name, 'RateKey, 'RateLimit>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rate_based_rule#name-1">WafregionalRateBasedRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafregionalRateBasedRuleState<'MetricName, Missing, 'RateKey, 'RateLimit>, value: string) : WafregionalRateBasedRuleState<'MetricName, Present, 'RateKey, 'RateLimit> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafregionalRateBasedRuleState<'MetricName, Present, 'RateKey, 'RateLimit>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rate_based_rule#rate_key-1">WafregionalRateBasedRule#rate_key</a>.
        /// </summary>
        [<CustomOperation "rate_key">]
        member _.RateKey(state: WafregionalRateBasedRuleState<'MetricName, 'Name, Missing, 'RateLimit>, value: string) : WafregionalRateBasedRuleState<'MetricName, 'Name, Present, 'RateLimit> =
            state.assignments.Add(fun config -> config.RateKey <- value)
            ({ assignments = state.assignments } : WafregionalRateBasedRuleState<'MetricName, 'Name, Present, 'RateLimit>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rate_based_rule#rate_limit-1">WafregionalRateBasedRule#rate_limit</a>.
        /// </summary>
        [<CustomOperation "rate_limit">]
        member _.RateLimit(state: WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, Missing>, value: double) : WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, Present> =
            state.assignments.Add(fun config -> config.RateLimit <- value)
            ({ assignments = state.assignments } : WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rate_based_rule#id-1">WafregionalRateBasedRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>, value: string) : WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>

        /// <summary>
        /// predicate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rate_based_rule#predicate-1">WafregionalRateBasedRule#predicate</a> Accepts: aws.IResolvable | aws.WafregionalRateBasedRule.WafregionalRateBasedRulePredicate[]
        /// </summary>
        [<CustomOperation "predicate">]
        member _.Predicate(state: WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>, value: HashiCorp.Cdktf.IResolvable) : WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit> =
            state.assignments.Add(fun config -> config.Predicate <- value)
            state : WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rate_based_rule#tags-1">WafregionalRateBasedRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>, value: seq<string * string>) : WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rate_based_rule#tags_all-1">WafregionalRateBasedRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>, value: seq<string * string>) : WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : WafregionalRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>

        member _.Run(state: WafregionalRateBasedRuleState<Present, Present, Present, Present>) : aws.WafregionalRateBasedRule.WafregionalRateBasedRule =
            let config = aws.WafregionalRateBasedRule.WafregionalRateBasedRuleConfig()
            for setter in state.assignments do
                setter config
            aws.WafregionalRateBasedRule.WafregionalRateBasedRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafregionalRateBasedRule: missing required arguments. Must call: metric_name, name, rate_key, rate_limit.", 9999, IsError = true)>]
        member _.Run(_: WafregionalRateBasedRuleState<_, _, _, _>) : aws.WafregionalRateBasedRule.WafregionalRateBasedRule =
            Unchecked.defaultof<aws.WafregionalRateBasedRule.WafregionalRateBasedRule>
