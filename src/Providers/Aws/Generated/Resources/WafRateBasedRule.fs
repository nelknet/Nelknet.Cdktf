namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit> = { assignments: ResizeArray<aws.WafRateBasedRule.WafRateBasedRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rate_based_rule">aws_waf_rate_based_rule</a>.
    /// </summary>
    type WafRateBasedRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafRateBasedRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WafRateBasedRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WafRateBasedRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WafRateBasedRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rate_based_rule#metric_name-1">WafRateBasedRule#metric_name</a>.
        /// </summary>
        [<CustomOperation "metric_name">]
        member _.MetricName(state: WafRateBasedRuleState<Missing, 'Name, 'RateKey, 'RateLimit>, value: string) : WafRateBasedRuleState<Present, 'Name, 'RateKey, 'RateLimit> =
            state.assignments.Add(fun config -> config.MetricName <- value)
            ({ assignments = state.assignments } : WafRateBasedRuleState<Present, 'Name, 'RateKey, 'RateLimit>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rate_based_rule#name-1">WafRateBasedRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafRateBasedRuleState<'MetricName, Missing, 'RateKey, 'RateLimit>, value: string) : WafRateBasedRuleState<'MetricName, Present, 'RateKey, 'RateLimit> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafRateBasedRuleState<'MetricName, Present, 'RateKey, 'RateLimit>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rate_based_rule#rate_key-1">WafRateBasedRule#rate_key</a>.
        /// </summary>
        [<CustomOperation "rate_key">]
        member _.RateKey(state: WafRateBasedRuleState<'MetricName, 'Name, Missing, 'RateLimit>, value: string) : WafRateBasedRuleState<'MetricName, 'Name, Present, 'RateLimit> =
            state.assignments.Add(fun config -> config.RateKey <- value)
            ({ assignments = state.assignments } : WafRateBasedRuleState<'MetricName, 'Name, Present, 'RateLimit>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rate_based_rule#rate_limit-1">WafRateBasedRule#rate_limit</a>.
        /// </summary>
        [<CustomOperation "rate_limit">]
        member _.RateLimit(state: WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, Missing>, value: double) : WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, Present> =
            state.assignments.Add(fun config -> config.RateLimit <- value)
            ({ assignments = state.assignments } : WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rate_based_rule#id-1">WafRateBasedRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>, value: string) : WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>

        /// <summary>
        /// predicates block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rate_based_rule#predicates-1">WafRateBasedRule#predicates</a> Accepts: aws.IResolvable | aws.WafRateBasedRule.WafRateBasedRulePredicates[]
        /// </summary>
        [<CustomOperation "predicates">]
        member _.Predicates(state: WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>, value: HashiCorp.Cdktf.IResolvable) : WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit> =
            state.assignments.Add(fun config -> config.Predicates <- value)
            state : WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rate_based_rule#tags-1">WafRateBasedRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>, value: seq<string * string>) : WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rate_based_rule#tags_all-1">WafRateBasedRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>, value: seq<string * string>) : WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : WafRateBasedRuleState<'MetricName, 'Name, 'RateKey, 'RateLimit>

        member _.Run(state: WafRateBasedRuleState<Present, Present, Present, Present>) : aws.WafRateBasedRule.WafRateBasedRule =
            let config = aws.WafRateBasedRule.WafRateBasedRuleConfig()
            for setter in state.assignments do
                setter config
            aws.WafRateBasedRule.WafRateBasedRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafRateBasedRule: missing required arguments. Must call: metric_name, name, rate_key, rate_limit.", 9999, IsError = true)>]
        member _.Run(_: WafRateBasedRuleState<_, _, _, _>) : aws.WafRateBasedRule.WafRateBasedRule =
            Unchecked.defaultof<aws.WafRateBasedRule.WafRateBasedRule>
