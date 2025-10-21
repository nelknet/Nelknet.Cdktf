namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafRuleState<'MetricName, 'Name> = { assignments: ResizeArray<aws.WafRule.WafRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule">aws_waf_rule</a>.
    /// </summary>
    type WafRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WafRuleState<Missing, Missing>)

        member _.Zero(()) : WafRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WafRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule#metric_name-1">WafRule#metric_name</a>.
        /// </summary>
        [<CustomOperation "metric_name">]
        member _.MetricName(state: WafRuleState<Missing, 'Name>, value: string) : WafRuleState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MetricName <- value)
            ({ assignments = state.assignments } : WafRuleState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule#name-1">WafRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafRuleState<'MetricName, Missing>, value: string) : WafRuleState<'MetricName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafRuleState<'MetricName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule#id-1">WafRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafRuleState<'MetricName, 'Name>, value: string) : WafRuleState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafRuleState<'MetricName, 'Name>

        /// <summary>
        /// predicates block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule#predicates-1">WafRule#predicates</a> Accepts: aws.IResolvable | aws.WafRule.WafRulePredicates[]
        /// </summary>
        [<CustomOperation "predicates">]
        member _.Predicates(state: WafRuleState<'MetricName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : WafRuleState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Predicates <- value)
            state : WafRuleState<'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule#tags-1">WafRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WafRuleState<'MetricName, 'Name>, value: seq<string * string>) : WafRuleState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WafRuleState<'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule#tags_all-1">WafRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: WafRuleState<'MetricName, 'Name>, value: seq<string * string>) : WafRuleState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : WafRuleState<'MetricName, 'Name>

        member _.Run(state: WafRuleState<Present, Present>) : aws.WafRule.WafRule =
            let config = aws.WafRule.WafRuleConfig()
            for setter in state.assignments do
                setter config
            aws.WafRule.WafRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafRule: missing required arguments. Must call: metric_name, name.", 9999, IsError = true)>]
        member _.Run(_: WafRuleState<_, _>) : aws.WafRule.WafRule =
            Unchecked.defaultof<aws.WafRule.WafRule>
