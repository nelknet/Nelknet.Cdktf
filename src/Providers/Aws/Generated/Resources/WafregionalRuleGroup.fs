namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafregionalRuleGroupState<'MetricName, 'Name> = { assignments: ResizeArray<aws.WafregionalRuleGroup.WafregionalRuleGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule_group">aws_wafregional_rule_group</a>.
    /// </summary>
    type WafregionalRuleGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafregionalRuleGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WafregionalRuleGroupState<Missing, Missing>)

        member _.Zero(()) : WafregionalRuleGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WafregionalRuleGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule_group#metric_name-1">WafregionalRuleGroup#metric_name</a>.
        /// </summary>
        [<CustomOperation "metric_name">]
        member _.MetricName(state: WafregionalRuleGroupState<Missing, 'Name>, value: string) : WafregionalRuleGroupState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MetricName <- value)
            ({ assignments = state.assignments } : WafregionalRuleGroupState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule_group#name-1">WafregionalRuleGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafregionalRuleGroupState<'MetricName, Missing>, value: string) : WafregionalRuleGroupState<'MetricName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafregionalRuleGroupState<'MetricName, Present>)

        /// <summary>
        /// activated_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule_group#activated_rule-1">WafregionalRuleGroup#activated_rule</a> Accepts: aws.IResolvable | aws.WafregionalRuleGroup.WafregionalRuleGroupActivatedRule[]
        /// </summary>
        [<CustomOperation "activated_rule">]
        member _.ActivatedRule(state: WafregionalRuleGroupState<'MetricName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : WafregionalRuleGroupState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.ActivatedRule <- value)
            state : WafregionalRuleGroupState<'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule_group#id-1">WafregionalRuleGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafregionalRuleGroupState<'MetricName, 'Name>, value: string) : WafregionalRuleGroupState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafregionalRuleGroupState<'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule_group#tags-1">WafregionalRuleGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WafregionalRuleGroupState<'MetricName, 'Name>, value: seq<string * string>) : WafregionalRuleGroupState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WafregionalRuleGroupState<'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_rule_group#tags_all-1">WafregionalRuleGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: WafregionalRuleGroupState<'MetricName, 'Name>, value: seq<string * string>) : WafregionalRuleGroupState<'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : WafregionalRuleGroupState<'MetricName, 'Name>

        member _.Run(state: WafregionalRuleGroupState<Present, Present>) : aws.WafregionalRuleGroup.WafregionalRuleGroup =
            let config = aws.WafregionalRuleGroup.WafregionalRuleGroupConfig()
            for setter in state.assignments do
                setter config
            aws.WafregionalRuleGroup.WafregionalRuleGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafregionalRuleGroup: missing required arguments. Must call: metric_name, name.", 9999, IsError = true)>]
        member _.Run(_: WafregionalRuleGroupState<_, _>) : aws.WafregionalRuleGroup.WafregionalRuleGroup =
            Unchecked.defaultof<aws.WafregionalRuleGroup.WafregionalRuleGroup>
