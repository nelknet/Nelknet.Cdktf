namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWafSubscribedRuleGroupState = { assignments: ResizeArray<aws.DataAwsWafSubscribedRuleGroup.DataAwsWafSubscribedRuleGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/waf_subscribed_rule_group">aws_waf_subscribed_rule_group</a>.
    /// </summary>
    type DataAwsWafSubscribedRuleGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWafSubscribedRuleGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsWafSubscribedRuleGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/waf_subscribed_rule_group#id-1">DataAwsWafSubscribedRuleGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWafSubscribedRuleGroupState, value: string) : DataAwsWafSubscribedRuleGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWafSubscribedRuleGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/waf_subscribed_rule_group#metric_name-1">DataAwsWafSubscribedRuleGroup#metric_name</a>.
        /// </summary>
        [<CustomOperation "metric_name">]
        member _.MetricName(state: DataAwsWafSubscribedRuleGroupState, value: string) : DataAwsWafSubscribedRuleGroupState =
            state.assignments.Add(fun config -> config.MetricName <- value)
            state : DataAwsWafSubscribedRuleGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/waf_subscribed_rule_group#name-1">DataAwsWafSubscribedRuleGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsWafSubscribedRuleGroupState, value: string) : DataAwsWafSubscribedRuleGroupState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsWafSubscribedRuleGroupState

        member _.Run(state: DataAwsWafSubscribedRuleGroupState) : aws.DataAwsWafSubscribedRuleGroup.DataAwsWafSubscribedRuleGroup =
            let config = aws.DataAwsWafSubscribedRuleGroup.DataAwsWafSubscribedRuleGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWafSubscribedRuleGroup.DataAwsWafSubscribedRuleGroup(StackContext.get (), logicalId, config)
