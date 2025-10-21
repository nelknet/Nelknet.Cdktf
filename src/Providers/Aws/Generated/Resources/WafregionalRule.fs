namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafregionalRuleState<'MetricName, 'Name> = { assignments: ResizeArray<aws.WafregionalRule.WafregionalRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule">aws_wafregional_rule</a>.
    /// </summary>
    type WafregionalRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafregionalRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WafregionalRuleState<Missing, Missing>)

        member _.Zero(()) : WafregionalRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WafregionalRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule#metric_name-1">WafregionalRule#metric_name</a>.
        /// </summary>
        [<CustomOperation "metric_name">]
        member _.MetricName(state: WafregionalRuleState<Missing, 'Name>, value: string) : WafregionalRuleState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MetricName <- value)
            ({ assignments = state.assignments } : WafregionalRuleState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule#name-1">WafregionalRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafregionalRuleState<'MetricName, Missing>, value: string) : WafregionalRuleState<'MetricName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafregionalRuleState<'MetricName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule#id-1">WafregionalRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafregionalRuleState<'MetricName, 'Name>, value: string) : WafregionalRuleState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafregionalRuleState<'MetricName, 'Name>

        /// <summary>
        /// predicate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule#predicate-1">WafregionalRule#predicate</a> Accepts: aws.IResolvable | aws.WafregionalRule.WafregionalRulePredicate[]
        /// </summary>
        [<CustomOperation "predicate">]
        member _.Predicate(state: WafregionalRuleState<'MetricName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : WafregionalRuleState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Predicate <- value)
            state : WafregionalRuleState<'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule#tags-1">WafregionalRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WafregionalRuleState<'MetricName, 'Name>, value: seq<string * string>) : WafregionalRuleState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WafregionalRuleState<'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule#tags_all-1">WafregionalRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: WafregionalRuleState<'MetricName, 'Name>, value: seq<string * string>) : WafregionalRuleState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : WafregionalRuleState<'MetricName, 'Name>

        member _.Run(state: WafregionalRuleState<Present, Present>) : aws.WafregionalRule.WafregionalRule =
            let config = aws.WafregionalRule.WafregionalRuleConfig()
            for setter in state.assignments do
                setter config
            aws.WafregionalRule.WafregionalRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafregionalRule: missing required arguments. Must call: metric_name, name.", 9999, IsError = true)>]
        member _.Run(_: WafregionalRuleState<_, _>) : aws.WafregionalRule.WafregionalRule =
            Unchecked.defaultof<aws.WafregionalRule.WafregionalRule>
