namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafRuleGroupState<'MetricName, 'Name> = { assignments: ResizeArray<aws.WafRuleGroup.WafRuleGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule_group">aws_waf_rule_group</a>.
    /// </summary>
    type WafRuleGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafRuleGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WafRuleGroupState<Missing, Missing>)

        member _.Zero(()) : WafRuleGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WafRuleGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule_group#metric_name-1">WafRuleGroup#metric_name</a>.
        /// </summary>
        [<CustomOperation "metric_name">]
        member _.MetricName(state: WafRuleGroupState<Missing, 'Name>, value: string) : WafRuleGroupState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MetricName <- value)
            ({ assignments = state.assignments } : WafRuleGroupState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule_group#name-1">WafRuleGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafRuleGroupState<'MetricName, Missing>, value: string) : WafRuleGroupState<'MetricName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafRuleGroupState<'MetricName, Present>)

        /// <summary>
        /// activated_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule_group#activated_rule-1">WafRuleGroup#activated_rule</a> Accepts: aws.IResolvable | aws.WafRuleGroup.WafRuleGroupActivatedRule[]
        /// </summary>
        [<CustomOperation "activated_rule">]
        member _.ActivatedRule(state: WafRuleGroupState<'MetricName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : WafRuleGroupState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.ActivatedRule <- value)
            state : WafRuleGroupState<'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule_group#id-1">WafRuleGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafRuleGroupState<'MetricName, 'Name>, value: string) : WafRuleGroupState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafRuleGroupState<'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule_group#tags-1">WafRuleGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WafRuleGroupState<'MetricName, 'Name>, value: seq<string * string>) : WafRuleGroupState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WafRuleGroupState<'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_rule_group#tags_all-1">WafRuleGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: WafRuleGroupState<'MetricName, 'Name>, value: seq<string * string>) : WafRuleGroupState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : WafRuleGroupState<'MetricName, 'Name>

        member _.Run(state: WafRuleGroupState<Present, Present>) : aws.WafRuleGroup.WafRuleGroup =
            let config = aws.WafRuleGroup.WafRuleGroupConfig()
            for setter in state.assignments do
                setter config
            aws.WafRuleGroup.WafRuleGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafRuleGroup: missing required arguments. Must call: metric_name, name.", 9999, IsError = true)>]
        member _.Run(_: WafRuleGroupState<_, _>) : aws.WafRuleGroup.WafRuleGroup =
            Unchecked.defaultof<aws.WafRuleGroup.WafRuleGroup>
